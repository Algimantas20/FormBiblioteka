using FormBiblioteka.Modules;

namespace FormBiblioteka
{
    partial class HeroPage
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
            AddBookButton = new Button();
            TakeReturnFormButton = new Button();
            ListOfBooksButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(50, 225);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(175, 50);
            AddBookButton.TabIndex = 0;
            AddBookButton.Text = "Add a Book";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButtonClick;
            // 
            // TakeReturnFormButton
            // 
            TakeReturnFormButton.Location = new Point(300, 225);
            TakeReturnFormButton.Name = "TakeReturnFormButton";
            TakeReturnFormButton.Size = new Size(175, 50);
            TakeReturnFormButton.TabIndex = 1;
            TakeReturnFormButton.Text = "Take/Return";
            TakeReturnFormButton.UseVisualStyleBackColor = true;
            TakeReturnFormButton.Click += TakeReturnFormButtonClick;
            // 
            // ListOfBooksButton
            // 
            ListOfBooksButton.Location = new Point(550, 225);
            ListOfBooksButton.Name = "ListOfBooksButton";
            ListOfBooksButton.Size = new Size(175, 50);
            ListOfBooksButton.TabIndex = 2;
            ListOfBooksButton.Text = "List of Books";
            ListOfBooksButton.UseVisualStyleBackColor = true;
            ListOfBooksButton.Click += ListOfBooksButtonClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(231, 150);
            label1.Name = "label1";
            label1.Size = new Size(313, 50);
            label1.TabIndex = 3;
            label1.Text = "Biblioteka";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeroPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 436);
            Controls.Add(label1);
            Controls.Add(ListOfBooksButton);
            Controls.Add(TakeReturnFormButton);
            Controls.Add(AddBookButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HeroPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteka";
            ResumeLayout(false);
        }

        #endregion

        private Button AddBookButton;
        private Button TakeReturnFormButton;
        private Button ListOfBooksButton;
        private Label label1;
    }
}
