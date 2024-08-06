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

        private async void OnGroupClicked(object sender, EventArgs e)
        {
            string groupNumber = GroupInput.Text;
            var Items = await _scheduleService.GetGroupSchedule(groupNumber);
            if (Items == null)
            {
                GroupView.Text = "Error while reading API";
            }
            else
            {
                GroupView.Text = Items.studentGroupDto.specialityName;
            }
        }

        private async void OnEmployeeClicked(object sender, EventArgs e)
        {
            string urlId = EmployeeInput.Text;
            var Items = await _scheduleService.GetEmployeeSchedule(urlId);
            if (Items == null)
            {
                EmpoyeeView.Text = "Error while reading API";
            }
            else
            {
                EmpoyeeView.Text = Items.employeeDto.firstName;
            }
        }

        private async void OnAllGroupsClicked(object sender, EventArgs e)
        {
            var Items = await _scheduleService.GetAllGroups();
            if (Items == null)
            {
                AllGroupsView.Text = "Error while reading API";
            }
            else
            {
                string groupsNums = string.Empty;
                foreach (var item in Items)
                {
                    groupsNums += $"{item.name}\n";
                }
                AllGroupsView.Text = groupsNums;
            }
        }
    }

}
