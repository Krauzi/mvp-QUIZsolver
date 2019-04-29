namespace QUIZsolver
{
    partial class AnswerObject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAnswer = new System.Windows.Forms.Label();
            this.checkBoxAnswer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelAnswer
            // 
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnswer.Location = new System.Drawing.Point(25, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(422, 22);
            this.labelAnswer.TabIndex = 0;
            // 
            // checkBoxAnswer
            // 
            this.checkBoxAnswer.AutoSize = true;
            this.checkBoxAnswer.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAnswer.Name = "checkBoxAnswer";
            this.checkBoxAnswer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswer.TabIndex = 1;
            this.checkBoxAnswer.UseVisualStyleBackColor = true;
            // 
            // AnswerObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxAnswer);
            this.Controls.Add(this.labelAnswer);
            this.Name = "AnswerObject";
            this.Size = new System.Drawing.Size(450, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.CheckBox checkBoxAnswer;
    }
}
