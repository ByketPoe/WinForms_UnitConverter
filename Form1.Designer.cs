
namespace unit_converter
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
            this.button1 = new System.Windows.Forms.Button();
            this.MeasureBox = new System.Windows.Forms.ComboBox();
            this.comboBoxUnitIn = new System.Windows.Forms.ComboBox();
            this.comboBoxUnitOut = new System.Windows.Forms.ComboBox();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MeasureBox
            // 
            this.MeasureBox.AllowDrop = true;
            this.MeasureBox.FormattingEnabled = true;
            this.MeasureBox.Items.AddRange(new object[] {
            "Length"});
            this.MeasureBox.Location = new System.Drawing.Point(45, 101);
            this.MeasureBox.Name = "MeasureBox";
            this.MeasureBox.Size = new System.Drawing.Size(138, 23);
            this.MeasureBox.TabIndex = 1;
            this.MeasureBox.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeasureBox_SelectedIndexChanged);
            // 
            // comboBoxUnitIn
            // 
            this.comboBoxUnitIn.AllowDrop = true;
            this.comboBoxUnitIn.FormattingEnabled = true;
            this.comboBoxUnitIn.Location = new System.Drawing.Point(45, 179);
            this.comboBoxUnitIn.Name = "comboBoxUnitIn";
            this.comboBoxUnitIn.Size = new System.Drawing.Size(138, 23);
            this.comboBoxUnitIn.TabIndex = 2;
            // 
            // comboBoxUnitOut
            // 
            this.comboBoxUnitOut.AllowDrop = true;
            this.comboBoxUnitOut.FormattingEnabled = true;
            this.comboBoxUnitOut.Location = new System.Drawing.Point(218, 179);
            this.comboBoxUnitOut.Name = "comboBoxUnitOut";
            this.comboBoxUnitOut.Size = new System.Drawing.Size(140, 23);
            this.comboBoxUnitOut.TabIndex = 3;
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(45, 259);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(138, 23);
            this.fromInput.TabIndex = 4;
            this.fromInput.Text = "Enter value to convert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Measurement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // toOutput
            // 
            this.toOutput.Enabled = false;
            this.toOutput.Location = new System.Drawing.Point(218, 259);
            this.toOutput.Name = "toOutput";
            this.toOutput.Size = new System.Drawing.Size(140, 23);
            this.toOutput.TabIndex = 8;
            this.toOutput.Text = "Answer will appear here";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 425);
            this.Controls.Add(this.toOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.comboBoxUnitOut);
            this.Controls.Add(this.comboBoxUnitIn);
            this.Controls.Add(this.MeasureBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox MeasureBox;
        private System.Windows.Forms.ComboBox comboBoxUnitIn;
        private System.Windows.Forms.ComboBox comboBoxUnitOut;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toOutput;
    }
}

