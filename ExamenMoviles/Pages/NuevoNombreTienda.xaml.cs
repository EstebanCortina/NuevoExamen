namespace ExamenMoviles.Pages;

public partial class NuevoNombreTienda : ContentPage
{
    public NuevoNombreTienda()
    {
        InitializeComponent();
    }
    async private void BtnGuardarNombreTienda(object sender, EventArgs e)
    {
        string nombreTienda = inTiendaName.Text;
        Preferences.Set("nombreTienda", nombreTienda);
        Preferences.Set("statusNombreTienda", true);
        try
        {
            await Navigation.PushAsync(new MainPage());
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
        }
    }
    async private void BtnSendToMainPage(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new MainPage());
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
        }
    }
}