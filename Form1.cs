using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //變數宣告區
        public delegate double Operater();
        public double op1 = 0, op2 = 0;
        public string display_top = "", display_bottom = "";
        public bool fg_point = false;
        Operater OP = null;

        public Calculator()
        {
            InitializeComponent();
            Refresh();
        }

        public void DisplayRefresh()
        {
            tb_dispay_top.Text = display_top;
            tb_dispay_bottom.Text = display_bottom;
        }

        public double plus()
        {
            return op1 += op2;
        }

        public double minus()
        {
            return op1 -= op2;
        }


        public double multiplt()
        {
            return op1 *= op2;
        }


        public double divide()
        {
            return op1 /= op2;
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (fg_point == false && display_bottom != "")
            {
                fg_point = true;
                display_bottom = display_bottom + ".";
                DisplayRefresh();
            }
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            Button btnhit = (Button)sender;
            display_bottom += btnhit.Text;
            DisplayRefresh();
        }


        private void btn_0_Click(object sender, EventArgs e)
        {
            if (fg_point == false && (display_bottom == "0" || display_bottom == "-0"))
                return;
            display_bottom += "0";
            DisplayRefresh();
        }


        private void btn_AC_Click(object sender, EventArgs e)
        {
            op1 = 0;
            op2 = 0;
            display_top = "";
            display_bottom = "";
            fg_point = false;
            OP = null;
            DisplayRefresh();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            display_bottom.Remove(display_bottom.Length-2);
            DisplayRefresh();
        }
    }
}
