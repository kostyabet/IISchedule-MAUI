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

        public async void OnButtonClick(object sender, EventArgs e)
        {
            await MopupService.Instance.PushAsync(new PopupPage());
        }
    }
}
