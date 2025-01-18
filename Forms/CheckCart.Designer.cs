namespace FormBiblioteka.Forms
{
    partial class CheckCart
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
            BookButtonDisplay = new Panel();
            BookInfoLabel = new Label();
            Title = new Label();
            BackButton = new Button();
            BookInfoDisplayLabel = new Label();
            SuspendLayout();
            // 
            // BookButtonDisplay
            // 
            BookButtonDisplay.AutoScroll = true;
            BookButtonDisplay.BackColor = SystemColors.ControlLight;
            BookButtonDisplay.BorderStyle = BorderStyle.Fixed3D;
            BookButtonDisplay.Location = new Point(12, 71);
            BookButtonDisplay.Margin = new Padding(3, 4, 3, 4);
            BookButtonDisplay.Name = "BookButtonDisplay";
            BookButtonDisplay.Size = new Size(285, 468);
            BookButtonDisplay.TabIndex = 19;
            // 
            // BookInfoLabel
            // 
            BookInfoLabel.BackColor = SystemColors.ControlLight;
            BookInfoLabel.BorderStyle = BorderStyle.Fixed3D;
            BookInfoLabel.Font = new Font("Times New Roman", 18F);
            BookInfoLabel.Location = new Point(303, 11);
            BookInfoLabel.Name = "BookInfoLabel";
            BookInfoLabel.Size = new Size(564, 524);
            BookInfoLabel.TabIndex = 15;
            // 
            // Title
            // 
            Title.BackColor = SystemColors.ControlLight;
            Title.BorderStyle = BorderStyle.Fixed3D;
            Title.Font = new Font("Times New Roman", 16F);
            Title.Location = new Point(70, 12);
            Title.Name = "Title";
            Title.Size = new Size(227, 55);
            Title.TabIndex = 21;
            Title.Text = "View Cart";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            BackButton.AllowDrop = true;
            BackButton.BackColor = SystemColors.ControlLight;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Times New Roman", 16F);
            BackButton.Location = new Point(12, 12);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(55, 55);
            BackButton.TabIndex = 20;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButtonClick;
            // 
            // BookInfoDisplayLabel
            // 
            BookInfoDisplayLabel.BackColor = SystemColors.ControlLight;
            BookInfoDisplayLabel.Font = new Font("Times New Roman", 18F);
            BookInfoDisplayLabel.Location = new Point(303, 12);
            BookInfoDisplayLabel.Name = "BookInfoDisplayLabel";
            BookInfoDisplayLabel.Size = new Size(564, 527);
            BookInfoDisplayLabel.TabIndex = 22;
            // 
            // CheckCart
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 548);
            Controls.Add(BookInfoDisplayLabel);
            Controls.Add(Title);
            Controls.Add(BackButton);
            Controls.Add(BookInfoLabel);
            Controls.Add(BookButtonDisplay);
            Font = new Font("Times New Roman", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CheckCart";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteka";
            Load += CheckCart_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel BookButtonDisplay;
        private Label BookInfoLabel;
        private Label Title;
        private Button BackButton;
        private Label BookInfoDisplayLabel;
    }
}