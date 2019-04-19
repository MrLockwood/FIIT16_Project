using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace BugTracer
{
    public partial class Login : Form
    {
        Employee empl = new Employee();
        public Login(Employee _empl)
        {
            InitializeComponent();
            empl = _empl;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string connStr = @"provider=Microsoft.Jet.OLEDB.4.0; data source=C:\BugTracer\BugTraceDB.mdb ;";
            OleDbConnection myOleDbConnection = new OleDbConnection (connStr);
            //SqlConnection conn = new SqlConnection(connStr);
            OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = "SELECT * FROM Employee" ;
            myOleDbConnection.Open();
            OleDbDataReader myOleDbDataReader = myOleDbCommand.ExecuteReader();
            while (myOleDbDataReader.Read())
            {
                if ((myOleDbDataReader.GetValue(1).ToString().Trim()==NameBox.Text)&&(myOleDbDataReader.GetValue(4).ToString().Trim()==PassBox.Text))
                {
                    MessageBox.Show("Вы в системе");
                    empl.SetName(Convert.ToString(myOleDbDataReader.GetValue(1)));
                    empl.SetNumber(Convert.ToInt32(myOleDbDataReader.GetValue(0)));
                    empl.SetEmail(Convert.ToString(myOleDbDataReader.GetValue(3)));
                    empl.SetPosition(Convert.ToString(myOleDbDataReader.GetValue(2)));
                    empl.SetPassword(Convert.ToString(myOleDbDataReader.GetValue(4)));
                    label1.Text = "Welcome, "+empl.name;
                    Form1 form1 = new Form1(empl);
                    form1.Show();
                }
            }
            myOleDbDataReader.Close();
            myOleDbConnection.Close();
            
        }
    }

}