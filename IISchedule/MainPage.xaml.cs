using IISchedule.Services;

namespace IISchedule
{
    public partial class MainPage : ContentPage
    {
        private readonly ScheduleService _scheduleService;
        public MainPage()
        {
            InitializeComponent();
            _scheduleService = new ScheduleService(new HttpClient());
        }
        private async void OnAllGroupsClicked(object sender, EventArgs e)
        {
            var Items = await _scheduleService.GetCurrentWeek();
            if (Items == 0)
            {
                AllGroupsView.Text = "Error while reading API";
            }
            else
            {
                AllGroupsView.Text = $"{Items}\n";
            }
        }
    }

}
