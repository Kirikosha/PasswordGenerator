namespace PasswordGenerator
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
            label1 = new Label();
            passwordField = new TextBox();
            copyButton = new Button();
            roundedButton1 = new Controls.RoundedButton();
            uppercaseCondition = new CheckBox();
            numberCondition = new CheckBox();
            symbolsCondition = new CheckBox();
            paswordLengthField = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(53, 53, 53);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 0;
            label1.Text = "Password:";
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.FromArgb(60, 110, 113);
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordField.Location = new Point(147, 34);
            passwordField.Name = "passwordField";
            passwordField.ReadOnly = true;
            passwordField.Size = new Size(210, 32);
            passwordField.TabIndex = 2;
            // 
            // copyButton
            // 
            copyButton.BackColor = Color.FromArgb(53, 53, 53);
            copyButton.BackgroundImageLayout = ImageLayout.None;
            copyButton.FlatAppearance.BorderSize = 0;
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            copyButton.ForeColor = Color.White;
            copyButton.Location = new Point(354, 34);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(74, 32);
            copyButton.TabIndex = 3;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = false;
            copyButton.Click += CopyPassword;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(53, 53, 53);
            roundedButton1.BorderRadius = 40;
            roundedButton1.BorderSize = 0;
            roundedButton1.Color = Color.FromArgb(53, 53, 53);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(480, 31);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(150, 40);
            roundedButton1.TabIndex = 4;
            roundedButton1.Text = "Generate";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += PasswordGenerateClick;
            // 
            // uppercaseCondition
            // 
            uppercaseCondition.AutoSize = true;
            uppercaseCondition.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            uppercaseCondition.Location = new Point(44, 100);
            uppercaseCondition.Name = "uppercaseCondition";
            uppercaseCondition.Size = new Size(132, 34);
            uppercaseCondition.TabIndex = 5;
            uppercaseCondition.Text = "UpperCase";
            uppercaseCondition.UseVisualStyleBackColor = true;
            // 
            // numberCondition
            // 
            numberCondition.AutoSize = true;
            numberCondition.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            numberCondition.Location = new Point(44, 140);
            numberCondition.Name = "numberCondition";
            numberCondition.Size = new Size(117, 34);
            numberCondition.TabIndex = 6;
            numberCondition.Text = "Numbers";
            numberCondition.UseVisualStyleBackColor = true;
            // 
            // symbolsCondition
            // 
            symbolsCondition.AutoSize = true;
            symbolsCondition.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            symbolsCondition.Location = new Point(44, 180);
            symbolsCondition.Name = "symbolsCondition";
            symbolsCondition.Size = new Size(108, 34);
            symbolsCondition.TabIndex = 7;
            symbolsCondition.Text = "Symbols";
            symbolsCondition.UseVisualStyleBackColor = true;
            // 
            // paswordLengthField
            // 
            paswordLengthField.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            paswordLengthField.Location = new Point(214, 229);
            paswordLengthField.Name = "paswordLengthField";
            paswordLengthField.Size = new Size(63, 35);
            paswordLengthField.TabIndex = 8;
            paswordLengthField.Text = "6";
            paswordLengthField.TextChanged += InputAnalyser;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 232);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 9;
            label2.Text = "Password length";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(844, 314);
            Controls.Add(label2);
            Controls.Add(paswordLengthField);
            Controls.Add(symbolsCondition);
            Controls.Add(numberCondition);
            Controls.Add(uppercaseCondition);
            Controls.Add(roundedButton1);
            Controls.Add(copyButton);
            Controls.Add(passwordField);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox passwordField;
        private Button copyButton;
        private Controls.RoundedButton roundedButton1;
        private CheckBox uppercaseCondition;
        private CheckBox numberCondition;
        private CheckBox symbolsCondition;
        private TextBox paswordLengthField;
        private Label label2;
    }
}