using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Експерта_Система
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int point = 0;

            if (checkBox2.Checked) point = point + 1;
            if (checkBox4.Checked) point = point + 1;
            if (checkBox6.Checked) point = point + 1;
            if (checkBox8.Checked) point = point + 1;
            if (checkBox10.Checked) point = point + 1;
            if (checkBox12.Checked) point = point + 1;
            if (checkBox14.Checked) point = point + 1;
            if (checkBox16.Checked) point = point + 1;
            if (checkBox18.Checked) point = point + 1;
            if (checkBox20.Checked) point = point + 1;

            if (point == 0) label11.Text = "Ви не відповіли на жодне запитання";
            if (point >= 1 && point <= 3) label11.Text = "Ви не проявляєте великого інтересу до оптимізації стратегій к комп'ютерних іграх. Ви вважаєте гру просто розвагою і не бажаєте вкладати зусилля у вивчення нових методів та стратегій";
            if (point >= 4 && point <= 7) label11.Text = "Ви маєте певний інтерес до оптимізації стратегій у грі, але не завжди активно займаєтесь вивченням нових методів. Ви можливо шукали інструменти для оптимізації, але не завжди використовували їх";
            if (point >= 8 && point <= 10) label11.Text = "Ви маєте високий інтерес до оптимізації стратегій. Ви шукаєте інструменти та системи, що допоможуть вам покращити результати гри. Ви вірите, що використання штучного інтелекту та передових методів може дати вам перевагу над іншими гравцями";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
