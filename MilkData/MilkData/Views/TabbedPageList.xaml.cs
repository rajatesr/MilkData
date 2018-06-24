using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MilkData.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedPageList : TabbedPage
	{
		public TabbedPageList ()
		{
			InitializeComponent ();

            Children.Add(new MilkEntrypage());
            Children.Add(new DialyListPage());
		}
	}
}