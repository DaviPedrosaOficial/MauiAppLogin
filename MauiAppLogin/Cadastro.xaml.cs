

namespace MauiAppLogin;

public partial class Cadastro : ContentPage
{
    private List<DadosUsuario> usuarios;

	public Cadastro()
	{
		InitializeComponent();
        usuarios = UsuarioService.Instance.Usuarios;
    }

    private async void btn_cadastro_cadastro_Clicked(object sender, EventArgs e)
    {
        try 
        {
            if (usuarios.Any(i => i.Usuario == txt_usuario_cadastro.Text))
            {
                throw new Exception("Usu�rio j� cadastrado!");

            }
            else if (txt_senha_cadastro == null || txt_confirma_senha_cadastro == null) 
            {
                throw new Exception("Senha &/ou confirma��o de senha n�o inserida!");
            }
            else if (txt_senha_cadastro.Text != txt_confirma_senha_cadastro.Text) 
            {
                txt_senha_cadastro.Text = string.Empty;
                txt_confirma_senha_cadastro.Text = string.Empty;
                throw new Exception("Senha e confirma��o de senha n�o batem!");
            }
            else {                 
                
                // Criando o usu�rio com os dados digitados
                DadosUsuario novo_usuario = new DadosUsuario()
                {
                    Usuario = txt_usuario_cadastro.Text,
                    Senha = txt_senha_cadastro.Text
                };
                
                // Adicionando o usu�rio na lista de usu�rios
                usuarios.Add(novo_usuario);
                
                // Salvando o usu�rio no armazenamento seguro do dispositivo
                await SecureStorage.SetAsync("usuario_logado", novo_usuario.Usuario);
                
                // Redirecionando para a p�gina protegida
                App.Current.MainPage = new Protegida();
            }

        } catch (Exception ex) 
        {
            await DisplayAlert("Erro", ex.Message, "Ok!");
        }
    }
}