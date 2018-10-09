using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieBasen.Controllers
{
    public class ConnectionTestController : Controller
    {
        // GET: ConnectionTest
        public ActionResult Index()
        {
            {
                try
                {
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                    connection.Open();
                    if ((connection.State & ConnectionState.Open)==0)
                    {
                        Response.Write("Connection OK!");
                        connection.Close();
                    }
                     else
                     {
                        Response.Write("No Connection!");
                    }
                }
                catch
                {
                    Response.Write("No Connection!");
                }
            }
            return View();
        }
    }
}