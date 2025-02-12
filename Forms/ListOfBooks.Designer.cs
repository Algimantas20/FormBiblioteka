﻿using FormBiblioteka.Modules;

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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BookInfoLabel
            // 
            BookInfoLabel.BackColor = SystemColors.ControlLight;
            BookInfoLabel.Font = new Font("Times New Roman", 18F);
            BookInfoLabel.Location = new Point(-2, -2);
            BookInfoLabel.Name = "BookInfoLabel";
            BookInfoLabel.Size = new Size(487, 392);
            BookInfoLabel.TabIndex = 14;
            // 
            // BackButton
            // 
            BackButton.AllowDrop = true;
            BackButton.BackColor = SystemColors.ControlLight;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("Times New Roman", 16F);
            BackButton.Location = new Point(14, 7);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(48, 41);
            BackButton.TabIndex = 17;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButtonClick;
            // 
            // BookButtonDisplay
            // 
            BookButtonDisplay.AutoScroll = true;
            BookButtonDisplay.BackColor = SystemColors.ControlLight;
            BookButtonDisplay.BorderStyle = BorderStyle.Fixed3D;
            BookButtonDisplay.Location = new Point(14, 52);
            BookButtonDisplay.Name = "BookButtonDisplay";
            BookButtonDisplay.Size = new Size(250, 347);
            BookButtonDisplay.TabIndex = 18;
            // 
            // Title
            // 
            Title.BackColor = SystemColors.ControlLight;
            Title.BorderStyle = BorderStyle.Fixed3D;
            Title.Font = new Font("Times New Roman", 16F);
            Title.Location = new Point(65, 7);
            Title.Name = "Title";
            Title.Size = new Size(199, 41);
            Title.TabIndex = 19;
            Title.Text = "List of Books";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BookInfoLabel);
            panel1.Location = new Point(270, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 392);
            panel1.TabIndex = 20;
            // 
            // ListOfBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 411);
            Controls.Add(Title);
            Controls.Add(panel1);
            Controls.Add(BookButtonDisplay);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ListOfBooks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List of Books";
            Load += ListOfBooks_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label BookInfoLabel;
        private Button BackButton;
        private Panel BookButtonDisplay;
        private Label Title;
        private Panel panel1;
    }
}