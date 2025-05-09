namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        Game jogo = new Game();
        Dice dado = new Dice();

        public MainPage()
        {
            InitializeComponent();
        }

        private void RollButton_Clicked(object sender, EventArgs e)
        {
            int resultado1 = dado1.Roll();
            int resultado2 = dado2.Roll();

            // Atualiza as imagens dos dados conforme o resultado
            Dado1Imagem.Source = $"dice{resultado1}.png";
            Dado2Imagem.Source = $"dice{resultado2}.png";

            // Verifica se o jogador escolheu uma soma
            if (EscolhaJogador.SelectedIndex != -1)
            {
                int escolha = EscolhaJogador.SelectedIndex + 2; // Soma varia de 2 a 12
                bool venceu = jogo.CheckResult(resultado1, resultado2, escolha);

                SomaDadosLabel.Text = $"Soma dos dados: {jogo.UltimaSomaDosDados}";

                if (venceu)
                    DisplayAlert("Parabéns", $"Você acertou! Soma: {jogo.UltimaSomaDosDados}", "Ok!");
                else
                    DisplayAlert("Que pena!", $"Resultado: {jogo.UltimaSomaDosDados}, tente novamente!", "Ok!");

                TotalVitoriasLabel.Text = $"Vitórias totais: {jogo.TotalVitorias}";
                VitoriasSequenciaLabel.Text = $"Vitórias seguidas: {jogo.VitoriaSequencia}";
            }
            else
            {
                DisplayAlert("Escolha um número", "Selecione uma soma antes de rolar os dados.", "Ok!");
            }
        }

    }

