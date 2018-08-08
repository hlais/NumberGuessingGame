using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        private int number;
        //the function below sets the number. We pass the number through the parameter 
        public void setNum(int num)
        {
            this.number = num;
        }

        //the funtion below gets the number from the field.
        public int getNum() {return number; }

        //below is a contructor. This gets runs called automatically. 
        public Form1()
        {
            InitializeComponent();
            //using Random from the library 
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 21);
            setNum(randomNumber);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "I have been clicked";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "I have thought of a number 1 - 20, can you guess what it is?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //text box is a string so we must convert to a number. this is known as casting
            int guessNumber = Convert.ToInt16(textBox1.Text);
            rate(guessNumber, getNum());
        }
        public void rate(int guessNumber, int actualNumber)
        {
            if (guessNumber < actualNumber)
            {
                label2.Text = "Too low!";
                
               
            }
            //else if exits if this condition is meet
            else if (guessNumber > actualNumber)
            {
                label2.Text = "Too high!";
            }
            //if the all the above is incorrect else statment gets executed
            else
            {
                label2.Text = "YOU ROCK! \n you guessed correctly";
                
            }
        }
    }
}
