
namespace Arcanum
{
    partial class Arcanum
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arcanum));
            this.logo = new System.Windows.Forms.PictureBox();
            this.introductionTxt = new System.Windows.Forms.RichTextBox();
            this.soundBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.muteBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.numb = new System.Windows.Forms.Label();
            this.zodiac = new System.Windows.Forms.Label();
            this.numberTxt = new System.Windows.Forms.RichTextBox();
            this.zodiacTxt = new System.Windows.Forms.RichTextBox();
            this.aries = new System.Windows.Forms.PictureBox();
            this.aquarius = new System.Windows.Forms.PictureBox();
            this.cancer = new System.Windows.Forms.PictureBox();
            this.capricorn = new System.Windows.Forms.PictureBox();
            this.gemini = new System.Windows.Forms.PictureBox();
            this.leo = new System.Windows.Forms.PictureBox();
            this.libra = new System.Windows.Forms.PictureBox();
            this.pisces = new System.Windows.Forms.PictureBox();
            this.sagittarius = new System.Windows.Forms.PictureBox();
            this.scorpio = new System.Windows.Forms.PictureBox();
            this.taurus = new System.Windows.Forms.PictureBox();
            this.virgo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquarius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capricorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pisces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagittarius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scorpio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taurus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virgo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Arcanum.Properties.Resources.logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(203, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(575, 234);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // introductionTxt
            // 
            this.introductionTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.introductionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.introductionTxt.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.introductionTxt.ForeColor = System.Drawing.Color.White;
            this.introductionTxt.Location = new System.Drawing.Point(203, 278);
            this.introductionTxt.Name = "introductionTxt";
            this.introductionTxt.Size = new System.Drawing.Size(575, 93);
            this.introductionTxt.TabIndex = 2;
            this.introductionTxt.Text = resources.GetString("introductionTxt.Text");
            this.introductionTxt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // soundBtn
            // 
            this.soundBtn.BackgroundImage = global::Arcanum.Properties.Resources.volume;
            this.soundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.soundBtn.Location = new System.Drawing.Point(953, 486);
            this.soundBtn.Name = "soundBtn";
            this.soundBtn.Size = new System.Drawing.Size(41, 40);
            this.soundBtn.TabIndex = 3;
            this.soundBtn.UseVisualStyleBackColor = true;
            this.soundBtn.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = global::Arcanum.Properties.Resources.close;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.exitBtn.Location = new System.Drawing.Point(953, 24);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(41, 40);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // muteBtn
            // 
            this.muteBtn.BackgroundImage = global::Arcanum.Properties.Resources.mute;
            this.muteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.muteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.muteBtn.Location = new System.Drawing.Point(953, 486);
            this.muteBtn.Name = "muteBtn";
            this.muteBtn.Size = new System.Drawing.Size(41, 40);
            this.muteBtn.TabIndex = 5;
            this.muteBtn.UseVisualStyleBackColor = true;
            this.muteBtn.Click += new System.EventHandler(this.muteBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.startBtn.BackgroundImage = global::Arcanum.Properties.Resources.start;
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.startBtn.Location = new System.Drawing.Point(424, 377);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(129, 121);
            this.startBtn.TabIndex = 1;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // birthday
            // 
            this.birthday.CalendarFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthday.CalendarForeColor = System.Drawing.Color.White;
            this.birthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.birthday.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.birthday.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.birthday.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.birthday.Cursor = System.Windows.Forms.Cursors.Default;
            this.birthday.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthday.Location = new System.Drawing.Point(354, 332);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(322, 26);
            this.birthday.TabIndex = 6;
            this.birthday.Value = new System.DateTime(2021, 5, 24, 17, 5, 10, 0);
            this.birthday.ValueChanged += new System.EventHandler(this.birthday_ValueChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Yusei Magic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(399, 252);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(256, 54);
            this.date.TabIndex = 7;
            this.date.Text = "Date of Birth";
            // 
            // calculate
            // 
            this.calculate.BackgroundImage = global::Arcanum.Properties.Resources.calculate;
            this.calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.calculate.Location = new System.Drawing.Point(424, 378);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(129, 120);
            this.calculate.TabIndex = 8;
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::Arcanum.Properties.Resources.previous;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.backBtn.Location = new System.Drawing.Point(26, 485);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(41, 40);
            this.backBtn.TabIndex = 9;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // numb
            // 
            this.numb.AutoSize = true;
            this.numb.Font = new System.Drawing.Font("Yusei Magic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numb.ForeColor = System.Drawing.Color.White;
            this.numb.Location = new System.Drawing.Point(655, 249);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(0, 54);
            this.numb.TabIndex = 10;
            // 
            // zodiac
            // 
            this.zodiac.AutoSize = true;
            this.zodiac.Font = new System.Drawing.Font("Yusei Magic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zodiac.ForeColor = System.Drawing.Color.White;
            this.zodiac.Location = new System.Drawing.Point(319, 249);
            this.zodiac.Name = "zodiac";
            this.zodiac.Size = new System.Drawing.Size(0, 54);
            this.zodiac.TabIndex = 11;
            // 
            // numberTxt
            // 
            this.numberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.numberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberTxt.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberTxt.ForeColor = System.Drawing.Color.White;
            this.numberTxt.Location = new System.Drawing.Point(635, 331);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(261, 194);
            this.numberTxt.TabIndex = 12;
            this.numberTxt.Text = "";
            // 
            // zodiacTxt
            // 
            this.zodiacTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.zodiacTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zodiacTxt.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zodiacTxt.ForeColor = System.Drawing.Color.White;
            this.zodiacTxt.Location = new System.Drawing.Point(304, 331);
            this.zodiacTxt.Name = "zodiacTxt";
            this.zodiacTxt.Size = new System.Drawing.Size(261, 194);
            this.zodiacTxt.TabIndex = 13;
            this.zodiacTxt.Text = "";
            // 
            // aries
            // 
            this.aries.BackgroundImage = global::Arcanum.Properties.Resources.aries;
            this.aries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aries.Location = new System.Drawing.Point(38, 227);
            this.aries.Name = "aries";
            this.aries.Size = new System.Drawing.Size(224, 218);
            this.aries.TabIndex = 14;
            this.aries.TabStop = false;
            // 
            // aquarius
            // 
            this.aquarius.BackgroundImage = global::Arcanum.Properties.Resources.aquarius;
            this.aquarius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aquarius.Location = new System.Drawing.Point(38, 227);
            this.aquarius.Name = "aquarius";
            this.aquarius.Size = new System.Drawing.Size(224, 218);
            this.aquarius.TabIndex = 15;
            this.aquarius.TabStop = false;
            // 
            // cancer
            // 
            this.cancer.BackgroundImage = global::Arcanum.Properties.Resources.cancer;
            this.cancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancer.Location = new System.Drawing.Point(38, 227);
            this.cancer.Name = "cancer";
            this.cancer.Size = new System.Drawing.Size(224, 218);
            this.cancer.TabIndex = 16;
            this.cancer.TabStop = false;
            // 
            // capricorn
            // 
            this.capricorn.BackgroundImage = global::Arcanum.Properties.Resources.capricorn;
            this.capricorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.capricorn.Location = new System.Drawing.Point(38, 227);
            this.capricorn.Name = "capricorn";
            this.capricorn.Size = new System.Drawing.Size(224, 218);
            this.capricorn.TabIndex = 17;
            this.capricorn.TabStop = false;
            // 
            // gemini
            // 
            this.gemini.BackgroundImage = global::Arcanum.Properties.Resources.gemini;
            this.gemini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gemini.Location = new System.Drawing.Point(38, 227);
            this.gemini.Name = "gemini";
            this.gemini.Size = new System.Drawing.Size(224, 218);
            this.gemini.TabIndex = 18;
            this.gemini.TabStop = false;
            // 
            // leo
            // 
            this.leo.BackgroundImage = global::Arcanum.Properties.Resources.leo;
            this.leo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leo.Location = new System.Drawing.Point(38, 227);
            this.leo.Name = "leo";
            this.leo.Size = new System.Drawing.Size(224, 218);
            this.leo.TabIndex = 19;
            this.leo.TabStop = false;
            // 
            // libra
            // 
            this.libra.BackgroundImage = global::Arcanum.Properties.Resources.libra;
            this.libra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.libra.Location = new System.Drawing.Point(38, 227);
            this.libra.Name = "libra";
            this.libra.Size = new System.Drawing.Size(224, 218);
            this.libra.TabIndex = 20;
            this.libra.TabStop = false;
            // 
            // pisces
            // 
            this.pisces.BackgroundImage = global::Arcanum.Properties.Resources.pisces;
            this.pisces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pisces.Location = new System.Drawing.Point(38, 227);
            this.pisces.Name = "pisces";
            this.pisces.Size = new System.Drawing.Size(224, 218);
            this.pisces.TabIndex = 21;
            this.pisces.TabStop = false;
            // 
            // sagittarius
            // 
            this.sagittarius.BackgroundImage = global::Arcanum.Properties.Resources.sagittarius;
            this.sagittarius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sagittarius.Location = new System.Drawing.Point(38, 227);
            this.sagittarius.Name = "sagittarius";
            this.sagittarius.Size = new System.Drawing.Size(224, 218);
            this.sagittarius.TabIndex = 22;
            this.sagittarius.TabStop = false;
            // 
            // scorpio
            // 
            this.scorpio.BackgroundImage = global::Arcanum.Properties.Resources.scorpio;
            this.scorpio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scorpio.Location = new System.Drawing.Point(38, 227);
            this.scorpio.Name = "scorpio";
            this.scorpio.Size = new System.Drawing.Size(224, 218);
            this.scorpio.TabIndex = 23;
            this.scorpio.TabStop = false;
            // 
            // taurus
            // 
            this.taurus.BackgroundImage = global::Arcanum.Properties.Resources.taurus;
            this.taurus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.taurus.Location = new System.Drawing.Point(38, 227);
            this.taurus.Name = "taurus";
            this.taurus.Size = new System.Drawing.Size(224, 218);
            this.taurus.TabIndex = 24;
            this.taurus.TabStop = false;
            // 
            // virgo
            // 
            this.virgo.BackgroundImage = global::Arcanum.Properties.Resources.virgo;
            this.virgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.virgo.Location = new System.Drawing.Point(38, 227);
            this.virgo.Name = "virgo";
            this.virgo.Size = new System.Drawing.Size(224, 218);
            this.virgo.TabIndex = 25;
            this.virgo.TabStop = false;
            // 
            // Arcanum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(31)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1016, 556);
            this.Controls.Add(this.virgo);
            this.Controls.Add(this.taurus);
            this.Controls.Add(this.scorpio);
            this.Controls.Add(this.sagittarius);
            this.Controls.Add(this.pisces);
            this.Controls.Add(this.libra);
            this.Controls.Add(this.leo);
            this.Controls.Add(this.gemini);
            this.Controls.Add(this.capricorn);
            this.Controls.Add(this.cancer);
            this.Controls.Add(this.aquarius);
            this.Controls.Add(this.aries);
            this.Controls.Add(this.zodiacTxt);
            this.Controls.Add(this.numberTxt);
            this.Controls.Add(this.zodiac);
            this.Controls.Add(this.numb);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.muteBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.soundBtn);
            this.Controls.Add(this.introductionTxt);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arcanum";
            this.Text = "Arcanum";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquarius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capricorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pisces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagittarius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scorpio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taurus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virgo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.RichTextBox introductionTxt;
        private System.Windows.Forms.Button soundBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button muteBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label numb;
        private System.Windows.Forms.Label zodiac;
        private System.Windows.Forms.RichTextBox numberTxt;
        private System.Windows.Forms.RichTextBox zodiacTxt;
        private System.Windows.Forms.PictureBox aries;
        private System.Windows.Forms.PictureBox aquarius;
        private System.Windows.Forms.PictureBox cancer;
        private System.Windows.Forms.PictureBox capricorn;
        private System.Windows.Forms.PictureBox gemini;
        private System.Windows.Forms.PictureBox leo;
        private System.Windows.Forms.PictureBox libra;
        private System.Windows.Forms.PictureBox pisces;
        private System.Windows.Forms.PictureBox sagittarius;
        private System.Windows.Forms.PictureBox scorpio;
        private System.Windows.Forms.PictureBox taurus;
        private System.Windows.Forms.PictureBox virgo;
    }
}

