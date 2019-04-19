using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracer
{
    public partial class Form1 : Form
    {
        Employee empl = new Employee();
        public Form1(Employee _empl)
        {
            InitializeComponent();
            empl = _empl;
            label1.Text = empl.name;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login(empl);
            login.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string position = empl.GetPosition();
            if (position == "admin") 
            {
                Registration reg = new Registration(empl);
                reg.Show();
                this.Hide();
            }
        }
    }
}
