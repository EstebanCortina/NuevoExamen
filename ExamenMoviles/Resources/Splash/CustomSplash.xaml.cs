
using System.Threading.Tasks;
namespace ExamenMoviles.Resources.Splash;

public partial class CustomSplash : ContentPage
{
    public CustomSplash()
    {
        InitializeComponent();
        asignarSplashScreen();
        timer();
    }
    async private void timer()
    {
        try
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            Preferences.Set("statusSplash", true);
            await Navigation.PushAsync(new MainPage());
        }
        catch (Exception ex)
        {

        }
    }
    private void asignarSplashScreen()
    {
        splashImg.Source = Preferences.Get("splashScreenImageUrl", "https://img.freepik.com/vector-gratis/cargando-circulos-azul-degradado_78370-2646.jpg?w=740&t=st=1694747204~exp=1694747804~hmac=ac29e3ca886db32dcc20cf5889fad40e1e74288bbe8b8d2df264d3dd738ea038");
    }
}