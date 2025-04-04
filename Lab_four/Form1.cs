using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_four
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
            listBox1.SetSelected(1, true);
            listBox1.SetSelected(2, true);

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            {
                
                int a, b, c;
                // пытаем преобразовать строку из textBox1.Text в целое число
                bool rez1 = int.TryParse(textBox1.Text, out a);
                if (rez1 == false) // если возникла ли ошибка преобразования
                { // то выводим сообщение и заканчиваем работу метода
                    MessageBox.Show(" Неверный формат числа " + textBox1.Text + "!");
                    return; // заканчиваем работу метода
                }
                // пытаем преобразовать строку из textBox2.Text в целое число
                bool rez2 = int.TryParse(textBox2.Text, out b);
                if (rez2 == false) // если возникла ли ошибка преобразования
                { // то выводим сообщение и заканчиваем работу метода
                    MessageBox.Show(" Неверный формат числа " + textBox2.Text + "!");
                    return; // заканчиваем работу метода
                }
                c = a * b;
                string cStr = c.ToString();
                listBox1.Text = cStr;
                MessageBox.Show(cStr);
                return; // заканчиваем работу метода
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
