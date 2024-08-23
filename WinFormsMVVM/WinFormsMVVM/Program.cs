namespace WinFormsMVVM
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            var model = new CounterModel();
            var viewModel = new ClickViewModel(model);
            var mainForm = new Form();
            var view = new MainView(mainForm, viewModel);
            Application.Run(view.MainForm);
        }
    }
}