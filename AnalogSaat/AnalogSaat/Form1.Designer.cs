namespace AnalogSaat
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            pictureBoxSaat = new PictureBox();
            pictureBoxAkrep = new PictureBox();
            pictureBoxYelkovan = new PictureBox();
            pictureBoxSaniye = new PictureBox();
            pictureBoxMili = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAkrep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYelkovan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaniye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMili).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxSaat
            // 
            pictureBoxSaat.BackColor = Color.Transparent;
            pictureBoxSaat.Image = Properties.Resources.kadran;
            pictureBoxSaat.Location = new Point(0, 0);
            pictureBoxSaat.MinimumSize = new Size(500, 500);
            pictureBoxSaat.Name = "pictureBoxSaat";
            pictureBoxSaat.Size = new Size(500, 500);
            pictureBoxSaat.TabIndex = 0;
            pictureBoxSaat.TabStop = false;
            // 
            // pictureBoxAkrep
            // 
            pictureBoxAkrep.BackColor = Color.Transparent;
            pictureBoxAkrep.Image = Properties.Resources.akrep;
            pictureBoxAkrep.Location = new Point(0, 0);
            pictureBoxAkrep.MinimumSize = new Size(500, 500);
            pictureBoxAkrep.Name = "pictureBoxAkrep";
            pictureBoxAkrep.Size = new Size(500, 500);
            pictureBoxAkrep.TabIndex = 1;
            pictureBoxAkrep.TabStop = false;
            // 
            // pictureBoxYelkovan
            // 
            pictureBoxYelkovan.BackColor = Color.Transparent;
            pictureBoxYelkovan.Image = Properties.Resources.yelkovan;
            pictureBoxYelkovan.Location = new Point(0, 0);
            pictureBoxYelkovan.MinimumSize = new Size(500, 500);
            pictureBoxYelkovan.Name = "pictureBoxYelkovan";
            pictureBoxYelkovan.Size = new Size(500, 500);
            pictureBoxYelkovan.TabIndex = 2;
            pictureBoxYelkovan.TabStop = false;
            // 
            // pictureBoxSaniye
            // 
            pictureBoxSaniye.BackColor = Color.Transparent;
            pictureBoxSaniye.Image = Properties.Resources.saniye;
            pictureBoxSaniye.Location = new Point(0, 0);
            pictureBoxSaniye.Name = "pictureBoxSaniye";
            pictureBoxSaniye.Size = new Size(500, 500);
            pictureBoxSaniye.TabIndex = 3;
            pictureBoxSaniye.TabStop = false;
            // 
            // pictureBoxMili
            // 
            pictureBoxMili.BackColor = Color.Transparent;
            pictureBoxMili.Image = Properties.Resources.mili;
            pictureBoxMili.Location = new Point(0, 0);
            pictureBoxMili.Name = "pictureBoxMili";
            pictureBoxMili.Size = new Size(500, 500);
            pictureBoxMili.TabIndex = 4;
            pictureBoxMili.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxMili);
            Controls.Add(pictureBoxSaniye);
            Controls.Add(pictureBoxYelkovan);
            Controls.Add(pictureBoxAkrep);
            Controls.Add(pictureBoxSaat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAkrep).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYelkovan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaniye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMili).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxSaat;
        private PictureBox pictureBoxAkrep;
        private PictureBox pictureBoxYelkovan;
        private PictureBox pictureBoxSaniye;
        private PictureBox pictureBoxMili;
        private System.Windows.Forms.Timer timer1;
    }
}