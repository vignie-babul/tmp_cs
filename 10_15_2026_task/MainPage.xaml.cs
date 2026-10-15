using Microsoft.Maui.Controls.Shapes;
using SharpConstraintLayout.Maui.Widget;
using SharpConstraintLayout.Maui.Helper.Widget;


namespace main
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			const int MARGIN = 10;

			const int BUTTON_ADD_CARD_HEIGHT = 50;

			const int CARD_BUTTON_HEIGHT = 50;
			const int CARD_WIDTH = 150;
			const int CARD_HEIGHT = CARD_WIDTH + MARGIN + CARD_BUTTON_HEIGHT;

			int global_card_counter = 0;


			ConstraintLayout screen = new ConstraintLayout() {
				BackgroundColor = Colors.LightGray,
			};
			FluentConstraintSet set = new FluentConstraintSet();
			SharpConstraintLayout.Maui.Widget.Barrier barrier = new SharpConstraintLayout.Maui.Widget.Barrier();

			Flow flow = new Flow();
			flow.SetWrapMode(Flow.WrapAligned);
			flow.SetHorizontalGap(MARGIN);
			flow.SetVerticalGap(10);


			//HashSet<ConstraintLayout> cards = new HashSet<ConstraintLayout>();


			//void remove_card(object sender, System.EventArgs e)
			//{
			//	cards.Select((Button)sender);
			//	cards.Remove(sender.);
			//}


			void add_card(object sender, System.EventArgs e)
			{
				global_card_counter++;

				ConstraintLayout card_frame = new ConstraintLayout() {
					WidthRequest = CARD_WIDTH,
					HeightRequest = CARD_HEIGHT,
				};
				Image card_image = new Image() { Source = "dotnet_bot.png" };
				Button card_button = new Button() { Text = $"{global_card_counter}" };
				//card_button.Clicked += remove_card;

				card_frame.Add(card_image);
				card_frame.Add(card_button);

				set.Select(card_image)
					.Width(0f).Height(CARD_WIDTH)
					.TopToTop(card_frame).LeftToLeft(card_frame).RightToRight(card_frame);

				set.Select(card_button)
					.Width(0f).Height(CARD_BUTTON_HEIGHT)
					.BottomToBottom(card_frame).LeftToLeft(card_frame).RightToRight(card_frame);
			
				set.ApplyTo(card_frame);

				screen.Add(card_frame);
				flow.RefElement(card_frame);

				//cards.Add(card_frame);
			}


			Guideline guideline_left = new Guideline();
			Guideline guideline_right = new Guideline();

			Button button_add_card = new Button() { Text = "Добавить" };
			button_add_card.Clicked += add_card;


			screen.Add(guideline_left);
			screen.Add(guideline_right);

			screen.Add(button_add_card);
			screen.Add(barrier);
			screen.Add(flow);


			set.Select(guideline_left).GuidelineOrientation(Orientation.Y).GuidelinePercent(0.1f);
			set.Select(guideline_right).GuidelineOrientation(Orientation.Y).GuidelinePercent(0.9f);

			set.Select(button_add_card)
				.Width(0f).Height(BUTTON_ADD_CARD_HEIGHT)
				.TopToTop(screen)
				.LeftToLeft(guideline_left).RightToRight(guideline_right);

			set.Select(barrier).Barrier(Direction.Bottom, MARGIN, button_add_card);
			set.Select(flow)
				.TopToBottom(barrier)
				.LeftToLeft(guideline_left).RightToRight(guideline_right);

			set.ApplyTo(screen);

			Content = screen;
		}
	}
}
