namespace CatchMeGame
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
            button_CatchMe = new Button();
            SuspendLayout();
            // 
            // button_CatchMe
            // 
            button_CatchMe.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_CatchMe.Location = new Point(499, 219);
            button_CatchMe.Name = "button_CatchMe";
            button_CatchMe.Size = new Size(113, 37);
            button_CatchMe.TabIndex = 0;
            button_CatchMe.Text = "Catch me";
            button_CatchMe.UseVisualStyleBackColor = true;
            button_CatchMe.Click += button_CatchMe_Click;
            button_CatchMe.MouseEnter += button_CatchMe_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 551);
            Controls.Add(button_CatchMe);
            Name = "Form1";
            Text = "\"Catch me If you can\" Game App";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_CatchMe;
    }
}