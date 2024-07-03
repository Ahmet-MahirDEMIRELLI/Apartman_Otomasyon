using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyon
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }
        SqlHelper sqlHelper = new SqlHelper();
        private void Expenses_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.GetTable("SELECT * FROM Expenses");
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["Expense"].ToString());
                string[] parts = dr["Date"].ToString().Split(' ');
                listBox2.Items.Add(parts[0]);
                listBox3.Items.Add(dr["Name"].ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int expense = (int)numericUpDown1.Value;
            DateTime date = dateTimePicker1.Value;
            string expenseTypes = "";
            foreach (Control item in groupBoxExpenses.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    expenseTypes += "," + item.Text;
                }
            }
            expenseTypes = expenseTypes.Remove(0, 1);

            SqlParameter p1 = new SqlParameter("@expense", expense);
            SqlParameter p2 = new SqlParameter("@payment_date", date);
            SqlParameter p3 = new SqlParameter("@name", expenseTypes);

            sqlHelper.ExecuteProcedure("make_payment", p1, p2, p3);


            listBox1.Items.Add(expense.ToString());
            listBox2.Items.Add(date.Date);
            listBox3.Items.Add(expenseTypes);
        }
    }
}
