using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDPortalWeb.Manager
{
    public class MiWebApp
    {
        public bool Login(string Usuario, string Password)
        {
            bool result = false;
            if (Usuario == "Luis")
            {
                if (Password == "12345678")
                {
                    result = true;
                }
                else
                {
                    //var resultError = "";
                    //resultError += "<table border>";
                    //resultError += "<tr>";
                    //resultError += "<td>***</td>";
                    //resultError += "<td rowspan=\"2\">Password Incorrecto</td>";
                    //resultError += "<td>***</td>";
                    //resultError += "</tr>";
                    //resultError += "<tr>";
                    //resultError += "<td>***</td>";
                    //resultError += "<td><button type=\"button\" onclick=\"DeleteUser('Usuario'); \">Eliminar</button></td>";
                    //resultError += "</tr>";
                    //resultError += "</table>";
                    //throw new Exception(resultError);
                    throw new Exception("Contraseña Incorrecta");
                }
            }
            else
            {
                throw new Exception("Usuario Incorrecto");
            }
            return result;
        }
    }
}
