namespace NumberGuesser
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
            this.highGuess = new System.Windows.Forms.Button();
            this.answerOutput = new System.Windows.Forms.RichTextBox();
            this.tooLow = new System.Windows.Forms.Button();
            this.correctGuess = new System.Windows.Forms.Button();
            this.startPress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highGuess
            // 
            this.highGuess.Location = new System.Drawing.Point(42, 112);
            this.highGuess.Name = "highGuess";
            this.highGuess.Size = new System.Drawing.Size(355, 64);
            this.highGuess.TabIndex = 0;
            this.highGuess.Text = "Too High!";
            this.highGuess.UseVisualStyleBackColor = true;
            this.highGuess.Click += new System.EventHandler(this.highGuess_Click);
            // 
            // answerOutput
            // 
            this.answerOutput.Enabled = false;
            this.answerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerOutput.Location = new System.Drawing.Point(42, 10);
            this.answerOutput.Name = "answerOutput";
            this.answerOutput.Size = new System.Drawing.Size(355, 96);
            this.answerOutput.TabIndex = 1;
            this.answerOutput.Text = "";
            this.answerOutput.TextChanged += new System.EventHandler(this.answerOutput_TextChanged);
            // 
            // tooLow
            // 
            this.tooLow.Location = new System.Drawing.Point(42, 182);
            this.tooLow.Name = "tooLow";
            this.tooLow.Size = new System.Drawing.Size(355, 64);
            this.tooLow.TabIndex = 2;
            this.tooLow.Text = "Too Low!";
            this.tooLow.UseVisualStyleBackColor = true;
            this.tooLow.Click += new System.EventHandler(this.tooLow_Click);
            // 
            // correctGuess
            // 
            this.correctGuess.Location = new System.Drawing.Point(42, 252);
            this.correctGuess.Name = "correctGuess";
            this.correctGuess.Size = new System.Drawing.Size(355, 64);
            this.correctGuess.TabIndex = 3;
            this.correctGuess.Text = "Correct!";
            this.correctGuess.UseVisualStyleBackColor = true;
            this.correctGuess.Click += new System.EventHandler(this.correctGuess_Click);
            // 
            // startPress
            // 
            this.startPress.Location = new System.Drawing.Point(42, 374);
            this.startPress.Name = "startPress";
            this.startPress.Size = new System.Drawing.Size(355, 64);
            this.startPress.TabIndex = 4;
            this.startPress.Text = "Start!";
            this.startPress.UseVisualStyleBackColor = true;
            this.startPress.Click += new System.EventHandler(this.startPress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startPress);
            this.Controls.Add(this.correctGuess);
            this.Controls.Add(this.tooLow);
            this.Controls.Add(this.answerOutput);
            this.Controls.Add(this.highGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button highGuess;
        private System.Windows.Forms.RichTextBox answerOutput;
        private System.Windows.Forms.Button tooLow;
        private System.Windows.Forms.Button correctGuess;
        private System.Windows.Forms.Button startPress;
    }
}

