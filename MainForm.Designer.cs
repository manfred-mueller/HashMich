using System.Reflection;
using System;
using System.Windows.Forms;

namespace HashMich
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkMD5 = new System.Windows.Forms.CheckBox();
            this.TxtMD5 = new System.Windows.Forms.TextBox();
            this.TxtSHA1 = new System.Windows.Forms.TextBox();
            this.ChkSHA1 = new System.Windows.Forms.CheckBox();
            this.TxtSHA256 = new System.Windows.Forms.TextBox();
            this.ChkSHA256 = new System.Windows.Forms.CheckBox();
            this.TxtSHA512 = new System.Windows.Forms.TextBox();
            this.ChkSHA512 = new System.Windows.Forms.CheckBox();
            this.TxtCheck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdCompute = new System.Windows.Forms.Button();
            this.CmdBrowsePath = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbContext = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPath
            // 
            this.TxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPath.Location = new System.Drawing.Point(81, 12);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(408, 20);
            this.TxtPath.TabIndex = 0;
            this.TxtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = HashMich.Properties.Resources.MainForm_InitializeComponent_Path;
            // 
            // ChkMD5
            // 
            this.ChkMD5.AutoSize = true;
            this.ChkMD5.Checked = true;
            this.ChkMD5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkMD5.Location = new System.Drawing.Point(15, 57);
            this.ChkMD5.Name = "ChkMD5";
            this.ChkMD5.Size = new System.Drawing.Size(49, 17);
            this.ChkMD5.TabIndex = 3;
            this.ChkMD5.Text = "MD5";
            this.ChkMD5.UseVisualStyleBackColor = true;
            this.ChkMD5.CheckedChanged += new System.EventHandler(this.ChkMD5_CheckedChanged);
            // 
            // TxtMD5
            // 
            this.TxtMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMD5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMD5.Location = new System.Drawing.Point(6, 15);
            this.TxtMD5.Name = "TxtMD5";
            this.TxtMD5.ReadOnly = true;
            this.TxtMD5.Size = new System.Drawing.Size(457, 20);
            this.TxtMD5.TabIndex = 4;
            this.toolTip.SetToolTip(this.TxtMD5, HashMich.Properties.Resources.MainForm_InitializeComponent_DoubleClickSavesValueToClipboard);
            this.TxtMD5.DoubleClick += new System.EventHandler(this.TxtHash_DoubleClick);
            // 
            // TxtSHA1
            // 
            this.TxtSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSHA1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSHA1.Location = new System.Drawing.Point(6, 41);
            this.TxtSHA1.Name = "TxtSHA1";
            this.TxtSHA1.ReadOnly = true;
            this.TxtSHA1.Size = new System.Drawing.Size(457, 20);
            this.TxtSHA1.TabIndex = 6;
            this.toolTip.SetToolTip(this.TxtSHA1, HashMich.Properties.Resources.MainForm_InitializeComponent_DoubleClickSavesValueToClipboard);
            this.TxtSHA1.DoubleClick += new System.EventHandler(this.TxtHash_DoubleClick);
            // 
            // ChkSHA1
            // 
            this.ChkSHA1.AutoSize = true;
            this.ChkSHA1.Checked = true;
            this.ChkSHA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSHA1.Location = new System.Drawing.Point(15, 83);
            this.ChkSHA1.Name = "ChkSHA1";
            this.ChkSHA1.Size = new System.Drawing.Size(54, 17);
            this.ChkSHA1.TabIndex = 5;
            this.ChkSHA1.Text = "SHA1";
            this.ChkSHA1.UseVisualStyleBackColor = true;
            this.ChkSHA1.CheckedChanged += new System.EventHandler(this.ChkSHA1_CheckedChanged);
            // 
            // TxtSHA256
            // 
            this.TxtSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSHA256.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSHA256.Location = new System.Drawing.Point(6, 67);
            this.TxtSHA256.Name = "TxtSHA256";
            this.TxtSHA256.ReadOnly = true;
            this.TxtSHA256.Size = new System.Drawing.Size(457, 20);
            this.TxtSHA256.TabIndex = 8;
            this.toolTip.SetToolTip(this.TxtSHA256, HashMich.Properties.Resources.MainForm_InitializeComponent_DoubleClickSavesValueToClipboard);
            this.TxtSHA256.DoubleClick += new System.EventHandler(this.TxtHash_DoubleClick);
            // 
            // ChkSHA256
            // 
            this.ChkSHA256.AutoSize = true;
            this.ChkSHA256.Checked = true;
            this.ChkSHA256.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSHA256.Location = new System.Drawing.Point(15, 109);
            this.ChkSHA256.Name = "ChkSHA256";
            this.ChkSHA256.Size = new System.Drawing.Size(66, 17);
            this.ChkSHA256.TabIndex = 7;
            this.ChkSHA256.Text = "SHA256";
            this.ChkSHA256.UseVisualStyleBackColor = true;
            this.ChkSHA256.CheckedChanged += new System.EventHandler(this.ChkSHA256_CheckedChanged);
            // 
            // TxtSHA512
            // 
            this.TxtSHA512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSHA512.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSHA512.Location = new System.Drawing.Point(6, 93);
            this.TxtSHA512.Name = "TxtSHA512";
            this.TxtSHA512.ReadOnly = true;
            this.TxtSHA512.Size = new System.Drawing.Size(457, 20);
            this.TxtSHA512.TabIndex = 10;
            this.toolTip.SetToolTip(this.TxtSHA512, HashMich.Properties.Resources.MainForm_InitializeComponent_DoubleClickSavesValueToClipboard);
            this.TxtSHA512.DoubleClick += new System.EventHandler(this.TxtHash_DoubleClick);
            // 
            // ChkSHA512
            // 
            this.ChkSHA512.AutoSize = true;
            this.ChkSHA512.Checked = true;
            this.ChkSHA512.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSHA512.Location = new System.Drawing.Point(15, 135);
            this.ChkSHA512.Name = "ChkSHA512";
            this.ChkSHA512.Size = new System.Drawing.Size(66, 17);
            this.ChkSHA512.TabIndex = 9;
            this.ChkSHA512.Text = "SHA512";
            this.ChkSHA512.UseVisualStyleBackColor = true;
            this.ChkSHA512.CheckedChanged += new System.EventHandler(this.ChkSHA512_CheckedChanged);
            // 
            // TxtCheck
            // 
            this.TxtCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCheck.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCheck.Location = new System.Drawing.Point(15, 190);
            this.TxtCheck.Name = "TxtCheck";
            this.TxtCheck.Size = new System.Drawing.Size(528, 20);
            this.TxtCheck.TabIndex = 11;
            this.TxtCheck.TextChanged += new System.EventHandler(this.TxtCheck_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = HashMich.Properties.Resources.MainForm_InitializeComponent_PasteAnHashHereToCompareWithTheAboveResults;
            // 
            // CmdCompute
            // 
            this.CmdCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCompute.Image = HashMich.Properties.Resources.calculator;
            this.CmdCompute.Location = new System.Drawing.Point(526, 10);
            this.CmdCompute.Name = "CmdCompute";
            this.CmdCompute.Size = new System.Drawing.Size(25, 23);
            this.CmdCompute.TabIndex = 15;
            this.toolTip.SetToolTip(this.CmdCompute, HashMich.Properties.Resources.MainForm_InitializeComponent_CalculateHashes);
            this.CmdCompute.UseVisualStyleBackColor = true;
            this.CmdCompute.Click += new System.EventHandler(this.CmdCompute_Click);
            // 
            // CmdBrowsePath
            // 
            this.CmdBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdBrowsePath.Image = HashMich.Properties.Resources.browse;
            this.CmdBrowsePath.Location = new System.Drawing.Point(495, 10);
            this.CmdBrowsePath.Name = "CmdBrowsePath";
            this.CmdBrowsePath.Size = new System.Drawing.Size(25, 23);
            this.CmdBrowsePath.TabIndex = 2;
            this.toolTip.SetToolTip(this.CmdBrowsePath, HashMich.Properties.Resources.MainForm_InitializeComponent_BrowseFilesystem);
            this.CmdBrowsePath.UseVisualStyleBackColor = true;
            this.CmdBrowsePath.Click += new System.EventHandler(this.CmdBrowsePath_Click);
            // 
            // cbContext
            // 
            this.cbContext.AutoSize = true;
            this.cbContext.Location = new System.Drawing.Point(15, 216);
            this.cbContext.Name = "cbContext";
            this.cbContext.Size = new System.Drawing.Size(117, 17);
            this.cbContext.TabIndex = 16;
            this.cbContext.Text = HashMich.Properties.Resources.MainForm_InitializeComponent_ContextMenu;
            this.toolTip.SetToolTip(this.cbContext, HashMich.Properties.Resources.MainForm_InitializeComponent_RegisterToUserSContextMenu);
            this.cbContext.UseVisualStyleBackColor = true;
            this.cbContext.CheckedChanged += new System.EventHandler(this.cbContext_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtMD5);
            this.panel1.Controls.Add(this.TxtSHA1);
            this.panel1.Controls.Add(this.TxtSHA256);
            this.panel1.Controls.Add(this.TxtSHA512);
            this.panel1.Location = new System.Drawing.Point(81, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 120);
            this.panel1.TabIndex = 17;
            this.toolTip.SetToolTip(this.panel1, HashMich.Properties.Resources.MainForm_InitializeComponent_DoubleClickSavesValueToClipboard);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(514, 217);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = HashMich.Properties.Resources.MainForm_InitializeComponent_Help;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbContext);
            this.Controls.Add(this.CmdCompute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCheck);
            this.Controls.Add(this.ChkSHA512);
            this.Controls.Add(this.ChkSHA256);
            this.Controls.Add(this.ChkSHA1);
            this.Controls.Add(this.ChkMD5);
            this.Controls.Add(this.CmdBrowsePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPath);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdBrowsePath;
        private System.Windows.Forms.CheckBox ChkMD5;
        private System.Windows.Forms.TextBox TxtMD5;
        private System.Windows.Forms.TextBox TxtSHA1;
        private System.Windows.Forms.CheckBox ChkSHA1;
        private System.Windows.Forms.TextBox TxtSHA256;
        private System.Windows.Forms.CheckBox ChkSHA256;
        private System.Windows.Forms.TextBox TxtSHA512;
        private System.Windows.Forms.CheckBox ChkSHA512;
        private System.Windows.Forms.TextBox TxtCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdCompute;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox cbContext;
        private Panel panel1;
        private Label label3;
    }
}
