using FormBiblioteka.Modules;

namespace FormBiblioteka
{
    partial class Take_ReturnForm
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
            OperationTypeInput = new ComboBox();
            TitleTextLabel = new Label();
            label1 = new Label();
            BookInput = new ComboBox();
            NumberOfBooksInput = new NumericUpDown();
            label2 = new Label();
            HeaderLabel = new Label();
            SubmitButton = new Button();
            ExitButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NumberOfBooksInput).BeginInit();
            SuspendLayout();
            // 
            // OperationTypeInput
            // 
            OperationTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            OperationTypeInput.FormattingEnabled = true;
            OperationTypeInput.Items.AddRange(new object[] { "Take", "Return" });
            OperationTypeInput.Location = new Point(211, 161);
            OperationTypeInput.MaxDropDownItems = 10;
            OperationTypeInput.Name = "OperationTypeInput";
            OperationTypeInput.Size = new Size(151, 28);
            OperationTypeInput.TabIndex = 0;
            // 
            // TitleTextLabel
            // 
            TitleTextLabel.AutoSize = true;
            TitleTextLabel.Font = new Font("Segoe UI", 12F);
            TitleTextLabel.Location = new Point(110, 164);
            TitleTextLabel.Name = "TitleTextLabel";
            TitleTextLabel.Size = new Size(105, 28);
            TitleTextLabel.TabIndex = 2;
            TitleTextLabel.Text = "Operation:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(150, 195);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 4;
            label1.Text = "Book:";
            // 
            // BookInput
            // 
            BookInput.DropDownStyle = ComboBoxStyle.DropDownList;
            BookInput.FormattingEnabled = true;
            BookInput.Location = new Point(211, 195);
            BookInput.Name = "BookInput";
            BookInput.Size = new Size(151, 28);
            BookInput.TabIndex = 3;
            // 
            // NumberOfBooksInput
            // 
            NumberOfBooksInput.BorderStyle = BorderStyle.FixedSingle;
            NumberOfBooksInput.Location = new Point(211, 229);
            NumberOfBooksInput.Name = "NumberOfBooksInput";
            NumberOfBooksInput.Size = new Size(151, 27);
            NumberOfBooksInput.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(126, 229);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 6;
            label2.Text = "Amount:";
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 24F);
            HeaderLabel.Location = new Point(67, 77);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(418, 54);
            HeaderLabel.TabIndex = 11;
            HeaderLabel.Text = "Take or Return a Book:";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(731, 519);
            SubmitButton.Margin = new Padding(3, 4, 3, 4);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(151, 47);
            SubmitButton.TabIndex = 14;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButtonClick;
            // 
            // ExitButton
            // 
            ExitButton.AllowDrop = true;
            ExitButton.Font = new Font("Arial", 12F);
            ExitButton.Location = new Point(827, 9);
            ExitButton.Margin = new Padding(0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(55, 55);
            ExitButton.TabIndex = 17;
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
            BackButton.TabIndex = 18;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButtonClick;
            // 
            // Take_ReturnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 581);
            Controls.Add(BackButton);
            Controls.Add(ExitButton);
            Controls.Add(SubmitButton);
            Controls.Add(HeaderLabel);
            Controls.Add(label2);
            Controls.Add(NumberOfBooksInput);
            Controls.Add(label1);
            Controls.Add(BookInput);
            Controls.Add(TitleTextLabel);
            Controls.Add(OperationTypeInput);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Take_ReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Take_ReturnForm";
            Load += TakeReturnFormLoad;
            ((System.ComponentModel.ISupportInitialize)NumberOfBooksInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox OperationTypeInput;
        private Label TitleTextLabel;
        private Label label1;
        private ComboBox BookInput;
        private NumericUpDown NumberOfBooksInput;
        private Label label2;
        private Label HeaderLabel;
        private Button SubmitButton;
        private Button ExitButton;
        private Button BackButton;
    }
}