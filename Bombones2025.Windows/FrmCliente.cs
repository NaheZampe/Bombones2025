using AutoMapper;
using Bombones2025.Entidades.DTOs.Cliente;
using Bombones2025.Entidades.DTOs.ProvinciaEstado;
using Bombones2025.Servicios.Interfaces;
using Bombones2025.Windows.Frm_Filtros;
using Bombones2025.Windows.Helpers;

namespace Bombones2025.Windows
{
    public partial class FrmCliente : Form
    {
        private readonly IMapper _mapper;
        private readonly IClienteServicio _clienteServicio;
        private readonly ICiudadServicio _ciudadServicio;
        private readonly IProvinciaEstadoServicio _provinciaServicio;
        private readonly IPaisServicio _paisServicio;
        private bool _filtroActivo = false;

        public FrmCliente(IMapper mapper, IClienteServicio clienteServicio, ICiudadServicio ciudadServicio, IProvinciaEstadoServicio provinciaServicio, IPaisServicio paisServicio)
        {
            _mapper = mapper;
            _ciudadServicio = ciudadServicio;
            _provinciaServicio = provinciaServicio;
            _paisServicio = paisServicio;
            _clienteServicio = clienteServicio;
            InitializeComponent();
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            GridHelper.MostrarDatosEnGrilla(dgvDatos, _clienteServicio.GetLista());
            lblCant.Text = _clienteServicio.GetCantidad().ToString();
        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            var c = r.Tag as ClienteListDto;
            if (c is null) return;
            DialogResult dr = MessageBox.Show($"¿Desea borrar el registro de {c.Nombre + " " + c.Apellido}?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (_clienteServicio.Borrar(c.ClienteId, out var errores))
                {
                    GridHelper.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Registro Borrado", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errores.First(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            var c = r.Tag as ClienteListDto;
            if (c is null) return;
            var cEditDto = _clienteServicio.GetClientePorId(c.ClienteId);
            FrmClientesAE frm = new FrmClientesAE(_ciudadServicio, _provinciaServicio, _paisServicio) { Text = "Editar Cliente" };
            frm.SetCliente(cEditDto);
            DialogResult dr = frm.ShowDialog(this);
            ClienteEditDto clienteEditado = new();
            if (dr == DialogResult.OK)
            {
                clienteEditado = frm.GetCliente();
            }
            try
            {
                if (!_clienteServicio.Existe(clienteEditado))
                {
                    if (_clienteServicio.Guardar(clienteEditado))
                    {
                        var clienteListDto = _mapper.Map<ClienteListDto>(cEditDto);
                        var ciudad = _ciudadServicio.ObtenerPorId(cEditDto.CiudadId);
                        clienteListDto.NombreCiudad = ciudad!.NombreCiudad;
                        GridHelper.SetearFila(r, clienteListDto);
                        MessageBox.Show("Registro Editado", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Registro Duplicado", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmClientesAE frm = new FrmClientesAE(_ciudadServicio, _provinciaServicio, _paisServicio) { Text = "Agregar Cliente" };
            DialogResult dr = frm.ShowDialog(this);
            ClienteEditDto clienteEditDto = new();
            if (dr == DialogResult.OK)
            {
                clienteEditDto = frm.GetCliente();
            }
            try
            {
                if (clienteEditDto is null) return;
                if (!_clienteServicio.Existe(clienteEditDto))
                {
                    if (_clienteServicio.Guardar(clienteEditDto))
                    {
                        //Tengo que generar un ClienteListDto para mostrarlo en la grilla
                        ClienteListDto clienteListDto = _mapper.Map<ClienteListDto>(clienteEditDto);
                        //Tengo que obtener los datos que me faltan!!!
                        var ciudadDto = _ciudadServicio.ObtenerPorId(clienteEditDto.CiudadId);
                        clienteListDto.NombreCiudad = ciudadDto!.NombreCiudad;
                        //Joya ya tengo todos los datos... ahora lo muestro
                        DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                        GridHelper.SetearFila(r, clienteListDto!);
                        GridHelper.AgregarFila(r, dgvDatos);
                        MessageBox.Show("Registro Agregado", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Registro Duplicado", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new();
            var frm = new FrmFiltro();
            dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                _filtroActivo = true;
                TsbFiltrar.BackColor = Color.LightBlue;
                TsbFiltrar.Enabled = false;
                string? texto = frm.GetTexto();
                if (string.IsNullOrWhiteSpace(texto))
                {
                    GridHelper.LimpiarGrilla(dgvDatos);
                    GridHelper.MostrarDatosEnGrilla(dgvDatos, _clienteServicio.GetLista());
                }
                else
                {
                    var lista = _clienteServicio.GetLista(texto);
                    GridHelper.LimpiarGrilla(dgvDatos);
                    if (lista.Count > 0)
                    {
                        GridHelper.MostrarDatosEnGrilla(dgvDatos, lista);
                        lblCant.Text = lista.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No hay registros para mostrar", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TsbActualizar_Click(object sender, EventArgs e)
        {
            _filtroActivo = false;
            TsbFiltrar.BackColor = Color.Empty;
            TsbFiltrar.Enabled = true;
            GridHelper.LimpiarGrilla(dgvDatos);
            GridHelper.MostrarDatosEnGrilla(dgvDatos, _clienteServicio.GetLista());
            lblCant.Text = _clienteServicio.GetCantidad().ToString();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new();
            var frm = new FrmFiltroPorPais(_paisServicio);
            dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                _filtroActivo = true;
                TsbFiltrar.BackColor = Color.LightBlue;
                TsbFiltrar.Enabled = false;
                var pais = frm.GetPais();
                if (pais is null)
                {
                    GridHelper.LimpiarGrilla(dgvDatos);
                    GridHelper.MostrarDatosEnGrilla(dgvDatos, _clienteServicio.GetLista());
                }
                else
                {
                    var lista = _clienteServicio.GetLista(null, null, null, pais.PaisId);
                    GridHelper.LimpiarGrilla(dgvDatos);
                    if (lista.Count > 0)
                    {
                        GridHelper.MostrarDatosEnGrilla(dgvDatos, lista);
                        lblCant.Text = lista.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No hay registros para mostrar", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void provEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new();
            var frm = new FrmProvinciaFiltro(_paisServicio, _provinciaServicio);
            dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                _filtroActivo = true;
                TsbFiltrar.BackColor = Color.LightBlue;
                TsbFiltrar.Enabled = false;
                var provincia = frm.GetProvincia();
                if (provincia is null)
                {
                    GridHelper.LimpiarGrilla(dgvDatos);
                    GridHelper.MostrarDatosEnGrilla(dgvDatos, _clienteServicio.GetLista());
                }
                else
                {
                    var lista = _clienteServicio.GetLista(null, null, provincia.ProvinciaEstadoId);
                    GridHelper.LimpiarGrilla(dgvDatos);
                    if (lista.Count > 0)
                    {
                        GridHelper.MostrarDatosEnGrilla(dgvDatos, lista);
                        lblCant.Text = lista.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No hay registros para mostrar", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new();
            var frm = new FrmFiltroCity(_paisServicio, _provinciaServicio, _ciudadServicio);
            dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                _filtroActivo = true;
                TsbFiltrar.BackColor = Color.LightBlue;
                TsbFiltrar.Enabled = false;
                var ciudad = frm.GetCiudad();
                if (ciudad is null)
                {
                    GridHelper.LimpiarGrilla(dgvDatos);
                    GridHelper.MostrarDatosEnGrilla(dgvDatos, _clienteServicio.GetLista());
                }
                else
                {
                    var lista = _clienteServicio.GetLista(null, ciudad.CiudadId);
                    GridHelper.LimpiarGrilla(dgvDatos);
                    if (lista.Count > 0)
                    {
                        GridHelper.MostrarDatosEnGrilla(dgvDatos, lista);
                        lblCant.Text = lista.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No hay registros para mostrar", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

