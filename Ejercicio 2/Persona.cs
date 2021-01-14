using System;

namespace Ejercicio_2
{
    class Persona
    {
        private int edad, dni;
        private string nombres, apellidos;
        public Persona(string nom, string ape, int age, int id)
        {
            this.nombres = nom;
            this.apellidos = ape;
            this.edad = age;
            this.dni = id;
        }
        /*
        public virtual void saludar()
        {
            Console.WriteLine("Hola");
        }*/

        public int getEdad()
        {
            return this.edad;
        }

        public int getDni()
        {
            return this.dni;
        }

        public string getNombres()
        {
            return this.nombres;
        }

        public string getApellidos()
        {
            return this.apellidos;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void setDni(int dni)
        {
            this.dni = dni;
        }

        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }

        public void setDni(string apellidos)
        {
            this.apellidos = apellidos;
        }


    }
}