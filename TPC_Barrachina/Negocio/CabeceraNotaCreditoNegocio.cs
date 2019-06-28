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
            int NumeroNotaDevolucion = AccederDatos.ejecutarAccionReturn()+1;
            AccederDatos.CerrarConexion();
            return NumeroNotaDevolucion;
        }

        public CabeceraNotaCredito CargarCabeceraDevolucion(Usuario UsuarioActivo, Cliente unCliente, string FechaEmision, decimal TotalFactura, string MetodoPago, string MotivoDevolucion, string TipoOperacion)
        {

            CabeceraNotaCredito unaCabeceraNotaCredito = new CabeceraNotaCredito();
            ClienteNegocio unClienteNegocio = new ClienteNegocio();
            unaCabeceraNotaCredito.Usuario = new Usuario();
            unaCabeceraNotaCredito.Cliente = new Cliente();

            unaCabeceraNotaCredito.Usuario = UsuarioActivo;
            unaCabeceraNotaCredito.FechaEmision = FechaEmision;
            unaCabeceraNotaCredito.Total = TotalFactura;
            unaCabeceraNotaCredito.MetodoPago = MetodoPago;
            unaCabeceraNotaCredito.MotivoDevolucion = MotivoDevolucion;

            if (unCliente != null)
            {
                unCliente = unClienteNegocio.CargaCuentaCorriente("CtaCorriente", MetodoPago, unCliente, TotalFactura,TipoOperacion);
                unaCabeceraNotaCredito.Cliente.CodigoCliente = unCliente.CodigoCliente;
            }

            return unaCabeceraNotaCredito;

        }

        public void AgregarCabeceraNotaDevolucion(CabeceraNotaCredito unaNuevaCabeceraNotaDevolucion)
        {
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO NotaDevolucion (Usuario,Cliente,Total,MetodoPago,Fecha,MotivoDevolucion) VALUES ('" + unaNuevaCabeceraNotaDevolucion.Usuario.CodigoUsuario + "','" + unaNuevaCabeceraNotaDevolucion.Cliente.CodigoCliente + "','" +
            unaNuevaCabeceraNotaDevolucion.Total + "','" + unaNuevaCabeceraNotaDevolucion.MetodoPago + "','" + unaNuevaCabeceraNotaDevolucion.FechaEmision + "','" + unaNuevaCabeceraNotaDevolucion.MotivoDevolucion + "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }
}
