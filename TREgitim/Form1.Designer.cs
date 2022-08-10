namespace TREgitim
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Markacmb = new System.Windows.Forms.ComboBox();
            this.Modelcmb = new System.Windows.Forms.ComboBox();
            this.Kasacmb = new System.Windows.Forms.ComboBox();
            this.kapisayisi = new System.Windows.Forms.TextBox();
            this.penceresayisi = new System.Windows.Forms.TextBox();
            this.Sipariş = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yaş Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doğum Yılınız :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1068, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sipariş Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Markası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modeli:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kasası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kapı Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pencere Sayısı:";
            // 
            // Markacmb
            // 
            this.Markacmb.FormattingEnabled = true;
            this.Markacmb.Items.AddRange(new object[] {
            "Seçiniz",
            "BMW",
            "Mercedes",
            "Porsche"});
            this.Markacmb.Location = new System.Drawing.Point(846, 21);
            this.Markacmb.Name = "Markacmb";
            this.Markacmb.Size = new System.Drawing.Size(188, 28);
            this.Markacmb.TabIndex = 9;
            this.Markacmb.SelectedIndexChanged += new System.EventHandler(this.Markacmb_SelectedIndexChanged);
            // 
            // Modelcmb
            // 
            this.Modelcmb.FormattingEnabled = true;
            this.Modelcmb.Items.AddRange(new object[] {
            "Seçiniz",
            "Model1",
            "Model2"});
            this.Modelcmb.Location = new System.Drawing.Point(847, 55);
            this.Modelcmb.Name = "Modelcmb";
            this.Modelcmb.Size = new System.Drawing.Size(187, 28);
            this.Modelcmb.TabIndex = 10;
            this.Modelcmb.SelectedIndexChanged += new System.EventHandler(this.Modelcmb_SelectedIndexChanged);
            // 
            // Kasacmb
            // 
            this.Kasacmb.FormattingEnabled = true;
            this.Kasacmb.Items.AddRange(new object[] {
            "Seçiniz",
            "SW",
            "Sedam",
            "HB"});
            this.Kasacmb.Location = new System.Drawing.Point(849, 89);
            this.Kasacmb.Name = "Kasacmb";
            this.Kasacmb.Size = new System.Drawing.Size(185, 28);
            this.Kasacmb.TabIndex = 11;
            this.Kasacmb.SelectedIndexChanged += new System.EventHandler(this.Kasacmb_SelectedIndexChanged);
            // 
            // kapisayisi
            // 
            this.kapisayisi.Location = new System.Drawing.Point(849, 123);
            this.kapisayisi.Name = "kapisayisi";
            this.kapisayisi.Size = new System.Drawing.Size(186, 27);
            this.kapisayisi.TabIndex = 12;
            // 
            // penceresayisi
            // 
            this.penceresayisi.Location = new System.Drawing.Point(849, 156);
            this.penceresayisi.Name = "penceresayisi";
            this.penceresayisi.Size = new System.Drawing.Size(186, 27);
            this.penceresayisi.TabIndex = 13;
            // 
            // Sipariş
            // 
            this.Sipariş.AutoSize = true;
            this.Sipariş.Location = new System.Drawing.Point(187, 515);
            this.Sipariş.Name = "Sipariş";
            this.Sipariş.Size = new System.Drawing.Size(50, 20);
            this.Sipariş.TabIndex = 14;
            this.Sipariş.Text = "label7";
            this.Sipariş.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(787, 217);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 679);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sipariş);
            this.Controls.Add(this.penceresayisi);
            this.Controls.Add(this.kapisayisi);
            this.Controls.Add(this.Kasacmb);
            this.Controls.Add(this.Modelcmb);
            this.Controls.Add(this.Markacmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox Markacmb;
        private ComboBox Modelcmb;
        private ComboBox Kasacmb;
        private TextBox kapisayisi;
        private TextBox penceresayisi;
        private Label Sipariş;
        private DataGridView dataGridView1;
    }
}