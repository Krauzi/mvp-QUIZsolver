﻿namespace QUIZsolver
{
    partial class Form2
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelNegativePointsInfo = new System.Windows.Forms.Label();
            this.checkBoxNegative = new System.Windows.Forms.CheckBox();
            this.labelTimeInfo = new System.Windows.Forms.Label();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(15, 18);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(350, 38);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load file";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFileName.Location = new System.Drawing.Point(18, 60);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 16);
            this.labelFileName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(15, 156);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(350, 58);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start test";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelNegativePointsInfo
            // 
            this.labelNegativePointsInfo.AutoSize = true;
            this.labelNegativePointsInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNegativePointsInfo.Location = new System.Drawing.Point(202, 126);
            this.labelNegativePointsInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNegativePointsInfo.Name = "labelNegativePointsInfo";
            this.labelNegativePointsInfo.Size = new System.Drawing.Size(153, 19);
            this.labelNegativePointsInfo.TabIndex = 3;
            this.labelNegativePointsInfo.Text = "Negative points?";
            // 
            // checkBoxNegative
            // 
            this.checkBoxNegative.AutoSize = true;
            this.checkBoxNegative.Location = new System.Drawing.Point(342, 126);
            this.checkBoxNegative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxNegative.Name = "checkBoxNegative";
            this.checkBoxNegative.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNegative.TabIndex = 4;
            this.checkBoxNegative.UseVisualStyleBackColor = true;
            // 
            // labelTimeInfo
            // 
            this.labelTimeInfo.AutoSize = true;
            this.labelTimeInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTimeInfo.Location = new System.Drawing.Point(10, 126);
            this.labelTimeInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeInfo.Name = "labelTimeInfo";
            this.labelTimeInfo.Size = new System.Drawing.Size(54, 19);
            this.labelTimeInfo.TabIndex = 5;
            this.labelTimeInfo.Text = "Time:";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownTime.Location = new System.Drawing.Point(72, 124);
            this.numericUpDownTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(108, 26);
            this.numericUpDownTime.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(379, 232);
            this.Controls.Add(this.numericUpDownTime);
            this.Controls.Add(this.labelTimeInfo);
            this.Controls.Add(this.checkBoxNegative);
            this.Controls.Add(this.labelNegativePointsInfo);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonLoad);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Load file";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelNegativePointsInfo;
        private System.Windows.Forms.CheckBox checkBoxNegative;
        private System.Windows.Forms.Label labelTimeInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
    }
}