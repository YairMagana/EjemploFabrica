namespace EjemploFabrica
{
    partial class Program
    {
        class BotonWeb : IBoton
        {
            public string Mostrar()
            {
                return ":Botón Web:";
            }

            public string onClick(string accion)
            {
                return $"Ejecutar {accion}";
            }
        }
    }
}
