using FYS.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymbolicArt
{
    public partial class Main : FYS_Form
    {
        public Main()
        {
            InitializeComponent();

        }
        protected override CreateParams CreateParams  //Уберает мерцание всех элементов
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        Bitmap img = null;
        private void SelectImage_Click(object sender, EventArgs e)
        {
            if (ImageDialog.ShowDialog() != DialogResult.OK) return;
            img = new Bitmap(ImageDialog.FileName);
            pictureBox1.Image = img;
            ImageWidth.Maximum = img.Width;
            textBox2.Text = null;
        }
        Thread GenTheread;
        private void Generate_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                if (img != null)
                {
                    int imgwidth = img.Width;
                    if (ImageWidth.Enabled)
                        imgwidth = Convert.ToInt32(ImageWidth.Text);
                    GenTheread = new System.Threading.Thread(delegate() { M_Gen(img, imgwidth, OutputHTML.Checked); });
                    GenTheread.Start();
                }
                else
                    MessageDialog.ShowBoxOk("Выберите изображение на компьютере или вставьте ссылку!");
            }
            else
            {
                pictureBox1.Load(textBox2.Text);
                img = new Bitmap(pictureBox1.Image);
                int imgwidth = img.Width;
                if (ImageWidth.Enabled)
                    imgwidth = Convert.ToInt32(ImageWidth.Text);
                GenTheread = new System.Threading.Thread(delegate() { M_Gen(img, imgwidth, OutputHTML.Checked); });                
                GenTheread.Start();
            }

        }
                
        private static void M_Gen(Bitmap img, int imgwidth, bool status)
        {
            Application.OpenForms.OfType<Main>().Single().GeneratedText.BeginInvoke(new Action(() => { Application.OpenForms.OfType<Main>().Single().GeneratedText.Text = ConvertToSymbol.Generate(img, imgwidth, status); }));
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ImageWidth.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ImageWidth.Enabled = true;
        }
                
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (OutputHTML.Checked)
            {
                OutputHTML.Text = "Да";
            }
            else
                OutputHTML.Text = "Нет";
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //if (files[0])
            img = new Bitmap(Image.FromFile(files[0]));
            pictureBox1.Image = img;
            ImageWidth.Maximum = img.Width;
            textBox2.Text = null;
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string fileType = Path.GetExtension(files[0]).ToLower();
            if (fileType == ".png" || fileType == ".pns" || fileType == ".jpg" || fileType == ".jpeg" || fileType == ".jpe" || fileType == ".bmp" || fileType == ".rle" || fileType == ".dip")
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void GeneratedText_TextChanged(object sender, EventArgs e)
        {
            Text = String.Format("Преобразователь изображения в символы | Использовано {0} символов", (sender as RichTextBox).Text.Length.ToString());
            GenTheread.Abort();
        }
    }
}