// Copyright (C)2014-2014 AirVPN (support@airvpn.org) / https://airvpn.org )
//
// Hash Calculator is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Hash Calculator is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Hash Calculator. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Linq;
using System.Reflection;

namespace HashMich
{
    public partial class MainForm : Form
    {
        // Registry paths
        public string ProgKey = $@"Software\Classes\*\shell\{Application.ProductName}";
        public string ExtKey = $@"Software\Classes\*\shell\{Application.ProductName}\command";
        public string ExePath = Application.ExecutablePath;
        public MainForm(string[] args)
        {
            InitializeComponent();
            Version shortVersion = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = string.Format(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + $" {shortVersion.Major}.{shortVersion.Minor}.{shortVersion.Build}");
            this.Icon = HashMich.Properties.Resources.HashMich;
            this.ActiveControl = TxtCheck;
            CenterFormOnScreen();
            cbContext.Checked = Properties.Settings.Default.contextMenu;

            if (args.Length > 0)
            {
                string inputFilePath = args[0];
                if (File.Exists(inputFilePath))
                {
                    TxtPath.Text = inputFilePath;
                    Check();
                }
                else
                {
                    MessageBox.Show(String.Format(HashMich.Properties.Resources.MainForm_MainForm_InvalidFilePath0, inputFilePath), HashMich.Properties.Resources.MainForm_MainForm_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (TxtPath.Text.Trim() == "")
            {
                Clear();
            }
        }

        private void CmdCompute_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void CmdBrowsePath_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                TxtPath.Text = FD.FileName;
                Check();
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void TxtCheck_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void ChkMD5_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void ChkSHA1_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void ChkSHA256_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void ChkSHA512_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        public void Clear()
        {
            TxtMD5.Text = "";
            TxtSHA1.Text = "";
            TxtSHA256.Text = "";
            TxtSHA512.Text = "";
        }

        public void ColorTextBox(TextBox c)
        {
            int lc = 246;
            int mc = 160;
            int hc = 255;
            if ((TxtCheck.Text.Trim() == "") || (c.Text == ""))
                c.BackColor = Color.FromArgb(lc, lc, lc);
            else if (TxtCheck.Text.Trim() == c.Text)
                c.BackColor = Color.FromArgb(mc, hc, mc);
            else
                c.BackColor = Color.FromArgb(hc, mc, mc);
        }

        private static string GetHash(string filePath, HashAlgorithm hasher)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                return GetHash(fs, hasher);
        }

        private static string GetHash(Stream s, HashAlgorithm hasher)
        {
            var hash = hasher.ComputeHash(s);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

        public void Compute(CheckBox c, TextBox t, string a)
        {
            if (c.Checked)
            {
                if ((t.Text == "") && (TxtPath.Text != ""))
                {
                    HashAlgorithm algo = null;
                    if (a == "md5")
                        algo = new MD5CryptoServiceProvider();
                    else if (a == "sha1")
                        algo = new SHA1CryptoServiceProvider();
                    else if (a == "sha256")
                        algo = new SHA256CryptoServiceProvider();
                    else if (a == "sha512")
                        algo = new SHA512CryptoServiceProvider();

                    if (algo != null)
                    {
                        try
                        {
                            t.BackColor = Color.LightYellow;
                            t.Text = HashMich.Properties.Resources.MainForm_Compute_Calculating; // Changed to avoid dependency on resource file.
                            t.Text = GetHash(TxtPath.Text, algo);
                        }
                        catch (Exception e)
                        {
                            t.Text = e.Message;
                        }
                        t.Refresh();
                    }
                    else
                        t.Text = HashMich.Properties.Resources.UnknownAlgorithm; // Changed to avoid dependency on resource file.
                }
            }
            else
            {
                t.Text = "";
            }

            ColorTextBox(t);
            t.Refresh();

            Application.DoEvents();
        }

        public void Check()
        {
            Application.DoEvents();

            Compute(ChkMD5, TxtMD5, "md5");
            Compute(ChkSHA1, TxtSHA1, "sha1");
            Compute(ChkSHA256, TxtSHA256, "sha256");
            Compute(ChkSHA512, TxtSHA512, "sha512");
        }
        private void TxtHash_DoubleClick(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                Clipboard.SetText(textBox.Text);
                MessageBox.Show(String.Format(HashMich.Properties.Resources.MainForm_TxtHash_DoubleClick_0HashCopiedToClipboard, textBox.Name.Remove(0, 3)), HashMich.Properties.Resources.MainForm_TxtHash_DoubleClick_Copied, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(HashMich.Properties.Resources.MainForm_TxtHash_DoubleClick_HashValueIsEmpty, HashMich.Properties.Resources.MainForm_MainForm_Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbContext_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if the context menu entry should be added or removed
                if (cbContext.Checked)
                {
                    // Check if the registry entry already exists
                    using (RegistryKey shellKey = Registry.CurrentUser.OpenSubKey(ProgKey, writable: true))
                    {
                        if (shellKey == null || shellKey.GetValue(null) == null) // If the shellKey doesn't exist or is empty
                        {
                            // Add the context menu entry
                            using (RegistryKey newShellKey = Registry.CurrentUser.CreateSubKey(ProgKey))
                            {
                                if (newShellKey != null)
                                {
                                    newShellKey.SetValue(null, HashMich.Properties.Resources.MainForm_cbContext_CheckedChanged_CalculateHashValue); // Text for the context menu
                                    newShellKey.SetValue("Icon", ExePath); // Use the application's icon
                                }
                            }

                            using (RegistryKey newCommandKey = Registry.CurrentUser.CreateSubKey(ExtKey))
                            {
                                if (newCommandKey != null)
                                {
                                    newCommandKey.SetValue(null, $"\"{ExePath}\" \"%1\""); // "%1" is the selected file
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Remove the context menu entry if it exists
                    using (RegistryKey shellKey = Registry.CurrentUser.OpenSubKey($@"Software\Classes\*\shell", writable: true))
                    {
                        if (shellKey != null && shellKey.GetSubKeyNames().Contains(Application.ProductName))
                        {
                            shellKey.DeleteSubKeyTree(Application.ProductName);
                        }
                    }
                }
                Properties.Settings.Default.contextMenu = cbContext.Checked;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format(HashMich.Properties.Resources.MainForm_cbContext_CheckedChanged_Error0, ex.Message), HashMich.Properties.Resources.MainForm_MainForm_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkKey()
        {
            if (ProgKey != null)
            {
                cbContext.Checked = true;
            }
            else
            {
                cbContext.Checked = false;
            }
        }

        private void CenterFormOnScreen()
        {
            // Calculate the center of the screen based on the form's dimensions
            int centerX = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
            int centerY = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;

            // Set the form's location
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(centerX, centerY);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(HashMich.Properties.Resources.MainForm_label3_Click_HashMich00CalculatesHashesForTheGiveFile0AcceptsTheFileAsParameter0CanBeRegisteredInTheUserSContextMenu0DoubleClickCopiesTheValueToTheClipbopard, Environment.NewLine).Replace("\\t", "\t"), System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}