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
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
        }
        SqlHelper sqlHelper = new SqlHelper();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int apartmentNo = Convert.ToInt32(comboBoxAparment.Text);
            int payment = (int)numericUpDownTotal.Value;
            DateTime date = dateTimePicker1.Value;

            SqlParameter p1 = new SqlParameter("apartmant_no",apartmentNo);
            SqlParameter p2 = new SqlParameter("payment", payment);
            SqlParameter p3 = new SqlParameter("payment_date", date);

            sqlHelper.ExecuteProcedure("get_payment", p1, p2, p3);


            listBox1.Items.Add(apartmentNo.ToString());
            listBox2.Items.Add(payment.ToString());
            listBox3.Items.Add(date.Date);
        }

        private void Incomes_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.GetTable("SELECT * FROM Payments");
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["ApartmentNo"].ToString());
                listBox2.Items.Add(dr["Payment"].ToString());
                string[] parts = dr["Date"].ToString().Split(' ');
                listBox3.Items.Add(parts[0]);
            }
        }
    }
}
