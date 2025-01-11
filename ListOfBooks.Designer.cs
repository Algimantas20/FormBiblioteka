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
            BackButton = new Button();
            BookInfoLabel = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(0, 0);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(95, 40);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButtonClick;
            // 
            // BookInfoLabel
            // 
            BookInfoLabel.Font = new Font("Segoe UI", 18F);
            BookInfoLabel.Location = new Point(314, 12);
            BookInfoLabel.Name = "BookInfoLabel";
            BookInfoLabel.Size = new Size(568, 557);
            BookInfoLabel.TabIndex = 14;
            // 
            // ListOfBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 581);
            Controls.Add(BookInfoLabel);
            Controls.Add(BackButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListOfBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List of Books";
            Load += ListOfBooks_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BackButton;
        private Label BookInfoLabel;
    }
}