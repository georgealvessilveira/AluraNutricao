using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AluraNutricao
{
	public partial class CadastroRefeicao : ContentPage
	{
        public ObservableCollection<Refeicao> Refeicoes { get; set; }

		public CadastroRefeicao(ObservableCollection<Refeicao> refeicoes)
		{
            Refeicoes = refeicoes;
            InitializeComponent();
		}

        public void AtualizaContador(Object sender, EventArgs e)
        {
            lblCalorias.Text = stpCalorias.Value.ToString();
        }

        public void SalvaRefeicao(Object sender, EventArgs e)
        {
            string descricao = entDescricao.Text;
            double valor = stpCalorias.Value;

            var refeicao = new Refeicao(descricao, valor);
            Refeicoes.Add(refeicao);

            string msg = "A refeição " + descricao + " de " + valor + " calorias foi salva com sucesso";
            DisplayAlert("Salvar Refeição", msg, "OK");
            Clear();
        }

        public void Clear()
        {
            entDescricao.Text = "";
            stpCalorias.Value = 10.0;
        }
	}
}
