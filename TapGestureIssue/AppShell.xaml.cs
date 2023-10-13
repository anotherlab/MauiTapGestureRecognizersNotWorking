namespace TapGestureIssue
{
    public partial class AppShell : Shell
    {
        public Dictionary<string, Type> Routes { get; private set; } = [];
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        void RegisterRoutes()
        {
            Routes.Add("employee", typeof(EmployeePage));

            foreach (var route in Routes)
            {
                Routing.RegisterRoute(route.Key, route.Value);
            }
        }
    }
}
