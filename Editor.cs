using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fnf_Character_Test_Moddable_Edition
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        
        OpenFileDialog selectanims = new OpenFileDialog();
        OpenFileDialog selectstages = new OpenFileDialog();
        private void button4_Click(object sender, EventArgs e)
        {
            charaddstep.Visible = true;
            charaddstep.Dock = DockStyle.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\");

            FileInfo fi = new FileInfo(pictureBox1.ImageLocation);
            fi.CopyTo(@"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi.Name);

            string move1 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi.Name;
            string move2 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + "idle.gif";
            File.Move(move1, move2);

            FileInfo fi2 = new FileInfo(Down.ImageLocation);
            fi2.CopyTo(@"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi2.Name);

            string move21 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi2.Name;
            string move22 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + "Down.gif";
            File.Move(move21, move22);

            FileInfo fi3 = new FileInfo(Right.ImageLocation);
            fi3.CopyTo(@"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi3.Name);

            string move31 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi3.Name;
            string move32 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + "Right.gif";

            File.Move(move31, move32);

            FileInfo fi4 = new FileInfo(Left.ImageLocation);
            fi4.CopyTo(@"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi4.Name);

            string move41 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi4.Name;
            string move42 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + "Left.gif";

            File.Move(move41, move42);

            FileInfo fi5 = new FileInfo(Up.ImageLocation);
            fi5.CopyTo(@"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi5.Name);

            string move51 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + fi5.Name;
            string move52 = @"C:\Character Test\assets\characters\" + textBox1.Text + @"\animations\" + "Up.gif";

            File.Move(move51, move52);

            StreamWriter yess = File.AppendText(@"C:\Character Test\assets\characters\characterList.txt");
            string yess2 = textBox1.Text;
            yess.WriteLine(yess2);
            yess.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectanims.Title = "Character Test Moddable";
            selectanims.ShowDialog();
            string Hmmmm = selectanims.FileName;
            pictureBox1.ImageLocation = Hmmmm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectanims.Title = "Character Test Moddable";
            selectanims.ShowDialog();
            string Hmmmm = selectanims.FileName;
            Down.ImageLocation = Hmmmm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectanims.Title = "Character Test Moddable";
            selectanims.ShowDialog();
            string Hmmmm = selectanims.FileName;
            Right.ImageLocation = Hmmmm;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectanims.Title = "Character Test Moddable";
            selectanims.ShowDialog();
            string Hmmmm = selectanims.FileName;
            Left.ImageLocation = Hmmmm;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectanims.Title = "Character Test Moddable";
            selectanims.ShowDialog();
            string Hmmmm = selectanims.FileName;
            Up.ImageLocation = Hmmmm;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stageeditor.Dock = DockStyle.Fill;
            stageeditor.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectstages.Title = "Character Test Moddable";
            selectstages.ShowDialog();
            string Hmmmm = selectstages.FileName;
            back.ImageLocation = Hmmmm;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectstages.Title = "Character Test Moddable";
            selectstages.ShowDialog();
            string Hmmmm2 = selectstages.FileName;
            front.ImageLocation = Hmmmm2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Character Test\assets\stages\" + textBox2.Text + @"\");

            FileInfo fi = new FileInfo(back.ImageLocation);
            fi.CopyTo(@"C:\Character Test\assets\stages\" + textBox2.Text + @"\" + fi.Name);

            string move1 = @"C:\Character Test\assets\stages\" + textBox2.Text + @"\" + fi.Name;
            string move2 = @"C:\Character Test\assets\stages\" + textBox2.Text + @"\back.png";
            File.Move(move1, move2);

            if(front.Image == null)
            {
               
            }
            else
            {
                FileInfo fi2 = new FileInfo(front.ImageLocation);
                fi2.CopyTo(@"C:\Character Test\assets\stages\" + textBox2.Text + @"\" + fi2.Name);

                string move21 = @"C:\Character Test\assets\stages\" + textBox2.Text + @"\" + fi2.Name;
                string move22 = @"C:\Character Test\assets\stages\" + textBox2.Text + @"\front.png";
                File.Move(move21, move22);
            }
           

            StreamWriter yess = File.AppendText(@"C:\Character Test\assets\stages\stageList.txt");
            string yess2 = textBox2.Text;
            yess.WriteLine(yess2);
            yess.Close();
        }
    }
}
