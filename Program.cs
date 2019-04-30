using System;
using System.Collections.Generic;

namespace DefinicionClase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona per = new Persona();
            //Persona per2 = new Persona();
            //Persona per3 = new Persona();

            List<Persona> personas = new List<Persona>();
            //per.Nombre = "Juliana";
            //per.Edad = 18;

            //Console.WriteLine($"Nombre:{per.Nombre} Edad: {per.Edad}");
            //Console.WriteLine("Ingresar su nombre");
            //per2.Nombre = Console.ReadLine();
            //Console.WriteLine("Ingresar su Edad");
            //per2.Edad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Nombre:{per2.Nombre} Edad: {per2.Edad}");
            //per3.IngresarPersona();
            //personas.Add(per);
            //personas.Add(per2);
            //personas.Add(per3);

            //    foreach (var item in personas)
            //    {
            //        Console.WriteLine($"Nombre: {item.Nombre} Edad: {item.Edad}");
            //    }

            Console.WriteLine("¿Desea ingresar personas? s/n");
            var res = Console.ReadLine();

            while (res == "s")
            {
                Persona per4 = new Persona();
                per4.IngresarPersona();
                personas.Add(per4);
                Console.WriteLine("¿Desea ingresar personas? s/n");
                res = Console.ReadLine();

            }
            Persona per = new Persona();
            per.ListarPersonas(personas);
            Console.ReadKey();


        }
    }
}
