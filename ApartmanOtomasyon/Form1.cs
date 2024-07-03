using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIncomes_Click(object sender, EventArgs e)
        {
            new Incomes().Show();
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            new Expenses().Show();
        }
    }
}
