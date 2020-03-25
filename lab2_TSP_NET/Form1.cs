using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratoareTSPNET
{
    public partial class cal : Form
    {

        private string calcul = String.Empty;

        public cal()
        {
            InitializeComponent();
            calcul = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        
        private void button0_Click(object sender, EventArgs e)
        {
            calcul += "0";
            textChanged(calcul);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            calcul += "1";
            textChanged(calcul);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            calcul += "2";
            textChanged(calcul);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            calcul += "3";
            textChanged(calcul);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            calcul += "4";
            textChanged(calcul);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            calcul += "5";
            textChanged(calcul);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            calcul += "6";
            textChanged(calcul);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            calcul += "7";
            textChanged(calcul);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            calcul += "8";
            textChanged(calcul);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            calcul += "9";
            textChanged(calcul);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            calcul += ".";
            textChanged(calcul);
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calcul += "=";
            textChanged(calcul);
            CalculFinal(calcul);
        }
        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            calcul = String.Empty;
            textChanged(calcul);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int lungime = calcul.Length;
            Console.WriteLine(lungime);
            calcul=calcul.Remove(lungime-1);
            textChanged(calcul);
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            calcul += "+";
            textChanged(calcul);
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            calcul += "-";
            textChanged(calcul);
        }
        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            calcul += "/";
            textChanged(calcul);
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            calcul += "*";
            textChanged(calcul);
        }

        private void textChanged(string calcul)
        {
            Result.Text = calcul;
           
            Console.WriteLine(calcul);
        }

        private void CalculFinal(string calcul)
        {
            var item1 = calcul;
            var item2 = calcul;
            Console.WriteLine(item1);
            Console.WriteLine(item2);
            var semnList = item2.Split('=','.', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            string semn = string.Empty;
            foreach (var item in semnList)
            {
                if (item != string.Empty)
                {
                    semn = item;
                }
            }
            var nrSplit = item1.Split('*','-','+','/','=');
            if ((nrSplit[0].Contains('.')==true) || (nrSplit[1].Contains('.') == true))
            {
                 var nr1 = formatFloat(nrSplit[0]);
                 var nr2 = formatFloat(nrSplit[1]);
                 CalculPropriuZisFloat(semn, nr1, nr2);
            }
            else
            {
                var nr1 = formatInt(nrSplit[0]);
                var nr2 = formatInt(nrSplit[1]);
                CalculPropriuZisInt(semn, nr1, nr2);
            }

        }

        private int formatInt(string nr)
        {
           return Int32.Parse(nr);
        }
        private float formatFloat(string nr)
        {
            return float.Parse(nr);
        }
        private void CalculPropriuZisInt(string semn, int nr1, int nr2)
        {
            Console.WriteLine(nr1);
            Console.WriteLine(semn);
            Console.WriteLine(nr2);
            int calculFinal = 0;
            if (semn == "+")
            {
                Result.Text = string.Empty;
                calculFinal = nr1 + nr2;
                Result.Text += calculFinal.ToString();
            }
            if (semn == "-")
            {
                Result.Text = string.Empty;
                calculFinal = nr1 - nr2;
                Result.Text += calculFinal.ToString();
            }
            if (semn == "*")
            {
                Result.Text = string.Empty;
                calculFinal = nr1 * nr2;
                Result.Text += calculFinal.ToString();
            }
            if (semn == "/")
            {
                Result.Text = string.Empty;
                calculFinal = nr1 / nr2;
                Result.Text += calculFinal.ToString();
            }
            calcul = string.Empty;
            calcul += calculFinal.ToString();
        }
        private void CalculPropriuZisFloat(string semn, float nr1, float nr2)
        {
            Console.WriteLine(nr1);
            Console.WriteLine(semn);
            Console.WriteLine(nr2);
            float calculFinal=0;
            if (semn == "+")
            {
                Result.Text = string.Empty;
                calculFinal = nr1 + nr2;
                Result.Text += calculFinal.ToString();
            }
            if (semn == "-")
            {
                Result.Text = string.Empty;
                calculFinal = nr1 - nr2;
                Result.Text += calculFinal.ToString();
            }
            if (semn == "*")
            {
                Result.Text = string.Empty;
                calculFinal = nr1 * nr2;
                Result.Text += calculFinal.ToString();
            }
            if (semn == "/")
            {
                Result.Text = string.Empty;
                calculFinal= nr1 / nr2;
                Result.Text += calculFinal.ToString();
            }
             calcul =string.Empty;
             calcul += calculFinal.ToString();
        }
    }
}
