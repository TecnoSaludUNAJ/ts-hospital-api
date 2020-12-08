using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TP_Application.Services
{
    public class Validacion
    {
        public static bool ValidarDni(string dni)
        {

            string expresion = @"^\d{5,6}[^\s.,_]\S$";

            Regex regex = new Regex(expresion);

            Match match = regex.Match(dni);


            bool resultado = match.Success == true ? true : false;

            return resultado;
        }

        public static bool ValidarNombre(string nombre)
        {

            string expresion = @"^(?!.* (?: |$))[a-zA-Z]+$";

            Regex regex = new Regex(expresion);

            Match match = regex.Match(nombre);


            bool resultado = match.Success == true ? true : false;

            return resultado;
        }

    }
}
