namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        String caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");

        public MainPage()
        {
            InitializeComponent();
        }
        private void Apagarbtn_Clicked(object sender, EventArgs e)
        {

        }

        private void Salvarbtn_Clicked(object sender, EventArgs e)
        {
            String conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho , conteudo);
        }
    }

}
