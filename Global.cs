using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroSangre
{
    public class Global
    {

        public static string? paciente;
        public string? Paciente
        {
            set { paciente = value; }
            get { return paciente; }

        }

        public static string? doctor;
        public string? Doctor
        {
            set { doctor = value; }
            get { return doctor; }

        }


    }
}
