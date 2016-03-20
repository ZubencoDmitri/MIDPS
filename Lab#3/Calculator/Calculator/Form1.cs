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
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               textBox3.Text = "+";
               //label1.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text),
                  //  Convert.ToDouble(textBox2.Text)));
          }

          private void button2_Click_1(object sender, EventArgs e)
          {
               textBox3.Text = "-";
             //  label1.Text = Convert.ToString(substract(Convert.ToDouble(textBox1.Text),
                 //   Convert.ToDouble(textBox2.Text)));
          }

          private void button3_Click_1(object sender, EventArgs e)
          {
               textBox3.Text = "/";
             //  label1.Text = Convert.ToString(devide(Convert.ToDouble(textBox1.Text),
                  //  Convert.ToDouble(textBox2.Text)));
          }

          private void button4_Click(object sender, EventArgs e)
          {
               textBox3.Text = "*";
              // label1.Text = Convert.ToString(multiply(Convert.ToDouble(textBox1.Text),
                //    Convert.ToDouble(textBox2.Text)));
          }

          public static double sum(double a, double b)//Сумма
          {
               return a + b;
          }

          public static double devide(double a, double b)//Деление
          {
               return a / b;
          }

          public static double substract(double a, double b)//Вычитание
          {
               return a - b;
          }

          public static double multiply(double a, double b)//Умножение
          {
               return a * b;
          }

          public static double stepen(double a, double b)
          {
               
               double rez = 1;
               for (double i = 0; i < b; i = i + 1) rez = rez * a;
               return rez;
          }

          private void button5_Click(object sender, EventArgs e)
          {
               if (Convert.ToChar(textBox3.Text) == '+') label1.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text),
                      Convert.ToDouble(textBox2.Text)));
               else if (Convert.ToChar(textBox3.Text) == '-') label1.Text = Convert.ToString(substract(Convert.ToDouble(textBox1.Text),
                     Convert.ToDouble(textBox2.Text)));
               else if (Convert.ToChar(textBox3.Text) == '/') label1.Text = Convert.ToString(devide(Convert.ToDouble(textBox1.Text),
                     Convert.ToDouble(textBox2.Text)));
               else if (Convert.ToChar(textBox3.Text) == '*') label1.Text = Convert.ToString(multiply(Convert.ToDouble(textBox1.Text),
                     Convert.ToDouble(textBox2.Text)));
               else if (Convert.ToChar(textBox3.Text) == '^') label1.Text = Convert.ToString(stepen(Convert.ToDouble(textBox1.Text),
                    Convert.ToDouble(textBox2.Text)));
               else label1.Text = "Неверно введено действие";
          }

          private void button15_Click(object sender, EventArgs e)
          {
               if (Convert.ToChar(textBox3.Text) == '+' || Convert.ToChar(textBox3.Text) == '*'
                   || Convert.ToChar(textBox3.Text) == '-' || Convert.ToChar(textBox3.Text) == '/'
                    || Convert.ToChar(textBox3.Text) == '^')
                     textBox2.Text += (sender as Button).Text;
               else if (Convert.ToChar(textBox3.Text) == '?') textBox1.Text += (sender as Button).Text;
          }

          private void button19_Click(object sender, EventArgs e)
          {
               textBox1.Clear();
               textBox2.Clear();
               textBox3.Text="?";
               label1.Text="*Answer*";
          }

          private void button20_Click(object sender, EventArgs e)
          {
               textBox3.Text = "sqrt";
              double g=Math.Sqrt(Convert.ToDouble(textBox1.Text));
              label1.Text = Convert.ToString(g);
          }

          private void button21_Click(object sender, EventArgs e)
          {
               textBox3.Text = "^";
              
          }

          private void button17_Click(object sender, EventArgs e)
          {
               if (Convert.ToChar(textBox3.Text) == '+' || Convert.ToChar(textBox3.Text) == '*'
                  || Convert.ToChar(textBox3.Text) == '-' || Convert.ToChar(textBox3.Text) == '/'
                   || Convert.ToChar(textBox3.Text) == '^')
               {
                    if (textBox2.Text[0] == '-') textBox2.Text = textBox2.Text.Remove(0, 1);
                    else textBox2.Text = '-' + textBox2.Text;
               }
               else if (Convert.ToChar(textBox3.Text) == '?')
               {
                    if (textBox1.Text[0] == '-') textBox1.Text = textBox1.Text.Remove(0, 1);
                    else textBox1.Text = '-' + textBox1.Text;
               }
          }

          private void label5_Click(object sender, EventArgs e)
          {

          }





     }
}
