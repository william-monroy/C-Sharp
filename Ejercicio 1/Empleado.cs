using System;

namespace C_Sharp
{
    class Empleado:Persona
    {
        public override void saludar()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tipo: Empleado");
        }
    }
}
