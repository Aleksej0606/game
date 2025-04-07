namespace RidingGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bg2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg1.BackgroundImage")));
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(1024, 1024);
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            this.bg1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DimGray;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.Location = new System.Drawing.Point(455, 729);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 223);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 13;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bg2
            // 
            this.bg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg2.BackgroundImage")));
            this.bg2.Location = new System.Drawing.Point(0, -1024);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(1024, 1024);
            this.bg2.TabIndex = 14;
            this.bg2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1024, 1024);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bg2;
    }
}

