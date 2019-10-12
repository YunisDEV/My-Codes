namespace Calculator
{
    partial class calc
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.rdMultiple = new System.Windows.Forms.RadioButton();
            this.rdDivide = new System.Windows.Forms.RadioButton();
            this.rdPlus = new System.Windows.Forms.RadioButton();
            this.rdMinus = new System.Windows.Forms.RadioButton();
            this.rdPow = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.process = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "A ədədi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "B ədədi";
            // 
            // textA
            // 
            this.textA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textA.Location = new System.Drawing.Point(71, 102);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(140, 34);
            this.textA.TabIndex = 2;
            // 
            // textB
            // 
            this.textB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB.Location = new System.Drawing.Point(267, 102);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(143, 34);
            this.textB.TabIndex = 3;
            // 
            // rdMultiple
            // 
            this.rdMultiple.AutoSize = true;
            this.rdMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMultiple.Location = new System.Drawing.Point(71, 169);
            this.rdMultiple.Name = "rdMultiple";
            this.rdMultiple.Size = new System.Drawing.Size(103, 33);
            this.rdMultiple.TabIndex = 4;
            this.rdMultiple.TabStop = true;
            this.rdMultiple.Text = "Vurma";
            this.rdMultiple.UseVisualStyleBackColor = true;
            this.rdMultiple.CheckedChanged += new System.EventHandler(this.RdMultiple_CheckedChanged);
            // 
            // rdDivide
            // 
            this.rdDivide.AutoSize = true;
            this.rdDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDivide.Location = new System.Drawing.Point(180, 169);
            this.rdDivide.Name = "rdDivide";
            this.rdDivide.Size = new System.Drawing.Size(104, 33);
            this.rdDivide.TabIndex = 5;
            this.rdDivide.TabStop = true;
            this.rdDivide.Text = "Bölmə";
            this.rdDivide.UseVisualStyleBackColor = true;
            this.rdDivide.CheckedChanged += new System.EventHandler(this.RdDivide_CheckedChanged);
            // 
            // rdPlus
            // 
            this.rdPlus.AutoSize = true;
            this.rdPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPlus.Location = new System.Drawing.Point(290, 169);
            this.rdPlus.Name = "rdPlus";
            this.rdPlus.Size = new System.Drawing.Size(130, 33);
            this.rdPlus.TabIndex = 6;
            this.rdPlus.TabStop = true;
            this.rdPlus.Text = "Toplama";
            this.rdPlus.UseVisualStyleBackColor = true;
            this.rdPlus.CheckedChanged += new System.EventHandler(this.RdPlus_CheckedChanged);
            // 
            // rdMinus
            // 
            this.rdMinus.AutoSize = true;
            this.rdMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMinus.Location = new System.Drawing.Point(426, 169);
            this.rdMinus.Name = "rdMinus";
            this.rdMinus.Size = new System.Drawing.Size(101, 33);
            this.rdMinus.TabIndex = 7;
            this.rdMinus.TabStop = true;
            this.rdMinus.Text = "Çıxma";
            this.rdMinus.UseVisualStyleBackColor = true;
            this.rdMinus.CheckedChanged += new System.EventHandler(this.RdMinus_CheckedChanged);
            // 
            // rdPow
            // 
            this.rdPow.AutoSize = true;
            this.rdPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPow.Location = new System.Drawing.Point(533, 169);
            this.rdPow.Name = "rdPow";
            this.rdPow.Size = new System.Drawing.Size(108, 33);
            this.rdPow.TabIndex = 8;
            this.rdPow.TabStop = true;
            this.rdPow.Text = "Qüvvət";
            this.rdPow.UseVisualStyleBackColor = true;
            this.rdPow.CheckedChanged += new System.EventHandler(this.RdPow_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(71, 246);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(140, 42);
            this.submit.TabIndex = 9;
            this.submit.Text = "HESABLA";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // process
            // 
            this.process.AutoSize = true;
            this.process.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process.Location = new System.Drawing.Point(229, 102);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(0, 29);
            this.process.TabIndex = 10;
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.process);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.rdPow);
            this.Controls.Add(this.rdMinus);
            this.Controls.Add(this.rdPlus);
            this.Controls.Add(this.rdDivide);
            this.Controls.Add(this.rdMultiple);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulyator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.RadioButton rdMultiple;
        private System.Windows.Forms.RadioButton rdDivide;
        private System.Windows.Forms.RadioButton rdPlus;
        private System.Windows.Forms.RadioButton rdMinus;
        private System.Windows.Forms.RadioButton rdPow;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label process;
    }
}

