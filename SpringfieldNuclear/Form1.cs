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

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reactor1StateLabel_Click(object sender, EventArgs e)
        {

        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer (Properties.Resources.alert);
            alertPlayer.Play();

            this.BackColor = Color.White;
            outputLabel.Text = "Meltdown Imminent";

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            

            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);


            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
        }
    }
}
