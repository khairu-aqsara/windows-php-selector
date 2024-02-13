using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PHP_Selector
{

    public partial class MainForm : Form
    {
        public string DEFAULT_VALUE = "Please select PHP Version";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSelect.Enabled = false;
            cmbPhpVersion.Enabled = false;
            txtDirectory.Enabled = false;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = folderBrowser.SelectedPath;
                cmbPhpVersion.Items.Clear();
                scanDirectory();
            }
        }

        private void scanDirectory()
        {
            string folderPath = txtDirectory.Text;

            if (Directory.Exists(folderPath))
            {
                string[] phpDirectories = Directory.GetDirectories(folderPath);
                
                cmbPhpVersion.Items.Insert(0, DEFAULT_VALUE);
                cmbPhpVersion.SelectedIndex = 0;

                foreach (string phpDir in phpDirectories)
                {

                    Match match = Regex.Match(Path.GetFileName(phpDir), @"php(\d+\.\d+\.\d+)");
                    if (PhpExists(phpDir))
                    {
                        if (match.Success)
                        {
                            string version = match.Groups[1].Value;
                            cmbPhpVersion.Items.Add(version);
                        }
                    }
                }

                if (cmbPhpVersion.Items.Count > 0)
                {
                
                    EnableDisableSelector(true);
                }
                else
                {
                    EnableDisableSelector(false);
                    MessageBox.Show($"There is no PHP Directories", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool PhpExists(string phpDirectory)
        {
            string phpExecutablePath = Path.Combine(phpDirectory, "php.exe");
            return File.Exists(phpExecutablePath);
        }

        private void CreateEnvironmentVariable(string version)
        {
            try
            {
                EnableDisableSelector(false);

                string xamppDirectory = txtDirectory.Text;
                string phpDirectory = Path.Combine(xamppDirectory, $"php{version}");

                if (!Directory.Exists(phpDirectory))
                {
                    MessageBox.Show($"PHP version {version} not found!");
                    return;
                }

                // Get current user PATH environment variable
                string userPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);

                // Remove previous PHP directory from the PATH if it exists
                string[] pathDirectories = userPath.Split(';');
                string newPath = string.Join(";", pathDirectories.Where(dir => !dir.StartsWith(xamppDirectory)));

                // Append PHP directory to the PATH
                newPath = $"{phpDirectory};{userPath}";
                Environment.SetEnvironmentVariable("PATH", newPath, EnvironmentVariableTarget.User);

                // Add environment variable alias "php" pointing to the PHP directory
                Environment.SetEnvironmentVariable("php", phpDirectory, EnvironmentVariableTarget.User);

                MessageBox.Show($"Successfully added PHP version {version} to the User PATH You can now use php -v, please close all CMD or Terminal to refresh the PATH", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnableDisableSelector(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding PHP version to the system PATH: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableDisableSelector(true);
            }
        }

        private void EnableDisableSelector(bool value)
        {
            btnSelect.Enabled = value;
            cmbPhpVersion.Enabled = value;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string selectedVersion = cmbPhpVersion.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedVersion) || selectedVersion != DEFAULT_VALUE)
            {
                CreateEnvironmentVariable(selectedVersion);
            }
            else
            {
                MessageBox.Show("Please Select the PHP Version from the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/khairu-aqsara/php-selector";

            // Open the URL in the default web browser
            var ps = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
    }
}
