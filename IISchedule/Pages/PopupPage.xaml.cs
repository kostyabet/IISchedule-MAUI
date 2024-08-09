using Mopups.Services;

namespace IISchedule.Pages;

public partial class PopupPage
{
	public PopupPage()
	{
		InitializeComponent();
	}

    public async void OnSetScheduleClick(object sender, EventArgs e)
	{
        await MopupService.Instance.PopAsync();
        await MopupService.Instance.PushAsync(new SearchSchedule.SearchSchedule());
    }
}