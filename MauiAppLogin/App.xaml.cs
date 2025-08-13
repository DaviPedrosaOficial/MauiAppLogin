namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage abaixo, representa qual será a tela inicial de nosso projeto, no nosso caso a tela de Login ;)
            MainPage = new Login();
        }

        /* Método abaixo, é utilizado na personalização e configurações das janelas de nosso app, definindo alguns atributos
        como tamanho, largura, posição, título e ate múltiplas janelas
        
         --- Descrição de seu parâmetro ----
        
         * activationState: Informações sobre o estado de ativação do app (podendo ser nulo)
        
         --- Possíveis chamadas ---
        
         * Tamanho e largura:       window.Height = 600;
                                    window.Width = 400;
        
         * Definir título e posição inicial:          window.Title = "Minha aplicação de Login em .MAUI";
                                                      window.X = 100;
                                                      window.Y = 100;
        
         * Criando múltiplas janelas:       var mainWindow = new Window(new MainPage());
    var                                     secondaryWindow = new Window(new SecondaryPage());
                                            Lógica que gerenciará as janelas
                                            return mainWindow;
        */
        protected override Window CreateWindow(IActivationState? activationState)
        {
            /* Sempre chame base.CreateWindow(activationState) se quiser manter o comportamento padrão e apenas ajustar propriedades,
            isso porque, como o .MAUI trabalha com Android e IOS, nessas, existem apenas 1 página, uma vez que telefones não são tão
            dinâmicos como computadores, que permitem termos mais de ao mesmo tempo.
            
             Sendo assim, ao utilizarmos o base.CreateWindow(activationState) faremos com que nessas plataformas os padrões do sistema
            sejam respeitados e alterando apenas algumas propriedades chaves*/
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}