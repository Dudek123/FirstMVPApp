namespace FirstMVPApp
{
    partial class FirstMVPAppView
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxOperand1 = new System.Windows.Forms.TextBox();
            this.textBoxOperand2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelOperand1 = new System.Windows.Forms.Label();
            this.labelOperand2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 66);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(41, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxOperand1
            // 
            this.textBoxOperand1.Location = new System.Drawing.Point(123, 12);
            this.textBoxOperand1.Name = "textBoxOperand1";
            this.textBoxOperand1.Size = new System.Drawing.Size(100, 20);
            this.textBoxOperand1.TabIndex = 1;
            this.textBoxOperand1.TextChanged += new System.EventHandler(this.textBoxOperand1_TextChanged);
            // 
            // textBoxOperand2
            // 
            this.textBoxOperand2.Location = new System.Drawing.Point(123, 37);
            this.textBoxOperand2.Name = "textBoxOperand2";
            this.textBoxOperand2.Size = new System.Drawing.Size(100, 20);
            this.textBoxOperand2.TabIndex = 2;
            this.textBoxOperand2.TextChanged += new System.EventHandler(this.textBoxOperand2_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(123, 95);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // labelOperand1
            // 
            this.labelOperand1.AutoSize = true;
            this.labelOperand1.Location = new System.Drawing.Point(63, 15);
            this.labelOperand1.Name = "labelOperand1";
            this.labelOperand1.Size = new System.Drawing.Size(54, 13);
            this.labelOperand1.TabIndex = 4;
            this.labelOperand1.Text = "Operand1";
            // 
            // labelOperand2
            // 
            this.labelOperand2.AutoSize = true;
            this.labelOperand2.Location = new System.Drawing.Point(63, 40);
            this.labelOperand2.Name = "labelOperand2";
            this.labelOperand2.Size = new System.Drawing.Size(54, 13);
            this.labelOperand2.TabIndex = 5;
            this.labelOperand2.Text = "Operand2";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(80, 98);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(74, 66);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(61, 23);
            this.buttonSubtract.TabIndex = 7;
            this.buttonSubtract.Text = "Subtract";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(141, 66);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(61, 23);
            this.buttonMultiply.TabIndex = 8;
            this.buttonMultiply.Text = "Multiply";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(208, 66);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(61, 23);
            this.buttonDivide.TabIndex = 9;
            this.buttonDivide.Text = "Divide";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // FirstMVPAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 133);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelOperand2);
            this.Controls.Add(this.labelOperand1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxOperand2);
            this.Controls.Add(this.textBoxOperand1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FirstMVPAppView";
            this.Text = "First MVP App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxOperand1;
        private System.Windows.Forms.TextBox textBoxOperand2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelOperand1;
        private System.Windows.Forms.Label labelOperand2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
    }
}

