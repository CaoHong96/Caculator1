using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmMain : Form
    {
        bool isTypingNumber = false;
        enum PhepToan { Cong, Tru, Nhan, Chia };
        PhepToan pheptoan;
        double nho = 0.0;



        public FrmMain()
        {
            InitializeComponent();
        }

        private void TinhKetQua()
        {
            double ketqua = 0.0;
            switch (pheptoan)
            {
                case PhepToan.Cong:
                    ketqua = nho + double.Parse(lblDisplay.Text);
                    break;
                case PhepToan.Tru:
                    ketqua = nho - double.Parse(lblDisplay.Text);
                    break;
                case PhepToan.Nhan:
                    ketqua = nho * double.Parse(lblDisplay.Text);
                    break;
                case PhepToan.Chia:
                    ketqua = nho / double.Parse(lblDisplay.Text);
                    break;
            }
            lblDisplay.Text = ketqua.ToString();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            isTypingNumber = false;
            TinhKetQua();
        }

        private void NhapSo(object sender, EventArgs e)
        {
            NhapSo(((Button)sender).Text);
        }

        private void NhapSo(string so)
        {
            if (isTypingNumber)
                lblDisplay.Text = lblDisplay.Text + so;
            else
            {
                lblDisplay.Text = so;
                isTypingNumber = true;
            }
        }

        private void NhapPhepToan(object sender, EventArgs e)
        {
            isTypingNumber = false;
            switch (((Button)sender).Text)
            {
                case "+":
                    pheptoan = PhepToan.Cong; break;
                case "-":
                    pheptoan = PhepToan.Tru; break;
                case "*":
                    pheptoan = PhepToan.Nhan; break;
                case "/":
                    pheptoan = PhepToan.Chia; break;
            }
            TinhKetQua();
            nho = double.Parse(lblDisplay.Text);
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    NhapSo("" + e.KeyChar);
                    break;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.ToString)
            //{
            //    case "0":
            //    case "1":
            //    case "2":
            //    case "3":
            //    case "4":
            //        NhapSo("" + e.KeyChar);
            //        break;
            //}
        }

    }
}
