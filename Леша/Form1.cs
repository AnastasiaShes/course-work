﻿using System;
using System.Windows.Forms;
using System.IO;

namespace Леша
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
            label5.Text = "";
        }
        //Кнопка Решить
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text); //Присваиваем перменной а значение из ТекстБокса
            if (radioButton1.Checked)
            {
                //Решение синуса двойного угла
                Double sin, cos,a1;
                sin = Math.Sin(a * 3.14 / 180);
                cos = Math.Cos(a * 3.14 / 180);
                a1 = 2 * Math.Sin(a * 3.14 / 180) * Math.Cos(a * 3.14 / 180);
                a1 = Math.Round(a1, 2);
                sin = Math.Round(sin, 2);
                cos = Math.Round(cos, 2);
                label3.Text = "sin(2a) = 2 * " + sin.ToString() + " * " + cos.ToString();
                label5.Text = a1.ToString();
                //Записать результат в историю
                File.AppendAllText("C:\\Users\\ПК\\Desktop\\History.txt", "Синуса двойного угла при x = " + a + " будет равен " + a1 + Environment.NewLine);
            }
            if (radioButton2.Checked)
            {
                //Решение косинуса двойного угла
                Double sin, cos, a1;           
                sin = Math.Pow((Math.Sin(a * 3.14 / 180)), 2);
                cos = Math.Pow((Math.Cos(a * 3.14 / 180)), 2);
                a1 = Math.Pow((Math.Cos(a * 3.14 / 180)), 2) - Math.Pow((Math.Sin(a * 3.14 / 180)), 2);
                a1 = Math.Round(a1, 2);
                sin = Math.Round(sin, 2);
                cos = Math.Round(cos, 2);
                label3.Text = "cos(2a) = " + cos.ToString() + " - " + sin.ToString();
                label5.Text = a1.ToString();
                //Записать результат в историю
                File.AppendAllText("C:\\Users\\ПК\\Desktop\\History.txt", "Косинус двойного угла при x = " + a + " будет равен " + a1 + Environment.NewLine);
            }
            if (radioButton3.Checked)
            {
                //Решение тангенса двойного угла
                Double tg, tg2, a1;
                tg = Math.Tan(a * 3.14 / 180);
                tg2 = Math.Pow((Math.Tan(a * 3.14 / 180)), 2);
                tg = Math.Round(tg, 2);
                tg2 = Math.Round(tg2, 2);
                if ((1 - tg2)==0)
                {
                    label3.Text = "Деление на ноль";
                    label5.Text = "Ошибка";
                    //Записать результат в историю
                    File.AppendAllText("C:\\Users\\ПК\\Desktop\\History.txt", "Тангенс двойного угла при x = " + a + " приведет к ошибке (деление на 0)" + Environment.NewLine);
                }
                else
                {
                    a1 = (2 * tg) / (1 - tg2);
                    a1 = Math.Round(a1, 2);
                    label3.Text = "tg(2a) = (2 * " + tg.ToString() + ")" + " / " + "(1 - " + tg2.ToString() + ")";
                    label5.Text = a1.ToString();
                    //Записать результат в историю
                    File.AppendAllText("C:\\Users\\ПК\\Desktop\\History.txt", "Тангенс двойного угла при x = " + a + " будет равен " + a1 + Environment.NewLine);
                }
            }
            if (radioButton4.Checked)
            {
                //Решение синуса тройного угла
                Double sin, sin3, a1;
                sin = Math.Sin(a * 3.14 / 180);
                sin3 = Math.Pow(Math.Sin(a * 3.14 / 180), 3);
                a1 = 3 * Math.Sin(a * 3.14 / 180) - 4 * Math.Pow(Math.Sin(a * 3.14 / 180), 3);
                a1 = Math.Round(a1, 2);
                sin = Math.Round(sin, 2);
                sin3 = Math.Round(sin3, 2);
                label3.Text = "sin(3a) = 3 * " + sin.ToString() + " - 4 * " + sin3.ToString();
                label5.Text = a1.ToString();
                //Записать результат в историю
                File.AppendAllText("C:\\Users\\ПК\\Desktop\\History.txt", "Синуса тройного угла при x = " + a + " будет равен " + a1 + Environment.NewLine);
            }
            if (radioButton5.Checked)
            {
                //Решение косинуса тройного угла
                Double cos, cos3, a1;
                a = a * 3.14 / 180; 
                cos = Math.Cos(a);
                cos3 = Math.Pow(Math.Cos(a), 3);
                a1 = 4 * cos3 - 3 * cos;
                a1 = Math.Round(a1, 2);
                cos = Math.Round(cos, 2);
                cos3 = Math.Round(cos3, 2);
                label3.Text = "cos(3a) = 4*(" + cos3.ToString() + ")" + " - 3*(" + cos.ToString() + ")";
                label5.Text = a1.ToString();
                //Записать результат в историю
                File.AppendAllText("C:\\Users\\ПК\\Desktop\\History.txt", "Косинус тройного угла при x = " + a + " будет равен " + a1 + Environment.NewLine);
            }
            if (radioButton6.Checked)
            {
                //Решение тангенса тройного угла
                Double tg, tg2, tg3, a1;
                tg = Math.Tan(a * 3.14 / 180);
                tg2 = Math.Pow((Math.Tan(a * 3.14 / 180)), 2);
                tg3 = Math.Pow((Math.Tan(a * 3.14 / 180)), 3);
                tg = Math.Round(tg, 2);
                tg2 = Math.Round(tg2, 2);
                tg3 = Math.Round(tg3, 2);

                if ((1 - 3 * tg2) == 0)
                {
                    label3.Text = "Деление на ноль";
                    label5.Text = "ошибка";
                    //Записать результат в историю
                    File.AppendAllText("C:\\Users\\ПК\\Desktop\\History.txt", "Тангенс тройного угла при x = " + a + " Приведет к ошибке (деление на 0)" + Environment.NewLine);
                }
                else
                {
                    a1 = (3 * tg - tg3) / (1 - 3 * tg2);
                    a1 = Math.Round(a1, 2);
                    label3.Text = "tg(3a) = (3 * " + tg.ToString() + " - " + tg3.ToString() + ") / (1 - 3 * " + tg2.ToString() + ")";
                    label5.Text = a1.ToString();
                    //Записать результат в историю
                    File.AppendAllText("C:\\Users\\ПК\\Desktop\\History.txt", "Тангенс тройного угла при x = " + a + " будет равен " + a1 + Environment.NewLine);
                }
            }
        }
        //Кнопка очистить
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
            label5.Text = " ";
            textBox1.Text = "";
        }
        //Кнопка Истрория
        private void button3_Click(object sender, EventArgs e)
        {
            string history = File.ReadAllText("C:\\Users\\ПК\\Desktop\\History.txt");
            richTextBox1.Text = history;
        }
        //Кнопка Выход
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
