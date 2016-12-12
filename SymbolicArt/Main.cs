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

            pictureBox1.Image = new Bitmap(ImageDialog.FileName); 
            img = new Bitmap(pictureBox1.Image);
            ImageWidth.Maximum = img.Width;
            textBox2.Text = null;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {

                if (img != null)
                {
                    Task T = Task.Factory.StartNew(() =>
                        {
                            int imgwidth = img.Width;
                            if (ImageWidth.Enabled)
                                imgwidth = Convert.ToInt32(ImageWidth.Text);
                            _L_Status.BeginInvoke(new Action(() => { _L_Status.Text = "Приобразование в символы"; }));
                            ConvertToSymbol.Generate(this, GeneratedText, (Bitmap)img.Clone(), imgwidth, OutputHTML.Checked);
                        });
                }
                else
                    MessageDialog.ShowBoxOk("Выберите изображение на компьютере или вставьте ссылку!");
            }
            else
            {
                Task T = Task.Factory.StartNew(() =>
                {
                    _L_Status.BeginInvoke(new Action(() => { _L_Status.Text = "Загрузка изображения"; }));
                    pictureBox1.Load(textBox2.Text);
                    img = new Bitmap(pictureBox1.Image);
                    int imgwidth = img.Width;
                    if (ImageWidth.Enabled)
                        imgwidth = Convert.ToInt32(ImageWidth.Text);
                    _L_Status.BeginInvoke(new Action(() => { _L_Status.Text = "Приобразование в символы"; }));
                    Task.Factory.StartNew(() =>
                    {
                        ConvertToSymbol.Generate(this, GeneratedText, (Bitmap)img.Clone(), imgwidth, OutputHTML.Checked);
                    });
                });
            }
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
            _L_Status.Text = String.Format("Использовано {0} символов", (sender as Control).Text.Length.ToString());
        }
    }
}