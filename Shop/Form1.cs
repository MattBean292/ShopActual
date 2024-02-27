using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Shop
{
    public partial class Form1 : Form
    {
        // integers
        int secret;
        int shovel;
        int carrot;
        int raddish;
        double shovelm;
        double carrotm;
        double raddishm;
        int shovelRate = 7;
        double carrotRate = 2.55;
        double raddishRate = 4.70;
        double taxRate = 0.13;
        double subtotal;
        double taxAmount;
        double total;
        double tendered;
        double change;
        public Form1()
        {
            InitializeComponent();
            changebutton.Hide();
            receiptLabel.Hide();
            printbutton.Hide();
            neworderbutton.Hide();
            this.Size = new Size(400, 479);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // how to leave the secret
            if ((secret == 1) && (shovelText.Text == "help")) 
                {
                this.Size = new Size(400, 479);
                shovelText.Text = "";
                carrotText.Text = "";
                radishText.Text = "";
                tenderedText.Text = "";
                subtotalLabel.Text = "";
                taxesLabel.Text = "";
                totalLabel.Text = "";
                changeLabel.Text = "";
                shovelText.Enabled = true;
                carrotText.Enabled = true;
                radishText.Enabled = true;
                tenderedText.Enabled = true;
                calculateButton.Enabled = true;
                changebutton.Enabled = true;
                printbutton.Enabled = true;
                showbutton.Enabled = true;
                receiptLabel.Hide();
                printbutton.Hide();
                neworderbutton.Hide();
                secret = 0;
            }
            try
            {
                shovel = Convert.ToInt16(shovelText.Text);
                carrot = Convert.ToInt16(carrotText.Text);
                raddish = Convert.ToInt16(radishText.Text);
            }
            catch
            {
                // makes sure your not breaking anything
                shovelText.Text = "buy something";
                carrotText.Text = "";
                radishText.Text = "";
                return;
            }
            // the math part
            shovelm = shovel * shovelRate;
            carrotm = carrot * carrotRate;
            raddishm = raddish * raddishRate;
            subtotal = shovelm  + carrotm + raddishm;
            taxAmount = subtotal * taxRate;
            total = taxAmount + subtotal;
                if ((shovel == 0) && (carrot == 0) && (raddish == 0))
                {
                    shovelText.Text = "buy something";
                    carrotText.Text = "";
                    radishText.Text = "";
                }
                else
                {
                    subtotalLabel.Text = $"{subtotal.ToString("c")}";
                    taxesLabel.Text = $"{taxAmount.ToString("c")}";
                    totalLabel.Text = $"{total.ToString("c")}";
                    changebutton.Show();
                }
                // the secret
                if ((shovel >= 99) && (carrot == 0) && (raddish == 0))
                {
                    shovelText.Text = "0";
                    shovelText.Enabled = false;
                    carrotText.Enabled = false;
                    radishText.Enabled = false;
                    tenderedText.Enabled = false;
                    calculateButton.Enabled = false;
                    showbutton.Enabled = false;
                    changebutton.Hide();
                    costClabel.Text = "";
                    costSlabel.Text = "";
                    costRlabel.Text = "";
                    subtotalLabel.Text = "why";
                    taxesLabel.Text = "why";
                    totalLabel.Text = "why";
                    changeLabel.Text = "what are you doing";
                    printbutton.Show();
                    secret = 1;
            }
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            // no cheating
            try
            {
                tendered = Convert.ToDouble(tenderedText.Text);
            }
            catch 
            {
                tenderedText.Text = "real money please";
                return;
            }
            change = tendered - total;
            if (change < 0)
            {
                tenderedText.Text = "requires more money";
            }
            else
            {
                changeLabel.Text = $"{change.ToString("c")}";
                printbutton.Show();
            }
            
        }
  
        private void printbutton_Click(object sender, EventArgs e)
        {
            // the secret
            if (secret == 1)
            {
                this.Size = new Size(655, 479);
                SoundPlayer player = new SoundPlayer(Properties.Resources.printernoise);
                player.Play();
                receiptLabel.Show();
                showbutton.Enabled = false;
                shovelText.Enabled = true;
                carrotText.Enabled = false;
                radishText.Enabled = false;
                tenderedText.Enabled = false;
                calculateButton.Enabled = true;
                changebutton.Enabled = false;
                printbutton.Enabled = false;
                neworderbutton.Hide();
                receiptLabel.Text = "why do you want so many shovels";
                secret = 1;
            }
            else
            {
                // the actual receipt
                this.Size = new Size(655, 479);
                receiptLabel.Show();
                shovelText.Enabled = false;
                carrotText.Enabled = false;
                radishText.Enabled = false;
                tenderedText.Enabled = false;
                calculateButton.Enabled = false;
                changebutton.Enabled = false;
                printbutton.Enabled = false;
                SoundPlayer player = new SoundPlayer(Properties.Resources.printernoise);
                player.Play();
                receiptLabel.Text = "Farmer Joe Shop ";
                Thread.Sleep(500);
                Refresh();
                receiptLabel.Text += $"\n\nShovels:                              X{shovel} {shovelm.ToString("c")}";
                Thread.Sleep(500);
                Refresh();
                receiptLabel.Text += $"\nRaddishes:                          X{raddish} {raddishm.ToString("c")}";
                Thread.Sleep(500);
                Refresh();
                receiptLabel.Text += $"\nCarrots:                              X{carrot} {carrotm.ToString("c")}";
                Thread.Sleep(500);
                player.Play();
                Refresh();
                receiptLabel.Text += $"\n\nSubtotal:                                   {subtotal.ToString("c")}";
                Thread.Sleep(500);
                Refresh();
                receiptLabel.Text += $"\nTaxes:                                        {taxAmount.ToString("c")}";
                Thread.Sleep(500);
                Refresh();
                receiptLabel.Text += $"\nTotal:                                       {total.ToString("c")}";
                Thread.Sleep(500);
                Refresh();
                receiptLabel.Text += $"\n\nTendered:                                {tendered.ToString("c")}";
                Thread.Sleep(500);
                player.Play();
                Refresh();
                receiptLabel.Text += $"\nChange:                                    {change.ToString("c")}";
                Thread.Sleep(500);
                Refresh();
                receiptLabel.Text += "\n\nThank You for Shopping at Farmer Joe's Shop ";
                Thread.Sleep(500);
                neworderbutton.Show();
            }
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            // lets you see things
            costSlabel.Text = $"{shovelRate.ToString("c")}";
            costRlabel.Text = $"{raddishRate.ToString("c")}";
            costClabel.Text = $"{carrotRate.ToString("c")}";
        }

        private void neworderbutton_Click(object sender, EventArgs e)
        {
            // how to reset
            this.Size = new Size(400, 479);
            shovelText.Text = "";
            carrotText.Text = "";
            radishText.Text = "";
            tenderedText.Text = "";
            subtotalLabel.Text = "";
            taxesLabel.Text = "";
            totalLabel.Text = "";
            changeLabel.Text = "";
            shovelText.Enabled = true;
            carrotText.Enabled = true;
            radishText.Enabled = true;
            tenderedText.Enabled = true;
            calculateButton.Enabled = true;
            changebutton.Enabled = true;
            printbutton.Enabled = true;
            receiptLabel.Hide();
            printbutton.Hide();
            neworderbutton.Hide();
        }
    }
}