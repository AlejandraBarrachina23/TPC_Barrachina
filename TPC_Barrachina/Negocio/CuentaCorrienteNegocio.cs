using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class CuentaCorrienteNegocio

    {

        private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
        public void AgregarCuentaCorriente(CuentaCorriente unaCuentaCorriente)
        {

            AccederDatos.DefinirTipoComando(("INSERT INTO CuentaCorrientes (Saldo)" +
                 "VALUES ('" +unaCuentaCorriente.Saldo+ "')"));
            AccederDatos.AbrirConexion();
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
        }

        public int ContarFilasCuentaCorriente() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT COUNT (CodigoCuentaCorriente) FROM CuentaCorrientes");
            return AccederDatos.ejecutarAccionReturn();
        }
    }
}
