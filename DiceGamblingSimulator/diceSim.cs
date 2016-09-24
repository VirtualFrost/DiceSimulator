using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGamblingSimulator
{
    public partial class diceSimForm : Form
    {
        public diceSimForm()
        {
            InitializeComponent();
            underWinLbl.Visible = false;
            chanceValueChangeTxt.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void halfAmountBtn_Click(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(amountTxt.Text);

            amount = amount / 2;
            amountTxt.Text = Convert.ToString(amount);
            
        }

        private void doubleAmountBtn_Click(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(amountTxt.Text);

            amount = amount * 2;
            amountTxt.Text = Convert.ToString(amount);
        }

        private void underValueLbl_Click(object sender, EventArgs e)
        {
            underValueLbl.Visible = false;
            overValueLbl.Visible = true;
            smallSymbolLbl.Visible = false;
            biggerSymbolLbl.Visible = true;
        }

        private void overValueLbl_Click(object sender, EventArgs e)
        {
            underValueLbl.Visible = true;
            overValueLbl.Visible = false;
            smallSymbolLbl.Visible = true;
            biggerSymbolLbl.Visible = false;
        }

        private void chanceValueLbl_Click(object sender, EventArgs e)
        {
            chanceValueLbl.Visible = false;
            chanceValueChangeTxt.Visible = true;
            chanceValueChangeTxt.Text = chanceValueLbl.Text;

            double chance;
            chance = Convert.ToDouble(chanceValueChangeTxt.Text);
            //chance = Convert.ToString(chanceValueLbl.Text);
            
        }
    }
}
