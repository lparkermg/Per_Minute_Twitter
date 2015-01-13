namespace PerMinuteTwitter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitAppItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(522, 194);
            this.textBox1.TabIndex = 2;
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.ContextMenuStrip = this.mainMenu;
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "PerMinuteTwitter";
            this.appNotifyIcon.Visible = true;
            this.appNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.appNotifyIcon_MouseDoubleClick);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsItem,
            this.toolStripSeparator1,
            this.exitAppItem});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(157, 54);
            // 
            // optionsItem
            // 
            this.optionsItem.Name = "optionsItem";
            this.optionsItem.Size = new System.Drawing.Size(156, 22);
            this.optionsItem.Text = "Options";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // exitAppItem
            // 
            this.exitAppItem.Name = "exitAppItem";
            this.exitAppItem.Size = new System.Drawing.Size(156, 22);
            this.exitAppItem.Text = "Exit Application";
            this.exitAppItem.Click += new System.EventHandler(this.exitAppItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon appNotifyIcon;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ContextMenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitAppItem;
    }
}

