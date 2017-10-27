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
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

namespace FightClub
{
    public partial class Game : Form
    {
        const int maxhp = 100;
       int[] damage = { 10, 9, 8 };

        LoginPlayer lp = new LoginPlayer();
        Fighter Player;
        Computer Comp;

        WMPLib.WindowsMediaPlayer Music = new WMPLib.WindowsMediaPlayer();
        bool sound = true;

        // Microsoft.DirectX.AudioVideoPlayback.Video video;

        int countRound = 1;
        string Log = @"LogFile.txt";
        string mess;
        bool yourmove = true;
        int counthit = 1;

        public Game(LoginPlayer lp)
        {
            Music.URL = @"Music.mp3";
            InitializeComponent();
            this.lp = lp;
            Player = new Fighter(lp.NamePlayer, maxhp);
            Comp = new Computer(maxhp);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            lbPlayer1.Text = Player.Name;
            lbPlayer2.Text = Comp.Name;
            lbHP1.Text = Player.HP.ToString();
            lbHP2.Text = Comp.HP.ToString();
            progressBarPlayer1.Maximum = Player.HP;
            progressBarPlayer2.Maximum = Comp.HP;
            progressBarPlayer1.Value = Player.HP;
            progressBarPlayer2.Value = Comp.HP;
            lbRound.Text = "Round: " + countRound;
            lbTurn.Text = "You strike\n(select one part of stickman's body)";
            Player.Block += Block;
            Player.Death += Death;
            Player.Wound += Wound;
            Comp.Block += Block;
            Comp.Death += Death;
            Comp.Wound += Wound;
            

        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            if (sound)
                Music.controls.stop();
            else
                Music.controls.play();
            sound = !sound;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"Help.txt", Encoding.UTF8);
            MessageBox.Show(text);
        }
        private void LetIshowsomething( string path)
        {
            pictureBoxJim.ImageLocation = path;
            pictureBoxJim.Visible = true;
            timer1.Enabled = true;
        }
        private void Death(string name, int hp)
        {
            mess = lbRound.Text+ "\n Fighter " +name+ " are dead... but not Deadpool,  unfortunately \n";
            ToLog(mess);
            if(Player.Name != name)
                MessageBox.Show(Player.Name + " win, if want play again tip Reset");
            else
                MessageBox.Show(Comp.Name + " win, if want play again tip Reset");
            buttonBody.Enabled = false;
            buttonHead.Enabled = false;
            buttonLegs.Enabled = false;
            WriteHP();
        }
        private void Wound(string name, int hp)
        {
            mess = lbRound.Text+ "\n Fighter " + name + " struck in the nose,  but did not give up. But mow fighter  have "+ hp + " HP \n";
            ToLog(mess);
            WriteHP();
            Turn();
        }
        private void Block(string name, int hp)
        {
            mess = lbRound.Text+ "\n Fighter " + name + " blocked. You are filled with determination \n";
            ToLog(mess);
            Turn();
        }
        private void WriteHP()
        {
            lbHP1.Text = Player.HP.ToString();
            lbHP2.Text = Comp.HP.ToString();
            if (Player.HP > 0)
                progressBarPlayer1.Value = Player.HP;
            else
                progressBarPlayer1.Value = 0;
            if(Comp.HP > 0)
                progressBarPlayer2.Value = Comp.HP;
            else
                progressBarPlayer2.Value = 0;
        }
        private void ToLog(string mess)
        {
            dataGridView1.Rows.Add(mess);
            if (lp.LogToFile)
                System.IO.File.AppendAllText(Log, mess, Encoding.UTF8);
        }
        private void Turn()
        {
            if (yourmove)
            {
                lbTurn.Text = "You strike\n(select one part of stickman's body)";
            }
            else
            {
                lbTurn.Text = "You block your life\n(select one part of stickman's body)";
            }

            countRound++;

            lbRound.Text = "Round: " + countRound;

            if (counthit > lp.Hits)
            {
                yourmove = !yourmove;
                counthit = 0;
            }

            counthit++;
        }

        private void buttonHead_Click(object sender, EventArgs e)
        {
            /*video = new Microsoft.DirectX.AudioVideoPlayback.Video(@"Jim.mp4");
           video.Open(@"Jim.mp4");
           video.Owner = panelVideo;
           video.Play();*/
           // pictureBoxJim.Visible = true;
            if (yourmove)
            {
                switch ((sender as Button).Name)
                {
                    case "buttonHead":
                        Comp.GetHit(PartOfBody.Head, damage[0]);
                        LetIshowsomething(@"images/Hit.gif");
                        break;
                    case "buttonBody":
                        Comp.GetHit(PartOfBody.Body, damage[1]);
                        LetIshowsomething(@"images/Hit1.gif");
                        break;
                    case "buttonLegs":
                        Comp.GetHit(PartOfBody.Legs, damage[2]);
                        LetIshowsomething(@"images/Hit2.gif");
                        break;
                }
            }
            else
            {
                switch ((sender as Button).Name)
                {
                    case "buttonHead":
                        Player.SetBlock(PartOfBody.Head);
                        Player.GetHit(Comp.SetHit(), damage[0]);
                        LetIshowsomething(@"images/Hit7.gif");
                        break;
                    case "buttonBody":
                        Player.SetBlock(PartOfBody.Body);
                        Player.GetHit(Comp.SetHit(), damage[1]);
                        LetIshowsomething(@"images/Jim.gif");
                        break;
                    case "buttonLegs":
                        Player.SetBlock(PartOfBody.Legs);
                        Player.GetHit(Comp.SetHit(), damage[2]);
                        LetIshowsomething(@"images/Sad.gif");
                        break;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Player = new Fighter(lp.NamePlayer, maxhp);
            Comp = new Computer(maxhp);
            lbPlayer1.Text = Player.Name;
            lbPlayer2.Text = Comp.Name;
            lbHP1.Text = Player.HP.ToString();
            lbHP2.Text = Comp.HP.ToString();
            progressBarPlayer1.Maximum = Player.HP;
            progressBarPlayer2.Maximum = Comp.HP;
            progressBarPlayer1.Value = Player.HP;
            progressBarPlayer2.Value = Comp.HP;
            countRound = 1;
            lbRound.Text = "Round: " + countRound;
            lbTurn.Text = "You strike\n(select one part of stickman's body)";
            Player.Block += Block;
            Player.Death += Death;
            Player.Wound += Wound;
            Comp.Block += Block;
            Comp.Death += Death;
            Comp.Wound += Wound;
            buttonBody.Enabled = true;
            buttonHead.Enabled = true;
            buttonLegs.Enabled = true;
            dataGridView1.RowCount = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxJim.Visible = false;
            pictureBoxJim.ImageLocation = "";
        }
    }
}
