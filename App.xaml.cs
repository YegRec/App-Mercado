namespace AppMercado
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Verifica que MainPage esté asignada correctamente
            MainPage = new MainPage();
        }
    }
}
