using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiliToli
{
    public partial class Form1 : Form
    {

        int time;
        int timer = 0;
        int hour, min, sec = 0;
        //int szam;
        

        public Form1()
        {
            InitializeComponent();
        }

        int lepesekszama = 0, labelIndex = 0;

        private void Check()
        {
            int index = 0;
            foreach (Button btn in this.panel1.Controls)
            {
                if (btn.Text!="" && Convert.ToInt16(btn.Text) != index)
                {
                    return;
                }
                index++;
            }
            MessageBox.Show("Gratulálok kiraktad" + lepesekszama + "lépéssel");
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            if(button5.Text == "")
            {
                button5.Text = button1.Text;
                button1.Text = "";
            }
            lepesSzamlalo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button2.Text;
                button2.Text = "";
            }
            lepesSzamlalo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button3.Text;
                button3.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button3.Text;
                button3.Text = "";
            }
            lepesSzamlalo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button4.Text;
                button4.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button4.Text;
                button4.Text = "";
            }
            lepesSzamlalo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button5.Text;
                button5.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button5.Text;
                button5.Text = "";
            }
            lepesSzamlalo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button6.Text;
                button6.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button6.Text;
                button6.Text = "";
            }
            if (button10.Text == "")
            {
                button10.Text = button6.Text;
                button6.Text = "";
            }
            lepesSzamlalo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button7.Text;
                button7.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button7.Text;
                button7.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
            if (button11.Text == "")
            {
                button11.Text = button7.Text;
                button7.Text = "";
            }
            lepesSzamlalo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button8.Text;
                button8.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }
            if (button12.Text == "")
            {
                button12.Text = button8.Text;
                button8.Text = "";
            }
            lepesSzamlalo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button9.Text;
                button9.Text = "";
            }
            if (button10.Text == "")
            {
                button10.Text = button9.Text;
                button9.Text = "";
            }
            if (button13.Text == "")
            {
                button13.Text = button9.Text;
                button9.Text = "";
            }
            lepesSzamlalo();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button10.Text;
                button10.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button10.Text;
                button10.Text = "";
            }
            if (button11.Text == "")
            {
                button11.Text = button10.Text;
                button10.Text = "";
            }
            if (button14.Text == "")
            {
                button14.Text = button10.Text;
                button10.Text = "";
            }
            lepesSzamlalo();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = button11.Text;
                button11.Text = "";
            }
            if (button10.Text == "")
            {
                button10.Text = button11.Text;
                button11.Text = "";
            }
            if (button12.Text == "")
            {
                button12.Text = button11.Text;
                button11.Text = "";
            }
            if (button15.Text == "")
            {
                button15.Text = button11.Text;
                button11.Text = "";
            }
            lepesSzamlalo();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = button12.Text;
                button12.Text = "";
            }
            if (button11.Text == "")
            {
                button11.Text = button12.Text;
                button12.Text = "";
            }
            if (button16.Text == "")
            {
                button16.Text = button12.Text;
                button12.Text = "";
            }
            lepesSzamlalo();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = button13.Text;
                button13.Text = "";
            }
            if (button14.Text == "")
            {
                button14.Text = button13.Text;
                button13.Text = "";
            }
            lepesSzamlalo();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button10.Text == "")
            {
                button10.Text = button14.Text;
                button14.Text = "";
            }
            if (button13.Text == "")
            {
                button13.Text = button14.Text;
                button14.Text = "";
            }
            if (button15.Text == "")
            {
                button15.Text = button14.Text;
                button14.Text = "";
            }
            lepesSzamlalo();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button11.Text == "")
            {
                button11.Text = button15.Text;
                button15.Text = "";
            }
            if (button14.Text == "")
            {
                button14.Text = button15.Text;
                button15.Text = "";
            }
            if (button16.Text == "")
            {
                button16.Text = button15.Text;
                button15.Text = "";
            }
            lepesSzamlalo();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.Text == "")
            {
                button12.Text = button16.Text;
                button16.Text = "";
            }
            if (button15.Text == "")
            {
                button15.Text = button16.Text;
                button16.Text = "";
            }
            lepesSzamlalo();
        }

        public void lepesSzamlalo()
        {
            time = time + 1;
            label2.Text ="Lépések száma : " + time;
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
               button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
               button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
               button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "16")
            {
                MessageBox.Show("Gratulálok sikerült kiraknod" + time + "Lépések száma");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            timer1.Start();
            

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = hour + ":" + min + ":" + sec.ToString();
            sec++;
            if (sec >= 60)
            {
                min++;
                sec = 0;
            }
            else
            {
                sec++;
            }
            if (min > 60)
            {
                hour++;
                min = 0;
            }
            if (hour >= 60)
            {
                hour++;
                min = 0;
            }



          
        }

        

        private void button18_Click(object sender, EventArgs e)
        {
            List<int> labelList = new List<int>();
            Random rand = new Random();
            foreach (Button b in panel1.Controls)
            {
                while (labelList.Contains(labelIndex))
                    labelIndex = rand.Next(16);

                b.Text = (labelIndex == 0) ? "" : labelIndex + "";
                labelList.Add(labelIndex);
            }
            lepesekszama = 0;
            label2.Text = "Lépések száma : " + lepesekszama;

        }




    }
}
