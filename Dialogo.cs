namespace EjemploFabrica
{
    partial class Program
    {
        abstract class Dialogo
        {
            public abstract IBoton FabricaBoton();
            public abstract string Desplegar();

            public string CrearBoton()
            {
                var boton = FabricaBoton();
                var result = $"{boton.Mostrar()}";

                return result;
            }
        }
    }
}
