using AutoTyperBot.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoTyperBot
{
    public partial class Main : Form
    {
        private bool isCollapsed;


        public Main()
        {
            InitializeComponent();
        }


        public async void button1_Click(object sender, EventArgs e)
        {

            int buttonDelay;

            buttonDelay = Slider.Value;
            MessageBox.Show($"Typing will start after {buttonDelay} Miliseconds");

            await Task.Delay(buttonDelay);
        
            timer1.Start();

            buttonDelay = Slider.Value = Convert.ToInt32(Number.Text = buttonDelay.ToString());

            Number.Text = buttonDelay.ToString();

        }


        public void Slider_ValueChanged(object sender, EventArgs e)
        {
            Number.Text = Slider.Value.ToString();

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Typing has Stopped");
        }

        public void timer1_Tick_1(object sender, EventArgs e)
        {
            int delay;
            delay = Slider.Value;
            bool canSend = true;
            if (canSend == true) 
            {
                
               SendKeys.Send(textBox1.Text);
               SendKeys.Send("{Enter}");

                canSend = false;
                canSend.ToString();

                timer1.Stop();
                Task.Delay(delay).Wait();

                timer1.Start();
  
            }


        }

        public void StartButton_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control == true && e.KeyCode == Keys.F1)
            {

                StartButton.PerformClick();
            }


            if (e.Control == true && e.KeyCode == Keys.K)
            {

                StartButton.PerformClick();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
                button1.Image = Resources.arrowhaha;

                panelDrop.Height += 10;

                if (panelDrop.Size == panelDrop.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }

            }

            else
            {
                button1.Image = Resources.retractarrow;
                panelDrop.Height -= 7;

                if (panelDrop.Size == panelDrop.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }

        }

    }
}

