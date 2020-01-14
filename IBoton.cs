namespace EjemploFabrica
{
    partial class Program
    {
        public interface IBoton
        {
            string Mostrar();

            string onClick(string accion);
        }
    }
}
