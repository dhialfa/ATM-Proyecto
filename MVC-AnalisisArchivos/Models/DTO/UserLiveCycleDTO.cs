using MVC_AnalisisArchivos.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_AnalisisArchivos.Models
{
    public class UserLiveCycleDTO
   {
        public int Session { get; set; }

        public UserDTO User { get; set; }
        // public AtmParameterDTO atm { get; set; }
        public AtmParameterDTO Atm { get; set; }
    }
}