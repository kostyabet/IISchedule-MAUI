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
            var Items = await _scheduleService.GetRelevantDepartmentAnnouncements(20003);
            if (Items == null)
            {
                AllGroupsView.Text = "Error while reading API";
            }
            else
            {
                string groupsNums = string.Empty;
                foreach (var item in Items)
                {
                    groupsNums += $"{item.date}\n";
                }
                AllGroupsView.Text = groupsNums;
            }
        }
    }

}
