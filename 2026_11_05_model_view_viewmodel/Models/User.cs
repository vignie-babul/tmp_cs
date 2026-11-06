using System.ComponentModel;


namespace main.Models
{
	internal class User : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private int _id;
		private string _name;
		private int _age;

		public int Id {
			get { return _id; }
			set {
				_id = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
			}
		}

		public string Name {
			get { return _name; }
			set {
				_name = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
			}
		}

		public int Age {
			get { return _age; }
			set {
				_age = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
			}
		}
	}
}
