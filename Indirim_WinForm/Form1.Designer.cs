namespace Indirim_WinForm
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
            groupBox1 = new GroupBox();
            chcKampanyaInd = new CheckBox();
            chcNakitInd = new CheckBox();
            groupBox2 = new GroupBox();
            btnHesapla = new Button();
            txtTutar = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chcKampanyaInd);
            groupBox1.Controls.Add(chcNakitInd);
            groupBox1.Location = new Point(48, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Indirimler";
            // 
            // chcKampanyaInd
            // 
            chcKampanyaInd.AutoSize = true;
            chcKampanyaInd.Location = new Point(26, 64);
            chcKampanyaInd.Name = "chcKampanyaInd";
            chcKampanyaInd.Size = new Size(151, 19);
            chcKampanyaInd.TabIndex = 1;
            chcKampanyaInd.Text = "%10 Kampanya Indirimi";
            chcKampanyaInd.UseVisualStyleBackColor = true;
            // 
            // chcNakitInd
            // 
            chcNakitInd.AutoSize = true;
            chcNakitInd.Location = new Point(26, 39);
            chcNakitInd.Name = "chcNakitInd";
            chcNakitInd.Size = new Size(117, 19);
            chcNakitInd.TabIndex = 0;
            chcNakitInd.Text = "%5 Nakit Indirimi";
            chcNakitInd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHesapla);
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(280, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hesaplama";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(18, 85);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(161, 23);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(68, 37);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(111, 23);
            txtTutar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "TUTAR:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 198);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Indirim Hesaplama";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chcKampanyaInd;
        private CheckBox chcNakitInd;
        private GroupBox groupBox2;
        private Button btnHesapla;
        private TextBox txtTutar;
        private Label label1;
    }
}