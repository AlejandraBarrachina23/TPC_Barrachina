﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class CabeceraVentaNegocio
    {
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public void AgregarCabeceraVenta(CabeceraVenta unaNuevaCabeceraVenta) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Ventas (Usuario,Cliente,Total,MetodoPago,Fecha) VALUES ('" + unaNuevaCabeceraVenta.Usuario.CodigoUsuario + "','" + unaNuevaCabeceraVenta.Cliente.CodigoCliente + "','" +
            unaNuevaCabeceraVenta.Total + "','" + unaNuevaCabeceraVenta.MetodoPago + "','" + unaNuevaCabeceraVenta.FechaEmision + "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public int CuentaFilasCabeceraVenta() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT COUNT (NumeroVenta) FROM Ventas");
            int NumeroVenta = AccederDatos.ejecutarAccionReturn() + 1;
            AccederDatos.CerrarConexion();
            return NumeroVenta;
        }

        public decimal TotalVentasDelDia() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT SUM(total) from Ventas where Fecha ='" + DateTime.Now.ToShortDateString() + "'");
            decimal TotalVentas = AccederDatos.ejecutarAccionReturnDouble();
            AccederDatos.CerrarConexion();
            return TotalVentas;
        }

        public int CantidadVentasDelDia()
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT count(total) from Ventas where Fecha ='" + DateTime.Now.ToShortDateString() + "'");
            int CantidadVentas = AccederDatos.ejecutarAccionReturn();
            AccederDatos.CerrarConexion();
            return CantidadVentas;
        }

        public decimal GananciaDelDia() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("Select SUM((PrecioVentaMinorista*Unidad + PrecioVentaMayorista*Bulto*CantidadxBulto)-(PrecioCosto*(Unidad+Bulto*CantidadxBulto)))from DetalleVentas inner join Ventas on Ventas.NumeroVenta = DetalleVentas.NumeroFactura where Fecha ='" + DateTime.Now.ToShortDateString() + "'");
            decimal TotalGanancia = AccederDatos.ejecutarAccionReturnDouble();
            AccederDatos.CerrarConexion();
            return TotalGanancia;
        }

        public decimal RecaudacionPorTipoProducto(int CodigoTipoProducto) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("Select SUM((DetalleVentas.PrecioVentaMinorista * Unidad + DetalleVentas.PrecioVentaMayorista * Bulto * DetalleVentas.CantidadxBulto) - (DetalleVentas.PrecioCosto * (Unidad + Bulto * DetalleVentas.CantidadxBulto)))from DetalleVentas inner join Ventas" +
              " on Ventas.NumeroVenta = DetalleVentas.NumeroFactura INNER JOIN Productos on Productos.CodigoProducto = DetalleVentas.CodigoProducto where Fecha ='" + DateTime.Now.ToShortDateString() + "' AND Productos.CodigoTipoProducto = '"+CodigoTipoProducto+"'");
            decimal TotalRedaudacionCigarrillos = AccederDatos.ejecutarAccionReturnDouble();
            AccederDatos.CerrarConexion();
            return TotalRedaudacionCigarrillos;
        }

        public decimal RecaudacionVarios() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("Select SUM((DetalleVentas.PrecioVentaMinorista * Unidad + DetalleVentas.PrecioVentaMayorista * Bulto * DetalleVentas.CantidadxBulto) - (DetalleVentas.PrecioCosto * (Unidad + Bulto * DetalleVentas.CantidadxBulto)))from DetalleVentas inner join Ventas" +
              " on Ventas.NumeroVenta = DetalleVentas.NumeroFactura INNER JOIN Productos on Productos.CodigoProducto = DetalleVentas.CodigoProducto where Fecha ='" + DateTime.Now.ToShortDateString() + "' AND Productos.CodigoTipoProducto != '3' AND Productos.CodigoTipoProducto != '7'");
            decimal TotalRedaudacionCigarrillos = AccederDatos.ejecutarAccionReturnDouble();
            AccederDatos.CerrarConexion();
            return TotalRedaudacionCigarrillos;

        }

        public CabeceraVenta CargarCabeceraVenta(Usuario UsuarioActivo,Cliente unCliente,string FechaEmision, decimal TotalFactura, string MetodoPago) {

            CabeceraVenta unaCabeceraVenta = new CabeceraVenta();
            ClienteNegocio unClienteNegocio = new ClienteNegocio();
            unaCabeceraVenta.Usuario = new Usuario();
            unaCabeceraVenta.Cliente = new Cliente();
            
            unaCabeceraVenta.Usuario = UsuarioActivo;
            unaCabeceraVenta.FechaEmision = FechaEmision;
            unaCabeceraVenta.Total = TotalFactura;
            unaCabeceraVenta.MetodoPago = MetodoPago;

            if (unCliente != null)
            {
                unCliente = unClienteNegocio.CargaCuentaCorriente("CtaCorriente", MetodoPago, unCliente, TotalFactura, "Venta");
                unaCabeceraVenta.Cliente.CodigoCliente = unCliente.CodigoCliente;
           
            }

            return unaCabeceraVenta;

        }

        public List<CabeceraVenta> ListarVentas() {

            List<CabeceraVenta> ListadoVentas = new List<CabeceraVenta>();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("Select * from Ventas INNER JOIN Usuarios ON Usuarios.CodigoUsuario = Ventas.Usuario INNER JOIN Clientes ON Ventas.Cliente = Clientes.CodigoCliente");
            AccederDatos.EjecutarConsulta();
            while (AccederDatos.LectorDatos.Read()) {

                CabeceraVenta unaCabeceraVenta = new CabeceraVenta();
                unaCabeceraVenta.Usuario = new Usuario();
                unaCabeceraVenta.Cliente = new Cliente();
                unaCabeceraVenta.NumeroDocumento = (int)AccederDatos.LectorDatos["NumeroVenta"];
                unaCabeceraVenta.Usuario.CodigoUsuario = (int)AccederDatos.LectorDatos["CodigoUsuario"];
                unaCabeceraVenta.Usuario.Nombre = (string)AccederDatos.LectorDatos["Nombre"];
                unaCabeceraVenta.Cliente.CodigoCliente = (int)AccederDatos.LectorDatos["CodigoCliente"];
                unaCabeceraVenta.Cliente.Nombre = (string)AccederDatos.LectorDatos["NombreCliente"];
                unaCabeceraVenta.FechaEmision = (string)AccederDatos.LectorDatos["Fecha"];
                unaCabeceraVenta.Total = (decimal)AccederDatos.LectorDatos["Total"];
                unaCabeceraVenta.MetodoPago = AccederDatos.LectorDatos["Metodopago"].ToString();
                ListadoVentas.Add(unaCabeceraVenta);
            }

            return ListadoVentas;
        }
    }
}
