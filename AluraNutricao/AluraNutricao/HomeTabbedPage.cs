using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AluraNutricao
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage ()
		{
            var refeicoes = new ObservableCollection<Refeicao>();
            Children.Add(new CadastroRefeicao(refeicoes));
            Children.Add(new ListaRefeicoes(refeicoes));
		}
	}
}