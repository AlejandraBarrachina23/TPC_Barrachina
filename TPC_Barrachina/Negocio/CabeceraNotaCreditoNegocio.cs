using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class CabeceraNotaCreditoNegocio
    {
        public int CuentaFilasCabeceraNotaCredito()
        {
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT COUNT (NumeroNotaCredito) FROM NotaDevolucion");
            int NumeroNotaDevolucion = AccederDatos.ejecutarAccionReturn();
            AccederDatos.CerrarConexion();
            return NumeroNotaDevolucion;
        }
    }
}
