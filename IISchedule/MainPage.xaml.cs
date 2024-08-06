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

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            string groupNumber = GroupInput.Text;
            var Items = await _scheduleService.GetGroupSchedule(groupNumber);
            if (Items == null)
            {
                TaskView.Text = "Error while reading API";
            }
            else
            {
                TaskView.Text = Items.studentGroupDto.specialityName;
            }
        }
    }

}
