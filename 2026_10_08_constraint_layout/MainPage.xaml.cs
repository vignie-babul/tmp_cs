using androidx.constraintlayout.core.widgets;
using Microsoft.Maui.Controls.Shapes;
using SharpConstraintLayout.Maui.Widget;

namespace main
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			//InitializeComponent(); // для MainPage.xaml

			//ConstraintLayout main = new ConstraintLayout()
			//{
			//    BackgroundColor = Colors.LightGray,
			//};

			//Button button_1 = new Button() { Text = "1", };
			//Button button_2 = new Button() { Text = "2", };
			//Button button_3 = new Button() { Text = "3", };
			//Button button_4 = new Button() { Text = "4", };
			//Button button_5 = new Button() { Text = "5", };

			//main.Add(button_1);
			//main.Add(button_2);
			//main.Add(button_3);
			//main.Add(button_4);
			//main.Add(button_5);

			//FluentConstraintSet set = new FluentConstraintSet();

			//set.Select(button_1).LeftToLeft(main).RightToRight(main).CenterTo(main);
			//set.Select(button_2).Width(0f);
			//set.Select(button_2).TopToBottom(button_1).LeftToLeft(main).RightToRight(button_1);
			//set.Select(button_3).Width(200f);
			//set.Select(button_4).Width(200f);
			//set.Select(button_5).Width(200f);
			//set.CreateXChain(main, Edge.Left, main, Edge.Right, [button_3, button_4, button_5], [1, 2, 1], ChainStyle.Spread);

			//set.ApplyTo(main);

			//Content = main;



			ConstraintLayout main = new ConstraintLayout() {
				BackgroundColor = Colors.LightGray,
			};

			var RECT_SIZE = 0f;

			const int RECT_CORNER_WEIGHT = 1;
			Color RECT_CORNER_COLOR = Colors.Blue;

			const int RECT_CENTER_WEIGHT = 4;
			Color RECT_CENTER_COLOR = Colors.Magenta;

			var rect_top_left = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CORNER_COLOR};
			var rect_top_right = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CORNER_COLOR};
			var rect_bottom_left = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CORNER_COLOR};
			var rect_bottom_right = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CORNER_COLOR};
			var rect_center = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CENTER_COLOR};

			main.Add(rect_top_left);
			main.Add(rect_top_right);
			main.Add(rect_bottom_left);
			main.Add(rect_bottom_right);
			main.Add(rect_center);

			FluentConstraintSet set = new FluentConstraintSet();

			set.Select(rect_top_left)
				.Width(RECT_SIZE).Height(RECT_SIZE)
				.XWeight(RECT_CORNER_WEIGHT).YWeight(RECT_CORNER_WEIGHT)
				.LeftToLeft(main).TopToTop(main)
				.RightToLeft(rect_center).BottomToTop(rect_center);

			set.Select(rect_top_right)
				.Width(RECT_SIZE).Height(RECT_SIZE)
				.XWeight(RECT_CORNER_WEIGHT).YWeight(RECT_CORNER_WEIGHT)
				.RightToRight(main).TopToTop(main)
				.LeftToRight(rect_center).BottomToTop(rect_center);

			set.Select(rect_bottom_left)
				.Width(RECT_SIZE).Height(RECT_SIZE)
				.XWeight(RECT_CORNER_WEIGHT).YWeight(RECT_CORNER_WEIGHT)
				.LeftToLeft(main).BottomToBottom(main)
				.RightToLeft(rect_center).TopToBottom(rect_center);

			set.Select(rect_bottom_right)
				.Width(RECT_SIZE).Height(RECT_SIZE)
				.XWeight(RECT_CORNER_WEIGHT).YWeight(RECT_CORNER_WEIGHT)
				.RightToRight(main).BottomToBottom(main)
				.LeftToRight(rect_center).TopToBottom(rect_center);

			set.Select(rect_center)
				.Width(RECT_SIZE).Height(RECT_SIZE)
				.XWeight(RECT_CENTER_WEIGHT).YWeight(RECT_CENTER_WEIGHT)
				.LeftToRight(rect_top_left).RightToLeft(rect_top_right)
				.TopToBottom(rect_top_left).BottomToTop(rect_bottom_left);

			set.ApplyTo(main);

			Content = main;
		}
	}
}
