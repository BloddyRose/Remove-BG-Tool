using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RemoveBgTool
{
    public partial class Form1 : Form
    {
        private static string selectedfile = string.Empty;
        private static string selectedfolder = string.Empty;
        private static string api = string.Empty; // TODO Remove at release DONE
        private static string res = string.Empty;
        private static string message = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedfile = ofd.FileName;
                    txtSelectedFile.Text = ofd.SafeFileName;

                    string file = Path.GetFileNameWithoutExtension(selectedfile);

                    res = file + "-no-bg.png";
                    txtSelectedFile.Text = file;

                    localPhoto.Image = Image.FromFile(selectedfile);
                    
                }
                else
                {
                    MessageBox.Show("Please select a file!", "Remove-BG-Tool");
                }
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    selectedfolder = fbd.SelectedPath;
                    txtSelectedFolder.Text = fbd.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Please select a file!", "Remove-BG-Tool");
                }
            }
        }

        private async Task UploadToApi()
        {
            message = $"The file {selectedfile} will be saved in {selectedfolder}";
            label3.Text = message;

            string dest = Path.Combine(selectedfolder, res);

            if (string.IsNullOrEmpty(api))
                MessageBox.Show("The api key must not be empty please set it in the settings form", "Remove-BG-Tool");

            else
            {
                using (var client = new HttpClient())
                using (var formData = new MultipartFormDataContent())
                {
                    formData.Headers.Add("X-Api-Key", api);
                    formData.Add(new ByteArrayContent(File.ReadAllBytes(selectedfile)), "image_file", "file.jpg");
                    formData.Add(new StringContent("auto"), "size");
                    var response = client.PostAsync("https://api.remove.bg/v1.0/removebg", formData).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        FileStream fileStream = new FileStream(dest, FileMode.Create, FileAccess.Write, FileShare.None);
                        await response.Content.CopyToAsync(fileStream).ContinueWith((copyTask) => { fileStream.Close(); });

                        streamPhoto.Image = Image.FromFile(dest);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.Content.ReadAsStringAsync().Result, "Remove-BG-Tool");
                    }
                }
            }

        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelectedFile.Text))
            {
                MessageBox.Show("Please select a file ","Remove-BG-Tool");
                btnFile.Focus();
            }
            else if (string.IsNullOrEmpty(txtSelectedFolder.Text))
            {
                MessageBox.Show("Please select a folder ", "Remove-BG-Tool");
                btnFolder.Focus();
            }
            else
            {
                await UploadToApi();
            }
        }

        private void txtSelectedFile_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void streamPhoto_Click(object sender, EventArgs e)
        {
            string dest = Path.Combine(selectedfolder, res);
            if (!string.IsNullOrEmpty(dest))
            {
                Process.Start(dest);
            }
            else
            {
                MessageBox.Show("No photo converted so click no working");
            }
        }

        private void localPhoto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedfile))
            {
                Process.Start(selectedfile);
            }
            else
            {
                MessageBox.Show("No photo selected so click no working");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Api.Length > 0)
            {
                api = Properties.Settings.Default.Api;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (Settings settings = new Settings())
            {
                settings.ShowDialog();
            }
        }
    }
}
