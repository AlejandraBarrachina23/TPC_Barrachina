﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class CuentaCorrienteNegocio

    {

        private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
        public void AgregarCuentaCorriente(CuentaCorriente unaCuentaCorriente)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando(("INSERT INTO CuentaCorrientes(Saldo) VALUES ('" +unaCuentaCorriente.Saldo+ "')"));
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public int ContarFilasCuentaCorriente() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT COUNT (CodigoCuentaCorriente) FROM CuentaCorrientes");
            int total = AccederDatos.ejecutarAccionReturn();
            AccederDatos.CerrarConexion();
            return total+1;

        }

        public void EliminarCuentaCorriente(CuentaCorriente unaCuentaCorriente)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE CuentaCorrientes SET Estado = 0 WHERE CodigoCuentaCorriente =" + unaCuentaCorriente.CodigoCuentaCorriente);
            AccederDatos.EjecutarAccion();
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

        public void ModificarCuentaCorriente(CuentaCorriente unaCuentaCorriente) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE CuentaCorrientes SET LimiteCuenta=@LimiteCuenta WHERE CodigoCuentaCorriente = " + unaCuentaCorriente.CodigoCuentaCorriente);
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@LimiteCuenta", unaCuentaCorriente.LimiteCuenta);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public CuentaCorriente CargarCuentaCorriente(TextBox tboxLimitecuenta, int CodigoCuentaCorriente) {

            CuentaCorriente unaNuevaCuenteCorriente = new CuentaCorriente();
            unaNuevaCuenteCorriente.CodigoCuentaCorriente = CodigoCuentaCorriente;
            unaNuevaCuenteCorriente.LimiteCuenta = Convert.ToDecimal(tboxLimitecuenta.Text);
            return unaNuevaCuenteCorriente;
        }

        
    }
}
