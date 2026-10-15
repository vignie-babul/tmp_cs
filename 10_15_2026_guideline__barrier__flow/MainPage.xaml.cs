//using androidx.constraintlayout.core.widgets;

using Microsoft.Maui.Controls.Shapes;
using SharpConstraintLayout.Maui.Widget;
using SharpConstraintLayout.Maui.Helper.Widget;


namespace main
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
		//InitializeComponent(); // для MainPage.xaml

		//ConstraintLayout main = new ConstraintLayout() {
		//    BackgroundColor = Colors.LightGray,
		//};

		//var RECT_SIZE = 0f;

		//const int RECT_CORNER_WEIGHT = 1;
		//Color RECT_CORNER_COLOR = Colors.Blue;

		//const int RECT_CENTER_WEIGHT = 4;
		//Color RECT_CENTER_COLOR = Colors.Magenta;

		//var rect_top_left = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CORNER_COLOR};
		//var rect_top_right = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CORNER_COLOR};
		//var rect_bottom_left = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CORNER_COLOR};
		//var rect_bottom_right = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CORNER_COLOR};
		//var rect_center = new Microsoft.Maui.Controls.Shapes.Rectangle() {Fill = RECT_CENTER_COLOR};

		//main.Add(rect_top_left);
		//main.Add(rect_top_right);
		//main.Add(rect_bottom_left);
		//main.Add(rect_bottom_right);
		//main.Add(rect_center);

		//FluentConstraintSet set = new FluentConstraintSet();

		//set.Select(rect_top_left)
		//    .Width(RECT_SIZE).Height(RECT_SIZE)
		//    .XWeight(RECT_CORNER_WEIGHT).YWeight(RECT_CORNER_WEIGHT)
		//    .LeftToLeft(main).TopToTop(main)
		//    .RightToLeft(rect_center).BottomToTop(rect_center);

		//set.Select(rect_top_right)
		//    .Width(RECT_SIZE).Height(RECT_SIZE)
		//    .XWeight(RECT_CORNER_WEIGHT).YWeight(RECT_CORNER_WEIGHT)
		//    .RightToRight(main).TopToTop(main)
		//    .LeftToRight(rect_center).BottomToTop(rect_center);

		//set.Select(rect_bottom_left)
		//    .Width(RECT_SIZE).Height(RECT_SIZE)
		//    .XWeight(RECT_CORNER_WEIGHT).YWeight(RECT_CORNER_WEIGHT)
		//    .LeftToLeft(main).BottomToBottom(main)
		//    .RightToLeft(rect_center).TopToBottom(rect_center);

		//set.Select(rect_bottom_right)
		//    .Width(RECT_SIZE).Height(RECT_SIZE)
		//    .XWeight(RECT_CORNER_WEIGHT).YWeight(RECT_CORNER_WEIGHT)
		//    .RightToRight(main).BottomToBottom(main)
		//    .LeftToRight(rect_center).TopToBottom(rect_center);

		//set.Select(rect_center)
		//    .Width(RECT_SIZE).Height(RECT_SIZE)
		//    .XWeight(RECT_CENTER_WEIGHT).YWeight(RECT_CENTER_WEIGHT)
		//    .LeftToRight(rect_top_left).RightToLeft(rect_top_right)
		//    .TopToBottom(rect_top_left).BottomToTop(rect_bottom_left);

		//set.ApplyTo(main);

		//Content = main;



		ConstraintLayout main = new ConstraintLayout() {
			BackgroundColor = Colors.LightGray,
		};

		//var guideline_left = new Guideline();
		//var guideline_right = new Guideline();
		//var guideline_margin = new Guideline();

		//var rect_1 = new Rectangle() { Fill = Colors.Red };
		//var rect_2 = new Rectangle() { Fill = Colors.Blue };
		//var rect_3 = new Rectangle() { Fill = Colors.Green };

		//main.Add(guideline_left);
		//main.Add(guideline_right);
		//main.Add(guideline_margin);

		//main.Add(rect_1);
		//main.Add(rect_2);
		//main.Add(rect_3);

		FluentConstraintSet set = new FluentConstraintSet();

		//set.Select(guideline_left).GuidelineOrientation(Orientation.Y).GuidelinePercent(0.1f);
		//set.Select(guideline_right).GuidelineOrientation(Orientation.Y).GuidelinePercent(0.9f);
		//set.Select(guideline_margin).GuidelineOrientation(Orientation.Y).GuidelinePercent(10f);



		// ---------------------------------------------------------------- guideline
		//Guideline guidelineLeft = new Guideline();
		//Guideline guidelineRight = new Guideline();
		//Guideline guidelineMargin = new Guideline();

		//Rectangle r1 = new Rectangle() { BackgroundColor = Colors.Red };
		//Rectangle r2 = new Rectangle() { BackgroundColor = Colors.Blue };
		//Rectangle r3 = new Rectangle() { BackgroundColor = Colors.Green };

		//main.Add(guidelineLeft);
		//main.Add(guidelineRight);
		//main.Add(guidelineMargin);

		//main.Add(r1);
		//main.Add(r2);
		//main.Add(r3);

		//set.Select(guidelineLeft).GuidelineOrientation(Orientation.Y).GuidelinePercent(0.1f);
		//set.Select(guidelineRight).GuidelineOrientation(Orientation.Y).GuidelinePercent(0.9f);
		//set.Select(guidelineMargin).GuidelineOrientation(Orientation.Y).GuidelineEnd(10f);

		//set.Select(r1).Width(0f).Height(100f).LeftToLeft(guidelineLeft).RightToRight(guidelineRight);
		//set.Select(r2).Width(0f).Height(100f).TopToBottom(r1).LeftToLeft(guidelineLeft).RightToRight(guidelineMargin);
		//set.Select(r3).Width(0f).Height(100f).TopToBottom(r2).LeftToLeft(guidelineRight).RightToRight(guidelineMargin);


		// ------------------------------------------------------------------ barrier
		//Rectangle A = new Rectangle() { BackgroundColor = Colors.Red };
		//Rectangle B = new Rectangle() { BackgroundColor = Colors.Blue };
		//Rectangle C = new Rectangle() { BackgroundColor = Colors.Green };
		//var barrier = new SharpConstraintLayout.Maui.Widget.Barrier();

		//main.Add(A);
		//main.Add(B);
		//main.Add(C);
		//main.Add(barrier);

		//set.Select(A).Width(100).Height(100);
		//set.Select(B).Width(100).Height(300);
		//set.Select(C).Width(100).Height(100);

		//set.Select(B).LeftToRight(A,10);
		//set.Select(barrier).Barrier(Direction.Bottom,10f,[A,B]);
		//set.Select(C).TopToBottom(barrier);


		// --------------------------------------------------------------------- flow
		//Flow f2 = new Flow();
		//for(int i = 0;i < 10;i++) {
		//    var b = new Button() { Text = $"Button {i + 1}" };
		//    main.Add(b);
		//    set.Select(b).Width(100).Height(50);
		//    f2.RefElement(b);
		//}
		//main.Add(f2);

		//f2.SetWrapMode(Flow.WrapAligned);
		//f2.SetHorizontalGap(10);
		//f2.SetVerticalGap(10);



		set.ApplyTo(main);
		Content = main;
		}
	}
}
