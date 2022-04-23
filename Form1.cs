using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fnf_Character_Test_Moddable_Edition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }

        
        string playervar = "bf";
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gamebanana.com/members/2064554");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back.Visible = true;
        }
        int hmm = 1; 

        private void Form1_Load(object sender, EventArgs e)
        {
            WebRequest SiteyeBaglantiTalebi = HttpWebRequest.Create("https://github.com/EmreFnfGithub/versiongith/blob/main/version.txt");
            WebResponse GelenCevap = SiteyeBaglantiTalebi.GetResponse();
            StreamReader CevapOku = new StreamReader(GelenCevap.GetResponseStream());
            string KaynakKodlar = CevapOku.ReadToEnd();
            int IcerikBaslangicIndex = KaynakKodlar.IndexOf(label1.Text) + 4;
            int IcerikBitisIndex = KaynakKodlar.Substring(IcerikBaslangicIndex).IndexOf("</td>");

            label3.Text = (KaynakKodlar.Substring(IcerikBaslangicIndex, IcerikBitisIndex));
            Console.Read();

            stagelist.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Character Test\assets\stages\stageList.txt"));

            if (releasedver.Text == label3.Text)
            {

            }
            else
            {
                MessageBox.Show("New version is out! Please update...");
            }
            this.KeyPreview = true;
            //char list
            charlist.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Character Test\assets\characters\characterList.txt"));
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
            charpanel.Size = new Size(1031, 614);


            //note images
            left.Image = new Bitmap(@"C:\Character Test\assets\images\left.png");
            down.Image = new Bitmap(@"C:\Character Test\assets\images\down.png");
            up.Image = new Bitmap(@"C:\Character Test\assets\images\up.png");
            right.Image = new Bitmap(@"C:\Character Test\assets\images\right.png");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Left)
            {
                left.Image = new Bitmap(@"C:\Character Test\assets\images\leftshadow.png");
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\Left.gif");
                sp.SoundLocation = @"C:\Character Test\assets\songs\" + playervar + @"\left.wav";
                sp.Play();
            }

            if (e.KeyCode == Keys.Down)
            {
                down.Image = new Bitmap(@"C:\Character Test\assets\images\downshadow.png");
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\Down.gif");
                sp.SoundLocation = @"C:\Character Test\assets\songs\" + playervar + @"\down.wav";
                sp.Play();
            }

            if (e.KeyCode == Keys.Up)
            {
                up.Image = new Bitmap(@"C:\Character Test\assets\images\upshadow.png");
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\Up.gif");
                sp.SoundLocation = @"C:\Character Test\assets\songs\" + playervar + @"\up.wav";
                sp.Play();
            }

            if (e.KeyCode == Keys.Right)
            {
                right.Image = new Bitmap(@"C:\Character Test\assets\images\rightshadow.png");
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\Right.gif");
                sp.SoundLocation = @"C:\Character Test\assets\songs\" + playervar + @"\right.wav";
                sp.Play();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left.Image = new Bitmap(@"C:\Character Test\assets\images\left.png");
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
            }

            if (e.KeyCode == Keys.Down)
            {
                down.Image = new Bitmap(@"C:\Character Test\assets\images\down.png");
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
            }

            if (e.KeyCode == Keys.Up)
            {
                up.Image = new Bitmap(@"C:\Character Test\assets\images\up.png");
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
            }

            if (e.KeyCode == Keys.Right)
            {
                right.Image = new Bitmap(@"C:\Character Test\assets\images\right.png");
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            
        }

        private void left_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void left_MouseUp(object sender, MouseEventArgs e)
        {
            left.Image = new Bitmap(@"C:\Character Test\assets\images\left.png");
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");

        }

        private void left_MouseDown(object sender, MouseEventArgs e)
        {
            left.Image = new Bitmap(@"C:\Character Test\assets\images\leftshadow.png");
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\Left.gif");
            sp.SoundLocation = @"C:\Character Test\assets\songs\" + playervar + @"\left.wav";
            sp.Play();

        }

        private void down_MouseDown(object sender, MouseEventArgs e)
        {
            down.Image = new Bitmap(@"C:\Character Test\assets\images\downshadow.png");
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\Down.gif");
            sp.SoundLocation = @"C:\Character Test\assets\songs\" + playervar + @"\down.wav";
            sp.Play();
        }

        private void down_MouseUp(object sender, MouseEventArgs e)
        {
            down.Image = new Bitmap(@"C:\Character Test\assets\images\down.png");
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
        }

        private void up_MouseDown(object sender, MouseEventArgs e)
        {
            up.Image = new Bitmap(@"C:\Character Test\assets\images\upshadow.png");
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\Up.gif");
            sp.SoundLocation = @"C:\Character Test\assets\songs\" + playervar + @"\up.wav";
            sp.Play();
        }

        private void up_MouseUp(object sender, MouseEventArgs e)
        {
            up.Image = new Bitmap(@"C:\Character Test\assets\images\up.png");
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
        }

        private void right_MouseDown(object sender, MouseEventArgs e)
        {
            right.Image = new Bitmap(@"C:\Character Test\assets\images\rightshadow.png");
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\Right.gif");
            sp.SoundLocation = @"C:\Character Test\assets\songs\" + playervar + @"\right.wav";
            sp.Play();
        }

        private void right_MouseUp(object sender, MouseEventArgs e)
        {
            right.Image = new Bitmap(@"C:\Character Test\assets\images\right.png");
            playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            charlist.Items.Clear();
            charlist.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Character Test\assets\characters\characterList.txt"));
            charpanel.Size = new Size(1031, 614);
            charpanel.Dock = DockStyle.Fill;
            charpanel.Visible = true;
        }

        private void exitcharmenu_Click(object sender, EventArgs e)
        {
            charpanel.Visible = false;
        }

        private void charlist_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_DockChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            charpanel.Size = new Size(1031, 614);
            charpanel.Dock = DockStyle.Fill;
            charpanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            playervar = charlist.SelectedItem + "";
            if (File.Exists(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif"))
            {
                playerimage.Image = new Bitmap(@"C:\Character Test\assets\characters\" + playervar + @"\animations\idle.gif");
            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Character Test\assets\stages\" + stagelist.SelectedItem + @"\back.png"))
            {
                back.BackgroundImage = new Bitmap(@"C:\Character Test\assets\stages\" + stagelist.SelectedItem + @"\back.png");
                if(File.Exists(@"C:\Character Test\assets\stages\" + stagelist.SelectedItem + @"\front.png"))
                {
                    front.BackgroundImage = new Bitmap(@"C:\Character Test\assets\stages\" + stagelist.SelectedItem + @"\front.png");
                    front.Visible = true;
                }
                else
                {
                    front.Visible = true;
                    front.BackgroundImage = null;
                    front.BackColor = Color.Transparent;
                }
                
            }
            else
            {

            }
           
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            optionspanel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stagelist.Items.Clear();
            stagelist.Items.AddRange(System.IO.File.ReadAllLines(@"C:\Character Test\assets\stages\stageList.txt"));
            optionspanel.Dock = DockStyle.Fill;
            optionspanel.Visible = true;
        }
    }
}

//© EmreFnF
