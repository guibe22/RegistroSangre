using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroSangre
{
    public class Global
    {
       
        public string? Doctor { get; set; }
        public static string? prueba;
     

        public static string paciente;
        public string Paciente
        {
            set { paciente = value; }
            get { return paciente; }

        }


    }
}
