using System.Diagnostics;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Docker Push";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var image_names = image_txt.Text.Split(" ").Select(x => x.Trim()).Where(x => string.IsNullOrEmpty(x) is false);

            foreach (var image_name in image_names)
            {
                var hub_name = hub_txt.Text;
                var location = $"{hub_name}/{image_name}";

                list_box.Items.Add(image_name);

                _ = ExecuteCommands(image_name, location);
            }
        }

        private async Task ExecuteCommands(string image_name, string location)
        {
            await ExecuteCommand("docker", $"tag {image_name} {location}");
            await ExecuteCommand("docker", $"push {location}");
        }

        Task ExecuteCommand(string command, string arguments)
        {
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.OutputDataReceived += (sender, e) =>
            {
                if (string.IsNullOrEmpty(e.Data) is false)
                {
                    Invoke(new Action(() => list_box.Items.Add(e.Data)));
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (string.IsNullOrEmpty(e.Data) is false)
                {
                    Invoke(new Action(() => list_box.Items.Add(e.Data)));
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            return Task.Run(process.WaitForExit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list_box.Items.Clear();
        }
    }
}
