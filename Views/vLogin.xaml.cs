namespace jPaillachoS3.Views;

public partial class vLogin : ContentPage
{
    string usuario, contrasena;
    public vLogin()
    {
        InitializeComponent();
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngreso = txtUsuario.Text;
            string contrasenaIngreso = txtContrasena.Text;

            if (usuarioIngreso == usuario && contrasenaIngreso == contrasena)
            {
                Navigation.PushAsync(new vReporte());
            }
            else
            {
                DisplayAlertAsync("Alerta", "Usuario/Contraseña Incorrecto", "OK");
            }
        }
        catch (Exception ex)
        {

            DisplayAlertAsync("Error", ex.Message, "Cerrar");
        }
    }

    private void btnIniciarSesion_Clicked_1(object sender, EventArgs e)
    {

    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnRegistrar_Clicked_1(object sender, EventArgs e)
    {

    }
}