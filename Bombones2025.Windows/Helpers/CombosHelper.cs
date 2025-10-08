using Bombones2025.Entidades.DTOs.Ciudad;
using Bombones2025.Entidades.DTOs.Pais;
using Bombones2025.Entidades.DTOs.ProvinciaEstado;
using Bombones2025.Entidades.Entidades;
using Bombones2025.Servicios.Interfaces;

namespace Bombones2025.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboPaises(ref ComboBox cbo, IPaisServicio paisServicio)
        {
            var listaPaises = paisServicio.ObtenerLista();
            var defaultPais = new PaisListDto
            {
                PaisId = 0,
                NombrePais = "Seleccione País"
            };
            listaPaises.Insert(0, defaultPais);
            cbo.DataSource = listaPaises;
            cbo.DisplayMember = "NombrePais";
            cbo.ValueMember = "PaisId";
            cbo.SelectedIndex = 0;
        }
        public static void CargarComboProvincias(ref ComboBox cbo, int paisId, IProvinciaEstadoServicio provinciaServicio)
        {
            var listaProvincias = provinciaServicio.ObtenerLista(paisId);
            var defaultProvincia = new ProvinciaEstadoListDto
            {
                ProvinciaEstadoId = 0,
                NombreProvinciaEstado = "Seleccione Provincia"
            };
            listaProvincias.Insert(0, defaultProvincia);
            cbo.DataSource = listaProvincias;
            cbo.DisplayMember = "NombreProvinciaEstado";
            cbo.ValueMember = "ProvinciaEstadoId";
            cbo.SelectedIndex = 0;
        }

        internal static void CargarComboCiudades(ref ComboBox cboCiudad, int IdProv, ICiudadServicio ciudadServicio)
        {
            var listaCiudades = ciudadServicio.ObtenerLista(null,IdProv);
            var defaultCiudad = new CiudadListDto
            {
                CiudadId = 0,
                NombreCiudad = "Seleccione Ciudad"
            };
            listaCiudades.Insert(0, defaultCiudad);
            cboCiudad.DataSource = listaCiudades;
            cboCiudad.DisplayMember = "NombreCiudad";
            cboCiudad.ValueMember = "CiudadId";
            cboCiudad.SelectedIndex = 0;
        }
    }
}
