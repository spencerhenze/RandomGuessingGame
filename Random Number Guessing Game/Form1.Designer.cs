namespace Random_Number_Guessing_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guessCountLabel = new System.Windows.Forms.Label();
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.guessDisplayLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Number Guessing Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a number between 1 and 100 below to guess the random number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guess:";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(172, 115);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 20);
            this.guessTextBox.TabIndex = 3;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(162, 398);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 4;
            this.guessButton.Text = "Guess!";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(85, 310);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(242, 75);
            this.resultLabel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Guess Counter:";
            // 
            // guessCountLabel
            // 
            this.guessCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guessCountLabel.Location = new System.Drawing.Point(88, 198);
            this.guessCountLabel.Name = "guessCountLabel";
            this.guessCountLabel.Size = new System.Drawing.Size(55, 24);
            this.guessCountLabel.TabIndex = 8;
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(264, 166);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(91, 23);
            this.showAnswerButton.TabIndex = 9;
            this.showAnswerButton.Text = "Show Answer";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(288, 397);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.Form1_Load);
            // 
            // guessDisplayLabel
            // 
            this.guessDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guessDisplayLabel.Location = new System.Drawing.Point(88, 165);
            this.guessDisplayLabel.Name = "guessDisplayLabel";
            this.guessDisplayLabel.Size = new System.Drawing.Size(55, 24);
            this.guessDisplayLabel.TabIndex = 12;
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(6, 166);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(77, 13);
            this.guessLabel.TabIndex = 11;
            this.guessLabel.Text = "Current Guess:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.guessDisplayLabel);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.guessCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label guessCountLabel;
        private System.Windows.Forms.Button showAnswerButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label guessDisplayLabel;
        private System.Windows.Forms.Label guessLabel;
    }
}

