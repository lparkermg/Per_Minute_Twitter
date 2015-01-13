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
            this.shortDuration = new System.Windows.Forms.RadioButton();
            this.longDuration = new System.Windows.Forms.RadioButton();
            this.gB1.SuspendLayout();
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
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 210);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.RadioButton longDuration;
        private System.Windows.Forms.RadioButton shortDuration;
    }
}