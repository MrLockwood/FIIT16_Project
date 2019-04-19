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
    public partial class Registration : Form
    {
        Employee empl;
        public Registration(Employee _empl)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;
            string position = textBox4.Text;
            string connStr = @"provider=Microsoft.Jet.OLEDB.4.0; data source=C:\BugTracer\BugTraceDB.mdb;";
            OleDbConnection myOleDbConnection = new OleDbConnection(connStr);
            string query = "INSERT into Employee (name, position, email, password) Values ('name', 'position', 'email', 'password')";
            OleDbCommand InsertEmpl = new OleDbCommand(query, myOleDbConnection);
            InsertEmpl.Connection = myOleDbConnection;
            myOleDbConnection.Open();
            //InsertEmpl.CommandText = "INSERT into Employee (name, position, email, password) Values (@name, @position, @email, @password)";
            InsertEmpl.ExecuteNonQuery();
            InsertEmpl.Parameters.Add("@name", OleDbType.VarChar).Value = name;
            InsertEmpl.Parameters.Add("@password", OleDbType.VarChar).Value = password;
            InsertEmpl.Parameters.Add("@position", OleDbType.VarChar).Value = position;
            InsertEmpl.Parameters.Add("@email", OleDbType.VarChar).Value = email;
            /*
            myOleDbConnection.Open();
            if (myOleDbConnection.State == ConnectionState.Open)
            {

                InsertEmpl.Parameters.Add("@name", OleDbType.VarChar).Value = name;
                InsertEmpl.Parameters.Add("@password", OleDbType.VarChar).Value = password;
                InsertEmpl.Parameters.Add("@position", OleDbType.VarChar).Value = position;
                InsertEmpl.Parameters.Add("@email", OleDbType.VarChar).Value = email;
                {
                    InsertEmpl.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    myOleDbConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
            */
        }
    }
}
