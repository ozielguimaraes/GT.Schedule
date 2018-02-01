using System;
using System.Threading.Tasks;
using GT.Schedule.Pages.DNA;
using Xamarin.Forms;

namespace GT.Schedule
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    OpenCalendar.Clicked += async (sender, args) => await OnButtonClicked(sender, args);
        }

	    private static async Task OnButtonClicked(object sender, EventArgs e)
	    {
            var page = new WeeklyDna();

            await Application.Current.MainPage.Navigation.PushAsync(page);
	    }
    }
}