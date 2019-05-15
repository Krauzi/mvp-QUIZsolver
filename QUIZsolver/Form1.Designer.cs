namespace QUIZsolver
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
            this.flowLayoutPanelAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.labelWorth = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAnswers
            // 
            this.flowLayoutPanelAnswers.Location = new System.Drawing.Point(16, 150);
            this.flowLayoutPanelAnswers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelAnswers.Name = "flowLayoutPanelAnswers";
            this.flowLayoutPanelAnswers.Size = new System.Drawing.Size(600, 313);
            this.flowLayoutPanelAnswers.TabIndex = 0;
            // 
            // flowLayoutPanelQuestions
            // 
            this.flowLayoutPanelQuestions.Location = new System.Drawing.Point(16, 2);
            this.flowLayoutPanelQuestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            this.flowLayoutPanelQuestions.Size = new System.Drawing.Size(907, 97);
            this.flowLayoutPanelQuestions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(677, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time left:";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(815, 423);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(108, 39);
            this.buttonFinish.TabIndex = 3;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuestion.Location = new System.Drawing.Point(69, 103);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(541, 42);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuestionNumber.Location = new System.Drawing.Point(16, 103);
            this.labelQuestionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(45, 41);
            this.labelQuestionNumber.TabIndex = 5;
            this.labelQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWorth
            // 
            this.labelWorth.AutoSize = true;
            this.labelWorth.Location = new System.Drawing.Point(679, 135);
            this.labelWorth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorth.Name = "labelWorth";
            this.labelWorth.Size = new System.Drawing.Size(107, 17);
            this.labelWorth.TabIndex = 6;
            this.labelWorth.Text = "Question worth:";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(795, 135);
            this.labelPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(0, 17);
            this.labelPoints.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(783, 302);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(24, 17);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 478);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelWorth);
            this.Controls.Add(this.labelQuestionNumber);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelQuestions);
            this.Controls.Add(this.flowLayoutPanelAnswers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAnswers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelWorth;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
    }
}

