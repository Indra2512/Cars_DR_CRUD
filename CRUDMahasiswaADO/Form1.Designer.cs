namespace CRUDMahasiswaADO
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
            this.NIM = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.cmbJK = new System.Windows.Forms.ComboBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ClearForm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(94, 25);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(38, 20);
            this.NIM.TabIndex = 0;
            this.NIM.Text = "NIM";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(219, 25);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(212, 26);
            this.txtNIM.TabIndex = 1;
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(94, 74);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(51, 20);
            this.Nama.TabIndex = 2;
            this.Nama.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(219, 71);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(212, 26);
            this.txtNama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jenis Kelamin\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanggal Lahir";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(219, 201);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(254, 60);
            this.txtAlamat.TabIndex = 7;
            // 
            // cmbJK
            // 
            this.cmbJK.FormattingEnabled = true;
            this.cmbJK.Location = new System.Drawing.Point(219, 110);
            this.cmbJK.Name = "cmbJK";
            this.cmbJK.Size = new System.Drawing.Size(212, 28);
            this.cmbJK.TabIndex = 8;
            this.cmbJK.SelectedIndexChanged += new System.EventHandler(this.cmbJK_SelectedIndexChanged);
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(219, 154);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(212, 26);
            this.dtpTanggalLahir.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kode Prodi";
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(219, 271);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(212, 26);
            this.txtKodeProdi.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Membuka Koneksi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(566, 100);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(179, 33);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Menampilkan Data\r\n";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Menambahkan Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 32);
            this.button4.TabIndex = 15;
            this.button4.Text = "Mengubah Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ClearForm
            // 
            this.ClearForm.Location = new System.Drawing.Point(567, 257);
            this.ClearForm.Name = "ClearForm";
            this.ClearForm.Size = new System.Drawing.Size(178, 27);
            this.ClearForm.TabIndex = 16;
            this.ClearForm.Text = "Menghapus Data";
            this.ClearForm.UseVisualStyleBackColor = true;
            this.ClearForm.Click += new System.EventHandler(this.ClearForm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(852, 223);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearForm);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.cmbJK);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.NIM);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.ComboBox cmbJK;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ClearForm;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

