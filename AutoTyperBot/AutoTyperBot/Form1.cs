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


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        public async void button1_Click(object sender, EventArgs e)
        {
            
             
            
                
            bool buttonPressed = false;

            int buttonDelay;

            buttonDelay = Slider.Value;


            this.KeyPreview = true;


            await Task.Delay(buttonDelay);
            buttonPressed = true;


            if (buttonDelay < 0) 
            {
                buttonPressed = true;
            }

            timer1.Start();

            buttonDelay = Slider.Value = Convert.ToInt32(Number.Text = buttonDelay.ToString());

            Number.Text = buttonDelay.ToString();

        }


        //  public void button1_click() { }



        public void Slider_ValueChanged(object sender, EventArgs e)
        {

            //Number = the text box
            //Slider = the slider xd







            Number.Text = Slider.Value.ToString();






            //  Number.Text = Slider.Value.ToString();





        }



        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void timer1_Tick_1(object sender, EventArgs e)
        {

            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");


        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Slider_Scroll(object sender, EventArgs e)
        {




        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {





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

        public void button2_Click(object sender, EventArgs e)
        {



        }

    }
}











































