using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;
using SharpConstraintLayout.Maui.Helper.Widget;
using SharpConstraintLayout.Maui.Widget;
using System.Collections.Generic;


namespace main {
	public partial class MainPage:ContentPage {
		private const int MARGIN = 10;

		private const int BUTTON_ADD_CARD_HEIGHT = 50;

		private const int CARD_BUTTON_HEIGHT = 50;
		private const int CARD_WIDTH = 150;
		private const int CARD_HEIGHT = CARD_WIDTH + MARGIN + CARD_BUTTON_HEIGHT;

		private int global_card_counter = 0;

		private HashSet<int> deleted_cards_indexes = new HashSet<int>();

		public MainPage() {
			ConstraintLayout screen = new ConstraintLayout() {
				BackgroundColor = Colors.LightGray,
			};

			FluentConstraintSet set = new FluentConstraintSet();
			SharpConstraintLayout.Maui.Widget.Barrier barrier = new SharpConstraintLayout.Maui.Widget.Barrier();

			FlexLayout flex = new FlexLayout() {
				AlignContent = FlexAlignContent.Start,
				Wrap = FlexWrap.Wrap,
				JustifyContent = FlexJustify.Start,
			};

			void AddCard(object sender, System.EventArgs args) {
				int current_card_index;

				if (deleted_cards_indexes.Count > 0) {
					HashSet<int>.Enumerator enumerator = deleted_cards_indexes.GetEnumerator();
					enumerator.MoveNext();

					current_card_index = enumerator.Current;
					deleted_cards_indexes.Remove(current_card_index);
				} else {
					global_card_counter++;
					current_card_index = global_card_counter;
				}

				ConstraintLayout card_frame = new ConstraintLayout() {
					WidthRequest = CARD_WIDTH,
					HeightRequest = CARD_HEIGHT,
					Margin = MARGIN,
				};
				Image card_image = new Image() { Source = "dotnet_bot.png" };
				Button card_button = new Button() { Text = current_card_index.ToString() };

				card_button.Clicked += (sender, ars) => {
					flex.Remove(card_frame);
					deleted_cards_indexes.Add(Int32.Parse(card_button.Text));
				};

				card_frame.Add(card_image);
				card_frame.Add(card_button);

				set.Select(card_image)
					.Width(0f).Height(CARD_WIDTH)
					.TopToTop(card_frame).LeftToLeft(card_frame).RightToRight(card_frame);

				set.Select(card_button)
					.Width(0f).Height(CARD_BUTTON_HEIGHT)
					.BottomToBottom(card_frame).LeftToLeft(card_frame).RightToRight(card_frame);

				set.ApplyTo(card_frame);

				flex.Add(card_frame);
			}


			Guideline guideline_left = new Guideline();
			Guideline guideline_right = new Guideline();

			Button button_add_card = new Button() { Text = "Добавить" };
			button_add_card.Clicked += AddCard;


			screen.Add(guideline_left);
			screen.Add(guideline_right);

			screen.Add(button_add_card);
			screen.Add(barrier);
			screen.Add(flex);


			set.Select(guideline_left).GuidelineOrientation(Orientation.Y).GuidelinePercent(0.1f);
			set.Select(guideline_right).GuidelineOrientation(Orientation.Y).GuidelinePercent(0.9f);

			set.Select(button_add_card)
				.Width(0f).Height(BUTTON_ADD_CARD_HEIGHT)
				.TopToTop(screen)
				.LeftToLeft(guideline_left).RightToRight(guideline_right);

			set.Select(barrier).Barrier(Direction.Bottom,MARGIN,button_add_card);
			set.Select(flex)
				.TopToBottom(barrier)
				.LeftToLeft(guideline_left).RightToRight(guideline_right);

			set.ApplyTo(screen);

			Content = screen;
		}
	}
}
