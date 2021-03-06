
namespace Observer
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbTerminal = new System.Windows.Forms.TextBox();
            this.stripMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnClean = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbChanged = new System.Windows.Forms.CheckBox();
            this.cbRenamed = new System.Windows.Forms.CheckBox();
            this.cbCreated = new System.Windows.Forms.CheckBox();
            this.cbError = new System.Windows.Forms.CheckBox();
            this.cbDeleted = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkPath = new System.Windows.Forms.LinkLabel();
            this.lblPath = new System.Windows.Forms.Label();
            this.stripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tbTerminal
            // 
            this.tbTerminal.AcceptsReturn = true;
            this.tbTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTerminal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTerminal.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTerminal.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbTerminal.HideSelection = false;
            this.tbTerminal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTerminal.Location = new System.Drawing.Point(0, 24);
            this.tbTerminal.Multiline = true;
            this.tbTerminal.Name = "tbTerminal";
            this.tbTerminal.ReadOnly = true;
            this.tbTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTerminal.Size = new System.Drawing.Size(784, 432);
            this.tbTerminal.TabIndex = 0;
            this.tbTerminal.TabStop = false;
            this.tbTerminal.Text = "\r\n";
            // 
            // stripMenu
            // 
            this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.stripMenu.Location = new System.Drawing.Point(0, 0);
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Size = new System.Drawing.Size(784, 24);
            this.stripMenu.TabIndex = 1;
            this.stripMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openToolStripMenuItem.Text = "&Path";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemOnClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemOnClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnClean
            // 
            this.btnClean.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClean.Location = new System.Drawing.Point(0, 569);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(784, 23);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Enabled = false;
            this.tbFilter.Location = new System.Drawing.Point(48, 464);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(100, 23);
            this.tbFilter.TabIndex = 3;
            this.tbFilter.Text = "*.xlsx";
            // 
            // cbChanged
            // 
            this.cbChanged.AutoSize = true;
            this.cbChanged.Location = new System.Drawing.Point(48, 496);
            this.cbChanged.Name = "cbChanged";
            this.cbChanged.Size = new System.Drawing.Size(74, 19);
            this.cbChanged.TabIndex = 4;
            this.cbChanged.Text = "Changed";
            this.cbChanged.UseVisualStyleBackColor = true;
            // 
            // cbRenamed
            // 
            this.cbRenamed.AutoSize = true;
            this.cbRenamed.Location = new System.Drawing.Point(200, 496);
            this.cbRenamed.Name = "cbRenamed";
            this.cbRenamed.Size = new System.Drawing.Size(76, 19);
            this.cbRenamed.TabIndex = 5;
            this.cbRenamed.Text = "Renamed";
            this.cbRenamed.UseVisualStyleBackColor = true;
            // 
            // cbCreated
            // 
            this.cbCreated.AutoSize = true;
            this.cbCreated.Location = new System.Drawing.Point(48, 520);
            this.cbCreated.Name = "cbCreated";
            this.cbCreated.Size = new System.Drawing.Size(67, 19);
            this.cbCreated.TabIndex = 6;
            this.cbCreated.Text = "Created";
            this.cbCreated.UseVisualStyleBackColor = true;
            // 
            // cbError
            // 
            this.cbError.AutoSize = true;
            this.cbError.Location = new System.Drawing.Point(200, 520);
            this.cbError.Name = "cbError";
            this.cbError.Size = new System.Drawing.Size(51, 19);
            this.cbError.TabIndex = 7;
            this.cbError.Text = "Error";
            this.cbError.UseVisualStyleBackColor = true;
            // 
            // cbDeleted
            // 
            this.cbDeleted.AutoSize = true;
            this.cbDeleted.Location = new System.Drawing.Point(48, 544);
            this.cbDeleted.Name = "cbDeleted";
            this.cbDeleted.Size = new System.Drawing.Size(66, 19);
            this.cbDeleted.TabIndex = 8;
            this.cbDeleted.Text = "Deleted";
            this.cbDeleted.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(200, 544);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(83, 19);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter";
            // 
            // lblLinkPath
            // 
            this.lblLinkPath.AutoSize = true;
            this.lblLinkPath.Location = new System.Drawing.Point(200, 464);
            this.lblLinkPath.Name = "lblLinkPath";
            this.lblLinkPath.Size = new System.Drawing.Size(28, 15);
            this.lblLinkPath.TabIndex = 11;
            this.lblLinkPath.TabStop = true;
            this.lblLinkPath.Text = "C:\\\\";
            this.lblLinkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkPath_LinkClicked);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(160, 464);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(31, 15);
            this.lblPath.TabIndex = 12;
            this.lblPath.Text = "Path";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblLinkPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.cbDeleted);
            this.Controls.Add(this.cbError);
            this.Controls.Add(this.cbCreated);
            this.Controls.Add(this.cbRenamed);
            this.Controls.Add(this.cbChanged);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.tbTerminal);
            this.Controls.Add(this.stripMenu);
            this.MainMenuStrip = this.stripMenu;
            this.Name = "Form";
            this.Text = "Folder Observer";
            this.stripMenu.ResumeLayout(false);
            this.stripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox tbTerminal;
        private System.Windows.Forms.MenuStrip stripMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.CheckBox cbChanged;
        private System.Windows.Forms.CheckBox cbRenamed;
        private System.Windows.Forms.CheckBox cbCreated;
        private System.Windows.Forms.CheckBox cbError;
        private System.Windows.Forms.CheckBox cbDeleted;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.LinkLabel lblLinkPath;
    }
}

