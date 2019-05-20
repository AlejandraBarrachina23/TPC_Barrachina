﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;


namespace PresentacionWinForm
{
    public partial class Clientes : Form
    {
        Utilidades utilidades = new Utilidades();

        public Clientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
                //cuentaCorriente
                CuentaCorriente unaNuevaCuentaCorriente = new CuentaCorriente();
                unaNuevaCuentaCorriente.LimiteCuenta = Convert.ToUInt32(tboxLimitecuenta.Text);
                CuentaCorrienteNegocio unaCuentaCorriente = new CuentaCorrienteNegocio();
                unaCuentaCorriente.AgregarCuentaCorriente(unaNuevaCuentaCorriente);
                unaNuevaCuentaCorriente.CodigoCuentaCorriente = unaCuentaCorriente.ContarFilasCuentaCorriente();

                //direccion
                Direccion unaNuevaDireccion = new Direccion();
                DireccionNegocio unaDireccion = new DireccionNegocio();
                unaNuevaDireccion.Calle = tboxCalle.Text;
                unaNuevaDireccion.Numero = Convert.ToInt32(tboxNumero.Text);
                unaNuevaDireccion.CodigoPostal = Convert.ToInt32(tboxCP.Text);
                unaNuevaDireccion.Localidad = tboxLocalidad.Text;
                unaNuevaDireccion.Provincia = tboxProvincia.Text;
                unaDireccion.AgregarDireccion(unaNuevaDireccion);
                //contacto
                Contacto unNuevoContacto = new Contacto();
                ContactoNegocio unContacto = new ContactoNegocio();
                unNuevoContacto = new Contacto();
                unNuevoContacto.CodigoContacto = unaDireccion.ContaFilasDireccion();
                unNuevoContacto.Telefono = tboxTelefono.Text;
                unNuevoContacto.Celular = tboxCelular.Text;
                unNuevoContacto.Mail = tboxCorreoElectronico.Text;
                unNuevoContacto.Direccion = unaNuevaDireccion;
                unContacto.AgregarContacto(unNuevoContacto);

                //cliente
                Cliente unNuevoCliente = new Cliente();
                ClienteNegocio unCliente = new ClienteNegocio();
                unNuevoCliente.CodigoCliente = Convert.ToInt32(tboxCodigo.Text);
                unNuevoCliente.Nombre = tboxNombre.Text;
                unNuevoCliente.Apellido = tboxApellido.Text;
                unNuevoCliente.Descuento = (Descuento)cboxDescuento.SelectedItem;
                unNuevoCliente.CuentaCorriente = unaNuevaCuentaCorriente;
                unNuevoCliente.Contacto = unNuevoContacto;
                unCliente.AgregarCliente(unNuevoCliente);

                Avisos FormularioAviso = new Avisos();
                FormularioAviso.Show();

                /*<-----------------------------------------------------------------------------------------------------------------VALIDAR INGRESO DE CAMPOS*/
                //insert into ProveedorxImpuesto (CodigoProveedor,CodigoImpuesto,Alicuota) VALUES (unProveedor.CodigoProveedor,???,tbox.Impuesto)
            }

            catch (Exception)
            {

                throw;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            DescuentoNegocio unDescuento = new DescuentoNegocio();
            cboxDescuento.DataSource = unDescuento.ListarDescuentos();
        }
    }
}