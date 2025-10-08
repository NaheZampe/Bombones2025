using Bombones2025.Entidades.DTOs.Ciudad;
using Bombones2025.Entidades.DTOs.Cliente;
using Bombones2025.Entidades.DTOs.Pais;
using Bombones2025.Entidades.DTOs.ProvinciaEstado;
using Bombones2025.Servicios.Interfaces;
using Bombones2025.Servicios.Servicios;
using Bombones2025.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025.Windows
{
    public partial class FrmClientesAE : Form
    {
        private ClienteEditDto clienteEditDto;
        private readonly ICiudadServicio _ciudadServicio;
        private readonly IProvinciaEstadoServicio _provinciaServicio;
        private readonly IPaisServicio _paisServicio;
        private PaisListDto? paisSeleccionado;
        private ProvinciaEstadoListDto? provinciaSeleccionada;
        public FrmClientesAE(ICiudadServicio ciudadServicio, IProvinciaEstadoServicio provinciaServicio, IPaisServicio paisServicio)
        {
            _ciudadServicio = ciudadServicio;
            _provinciaServicio = provinciaServicio;
            _paisServicio = paisServicio;

            InitializeComponent();

        }

        private void CargarDatos()
        {
            txtNombre.Text = clienteEditDto.Nombre;
            txtApellido.Text = clienteEditDto.Apellido;
            txtDireccion.Text = clienteEditDto.Direccion;
            txtMail.Text = clienteEditDto.Email;
            txtTelefono.Text = clienteEditDto.Telefono;
            if (clienteEditDto.AutorizadoCuentaCorriente) rbSiAC.Checked = true;
            else rbNoAC.Checked = true;
            txtSaldo.Text = clienteEditDto.SaldoCuentaCorriente.ToString();

            var ciudad = _ciudadServicio.ObtenerPorId(clienteEditDto.CiudadId);
            var provincia = _provinciaServicio.ObtenerPorId(ciudad!.ProvinciaEstadoId);
            cboPais.SelectedValue = provincia!.PaisId;
            CombosHelper.CargarComboProvincias(ref CboProvEstados,
                provincia.PaisId, _provinciaServicio);
            CboProvEstados.SelectedValue = provincia.ProvinciaEstadoId;
            CombosHelper.CargarComboCiudades(ref cboCiudad,
                ciudad.ProvinciaEstadoId, _ciudadServicio);
            cboCiudad.SelectedValue = ciudad.CiudadId;

        }

        internal void SetCliente(ClienteEditDto cEditDto)
        {
            clienteEditDto = cEditDto;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CombosHelper.CargarComboPaises(ref cboPais, _paisServicio);
            if (clienteEditDto is not null)
            {
                CargarDatos();
            }
            else
            {
                rbNoAC.Checked = true;
                txtSaldo.Text = "0";
                cboPais.SelectedIndex = 0;

                if (cboPais.SelectedIndex==0)
                {
                    CboProvEstados.Enabled= false;
                    CboProvEstados.DataSource= null;
                }
                if (CboProvEstados.DataSource==null)
                {
                    cboCiudad.Enabled= false;
                }

            }
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPais.SelectedIndex > 0)
            {
                CboProvEstados.Enabled = true;
                paisSeleccionado = (PaisListDto)cboPais.SelectedItem!;
                CombosHelper.CargarComboProvincias(ref CboProvEstados,
                    paisSeleccionado.PaisId, _provinciaServicio);
            }
            else
            {
                paisSeleccionado = null;
                CboProvEstados.Enabled = false;
                CboProvEstados.DataSource = null;
                cboCiudad.Enabled = false;
            }
        }

        private void CboProvEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboProvEstados.SelectedIndex > 0)
            {
                cboCiudad.Enabled = true;
                provinciaSeleccionada = (ProvinciaEstadoListDto)CboProvEstados.SelectedItem!;
                CombosHelper.CargarComboCiudades(ref cboCiudad,
                    provinciaSeleccionada.ProvinciaEstadoId, _ciudadServicio);
            }
            else
            {
                provinciaSeleccionada = null;
                cboCiudad.DataSource = null;
            }
        }
        internal ClienteEditDto GetCliente()
        {
            return clienteEditDto;
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (clienteEditDto == null)
                {
                    clienteEditDto = new ClienteEditDto();
                    clienteEditDto.ClienteId = 0;
                    clienteEditDto.Nombre = txtNombre.Text;
                    clienteEditDto.Apellido = txtApellido.Text;
                    clienteEditDto.Direccion = txtDireccion.Text;
                    clienteEditDto.Email = txtMail.Text;
                    clienteEditDto.Telefono = txtTelefono.Text;
                    if (rbSiAC.Checked) clienteEditDto.AutorizadoCuentaCorriente = true;
                    else clienteEditDto.AutorizadoCuentaCorriente = false;
                    clienteEditDto.SaldoCuentaCorriente = Convert.ToDecimal(txtSaldo.Text);
                    var ciudad = (CiudadListDto)cboCiudad.SelectedItem!;
                    clienteEditDto.CiudadId = ciudad.CiudadId;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    clienteEditDto.Nombre = txtNombre.Text;
                    clienteEditDto.Apellido = txtApellido.Text;
                    clienteEditDto.Direccion = txtDireccion.Text;
                    clienteEditDto.Email = txtMail.Text;
                    clienteEditDto.Telefono = txtTelefono.Text;
                    if (rbSiAC.Checked) clienteEditDto.AutorizadoCuentaCorriente = true;
                    else clienteEditDto.AutorizadoCuentaCorriente = false;
                    clienteEditDto.SaldoCuentaCorriente = Convert.ToDecimal(txtSaldo.Text);
                    var ciudad = (CiudadListDto)cboCiudad.SelectedItem!;
                    clienteEditDto.CiudadId = ciudad.CiudadId;
                    DialogResult = DialogResult.OK;
                } 
            }
        }

        private bool ValidarDatos()
        { 
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "El Nombre es requerido");
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "El Apellido es requerido");
            }
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                valido = false;
                errorProvider1.SetError(txtMail, "El Mail es requerido");
            }
            if (cboPais.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboPais, "Debe seleccionar un País");
            }
            if (CboProvEstados.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CboProvEstados, "Debe seleccionar una Provincia");
            }
            if (cboCiudad.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboCiudad, "Debe seleccionar una Ciudad");
            }
            if (string.IsNullOrWhiteSpace(txtSaldo.Text))
            {
                valido = false;
                errorProvider1.SetError(txtSaldo, "El Saldo es requerido");
            }
            else
            {
                try
                {
                    Convert.ToDecimal(txtSaldo.Text);
                }
                catch (Exception)
                {
                    valido = false;
                    errorProvider1.SetError(txtSaldo, "El Saldo debe ser un valor numérico");
                }
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                valido = false;
                errorProvider1.SetError(txtTelefono, "El Teléfono es requerido");
            }else
            {
                string telefono = txtTelefono.Text.Trim();
                var formato = new Regex(@"^\+?[0-9]{6,15}$");

                if (!formato.IsMatch(telefono))
                {
                    valido = false;
                    errorProvider1.SetError(txtTelefono, "El Teléfono debe contener solo números y puede empezar con +");
                }
            }
            return valido;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
