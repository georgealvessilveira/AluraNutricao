using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AluraNutricao
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage ()
		{
            var refeicoes = new List<Refeicao>();
            Children.Add(new CadastroRefeicao(refeicoes));
            Children.Add(new ListaRefeicoes(refeicoes));
		}
	}
}