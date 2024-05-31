using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koch_OOP_KT3
{
    public partial class NK_Form1 : Form
    {
        Random rnd = new Random();
        int Points1, Points2, FpD1, FpD2, SpD1, SpD2;

        string result;
         
        public NK_Form1()
        {
            InitializeComponent();
        }

        private void NK_btn_StartNew_Click(object sender, EventArgs e)
        {
            NK_lbl_Points1.Text = "";
            NK_lbl_Points2.Text = "";
            NK_pic_FpD1.Visible = false;
            NK_pic_FpD2.Visible = false;
            NK_pic_SpD1.Visible = false;
            NK_pic_SpD2.Visible = false;
            NK_lbl_Result.Text = "";

            NK_btn_StartNew.Enabled = false;
            NK_btn_PlayFirst.Enabled = true;
        }
        private void NK_btn_PlayFirst_Click(object sender, EventArgs e)
        {
            FpD1 = rnd.Next(1, 7);
            FpD2 = rnd.Next(1, 7);

            NK_pic_FpD1.Visible = true;
            NK_pic_FpD2.Visible = true;

            NK_pic_FpD1.Image = NK_imgList.Images[FpD1 - 1];
            NK_pic_FpD2.Image = NK_imgList.Images[FpD2 - 1];

            Points1 = FpD1 + FpD2;
            NK_lbl_Points1.Text = Points1.ToString();

            NK_btn_PlayFirst.Enabled = false;
            NK_btn_PlaySecond.Enabled = true;
        }
        private void NK_btn_PlaySecond_Click(object sender, EventArgs e)
        {
            SpD1 = rnd.Next(1, 7); 
            SpD2 = rnd.Next(1, 7);

            NK_pic_SpD1.Visible = true;
            NK_pic_SpD2.Visible = true;

            NK_pic_SpD1.Image = NK_imgList.Images[SpD1 - 1];
            NK_pic_SpD2.Image = NK_imgList.Images[SpD2 - 1];

            Points2 = SpD1 + SpD2;  
            NK_lbl_Points2.Text = Points2.ToString();
            if (Points1 > Points2)
            {
                NK_lbl_Result.Text = "First Player Won";
            }
            else if (Points1 < Points2)
            {
                NK_lbl_Result.Text = "Second Player Won";
            }
            else { NK_lbl_Result.Text = "Draw"; }

            NK_btn_PlaySecond.Enabled = false;
            NK_btn_StartNew.Enabled = true;
        }
    }
}
