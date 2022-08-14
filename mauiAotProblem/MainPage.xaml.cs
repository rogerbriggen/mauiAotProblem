using AutoMapper;

namespace mauiAotProblem;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void OnAutomapClicked(object sender, EventArgs e)
    {
		try
		{
            var myDto = new MyDto
            {
                name = "aot-problem",
                count = 2
            };
            var mapperConfig = new MapperConfiguration(cfg => {
                cfg.AddProfile<DtoProfile>();
            });
            var mapper = new Mapper(mapperConfig);
            var myOtherDto = mapper.Map<MyOtherDto>(myDto);
            AutomapLbl.Text = $"Success... {myOtherDto.count}";
        }
		catch(Exception ex)
		{
			AutomapLbl.Text = ex.Message + " " + ex.StackTrace;
		}
		

    }
}

