namespace WinFormsMVVM
{
    public sealed class MainView
    {
        public Form MainForm;

        private readonly ClickViewModel _ViewModel;

        public MainView(Form mainForm, ClickViewModel viewModel)
        {
            MainForm = mainForm;
            _ViewModel = viewModel;

            var button = new Button { Text = "Dodaj kliknięcie!" };
            button.Click += ButtonClicked;
            MainForm.Controls.Add(button);

            var label = new Label
            {
                Text = "Aktualna ilość kliknięć: ",
                Top = 50,
                Width = 300
            };
            label.DataBindings.Add(_ViewModel.GetLabelBinding());
            MainForm.Controls.Add(label);
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            _ViewModel.UpdateCounterCommand.Execute(null);
        }
    }
}