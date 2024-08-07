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
    }
}
