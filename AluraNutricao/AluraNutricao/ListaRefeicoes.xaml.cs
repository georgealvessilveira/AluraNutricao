using System.Collections.Generic;
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
	}
}