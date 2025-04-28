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
			RowSpacing = 5,
			ColumnSpacing = 5,
		};

		var img = new Image
		{
			BackgroundColor = Colors.Transparent,
			Source = "dotnet_bot.png",
		};
		var entry = new Entry
		{
            Placeholder = "Enter Task",
        };
		var btn1 = new Button
		{
			Text = "Add Task",
        };

		var TaskCollection = new CollectionView
		{
			ItemsSource = new List<string>
            {
                "Task 1",
                "Task 2",
                "Task 3",
                "Task 4",
                "Task 5",
                "Task 6",
                "Task 7",
            },

			ItemTemplate = new DataTemplate(() =>
			{
				var sw = new SwipeView() { RightItems = { new SwipeItem {Text="Delete",BackgroundColor=Colors.Red }, }};
                var grid = new Grid{ Padding = 10, };
				var frame = new Frame();
				var lbl = new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
					FontSize = 24,
                };
                lbl.SetBinding(Label.TextProperty, ".");
				frame.Content = lbl;
				grid.Add(frame);
                grid.SetColumnSpan(frame, 2);
				sw.Content = grid;
                return sw;
            })
        };

        //Image
        grid.Add(img);
        grid.SetColumnSpan(img, 2);
        //Input
		grid.Add(entry, 0, 1);	
		//Button
		grid.Add(btn1, 1, 1);
		//TaskCollection
		grid.Add(TaskCollection, 0, 2);
		grid.SetColumnSpan(TaskCollection, 2);

        Content = grid;
    }
}