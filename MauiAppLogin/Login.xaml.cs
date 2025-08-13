namespace MauiAppLogin;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btn_login_Clicked(object sender, EventArgs e)
    {
		/* É interessante, sempre que formos fazer metodos que possam crashar o nosso programa, utilizar o try & catch para impedir
		o mesmo */
		try {

		}
		catch (Exception ex)
		{
			DisplayAlert("Erro", "Ocorreu um erro ao tentar fazer o login: " + ex.Message, "OK");
        }
    }
}