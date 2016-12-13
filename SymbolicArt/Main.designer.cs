namespace SymbolicArt
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this._PB_Load = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.GeneratedText = new System.Windows.Forms.RichTextBox();
            this._P_Configure = new System.Windows.Forms.Panel();
            this.OutputHTML = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._TB_URL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._TB_Symbols = new System.Windows.Forms.TextBox();
            this.ImageWidth = new System.Windows.Forms.NumericUpDown();
            this._RB_No = new System.Windows.Forms.RadioButton();
            this._RB_Yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectImage = new FYS.Windows.Cotrols.FYS_Button();
            this.Generate = new FYS.Windows.Cotrols.FYS_Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._L_Status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PB_Load)).BeginInit();
            this._P_Configure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageDialog
            // 
            this.ImageDialog.Filter = "PNG|*.png;*.pns|Изображение JPG|*.jpg;*.jpeg;*.jpe|BMP|*.bmp;*.RLE;*.dip|Все изоб" +
    "ражения|*.png;*.pns;*.jpg;*.jpeg;*.jpe;*.bmp;*.rle;*.dip";
            this.ImageDialog.Title = "Выберите изображение";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 450);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._PB_Load);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Controls.Add(this.GeneratedText);
            this.panel4.Controls.Add(this._P_Configure);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(696, 450);
            this.panel4.TabIndex = 2;
            // 
            // _PB_Load
            // 
            this._PB_Load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._PB_Load.Enabled = false;
            this._PB_Load.Image = global::SymbolicArt.Properties.Resources.loading;
            this._PB_Load.Location = new System.Drawing.Point(424, 167);
            this._PB_Load.Name = "_PB_Load";
            this._PB_Load.Size = new System.Drawing.Size(128, 128);
            this._PB_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._PB_Load.TabIndex = 15;
            this._PB_Load.TabStop = false;
            this._PB_Load.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(250, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // GeneratedText
            // 
            this.GeneratedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneratedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratedText.Font = new System.Drawing.Font("Consolas", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GeneratedText.Location = new System.Drawing.Point(250, 0);
            this.GeneratedText.Name = "GeneratedText";
            this.GeneratedText.Size = new System.Drawing.Size(446, 450);
            this.GeneratedText.TabIndex = 7;
            this.GeneratedText.Text = "";
            this.GeneratedText.WordWrap = false;
            this.GeneratedText.TextChanged += new System.EventHandler(this.GeneratedText_TextChanged);
            // 
            // _P_Configure
            // 
            this._P_Configure.Controls.Add(this.OutputHTML);
            this._P_Configure.Controls.Add(this.label4);
            this._P_Configure.Controls.Add(this.label5);
            this._P_Configure.Controls.Add(this._TB_URL);
            this._P_Configure.Controls.Add(this.label3);
            this._P_Configure.Controls.Add(this._TB_Symbols);
            this._P_Configure.Controls.Add(this.ImageWidth);
            this._P_Configure.Controls.Add(this._RB_No);
            this._P_Configure.Controls.Add(this._RB_Yes);
            this._P_Configure.Controls.Add(this.label2);
            this._P_Configure.Controls.Add(this.label1);
            this._P_Configure.Controls.Add(this.SelectImage);
            this._P_Configure.Controls.Add(this.Generate);
            this._P_Configure.Controls.Add(this.pictureBox1);
            this._P_Configure.Dock = System.Windows.Forms.DockStyle.Left;
            this._P_Configure.Location = new System.Drawing.Point(0, 0);
            this._P_Configure.MinimumSize = new System.Drawing.Size(250, 300);
            this._P_Configure.Name = "_P_Configure";
            this._P_Configure.Size = new System.Drawing.Size(250, 450);
            this._P_Configure.TabIndex = 6;
            // 
            // OutputHTML
            // 
            this.OutputHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutputHTML.AutoSize = true;
            this.OutputHTML.Location = new System.Drawing.Point(25, 392);
            this.OutputHTML.Name = "OutputHTML";
            this.OutputHTML.Size = new System.Drawing.Size(45, 17);
            this.OutputHTML.TabIndex = 9;
            this.OutputHTML.Text = "Нет";
            this.OutputHTML.UseVisualStyleBackColor = true;
            this.OutputHTML.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Преобразовать в HTML:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ссылка на картинку:";
            // 
            // _TB_URL
            // 
            this._TB_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TB_URL.Location = new System.Drawing.Point(25, 202);
            this._TB_URL.Name = "_TB_URL";
            this._TB_URL.Size = new System.Drawing.Size(210, 20);
            this._TB_URL.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Используемые символы:";
            // 
            // _TB_Symbols
            // 
            this._TB_Symbols.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TB_Symbols.Location = new System.Drawing.Point(25, 249);
            this._TB_Symbols.Name = "_TB_Symbols";
            this._TB_Symbols.Size = new System.Drawing.Size(210, 20);
            this._TB_Symbols.TabIndex = 13;
            this._TB_Symbols.Text = "##@%=+*:-..1,0";
            // 
            // ImageWidth
            // 
            this.ImageWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageWidth.Enabled = false;
            this.ImageWidth.Location = new System.Drawing.Point(25, 344);
            this.ImageWidth.Maximum = new decimal(new int[] {
            258,
            0,
            0,
            0});
            this.ImageWidth.Name = "ImageWidth";
            this.ImageWidth.Size = new System.Drawing.Size(100, 20);
            this.ImageWidth.TabIndex = 12;
            this.ImageWidth.Value = new decimal(new int[] {
            258,
            0,
            0,
            0});
            // 
            // _RB_No
            // 
            this._RB_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._RB_No.AutoSize = true;
            this._RB_No.Checked = true;
            this._RB_No.Location = new System.Drawing.Point(25, 298);
            this._RB_No.Name = "_RB_No";
            this._RB_No.Size = new System.Drawing.Size(44, 17);
            this._RB_No.TabIndex = 10;
            this._RB_No.TabStop = true;
            this._RB_No.Text = "Нет";
            this._RB_No.UseVisualStyleBackColor = true;
            this._RB_No.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // _RB_Yes
            // 
            this._RB_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._RB_Yes.AutoSize = true;
            this._RB_Yes.Location = new System.Drawing.Point(80, 298);
            this._RB_Yes.Name = "_RB_Yes";
            this._RB_Yes.Size = new System.Drawing.Size(40, 17);
            this._RB_Yes.TabIndex = 10;
            this._RB_Yes.Text = "Да";
            this._RB_Yes.UseVisualStyleBackColor = true;
            this._RB_Yes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 318);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ширина:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 272);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Изменить размер: ";
            // 
            // SelectImage
            // 
            this.SelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectImage.AutoSize = true;
            this.SelectImage.BackColor = System.Drawing.Color.SteelBlue;
            this.SelectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectImage.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.SelectImage.FlatAppearance.BorderSize = 0;
            this.SelectImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SelectImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.SelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectImage.ForeColor = System.Drawing.Color.White;
            this.SelectImage.Location = new System.Drawing.Point(0, 146);
            this.SelectImage.Margin = new System.Windows.Forms.Padding(0);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(250, 29);
            this.SelectImage.TabIndex = 7;
            this.SelectImage.Text = "Выбрать изображение";
            this.SelectImage.UseVisualStyleBackColor = false;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.SteelBlue;
            this.Generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Generate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Generate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Generate.FlatAppearance.BorderSize = 0;
            this.Generate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Generate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.ForeColor = System.Drawing.Color.White;
            this.Generate.Location = new System.Drawing.Point(0, 420);
            this.Generate.Margin = new System.Windows.Forms.Padding(0);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(250, 30);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Преобразовать";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // _L_Status
            // 
            this._L_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._L_Status.AutoSize = true;
            this._L_Status.BackColor = System.Drawing.SystemColors.WindowFrame;
            this._L_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this._L_Status.ForeColor = System.Drawing.Color.White;
            this._L_Status.Location = new System.Drawing.Point(10, 481);
            this._L_Status.Name = "_L_Status";
            this._L_Status.Size = new System.Drawing.Size(410, 17);
            this._L_Status.TabIndex = 9;
            this._L_Status.Text = "Выберите изображение на компьютере или вставьте ссылку";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this._L_Status);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Main";
            this.Text = "Преобразователь изображения в символы";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this._L_Status, 0);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PB_Load)).EndInit();
            this._P_Configure.ResumeLayout(false);
            this._P_Configure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImageDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel _P_Configure;
        private FYS.Windows.Cotrols.FYS_Button SelectImage;
        private FYS.Windows.Cotrols.FYS_Button Generate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton _RB_No;
        private System.Windows.Forms.RadioButton _RB_Yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown ImageWidth;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox _TB_Symbols;
        private System.Windows.Forms.CheckBox OutputHTML;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox _TB_URL;
        private System.Windows.Forms.Label _L_Status;
        public System.Windows.Forms.RichTextBox GeneratedText;
        private System.Windows.Forms.PictureBox _PB_Load;
    }
}

