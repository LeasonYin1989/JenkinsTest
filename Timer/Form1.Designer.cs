
namespace Timer
{
    partial class Form1
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.begin = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(8, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(229, 173);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(8, 8);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(135, 288);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(90, 43);
            this.begin.TabIndex = 1;
            this.begin.Text = "开始";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(307, 288);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(90, 43);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "暂停";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(482, 288);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(90, 43);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "复位";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(201, 129);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(346, 41);
            this.timeLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 448);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox timeLabel;
    }
}

