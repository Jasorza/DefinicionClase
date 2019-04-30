using System;
using System.Collections.Generic;
using System.Text;

namespace DefinicionClase
{
    class Persona
    {
        #region propiedad
        public int Edad { get; set; }
        public string Nombre { get; set; }
        #endregion

        public void IngresarPersona()
        {
            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            Edad = Convert.ToInt32(Console.ReadLine());
        }

        public void ListarPersonas(List<Persona> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine($"Nombre: {item.Nomnre} Edad: {item.Edad}");
            }
        }
    }
}
