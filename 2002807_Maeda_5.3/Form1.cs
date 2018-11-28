using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_5._3
{
    public partial class Form1 : Form
    {
        private decimal totalPay = 0,
            weeklySales = 0,
            commission = 0,
            commissionRate = 0.15M,
            totalCommission = 0,
            quota = 1000,
            pay,
            basePay = 250,
            totalSales;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by - Ransom Maeda");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commissionOutput.Clear();
            nameInput.Clear();
            weeklyInput.Clear();
            salesOutput.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sales - " + totalSales.ToString("C") + "\nCommission - " + totalCommission.ToString() + "\nPay - " + totalPay.ToString(), "Summary");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectFont();
            commissionOutput.Font = fontChange.Font;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectColor();
            commissionOutput.ForeColor = colorChange.Color;
        }

        private int amount;

        public Form1()
        {
            InitializeComponent();
            commissionOutput.ReadOnly = true;
            payOutput.ReadOnly = true;
            salesOutput.ReadOnly = true;
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                amount++;
                weeklySales = decimal.Parse(weeklyInput.Text);
                totalSales += weeklySales;
                pay = basePay * amount;
                payOutput.Text = totalPay.ToString();
                if (weeklySales >= quota)
                {
                    commission = weeklySales * commissionRate;
                    totalCommission += commission;
                    commissionOutput.Text = totalCommission.ToString();
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }
        }

        private void selectFont()
        {
            fontChange.ShowDialog();
        }

        private void selectColor()
        {
            colorChange.ShowDialog();
        }
    }
}
