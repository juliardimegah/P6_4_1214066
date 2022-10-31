using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_1214066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, "TextBox nama tidak boleh kosong");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else
            {
                if ((txtNama.Text).All(Char.IsLetter) && (txtNama.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "Betul!");
                }
                else if ((txtNama.Text).All(Char.IsLower))
                {
                    epWarning.SetError(txtNama, "Inputan harus berbentuk huruf kapital!");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "");
                }
                else
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "Inputan hanya boleh huruf!");
                    epCorrect.SetError(txtNama, "");
                }
            }
        }

        private void tutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelpon_Leave(object sender, EventArgs e)
        {
            if (txtTelpon.Text == "")
            {
                epWarning.SetError(txtTelpon, "Textbox angka tidak boleh kosong!");
                epWrong.SetError(txtTelpon, "");
                epCorrect.SetError(txtTelpon, "");
            }

            else if ((txtTelpon.Text).All(Char.IsNumber))
            {
                if (txtTelpon.TextLength >= 11 || txtTelpon.TextLength == 12)
                {
                    epWarning.SetError(txtTelpon, "");
                    epWrong.SetError(txtTelpon, "");
                    epCorrect.SetError(txtTelpon, "Betul!");
                }
                 else if (txtTelpon.TextLength < 11 || txtTelpon.TextLength > 12)
                {
                    epWarning.SetError(txtTelpon, "");
                    epWrong.SetError(txtTelpon, "Jumlah karakter 11-12 digit");
                    epCorrect.SetError(txtTelpon, "");
                }
            }

            else
            {
                epWarning.SetError(txtTelpon, "");
                epWrong.SetError(txtTelpon, "Inputan hanya boleh angka!");
                epCorrect.SetError(txtTelpon, "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Text box email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            int[] arraynumber = new int[10];
            arraynumber[0] = int.Parse(txtAngka1.Text);
            arraynumber[1] = int.Parse(txtAngka2.Text);

            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "TextBox angka 2 tidak boleh kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    if (arraynumber[0] > arraynumber[1])
                    {
                        epInfo.SetError(txtAngka1, "Angka 1 lebih besar dari angka 2!");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka1, "");
                        epInfo.SetError(txtAngka2, "Angka 1 lebih besar dari angka 2!");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                    }

                    else if (arraynumber[0] < arraynumber[1])
                    {
                        epInfo.SetError(txtAngka1, "Angka 2 lebih besar dari angka 1!");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka1, "");
                        epInfo.SetError(txtAngka2, "Angka 2 lebih besar dari angka 1!");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                    }

                    else if (arraynumber[0] == arraynumber[1])
                    {
                        epInfo.SetError(txtAngka1, "Angka 1 sama dengan angka 2!");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka1, "");
                        epInfo.SetError(txtAngka2, "Angka 1 sama dengan angka 2!");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                    }

                    else
                    {
                        epWarning.SetError(txtAngka1, "");
                        epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
                        epCorrect.SetError(txtAngka1, "");
                    }
                }
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            int[] arraynumber = new int[10];
            arraynumber[0] = int.Parse(txtAngka1.Text);
            arraynumber[1] = int.Parse(txtAngka2.Text);

            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka2, "TextBox angka 1 tidak boleh kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    if (arraynumber[0] > arraynumber[1])
                    {
                        epInfo.SetError(txtAngka1, "Angka 1 lebih besar dari angka 2!");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka1, "");
                        epInfo.SetError(txtAngka2, "Angka 1 lebih besar dari angka 2!");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                    }

                    else if (arraynumber[0] < arraynumber[1])
                    {
                        epInfo.SetError(txtAngka1, "Angka 2 lebih besar dari angka 1!");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka1, "");
                        epInfo.SetError(txtAngka2, "Angka 2 lebih besar dari angka 1!");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                    }

                    else if (arraynumber[0] == arraynumber[1])
                    {
                        epInfo.SetError(txtAngka1, "Angka 1 sama dengan angka 2!");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka1, "");
                        epInfo.SetError(txtAngka2, "Angka 1 sama dengan angka 2!");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                        epWarning.SetError(txtAngka2, "");
                    }

                    else
                    {
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                        epCorrect.SetError(txtAngka2, "");
                    }
                }
            }
        }

        private void txtNickname_Leave(object sender, EventArgs e)
        {
            if (txtNickname.Text == "")
            {
                epWarning.SetError(txtNickname, "TextBox nama panggilan tidak boleh kosong");
                epWrong.SetError(txtNickname, "");
                epCorrect.SetError(txtNickname, "");
            }
            else
            {
                if ((txtNickname.Text).All(Char.IsLetter) && (txtNickname.Text).All(Char.IsLower))
                {
                    epWarning.SetError(txtNickname, "");
                    epWrong.SetError(txtNickname, "");
                    epCorrect.SetError(txtNickname, "Betul!");
                }
                else if ((txtNickname.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(txtNickname, "Inputan harus berbentuk huruf kecil!");
                    epWrong.SetError(txtNickname, "");
                    epCorrect.SetError(txtNickname, "");
                }
                else
                {
                    epWarning.SetError(txtNickname, "");
                    epWrong.SetError(txtNickname, "Inputan hanya boleh huruf!");
                    epCorrect.SetError(txtNickname, "");
                }
            }
        }

        private void buttonTampilkan_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nNo. Telp: " + txtTelpon.Text +
                    "\nEmail: " + txtEmail.Text +
                    "\nNama Panggilan: " + txtNickname.Text+
                    "\nAngka 1: " + txtAngka1.Text+
                    "\nAngka 2: " + txtAngka2.Text,
                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
