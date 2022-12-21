using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using EFDPortalWeb.Manager;

namespace EFDPortalWeb.MasterPages
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(EnableSession = true)]
        public static bool Login(string Usuario, string Password)
        {
            MiWebApp webApp = new MiWebApp();
            var result = webApp.Login(Usuario, Password);
            if (result)
                HttpContext.Current.Session["webApp"] = webApp;
            else
                HttpContext.Current.Session["webApp"] = null;
            if (!result)
            {
                throw new Exception("Usuario o Contraseña incorrecto.");
            }
            else
                return result;
        }
    }
}