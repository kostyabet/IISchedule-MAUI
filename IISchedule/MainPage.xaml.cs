using IISchedule.Pages;
using Mopups.Services;

namespace IISchedule
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnButtonClick(object sender, EventArgs e)
        {
            MopupService.Instance.PushAsync(new PopupPage());
        }
    }
}
