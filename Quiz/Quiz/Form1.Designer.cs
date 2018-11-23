namespace Quiz
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
            this.QuestionTextField = new System.Windows.Forms.TextBox();
            this.AnswerTextField = new System.Windows.Forms.TextBox();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.ResultTextField = new System.Windows.Forms.TextBox();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionTextField
            // 
            this.QuestionTextField.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuestionTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextField.Location = new System.Drawing.Point(137, 84);
            this.QuestionTextField.Name = "QuestionTextField";
            this.QuestionTextField.Size = new System.Drawing.Size(527, 31);
            this.QuestionTextField.TabIndex = 0;
            // 
            // AnswerTextField
            // 
            this.AnswerTextField.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AnswerTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextField.Location = new System.Drawing.Point(222, 197);
            this.AnswerTextField.Name = "AnswerTextField";
            this.AnswerTextField.Size = new System.Drawing.Size(223, 38);
            this.AnswerTextField.TabIndex = 1;
            // 
            // AnswerButton
            // 
            this.AnswerButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AnswerButton.FlatAppearance.BorderSize = 0;
            this.AnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerButton.Location = new System.Drawing.Point(451, 197);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(128, 38);
            this.AnswerButton.TabIndex = 2;
            this.AnswerButton.Text = "Answer";
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // ResultTextField
            // 
            this.ResultTextField.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextField.Location = new System.Drawing.Point(222, 298);
            this.ResultTextField.Name = "ResultTextField";
            this.ResultTextField.Size = new System.Drawing.Size(357, 31);
            this.ResultTextField.TabIndex = 3;
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.NextQuestionButton.FlatAppearance.BorderSize = 0;
            this.NextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextQuestionButton.Location = new System.Drawing.Point(336, 385);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(128, 38);
            this.NextQuestionButton.TabIndex = 4;
            this.NextQuestionButton.Text = "Next Question";
            this.NextQuestionButton.UseVisualStyleBackColor = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.ResultTextField);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.AnswerTextField);
            this.Controls.Add(this.QuestionTextField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionTextField;
        private System.Windows.Forms.TextBox AnswerTextField;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.TextBox ResultTextField;
        private System.Windows.Forms.Button NextQuestionButton;
    }
}

