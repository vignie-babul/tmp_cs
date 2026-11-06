using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;
using System.Collections.Generic;


namespace main
{
	public partial class MainPage:ContentPage
	{
		public class Dish
		{
			public string Name { get; set; }
			public int Price { get; set; }
			public HashSet<string> Ingredients { get; set; }

			public Dish(string name, int price, HashSet<string> ingredients)
			{
				this.Name = name;
				this.Price = price;
				this.Ingredients = ingredients;
			}
		}

		public class Category
		{
			public string Name { get; set; }
			public List<Dish> Dishes { get; set; }

			public Category(string name, List<Dish> dishes)
			{
				this.Name = name;
				this.Dishes = dishes;
			}
		}

		public class Restaurant
		{
			public string Name { get; set; }
			public List<Category> Categories { get; set; }

			public Restaurant(string name, List<Category> categories)
			{
				this.Name = name;
				this.Categories = categories;
			}
		}


		public static List<Dish> restaurant_foo_category_1_dishes { get; set; } = new List<Dish>() {
			new Dish("Ресторан Foo : Категория 1 : Блюдо 1", 100, new HashSet<string>() {"Яблоко", "и другие ингридиенты"}),
			new Dish("Ресторан Foo : Категория 1 : Блюдо 2", 200, new HashSet<string>() {"Яблоко", "и другие ингридиенты"}),
		};
		public static List<Dish> restaurant_foo_category_2_dishes { get; set; } = new List<Dish>() {
			new Dish("Ресторан Foo : Категория 2 : Блюдо 1", 100, new HashSet<string>() {"Яблоко", "и другие ингридиенты"}),
			new Dish("Ресторан Foo : Категория 2 : Блюдо 2", 200, new HashSet<string>() {"Яблоко", "и другие ингридиенты"}),
		};

		public static List<Dish> restaurant_bar_category_1_dishes { get; set; } = new List<Dish>() {
			new Dish("Ресторан Bar : Категория 1 : Блюдо 1", 100, new HashSet<string>() {"Яблоко", "и другие ингридиенты"}),
			new Dish("Ресторан Bar : Категория 1 : Блюдо 2", 200, new HashSet<string>() {"Яблоко", "и другие ингридиенты"}),
		};
		public static List<Dish> restaurant_bar_category_2_dishes { get; set; } = new List<Dish>() {
			new Dish("Ресторан Bar : Категория 2 : Блюдо 1", 100, new HashSet<string>() {"Яблоко", "и другие ингридиенты"}),
			new Dish("Ресторан Bar : Категория 2 : Блюдо 2", 200, new HashSet<string>() {"Яблоко", "и другие ингридиенты"}),
		};


		public static List<Category> restaurant_foo_categories { get; set; } = new List<Category>() {
			new Category("Ресторан Foo : Категория 1", restaurant_foo_category_1_dishes),
			new Category("Ресторан Foo : Категория 2", restaurant_foo_category_2_dishes),
		};

		public static List<Category> restaurant_bar_categories { get; set; } = new List<Category>() {
			new Category("Ресторан Bar : Категория 1", restaurant_bar_category_1_dishes),
			new Category("Ресторан Bar : Категория 2", restaurant_bar_category_2_dishes),
		};


		public List<Restaurant> restaurants { get; set; } = new List<Restaurant>() {
			new Restaurant("Ресторан Foo", restaurant_foo_categories),
			new Restaurant("Ресторан Bar", restaurant_bar_categories),
		};


		public void SetRestaurantCategories(object sender, EventArgs args)
		{
			Picker picker = (Picker)sender;

			Restaurant selected_restaurant = (Restaurant)picker.SelectedItem;
			category.ItemsSource = selected_restaurant.Categories;
			category.SelectedIndex = -1;
			dish.ItemsSource = null;
		}

		public void SetCategoriesDishes(object sender, EventArgs args)
		{
			Picker picker = (Picker)sender;

			Category selected_category = (Category)picker.SelectedItem;
			if (selected_category == null)
				return;

			dish.ItemsSource = selected_category.Dishes;
			dish.SelectedIndex = -1;
		}

		public void SetDishDescription(object sender, EventArgs args)
		{
			Picker picker = (Picker)sender;

			Dish selected_dish = (Dish)picker.SelectedItem;
			if (selected_dish == null)
				return;

			string dish_name = selected_dish.Name;
			int dish_price = selected_dish.Price;
			string dish_ingredients = String.Join(", ", selected_dish.Ingredients);
			dish_description.Text = $"{dish_name}   -   {dish_price}₽\n{dish_ingredients}";
		}

		public MainPage()
		{
			InitializeComponent();
			BindingContext = this;
		}
	}
}
