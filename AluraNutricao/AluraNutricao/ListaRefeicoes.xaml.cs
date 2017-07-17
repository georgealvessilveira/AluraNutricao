using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AluraNutricao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaRefeicoes : ContentPage
	{
        public List<Refeicao> Refeicoes { get; set; }

		public ListaRefeicoes(List<Refeicao> refeicoes)
		{
            Refeicoes = refeicoes;
            BindingContext = this;
            InitializeComponent();
		}
	}
}