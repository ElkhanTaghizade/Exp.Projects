namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n0_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "0";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "1";
            }
            else
            {
                Box.Text = Box.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "2";
            }
            else
            {
                Box.Text = Box.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "3";
            }
            else
            {
                Box.Text = Box.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "4";
            }
            else
            {
                Box.Text = Box.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "5";
            }
            else
            {
                Box.Text = Box.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "6";
            }
            else
            {
                Box.Text = Box.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "7";
            }
            else
            {
                Box.Text = Box.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "8";
            }
            else
            {
                Box.Text = Box.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0" && Box.Text != null)
            {
                Box.Text = "9";
            }
            else
            {
                Box.Text = Box.Text + "9";
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            Box.Text += ".";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Box.Text);
            Box.Text = "0";
            Operation = "+";
        }

        private void dif_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Box.Text);
            Box.Text = "0";
            Operation = "-";
        }

        private void multipy_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Box.Text);
            Box.Text = "0";
            Operation = "*";
        }

        private void devide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Box.Text);
            Box.Text = "0";
            Operation = "/";
        }

        private void clean_Click(object sender, EventArgs e)
        {
            Box.Text = "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(Box.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Box.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Box.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Box.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    Box.Text = "0-a bölmə yoxdur.";
                 //  MessageBox.Show("0-a bölmə yoxdur.");

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    Box.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}