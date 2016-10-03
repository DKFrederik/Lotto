using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        List<int> lotteryNums = new List<int>();
        List<int> tilleagstal = new List<int>();
        List<int> supertal = new List<int>();


        List<int> userNums1 = new List<int>();
        List<int> tillaeg1 = new List<int>();
        List<int> super1 = new List<int>();

        List<int> userNums2 = new List<int>();
        List<int> tillaeg2 = new List<int>();
        List<int> super2 = new List<int>();

        List<int> userNums3 = new List<int>();
        List<int> tillaeg3 = new List<int>();
        List<int> super3 = new List<int>();

        List<int> userNums4 = new List<int>();
        List<int> tillaeg4 = new List<int>();
        List<int> super4 = new List<int>();

        List<int> userNums5 = new List<int>();
        List<int> tillaeg5 = new List<int>();
        List<int> super5 = new List<int>();

        List<int> userNums6 = new List<int>();
        List<int> tillaeg6 = new List<int>();
        List<int> super6 = new List<int>();

        List<int> userNums7 = new List<int>();
        List<int> tillaeg7 = new List<int>();
        List<int> super7 = new List<int>();

        List<int> userNums8 = new List<int>();
        List<int> tillaeg8 = new List<int>();
        List<int> super8 = new List<int>();

        List<int> userNums9 = new List<int>();
        List<int> tillaeg9 = new List<int>();
        List<int> super9 = new List<int>();

        List<int> userNums10 = new List<int>();
        List<int> tillaeg10 = new List<int>();
        List<int> super10 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lotteryNums.Clear();
            tilleagstal.Clear();
            supertal.Clear();
            userNums1.Clear();
            tillaeg1.Clear();
            super1.Clear();
            userNums2.Clear();
            tillaeg2.Clear();
            super2.Clear();
            userNums3.Clear();
            tillaeg3.Clear();
            super3.Clear();
            userNums4.Clear();
            tillaeg4.Clear();
            super4.Clear();
            userNums5.Clear();
            tillaeg5.Clear();
            super5.Clear();
            userNums6.Clear();
            tillaeg6.Clear();
            super6.Clear();
            userNums7.Clear();
            tillaeg7.Clear();
            super7.Clear();
            userNums8.Clear();
            tillaeg8.Clear();
            super8.Clear();
            userNums9.Clear();
            tillaeg9.Clear();
            super9.Clear();
            userNums10.Clear();
            tillaeg10.Clear();
            super10.Clear();
            
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    int inte;
                    TextBox textBox = c as TextBox;
                    if (!int.TryParse(textBox.Text, out inte))
                    {
                        textBox.Text = "";
                    }
                    if (textBox.Text == string.Empty)
                    {
                        textBox.Text = "0";
                    }
                }
            }

            //Udtrukkene tal
            lotteryNums.Add(Convert.ToInt32(textBox1.Text));
            lotteryNums.Add(Convert.ToInt32(textBox2.Text));
            lotteryNums.Add(Convert.ToInt32(textBox3.Text));
            lotteryNums.Add(Convert.ToInt32(textBox4.Text));
            lotteryNums.Add(Convert.ToInt32(textBox5.Text));
            lotteryNums.Add(Convert.ToInt32(textBox6.Text));
            lotteryNums.Add(Convert.ToInt32(textBox7.Text));

            tilleagstal.Add(Convert.ToInt32(textBox78.Text));
            tilleagstal.Add(Convert.ToInt32(textBox79.Text));
            tilleagstal.Add(Convert.ToInt32(textBox80.Text));

            supertal.Add(Convert.ToInt32(textBox81.Text));
            supertal.Add(Convert.ToInt32(textBox82.Text));

            //Række 1
            userNums1.Add(Convert.ToInt32(textBox8.Text));
            userNums1.Add(Convert.ToInt32(textBox9.Text));
            userNums1.Add(Convert.ToInt32(textBox10.Text));
            userNums1.Add(Convert.ToInt32(textBox11.Text));
            userNums1.Add(Convert.ToInt32(textBox12.Text));
            userNums1.Add(Convert.ToInt32(textBox13.Text));
            userNums1.Add(Convert.ToInt32(textBox14.Text));

            tillaeg1.Add(Convert.ToInt32(textBox87.Text));
            tillaeg1.Add(Convert.ToInt32(textBox86.Text));
            tillaeg1.Add(Convert.ToInt32(textBox85.Text));

            super1.Add(Convert.ToInt32(textBox83.Text));
            super1.Add(Convert.ToInt32(textBox84.Text));

            //Række 2
            userNums2.Add(Convert.ToInt32(textBox15.Text));
            userNums2.Add(Convert.ToInt32(textBox16.Text));
            userNums2.Add(Convert.ToInt32(textBox17.Text));
            userNums2.Add(Convert.ToInt32(textBox18.Text));
            userNums2.Add(Convert.ToInt32(textBox19.Text));
            userNums2.Add(Convert.ToInt32(textBox20.Text));
            userNums2.Add(Convert.ToInt32(textBox21.Text));

            tillaeg2.Add(Convert.ToInt32(textBox92.Text));
            tillaeg2.Add(Convert.ToInt32(textBox91.Text));
            tillaeg2.Add(Convert.ToInt32(textBox90.Text));

            super2.Add(Convert.ToInt32(textBox89.Text));
            super2.Add(Convert.ToInt32(textBox88.Text));

            //Række 3
            userNums3.Add(Convert.ToInt32(textBox22.Text));
            userNums3.Add(Convert.ToInt32(textBox23.Text));
            userNums3.Add(Convert.ToInt32(textBox24.Text));
            userNums3.Add(Convert.ToInt32(textBox25.Text));
            userNums3.Add(Convert.ToInt32(textBox26.Text));
            userNums3.Add(Convert.ToInt32(textBox27.Text));
            userNums3.Add(Convert.ToInt32(textBox28.Text));

            tillaeg3.Add(Convert.ToInt32(textBox97.Text));
            tillaeg3.Add(Convert.ToInt32(textBox96.Text));
            tillaeg3.Add(Convert.ToInt32(textBox95.Text));

            super3.Add(Convert.ToInt32(textBox94.Text));
            super3.Add(Convert.ToInt32(textBox93.Text));

            //Række 4
            userNums4.Add(Convert.ToInt32(textBox29.Text));
            userNums4.Add(Convert.ToInt32(textBox30.Text));
            userNums4.Add(Convert.ToInt32(textBox31.Text));
            userNums4.Add(Convert.ToInt32(textBox32.Text));
            userNums4.Add(Convert.ToInt32(textBox33.Text));
            userNums4.Add(Convert.ToInt32(textBox34.Text));
            userNums4.Add(Convert.ToInt32(textBox35.Text));

            tillaeg4.Add(Convert.ToInt32(textBox102.Text));
            tillaeg4.Add(Convert.ToInt32(textBox101.Text));
            tillaeg4.Add(Convert.ToInt32(textBox100.Text));

            super4.Add(Convert.ToInt32(textBox99.Text));
            super4.Add(Convert.ToInt32(textBox98.Text));

            //Række 5
            userNums5.Add(Convert.ToInt32(textBox36.Text));
            userNums5.Add(Convert.ToInt32(textBox37.Text));
            userNums5.Add(Convert.ToInt32(textBox38.Text));
            userNums5.Add(Convert.ToInt32(textBox39.Text));
            userNums5.Add(Convert.ToInt32(textBox40.Text));
            userNums5.Add(Convert.ToInt32(textBox41.Text));
            userNums5.Add(Convert.ToInt32(textBox42.Text));

            tillaeg5.Add(Convert.ToInt32(textBox107.Text));
            tillaeg5.Add(Convert.ToInt32(textBox106.Text));
            tillaeg5.Add(Convert.ToInt32(textBox105.Text));

            super5.Add(Convert.ToInt32(textBox104.Text));
            super5.Add(Convert.ToInt32(textBox103.Text));

            //Række 6
            userNums6.Add(Convert.ToInt32(textBox43.Text));
            userNums6.Add(Convert.ToInt32(textBox44.Text));
            userNums6.Add(Convert.ToInt32(textBox45.Text));
            userNums6.Add(Convert.ToInt32(textBox46.Text));
            userNums6.Add(Convert.ToInt32(textBox47.Text));
            userNums6.Add(Convert.ToInt32(textBox48.Text));
            userNums6.Add(Convert.ToInt32(textBox49.Text));

            tillaeg6.Add(Convert.ToInt32(textBox112.Text));
            tillaeg6.Add(Convert.ToInt32(textBox111.Text));
            tillaeg6.Add(Convert.ToInt32(textBox110.Text));

            super6.Add(Convert.ToInt32(textBox109.Text));
            super6.Add(Convert.ToInt32(textBox108.Text));

            //Række 7
            userNums7.Add(Convert.ToInt32(textBox50.Text));
            userNums7.Add(Convert.ToInt32(textBox51.Text));
            userNums7.Add(Convert.ToInt32(textBox52.Text));
            userNums7.Add(Convert.ToInt32(textBox53.Text));
            userNums7.Add(Convert.ToInt32(textBox54.Text));
            userNums7.Add(Convert.ToInt32(textBox55.Text));
            userNums7.Add(Convert.ToInt32(textBox56.Text));

            tillaeg7.Add(Convert.ToInt32(textBox117.Text));
            tillaeg7.Add(Convert.ToInt32(textBox116.Text));
            tillaeg7.Add(Convert.ToInt32(textBox115.Text));

            super7.Add(Convert.ToInt32(textBox114.Text));
            super7.Add(Convert.ToInt32(textBox113.Text));

            //Række 8
            userNums8.Add(Convert.ToInt32(textBox57.Text));
            userNums8.Add(Convert.ToInt32(textBox58.Text));
            userNums8.Add(Convert.ToInt32(textBox59.Text));
            userNums8.Add(Convert.ToInt32(textBox60.Text));
            userNums8.Add(Convert.ToInt32(textBox61.Text));
            userNums8.Add(Convert.ToInt32(textBox62.Text));
            userNums8.Add(Convert.ToInt32(textBox63.Text));

            tillaeg8.Add(Convert.ToInt32(textBox122.Text));
            tillaeg8.Add(Convert.ToInt32(textBox121.Text));
            tillaeg8.Add(Convert.ToInt32(textBox120.Text));

            super8.Add(Convert.ToInt32(textBox119.Text));
            super8.Add(Convert.ToInt32(textBox118.Text));

            //Række 9
            userNums9.Add(Convert.ToInt32(textBox64.Text));
            userNums9.Add(Convert.ToInt32(textBox65.Text));
            userNums9.Add(Convert.ToInt32(textBox66.Text));
            userNums9.Add(Convert.ToInt32(textBox67.Text));
            userNums9.Add(Convert.ToInt32(textBox68.Text));
            userNums9.Add(Convert.ToInt32(textBox69.Text));
            userNums9.Add(Convert.ToInt32(textBox70.Text));

            tillaeg9.Add(Convert.ToInt32(textBox127.Text));
            tillaeg9.Add(Convert.ToInt32(textBox126.Text));
            tillaeg9.Add(Convert.ToInt32(textBox125.Text));

            super9.Add(Convert.ToInt32(textBox124.Text));
            super9.Add(Convert.ToInt32(textBox123.Text));

            //Række 10
            userNums10.Add(Convert.ToInt32(textBox71.Text));
            userNums10.Add(Convert.ToInt32(textBox72.Text));
            userNums10.Add(Convert.ToInt32(textBox73.Text));
            userNums10.Add(Convert.ToInt32(textBox74.Text));
            userNums10.Add(Convert.ToInt32(textBox75.Text));
            userNums10.Add(Convert.ToInt32(textBox76.Text));
            userNums10.Add(Convert.ToInt32(textBox77.Text));

            tillaeg10.Add(Convert.ToInt32(textBox132.Text));
            tillaeg10.Add(Convert.ToInt32(textBox131.Text));
            tillaeg10.Add(Convert.ToInt32(textBox130.Text));

            super10.Add(Convert.ToInt32(textBox129.Text));
            super10.Add(Convert.ToInt32(textBox128.Text));

            lotteryNums.Sort();
            tilleagstal.Sort();
            supertal.Sort();

            userNums1.Sort();
            tillaeg1.Sort();
            super1.Sort();

            userNums2.Sort();
            tillaeg2.Sort();
            super2.Sort();

            userNums3.Sort();
            tillaeg3.Sort();
            super3.Sort();

            userNums4.Sort();
            tillaeg4.Sort();
            super4.Sort();

            userNums5.Sort();
            tillaeg5.Sort();
            super5.Sort();

            userNums6.Sort();
            tillaeg6.Sort();
            super6.Sort();

            userNums7.Sort();
            tillaeg7.Sort();
            super7.Sort();

            userNums8.Sort();
            tillaeg8.Sort();
            super8.Sort();

            userNums9.Sort();
            tillaeg9.Sort();
            super9.Sort();

            userNums10.Sort();
            tillaeg10.Sort();
            super10.Sort();

            //Række 1
            label3.Text = "";
            var matches1 = lotteryNums.Intersect(userNums1).ToList();
            matches1.Remove(0);
            // Create comma-separated string of matching values...  
            string output1 = string.Join(",", matches1);
            foreach (var x in output1)
            {
                label3.Text += x;
            }

            label23.Text = "";
            var matches11 = tilleagstal.Intersect(tillaeg1).ToList();
            matches11.Remove(0);
            //Create comma-separated string of matching values...
            string output11 = string.Join(",", matches11);
            foreach (var x in output11)
            {
                label23.Text += x;
            }

            label24.Text = "";
            var matches12 = supertal.Intersect(super1).ToList();
            matches12.Remove(0);
            //Create comma-separated string of matching values...
            string output12 = string.Join(",", matches12);
            foreach (var x in output12)
            {
                label24.Text += x;
            }

            //Række 2
            label1.Text = "";
            var matches2 = lotteryNums.Intersect(userNums2).ToList();
            matches2.Remove(0);
            // Create comma-separated string of matching values...  
            string output2 = string.Join(",", matches2);
            foreach (var x in output2)
            {
                label1.Text += x;
            }

            label26.Text = "";
            var matches13 = tilleagstal.Intersect(tillaeg2).ToList();
            matches13.Remove(0);
            //Create comma-separated string of matching values...
            string output13 = string.Join(",", matches13);
            foreach (var x in output13)
            {
                label26.Text += x;
            }

            label25.Text = "";
            var matches14 = supertal.Intersect(super2).ToList();
            matches14.Remove(0);
            //Create comma-separated string of matching values...
            string output14 = string.Join(",", matches14);
            foreach (var x in output14)
            {
                label25.Text += x;
            }

            //Række 3
            label2.Text = "";
            var matches3 = lotteryNums.Intersect(userNums3).ToList();
            matches3.Remove(0);
            // Create comma-separated string of matching values...  
            string output3 = string.Join(",", matches3);
            foreach (var x in output3)
            {
                label2.Text += x;
            }

            label28.Text = "";
            var matches15 = tilleagstal.Intersect(tillaeg3).ToList();
            matches15.Remove(0);
            //Create comma-separated string of matching values...
            string output15 = string.Join(",", matches15);
            foreach (var x in output15)
            {
                label28.Text += x;
            }

            label27.Text = "";
            var matches16 = supertal.Intersect(super3).ToList();
            matches16.Remove(0);
            //Create comma-separated string of matching values...
            string output16 = string.Join(",", matches16);
            foreach (var x in output16)
            {
                label27.Text += x;
            }

            //Række 4
            label16.Text = "";
            var matches4 = lotteryNums.Intersect(userNums4).ToList();
            matches4.Remove(0);
            // Create comma-separated string of matching values...  
            string output4 = string.Join(",", matches4);
            foreach (var x in output4)
            {
                label16.Text += x;
            }

            label30.Text = "";
            var matches17 = tilleagstal.Intersect(tillaeg4).ToList();
            matches17.Remove(0);
            //Create comma-separated string of matching values...
            string output17 = string.Join(",", matches17);
            foreach (var x in output17)
            {
                label30.Text += x;
            }

            label29.Text = "";
            var matches18 = supertal.Intersect(super4).ToList();
            matches18.Remove(0);
            //Create comma-separated string of matching values...
            string output18 = string.Join(",", matches18);
            foreach (var x in output18)
            {
                label29.Text += x;
            }

            //Række 5
            label17.Text = "";
            var matches5 = lotteryNums.Intersect(userNums5).ToList();
            matches5.Remove(0);
            // Create comma-separated string of matching values...  
            string output5 = string.Join(",", matches5);
            foreach (var x in output5)
            {
                label17.Text += x;
            }

            label32.Text = "";
            var matches19 = tilleagstal.Intersect(tillaeg5).ToList();
            matches19.Remove(0);
            //Create comma-separated string of matching values...
            string output19 = string.Join(",", matches19);
            foreach (var x in output19)
            {
                label32.Text += x;
            }

            label31.Text = "";
            var matches20 = supertal.Intersect(super5).ToList();
            matches20.Remove(0);
            //Create comma-separated string of matching values...
            string output20 = string.Join(",", matches20);
            foreach (var x in output20)
            {
                label31.Text += x;
            }

            //Række 6
            label18.Text = "";
            var matches6 = lotteryNums.Intersect(userNums6).ToList();
            matches6.Remove(0);
            // Create comma-separated string of matching values...  
            string output6 = string.Join(",", matches6);
            foreach (var x in output6)
            {
                label18.Text += x;
            }

            label34.Text = "";
            var matches21 = tilleagstal.Intersect(tillaeg6).ToList();
            matches21.Remove(0);
            //Create comma-separated string of matching values...
            string output21 = string.Join(",", matches21);
            foreach (var x in output21)
            {
                label34.Text += x;
            }

            label33.Text = "";
            var matches22 = supertal.Intersect(super6).ToList();
            matches22.Remove(0);
            //Create comma-separated string of matching values...
            string output22 = string.Join(",", matches22);
            foreach (var x in output20)
            {
                label33.Text += x;
            }

            //Række 7
            label19.Text = "";
            var matches7 = lotteryNums.Intersect(userNums7).ToList();
            matches7.Remove(0);
            // Create comma-separated string of matching values...  
            string output7 = string.Join(",", matches7);
            foreach (var x in output7)
            {
                label19.Text += x;
            }

            label36.Text = "";
            var matches23 = tilleagstal.Intersect(tillaeg7).ToList();
            matches23.Remove(0);
            //Create comma-separated string of matching values...
            string output23 = string.Join(",", matches23);
            foreach (var x in output23)
            {
                label36.Text += x;
            }

            label35.Text = "";
            var matches24 = supertal.Intersect(super7).ToList();
            matches24.Remove(0);
            //Create comma-separated string of matching values...
            string output24 = string.Join(",", matches24);
            foreach (var x in output24)
            {
                label35.Text += x;
            }

            //Række 8
            label20.Text = "";
            var matches8 = lotteryNums.Intersect(userNums8).ToList();
            matches8.Remove(0);
            // Create comma-separated string of matching values...  
            string output8 = string.Join(",", matches8);
            foreach (var x in output8)
            {
                label20.Text += x;
            }

            label38.Text = "";
            var matches25 = tilleagstal.Intersect(tillaeg8).ToList();
            matches25.Remove(0);
            //Create comma-separated string of matching values...
            string output25 = string.Join(",", matches25);
            foreach (var x in output25)
            {
                label38.Text += x;
            }

            label37.Text = "";
            var matches26 = supertal.Intersect(super8).ToList();
            matches26.Remove(0);
            //Create comma-separated string of matching values...
            string output26 = string.Join(",", matches26);
            foreach (var x in output26)
            {
                label37.Text += x;
            }

            //Række 9
            label21.Text = "";
            var matches9 = lotteryNums.Intersect(userNums9).ToList();
            matches9.Remove(0);
            // Create comma-separated string of matching values...  
            string output9 = string.Join(",", matches9);
            foreach (var x in output9)
            {
                label21.Text += x;
            }

            label40.Text = "";
            var matches27 = tilleagstal.Intersect(tillaeg9).ToList();
            matches27.Remove(0);
            //Create comma-separated string of matching values...
            string output27 = string.Join(",", matches27);
            foreach (var x in output27)
            {
                label40.Text += x;
            }

            label39.Text = "";
            var matches28 = supertal.Intersect(super9).ToList();
            matches28.Remove(0);
            //Create comma-separated string of matching values...
            string output28 = string.Join(",", matches28);
            foreach (var x in output28)
            {
                label39.Text += x;
            }

            //Række 10
            label22.Text = "";
            var matches10 = lotteryNums.Intersect(userNums10).ToList();
            matches10.Remove(0);
            // Create comma-separated string of matching values...  
            string output10 = string.Join(",", matches10);
            foreach (var x in output10)
            {
                label22.Text += x;
            }

            label42.Text = "";
            var matches29 = tilleagstal.Intersect(tillaeg10).ToList();
            matches29.Remove(0);
            //Create comma-separated string of matching values...
            string output29 = string.Join(",", matches29);
            foreach (var x in output29)
            {
                label42.Text += x;
            }

            label41.Text = "";
            var matches30 = supertal.Intersect(super10).ToList();
            matches30.Remove(0);
            //Create comma-separated string of matching values...
            string output30 = string.Join(",", matches30);
            foreach (var x in output30)
            {
                label41.Text += x;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lotteryNums.Clear();
            tilleagstal.Clear();
            supertal.Clear();
            userNums1.Clear();
            tillaeg1.Clear();
            super1.Clear();
            userNums2.Clear();
            tillaeg2.Clear();
            super2.Clear();
            userNums3.Clear();
            tillaeg3.Clear();
            super3.Clear();
            userNums4.Clear();
            tillaeg4.Clear();
            super4.Clear();
            userNums5.Clear();
            tillaeg5.Clear();
            super5.Clear();
            userNums6.Clear();
            tillaeg6.Clear();
            super6.Clear();
            userNums7.Clear();
            tillaeg7.Clear();
            super7.Clear();
            userNums8.Clear();
            tillaeg8.Clear();
            super8.Clear();
            userNums9.Clear();
            tillaeg9.Clear();
            super9.Clear();
            userNums10.Clear();
            tillaeg10.Clear();
            super10.Clear();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
