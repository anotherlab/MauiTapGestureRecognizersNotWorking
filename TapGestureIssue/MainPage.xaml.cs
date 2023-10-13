using System.Windows.Input;

namespace TapGestureIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public ICommand EmployeeTappedCommand { get; } = new Command(() =>
        {
            Console.WriteLine("CLICKED EmployeeTappedCommand");
        });
    }
}
