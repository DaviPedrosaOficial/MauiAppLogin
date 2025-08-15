# Aplica��o de Login em MAUI

## Descri��o

 Projeto desenvolvido em C# utilizando sua framework .MAUI (desenvolvimento de softwares desktop & mobile).
 
 Projeto base que conta com uma interface de Login e Cadastro pr� prontas para futuras aplica��es utilizando o .MAUI.

 Pensando em futuras aplica��es na framework, criei um sistema de Login b�sico que poder� ser reutilizado e alterado no futuro, onde o mesmo conta com alguns usu�rios j� cadastrados e uma aba para cadastrarmos
 novos clientes. Al�m disso, o projeto j� exclui grande parte dos arquivos obsoletos que s�o criados ao iniciarmos um novo projeto MAUI, uma vez que o mesmo tamb�m cria uma interface gr�fica ao ser iniciado.
 O projeto tamb�m conta com diversos coment�rios para auxiliar no seu desenvolvimento.

 ### Requisitos

 <ul>
   <li>IDE de sua escolha: Visual Studio Community, JetRiders, ...</li>
   <li>SDK .NET: Utilizado no projeto � a 9.0. N�o possui o .NET ainda? <a href="https://learn.microsoft.com/pt-br/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio"     target="blank">Instalar SDK</a></li>
   <li>Extens�o do .NET MAUI: Caso n�o tenha instalado, <a href="https://learn.microsoft.com/pt-br/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio" target="blank">clique aqui</a></li>
 </ul>

 #### Instru��es de para baixar o projeto

 <ol>
  <li>Clone ou Baixe o projeto a partir do bot�o <b>'code'</b> aqui no git 
   <img src="MauiAppLogin/Resources/Images/tela_git_code.png" alt="Imagem ilustrativa de onde encontrar o bot�o 'code'"/>
   </li>
   <li>Escolha a melhor op��o para baix�-lo em sua IDE
   <img src="MauiAppLogin/Resources/Images/tela_git_clonar.png" alt="Imagem que demonstra como clonar o c�digo via git"</li>
   <li>Ap�s baix�-lo em sua m�quina, pe�a para sua IDE rodar o mesmo, pra ver se existe alguma extens�o que precisa ser instalada ainda.
   <br>
   Se for preciso, o terminal acusar� erro, e aconselhamos que pergunte ao Copilot que lhe ajude a instalar as extens�es faltantes (caso seja necess�rio).</li>
   <li>Agora com o c�digo pronto podemos explicar como o projeto funciona.</li>
 </ol>

 #### Instru��es de uso do projeto

 Para que seja possivel utilizar o projeto, vamos entender como o mesmo funciona, em duas partes:

 <ol>
   <li><b>Estrutura de arquivos:</b>
   <br>
   <br>
   Se voc� reparar, nosso projeto contem 2 pastas extras al�m das criadas por padr�o ao iniciarmos um novo projeto .MAUI: 
   <br>
   > Services e Views.

   <br>
   <br>
   Onde dentro de nossa pasta Services, temos o arquivo <b>LoginService.cs</b>, que � respons�vel por gerenciar os usu�rios cadastrados no sistema, e a pasta Views, que cont�m as telas de Login e Cadastro.
   <br>
   <br>
   Na pasta de <b>Services</b>, voc� poder� alterar as regras de neg�cio do sistema, como por exemplo, adicionar novos usu�rios, regras para criar um novo usu�rio, interpola��o com banco de dados, etc.
   <br>
   <br>
   J� na pasta <b>Views</b>, voc� encontrar� os arquivos de interface gr�fica, onde poder� alterar a apar�ncia do sistema, como cores, fontes, imagens, e tamb�m a linkagem das mesmas e outras poss�veis p�ginas que voc� desejar em seu projeto. etc.
   <br>
   <br>
   Os outros arquivos criados por padr�o pelo .MAUI, como o App.xaml.cs, foram ligeiramente alterados para se encaixar ao conceito do projeto,
   mas voc� pode alter�-los como desejar, uma vez que todas as altera��es foram descritas atrav�s de coment�rios para auxiliar a compreens�o.
   <br>
   <br>
   Lembrandro que o projeto � um exemplo b�sico de como utilizar o .MAUI, e n�o possui uma l�gica de neg�cio complexa, portanto, sinta-se livre para alter�-lo como desejar.
   </li>

   <br>
   <br>
   <li><b>Utiliza��o na pr�tica (janelas do projeto) :</b>

   Ao pedirmos a nossa IDE para rodar o projeto, ela ir� abrir uma janela de Login, onde voc� poder� utilizar os seguintes usu�rios j� cadastrados:
   > Usuario = "admin", Senha = "123"
   <br>
   > Usuario = "user", Senha = "123"
   <br>
   > Usuario = "guest", Senha = "123"

   <br>
   <br>
   Onde os mesmos possuem acesso padr�o ao nosso sistema, onde caso voc� logar com os mesmos, ser� diferecionado a tela 'Protegida', onde poder� deslogar.
   <br>
   <br>
   Al�m disso, em nossa tela de Login, voc� encontrar� um bot�o 'Cadastrar', onde ao clicar, ser� direcionado a tela de Cadastro, onde poder� cadastrar novos usu�rios para o sistema, onde ao cadastrar-se, automaticamente ser� direcionado a tela 'protegida'.
   <br>
   <br>
   E por fim, o nosso projeto conta tamb�m com algumas condi��es de erro, como por exemplo, caso o usu�rio n�o exista, ou a senha esteja incorreta, o sistema ir� acusar o erro e n�o permitir� o acesso ao sistema. Buscando sempre manter a seguran�a do sistema.
 </ol>

 Outro ponto interessante de nosso projeto se diz respeito a sua portabilidade, uma vez que o mesmo foi desenvolvido utilizando o .MAUI, ele pode ser executado em diversas plataformas, como Windows, MacOS, Android e iOS, sem a necessidade de grandes altera��es no c�digo.
 
 Caso voc� tenha interesse em aprender mais sobre o .MAUI, recomendo que acesse a documenta��o oficial do .NET MAUI, onde voc� encontrar� diversos tutoriais e exemplos de como utilizar a framework: <a href="https://learn.microsoft.com/pt-br/dotnet/maui/" target="blank">Documenta��o Oficial</a>.

 Deixarem tamb�m o link da documenta��o que te auxiliar� a configurar o emulador Android em seu Visual Studio, onde o mesmo explica como criar um novo emulador e assim voc� poder� ver em tempo real como seu projeto .MAUI esta ficando no android: <a href="https://learn.microsoft.com/pt-br/dotnet/maui/android/emulator/device-manager?view=net-maui-9.0" target="blank">Clique aqui</a>.

 ## Algumas imagens do projeto:

 Tela de Login:
 <br>
 <br>
 <img src="MauiAppLogin/Resources/Images/tela_login.png" alt="Tela de Login do projeto" width="400"/>
 <br>
 <br>
 Tela de Cadastro:
 <br>
 <br>
 <img src="MauiAppLogin/Resources/Images/tela_cadastro.png" alt="Tela de Cadastro do projeto" width="400"/>
 <br>
 <br>
 Tela Protegida (ap�s login):
 <br>
 <br>
 <img src="MauiAppLogin/Resources/Images/tela_protegida.png" alt="Tela Protegida do projeto" width="400"/>

 ## Considera��es finais

 Lembrando mais uma vez que o projeto � um exemplo b�sico de como utilizar o .MAUI, e n�o possui uma l�gica de neg�cio complexa, portanto, sinta-se livre para alter�-lo como desejar.
 E caso tenha alguma d�vida ou sugest�o, sinta-se � vontade para entrar em contato comigo atrav�s do meu e-mail: <a href="mailto:pedrosassss@hotmail.com">pedrosassss@hotmail.com</a>: