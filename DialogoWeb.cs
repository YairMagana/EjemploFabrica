namespace EjemploFabrica
{
    partial class Program
    {
        class DialogoWeb : Dialogo
        {
            public override IBoton FabricaBoton()
            {
                return new BotonWeb();
            }

            public override string Desplegar()
            {
                return "Diálogo Web | ";
            }
        }
    }
}
