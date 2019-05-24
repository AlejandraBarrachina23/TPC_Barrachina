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

            AccederDatos.DefinirTipoComando(("INSERT INTO CuentaCorrientes(Saldo)" +
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



        public void EliminarCuentaCorriente(int CodigoCuentaCorriente)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE CuentaCorrientes SET Estado = 0 WHERE CodigoCuentaCorriente =" + CodigoCuentaCorriente);
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarConexion();

        }

        public CuentaCorriente BusquedaCuentaCorriente(string NombreColumna, string ParametroBusqueda) {

            CuentaCorriente unaCuentaCorriente = new CuentaCorriente();
            string Consulta = "select * from CuentaCorrientes where " + NombreColumna + " = " + ParametroBusqueda;
            AccederDatos.DefinirTipoComando(Consulta);
            AccederDatos.AbrirConexion();
            AccederDatos.EjecutarConsulta();
            
            while (AccederDatos.LectorDatos.Read())
            {
               
                unaCuentaCorriente.CodigoCuentaCorriente = (int)AccederDatos.LectorDatos["CodigoCuentaCorriente"];
                unaCuentaCorriente.LimiteCuenta = (decimal)AccederDatos.LectorDatos["LimiteCuenta"];
                unaCuentaCorriente.Saldo = (decimal)AccederDatos.LectorDatos["Saldo"];
                unaCuentaCorriente.Estado = (bool)AccederDatos.LectorDatos["Estado"];
            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return unaCuentaCorriente;
        }
    }
}
