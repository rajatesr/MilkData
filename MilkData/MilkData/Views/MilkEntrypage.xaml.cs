using MilkData.ViewModels;
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
	public partial class MilkEntrypage : ContentPage
	{
		public MilkEntrypage ()
		{
			InitializeComponent ();
            BindingContext = new MilkEntryViewModels();
            MilkDate.MaximumDate = DateTime.Now;
            MilkDate.Date = DateTime.Now;

        }
	}
}