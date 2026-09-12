namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void GirarMoeda(object? sender, EventArgs e)
        {
            string EscolhaDoUsuario = BotaoListaOpcoes.SelectedItem.ToString();


            Random Moeda = new Random();
            int LadoSorteado = Moeda.Next(2);

        }

        private void OpcaoSelecionadaPicker(object? sender, EventArgs e)
        {
            

        }
    }
}
