namespace HastaneRandevuSistemi
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
            lblBrans = new Label();
            lblDoktor = new Label();
            lblSaat = new Label();
            lblTarih = new Label();
            lblHastaSoyadi = new Label();
            lblHastaAdi = new Label();
            cmbBrans = new ComboBox();
            cmbDoktor = new ComboBox();
            txtHastaAdi = new TextBox();
            txtHastaSoyadi = new TextBox();
            cmbSaat = new ComboBox();
            dtpTarih = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblBrans.Location = new Point(41, 42);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(59, 25);
            lblBrans.TabIndex = 0;
            lblBrans.Text = "Branş";
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblDoktor.Location = new Point(41, 94);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(72, 25);
            lblDoktor.TabIndex = 1;
            lblDoktor.Text = "Doktor";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblSaat.Location = new Point(41, 201);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(49, 25);
            lblSaat.TabIndex = 3;
            lblSaat.Text = "Saat";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblTarih.Location = new Point(41, 149);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(53, 25);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih";
            // 
            // lblHastaSoyadi
            // 
            lblHastaSoyadi.AutoSize = true;
            lblHastaSoyadi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblHastaSoyadi.Location = new Point(41, 307);
            lblHastaSoyadi.Name = "lblHastaSoyadi";
            lblHastaSoyadi.Size = new Size(123, 25);
            lblHastaSoyadi.TabIndex = 5;
            lblHastaSoyadi.Text = "Hasta Soyadı";
            // 
            // lblHastaAdi
            // 
            lblHastaAdi.AutoSize = true;
            lblHastaAdi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblHastaAdi.Location = new Point(41, 255);
            lblHastaAdi.Name = "lblHastaAdi";
            lblHastaAdi.Size = new Size(95, 25);
            lblHastaAdi.TabIndex = 4;
            lblHastaAdi.Text = "Hasta Adı";
            // 
            // cmbBrans
            // 
            cmbBrans.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(200, 45);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(191, 28);
            cmbBrans.TabIndex = 6;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // cmbDoktor
            // 
            cmbDoktor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(200, 97);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(191, 28);
            cmbDoktor.TabIndex = 7;
            cmbDoktor.SelectedIndexChanged += cmbDoktor_SelectedIndexChanged;
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtHastaAdi.Location = new Point(200, 253);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(170, 27);
            txtHastaAdi.TabIndex = 8;
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtHastaSoyadi.Location = new Point(200, 305);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(170, 27);
            txtHastaSoyadi.TabIndex = 9;
            // 
            // cmbSaat
            // 
            cmbSaat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(200, 199);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(191, 28);
            cmbSaat.TabIndex = 10;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dtpTarih.Location = new Point(200, 147);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(270, 27);
            dtpTarih.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(131, 366);
            button1.Name = "button1";
            button1.Size = new Size(151, 39);
            button1.TabIndex = 12;
            button1.Text = "Randevu Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 449);
            Controls.Add(button1);
            Controls.Add(dtpTarih);
            Controls.Add(cmbSaat);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(txtHastaAdi);
            Controls.Add(cmbDoktor);
            Controls.Add(cmbBrans);
            Controls.Add(lblHastaSoyadi);
            Controls.Add(lblHastaAdi);
            Controls.Add(lblSaat);
            Controls.Add(lblTarih);
            Controls.Add(lblDoktor);
            Controls.Add(lblBrans);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrans;
        private Label lblDoktor;
        private Label lblSaat;
        private Label lblTarih;
        private Label lblHastaSoyadi;
        private Label lblHastaAdi;
        private ComboBox cmbBrans;
        private ComboBox cmbDoktor;
        private TextBox txtHastaAdi;
        private TextBox txtHastaSoyadi;
        private ComboBox cmbSaat;
        private DateTimePicker dtpTarih;
        private Button button1;
    }
}
