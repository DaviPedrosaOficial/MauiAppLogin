namespace MauiAppLogin;

public partial class Login : ContentPage
{
	/* Como ainda a ideia do projeto � somente testar a funcionalidade da tela de login, irei criar os usu�rios diretamente
			 no c�digo */
	private List<DadosUsuario> usuarios = new List<DadosUsuario>();
    public Login()
	{
		InitializeComponent();
        usuarios = UsuarioService.Instance.Usuarios;
    }

    private async void btn_login_Clicked(object sender, EventArgs e)
    {
		/* � interessante, sempre que formos fazer metodos que possam crashar o nosso programa, utilizar o try & catch para impedir
		o mesmo */
		try {

			// Recebendo os dados digitados pelo cliente
			DadosUsuario dados_digitados = new DadosUsuario()
			{
				Usuario = txt_usuario.Text,
				Senha = txt_senha.Text
			};

			//LINQ (estrutura de consulta integrada) para verificar se o usu�rio e senha existem na lista criada
			if (usuarios.Any(i => i.Usuario == dados_digitados.Usuario && i.Senha == dados_digitados.Senha))
			{
				await SecureStorage.SetAsync("usuario_logado", dados_digitados.Usuario);

                App.Current.MainPage = new Protegida();

			}
			else
			{
				txt_senha.Text = string.Empty;
				throw new Exception("Usu�rio ou senha inv�lidos!");
				
			}


            } catch (Exception ex)
		{
			await DisplayAlert("Erro", "Ocorreu um erro ao tentar fazer o login: " + ex.Message, "OK");
        }
    }

    //Redirecionando � p�gina de cadastro
    private void btn_cadastro_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new Cadastro();
    }
}