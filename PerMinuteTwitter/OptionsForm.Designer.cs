namespace PerMinuteTwitter
{
    partial class OptionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.longDuration = new System.Windows.Forms.RadioButton();
            this.shortDuration = new System.Windows.Forms.RadioButton();
            this.applyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.freqGB = new System.Windows.Forms.GroupBox();
            this.frequencyUpDown = new System.Windows.Forms.NumericUpDown();
            this.gB1.SuspendLayout();
            this.freqGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Term:";
            // 
            // searchTerm
            // 
            this.searchTerm.Location = new System.Drawing.Point(90, 9);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(261, 20);
            this.searchTerm.TabIndex = 1;
            this.searchTerm.Text = "#gamedev";
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.longDuration);
            this.gB1.Controls.Add(this.shortDuration);
            this.gB1.Location = new System.Drawing.Point(13, 35);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(338, 49);
            this.gB1.TabIndex = 2;
            this.gB1.TabStop = false;
            this.gB1.Text = "Show Duration?";
            // 
            // longDuration
            // 
            this.longDuration.AutoSize = true;
            this.longDuration.Location = new System.Drawing.Point(77, 20);
            this.longDuration.Name = "longDuration";
            this.longDuration.Size = new System.Drawing.Size(49, 17);
            this.longDuration.TabIndex = 1;
            this.longDuration.TabStop = true;
            this.longDuration.Text = "Long";
            this.longDuration.UseVisualStyleBackColor = true;
            // 
            // shortDuration
            // 
            this.shortDuration.AutoSize = true;
            this.shortDuration.Location = new System.Drawing.Point(7, 20);
            this.shortDuration.Name = "shortDuration";
            this.shortDuration.Size = new System.Drawing.Size(50, 17);
            this.shortDuration.TabIndex = 0;
            this.shortDuration.TabStop = true;
            this.shortDuration.Text = "Short";
            this.shortDuration.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(256, 141);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(95, 26);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(155, 141);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 26);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 26);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // freqGB
            // 
            this.freqGB.Controls.Add(this.frequencyUpDown);
            this.freqGB.Location = new System.Drawing.Point(15, 91);
            this.freqGB.Name = "freqGB";
            this.freqGB.Size = new System.Drawing.Size(336, 44);
            this.freqGB.TabIndex = 6;
            this.freqGB.TabStop = false;
            this.freqGB.Text = "Frequency? (Minutes)";
            // 
            // frequencyUpDown
            // 
            this.frequencyUpDown.Location = new System.Drawing.Point(7, 18);
            this.frequencyUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.frequencyUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.frequencyUpDown.Name = "frequencyUpDown";
            this.frequencyUpDown.Size = new System.Drawing.Size(323, 20);
            this.frequencyUpDown.TabIndex = 0;
            this.frequencyUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 179);
            this.Controls.Add(this.freqGB);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.gB1);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.freqGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frequencyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.RadioButton longDuration;
        private System.Windows.Forms.RadioButton shortDuration;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox freqGB;
        private System.Windows.Forms.NumericUpDown frequencyUpDown;
    }
}