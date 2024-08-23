namespace NamespaceUpdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            var csharpFiles = Directory.EnumerateFiles(this.directoryTextBox.Text)
                .Where(x => x.EndsWith(".cs")).ToList();

            foreach (var csharpFile in csharpFiles)
            {
                var lines = File.ReadAllText(csharpFile).Split(Environment.NewLine);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("namespace"))
                    {
                        lines[i] = lines[i].Insert(
                            "namespace".Length + 1,
                            prefixTextBox.Text + ".");

                        break;
                    }
                }

                var writer = File.CreateText(csharpFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i < lines.Length - 1)
                    {
                        writer.WriteLine(lines[i]);
                    }
                    else
                    {
                        writer.Write(lines[i]);
                    }
                }
                writer.Flush();
                writer.Close();
            }
        }
    }
}