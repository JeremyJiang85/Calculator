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
        public delegate double Operater(double op1, double op2);
        public string display_top = "", display_bottom = "", display_operator = "";
        public bool fg_point = false;
        Operater OP = null;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            DisplayRefresh();
        }

        public void DisplayRefresh()
        {
            lbl_display_top.Text = display_top;
            lbl_display_bottom.Text = display_bottom;
            lbl_display_operator.Text = display_operator;
        }

        public double plus(double op1, double op2)
        {
            return op1 += op2;
        }

        public double minus(double op1, double op2)
        {
            return op1 -= op2;
        }


        public double multiply(double op1, double op2)
        {
            return op1 *= op2;
        }


        public double divide(double op1, double op2)
        {
            if (op2 == 0)
            {
                MessageBox.Show("除數不可為0");
                return op1;
            }
            return op1 /= op2;
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (fg_point == false && (!string.IsNullOrEmpty(display_bottom)))
            {
                fg_point = true;
                display_bottom = display_bottom.Insert(display_bottom.Length, ".");
                DisplayRefresh();
            }
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            if (display_bottom == "0")
                display_bottom = display_bottom.Remove(display_bottom.Length - 1);
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
            display_top = "";
            display_bottom = "";
            display_operator = "";
            fg_point = false;
            OP = null;
            DisplayRefresh();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(display_bottom))
                return;
            if (display_bottom.EndsWith("."))
                fg_point = false;
            display_bottom = display_bottom.Remove(display_bottom.Length - 1);
            DisplayRefresh();
        }

        private void btn_changeSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(display_bottom))
                return;
            if (display_bottom.StartsWith("-"))
            {
                display_bottom = display_bottom.Remove(0, 1);
            }
            else
            {
                display_bottom = display_bottom.Insert(0, "-"); ;
            }
            DisplayRefresh();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (OP == null || string.IsNullOrEmpty(display_bottom) || string.IsNullOrEmpty(display_top))
                return;
            display_top = Convert.ToString(OP(Convert.ToDouble(display_top), Convert.ToDouble(display_bottom)));
            display_bottom = "";
            display_operator = "";
            fg_point = false;
            OP = null;
            DisplayRefresh();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            Button btnhit = (Button)sender;
            if (string.IsNullOrEmpty(display_top))
            {
                display_top = display_bottom;
                display_bottom = "";
                fg_point = false;
            }
            else if (string.IsNullOrEmpty(display_bottom)) { }
            else if (OP != null)
            {
                display_top = Convert.ToString(OP(Convert.ToDouble(display_top), Convert.ToDouble(display_bottom)));
                display_bottom = "";
                fg_point = false;
            }
            display_operator = btnhit.Text;
            switch (btnhit.Text)
            {
                case "+":
                    OP = plus;
                    break;
                case "-":
                    OP = minus;
                    break;
                case "*":
                    OP = multiply;
                    break;
                case "/":
                    OP = divide;
                    break;
            }
            DisplayRefresh();
        }
    }
}
