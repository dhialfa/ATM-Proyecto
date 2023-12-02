using MVC_AnalisisArchivos.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AnalisisArchivos.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(UserDTO user)
        {
            // Aquí deberías validar el usuario y contraseña con la lógica de tu aplicación
            // Por ahora, simplemente redireccionamos a una página de inicio si el modelo es válido
            if (ModelState.IsValid)
            {
                // Realiza la lógica de autenticación aquí
                // Puedes utilizar el método VerifyCode para verificar la contraseña
                // (Asumiendo que estás utilizando la función ObfuscateCode para almacenar contraseñas)

                // Ejemplo:
                string storedHashedCode = ObtenerHashAlmacenadoDesdeLaBaseDeDatos(user.Email); // Aquí deberías obtener el hash almacenado en la base de datos
                if (user.VerifyCode(user.Code, storedHashedCode))
                {
                    // Autenticación exitosa, redirige a la página principal
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Autenticación fallida, agrega un mensaje de error
                    ModelState.AddModelError("", "Credenciales no válidas. Por favor, inténtalo de nuevo.");
                }
            }

            // Si llegamos a este punto, hay un error; vuelve a mostrar el formulario con los errores
            return View(user);
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