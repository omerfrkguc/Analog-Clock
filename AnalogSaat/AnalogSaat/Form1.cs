namespace AnalogSaat
{
    public partial class Form1 : Form
    {

        Bitmap akrepResim = new Bitmap(AnalogSaat.Properties.Resources.akrep);
        Bitmap yelkovanResim = new Bitmap(AnalogSaat.Properties.Resources.yelkovan);
        Bitmap saniyeResim = new Bitmap(AnalogSaat.Properties.Resources.saniye);
        Bitmap miliResim = new Bitmap(AnalogSaat.Properties.Resources.mili);
        int saat, dakika, saniye, mili;
        DateTime zaman;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            saat = zaman.Hour;
            dakika = zaman.Minute;
            saniye = zaman.Second;
            mili = zaman.Millisecond;
            Single miliAci = mili * (float)(360) / (1000);
            Single saniyeAci = saniye * 6 + miliAci / 1000;
            Single dakikaAci = dakika * 6 + saniyeAci / 60;
            Single saatAci = saat * 30 + dakikaAci / 12;

            pictureBoxAkrep.Image = resimCevir(akrepResim, saatAci);
            pictureBoxYelkovan.Image = resimCevir(yelkovanResim, dakikaAci);
            pictureBoxSaniye.Image = resimCevir(saniyeResim, saniyeAci);
            pictureBoxMili.Image = resimCevir(miliResim, miliAci);



        }
        private Bitmap resimCevir(Bitmap eskiResim, float aci)
        {
            Bitmap yeniResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using (Graphics g = Graphics.FromImage(yeniResim))
            {
                g.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                g.RotateTransform(aci);
                g.TranslateTransform(-eskiResim.Width / 2, -eskiResim.Height / 2);
                g.DrawImage(eskiResim, new Point(0, 0));

            }
            return yeniResim;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxAkrep.Parent = pictureBoxSaat;
            pictureBoxAkrep.Location = new Point(0, 0);

            pictureBoxYelkovan.Parent = pictureBoxAkrep;
            pictureBoxYelkovan.Location = new Point(0, 0);

            pictureBoxSaniye.Parent = pictureBoxYelkovan;
            pictureBoxSaniye.Location = new Point(0, 0);

            pictureBoxMili.Parent = pictureBoxSaniye;
            pictureBoxMili.Location = new Point(0, 0);

        }
    }
}