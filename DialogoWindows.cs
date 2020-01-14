namespace EjemploFabrica
{
    partial class Program
    {
        class DialogoWindows : Dialogo
        {
            public override IBoton FabricaBoton()
            {
                return new BotonWindows();
            }

            public override string Desplegar()
            {
                return "Diálogo Windows | ";
            }
        }
    }
}
