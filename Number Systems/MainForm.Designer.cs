namespace Number_Systems
{
    partial class MainForm
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
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.comboBoxFirstNumber = new System.Windows.Forms.ComboBox();
            this.LabelMathAnswer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMathOperation = new System.Windows.Forms.ComboBox();
            this.comboBoxSecondNumber = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelComparisonAnswer = new System.Windows.Forms.Label();
            this.textBoxComparisonSecondValue = new System.Windows.Forms.TextBox();
            this.comboBoxComparisonSecondValue = new System.Windows.Forms.ComboBox();
            this.comboBoxComparisonFirstValue = new System.Windows.Forms.ComboBox();
            this.comboBoxComparison = new System.Windows.Forms.ComboBox();
            this.textBoxComparisonFirstValue = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labeHexadecimal = new System.Windows.Forms.Label();
            this.labelОctal = new System.Windows.Forms.Label();
            this.labelBinary = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Location = new System.Drawing.Point(23, 40);
            this.textBoxFirstNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstNumber.MaxLength = 12;
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(114, 27);
            this.textBoxFirstNumber.TabIndex = 0;
            this.textBoxFirstNumber.TextChanged += new System.EventHandler(this.MathChanged);
            this.textBoxFirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFirstNumber_KeyPress);
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Location = new System.Drawing.Point(23, 120);
            this.textBoxSecondNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSecondNumber.MaxLength = 12;
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(114, 27);
            this.textBoxSecondNumber.TabIndex = 1;
            this.textBoxSecondNumber.TextChanged += new System.EventHandler(this.MathChanged);
            this.textBoxSecondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSecondNumber_KeyPress);
            // 
            // comboBoxFirstNumber
            // 
            this.comboBoxFirstNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFirstNumber.FormattingEnabled = true;
            this.comboBoxFirstNumber.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBoxFirstNumber.Location = new System.Drawing.Point(149, 40);
            this.comboBoxFirstNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFirstNumber.Name = "comboBoxFirstNumber";
            this.comboBoxFirstNumber.Size = new System.Drawing.Size(51, 28);
            this.comboBoxFirstNumber.TabIndex = 2;
            this.comboBoxFirstNumber.TabStop = false;
            this.comboBoxFirstNumber.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFirstNumber_SelectedIndexChanged);
            // 
            // LabelMathAnswer
            // 
            this.LabelMathAnswer.AutoSize = true;
            this.LabelMathAnswer.Location = new System.Drawing.Point(23, 200);
            this.LabelMathAnswer.Name = "LabelMathAnswer";
            this.LabelMathAnswer.Size = new System.Drawing.Size(0, 20);
            this.LabelMathAnswer.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMathOperation);
            this.groupBox1.Controls.Add(this.comboBoxSecondNumber);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBoxFirstNumber);
            this.groupBox1.Controls.Add(this.LabelMathAnswer);
            this.groupBox1.Controls.Add(this.textBoxSecondNumber);
            this.groupBox1.Controls.Add(this.comboBoxFirstNumber);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(206, 267);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Математические операции";
            // 
            // comboBoxMathOperation
            // 
            this.comboBoxMathOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMathOperation.FormattingEnabled = true;
            this.comboBoxMathOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxMathOperation.Location = new System.Drawing.Point(6, 80);
            this.comboBoxMathOperation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMathOperation.Name = "comboBoxMathOperation";
            this.comboBoxMathOperation.Size = new System.Drawing.Size(39, 28);
            this.comboBoxMathOperation.TabIndex = 6;
            this.comboBoxMathOperation.TabStop = false;
            this.comboBoxMathOperation.SelectedIndexChanged += new System.EventHandler(this.MathChanged);
            // 
            // comboBoxSecondNumber
            // 
            this.comboBoxSecondNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecondNumber.FormattingEnabled = true;
            this.comboBoxSecondNumber.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBoxSecondNumber.Location = new System.Drawing.Point(149, 120);
            this.comboBoxSecondNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSecondNumber.Name = "comboBoxSecondNumber";
            this.comboBoxSecondNumber.Size = new System.Drawing.Size(51, 28);
            this.comboBoxSecondNumber.TabIndex = 5;
            this.comboBoxSecondNumber.TabStop = false;
            this.comboBoxSecondNumber.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSecondNumber_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(23, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 3);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelComparisonAnswer);
            this.groupBox2.Controls.Add(this.textBoxComparisonSecondValue);
            this.groupBox2.Controls.Add(this.comboBoxComparisonSecondValue);
            this.groupBox2.Controls.Add(this.comboBoxComparisonFirstValue);
            this.groupBox2.Controls.Add(this.comboBoxComparison);
            this.groupBox2.Controls.Add(this.textBoxComparisonFirstValue);
            this.groupBox2.Location = new System.Drawing.Point(11, 293);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(617, 133);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сравнение";
            // 
            // labelComparisonAnswer
            // 
            this.labelComparisonAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComparisonAnswer.Location = new System.Drawing.Point(23, 93);
            this.labelComparisonAnswer.Name = "labelComparisonAnswer";
            this.labelComparisonAnswer.Size = new System.Drawing.Size(571, 20);
            this.labelComparisonAnswer.TabIndex = 6;
            this.labelComparisonAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxComparisonSecondValue
            // 
            this.textBoxComparisonSecondValue.Location = new System.Drawing.Point(366, 40);
            this.textBoxComparisonSecondValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComparisonSecondValue.MaxLength = 12;
            this.textBoxComparisonSecondValue.Name = "textBoxComparisonSecondValue";
            this.textBoxComparisonSecondValue.Size = new System.Drawing.Size(114, 27);
            this.textBoxComparisonSecondValue.TabIndex = 5;
            this.textBoxComparisonSecondValue.TextChanged += new System.EventHandler(this.ComparisonChanged);
            this.textBoxComparisonSecondValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxComparisonSecondValue_KeyPress);
            // 
            // comboBoxComparisonSecondValue
            // 
            this.comboBoxComparisonSecondValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComparisonSecondValue.FormattingEnabled = true;
            this.comboBoxComparisonSecondValue.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBoxComparisonSecondValue.Location = new System.Drawing.Point(495, 40);
            this.comboBoxComparisonSecondValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxComparisonSecondValue.Name = "comboBoxComparisonSecondValue";
            this.comboBoxComparisonSecondValue.Size = new System.Drawing.Size(49, 28);
            this.comboBoxComparisonSecondValue.TabIndex = 4;
            this.comboBoxComparisonSecondValue.TabStop = false;
            this.comboBoxComparisonSecondValue.SelectedValueChanged += new System.EventHandler(this.ComboBoxComparisonSecondValue_SelectedValueChanged);
            // 
            // comboBoxComparisonFirstValue
            // 
            this.comboBoxComparisonFirstValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComparisonFirstValue.FormattingEnabled = true;
            this.comboBoxComparisonFirstValue.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBoxComparisonFirstValue.Location = new System.Drawing.Point(206, 40);
            this.comboBoxComparisonFirstValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxComparisonFirstValue.Name = "comboBoxComparisonFirstValue";
            this.comboBoxComparisonFirstValue.Size = new System.Drawing.Size(49, 28);
            this.comboBoxComparisonFirstValue.TabIndex = 3;
            this.comboBoxComparisonFirstValue.TabStop = false;
            this.comboBoxComparisonFirstValue.SelectedValueChanged += new System.EventHandler(this.ComboBoxComparisonFirstValue_SelectedValueChanged);
            // 
            // comboBoxComparison
            // 
            this.comboBoxComparison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComparison.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxComparison.FormattingEnabled = true;
            this.comboBoxComparison.Items.AddRange(new object[] {
            "=",
            "≠",
            "<",
            "≤",
            ">",
            "≥"});
            this.comboBoxComparison.Location = new System.Drawing.Point(286, 36);
            this.comboBoxComparison.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxComparison.Name = "comboBoxComparison";
            this.comboBoxComparison.Size = new System.Drawing.Size(45, 36);
            this.comboBoxComparison.TabIndex = 2;
            this.comboBoxComparison.TabStop = false;
            this.comboBoxComparison.SelectedValueChanged += new System.EventHandler(this.ComparisonChanged);
            // 
            // textBoxComparisonFirstValue
            // 
            this.textBoxComparisonFirstValue.Location = new System.Drawing.Point(80, 40);
            this.textBoxComparisonFirstValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComparisonFirstValue.MaxLength = 12;
            this.textBoxComparisonFirstValue.Name = "textBoxComparisonFirstValue";
            this.textBoxComparisonFirstValue.Size = new System.Drawing.Size(114, 27);
            this.textBoxComparisonFirstValue.TabIndex = 0;
            this.textBoxComparisonFirstValue.TextChanged += new System.EventHandler(this.ComparisonChanged);
            this.textBoxComparisonFirstValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxComparisonFirstValue_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labeHexadecimal);
            this.groupBox3.Controls.Add(this.labelОctal);
            this.groupBox3.Controls.Add(this.labelBinary);
            this.groupBox3.Controls.Add(this.textBoxNumber);
            this.groupBox3.Location = new System.Drawing.Point(229, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(400, 267);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перевод в системы счисления";
            // 
            // labeHexadecimal
            // 
            this.labeHexadecimal.AutoSize = true;
            this.labeHexadecimal.Location = new System.Drawing.Point(23, 173);
            this.labeHexadecimal.Name = "labeHexadecimal";
            this.labeHexadecimal.Size = new System.Drawing.Size(0, 20);
            this.labeHexadecimal.TabIndex = 3;
            // 
            // labelОctal
            // 
            this.labelОctal.AutoSize = true;
            this.labelОctal.Location = new System.Drawing.Point(23, 133);
            this.labelОctal.Name = "labelОctal";
            this.labelОctal.Size = new System.Drawing.Size(0, 20);
            this.labelОctal.TabIndex = 2;
            // 
            // labelBinary
            // 
            this.labelBinary.AutoSize = true;
            this.labelBinary.Location = new System.Drawing.Point(23, 93);
            this.labelBinary.Name = "labelBinary";
            this.labelBinary.Size = new System.Drawing.Size(0, 20);
            this.labelBinary.TabIndex = 1;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(23, 40);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumber.MaxLength = 12;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(91, 27);
            this.textBoxNumber.TabIndex = 0;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.NumberChanged);
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumber_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Калькулятор систем счисления";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.ComboBox comboBoxFirstNumber;
        private System.Windows.Forms.Label LabelMathAnswer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxComparison;
        private System.Windows.Forms.TextBox textBoxComparisonFirstValue;
        private System.Windows.Forms.Label labeHexadecimal;
        private System.Windows.Forms.Label labelОctal;
        private System.Windows.Forms.Label labelBinary;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxMathOperation;
        private System.Windows.Forms.ComboBox comboBoxSecondNumber;
        private System.Windows.Forms.TextBox textBoxComparisonSecondValue;
        private System.Windows.Forms.ComboBox comboBoxComparisonSecondValue;
        private System.Windows.Forms.ComboBox comboBoxComparisonFirstValue;
        private System.Windows.Forms.Label labelComparisonAnswer;
    }
}
