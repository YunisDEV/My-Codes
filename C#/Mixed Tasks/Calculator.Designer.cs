namespace task
{
    partial class Calculator
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
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.cbPlus = new System.Windows.Forms.CheckBox();
            this.calculate = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.cbMinus = new System.Windows.Forms.CheckBox();
            this.cbDivide = new System.Windows.Forms.CheckBox();
            this.cbMultiple = new System.Windows.Forms.CheckBox();
            this.cbModal = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(238, 96);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(132, 38);
            this.A.TabIndex = 0;
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(429, 96);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(125, 38);
            this.B.TabIndex = 1;
            // 
            // cbPlus
            // 
            this.cbPlus.AutoSize = true;
            this.cbPlus.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlus.Location = new System.Drawing.Point(238, 191);
            this.cbPlus.Name = "cbPlus";
            this.cbPlus.Size = new System.Drawing.Size(35, 53);
            this.cbPlus.TabIndex = 2;
            this.cbPlus.Text = "+";
            this.cbPlus.UseVisualStyleBackColor = true;
            this.cbPlus.CheckedChanged += new System.EventHandler(this.CbPlus_CheckedChanged);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(295, 314);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(210, 46);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(348, 265);
            this.output.MinimumSize = new System.Drawing.Size(100, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 32);
            this.output.TabIndex = 4;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMinus
            // 
            this.cbMinus.AutoSize = true;
            this.cbMinus.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinus.Location = new System.Drawing.Point(310, 191);
            this.cbMinus.Name = "cbMinus";
            this.cbMinus.Size = new System.Drawing.Size(28, 53);
            this.cbMinus.TabIndex = 5;
            this.cbMinus.Text = "-";
            this.cbMinus.UseVisualStyleBackColor = true;
            this.cbMinus.CheckedChanged += new System.EventHandler(this.CbMinus_CheckedChanged);
            // 
            // cbDivide
            // 
            this.cbDivide.AutoSize = true;
            this.cbDivide.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDivide.Location = new System.Drawing.Point(391, 191);
            this.cbDivide.Name = "cbDivide";
            this.cbDivide.Size = new System.Drawing.Size(27, 53);
            this.cbDivide.TabIndex = 6;
            this.cbDivide.Text = "/";
            this.cbDivide.UseVisualStyleBackColor = true;
            this.cbDivide.CheckedChanged += new System.EventHandler(this.CbDivide_CheckedChanged);
            // 
            // cbMultiple
            // 
            this.cbMultiple.AutoSize = true;
            this.cbMultiple.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMultiple.Location = new System.Drawing.Point(452, 191);
            this.cbMultiple.Name = "cbMultiple";
            this.cbMultiple.Size = new System.Drawing.Size(30, 53);
            this.cbMultiple.TabIndex = 7;
            this.cbMultiple.Text = "*";
            this.cbMultiple.UseVisualStyleBackColor = true;
            this.cbMultiple.CheckedChanged += new System.EventHandler(this.CbMultiple_CheckedChanged);
            // 
            // cbModal
            // 
            this.cbModal.AutoSize = true;
            this.cbModal.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModal.Location = new System.Drawing.Point(510, 191);
            this.cbModal.Name = "cbModal";
            this.cbModal.Size = new System.Drawing.Size(44, 53);
            this.cbModal.TabIndex = 8;
            this.cbModal.Text = "%";
            this.cbModal.UseVisualStyleBackColor = true;
            this.cbModal.CheckedChanged += new System.EventHandler(this.CbModal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "B";
            // 
            // Kalkulyator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModal);
            this.Controls.Add(this.cbMultiple);
            this.Controls.Add(this.cbDivide);
            this.Controls.Add(this.cbMinus);
            this.Controls.Add(this.output);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.cbPlus);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kalkulyator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.CheckBox cbPlus;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.CheckBox cbMinus;
        private System.Windows.Forms.CheckBox cbDivide;
        private System.Windows.Forms.CheckBox cbMultiple;
        private System.Windows.Forms.CheckBox cbModal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

