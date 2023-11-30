using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayormenor
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = string.Empty;
            lbl2.Text = string.Empty;
            lbl1.Text = random.Next(1,49).ToString();
            lbl2.Text = random.Next(1,49).ToString();
        }

        private void btMenor_Click(object sender, EventArgs e)
        {
            txtEleccion.Text = "<";
            int num1 = int.Parse(lbl1.Text);
            int num2 = int.Parse(lbl2.Text);
            int numok = int.Parse(lblOk.Text);
            int numno = int.Parse(lblNo.Text);
            if (num1 < num2)
            {
                pbxImagen.ImageLocation = "./ok.jpg";
                SoundPlayer player = new SoundPlayer("./ok.wav");
                player.Play();
                numok++;
                lblOk.Text = numok.ToString();  
            }
            else
            {
                pbxImagen.ImageLocation = "./no.jpg";
                SoundPlayer player2 = new SoundPlayer("./no.wav");
                player2.Play();
                numno++;
                lblNo.Text = numno.ToString();
            }
        }

        private void pbxImagen_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            timer1.Start();
            btMenor.Enabled = false;
            btnIgual.Enabled = false;
            btnMayor.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Interval = 2000;
            pbxImagen.Image = null;
            lbl1.Text = string.Empty;
            lbl2.Text = string.Empty;
            lbl1.Text = random.Next(1, 49).ToString();
            lbl2.Text = random.Next(1, 49).ToString();
            txtEleccion.Text = string.Empty;
            timer1.Stop();
            btMenor.Enabled = true;
            btnIgual.Enabled= true;
            btnMayor .Enabled= true;
            txtEleccion.ReadOnly = true;
            txtEleccion.Cursor = Cursors.No;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            txtEleccion.Text = "=";
            int num1 = int.Parse(lbl1.Text);
            int num2 = int.Parse(lbl2.Text);
            int numok = int.Parse(lblOk.Text);
            int numno = int.Parse(lblNo.Text);
            if (num1 == num2)
            {
                pbxImagen.ImageLocation = "./ok.jpg";
                SoundPlayer player = new SoundPlayer("./ok.wav");
                player.Play();
                numok++;
                lblOk.Text = numok.ToString();
            }
            else
            {
                pbxImagen.ImageLocation = "./no.jpg";
                SoundPlayer player2 = new SoundPlayer("./no.wav");
                player2.Play();
                numno++;
                lblNo.Text = numno.ToString();
            }

        }

        private void btnMayor_Click(object sender, EventArgs e)
        {

            txtEleccion.Text = ">";
            int num1 = int.Parse(lbl1.Text);
            int num2 = int.Parse(lbl2.Text);
            int numok = int.Parse(lblOk.Text);
            int numno = int.Parse(lblNo.Text);
            if (num1 > num2)
            {
                pbxImagen.ImageLocation = "./ok.jpg";
                SoundPlayer player = new SoundPlayer("./ok.wav");
                player.Play();
                numok++;
                lblOk.Text = numok.ToString();
            }
            else
            {
                pbxImagen.ImageLocation = "./no.jpg";
                SoundPlayer player2 = new SoundPlayer("./no.wav");
                player2.Play();
                numno++;
                lblNo.Text = numno.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            
        }
    }
}
