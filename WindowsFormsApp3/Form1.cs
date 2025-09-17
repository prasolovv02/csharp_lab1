using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Обработчик для Pattern
            if (radioButton1.Checked)
            {
                PerformPatternOperation();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Обработчик для Component
            if (radioButton3.Checked)
            {
                PerformComponentOperation();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Выполняем операцию в зависимости от выбранного radioButton
            if (radioButton1.Checked)
            {
                PerformPatternOperation();
            }
            else if (radioButton3.Checked)
            {
                PerformComponentOperation();
            }
        }

        private void PerformComponentOperation()
        {
            // Сумма для Component
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 + num2;
                // Находим label с текстом "(no library selected)" и меняем его
                UpdateResultLabel(result.ToString());
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения в оба поля.");
            }
        }

        private void PerformPatternOperation()
        {
            // Произведение для Pattern
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = num1 * num2;
                // Находим label с текстом "(no library selected)" и меняем его
                UpdateResultLabel(result.ToString());
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения в оба поля.");
            }
        }

        private void UpdateResultLabel(string resultText)
        {
            // Ищем все label на форме и находим тот, у которого текст "(no library selected)"
            foreach (Control control in this.Controls)
            {
                if (control is Label label && label.Text == "(no library selected)")
                {
                    label.Text = resultText;
                    return;
                }
            }

            // Если не нашли, ищем в дочерних контролах (в groupBox и т.д.)
            foreach (Control container in this.Controls)
            {
                if (container.HasChildren)
                {
                    foreach (Control control in container.Controls)
                    {
                        if (control is Label label && label.Text == "(no library selected)")
                        {
                            label.Text = resultText;
                            return;
                        }
                    }
                }
            }
        }

        // Убедитесь, что имена методов совпадают с теми, что в Form1.Designer.cs
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                PerformPatternOperation();
            }
            else if (radioButton3.Checked)
            {
                PerformComponentOperation();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                PerformPatternOperation();
            }
            else if (radioButton3.Checked)
            {
                PerformComponentOperation();
            }
        }
    }
}