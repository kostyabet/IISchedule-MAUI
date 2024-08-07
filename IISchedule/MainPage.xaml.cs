using IISchedule.Services;
using IISchedule.Models.LastScheduleUpdate;

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
            var Items = await _scheduleService.GetLastScheduleUpdateDate(UpdateType.Employee, "s-nesterenkov");
            if (Items == null)
            {
                AllGroupsView.Text = "Error while reading API";
            }
            else
            {
                AllGroupsView.Text = $"{Items.lastUpdateDate}\n";
            }
        }
    }

}
