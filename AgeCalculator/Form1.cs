using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Age_Calculator : Form
    {
        public Age_Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            textBox1.Text = CalculateAge(startDate, endDate).ToString();
        }

        private void button1_Hoverk(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Black;
            this.button1.ForeColor = Color.White;
        }

        public long CalculateAge(System.DateTime StartDate, System.DateTime EndDate)
        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
            age = (long)(ts.Days / 365);

            return age;
        }

        private void button1_HoverL(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
            this.button1.ForeColor = Color.Gray;
        }

        private void button1_MouseM(object sender, MouseEventArgs e)
        {
            this.button1.BackColor = Color.Black;
            this.button1.ForeColor = Color.White;
        }
    }
}
