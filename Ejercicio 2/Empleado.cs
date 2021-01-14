using System;

namespace Ejercicio_2
{
    class Empleado : Persona
    {
        private string cargo;
        private double sueldo;

        public Empleado(string nom, string ape, int age, int id, string carg, double sueld) : base(nom, ape, age, id)
        {
            this.cargo = carg;
            this.sueldo = sueld;
        }

        /*
        public override void saludar()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tipo: Empleado");
        }*/

        public string getCargo()
        {
            return this.cargo;
        }

        public double getSueldo()
        {
            return this.sueldo;
        }

        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public void setSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }
    }
}
