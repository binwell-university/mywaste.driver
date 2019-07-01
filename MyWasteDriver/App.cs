using MyWasteDriver.DAL.DataServices;
using MyWasteDriver.UI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyWasteDriver
{
	public class App : Application
	{
		public App ()
		{
			DialogService.Init(this);
			NavigationService.Init(this);
			DataServices.Init(true);
		}

		protected override void OnStart ()
		{
			//NavigationService.Instance.SetMainPage(AppPages.Login);
			NavigationService.Instance.SetMainMasterDetailPage(AppPages.Menu, AppPages.Points);
		}
	}
}

