using Xamarin.Forms;

namespace TitleIconBug
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            MasterBehavior = MasterBehavior.Popover;

            Master = new ContentPage { Title = "Menu" };

            var detailPage = new ContentPage();
            NavigationPage.SetTitleIcon(detailPage, "my_icon");

            Detail = new NavigationPage(detailPage);
        }
    }
}
