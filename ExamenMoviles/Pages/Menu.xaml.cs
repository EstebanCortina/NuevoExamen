namespace ExamenMoviles.Pages;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();
    }
    private async void BtnSendToAgregarNombreTienda(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new NuevoNombreTienda());
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
        }
    }
    private async void BtnEliminarNombreTienda(object sender, EventArgs e)
    {
        try
        {
            Preferences.Remove("nombreTienda");
            Preferences.Set("statusNombreTienda", false);
            await Navigation.PushAsync(new NuevoNombreTienda());
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
        }
    }
    private async void BtnAgregarSplashScreen(object sender, EventArgs e)
    {
        try
        {
            Preferences.Set("splashScreenImageUrl", inUrlSplash.Text);
            await Navigation.PushAsync(new MainPage());
        }
        catch { 
        }
    }
}