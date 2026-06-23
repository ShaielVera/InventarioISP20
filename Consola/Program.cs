

using Consola.Class;

public class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio1();
        //Ejercicio2();
        EjercicioFinal();
        //ProbamosMetodosConDirentesValoresDeRetorno();
        //creamosEstudiantesEImprimimosSuSaludo();
        //CreeVariables();
        //CreamosMatricesyVectores();
        //Creeunaentradadetexto();
        //ProbeImprimirParametro(args);
        //CalcularAÑoNac();
        //CreamosAlumnoEImprimimosSuFichaDeDatos();
    }

    private static void EjercicioFinal()
    {
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre= "Shaiel Vera";
        Persona[] grupo = new Persona[2];
        grupo[0] = new Persona();
        grupo[1] = new Estudiante();

        foreach (Persona i in grupo)
        {
            i.Hablar();
        }
        Console.WriteLine(Environment.NewLine + "Probando probando");
        Object prueba = new Object();
        DateTime ahora = new DateTime();
        ahora = DateTime.Now;
        Console.WriteLine(prueba.ToString());
        Console.WriteLine(estudiante1.ToString());
        Console.WriteLine(ahora);
    }


    public static void Ejercicio2()
    {
        Bicicleta bicicleta1 = new();

        Console.WriteLine("Ingrese la velocidad de la Bicicleta: ");
        bicicleta1.Velocidad = int.Parse(Console.ReadLine());
        bicicleta1.tieneCampanilla = true;
        Console.WriteLine($"La bicicleta tiene una velocidad de {bicicleta1.Velocidad} y {(!bicicleta1.tieneCampanilla?"no":"")}tiene campanilla");
    }

    private static void Ejercicio1()
    {
        Persona persona1 = new();
        Console.WriteLine("Ingrese el nombre de la persona: ");
        persona1.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad de la persona: ");
        persona1.CumplirAnios();


        Console.WriteLine($"Nombre {persona1.Nombre} Edad: {persona1.CumplirAnios}");
    }

    private static void ProbamosMetodosConDirentesValoresDeRetorno()
    {
        AlumnoCurso alumno1 = new AlumnoCurso("Lucía", "Gómez", 19);

        alumno1.AgregarNota(8);
        alumno1.AgregarNota(7.5);
        alumno1.AgregarNota(9);
        alumno1.AgregarNota(3);
        alumno1.AgregarNota(5);

        string nombreCompleto = alumno1.ObtenerNombreCompleto();
        int cantidadNotas = alumno1.ObtenerCantidadDeNotas();
        double promedio = alumno1.CalcularPromedio();
        bool aprobado = alumno1.EstaAprobado();
        char inicial = alumno1.ObtenerInicial();
        DateTime fechaConsulta = alumno1.ObtenerFechaConsulta();
        List<double> notas = alumno1.ObtenerNotas();
        int MateriasDesaprobadas = alumno1.ContarMateriasDesaprobadas();
        int MateriasAprobadas = alumno1.ContarMateriasAprobadas();
        string PasoDeAño = alumno1.PasoDeAño();



        Console.WriteLine("Nombre completo: " + nombreCompleto);
        Console.WriteLine("Cantidad de notas: " + cantidadNotas);
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("¿Está aprobado?: " + aprobado);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Fecha de consulta: " + fechaConsulta);
        Console.WriteLine($"Materias desaprobadas: {MateriasDesaprobadas}");
        Console.WriteLine($"Materias Aprobadas: {MateriasAprobadas}");
        Console.WriteLine($"Estado: {PasoDeAño}");


    }

    private static void creamosEstudiantesEImprimimosSuSaludo()
    {
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Shaiel";
        estudiante1.Edad = 22;
        estudiante1.Domicilio = "N. Zamaro 2559";
        estudiante1.Saludar();
        Console.WriteLine(estudiante1.DatosCompletos);
    }

    private static void CreamosAlumnoEImprimimosSuFichaDeDatos()
    {
        Alumno alumno = new Alumno("Shaiel", "Vera", 44496912, new DateOnly(2002, 09, 28));
        Console.WriteLine(alumno.ImpresionFichaDeDatos());
        Alumno alumno2 = new Alumno("Loana", "Vera", 44496913, new DateOnly(2002, 09, 28));
        Console.WriteLine(alumno2.ImpresionFichaDeDatos());
        Alumno alumno3 = new Alumno("Nico", "Marquez", 44496914, new DateOnly(2001, 03, 14));
        Console.WriteLine(alumno3.ImpresionFichaDeDatos());

        Console.WriteLine(Alumno.ImprimirCantidadDeInstancias());
    }

    private static void CreamosMatricesyVectores()
    {
        string[] meses = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        meses[0] = "ENERO";
        meses[11] = "DICIEMBRE";
        string[,] nosotros = new string[3,2] {{"Alejandro", "Juampi"}, {"Loana", "Shaiel"}, {"Nicolas", "Bauti"}};
        nosotros[0, 0] = "Ramirez";
        nosotros[2, 1] = "Marquez";
        int[] edades = new int[3] { 23, 26, 23 };
    }

    private static void CalcularAÑoNac()
    {
        Console.Write("Ingrese su año de nacimiento: ");
        string? anio_nac = Console.ReadLine();
        int anio = Convert.ToInt32(anio_nac);
        int edad = DateTime.Now.Year - anio;
        Console.WriteLine($"Tienes {edad} años");
    }

    private static void CreeVariables()
    {
        int numero = 10;
        //Declarando
        int numero2;
        //Asignando
        numero2 = 20;
        int numero3 = 30;
    }

    private static void ProbeImprimirParametro(string[] args)
    {
        Console.WriteLine("probando imprimir en pantalla");
        if (args.Length > 1)
            Console.WriteLine($"Hola {args[0]} {args[1]}");
    }

    private static void Creeunaentradadetexto()
    {
        Console.WriteLine("Ingresa un nombre: ");
        string? nombre = Console.ReadLine();
        Console.WriteLine($"Hola {nombre}, ¿cómo estás?");
    }
}