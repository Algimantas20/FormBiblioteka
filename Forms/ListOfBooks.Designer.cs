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
            ExitButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // BookInfoLabel
            // 
            BookInfoLabel.Font = new Font("Segoe UI", 18F);
            BookInfoLabel.Location = new Point(314, 12);
            BookInfoLabel.Name = "BookInfoLabel";
            BookInfoLabel.Size = new Size(568, 557);
            BookInfoLabel.TabIndex = 14;
            // 
            // ExitButton
            // 
            ExitButton.AllowDrop = true;
            ExitButton.Font = new Font("Arial", 12F);
            ExitButton.Location = new Point(827, 9);
            ExitButton.Margin = new Padding(0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(55, 55);
            ExitButton.TabIndex = 16;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.AllowDrop = true;
            BackButton.Font = new Font("Arial", 16F);
            BackButton.Location = new Point(9, 9);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(55, 55);
            BackButton.TabIndex = 17;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButtonClick;
            // 
            // ListOfBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 581);
            Controls.Add(BackButton);
            Controls.Add(ExitButton);
            Controls.Add(BookInfoLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListOfBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List of Books";
            Load += ListOfBooks_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label BookInfoLabel;
        private Button ExitButton;
        private Button BackButton;
    }
}