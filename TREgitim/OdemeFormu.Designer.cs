namespace TREgitim
{
    partial class OdemeFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.OdemeTipicmb = new System.Windows.Forms.ComboBox();
            this.tutartxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OdemeYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Tipi";
            // 
            // OdemeTipicmb
            // 
            this.OdemeTipicmb.FormattingEnabled = true;
            this.OdemeTipicmb.Items.AddRange(new object[] {
            "Seçiniz",
            "KrediKarti",
            "MailOrder",
            "Cash"});
            this.OdemeTipicmb.Location = new System.Drawing.Point(409, 124);
            this.OdemeTipicmb.Name = "OdemeTipicmb";
            this.OdemeTipicmb.Size = new System.Drawing.Size(151, 28);
            this.OdemeTipicmb.TabIndex = 1;
            // 
            // tutartxtbox
            // 
            this.tutartxtbox.Location = new System.Drawing.Point(413, 191);
            this.tutartxtbox.Name = "tutartxtbox";
            this.tutartxtbox.Size = new System.Drawing.Size(125, 27);
            this.tutartxtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tutar";
            // 
            // OdemeYap
            // 
            this.OdemeYap.Location = new System.Drawing.Point(413, 305);
            this.OdemeYap.Name = "OdemeYap";
            this.OdemeYap.Size = new System.Drawing.Size(94, 29);
            this.OdemeYap.TabIndex = 4;
            this.OdemeYap.Text = "Ödeme Yap";
            this.OdemeYap.UseVisualStyleBackColor = true;
            this.OdemeYap.Click += new System.EventHandler(this.OdemeYap_Click);
            // 
            // OdemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OdemeYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tutartxtbox);
            this.Controls.Add(this.OdemeTipicmb);
            this.Controls.Add(this.label1);
            this.Name = "OdemeFormu";
            this.Text = "OdemeFormu";
            this.Load += new System.EventHandler(this.OdemeFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox OdemeTipicmb;
        private TextBox tutartxtbox;
        private Label label2;
        private Button OdemeYap;
    }
}