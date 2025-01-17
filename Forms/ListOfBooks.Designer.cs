using FormBiblioteka.Modules;

namespace FormBiblioteka
{
    partial class ListOfBooks
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
            BookInfoLabel = new Label();
            BackButton = new Button();
            BookButtonDisplay = new Panel();
            Title = new Label();
            SuspendLayout();
            // 
            // BookInfoLabel
            // 
            BookInfoLabel.BorderStyle = BorderStyle.Fixed3D;
            BookInfoLabel.Font = new Font("Segoe UI", 18F);
            BookInfoLabel.Location = new Point(270, 9);
            BookInfoLabel.Name = "BookInfoLabel";
            BookInfoLabel.Size = new Size(500, 420);
            BookInfoLabel.TabIndex = 14;
            // 
            // BackButton
            // 
            BackButton.AllowDrop = true;
            BackButton.Font = new Font("Arial", 16F);
            BackButton.Location = new Point(8, 7);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(48, 41);
            BackButton.TabIndex = 17;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButtonClick;
            // 
            // BookButtonDisplay
            // 
            BookButtonDisplay.AutoScroll = true;
            BookButtonDisplay.BorderStyle = BorderStyle.Fixed3D;
            BookButtonDisplay.Location = new Point(14, 52);
            BookButtonDisplay.Name = "BookButtonDisplay";
            BookButtonDisplay.Size = new Size(250, 377);
            BookButtonDisplay.TabIndex = 18;
            // 
            // Title
            // 
            Title.BorderStyle = BorderStyle.Fixed3D;
            Title.Font = new Font("Segoe UI", 16F);
            Title.Location = new Point(59, 7);
            Title.Name = "Title";
            Title.Size = new Size(205, 41);
            Title.TabIndex = 19;
            Title.Text = "List of Books";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ListOfBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 436);
            Controls.Add(Title);
            Controls.Add(BookButtonDisplay);
            Controls.Add(BackButton);
            Controls.Add(BookInfoLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ListOfBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List of Books";
            Load += ListOfBooks_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label BookInfoLabel;
        private Button BackButton;
        private Panel BookButtonDisplay;
        private Label Title;
    }
}