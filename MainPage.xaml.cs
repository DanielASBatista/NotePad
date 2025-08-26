using Windows.Media.AppBroadcasting;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        String caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");

        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(caminho))
            {
                CaixaEditor.Text = File.ReadAllText(caminho);
            }
            
        }
        private void Apagarbtn_Clicked(object sender, EventArgs e)
        {
            
            if (File.Exists(caminho))
            {
                
                File.Delete(caminho);
                CaixaEditor.Text = string.Empty;
                DisplayAlert("Arquivo apagado", "Arquivo apagado com sucesso", "OK");
            }
            else
            {
                DisplayAlert("Arquivo inexistente", "O arquivo ja foi Apagado ou não existe.", "OK");
            }

        }

        private void Salvarbtn_Clicked(object sender, EventArgs e)
        {
            String conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho , conteudo);
            DisplayAlert($"Arquivo salvo",conteudo + " salvo em: " + caminho , "OK");
        }
    }

}
