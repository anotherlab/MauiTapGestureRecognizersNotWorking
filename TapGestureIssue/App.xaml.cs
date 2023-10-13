namespace TapGestureIssue
{
    public partial class App : Application
    {
        EmployeeDataStore employeeDataStore = null;
        public EmployeeDataStore EmployeeDataStore => employeeDataStore ??= new EmployeeDataStore();

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
