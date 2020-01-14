using System;

namespace EjemploFabrica
{
    partial class Program
    {
        class Client
        {
            public void Main()
            {
                Console.WriteLine("Creación de dialogo Windows");
                CrearDialogo(new DialogoWindows());

                Console.WriteLine("");

                Console.WriteLine("Creación de dialogo Web");
                CrearDialogo(new DialogoWeb());
            }

            public void CrearDialogo(Dialogo dialogo)
            {
                Console.WriteLine($"{dialogo.Desplegar()} {dialogo.CrearBoton()}");
            }
        }
    }
}
