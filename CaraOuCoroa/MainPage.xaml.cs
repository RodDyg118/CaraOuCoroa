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


            LabelResultadoSorteio.Text = LadoSorteado.ToString();

            if (LadoSorteado == 0)
            {
                string ReCara = "Cara";
                LabelResultadoSorteio.Text = ReCara.ToString();
                if (EscolhaDoUsuario == LabelResultadoSorteio.Text)
                {
                    ResultadoVouD.Text = "Resultado: Vitoria".ToString();
                }
                else
                {
                    ResultadoVouD.Text = "Resultado: Derrota".ToString();
                }

            }
            else
            {
                string ReCoroa = "Coroa";
                LabelResultadoSorteio.Text = ReCoroa.ToString();

                if (EscolhaDoUsuario == LabelResultadoSorteio.Text)
                {
                    ResultadoVouD.Text = "Resultado: Vitoria".ToString();
                }
                else
                {
                    ResultadoVouD.Text = "Resultado: Derrota".ToString();
                }

                

            }
        }


        

        private void OpcaoSelecionadaPicker(object? sender, EventArgs e)
        {
            

        }
    }
}
