CREATE DATABASE BARRACHINA_DB  
ON   
( NAME = "BARRACHINA_DB", 
    FILENAME = 'C:\Users\Alejandra\Desktop\BARRACHINA_DB\BARRACHINA_DB.mdf')
    
    /* AGREGAR:
		- CREACION DE BASE DE DATOS X
		- CREACION DE TABLAS (falta compra,venta,devolucion)
		- LLAVES PRIMARIAS / CONSTRAINT 
		- LLENAR BASE DE DATOS (INSERTS)
		- PROCEDIMIENTO ALMACENADOS
		- TRIGGERS*/

USE BARRACHINA_DB

CREATE TABLE Productos(

		CodigoProducto int NOT NULL,
        codigoBulto int NOT NULL,
        Nombre varchar(30) NOT NULL,
        IdTipoProducto nchar(5) NOT NULL,
        Stock int NULL,
        StockCritico int NOT NULL,
        PrecioCosto decimal NOT NULL,
        PrecioCostoLista decimal NOT NULL,
        PrecioVentaMinorista decimal NOT NULL,
        PrecioVentaMayorista decimal NOT NULL,
        CantidadxBulto int NOT NULL,
        IdProveedor nchar(5)NOT NULL,
        IdRubro nchar(5) NOT NULL,
        IdSucursal nchar(5) NOT NULL,
		Estado BIT DEFAULT 1
)

CREATE TABLE Usuarios (

        IdUsuario nchar(5) NOT NULL,
        Nombre varchar(30) NOT NULL,
        Constrasenia varchar(30) NOT NULL,
        IdSector nchar(5) NOT NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE TipoProductos (

        IdTipoProducto nchar(5) NOT NULL,
        Nombre varchar(30) NOT NULL,
        Descripcion text NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE Descuentos(

        IdDescuento nchar(5) NOT NULL,
        Nombre varchar(50) NOT NULL,
        Porcentaje decimal NOT NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE Sucursales (

        CodigoSucursal nchar(5) NOT NULL,
	    Nombre varchar(30) NOT NULL,
        Estado bit DEFAULT 1

)

CREATE TABLE Sectores (

        CodigoSector nchar(5) NOT NULL,
        Nombre varchar(20) NOT NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE Rubros (
        
        CodigoRubro nchar(5) NOT NULL,
        Nombre varchar(30) NOT NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE Proveedores (
        
        IdProveedor nchar(5) NOT NULL,
        IdTipoProveedor nchar(5) NOT NULL,
        IdImpuesto nchar (5) NOT NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE PersonaJuridicas(

		IdPersonaJuridica nchar(5) NOT NULL,
        RazonSocial varchar(50) NOT NULL,
        NumeroCUIT varchar (20) NOT NULL,
        NombreFantasia varchar(30) NOT NULL,
        IdContacto nchar(5)NOT NULL,
        IdCondicionIVA nchar(5) NOT NULL        
)

CREATE TABLE PersonaFisicas(
    
        IdPersonaFisica nchar(5) NOT NULL,
        Nombre varchar(30) NOT NULL,
        Apellido varchar(30) NOT NULL,
        FechaNacimiento DateTime NOT NULL,
        Sexo nchar(10) NOT NULL,
        IdContacto nchar(5) NOT NULL
)

CREATE TABLE MotivosDevolucion(

		IdMotivoDevolucion nchar(5) NOT NULL,
        Nombre varchar(30) NOT NULL,
        Descripcion text NULL
)

CREATE TABLE Impuestos (
		
		CodigoImpuesto nchar(5) NOT NULL,
        Nombre varchar(30) NOT NULL,
        Descripcion text NULL,
        Alicuota decimal NOT NULL,
	    Estado bit DEFAULT 1  
)

CREATE TABLE FormasPago (

        CodigoFormaPago nchar(5) NOT NULL,
        Nombre varchar(30) NOT NULL,
        Porcentaje decimal NOT NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE Empleados (

 
        CodigoEmpleado nchar(5) NOT NULL,
        Cargo varchar(20) NOT NULL,
        Horario varchar (20) NOT NULL,
        Remuneracion decimal NOT NULL,
        IdTipoPersona varchar(5) NOT NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE Direcciones(

		IdDireccion nchar(5) NOT NULL,
		Calle varchar(30) NOT NULL,
        Numero int NOT NULL,
		CodigoPostal int NOT NULL,
        Localidad varchar(30) NOT NULL,
        Provincia varchar(30) NOT NULL,
        
)

CREATE TABLE CuentaCorrientes (

        IdCuentaCorriente nchar(5)NOT NULL,
        Fecha DateTime NOT NULL,
        Debe decimal DEFAULT 0,
        Haber decimal DEFAULT 0,
        Saldo decimal DEFAULT 0,
        LimiteCuenta decimal DEFAULT 2000

)

CREATE TABLE Contactos (

        IdContacto nchar(5) NOT NULL,
        Telefono int NULL,
        Celular int NOT NULL,
        Mail varchar(50) NULL,
        IdDireccion nchar(5) NOT NULL

)

CREATE TABLE CondicionesIVA(
		
		IdCondicionIVA nchar(5) NOT NULL,
        Nombre varchar(30) NOT NULL,
        Estado bit DEFAULT 1
)

CREATE TABLE Clientes (

        IdCliente nchar(5) NOT NULL,
        IdPersona nchar(5) NOT NULL,
        IdCuentaCorriente nchar(5) NOT NULL,
        IdDescuento nchar(5) NOT NULL,
        Estado bit DEFAULT 1
)

   
        
    
