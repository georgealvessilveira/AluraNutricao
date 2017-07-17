using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AluraNutricao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaRefeicoes : ContentPage
	{
        public ObservableCollection<Refeicao> Refeicoes { get; set; }

		public ListaRefeicoes(ObservableCollection<Refeicao> refeicoes)
		{
            Refeicoes = refeicoes;
            BindingContext = this;
            InitializeComponent();
		}

        public async void AcaoItem(object sender, ItemTappedEventArgs e)
        {
            var refeicao = e.Item as Refeicao;
            bool resposta = await DisplayAlert("Remover item", "Você tem certeza que deseja remover o item " + refeicao.Descricao + "?", "Sim", "Não");

            if (resposta)
            {
                Refeicoes.Remove(refeicao);
                await DisplayAlert("Remover item", "Item removido com sucesso", "OK");
            }
        }
	}
}