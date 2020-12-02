using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsTesting.Models
{
	public class Cliente
	{
		public int idCliente { get; set; }
		public string Nombre { get; set; }
		public string Apellidos { get; set; }
		public string TelefonoCasa { get; set; }
		public string TelefonoCasa2 { get; set; }
		public string TelefonoCelular { get; set; }
		public string TelefonoCelular2 { get; set; }
		public string CorreoElectronico { get; set; }
		public string CorreoElectronico2 { get; set; }
		public string DireccionCalle { get; set; }
		public string DireccionNumeroExt { get; set; }
		public string DireccionNumeroint { get; set; }
		public string DireccionColonia { get; set; }
		public int direccionpais_idDireccionPais { get; set; }
		public int direccionestado_idEstado { get; set; }
		public int direccionciudad_idCiudad { get; set; }
		public string DireccionCP { get; set; }
		public bool Habilitado { get; set; }
	}
}
