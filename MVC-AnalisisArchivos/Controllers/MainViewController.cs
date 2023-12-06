
using System.Web.Mvc;
using MVC_AnalisisArchivos.Models.DAO;

namespace MVC_AnalisisArchivos.Controllers
{
    public class TuControllerOperaciones : Controller
    {
        [HttpPost]
        public ActionResult RealizarOperacion(string operacion)
        {
            // Lógica para realizar la operación según el botón presionado
            // Puedes acceder al UserId desde TempData si es necesario
            string userId = TempData["UserId"] as string;

            switch (operacion)
            {
                case "ConsultaSaldo":
                    // Lógica para consultar saldo
                    break;
                case "RetirarDinero":
                    // Lógica para retirar dinero
                    break;
                case "Salir":
                    // Lógica para salir
                    break;
                default:
                    break;
            }

            // Puedes redirigir a otra página después de realizar la acción, si es necesario.
            // return RedirectToAction("OtraAccion", "OtroControlador");
            return Redirect("/user");
        }
    }
}