using MVC_AnalisisArchivos.Models.DAO;
using MVC_AnalisisArchivos.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_AnalisisArchivos.Models.DTO;
using MVC_AnalisisArchivos.Models.DAO;



namespace MVC_AnalisisArchivos.Controllers
{   
    public class LoginController : Controller
    {
        private UserDTO userDTO = new UserDTO();
        private UserDAO userDAO = new UserDAO();
        public ActionResult Login()
        {   
            return View();
        }
        UserDTO user = new UserDTO();
        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            userDTO = userDAO.ReadUser(email);
            TempData["UserId"] = user.Id;
            if (user.VerifyCode(password, userDTO.Code))
            {
                return Redirect("/");
            }
            return Redirect("/MainView/MainView");
        }



 

        // Método de ejemplo para obtener el hash almacenado desde la base de datos
        private string ObtenerHashAlmacenadoDesdeLaBaseDeDatos(string email)
        {
            // Aquí deberías implementar la lógica para obtener el hash almacenado en la base de datos
            // Usualmente, deberías buscar el usuario por su email en la base de datos y obtener el hash almacenado
            // Aquí simplemente devuelvo un valor fijo a modo de ejemplo
            return "hash_almacenado_en_la_base_de_datos";
        }
    }
}