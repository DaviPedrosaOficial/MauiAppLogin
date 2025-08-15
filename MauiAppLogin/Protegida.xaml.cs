using System.Data.SqlTypes;

namespace MauiAppLogin;

public partial class Protegida : ContentPage
{
	public Protegida()
	{
		InitializeComponent();

		string? usuario_logado = null;

		Task.Run(async () => 
		{
			usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");

			lbl_txt_boasvindas.Text = $"Seja bem vindo {usuario_logado} !";
		});
	}

    private async void btn_deslogar_Clicked(object sender, EventArgs e)
    {
		bool confirmacao = await DisplayAlert("Tem certeza?", "Sair da conta?", "Sim", "Não");

		if (confirmacao) 
		{
			SecureStorage.Default.Remove("usuario_logado");

			App.Current.MainPage = new Login();
        }
    }
}