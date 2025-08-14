

namespace MauiAppLogin;

public partial class Cadastro : ContentPage
{
    private List<DadosUsuario> usuarios;

	public Cadastro()
	{
		InitializeComponent();
        usuarios = UsuarioService.Instance.Usuarios;
    }

    private void btn_cadastro_cadastro_Clicked(object sender, EventArgs e)
    {
        if()
    }
}