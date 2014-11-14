using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace FastReader
{
    public partial class Form1 : Form
    {

        Timer tmr = new Timer();
        int currentWord;
        bool reading = false;   
        bool paused = false;        // checker if it's in a paused state - at start it's not
        
        public Form1()
        {
            InitializeComponent();
            //tmr.Interval = 200;                               // set one fixed speed of reading
            tmr.Tick += new System.EventHandler(wordChange);    // needs to be here otherwise if in the Start button it creates an event
                                                                // handler in the event handler and it accumulates words to display            
        }


        private void SpeedSlowButton_Click(object sender, EventArgs e)
        {
            tmr.Interval = 500;
            tmr.Start();
            if (reading == false)       // if it's not reading yet, start it and set it to true...
            {
                currentWord = 0;
                reading = true;         // ...here
            }   
        }

        private void SpeedFastButton_Click(object sender, EventArgs e)
        {
            tmr.Interval = 100;         // same with higher speed
            tmr.Start();
            if (reading == false)       
            {
                currentWord = 0;
                reading = true;
            }  
        } 

        
        private void wordChange(object sender, EventArgs e)
        {            
                showWord();           
        }


        private void showWord()
        {
            string src = "In Dark Souls, each of your character's eight statistics determines your overall level. Instead of being limited to the RPG norm of level 99, you can gain upwards of 700 levels. You can level up at Bonfires and spend accumulated Souls that improve your abilities.";

            //string src = null;

            try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    src = sr.ReadToEnd();
                    Console.WriteLine(src);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


            if (src == null)        // Display an error if the text file cannot be found - code problem error. 
            {
                DisplayLabel.Text = "Error: No text to be read.";
            }
            else
            {

                string[] book = src.Split(' ');


                if (currentWord < book.Length)      // this is needed otherwise it deletes the last element on the screen
                    DisplayLabel.Text = "                                   |  \n";

                if (currentWord < book.Length)
                {
                    // we have a 20-character line. we want every word to be displayed in the middle

                    int whiteSpaces;
                    if (book[currentWord].Length % 2 == 0)  // set the number of white spaces to be printed
                    {
                        whiteSpaces = 35 - (book[currentWord].Length / 2);
                    }
                    else
                        whiteSpaces = 34 - (book[currentWord].Length / 2);

                    for (int i = 0; i < whiteSpaces; i++)
                    {
                        DisplayLabel.Text += " ";           // print spaces = 35 or 34 - half the word size                    
                    }
                    DisplayLabel.Text += book[currentWord];

                    //NUMS.Text += book[currentWord] + " " + ( book[currentWord].Length/2) + " " ;   // test screen
                    NUMS.Text += book[currentWord] + " ";
                    currentWord += 1;
                }
                else
                    reading = false;    // if it has ended reading, you can start again without resetting

                DisplayLabel.Text += "\n                                   |  ";
            }
        }


        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (reading == true && paused == false)
            {
                tmr.Stop();
                paused = true;
            }

            else if (paused)    // formerly in a separate Resume button
            {
                tmr.Start();
                paused = false;
            }
        }

                
        private void RESET_Click(object sender, EventArgs e)
        { 
            //if (reading == true)      // uncommenting those will have the Reset not work upon finishing the text
            //{                              
                DisplayLabel.Text = "";
                NUMS.Text = "";
                tmr.Stop();                
                reading = false;  
            //}
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void GoBack10_Click(object sender, EventArgs e)
        {
            if (currentWord >= 10)
            {
                currentWord -= 10;
                NUMS.Text += " || ";
            }
        }

        private void NUMS_Click(object sender, EventArgs e)
        {

        }

        private void DisplayLabel_Click(object sender, EventArgs e)
        {

        }

                             

    }
}
