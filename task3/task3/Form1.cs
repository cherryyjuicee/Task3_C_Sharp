using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Введите числа!");
            }

            else
            {
                Decimal obj = new Decimal(new Number(int.Parse(textBox1.Text)), new Number(int.Parse(textBox2.Text)));
                Decimal obj2 = new Decimal(new Number(int.Parse(textBox3.Text)), new Number(int.Parse(textBox4.Text)));

                textBox5.Text = obj.Plus(obj2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Введите числа!");
            }
            else
            {
                Decimal obj = new Decimal(new Number(int.Parse(textBox1.Text)), new Number(int.Parse(textBox2.Text)));
                Decimal obj2 = new Decimal(new Number(int.Parse(textBox3.Text)), new Number(int.Parse(textBox4.Text)));

                textBox5.Text = obj.Minus(obj2).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Введите числа!");
            }
            else
            {
                Decimal obj = new Decimal(new Number(int.Parse(textBox1.Text)), new Number(int.Parse(textBox2.Text)));
                Decimal obj2 = new Decimal(new Number(int.Parse(textBox3.Text)), new Number(int.Parse(textBox4.Text)));

                textBox5.Text = obj.Multiply(obj2).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Введите числа!");
            }
            else
            { 
            Decimal obj = new Decimal(new Number(int.Parse(textBox1.Text)), new Number(int.Parse(textBox2.Text)));
            Decimal obj2 = new Decimal(new Number(int.Parse(textBox3.Text)), new Number(int.Parse(textBox4.Text)));

            textBox5.Text = obj.Divide(obj2).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }

    class Number
    {
        public int value;

        public Number(int value)
        {
            this.value = value;
        }
    }

    class Decimal
    {
        public Number num1;
        public Number num2;

        public Decimal(Number num1, Number num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public override string ToString()
        {
            int m = 1;

            if (this.num1.value < 0 || this.num2.value < 0)
            {
                if (this.num1.value < 0 && this.num2.value > 0)
                { 
                    this.num1.value = this.num1.value * -1; 
                    m = 0;
                }
                else if (this.num2.value < 0 && this.num1.value > 0)
                {
                    this.num2.value = this.num2.value * -1;
                    m = 0;
                }
                else{
                    this.num1.value = this.num1.value * -1;
                    this.num2.value = this.num2.value * -1;
                }
            }


            int o = 0;

            if (this.num1.value > this.num2.value)
            {
                int i = this.num2.value;

                while (i > 0)
                {
                    if (this.num1.value % i == 0 && this.num2.value % i == 0)
                    {
                        this.num1 = new Number(this.num1.value / i);
                        this.num2 = new Number(this.num2.value / i);
                        break;
                    }
                    else
                    {
                        i--;
                    }
                }

                while (this.num1.value > this.num2.value)
                {
                    this.num1.value = this.num1.value - this.num2.value;
                    o++;
                }

            }
            
            else
            {
                int i = this.num1.value;

                while (i > 0)
                {
                    if (this.num1.value % i == 0 && this.num2.value % i == 0)
                    {
                        this.num1 = new Number(this.num1.value / i);
                        this.num2 = new Number(this.num2.value / i);
                        break;
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            if (this.num1.value == 0)
            {
                return "0";
            }
            else if (this.num1.value == this.num2.value && o == 0 && m == 0)
            {
                return "-1";
            }
            else if (this.num1.value == this.num2.value && o == 0 && m != 0)
            {
                return "1";
            }
            else if (this.num1.value == this.num2.value && o != 0 && m != 0)
            {
                o = o + 1;
                return o + "";
            }
            else if (this.num1.value == this.num2.value && o != 0 && m == 0)
            {
                m = (o + 1)*-1;
                return m + "";
            }
            else if (this.num2.value == 1 && o != 0 && m != 0)
            {
                return o + "" + this.num1.value +"";
            }
            else if (this.num2.value == 1 && o != 0 && m == 0)
            {
                return "-" + o + "" + this.num1.value + "";
            }
            else if (this.num2.value == 1 && o == 0 && m != 0)
            {
                o = o + this.num1.value;
                return o+"";
            }
            else if (this.num2.value == 1 && o == 0 && m == 0)
            {
                o = o + this.num1.value;
                return "-" + o + "";
            }
            else if (o == 0 && m != 0)
            {
                return this.num1.value + "/" + this.num2.value ;
            }
            else if (o == 0 && m == 0)
            {
                return "-" + this.num1.value + "/" + this.num2.value;
            }
            else if (o != 0 && m != 0)
            {
                return o + " " + this.num1.value + "/" + this.num2.value;
            }
            else if (o != 0 && m == 0)
            {
                return "-" + o + " " + this.num1.value + "/" + this.num2.value;
            }
            else
            {
                return "Ошибка";
            }
        }

        public Decimal Multiply(Decimal a)
        {
            Number d = new Number(this.num1.value * a.num1.value);
            Number e = new Number(this.num2.value * a.num2.value);

            return new Decimal(d, e);
        }
        public Decimal Divide(Decimal a)
        {
            Number d = new Number(this.num1.value * a.num2.value);
            Number e = new Number(this.num2.value * a.num1.value);

            return new Decimal(d, e);
        }
        public Decimal Plus(Decimal a)
        {
            Number d = new Number(this.num1.value * a.num2.value + this.num2.value * a.num1.value);
            Number e = new Number(this.num2.value * a.num2.value);
            
            return new Decimal(d, e);
        }
        public Decimal Minus(Decimal a)
        {
            Number d = new Number(this.num1.value * a.num2.value - this.num2.value * a.num1.value);
            Number e = new Number(this.num2.value * a.num2.value);

            return new Decimal(d, e);
        }

    }
}

