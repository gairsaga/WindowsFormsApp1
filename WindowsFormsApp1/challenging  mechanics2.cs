//challenging Mechanics2.cs
// CS-1181
// Sagar Gaire
// 9/8/2017
// Anil Mandal
// From this assingnment we can learn how data type are use for coding for example int;double, etc.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int number1=10;
            int number2 = 15;
            int number3 = 5;
            int number4 = 75;
            int number5 = 3;
            double number6 = 10.0;
            double number7 = 45.0;
            double number8 = 3;
            double number9 = 23;
            double number10 = 15;
            int answer1;
            int answer2;
            int answer3;
            int answer4;
            int answer5;
            int answer6;
            int answer7;
            int answer8;
            int answer9;
            int answer10;
            double answer11;
            double answer12;
            double answer13;
            double answer14;
            double answer15;
            double answer16;
            double answer17;
            double answer18;
            double answer19;
            double answer20;
            answer1 = number1+ 10;
            answer2 = number2- 12;
            answer3 = 12-number3;
            answer4 = number4 / 5;
            answer5 = number3 * 8;
            answer6 = number3 + number4;
            answer7 = number2 / number3;
            answer8 = number4 / number3;
            answer9 = number4 / number1;
            answer10 = number5 / number2;
           // MessageBox.Show(answer1.ToString());
           // MessageBox.Show(answer2.ToString());
           // MessageBox.Show(answer3.ToString());
            //MessageBox.Show(answer4.ToString());
           // MessageBox.Show(answer5.ToString());
            //MessageBox.Show(answer6.ToString());
            //MessageBox.Show(answer7.ToString());
            //MessageBox.Show(answer8.ToString());
            //MessageBox.Show(answer9.ToString());
           // MessageBox.Show(answer10.ToString());
            answer11 = number6 + 10;
            answer12 = number7 - 12;
            answer13 = 12-number8;
            answer14 = number9 / 5;
            answer15 = number8 * 8;
            answer16 = number8 + number9;
            answer17 = number7 / number8;
            answer18 = number9 / number8;
            answer19 = number9 / number6;
            answer20 = number10 / number7;
            //MessageBox.Show(answer11.ToString());
            //MessageBox.Show(answer12.ToString());
            //MessageBox.Show(answer13.ToString());
            //MessageBox.Show(answer14.ToString());
            //MessageBox.Show(answer15.ToString());
            //MessageBox.Show(answer16.ToString());
            //MessageBox.Show(answer17.ToString());
            //MessageBox.Show(answer18.ToString());
            //MessageBox.Show(answer19.ToString());
            //MessageBox.Show(answer20.ToString());
            answer1 = number3 % 1;
            answer2 = number3 % 2;
            answer3 = number3 % 3;
            answer4 = number3 % 4;
            answer5 = number3 % 5;
            answer6 = number3 % 6;
            answer7 = number3 % 7;
            answer8 = number3 % 8;
            answer9 = number3 % 9;
            answer10 = number3 % 10;
            //MessageBox.Show(answer1.ToString());
            //MessageBox.Show(answer2.ToString());
            //MessageBox.Show(answer3.ToString());
            //MessageBox.Show(answer4.ToString());
            //MessageBox.Show(answer5.ToString());
            //MessageBox.Show(answer6.ToString());
            //MessageBox.Show(answer7.ToString());
            //MessageBox.Show(answer8.ToString());
            //MessageBox.Show(answer9.ToString());
            //MessageBox.Show(answer10.ToString());
            // MessageBox.Show(answer11.ToString("n2"));
            //MessageBox.Show(answer14.ToString("n6"));
            // MessageBox.Show(answer18.ToString("n3"));
            decimal currency = 15m;
           // MessageBox.Show(currency.ToString("c"));
            decimal rupeese = 7.667m;
           // MessageBox.Show(rupeese.ToString("c"));
            decimal Euro = 2.3m;
           // MessageBox.Show(Euro.ToString("c"));
            decimal pound = 0.33333m;
           // MessageBox.Show(pound.ToString("c"));
            string input1 = "apple";
            string input2 = "banana";
            string input3 = "pear";
            string input4 = "pine";
            string input5 = "boat";
            string input6 = "fruit";
            string output1;
            string output2;
            string output3;
            string output4;
            string output5;
            string output6;
            MessageBox.Show(output1 =input1);
            MessageBox.Show(string.Format ("output2:" +input4+ "" +input1));
            MessageBox.Show(string.Format("output4: " + input2 +" "+input5));
            MessageBox.Show(string.Format("output5:" + input1 + " " +"is a " +input6));
            MessageBox.Show(string.Format("output6:" + input1+","+ " " + input2+ "," + " " +"and"+ " " +input3+ " "+ "in a "+" "+ input6+" "+ input5 ));


        }
    }
}
