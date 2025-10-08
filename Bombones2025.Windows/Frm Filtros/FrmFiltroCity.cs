using Bombones2025.Entidades.DTOs.Ciudad;
using Bombones2025.Entidades.DTOs.Pais;
using Bombones2025.Entidades.DTOs.ProvinciaEstado;
using Bombones2025.Servicios.Interfaces;
using Bombones2025.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025.Windows.Frm_Filtros
{
    public partial class FrmFiltroCity : Form
    {
        private ProvinciaEstadoListDto? provinciaSeleccionada;
        private PaisListDto? paisSeleccionado;
        private CiudadListDto? ciudadSeleccionada;
        private readonly IPaisServicio _paisServicio;
        private readonly IProvinciaEstadoServicio _provinciaEstadoServicio;
        private readonly ICiudadServicio _ciudadServicio;

        public FrmFiltroCity(IPaisServicio paisServicio, IProvinciaEstadoServicio provinciaServicio, ICiudadServicio ciudadServicio)
        {
            _paisServicio = paisServicio;
            _provinciaEstadoServicio = provinciaServicio;
            _ciudadServicio = ciudadServicio;
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboPaises.SelectedIndex > 0)
            {
                paisSeleccionado = (PaisListDto)CboPaises.SelectedItem!;
                CombosHelper.CargarComboProvincias(ref CboProvEstados,
                    paisSeleccionado.PaisId, _provinciaEstadoServicio);
            }
            else
            {
                /*
                 * Si no hay país seleccionado se tiene que 
                 * limpiar el combo de provincias!!!
                 */
                paisSeleccionado = null;
                CboProvEstados.DataSource = null;
            }

        }

        private void FrmFiltroCity_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboPaises(ref CboPaises, _paisServicio);

        }

        private void CboProvEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboProvEstados.SelectedIndex > 0)
            {
                provinciaSeleccionada = (ProvinciaEstadoListDto)CboProvEstados.SelectedItem!;
                CombosHelper.CargarComboCiudades(ref CboCiudad,
                    provinciaSeleccionada.ProvinciaEstadoId, _ciudadServicio);
            }
            else
            {
                provinciaSeleccionada = null;
                CboCiudad.DataSource = null;
            }

        }

        private void CboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCiudad.SelectedIndex > 0)
            {
                ciudadSeleccionada = (CiudadListDto)CboCiudad.SelectedItem!;
            }
            else
            {
                ciudadSeleccionada = null;
            }
        }

        public CiudadListDto GetCiudad()
        {
            return ciudadSeleccionada!;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (CboPaises.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CboPaises, "Debe seleccionar un país");
            }
            if (CboProvEstados.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CboProvEstados, "Debe seleccionar un estado");
            }
            return valido;

        }

        private void BtnOK_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
