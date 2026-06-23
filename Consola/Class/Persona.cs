using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public class Persona
        {
        public string? Nombre;
        private int? Edad;

        public void CumplirAnios()
        {
            Edad++;
            Console.WriteLine($"La edad es: {Edad}");
        }

        public virtual void Hablar()
        {
            Console.WriteLine("Hola.");
        }
    }
}
