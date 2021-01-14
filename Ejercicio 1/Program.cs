using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            Alumno alm = new Alumno();
            Persona[] personas = { emp, alm };
            foreach (var item in personas)
            {
                item.saludar();
                Console.WriteLine("\n");
            }


            string[] lines = System.IO.File.ReadAllLines(@"estudiantes.csv");
            System.Console.WriteLine("Contenido del archivo = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Numero de elementos {0}",lines.Length);
            
        }
    }
}
