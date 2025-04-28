namespace QvaMAUI;

public class TasksPage : ContentPage
{
	public TasksPage()
	{

		Grid grid = new Grid
		{
			RowDefinitions =
			{
						new RowDefinition {Height = new GridLength(100, GridUnitType.Absolute)},
                        new RowDefinition {Height = GridLength.Auto},
                        new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
            },
			ColumnDefinitions =
			{
						new ColumnDefinition { Width = new GridLength(0.75, GridUnitType.Star)},
                        new ColumnDefinition { Width = new GridLength(0.25, GridUnitType.Star)},
            },

			Padding = 10,
		};

		var img = new Image
		{
			BackgroundColor = Colors.Orange,
			Source = "dotnet_bot.png",
		};
        var label = new Label
		{
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Text = "Welcome to .NET MAUI!"
		};
		var entry = new Entry
		{
            Placeholder = "Enter Task",
        };
		var btn1 = new Button
		{
			Text = "Add Task",
        };

        grid.Add(img);
        grid.SetColumnSpan(img, 2);
        grid.Add(label,0,1);
		grid.SetColumnSpan(label, 2);
        grid.Add(entry, 0, 1);	
		grid.Add(btn1, 1, 1);
        Content = grid;

    }
}