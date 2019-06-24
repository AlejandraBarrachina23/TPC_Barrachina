<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="PresentacionWebForm.ListadoUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="https://fonts.googleapis.com/css?family=Oswald&display=swap" rel="stylesheet">
</head>
<body>

    <script>
        function Ocultar() {

            document.getElementById("AgregarUsuario").style.display = "block";
            return false;
        }

    </script>

    <style>

        #form-list-users {
          
          width:50%;
          margin:0 auto;
          text-align:center;

        }

        #form-users{

            width:50%;
            margin:0 auto;
            text-align:center;
            background-color:#EFE7CC;
            color:black;
            font-family: 'Oswald', sans-serif;
        }

        #tboxNombre,#tboxCodigo,#tboxContrasenia, #DdlSectores {
        
               font-family: 'Oswald', sans-serif;  
               font-size:medium;
               width:25%;
               margin:5px;
               text-align:center;
        
        }

        #dgvUsuarios {
            
            font-family: 'Oswald', sans-serif;  
            font-size:medium;
            margin-left:25%;
            margin-bottom:2%;
        }

        .boton {
        
           font-family: 'Oswald', sans-serif;  
           background-color: #1B7395;
           width:10%;
           padding:8px;
           border: 1px solid #1B7395 ;
           margin:3px;
           color:white;

        }

        #lblAdvertencia {
        
             font-family: 'Oswald', sans-serif; 
             color:red;
             font-size:medium;
        }


    </style>
    <form id="form1" runat="server">
        <div id="form-list-users">
            <asp:GridView ID="dgvUsuarios" runat="server" OnRowDataBound="dgvUsuarios_RowDataBound" OnSelectedIndexChanged="dgvUsuarios_SelectedIndexChanged" OnSelectedIndexChanging="dgvUsuarios_SelectedIndexChanging" DataKeyNames="CodigoUsuario,Nombre,Constrasenia,SectorDesignado" Width="340px">
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/img/click.png" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        <asp:Button ID="btnAgregar" class="boton"  runat="server" Text="AGREGAR"  OnClick="btnAgregar_Click" />
        <asp:Button ID="btnEliminar" class="boton" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnModificar" class="boton" runat="server" Text="MODIFICAR" OnClick="btnModificar_Click" /><br />
        <asp:Label ID="lblAdvertencia" Text="" runat="server" />
        </div>
        

        <div id="form-users">
            <asp:Panel ID="pnlAgregarUsuario" runat="server" Visible="False"><br />
                <asp:Label ID="lblTitulo" Text="Agregar Usuario" runat="server" /><br />
                    <label>Codigo</label><br />
                    <asp:TextBox ID="tboxCodigo" runat="server" OnTextChanged="tboxCodigo_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <br />
                    <label>Nombre</label><br />
                    <asp:TextBox ID="tboxNombre" img="img/checked.png" runat="server"></asp:TextBox><br />
                    <label>Contraseña</label><br />
                    <asp:TextBox ID="tboxContrasenia" runat="server"></asp:TextBox><br />
                    <label>Sector</label><br />
                    <asp:DropDownList ID="DdlSectores" runat="server">
                        <asp:ListItem>Compra</asp:ListItem>
                        <asp:ListItem>Ventas</asp:ListItem>
                        <asp:ListItem>Administración</asp:ListItem>
                        <asp:ListItem>Depósito</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:Button ID="btnAceptar" class="boton" runat="server" Text="ACEPTAR" OnClientClick="if(!Advertencia()){return false;};" OnClick="btnAceptar_Click"/>
              </asp:Panel>
      </div>
    </form>
</body>
</html>
