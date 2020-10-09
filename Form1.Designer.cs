namespace My22
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
            this.Sum = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Divition = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sum
            // 
            this.Sum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sum.Location = new System.Drawing.Point(59, 145);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(117, 62);
            this.Sum.TabIndex = 0;
            this.Sum.Text = "Addition";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Subtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Subtract.Location = new System.Drawing.Point(182, 145);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(117, 62);
            this.Subtract.TabIndex = 1;
            this.Subtract.Text = "Subtraction";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Divition
            // 
            this.Divition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Divition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Divition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Divition.Location = new System.Drawing.Point(182, 213);
            this.Divition.Name = "Divition";
            this.Divition.Size = new System.Drawing.Size(117, 62);
            this.Divition.TabIndex = 2;
            this.Divition.Text = "Divition";
            this.Divition.UseVisualStyleBackColor = true;
            this.Divition.Click += new System.EventHandler(this.Divition_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiply.Location = new System.Drawing.Point(59, 213);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(117, 62);
            this.Multiply.TabIndex = 3;
            this.Multiply.Text = "Multiplication";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(59, 75);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(240, 22);
            this.num1.TabIndex = 4;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(59, 103);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(240, 22);
            this.num2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Simple Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divition);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Sum);
            this.Name = "Form1";
            this.Text = "Event Driven";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Divition;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label1;
    }
}

