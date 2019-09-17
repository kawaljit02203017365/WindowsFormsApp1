using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1

{
    public partial class Formplaygame : Form
    {
        public Formplaygame()
        {
            InitializeComponent();
        }
        RussianRoulleteclass objRussianRoullete = new RussianRoulleteclass();
        
        private object rr_game;

        private void Formplaygame_Load(object sender, EventArgs e)
        {
            btgunspin.Enabled = false;
            btgunshootaway.Enabled = false;
            Btshoot.Enabled = false;
            btgunspin.Enabled = false;
        }

        private void btreload_Click(object sender, EventArgs e)
        {
            (new Formplaygame()).Show();
            this.Close();
        }

        //  The below button will enable the gun to spin.
        private void btgunload_Click(object sender, EventArgs e)
        {
            objRussianRoullete.load();
            btgunspin.Enabled = true;
            btgunload.Enabled = false;
            //videoplayer.Image = Image.FromFile(@"C:\Users\sunny\source\repos\russian Rollete 1\Russian Rollete\Res\load.gif");
            videoplayer.Image = WindowsFormsApp1.Properties.Resources.gun2;
            System.IO.Stream str = WindowsFormsApp1.Properties.Resources.load;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            //Bitmap bmp = new Bitmap(myStream);
            //pic_box_main.Image = bmp;
            //coding for sounds//
            videoplayer.Image = WindowsFormsApp1.Properties.Resources.main;

            //SoundPlayer player = new SoundPlayer(rr_game.Properties.Resources.spin);
            //player.Play()
        }

        private void btgunspin_Click(object sender, EventArgs e)
        {
            objRussianRoullete.spin();
            btgunspin.Enabled = false;
            btgunshootaway.Enabled = true;
            Btshoot.Enabled = true;
            videoplayer.Image = WindowsFormsApp1.Properties.Resources._1;
            System.IO.Stream str = WindowsFormsApp1.Properties.Resources.shoot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

        }
         
        private void Btshoot_Click(object sender, EventArgs e)
        {
            videoplayer.Image = WindowsFormsApp1.Properties.Resources._3;
            System.IO.Stream str = WindowsFormsApp1.Properties.Resources.shoot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            objRussianRoullete.looseGame = objRussianRoullete.shootbullet();
            if (objRussianRoullete.looseGame == true)
            {
                MessageBox.Show("Sorry! you loose the game");
                btgunshootaway.Enabled = false;
                Btshoot.Enabled = false;

            }
            else
            {
                MessageBox.Show("Shot missed");
            }
        }

        private void btgunshootaway_Click(object sender, EventArgs e)
        {
            videoplayer.Image = WindowsFormsApp1.Properties.Resources._2;
            System.IO.Stream str = WindowsFormsApp1.Properties.Resources.shoot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            objRussianRoullete.WinningGame = objRussianRoullete.shootbullet();
           
            if (objRussianRoullete.WinningGame == true && objRussianRoullete.totalshottofire<=2)
            {
                MessageBox.Show("you won the game and score = $100");
                btgunshootaway.Enabled = false;
                Btshoot.Enabled = false;
            }
            else if(objRussianRoullete.WinningGame == false && objRussianRoullete.totalshottofire>=2)
            {
                MessageBox.Show("Sorry! you loose the game");
                btgunshootaway.Enabled = false;
                Btshoot.Enabled = false;
            }
            else
            {
                MessageBox.Show("Shot missed");
                objRussianRoullete.totalshottofire++;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
