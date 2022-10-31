namespace P6_4_1214066
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nama = new System.Windows.Forms.Label();
            this.notelp = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.angka1 = new System.Windows.Forms.Label();
            this.angka2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtTelpon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.tutup = new System.Windows.Forms.Button();
            this.epInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTampilkan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(31, 12);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(138, 13);
            this.nama.TabIndex = 0;
            this.nama.Text = "Nama (dalam format kapital)";
            // 
            // notelp
            // 
            this.notelp.AutoSize = true;
            this.notelp.Location = new System.Drawing.Point(31, 41);
            this.notelp.Name = "notelp";
            this.notelp.Size = new System.Drawing.Size(60, 13);
            this.notelp.TabIndex = 1;
            this.notelp.Text = "No. Telpon";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(31, 72);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 2;
            this.email.Text = "Email ";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(31, 130);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(149, 13);
            this.Info.TabIndex = 4;
            this.Info.Text = "Masukkan Nilai Perbandingan";
            // 
            // angka1
            // 
            this.angka1.AutoSize = true;
            this.angka1.Location = new System.Drawing.Point(31, 159);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(47, 13);
            this.angka1.TabIndex = 5;
            this.angka1.Text = "Angka 1";
            // 
            // angka2
            // 
            this.angka2.AutoSize = true;
            this.angka2.Location = new System.Drawing.Point(31, 190);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(47, 13);
            this.angka2.TabIndex = 6;
            this.angka2.Text = "Angka 2";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(270, 9);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(185, 20);
            this.txtNama.TabIndex = 8;
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // txtTelpon
            // 
            this.txtTelpon.Location = new System.Drawing.Point(270, 38);
            this.txtTelpon.Name = "txtTelpon";
            this.txtTelpon.Size = new System.Drawing.Size(185, 20);
            this.txtTelpon.TabIndex = 9;
            this.txtTelpon.Leave += new System.EventHandler(this.txtTelpon_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(270, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(270, 153);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(185, 20);
            this.txtAngka1.TabIndex = 13;
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(270, 187);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(185, 20);
            this.txtAngka2.TabIndex = 14;
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // tutup
            // 
            this.tutup.Location = new System.Drawing.Point(164, 230);
            this.tutup.Name = "tutup";
            this.tutup.Size = new System.Drawing.Size(75, 23);
            this.tutup.TabIndex = 16;
            this.tutup.Text = "&Tutup";
            this.tutup.UseVisualStyleBackColor = true;
            this.tutup.Click += new System.EventHandler(this.tutup_Click);
            // 
            // epInfo
            // 
            this.epInfo.ContainerControl = this;
            this.epInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("epInfo.Icon")));
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(270, 95);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(185, 20);
            this.txtNickname.TabIndex = 18;
            this.txtNickname.Leave += new System.EventHandler(this.txtNickname_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nama Panggilan (dalam format lowercase)";
            // 
            // buttonTampilkan
            // 
            this.buttonTampilkan.Location = new System.Drawing.Point(245, 230);
            this.buttonTampilkan.Name = "buttonTampilkan";
            this.buttonTampilkan.Size = new System.Drawing.Size(75, 23);
            this.buttonTampilkan.TabIndex = 19;
            this.buttonTampilkan.Text = "T&ampilkan";
            this.buttonTampilkan.UseVisualStyleBackColor = true;
            this.buttonTampilkan.Click += new System.EventHandler(this.buttonTampilkan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonTampilkan);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tutup);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelpon);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.angka2);
            this.Controls.Add(this.angka1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.email);
            this.Controls.Add(this.notelp);
            this.Controls.Add(this.nama);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label notelp;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label angka1;
        private System.Windows.Forms.Label angka2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtTelpon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.Button tutup;
        private System.Windows.Forms.ErrorProvider epInfo;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTampilkan;
    }
}

