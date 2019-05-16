using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;


namespace Negocio
{
    public class CondicionIVANegocio
    {
       private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

            public List<CondicionIVA> ListarCondicionIVA()
            {

                List<CondicionIVA> ListadoCondicionIVA = new List<CondicionIVA>();
                AccederDatos.LecturaBaseDatos("SELECT * FROM CondicionesIVA");
                while (AccederDatos.LectorDatos.Read())
                {

                CondicionIVA unaNuevaCondicionIVA = new CondicionIVA();

                unaNuevaCondicionIVA.CodigoCondicionIVA = (int)AccederDatos.LectorDatos["CodigoCondicionIVA"];
                unaNuevaCondicionIVA.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                ListadoCondicionIVA.Add(unaNuevaCondicionIVA);
                }
                return ListadoCondicionIVA;

            }
        }
    
}
