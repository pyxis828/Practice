using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Timers;

namespace TournyManager
{
    public partial class timerWindow : Form
    {
        double levelTime = 10;                              //declare some variables
        double clockTime = 0;       
        // double timesCalled = 0;
        Queue<string> times = new Queue<string>();
        public timerWindow()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)  //restart level button clicked
        {
            timer1.Stop();                                                          
            clock.Text = levelTime.ToString("00:00");
        }

        private void dock(object sender, DragEventArgs e)
        {

        }

        private void radioButton1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)  //pause button clicked
        {
            timer1.Enabled = false; 
        }

        private void timer1_Tick(object sender, EventArgs e)  //timer tick event method
        {
            // clock.Text = clockTime.ToString("00:00");           //in current set-up this line of code makes clock run incorrectly;   
            // clockTime = clockTime - ( 1 / (2 * timesCalled));    // tried to fool the program; looks right but timing is WAY OFF
            // clockTime = clockTime - 0.5;
            // clock.Text = clockTime.ToString("00:00");             //displays "correctly" like this (once only) 
            clock.Text = times.Dequeue();        
            if (clock.Text == "00:00")
            {
               clock.Text = clockTime.ToString("00:00");        //display 0
               SystemSounds.Exclamation.Play();                 //make a sound
                timer1.Stop();                                  //stop the timer
            }            
        }

        private void startClock_CheckedChanged(object sender, EventArgs e)  //start button clicked
        {            
            timer1.Start();                                                 //start the timer
            timer1.Tick += new EventHandler(timer1_Tick);                   //set tick event handler; pass it the name of the method for the tick event
                                                      //declared at top; need level time            
            //timesCalled++;                                                  //to remain constant; type double 
            int seconds = Convert.ToInt32(levelTime);
            for (int i = seconds; i >= 0; i--)
            {
                times.Enqueue(i.ToString("00:00"));
            }
        }
        private void nextLevel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void clock_Click(object sender, EventArgs e)
        {

        }
    }
}
