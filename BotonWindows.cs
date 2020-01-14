namespace EjemploFabrica
{
    partial class Program
    {
        class BotonWindows : IBoton
        {
            public string Mostrar()
            {
                return ":Boton Windows:";
            }

            public string onClick(string accion)
            {
                return $"Ejecutar {accion}";
            }
        }
    }
}
