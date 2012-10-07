using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using TechEdDemo.Models;

namespace TechEdDemo.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Icecream> Icecreams { get; set; }

        public ICommand IncrementCommand { get; set; }
        public ICommand DoubleCommand { get; set; }

        private string _greeting;
        public string Greeting
        {
            get { return _greeting; }
            set
            {
                _greeting = value;
                OnPropertyChanged("Greeting");
            }
        }

        private int _total;
        public int Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        public MainViewModel()
        {
            // Properties
            Greeting = "Hello World! v2";
            CreateData();

            // Commands
            IncrementCommand = new DelegateCommand(obj => Increment());
            DoubleCommand = new DelegateCommand(obj => Double());
        }

        private void CreateData()
        {
            Icecreams = new ObservableCollection<Icecream>();
            Uri _baseUri = new Uri("ms-appx:///");

            Icecream icecream;

            icecream = new Icecream();
            icecream.Name = "Banana Blast Frozen Yogurt";
            icecream.SetImage(_baseUri, "Assets/Images/60Banana.png");
            icecream.Category = "Low-fat frozen yogurt";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Lavish Lemon Ice";
            icecream.SetImage(_baseUri, "Assets/Images/60Lemon.png");
            icecream.Category = "Sorbet";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Marvelous Mint";
            icecream.SetImage(_baseUri, "Assets/Images/60Mint.png");
            icecream.Category = "Gelato";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Creamy Orange";
            icecream.SetImage(_baseUri, "Assets/Images/60Orange.png");
            icecream.Category = "Sorbet";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Succulent Strawberry";
            icecream.SetImage(_baseUri, "Assets/Images/60Strawberry.png");
            icecream.Category = "Sorbet";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Very Vanilla";
            icecream.SetImage(_baseUri, "Assets/Images/60Vanilla.png");
            icecream.Category = "Ice Cream";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Creamy Caramel Frozen Yogurt";
            icecream.SetImage(_baseUri, "Assets/Images/60SauceCaramel.png");
            icecream.Category = "Low-fat frozen yogurt";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Chocolate Lovers Frozen Yougurt";
            icecream.SetImage(_baseUri, "Assets/Images/60SauceChocolate.png");
            icecream.Category = "Low-fat frozen yogurt";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Roma Strawberry";
            icecream.SetImage(_baseUri, "Assets/Images/60Strawberry.png");
            icecream.Category = "Gelato";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Italian Rainbow";
            icecream.SetImage(_baseUri, "Assets/Images/60SprinklesRainbow.png");
            icecream.Category = "Gelato";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Straweberry";
            icecream.SetImage(_baseUri, "Assets/Images/60Strawberry.png");
            icecream.Category = "Ice Cream";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Strawberry Frozen Yogurt";
            icecream.SetImage(_baseUri, "Assets/Images/60Strawberry.png");
            icecream.Category = "Low-fat frozen yogurt";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Bongo Banana";
            icecream.SetImage(_baseUri, "Assets/Images/60Banana.png");
            icecream.Category = "Sorbet";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Firenze Vanilla";
            icecream.SetImage(_baseUri, "Assets/Images/60Vanilla.png");
            icecream.Category = "Gelato";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Choco-wocko";
            icecream.SetImage(_baseUri, "Assets/Images/60SauceChocolate.png");
            icecream.Category = "Sorbet";
            Icecreams.Add(icecream);

            icecream = new Icecream();
            icecream.Name = "Chocolate";
            icecream.SetImage(_baseUri, "Assets/Images/60SauceChocolate.png");
            icecream.Category = "Ice Cream";
            Icecreams.Add(icecream);
        }

        public void Increment()
        {
            Total += 1;
        }

        public void Double()
        {
            Total *= 2;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DelegateCommand : ICommand
    {
        public Action<object> ExecuteAction { get; set; }

        public DelegateCommand(Action<object> executeAction)
        {
            ExecuteAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteAction(parameter);
        }
    }

}
