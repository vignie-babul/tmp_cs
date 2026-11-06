using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

using main.Models;


namespace main.ViewModels
{
	internal class UserViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private User _user { get; set; }

		public int Id {
			get { return _selected_user.Id; }
			set { _selected_user.Id = value; }
		}

		public string Name {
			get { return _selected_user.Name; }
			set { _selected_user.Name = value; }
		}

		public int Age {
			get { return _selected_user.Age; }
			set { _selected_user.Age = value; }
		}

		private User _selected_user {
			get { return _user; }
			set {
				_user = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
			}
		}

		public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();


		public ICommand Prev { get; }
		public ICommand Next { get; }

		public UserViewModel()
		{
			_selected_user = new User() { Id = 1, Name = "A", Age = 18 };
			Users.Add(_selected_user);
			Users.Add(new User() { Id = 2, Name = "B", Age = 19 });
			Users.Add(new User() { Id = 3, Name = "C", Age = 20 });
			
			Prev = new Command(() => {
				if (_selected_user != null) {
					User user = Users.Where(x => x.Id < _selected_user.Id).MaxBy(x => x.Id);
					if (user != null)
						_selected_user = user;
				}
			});
			Next = new Command(() => {
				if (_selected_user != null) {
					User user = Users.FirstOrDefault(x => x.Id > _selected_user.Id);
					if (user != null)
						_selected_user = user;
				}
			});
		}
	}
}
