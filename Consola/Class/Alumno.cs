using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public partial class Alumno
    {
        static int instancias_de_alumnos = 0;
        string nombre;
        string apellido;
        int? dni;
        DateOnly fecha_nacimiento;

        public Alumno()
        {
            
        }

        // Constructor de la clase Alumno
        public Alumno(string nombre, string apellido, int dni=0, DateOnly fecha_nacimiento= new DateOnly())
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fecha_nacimiento = fecha_nacimiento;
            instancias_de_alumnos++;
        }

        // Metodo para imprimir la ficha de datos del alumno
        public string ImpresionFichaDeDatos()
        {
            return $"Nombre: {nombre} {apellido}\nDNI: {dni}\nFecha de Nacimiento: {fecha_nacimiento.ToString("dd/MM/yyyy")}";
        }

        public override string ToString()
        {
            return apellido + " " + nombre;
        }
    }
}
