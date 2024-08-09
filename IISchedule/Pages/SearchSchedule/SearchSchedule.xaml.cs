using IISchedule.Models.OutputModels;
using IISchedule.Services;
using MvvmHelpers;

namespace IISchedule.Pages.SearchSchedule;

public partial class SearchSchedule
{
    public ObservableRangeCollection<ShortOutputInfo> Groups { get; set; }
    public ObservableRangeCollection<ShortOutputInfo> Employees { get; set; }
    private readonly ScheduleService _scheduleService;

    public SearchSchedule()
    {
		InitializeComponent();
        _scheduleService = new ScheduleService(new HttpClient());
        Groups = new ObservableRangeCollection<ShortOutputInfo>();
        Employees = new ObservableRangeCollection<ShortOutputInfo>();
        LoadEmployeeData();
        LoadGroupData();
    }
	public void OnSaveButtonClicked(object sender, EventArgs e)
	{
        SaveButton.BorderColor = Color.FromRgb(92, 116, 161);
        GroupButton.BorderColor = Color.FromRgb(33, 34, 43);
        EmployeeButton.BorderColor = Color.FromRgb(33, 34, 43);
        EmployeesCollectionView.IsVisible = false;
        GroupsCollectionView.IsVisible = false;
    }

    public void OnGroupButtonClicked(object sender, EventArgs e)
    {
        SaveButton.BorderColor = Color.FromRgb(33, 34, 43);
        GroupButton.BorderColor = Color.FromRgb(92, 116, 161);
        EmployeeButton.BorderColor = Color.FromRgb(33, 34, 43);
        EmployeesCollectionView.IsVisible = false;
        GroupsCollectionView.IsVisible = true;
    }
    private async void LoadGroupData()
    {
        var Items = await _scheduleService.GetAllGroups();
        Groups = new ObservableRangeCollection<ShortOutputInfo>();
        foreach (var item in Items)
        {
            var group = new ShortOutputInfo();
            group.name = item.name;
            group.description = "ФКСИС ПИ";
            Groups.Add(group);
        }
        BindingContext = this;
    }
    public void OnEmployeeButtonClicked(object sender, EventArgs e)
    {
        SaveButton.BorderColor = Color.FromRgb(33, 34, 43);
        GroupButton.BorderColor = Color.FromRgb(33, 34, 43);
        EmployeeButton.BorderColor = Color.FromRgb(92, 116, 161);
        EmployeesCollectionView.IsVisible = true;
        GroupsCollectionView.IsVisible = false;
    }
    private async void LoadEmployeeData()
    {
        var Items = await _scheduleService.GetAllEmployees();
        var BufEmployees = new List<ShortOutputInfo>();
        foreach (var item in Items)
        {
            var employee = new ShortOutputInfo();
            employee.name = item.lastName + " " + item.firstName + " " + item.middleName;
            foreach (var dep in item.academicDepartment)
            {
                employee.description = dep + " ";
            }
            BufEmployees.Add(employee);
        }
        Employees.AddRange(BufEmployees);
    }
}