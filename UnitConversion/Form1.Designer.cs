namespace UnitConversion
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.conversionsLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.conversionInput = new System.Windows.Forms.TextBox();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(80, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(359, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Conversions";
            // 
            // conversionsLabel
            // 
            this.conversionsLabel.AutoSize = true;
            this.conversionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.conversionsLabel.Location = new System.Drawing.Point(147, 74);
            this.conversionsLabel.Name = "conversionsLabel";
            this.conversionsLabel.Size = new System.Drawing.Size(211, 96);
            this.conversionsLabel.TabIndex = 1;
            this.conversionsLabel.Text = "1. Inches to Centimetres\r\n2. Feet to Centimetres\r\n3. Yards to Metres\r\n4. Miles to" +
    " Kilometres";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(295, 201);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 20);
            this.numberInput.TabIndex = 2;
            this.numberInput.TextChanged += new System.EventHandler(this.numberInput_TextChanged);
            // 
            // conversionInput
            // 
            this.conversionInput.Location = new System.Drawing.Point(295, 266);
            this.conversionInput.Name = "conversionInput";
            this.conversionInput.Size = new System.Drawing.Size(100, 20);
            this.conversionInput.TabIndex = 3;
            this.conversionInput.TextChanged += new System.EventHandler(this.conversionInput_TextChanged);
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.choiceLabel.Location = new System.Drawing.Point(69, 202);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(217, 16);
            this.choiceLabel.TabIndex = 4;
            this.choiceLabel.Text = "Enter Conversion Choice (1-4):";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inputLabel.Location = new System.Drawing.Point(76, 266);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(210, 16);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Enter Value to be Converted: ";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(12, 354);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(495, 31);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(79, 316);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(316, 23);
            this.convertButton.TabIndex = 7;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(535, 394);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.conversionInput);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.conversionsLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label conversionsLabel;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.TextBox conversionInput;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button convertButton;
    }
}

