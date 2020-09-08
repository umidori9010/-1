using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Media;
using System.Threading;
using System.Reflection;
using System.Timers;

namespace test1
{

    public partial class Form1 : Form
    {
        int d, i, j, k = 0, s,m=0, n, t = 0, dr = 0;
        int mcst = 0, mtcst = 0, ytcst = 0, ycst = 0;       //  残コスト、ターンコスト
        int seed;
        int StartTime = 0, EndTime = 0, TimePara = 0;
        int mainflag = 0;
        public int dic;
        int mln1, mln2, mln3, mln4, mln5;
        int mid1, mid2, mid3, mid4, mid5;
        int yln1, yln2, yln3, yln4, yln5;
        int yid1, yid2, yid3, yid4, yid5;
        int mt1, mt2, mt3, mt4, mt5;
        int mc1, mc2, mc3, mc4, mc5;
        int mcc1, mcc2, mcc3, mcc4, mcc5;
        int mac1 = 0, mac2 = 0, mac3 = 0, mac4 = 0, mac5 = 0;
        int mhp1 = 0, mhp2 = 0, mhp3 = 0, mhp4 = 0, mhp5 = 0;
        int yac1 = 0, yac2 = 0, yac3 = 0, yac4 = 0, yac5 = 0;
        int yhp1 = 0, yhp2 = 0, yhp3 = 0, yhp4 = 0, yhp5 = 0;
        public int mte1d1, mte2d1, mte3d1, mte4d1, mte5d1;
        public int mte1d2, mte2d2, mte3d2, mte4d2, mte5d2;
        public int mp11 = 0, mp21 = 0, mp31 = 0, mp41 = 0, mp51 = 0;
        public int mp12 = 0, mp22 = 0, mp32 = 0, mp42 = 0, mp52 = 0;
        public int yp11 = 0, yp21 = 0, yp31 = 0, yp41 = 0, yp51 = 0;
        public int yp12 = 0, yp22 = 0, yp32 = 0, yp42 = 0, yp52 = 0;
        int yt1, yt2, yt3, yt4, yt5;
        int yc1, yc2, yc3, yc4, yc5;
        int ycc1, ycc2, ycc3, ycc4, ycc5;
        int volume = 150;
        int turn = 1, NowPhase = 0;
        string who;
        int hiki, mhiki, yhiki, mthd = 0, ythd = 0, myama,yyama;
        int dicenmb = 0;
        int ba1set = 0, ba2set = 0, ba3set = 0, ba4set = 0, ba5set = 0;
        int ba6set = 0, ba7set = 0, ba8set = 0, ba9set = 0, ba10set = 0;
        int ba1move = 0, ba2move = 0, ba3move = 0, ba4move = 0, ba5move = 0;
        int ba6move = 0, ba7move = 0, ba8move = 0, ba9move = 0, ba10move = 0;
        int ba1ln = 0, ba2ln = 0, ba3ln = 0, ba4ln = 0, ba5ln = 0;
        int ba6ln = 0, ba7ln = 0, ba8ln = 0, ba9ln = 0, ba10ln = 0;
        int ba1id = 0, ba2id = 0, ba3id = 0, ba4id = 0, ba5id = 0;
        int ba6id = 0, ba7id = 0, ba8id = 0, ba9id = 0, ba10id = 0;
        int ba1c = 0, ba2c = 0, ba3c = 0, ba4c = 0, ba5c = 0, ba6c = 0, ba7c = 0, ba8c = 0, ba9c = 0, ba10c = 0;
        int mbacc =0,ybacc=0,ba1cc=0, ba2cc = 0, ba3cc = 0, ba4cc = 0, ba5cc = 0, ba6cc = 0, ba7cc = 0, ba8cc = 0, ba9cc = 0, ba10cc = 0;
        int ba1ac = 0, ba2ac = 0, ba3ac = 0, ba6ac = 0, ba7ac = 0, ba8ac = 0;
        int ba1hp = 0, ba2hp = 0, ba3hp = 0, ba6hp = 0, ba7hp = 0, ba8hp = 0;
        int ba1d1 = 0, ba2d1 = 0, ba3d1 = 0, ba1d2 = 0, ba2d2 = 0, ba3d2 = 0;
        int ba6d1 = 0, ba7d1 = 0, ba8d1 = 0, ba6d2 = 0, ba7d2 = 0, ba8d2 = 0;
        int ba1p1 = 0, ba2p1 = 0, ba3p1 = 0, ba1p2 = 0, ba2p2 = 0, ba3p2 = 0;
        int ba6p1 = 0, ba7p1 = 0, ba8p1 = 0, ba6p2 = 0, ba7p2 = 0, ba8p2 = 0;
        int btlflg1 = 0, btlflg2 = 0, btlflg3 = 0;
        int btlflg6 = 0, btlflg7 = 0, btlflg8 = 0;
        int btl1 = 0, btl2 = 0, btl3 = 0;
        int btl6 = 0, btl7 = 0, btl8 = 0;
        int TimerStep = 0;
        int atk = 0, hp = 0, ac = 0, dmg = 0;
        int ith=0;        //退避
        int[] mln = new int[5];
        int[] yln = new int[5];
        string[] atkskill = new string[20];
        string[] defskill = new string[20];
        string[] line = new string[99];
        int[] mte1 = new int[20];
        int[] mte2 = new int[20];
        int[] mte3 = new int[20];
        int[] mte4 = new int[20];
        int[] mte5 = new int[20]; //手札１～５
        int[] yte1 = new int[20];
        int[] yte2 = new int[20];
        int[] yte3 = new int[20];
        int[] yte4 = new int[20];
        int[] yte5 = new int[20];
        int[] ba1 = new int[20];
        int[] ba2 = new int[20];
        int[] ba3 = new int[20];
        int[] ba4 = new int[20];
        int[] ba5 = new int[20];
        int[] ba6 = new int[20];
        int[] ba7 = new int[20];
        int[] ba8 = new int[20];
        int[] ba9 = new int[20];
        int[] ba10 = new int[20];
        int[,] mdk = new int[31,20];
        int[,] ydk = new int[31,20];
        Image[] imgs = new Image[12];
        Image[] imgm = new Image[12];
        Image[] imgd = new Image[7];
        Image[] ipda = new Image[6];
        Image[] ipdb = new Image[6];
        Image imgura = Image.FromFile(string.Format(@"Resources\ura.jpg"));
        Image imgnull = Image.FromFile(string.Format(@"Resources\null.png"));
        Image imgselect = Image.FromFile(string.Format(@"Resources\select1.png"));
        string path = Directory.GetCurrentDirectory() + "\\Resources\\nisuisen.mp3";
        string waveFile = Directory.GetCurrentDirectory() + "\\Resources\\hit02.wav";
        string bgm;
        string next = "off";
        int[] mte = new int[] { 0, 0, 0, 0, 0 };
        int[] yte = new int[] { 0, 0, 0, 0, 0 };
        int[] mdeck = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        int[] ydeck = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };


        public Form1()
        {
            InitializeComponent();
        }

        public void Main()
        {
            if (mainflag == 0)
            {
                NowPhase = 0;
                StartConfig();
                //上の動作後にmain2に行く動作を入れるのね・・・。20200907
                //仮として・・・
                mDraw();
                mSetPhase();
                mPara();
                DrawTime();
                //yDraw();
                
            }
            /*
            else if (mainflag == 1)
            {
                who = "m";
                Phase_on();
            }
            else if (mainflag == 2)
            {
                NowPhase = 1;
                Phase_on();
            }
            
            else if (mainflag == 2)
            {
                mainflag = 999;
                
                mtcst = turn - mbacc;
                ytcst = turn - ybacc;
                label4.Text = turn.ToString();
                btn_Enable();                
            }
            else if (mainflag == 3)
            {
                mainflag = 999;
                mSetPhase();
                ySetPhase();
                Phase_on();
                mainflag = 4;
            }
            else if (mainflag == 4)
            {
                mainflag = 999;
                AttackBattlePhase();
                Phase_on();
                mainflag = 5;
            }
            */
        }
        public void Main2()
        {
            mSetPhase();
            ySetPhase();
            NowPhase = 1;
            
            //Phase_on();
            //NowPhase=3;
            //Phase_on();
        }
        public void Main3()
        {
            AttackBattlePhase();
            //ySetPhase();
            //NowPhase=4;
            //Phase_on();
        }
        public void Main4()
        {
            mtcst = turn - mbacc;
            ytcst = turn - ybacc;
            label4.Text = turn.ToString();
            NowPhase = 5;
            Phase_on();
            //AttackBattlePhase();
        }
        public void Main5()
        {
            ySetPhase();
            btn_Enable();
            /*
            DrawPhase();
            turn++;
            label3.Text = turn.ToString();
            mtcst = turn - mbacc;
            ytcst = turn - ybacc;
            label4.Text = turn.ToString();
            btn_Enable();
            */
        }
        private void StartConfig()
        {             //BGM_ON
            sound_open();
            sound_play();
            sound_volume();

            // 自フェイズ 初期
            button26.Enabled = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            mtcst = turn;
            ytcst = turn;
            mcst = 0;
            ycst = 0;

            CardImage.Visible = true;
            CardImage.BackColor = Color.FromArgb(80, 0, 0, 0);

            label5.Parent = CardImage;
            label5.BackColor = Color.FromArgb(150, 0, 0, 0);
            label5.Location -= (Size)this.CardImage.Location;
            label6.Parent = CardImage;
            label6.BackColor = Color.FromArgb(150, 0, 0, 0);
            label6.Location -= (Size)this.CardImage.Location;
            label7.Parent = CardImage;
            label7.BackColor = Color.FromArgb(150, 0, 0, 0);
            label7.Location -= (Size)this.CardImage.Location;
            label8.Parent = CardImage;
            label8.BackColor = Color.FromArgb(150, 0, 0, 0);
            label8.Location -= (Size)this.CardImage.Location;
            label9.Parent = CardImage;
            label9.ForeColor = Color.White;
            label9.BackColor = Color.FromArgb(150, 0, 0, 0);
            label9.Location -= (Size)this.CardImage.Location;
            label10.Parent = CardImage;
            label10.ForeColor = Color.White;
            label10.BackColor = Color.FromArgb(150, 0, 0, 0);
            label10.Location -= (Size)this.CardImage.Location;
            label11.Parent = CardImage;
            label11.ForeColor = Color.White;
            label11.BackColor = Color.FromArgb(150, 0, 0, 0);
            label11.Location -= (Size)this.CardImage.Location;
            label15.Parent = CardImage;
            label15.ForeColor = Color.White;
            label15.BackColor = Color.FromArgb(150, 0, 0, 0);
            label15.Location -= (Size)this.CardImage.Location;
            label17.Parent = CardImage;
            label17.ForeColor = Color.White;
            label17.BackColor = Color.FromArgb(150, 0, 0, 0);
            label17.Location -= (Size)this.CardImage.Location;
            label16.Parent = CardImage;
            label16.ForeColor = Color.White;
            label16.BackColor = Color.FromArgb(150, 0, 0, 0);
            label16.Location -= (Size)this.CardImage.Location;

            button1.Location = new Point(690, 500);
            button2.Location = new Point(690, 500);
            button3.Location = new Point(690, 500);
            button4.Location = new Point(690, 500);
            button5.Location = new Point(690, 500);
            button21.Location = new Point(690, 10);
            button22.Location = new Point(690, 10);
            button23.Location = new Point(690, 10);
            button24.Location = new Point(690, 10);
            button25.Location = new Point(690, 10);

            M1Cost.Location = new Point(250, 485);
            M1Cost.ForeColor = Color.White;
            M1Cost.BackColor = Color.FromArgb(150, 0, 0, 0);
            M2Cost.Location = new Point(330, 485);
            M2Cost.ForeColor = Color.White;
            M2Cost.BackColor = Color.FromArgb(150, 0, 0, 0);
            M3Cost.Location = new Point(410, 485);
            M3Cost.ForeColor = Color.White;
            M3Cost.BackColor = Color.FromArgb(150, 0, 0, 0);
            M4Cost.Location = new Point(490, 485);
            M4Cost.ForeColor = Color.White;
            M4Cost.BackColor = Color.FromArgb(150, 0, 0, 0);
            M5Cost.Location = new Point(570, 485);
            M5Cost.ForeColor = Color.White;
            M5Cost.BackColor = Color.FromArgb(150, 0, 0, 0);

            myamahuda_n.ForeColor = Color.White;
            myamahuda_n.BackColor = Color.FromArgb(150, 0, 0, 0);
            yyamahuda_n.ForeColor = Color.White;
            yyamahuda_n.BackColor = Color.FromArgb(150, 0, 0, 0);

            field1.Location = new Point(220, 365);
            field1.BackColor = Color.Black;
            field1.BackColor = Color.FromArgb(60, 0, 0, 0);
            field1.BackgroundImage = imgnull;
            field2.Location = new Point(300, 365);
            field2.BackColor = Color.Black;
            field2.BackColor = Color.FromArgb(60, 0, 0, 0);
            field2.BackgroundImage = imgnull;
            field3.Location = new Point(380, 365);
            field3.BackColor = Color.Black;
            field3.BackColor = Color.FromArgb(60, 0, 0, 0);
            field3.BackgroundImage = imgnull;
            field4.Location = new Point(475, 365);
            field4.BackColor = Color.Black;
            field4.BackColor = Color.FromArgb(60, 0, 0, 0);
            field4.BackgroundImage = imgnull;
            field5.Location = new Point(555, 365);
            field5.BackColor = Color.Black;
            field5.BackColor = Color.FromArgb(60, 0, 0, 0);
            field5.BackgroundImage = imgnull;
            field6.Location = new Point(220, 145);
            field6.BackColor = Color.Black;
            field6.BackColor = Color.FromArgb(60, 0, 0, 0);
            field6.BackgroundImage = imgnull;
            field7.Location = new Point(300, 145);
            field7.BackColor = Color.Black;
            field7.BackColor = Color.FromArgb(60, 0, 0, 0);
            field7.BackgroundImage = imgnull;
            field8.Location = new Point(380, 145);
            field8.BackColor = Color.Black;
            field8.BackColor = Color.FromArgb(60, 0, 0, 0);
            field8.BackgroundImage = imgnull;
            field9.Location = new Point(475, 145);
            field9.BackColor = Color.Black;
            field9.BackColor = Color.FromArgb(60, 0, 0, 0);
            field9.BackgroundImage = imgnull;
            field10.Location = new Point(555, 145);
            field10.BackColor = Color.Black;
            field10.BackColor = Color.FromArgb(60, 0, 0, 0);
            field10.BackgroundImage = imgnull;

            //obi.ForeColor = Color.White;
            obi.Location = new Point(0, 250);
            obi.Size = new Size(884, 110);
            obi.BackColor = Color.FromArgb(150, 0, 0, 0);

            myDice.Parent = CardImage;
            myDice.Location = new Point(110, 310);
            myDice.BackColor = Color.FromArgb(0, 0, 0, 0);
            myDice.Location -= (Size)this.CardImage.Location;
            

            youDice.Parent = CardImage;
            youDice.Location = new Point(110, 200);
            youDice.BackColor = Color.FromArgb(0, 0, 0, 0);
            youDice.Location -= (Size)this.CardImage.Location;

            label3.Text = turn.ToString();
            label4.Text = mtcst.ToString();

            /* 
            //デッキの初期化_mDrawPhase,yDrawPhase
            for (k = 0; k < 30; k++)
            {
                mdk[k] = k;
                ydk[k] = k;
            }
            */


            //Fisher-Yatesアルゴリズムでシャッフルする
            seed = Environment.TickCount;
            Random rnd1 = new Random(seed++);
            n = mdeck.Length;
            while (n > 1)
            {
                n--;
                k = rnd1.Next(n + 1);
                int tmp = mdeck[k];
                mdeck[k] = mdeck[n];
                mdeck[n] = tmp;
            }

            Random rnd2 = new Random(seed++);
            n = ydeck.Length;
            while (n > 1)
            {
                n--;
                k = rnd2.Next(n + 1);
                int tmp = ydeck[k];
                ydeck[k] = ydeck[n];
                ydeck[n] = tmp;
            }
            //デッキをセット
            FileRead4 fr4 = new FileRead4();
            fr4.deck1();
            for (i = 1; i < 31; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    mdk[i, j] = int.Parse(fr4.mData[mdeck[i-1], j]);
                }
            }
            fr4.deck2();
            for (i = 1; i < 31; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    ydk[i, j] = int.Parse(fr4.yData[ydeck[i-1], j]);
                }
            }
            mln1 = mdk[1, 0];
            mln2 = mdk[2, 0];
            mln3 = mdk[3, 0];
            mln4 = mdk[4, 0];
            mln5 = mdk[5, 0];
            mhiki = 5;
            yln1 = ydk[1, 0];
            yln2 = ydk[2, 0];
            yln3 = ydk[3, 0];
            yln4 = ydk[4, 0];
            yln5 = ydk[5, 0];
            yhiki = 5;

            myama = 30 - mhiki;
            yyama = 30 - yhiki;

            //mte[],yte[]初期化mPara等の停止を防ぐ
            for (i = 0; i < 20; i++)
            {
                mte1[i] = 0;
                mte2[i] = 0;
                mte3[i] = 0;
                mte4[i] = 0;
                mte5[i] = 0;
                yte1[i] = 0;
                yte2[i] = 0;
                yte3[i] = 0;
                yte4[i] = 0;
                yte5[i] = 0;
                ba1[i] = 0;
                ba2[i] = 0;
                ba3[i] = 0;
                ba4[i] = 0;
                ba5[i] = 0;
                ba6[i] = 0;
                ba7[i] = 0;
                ba8[i] = 0;
                ba9[i] = 0;
                ba10[i] = 0;
            }
            //画像読み込み
            imgs[0] = Image.FromFile(@"Resources\null.png");
            imgm[0] = Image.FromFile(@"Resources\null.png");
            for (i = 1; i < imgs.Length; i++)
            {
                imgs[i] = Image.FromFile(string.Format(@"Resources\t{0}.jpg", i));
            }
            for (i = 1; i < imgm.Length; i++)
            {
                imgm[i] = Image.FromFile(string.Format(@"Resources\m{0}.jpg", i));
            }
            for (i = 1; i < imgd.Length; i++)
            {
                imgd[i] = Image.FromFile(string.Format(@"Resources\d{0}.png", i));
            }
            for (i = 1; i < ipda.Length; i++)
            {
                ipda[i] = Image.FromFile(string.Format(@"Resources\pda{0}.bmp", i));
            }
            for (i = 1; i < ipdb.Length; i++)
            {
                ipdb[i] = Image.FromFile(string.Format(@"Resources\pdb{0}.bmp", i));
            }
            myamahuda.BackgroundImage = imgura;
            yyamahuda.BackgroundImage = imgura;
            TurnCost();
            //mainflag = 1;

        }
        private void PhaseEnd()
        {
            mSetPhase();
            ySetPhase();
        }
        private void mDraw()
        {
            //hiki：一時的なカード引き数
            //mhiki：トータルのカード引き数
            who = "m";
            d = 690;
            hiki = 5 - mthd;

            for (i = 0; i < hiki; i++)
            {
                mhiki++;
                if (hiki == 5) mln1 = mdk[mhiki, 0];
                if (hiki == 4) mln2 = mdk[mhiki, 0];
                if (hiki == 3) mln3 = mdk[mhiki, 0];
                if (hiki == 2) mln4 = mdk[mhiki, 0];
                if (hiki == 1) mln5 = mdk[mhiki, 0];
                hiki--;
                
            }


            //DrawTime();
        }
        private void yDraw()
        {
            who = "y";
            d = 690;
            hiki = ythd;

            for (i = 0; i < 5 - ythd; i++)
            {                
                yhiki++;
                if (hiki == 0) yln1 = yhiki;
                if (hiki == 1) yln2 = yhiki;
                if (hiki == 2) yln3 = yhiki;
                if (hiki == 3) yln4 = yhiki;
                if (hiki == 4) yln5 = yhiki;
                hiki++;

            }

            yPara();

            DrawTime();

        }
        private void DrawTime()
        {
            while (who != "end")
            {
                //Time50();
                timer1.Interval = 100;
                timer1.Enabled = true;
                d = d - 50;

                //A用
                if (who == "m" & mthd == 0)
                {
                    button1.Visible = true;
                    button1.Location = new Point(d, 500);
                    button1.BackgroundImage = imgs[mid1];
                    if (d - 30 < 220)
                    {
                        button1.Location = new Point(220, 500);
                        mthd = 1;
                        M1Cost.Visible = true;
                        myama = myama - 1;
                        myamahuda_n.Text = myama.ToString();
                        d = 690;
                        timer1.Enabled = false;
                    }

                }
                else if (who == "m" & mthd == 1)
                {
                    button2.Visible = true;
                    button2.Location = new Point(d, 500);
                    if (d - 30 < 300)
                    {
                        button2.Location = new Point(300, 500);
                        mthd = 2;
                        M2Cost.Visible = true;
                        myama = myama - 1;
                        myamahuda_n.Text = myama.ToString();
                        d = 690;
                        timer1.Enabled = false;
                    }
                }
                else if (who == "m" & mthd == 2)
                {
                    button3.Visible = true;
                    button3.Location = new Point(d, 500);
                    if (d - 30 < 380)
                    {
                        button3.Location = new Point(380, 500);
                        mthd = 3;
                        M3Cost.Visible = true;
                        myama = myama - 1;
                        myamahuda_n.Text = myama.ToString();
                        d = 690;
                        timer1.Enabled = false;
                    }
                }
                else if (who == "m" & mthd == 3)
                {
                    button4.Visible = true;
                    button4.Location = new Point(d, 500);
                    if (d - 30 < 460)
                    {
                        button4.Location = new Point(460, 500);
                        mthd = 4;
                        M4Cost.Visible = true;
                        myama = myama - 1;
                        myamahuda_n.Text = myama.ToString();
                        d = 690;
                        timer1.Enabled = false;
                    }
                }
                else if (who == "m" & mthd == 4)
                {
                    button5.Visible = true;
                    button5.Location = new Point(d, 500);
                    if (d - 30 < 540)
                    {
                        button5.Location = new Point(540, 500);
                        mthd = 5;
                        M5Cost.Visible = true;
                        myama = myama - 1;
                        myamahuda_n.Text = myama.ToString();
                        d = 690;
                        timer1.Enabled = false;
                    }
                }
                else if (who == "m" & mthd == 5)
                {
                    who = "end";
                    timer1.Enabled = false;
                }

                // B用
                else if (who == "y" & ythd == 0)
                {
                    button21.Visible = true;
                    button21.Location = new Point(d, 10);

                    if (d - 30 < 220)
                    {
                        button21.Location = new Point(220, 10);
                        ythd = 1;
                        yyama = yyama - 1;
                        yyamahuda_n.Text = yyama.ToString();
                        d = 690;
                    }

                }
                else if (who == "y" & ythd == 1)
                {
                    button22.Visible = true;
                    button22.Location = new Point(d, 10);
                    if (d - 30 < 300)
                    {
                        button22.Location = new Point(300, 10);
                        ythd = 2;
                        yyama = yyama - 1;
                        yyamahuda_n.Text = yyama.ToString();
                        d = 690;
                    }
                }
                else if (who == "y" & ythd == 2)
                {
                    button23.Visible = true;
                    button23.Location = new Point(d, 10);
                    if (d - 30 < 380)
                    {
                        button23.Location = new Point(380, 10);
                        ythd = 3;
                        yyama = yyama - 1;
                        yyamahuda_n.Text = yyama.ToString();
                        d = 690;
                    }
                }
                else if (who == "y" & ythd == 3)
                {
                    button24.Visible = true;
                    button24.Location = new Point(d, 10);
                    if (d - 30 < 460)
                    {
                        button24.Location = new Point(460, 10);
                        ythd = 4;
                        yyama = yyama - 1;
                        yyamahuda_n.Text = yyama.ToString();
                        d = 690;
                    }
                }
                else if (who == "y" & ythd == 4)
                {
                    button25.Visible = true;
                    button25.Location = new Point(d, 10);
                    if (d - 30 < 540)
                    {
                        button25.Location = new Point(540, 10);
                        ythd = 5;
                        yyama = yyama - 1;
                        yyamahuda_n.Text = yyama.ToString();
                        d = 690;
                    }
                }
                else if (who == "y" & ythd == 5)
                {
                    who = "end";
                }
            }
        }
        public void mSetPhase()
        {

            if (s == 1) button1.Top += 10;
            if (s == 2) button2.Top += 10;
            if (s == 3) button3.Top += 10;
            if (s == 4) button4.Top += 10;
            if (s == 5) button5.Top += 10;
            s = 0;
            //手札左詰め
            for (i = 0; i < 4; i++)
            {
                if (mln1 == 0)
                {
                    mln1 = mln2;
                    mln2 = 0;
                }
                if (mln2 == 0)
                {
                    mln2 = mln3;
                    mln3 = 0;
                }
                if (mln3 == 0)
                {
                    mln3 = mln4;
                    mln4 = 0;
                }
                if (mln4 == 0)
                {
                    mln4 = mln5;
                    mln5 = 0;
                }
            }
        }
        private void TurnCost()
        {
            mtcst = turn - mcst;
            ytcst = turn - ycst;
            label3.Text = turn.ToString();
            label4.Text = mtcst.ToString();
            //step++;
        }
        public void ySetPhase()
        {
            //並び替え、高コスト
            for (i = 0; i < 4; i++)
            {
                if (yc1 < yc2)
                {
                    ith = yln1;
                    yln1 = yln2;
                    yln2 = ith;
                    ith = yc1;
                    yc1 = yc2;
                    yc2 = ith;
                }
                if (yc2 < yc3)
                {
                    ith = yln2;
                    yln2 = yln3;
                    yln3 = ith;
                    ith = yc2;
                    yc2 = yc3;
                    yc3 = ith;
                }
                if (yc3 < yc4)
                {
                    ith = yln3;
                    yln3 = yln4;
                    yln4 = ith;
                    ith = yc3;
                    yc3 = yc4;
                    yc4 = ith;
                }
                if (yc4 < yc5)
                {
                    ith = yln4;
                    yln4 = yln5;
                    yln5 = ith;
                    ith = yc4;
                    yc4 = yc5;
                    yc5 = ith;
                }

            }

            yPara();

            //MessageBox.Show(yc1.ToString() + yc2.ToString() + yc3.ToString() + yc4.ToString() + yc5.ToString());

            //ターンコスト以内、高コスト、モンスター優先、相対優先
            if (yln1 > 0 & yc1 <= ytcst & yt1 == 1)
            {
                if (ba1ln > 0 & ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln1;
                    ytcst = ytcst - yc1;
                    ycst = ycst + ycc1;
                    field6.BackgroundImage = imgs[yid1];
                    button21.Visible = false;
                    yln1 = 0;
                    ythd--;
                }
                else if (ba2ln > 0 & ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln1;
                    ytcst = ytcst - yc1;
                    ycst = ycst + ycc1;
                    field7.BackgroundImage = imgs[yid1];
                    button21.Visible = false;
                    yln1 = 0;
                    ythd--;
                }
                else if (ba3ln > 0 & ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln1;
                    ytcst = ytcst - yc1;
                    ycst = ycst + ycc1;
                    field8.BackgroundImage = imgs[yid1];
                    button21.Visible = false;
                    yln1 = 0;
                    ythd--;
                }                
            }
            if (yln2 > 0 & yc2 <= ytcst & yt2 == 1)
            {
                if (ba1ln > 0 & ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln2;
                    ytcst = ytcst - yc2;
                    ycst = ycst + ycc2;
                    field6.BackgroundImage = imgs[yid2];
                    button22.Visible = false;
                    yln2 = 0;
                    ythd--;
                }
                else if (ba2ln > 0 & ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln2;
                    ytcst = ytcst - yc2;
                    ycst = ycst + ycc2;
                    field7.BackgroundImage = imgs[yid2];
                    button22.Visible = false;
                    yln2 = 0;
                    ythd--;
                }
                else if (ba3ln > 0 & ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln2;
                    ytcst = ytcst - yc2;
                    ycst = ycst + ycc2;
                    field8.BackgroundImage = imgs[yid2];
                    button22.Visible = false;
                    yln2 = 0;
                    ythd--;
                }
            }
            if (yln3 > 0 & yc3 <= ytcst & yt3 == 1)
            {
                if (ba1ln > 0 & ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln3;
                    ytcst = ytcst - yc3;
                    ycst = ycst + ycc3;
                    field6.BackgroundImage = imgs[yid3];
                    button23.Visible = false;
                    yln3 = 0;
                    ythd--;
                }
                else if (ba2ln > 0 & ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln3;
                    ytcst = ytcst - yc3;
                    ycst = ycst + ycc3;
                    field7.BackgroundImage = imgs[yid3];
                    button23.Visible = false;
                    yln3 = 0;
                    ythd--;
                }
                else if (ba3ln > 0 & ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln3;
                    ytcst = ytcst - yc3;
                    ycst = ycst + ycc3;
                    field8.BackgroundImage = imgs[yid3];
                    button23.Visible = false;
                    yln3 = 0;
                    ythd--;
                }
            }
            if (yln4 > 0 & yc4 <= ytcst & yt4 == 1)
            {
                if (ba1ln > 0 & ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln4;
                    ytcst = ytcst - yc4;
                    ycst = ycst + ycc4;
                    field6.BackgroundImage = imgs[yid4];
                    button24.Visible = false;
                    yln4 = 0;
                    ythd--;
                }
                else if (ba2ln > 0 & ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln4;
                    ytcst = ytcst - yc4;
                    ycst = ycst + ycc4;
                    field7.BackgroundImage = imgs[yid4];
                    button24.Visible = false;
                    yln4 = 0;
                    ythd--;
                }
                else if (ba3ln > 0 & ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln4;
                    ytcst = ytcst - yc4;
                    ycst = ycst + ycc4;
                    field8.BackgroundImage = imgs[yid4];
                    button24.Visible = false;
                    yln4 = 0;
                    ythd--;
                }                
            }
            if (yln5 > 0 & yc5 <= ytcst & yt5 == 1)
            {
                if (ba1ln > 0 & ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln5;
                    ytcst = ytcst - yc5;
                    ycst = ycst + ycc5;
                    field6.BackgroundImage = imgs[yid5];
                    button25.Visible = false;
                    yln5 = 0;
                    ythd--;
                }
                else if (ba2ln > 0 & ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln5;
                    ytcst = ytcst - yc5;
                    ycst = ycst + ycc5;
                    field7.BackgroundImage = imgs[yid5];
                    button25.Visible = false;
                    yln5 = 0;
                    ythd--;
                }
                else if (ba3ln > 0 & ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln5;
                    ytcst = ytcst - yc5;
                    ycst = ycst + ycc5;
                    field8.BackgroundImage = imgs[yid5];
                    button25.Visible = false;
                    yln5 = 0;
                    ythd--;
                }                
            }

            // 相手の場にモンスターがいない
            if (yln1 > 0 & yc1 <= ytcst & yt1 == 1)
            {
                if (ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln1;
                    ytcst = ytcst - yc1;
                    ycst = ycst + ycc1;
                    field6.BackgroundImage = imgs[yid1];
                    button21.Visible = false;
                    yln1 = 0;
                    ythd--;
                }
                else if (ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln1;
                    ytcst = ytcst - yc1;
                    ycst = ycst + ycc1;
                    field7.BackgroundImage = imgs[yid1];
                    button21.Visible = false;
                    yln1 = 0;
                    ythd--;
                }
                else if (ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln1;
                    ytcst = ytcst - yc1;
                    ycst = ycst + ycc1;
                    field8.BackgroundImage = imgs[yid1];
                    button21.Visible = false;
                    yln1 = 0;
                    ythd--;
                }                
            }
            if (yln2 > 0 & yc2 <= ytcst & yt2 == 1)
            {
                if (ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln2;
                    ytcst = ytcst - yc2;
                    ycst = ycst + ycc2;
                    field6.BackgroundImage = imgs[yid2];
                    button22.Visible = false;
                    yln2 = 0;
                    ythd--;
                }
                else if (ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln2;
                    ytcst = ytcst - yc2;
                    ycst = ycst + ycc2;
                    field7.BackgroundImage = imgs[yid2];
                    button22.Visible = false;
                    yln2 = 0;
                    ythd--;
                }
                else if (ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln2;
                    ytcst = ytcst - yc2;
                    ycst = ycst + ycc2;
                    field8.BackgroundImage = imgs[yid2];
                    button22.Visible = false;
                    yln2 = 0;
                    ythd--;
                }                
            }
            if (yln3 > 0 & yc3 <= ytcst & yt3 == 1)
            {
                if (ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln3;
                    ytcst = ytcst - yc3;
                    ycst = ycst + ycc3;
                    field6.BackgroundImage = imgs[yid3];
                    button23.Visible = false;
                    yln3 = 0;
                    ythd--;
                }
                else if (ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln3;
                    ytcst = ytcst - yc3;
                    ycst = ycst + ycc3;
                    field7.BackgroundImage = imgs[yid3];
                    button23.Visible = false;
                    yln3 = 0;
                    ythd--;
                }
                else if (ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln3;
                    ytcst = ytcst - yc3;
                    ycst = ycst + ycc3;
                    field8.BackgroundImage = imgs[yid3];
                    button23.Visible = false;
                    yln3 = 0;
                    ythd--;
                }                
            }
            if (yln4 > 0 & yc4 <= ytcst & yt4 == 1)
            {
                if (ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln4;
                    ytcst = ytcst - yc4;
                    ycst = ycst + ycc4;
                    field6.BackgroundImage = imgs[yid4];
                    button24.Visible = false;
                    yln4 = 0;
                    ythd--;
                }
                else if (ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln4;
                    ytcst = ytcst - yc4;
                    ycst = ycst + ycc4;
                    field7.BackgroundImage = imgs[yid4];
                    button24.Visible = false;
                    yln4 = 0;
                    ythd--;
                }
                else if (ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln4;
                    ytcst = ytcst - yc4;
                    ycst = ycst + ycc4;
                    field8.BackgroundImage = imgs[yid4];
                    button24.Visible = false;
                    yln4 = 0;
                    ythd--;
                }                
            }
            if (yln5 > 0 & yc5 <= ytcst & yt5 == 1)
            {
                if (ba6ln == 0)
                {
                    ba6set = 1;
                    ba6ln = yln5;
                    ytcst = ytcst - yc5;
                    ycst = ycst + ycc5;
                    field6.BackgroundImage = imgs[yid5];
                    button25.Visible = false;
                    yln5 = 0;
                    ythd--;
                }
                else if (ba7ln == 0)
                {
                    ba7set = 1;
                    ba7ln = yln5;
                    ytcst = ytcst - yc5;
                    ycst = ycst + ycc5;
                    field7.BackgroundImage = imgs[yid5];
                    button25.Visible = false;
                    yln5 = 0;
                    ythd--;
                }
                else if (ba8ln == 0)
                {
                    ba8set = 1;
                    ba8ln = yln5;
                    ytcst = ytcst - yc5;
                    ycst = ycst + ycc5;
                    field8.BackgroundImage = imgs[yid5];
                    button25.Visible = false;
                    yln5 = 0;
                    ythd--;
                }                
            }
            //ターンコスト以内、低コスト、スキル優先
            if (yln1 > 0 & yc1 <= ytcst & yt1 == 2)
            {
                if (ba9ln == 0)
                {
                    ba9set = 1;
                    ba9ln = yln1;
                    ytcst = ytcst - yc1;
                    ycst = ycst + ycc1;
                    field9.BackgroundImage = imgs[yid1];
                    button21.Visible = false;
                    yln1 = 0;
                    ythd--;
                }
                else if (ba10ln == 0)
                {
                    ba10set = 1;
                    ba10ln = yln1;
                    ytcst = ytcst - yc1;
                    ycst = ycst + ycc1;
                    field10.BackgroundImage = imgs[yid1];
                    button21.Visible = false;
                    yln1 = 0;
                    ythd--;
                }                
            }
            if (yln2 > 0 & yc2 <= ytcst & yt2 == 2)
            {
                if (ba9ln == 0)
                {
                    ba9set = 1;
                    ba9ln = yln2;
                    ytcst = ytcst - yc2;
                    ycst = ycst + ycc2;
                    field9.BackgroundImage = imgs[yid2];
                    button22.Visible = false;
                    yln2 = 0;
                    ythd--;
                }
                else if (ba10ln == 0)
                {
                    ba10set = 1;
                    ba10ln = yln2;
                    ytcst = ytcst - yc2;
                    ycst = ycst + ycc2;
                    field10.BackgroundImage = imgs[yid2];
                    button22.Visible = false;
                    yln2 = 0;
                    ythd--;
                }                
            }
            if (yln3 > 0 & yc3 <= ytcst & yt3 == 2)
            {
                if (ba9ln == 0)
                {
                    ba9set = 1;
                    ba9ln = yln3;
                    ytcst = ytcst - yc3;
                    ycst = ycst + ycc3;
                    field9.BackgroundImage = imgs[yid3];
                    button23.Visible = false;
                    yln3 = 0;
                    ythd--;
                }
                else if (ba10ln == 0)
                {
                    ba10set = 1;
                    ba10ln = yln3;
                    ytcst = ytcst - yc3;
                    ycst = ycst + ycc3;
                    field10.BackgroundImage = imgs[yid3];
                    button23.Visible = false;
                    yln3 = 0;
                    ythd--;
                }                
            }
            if (yln4 > 0 & yc4 <= ytcst & yt4 == 2)
            {
                if (ba9ln == 0)
                {
                    ba9set = 1;
                    ba9ln = yln4;
                    ytcst = ytcst - yc4;
                    ycst = ycst + ycc4;
                    field9.BackgroundImage = imgs[yid4];
                    button24.Visible = false;
                    yln4 = 0;
                    ythd--;
                }
                else if (ba10ln == 0)
                {
                    ba10set = 1;
                    ba10ln = yln4;
                    ytcst = ytcst - yc4;
                    ycst = ycst + ycc4;
                    field10.BackgroundImage = imgs[yid4];
                    button24.Visible = false;
                    yln4 = 0;
                    ythd--;
                }                
            }
            if (yln5 > 0 & yc5 <= ytcst & yt5 == 2)
            {
                if (ba9ln == 0)
                {
                    ba9set = 1;
                    ba9ln = yln5;
                    ytcst = ytcst - yc5;
                    ycst = ycst + ycc5;
                    field9.BackgroundImage = imgs[yid5];
                    button25.Visible = false;
                    yln5 = 0;
                    ythd--;
                }
                else if (ba10ln == 0)
                {
                    ba10set = 1;
                    ba10ln = yln5;
                    ytcst = ytcst - yc5;
                    ycst = ycst + ycc5;
                    field10.BackgroundImage = imgs[yid5];
                    button25.Visible = false;
                    yln5 = 0;
                    ythd--;
                }                
            }
            //場にカードがセットされた場合のみ参照
            if(ba6set==1)
            {
                for (i = 0; i < 20; i++)
                {
                    ba6[i] = ydk[ba6ln, i];
                }
            }
            if (ba7set == 1)
            {
                for (i = 0; i < 20; i++)
                {
                    ba7[i] = ydk[ba7ln, i];
                }
            }
            if (ba8set == 1)
            {
                for (i = 0; i < 20; i++)
                {
                    ba8[i] = ydk[ba8ln, i];
                }
            }
            if (ba9set == 1)
            {
                for (i = 0; i < 20; i++)
                {
                    ba9[i] = ydk[ba9ln, i];
                }
            }
            if (ba10set == 1)
            {
                for (i = 0; i < 20; i++)
                {
                    ba10[i] = ydk[ba10ln, i];
                }
            }

                //手札左詰め               


            for (i = 0; i < 4; i++)
            {
                if (yln1 == 0)
                {
                    yln1 = yln2;
                    yln2 = 0;
                }
                if (yln2 == 0)
                {
                    yln2 = yln3;
                    yln3 = 0;
                }
                if (yln3 == 0)
                {
                    yln3 = yln4;
                    yln4 = 0;
                }
                if (yln4 == 0)
                {
                    yln4 = yln5;
                    yln5 = 0;
                }
            }
            //MessageBox.Show(yln1.ToString() + yln2.ToString() + yln3.ToString() + yln4.ToString() + yln5.ToString());

            yPara();
            bPara();

            ba6set = 0;
            ba7set = 0;
            ba8set = 0;
            ba9set = 0;
            ba10set = 0;
        }
        public void mPara()
        {
            for (i = 0; i < 20; i++)
            {
                mte1[i] = mdk[mln1, i];
                mte2[i] = mdk[mln2, i];
                mte3[i] = mdk[mln3, i];
                mte4[i] = mdk[mln4, i];
                mte5[i] = mdk[mln5, i];
            }

            mid1 = mte1[1];
            mid2 = mte2[1];
            mid3 = mte3[1];
            mid4 = mte4[1];
            mid5 = mte5[1];

            if (mln1 > 0)
            {
                button1.Visible = true;
                button1.BackgroundImage = imgs[mid1];
                M1Cost.Visible = true;
            }
            else { button1.Visible = false; M1Cost.Visible = false; }
            if (mln2 > 0)
            {
                button2.Visible = true;
                button2.BackgroundImage = imgs[mid2];
                M2Cost.Visible = true;
            }
            else { button2.Visible = false; M2Cost.Visible = false; }
            if (mln3 > 0)
            {
                button3.Visible = true;
                button3.BackgroundImage = imgs[mid3];
                M3Cost.Visible = true;
            }
            else { button3.Visible = false; M3Cost.Visible = false; }
            if (mln4 > 0)
            {
                button4.Visible = true;
                button4.BackgroundImage = imgs[mid4];
                M4Cost.Visible = true;
            }
            else { button4.Visible = false; M4Cost.Visible = false; }
            if (mln5 > 0)
            {
                button5.Visible = true;
                button5.BackgroundImage = imgs[mid5];
                M5Cost.Visible = true;
            }
            else { button5.Visible = false; M5Cost.Visible = false; }

            mt1 = mte1[2];
            mt2 = mte2[2];
            mt3 = mte3[2];
            mt4 = mte4[2];
            mt5 = mte5[2];

            //セットコスト
            mc1 = mte1[5];
            mc2 = mte2[5];
            mc3 = mte3[5];
            mc4 = mte4[5];
            mc5 = mte5[5];

            //維持コスト
            mcc1 = mte1[6];
            mcc2 = mte2[6];
            mcc3 = mte3[6];
            mcc4 = mte4[6];
            mcc5 = mte5[6];

            //ac
            mac1 = mte1[11];
            mac2 = mte2[11];
            mac3 = mte3[11];
            mac4 = mte4[11];
            mac5 = mte5[11];

            //hp
            mhp1 = mte1[12];
            mhp2 = mte2[12];
            mhp3 = mte3[12];
            mhp4 = mte4[12];
            mhp5 = mte5[12];

            mte1d1 = mte1[13];
            mte1d2 = mte1[14];
            mte2d1 = mte2[13];
            mte2d2 = mte2[14];
            mte3d1 = mte3[13];
            mte3d2 = mte3[14];
            mte4d1 = mte4[13];
            mte4d2 = mte4[14];
            mte5d1 = mte5[13];
            mte5d2 = mte5[14];

            //pow
            mp11 = mte1[15];
            mp12 = mte1[16];
            mp21 = mte2[15];
            mp22 = mte2[16];
            mp31 = mte3[15];
            mp32 = mte3[16];
            mp41 = mte4[15];
            mp42 = mte4[16];
            mp51 = mte5[15];
            mp52 = mte5[16];

            //手札コスト表示
            M1Cost.Text = mc1.ToString();
            M2Cost.Text = mc2.ToString();
            M3Cost.Text = mc3.ToString();
            M4Cost.Text = mc4.ToString();
            M5Cost.Text = mc5.ToString();

            //kari
            label13.Text = mln1.ToString();
            label14.Text = mln2.ToString();
            label18.Text = mln3.ToString();
            label19.Text = mln4.ToString();
            label20.Text = mln5.ToString();
        }
        public void yPara()
        {
            for (i = 0; i < 20; i++)
            {
                yte1[i] = ydk[yln1, i];
                yte2[i] = ydk[yln2, i];
                yte3[i] = ydk[yln3, i];
                yte4[i] = ydk[yln4, i];
                yte5[i] = ydk[yln5, i];
            }

            yid1 = yte1[1];
            yid2 = yte2[1];
            yid3 = yte3[1];
            yid4 = yte4[1];
            yid5 = yte5[1];
            //手札表示 BackgroundImage = imgs[0]でvisibleがtrueになってしまう
            if (yln1 > 0)
            {
                button21.Visible = true;
                button21.BackgroundImage = imgs[yid1];
            }
            else button21.Visible = false;
            if (yln2 > 0)
            {
                button22.Visible = true;
                button22.BackgroundImage = imgs[yid2];
            }
            else button22.Visible = false;
            if (yln3 > 0)
            {
                button23.Visible = true;
                button23.BackgroundImage = imgs[yid3];
            }
            else button23.Visible = false;
            if (yln4 > 0)
            {
                button24.Visible = true;
                button24.BackgroundImage = imgs[yid4];
            }
            else button24.Visible = false;
            if (yln5 > 0)
            {
                button25.Visible = true;
                button25.BackgroundImage = imgs[yid5];
            }
            else button25.Visible = false;

            yt1 = yte1[2];
            yt2 = yte2[2];
            yt3 = yte3[2];
            yt4 = yte4[2];
            yt5 = yte5[2];

            //cost
            yc1 = yte1[5];
            yc2 = yte2[5];
            yc3 = yte3[5];
            yc4 = yte4[5];
            yc5 = yte5[5];

            //維持cost
            ycc1 = yte1[6];
            ycc2 = yte2[6];
            ycc3 = yte3[6];
            ycc4 = yte4[6];
            ycc5 = yte5[6];

            //ac
            yac1 = yte1[11];
            yac2 = yte2[11];
            yac3 = yte3[11];
            yac4 = yte4[11];
            yac5 = yte5[11];

            //hp
            yhp1 = yte1[12];
            yhp2 = yte2[12];
            yhp3 = yte3[12];
            yhp4 = yte4[12];
            yhp5 = yte5[12];
        }
        public void bPara()
        {
            if (ba1set == 1)
            {
                ba1id = ba1[1];
                field1.BackgroundImage = imgs[ba1id];
                ba1c = ba1[5];
                ba1cc = ba1[6];
                ba1ac = ba1[11];
                ba1hp = ba1[12];
                ba1d1 = ba1[13];
                ba1d2 = ba1[14];
                ba1p1 = ba1[15];
                ba1p2 = ba1[16];
            }
            if (ba2set == 1)
            {
                ba2id = ba2[1];
                field2.BackgroundImage = imgs[ba2id];
                ba2c = ba2[5];
                ba2cc = ba2[6];
                ba2ac = ba2[11];
                ba2hp = ba2[12];
                ba2d1 = ba2[13];
                ba2d2 = ba2[14];
                ba2p1 = ba2[15];
                ba2p2 = ba2[16];
            }
            if (ba3set == 1)
            {
                ba3id = ba3[1];
                field3.BackgroundImage = imgs[ba3id];
                ba3c = ba3[5];
                ba3cc = ba3[6];
                ba3ac = ba3[11];
                ba3hp = ba3[12];
                ba3d1 = ba3[13];
                ba3d2 = ba3[14];
                ba3p1 = ba3[15];
                ba3p2 = ba3[16];
            }
            if (ba4set == 1)
            {
                ba4id = ba4[1];
                field4.BackgroundImage = imgs[ba4id];
                ba4c = ba4[5];
                ba4cc = ba4[6];
            }
            if (ba5set == 1)
            {
                ba5id = ba5[1];
                field5.BackgroundImage = imgs[ba5id];
                ba5c = ba5[5];
                ba5cc = ba5[6];
            }
            if (ba6set == 1)
            {
                ba6id = ba6[1];
                field6.BackgroundImage = imgs[ba6id];
                ba6c = ba6[5];
                ba6cc = ba6[6];
                ba6ac = ba6[11];
                ba6hp = ba6[12];
                ba6d1 = ba6[13];
                ba6d2 = ba6[14];
                ba6p1 = ba6[15];
                ba6p2 = ba6[16];
            }
            if (ba7set == 1)
            {
                ba7id = ba7[1];
                field7.BackgroundImage = imgs[ba7id];
                ba7c = ba7[5];
                ba7cc = ba7[6];
                ba7ac = ba7[11];
                ba7hp = ba7[12];
                ba7d1 = ba7[13];
                ba7d2 = ba7[14];
                ba7p1 = ba7[15];
                ba7p2 = ba7[16];
            }
            if (ba8set == 1)
            {
                ba8id = ba8[1];
                field8.BackgroundImage = imgs[ba8id];
                ba8c = ba8[5];
                ba8cc = ba8[6];
                ba8ac = ba8[11];
                ba8hp = ba8[12];
                ba8d1 = ba8[13];
                ba8d2 = ba8[14];
                ba8p1 = ba8[15];
                ba8p2 = ba8[16];
            }
            if (ba9set == 1)
            {
                ba9id = ba9[1];
                field9.BackgroundImage = imgs[ba9id];
                ba9c = ba9[5];
                ba9cc = ba9[6];
            }
            if (ba10set == 1)
            {
                ba10id = ba10[1];
                field10.BackgroundImage = imgs[ba10id];
                ba10c = ba10[5];
                ba10cc = ba10[6];
            }

            mbacc = ba1cc + ba2cc + ba3cc + ba4cc + ba5cc;
            ybacc = ba6cc + ba7cc + ba8cc + ba9cc + ba10cc;

        }
        private void AttackBattlePhase()
        {
            if (ba1ln > 0) btlflg1 = 1;
            if (ba2ln > 0) btlflg2 = 1;
            if (ba3ln > 0) btlflg3 = 1;
            who = "m";
            abtlp1();
        }
        private void DefenceBattlePhase()
        {
            if (ba6ln > 0) btlflg6 = 1;
            if (ba7ln > 0) btlflg7 = 1;
            if (ba8ln > 0) btlflg8 = 1;
            who = "y";
            dbtlp1();
        }
        private void abtlp1()
        {
            if (btlflg1 == 1 & btl2 == 0 & btl3 == 0)
            {
                field1.Top -= 20;
                btlflg1 = 0;
                btl1 = 1;
                if (ba4ln > 0)
                {

                }
                else
                {

                }
                DiceTimerStart.Enabled = true;
            }
            else if (btlflg2 == 1 & btl1 == 0 & btl3 == 0)
            {
                field2.Top -= 20;
                btlflg2 = 0;
                btl2 = 1;                
                if (ba4ln > 0)
                {

                }
                else
                {

                }
                DiceTimerStart.Enabled = true;
            }
            else if (btlflg3 == 1 & btl1 == 0 & btl2 == 0)
            {
                field3.Top -= 20;
                btlflg3 = 0;
                btl3 = 1;                
                if (ba4ln > 0)
                {
                }
                else
                {

                }
                DiceTimerStart.Enabled = true;
            }
            else if(btlflg1 == 0 & btlflg2 == 0 & btlflg3 == 0)
            {
                turn++;
                label3.Text = turn.ToString();
                NowPhase = 4;
                Phase_on();
            }
        }
        private void dbtlp1()
        {
            if (btlflg6 == 1)
            {
                field6.Top += 20;
                btl6 = 1;
                if (ba9ln > 0)
                {

                }
                else
                {

                }
                DiceTimerStart.Enabled = true;
            }
            else if (btlflg7 == 1 & btl6 == 0)
            {
                field7.Top += 20;
                btl7 = 1;
                if (ba9ln > 0)
                {

                }
                else
                {

                }
                DiceTimerStart.Enabled = true;
            }
            else if (btlflg8 == 1 & btl6 == 0 & btl7 == 0)
            {
                field8.Top += 20;
                btl8 = 1;
                if (ba9ln > 0)
                {
                }
                else
                {

                }
                DiceTimerStart.Enabled = true;
            }
            else
            {
                bPara();
                
            }
        }
        private void abtlp2()
        {
            if (btl1 == 1)
            {
                if (ba1d1 >= 7 - dicenmb)
                {
                    atk = ba1p1;
                    ac = ba6ac;
                    hp = ba6hp;
                    dmg = ac - atk;
                    ba6hp = hp + ac - atk;                    
                }
                else if (ba1d2 >=  dicenmb)
                {
                    atk = ba1p2;
                    ac = ba6ac;
                    hp = ba6hp;
                    dmg = ac - atk;
                    ba6hp = hp + ac - atk;
                }
                else
                {
                    Field6Damage.Visible = true;
                    Field6Damage.Text = "miss";
                }                     
                if (ba6ln > 0)
                {
                    Field6Damage.Visible = true;
                    Field6Damage.Text = dmg.ToString();
                }
                else
                {
                    EnemyDamage.Visible = true;
                    EnemyDamage.Text = dmg.ToString();
                }
                
                if (ba6hp <= 0)
                {
                    field6.BackgroundImage = imgnull;
                    ba6ln = 0;
                }
                sound_hit();
                DmgEffectTime.Enabled = true;
                field1.Top += 20;
                btl1 = 0;
            }
            else if (btl2 == 1)
            {
                if (ba2d1 >= 7 - dicenmb)
                {
                    atk = ba2p1;
                    ac = ba7ac;
                    hp = ba7hp;
                    dmg = ac - atk;
                    ba7hp = hp + ac - atk;
                }
                else if (ba2d2 >= dicenmb)
                {
                    atk = ba2p2;
                    ac = ba7ac;
                    hp = ba7hp;
                    dmg = ac - atk;
                    ba7hp = hp + ac - atk;
                }
                else
                {
                    Field7Damage.Visible = true;
                    Field7Damage.Text = "miss";
                }
                
                if (ba7ln > 0)
                {
                    Field7Damage.Visible = true;
                    Field7Damage.Text = dmg.ToString();
                }
                else
                {
                    EnemyDamage.Visible = true;
                    EnemyDamage.Text = dmg.ToString();
                }
                
                if (ba7hp <= 0)
                {
                    field7.BackgroundImage = imgnull;
                    ba7ln = 0;
                }
                sound_hit();
                DmgEffectTime.Enabled = true;
                field2.Top += 20;
                btl2 = 0;
            }
            else if (btl3 == 1)
            {
                if (ba3d1 >= 7 - dicenmb)
                {
                    atk = ba3p1;
                    ac = ba8ac;
                    hp = ba8hp;
                    dmg = ac - atk;
                    ba8hp = hp + ac - atk;
                }
                else if (ba3d2 >= dicenmb)
                {
                    atk = ba3p2;
                    ac = ba8ac;
                    hp = ba8hp;
                    dmg = ac - atk;
                    ba8hp = hp + ac - atk;
                }
                else
                {
                    Field8Damage.Visible = true;
                    Field8Damage.Text = "miss";
                }
               
                if (ba8ln > 0)
                {
                    Field8Damage.Visible = true;
                    Field8Damage.Text = dmg.ToString();
                }
                else
                {
                    EnemyDamage.Visible = true;
                    EnemyDamage.Text = dmg.ToString();
                }
                
                if (ba8hp <= 0)
                {
                    field8.BackgroundImage = imgnull;
                    ba8ln = 0;
                }
                sound_hit();
                DmgEffectTime.Enabled = true;
                field3.Top += 20;
                btl3 = 0;
            }
            bPara();
        }
        private void dbtlp2()
        {
            if (btl6 == 1)
            {
                if (ba6d1 >= dicenmb)
                {
                    atk = ba6p1;
                    ac = ba1ac;
                    hp = ba1hp;
                    dmg = ac - atk;
                    ba1hp = hp + ac - atk;
                }
                else if (ba1d2 >= 6 - dicenmb)
                {
                    atk = ba6p2;
                    ac = ba1ac;
                    hp = ba1hp;
                    dmg = ac - atk;
                    ba1hp = hp + ac - atk;
                }
                else
                {
                    Field1Damage.Visible = true;
                    Field1Damage.Text = "miss";
                }
                btl6 = 0;
                btlflg6 = 0;
                if (ba1ln > 0)
                {
                    Field1Damage.Visible = true;
                    Field1Damage.Text = dmg.ToString();
                }
                else
                {
                    UserDamage.Visible = true;
                    UserDamage.Text = dmg.ToString();
                }
                sound_hit();
                DmgEffectTime.Enabled = true;
                field6.Top -= 20;
                if (ba1hp <= 0)
                {
                    field1.BackgroundImage = imgnull;
                    ba1ln = 0;
                }
            }
            else if (btl7 == 1)
            {
                if (ba7d1 >= dicenmb)
                {
                    atk = ba7p1;
                    ac = ba2ac;
                    hp = ba2hp;
                    dmg = ac - atk;
                    ba2hp = hp + ac - atk;
                }
                else if (ba7d2 >= 6 - dicenmb)
                {
                    atk = ba7p2;
                    ac = ba2ac;
                    hp = ba2hp;
                    dmg = ac - atk;
                    ba2hp = hp + ac - atk;
                }
                else
                {
                    Field2Damage.Visible = true;
                    Field2Damage.Text = "miss";
                }
                btl7 = 0;
                btlflg7 = 0;
                if (ba2ln > 0)
                {
                    Field2Damage.Visible = true;
                    Field2Damage.Text = dmg.ToString();
                }
                else
                {
                    UserDamage.Visible = true;
                    UserDamage.Text = dmg.ToString();
                }
                sound_hit();
                DmgEffectTime.Enabled = true;
                field7.Top -= 20;
                if (ba2hp <= 0)
                {
                    field2.BackgroundImage = imgnull;
                    ba2ln = 0;
                }
            }
            else if (btl8 == 1)
            {
                if (ba8d1 <= dicenmb)
                {
                    atk = ba8p1;
                    ac = ba3ac;
                    hp = ba3hp;
                    dmg = ac - atk;
                    ba3hp = hp + ac - atk;
                }
                else if (ba8d2 <= 6 - dicenmb)
                {
                    atk = ba8p2;
                    ac = ba3ac;
                    hp = ba3hp;
                    dmg = ac - atk;
                    ba3hp = hp + ac - atk;
                }
                else
                {
                    Field3Damage.Visible = true;
                    Field3Damage.Text = "miss";
                }
                btl8 = 0;
                btlflg8 = 0;
                if (ba3ln > 0)
                {
                    Field3Damage.Visible = true;
                    Field3Damage.Text = dmg.ToString();
                }
                else
                {
                    UserDamage.Visible = true;
                    UserDamage.Text = dmg.ToString();
                }
                sound_hit();
                DmgEffectTime.Enabled = true;
                field8.Top -= 20;
                if (ba3hp <= 0)
                {
                    field3.BackgroundImage = imgnull;
                    ba3ln = 0;
                }
            }
            if (next == "on") dbtlp1();
        }
        private void DmgEffectTime_Tick(object sender, EventArgs e)
        {
            Field6Damage.Visible = false;
            Field7Damage.Visible = false;
            Field8Damage.Visible = false;
            EnemyDamage.Visible = false;
            DmgEffectTime.Enabled = false;
            abtlp1();
        }
        private void DiceTimerStart_Tick(object sender, EventArgs e)
        {
            seed = Environment.TickCount;
            Random rdm6 = new Random(seed++);
            dicenmb = rdm6.Next(1, 6);
            myDice.Visible = true;
            myDice.BackgroundImage = imgd[dicenmb];
            //if (who == "m") myDice.BackgroundImage = imgd[dicenmb];
            //else if (who == "y") youDice.BackgroundImage = imgd[dicenmb];
            t++;
            if (t == 20)
            {
                //MessageBox.Show("DiceTimer50");
                t = 0;
                DiceTimerStart.Enabled = false;
                DiceTimerEnd.Enabled = true;
            }
        }
        private void DiceTimerEnd_Tick(object sender, EventArgs e)
        {
            DiceTimerEnd.Enabled = false;
            myDice.Visible = false;
            abtlp2();
            //Dice();
        }
        private void btn_Enable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button26.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (mtcst >= mc1)
            {
                if (s != 1)
                {
                    if (s == 2)button2.Top += 10;
                    else if (s == 3)button3.Top += 10;
                    else if (s == 4)button4.Top += 10;
                    else if (s == 5)button5.Top += 10;
                    s = 1;
                    M1Cost.Visible = false;
                    button1.Top -= 10;
                    textBox1.Text = "場を選択してください。";
                    if (mt1 == 1)     //  ct = 1：モンスター
                    {
                        bacheck1();
                    }
                    else if (mt1 == 2)     //  ct = 2：アイテムorスキル
                    {
                        bacheck2();
                    }
                }
                else
                {
                    s = 0;
                    bacheck1();
                    bacheck2();
                    button1.Top += 10;
                    M1Cost.Visible = true;
                    textBox1.Text = "";
                }
            }
            else textBox1.Text = "コスト不足です。";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (mtcst >= mc2)
            {
                if (s != 2)
                {
                    if (s == 1)button1.Top += 10;
                    else if (s == 3)button3.Top += 10;
                    else if (s == 4)button4.Top += 10;
                    else if (s == 5)button5.Top += 10;
                    s = 2;
                    M2Cost.Visible = false;
                    button2.Top -= 10;                    
                    textBox1.Text = "場を選択してください。";
                    if (mt2 == 1)     //  ct = 1：モンスター
                    {
                        bacheck1();
                    }
                    else if (mt2 == 2)     //  ct = 2：アイテムorスキル
                    {
                        bacheck2();
                    }
                }
                else
                {
                    s = 0;
                    bacheck1();
                    bacheck2();
                    button2.Top += 10;
                    M2Cost.Visible = true;
                    textBox1.Text = "";
                }
            }
            else textBox1.Text = "コスト不足です。";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (mtcst >= mc3)
            {
                if (s != 3)
                {
                    if (s == 1) button1.Top += 10;
                    else if (s == 2) button2.Top += 10;
                    else if (s == 4) button4.Top += 10;
                    else if (s == 5) button5.Top += 10;
                    s = 3;
                    M3Cost.Visible = false;
                    button3.Top -= 10;
                    textBox1.Text = "場を選択してください。";
                    if (mt3 == 1)     //  ct = 1：モンスター
                    {
                        bacheck1();
                    }
                    else if (mt3 == 2)     //  ct = 2：アイテムorスキル
                    {
                        bacheck2();
                    }
                }
                else
                {
                    s = 0;
                    bacheck1();
                    bacheck2();
                    button3.Top += 10;
                    M3Cost.Visible = true;
                    textBox1.Text = "";
                }
            }
            else textBox1.Text = "コスト不足です。";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (mtcst >= mc4)
            {
                if (s != 4)
                {
                    if (s == 1) button1.Top += 10;
                    else if (s == 2) button2.Top += 10;
                    else if (s == 3) button3.Top += 10;
                    else if (s == 5) button5.Top += 10;
                    s = 4;
                    M4Cost.Visible = false;
                    button4.Top -= 10;                    
                    textBox1.Text = "場を選択してください。";
                    if (mt4 == 1)     //  ct = 1：モンスター
                    {
                        bacheck1();
                    }
                    else if (mt4 == 2)     //  ct = 2：アイテムorスキル
                    {
                        bacheck2();
                    }
                }
                else
                {
                    s = 0;
                    bacheck1();
                    bacheck2();
                    button4.Top += 10;
                    M4Cost.Visible = true;
                    textBox1.Text = "";
                }
            }
            else textBox1.Text = "コスト不足です。";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (mtcst >= mc5)
            {
                if (s != 5)
                {
                    if (s == 1) button1.Top += 10;
                    else if (s == 2) button2.Top += 10;
                    else if (s == 3) button3.Top += 10;
                    else if (s == 4) button4.Top += 10;
                    s = 5;
                    M5Cost.Visible = false;
                    button5.Top -= 10;
                    textBox1.Text = "場を選択してください。";
                    if (mt5 == 1)     //  ct = 1：モンスター
                    {
                        bacheck1();
                    }
                    else if (mt5 == 2)     //  ct = 2：アイテムorスキル
                    {
                        bacheck2();
                    }
                }
                else
                {
                    s = 0;
                    bacheck1();
                    bacheck2();
                    button5.Top += 10;
                    M5Cost.Visible = true;
                    textBox1.Text = "";
                }
            }
            else textBox1.Text = "コスト不足です。";
        }
        private void bacheck1()
        {
            if (ba1ln == 0)
            {
                field1.BackgroundImage = imgselect;
                field1.Cursor = Cursors.Hand;
                if (s == 0)
                {
                    field1.BackgroundImage = imgnull;
                    field1.Cursor = Cursors.Default;
                }
            }
            if (ba2ln == 0)
            {
                field2.BackgroundImage = imgselect;
                field2.Cursor = Cursors.Hand;
                if (s == 0)
                {
                    field2.BackgroundImage = imgnull;
                    field2.Cursor = Cursors.Default;
                }
            }
            if (ba3ln == 0)
            {
                field3.BackgroundImage = imgselect;
                field3.Cursor = Cursors.Hand;
                if (s == 0)
                {
                    field3.BackgroundImage = imgnull;
                    field3.Cursor = Cursors.Default;
                }
            }
        }
        private void bacheck2()
        {
            if (ba4ln == 0)
            {
                field4.BackgroundImage = imgselect;
                field4.Cursor = Cursors.Hand;
                if (s == 0)
                {
                    field4.BackgroundImage = imgnull;
                    field4.Cursor = Cursors.Default;
                }
            }
            if (ba5ln == 0)
            {
                field5.BackgroundImage = imgselect;
                field5.Cursor = Cursors.Hand;
                if (s == 0)
                {
                    field5.BackgroundImage = imgnull;
                    field5.Cursor = Cursors.Default;
                }
            }
        }
        private void field1_Click(object sender, EventArgs e)
        {
            if (s > 0)
            {
                if (ba1ln == 0)
                {
                    //手札処理
                    if (s == 1)
                    {
                        ba1ln = mln1;
                        button1.BackgroundImage = null;
                        button1.Visible = false;
                        mtcst = mtcst - mc1;
                        mcst = mcst + mcc1;
                        mln1 = 0;
                        button1.Top += 10;
                        mthd--;
                    }
                    else if (s == 2)
                    {
                        ba1ln = mln2;
                        button2.BackgroundImage = null;
                        button2.Visible = false;
                        mtcst = mtcst - mc2;
                        mcst = mcst + mcc2;
                        mln2 = 0;
                        button2.Top += 10;
                        mthd--;
                    }
                    else if (s == 3)
                    {
                        ba1ln = mln3;
                        button3.BackgroundImage = null;
                        button3.Visible = false;
                        mtcst = mtcst - mc3;
                        mcst = mcst + mcc3;
                        mln3 = 0;
                        button3.Top += 10;
                        mthd--;
                    }
                    else if (s == 4)
                    {
                        ba1ln = mln4;
                        button4.BackgroundImage = null;
                        button4.Visible = false;
                        mtcst = mtcst - mc4;
                        mcst = mcst + mcc4;
                        mln4 = 0;
                        button4.Top += 10;
                        mthd--;
                    }
                    else if (s == 5)
                    {
                        ba1ln = mln5;
                        button5.BackgroundImage = null;
                        button5.Visible = false;
                        mtcst = mtcst - mc5;
                        mcst = mcst + mcc5;
                        mln5 = 0;
                        button5.Top += 10;
                        mthd--;
                    }
                    for (i = 0; i < 20; i++)
                    {
                        ba1[i] = mdk[ba1ln, i];
                    }
                    ba1set = 1;
                    s = 0;
                    bacheck1();
                    bPara();
                    ba1set = 0;
                    label4.Text = mtcst.ToString();
                }
            }
            // 場のカードを入れ替え(ステータス保持)
            else if (ba1ln > 0 & ba1move == 0 & ba2move == 0 & ba3move == 0)
            {
                ba1move = 1;
                field2.BackgroundImage = imgselect;
                field2.Cursor = Cursors.Hand;
                field3.BackgroundImage = imgselect;
                field3.Cursor = Cursors.Hand;
            }
            else if (ba1ln > 0 & ba1move > 0 & ba2move == 0 & ba3move == 0)
            {
                ba1move = 0;
                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];
                field2.Cursor = Cursors.Default;
                field3.Cursor = Cursors.Default;
            }
            else if (ba2move > 0)
            {
                ba2move = 0;

                ith = ba1ln;
                ba1ln = ba2ln;
                ba2ln = ith;

                ith = ba1id;
                ba1id = ba2id;
                ba2id = ith;

                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];

                ith = ba1c;
                ba1c = ba2c;
                ba2c = ith;

                ith = ba1cc;
                ba1cc = ba2cc;
                ba2cc = ith;

                ith = ba1ac;
                ba1ac = ba2ac;
                ba2ac = ith;

                ith = ba1hp;
                ba1hp = ba2hp;
                ba2hp = ith;

                ith = ba1d1;
                ba1d1 = ba2d1;
                ba2d1 = ith;

                ith = ba1d2;
                ba1d2 = ba2d2;
                ba2d2 = ith;

                ith = ba1p1;
                ba1p1 = ba2p1;
                ba2p1 = ith;

                ith = ba1p2;
                ba1p2 = ba2p2;
                ba2p2 = ith;

                field2.Cursor = Cursors.Default;
                field3.Cursor = Cursors.Default;
            }
            else if (ba3move > 0)
            {
                ba3move = 0;

                ith = ba1ln;
                ba1ln = ba3ln;
                ba3ln = ith;

                ith = ba1id;
                ba1id = ba3id;
                ba3id = ith;

                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];

                ith = ba1c;
                ba1c = ba3c;
                ba3c = ith;

                ith = ba1cc;
                ba1cc = ba3cc;
                ba3cc = ith;

                ith = ba1ac;
                ba1ac = ba3ac;
                ba3ac = ith;

                ith = ba1hp;
                ba1hp = ba3hp;
                ba3hp = ith;

                ith = ba1d1;
                ba1d1 = ba3d1;
                ba3d1 = ith;

                ith = ba1d2;
                ba1d2 = ba3d2;
                ba3d2 = ith;

                ith = ba1p1;
                ba1p1 = ba3p1;
                ba3p1 = ith;

                ith = ba1p2;
                ba1p2 = ba3p2;
                ba3p2 = ith;

                field2.Cursor = Cursors.Default;
                field3.Cursor = Cursors.Default;
            }
        }
        private void field2_Click(object sender, EventArgs e)
        {
            if (s > 0)
            {
                if (ba2ln == 0)
                {
                    if (s == 1)
                    {
                        ba2ln = mln1;
                        button1.BackgroundImage = null;
                        button1.Visible = false;
                        mtcst = mtcst - mc1;
                        mcst = mcst + mcc1;
                        mln1 = 0;
                        button1.Top += 10;
                        mthd--;
                    }
                    else if (s == 2)
                    {
                        ba2ln = mln2;
                        button2.BackgroundImage = null;
                        button2.Visible = false;
                        mtcst = mtcst - mc2;
                        mcst = mcst + mcc2;
                        mln2 = 0;
                        button2.Top += 10;
                        mthd--;
                    }
                    else if (s == 3)
                    {
                        ba2ln = mln3;
                        button3.BackgroundImage = null;
                        button3.Visible = false;
                        mtcst = mtcst - mc3;
                        mcst = mcst + mcc3;
                        mln3 = 0;
                        button3.Top += 10;
                        mthd--;
                    }
                    else if (s == 4)
                    {
                        ba2ln = mln4;
                        button4.BackgroundImage = null;
                        button4.Visible = false;
                        mtcst = mtcst - mc4;
                        mcst = mcst + mcc4;
                        mln4 = 0;
                        button4.Top += 10;
                        mthd--;
                    }
                    else if (s == 5)
                    {
                        ba2ln = mln5;
                        button5.BackgroundImage = null;
                        button5.Visible = false;
                        mtcst = mtcst - mc5;
                        mcst = mcst + mcc5;
                        mln5 = 0;
                        button5.Top += 10;
                        mthd--;
                    }
                    for (i = 0; i < 20; i++)
                    {
                        ba2[i] = mdk[ba2ln, i];
                    }
                    ba2set = 1;
                    s = 0;
                    bacheck1();
                    bPara();
                    ba2set = 0;
                    label4.Text = mtcst.ToString();
                }
            }
            // 場のカードを入れ替え(ステータス保持)
            else if (ba2ln > 0 & ba1move == 0 & ba2move == 0 & ba3move == 0)
            {
                ba2move = 1;
                field1.BackgroundImage = imgselect;
                field1.Cursor = Cursors.Hand;
                field3.BackgroundImage = imgselect;
                field3.Cursor = Cursors.Hand;
            }
            else if (ba2ln > 0 & ba1move == 0 & ba2move > 0 & ba3move == 0)
            {
                ba2move = 0;
                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];
                field1.Cursor = Cursors.Default;
                field3.Cursor = Cursors.Default;
            }
            else if (ba1move > 0)
            {
                ba1move = 0;

                ith = ba2ln;
                ba2ln = ba1ln;
                ba1ln = ith;

                ith = ba2id;
                ba2id = ba1id;
                ba1id = ith;

                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];

                ith = ba2c;
                ba2c = ba1c;
                ba1c = ith;

                ith = ba2cc;
                ba2cc = ba1cc;
                ba1cc = ith;

                ith = ba2ac;
                ba2ac = ba1ac;
                ba1ac = ith;

                ith = ba2hp;
                ba2hp = ba1hp;
                ba1hp = ith;

                ith = ba2d1;
                ba2d1 = ba1d1;
                ba1d1 = ith;

                ith = ba2d2;
                ba2d2 = ba1d2;
                ba1d2 = ith;

                ith = ba2p1;
                ba2p1 = ba1p1;
                ba1p1 = ith;

                ith = ba2p2;
                ba2p2 = ba1p2;
                ba1p2 = ith;

                field1.Cursor = Cursors.Default;
                field3.Cursor = Cursors.Default;
            }
            else if (ba3move > 0)
            {
                ba3move = 0;

                ith = ba2ln;
                ba2ln = ba3ln;
                ba3ln = ith;

                ith = ba2id;
                ba2id = ba3id;
                ba3id = ith;

                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];

                ith = ba2c;
                ba2c = ba3c;
                ba3c = ith;

                ith = ba2cc;
                ba2cc = ba3cc;
                ba3cc = ith;

                ith = ba2ac;
                ba2ac = ba3ac;
                ba3ac = ith;

                ith = ba2hp;
                ba2hp = ba3hp;
                ba3hp = ith;

                ith = ba2d1;
                ba2d1 = ba3d1;
                ba3d1 = ith;

                ith = ba2d2;
                ba2d2 = ba3d2;
                ba3d2 = ith;

                ith = ba2p1;
                ba2p1 = ba3p1;
                ba3p1 = ith;

                ith = ba2p2;
                ba2p2 = ba3p2;
                ba3p2 = ith;

                field1.Cursor = Cursors.Default;
                field3.Cursor = Cursors.Default;
            }
        }
        private void field3_Click(object sender, EventArgs e)
        {
            if (s > 0)
            {
                if (ba3ln == 0)
                {
                    if (s == 1)
                    {
                        ba3ln = mln1;
                        button1.BackgroundImage = null;
                        button1.Visible = false;
                        mtcst = mtcst - mc1;
                        mcst = mcst + mcc1;
                        mln1 = 0;
                        button1.Top += 10;
                        mthd--;
                    }
                    else if (s == 2)
                    {
                        ba3ln = mln2;
                        button2.BackgroundImage = null;
                        button2.Visible = false;
                        mtcst = mtcst - mc2;
                        mcst = mcst + mcc2;
                        mln2 = 0;
                        button2.Top += 10;
                        mthd--;
                    }
                    else if (s == 3)
                    {
                        ba3ln = mln3;
                        button3.BackgroundImage = null;
                        button3.Visible = false;
                        mtcst = mtcst - mc3;
                        mcst = mcst + mcc3;
                        mln3 = 0;
                        button3.Top += 10;
                        mthd--;
                    }
                    else if (s == 4)
                    {
                        ba3ln = mln4;
                        button4.BackgroundImage = null;
                        button4.Visible = false;
                        mtcst = mtcst - mc4;
                        mcst = mcst + mcc4;
                        mln4 = 0;
                        button4.Top += 10;
                        mthd--;
                    }
                    else if (s == 5)
                    {
                        ba3ln = mln5;
                        button5.BackgroundImage = null;
                        button5.Visible = false;
                        mtcst = mtcst - mc5;
                        mcst = mcst + mcc5;
                        mln5 = 0;
                        button5.Top += 10;
                        mthd--;
                    }
                    for (i = 0; i < 20; i++)
                    {
                        ba3[i] = mdk[ba3ln, i];
                    }
                    ba3set = 1;
                    s = 0;
                    bacheck1();
                    bPara();
                    ba3set = 0;
                    label4.Text = mtcst.ToString();
                }
            }
            // 場のカードを入れ替え(ステータス保持)
            else if (ba3ln > 0 & ba1move == 0 & ba2move == 0 & ba3move == 0)
            {
                ba3move = 1;
                field1.BackgroundImage = imgselect;                
                field2.BackgroundImage = imgselect;
                field1.Cursor = Cursors.Hand;
                field2.Cursor = Cursors.Hand;
            }
            else if (ba3ln > 0 & ba1move == 0 & ba2move == 0 & ba3move > 0)
            {
                ba3move = 0;
                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];
                field1.Cursor = Cursors.Default;
                field2.Cursor = Cursors.Default;
            }
            else if (ba1move > 0)
            {
                ba1move = 0;

                ith = ba3ln;
                ba3ln = ba1ln;
                ba1ln = ith;

                ith = ba3id;
                ba3id = ba1id;
                ba1id = ith;

                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];

                ith = ba3c;
                ba3c = ba1c;
                ba1c = ith;

                ith = ba3cc;
                ba3cc = ba1cc;
                ba1cc = ith;

                ith = ba3ac;
                ba3ac = ba1ac;
                ba1ac = ith;

                ith = ba3hp;
                ba3hp = ba1hp;
                ba1hp = ith;

                ith = ba3d1;
                ba3d1 = ba1d1;
                ba1d1 = ith;

                ith = ba3d2;
                ba3d2 = ba1d2;
                ba1d2 = ith;

                ith = ba3p1;
                ba3p1 = ba1p1;
                ba1p1 = ith;

                ith = ba3p2;
                ba3p2 = ba1p2;
                ba1p2 = ith;

                field1.Cursor = Cursors.Default;
                field2.Cursor = Cursors.Default;
            }
            else if (ba2move > 0)
            {
                ba2move = 0;

                ith = ba3ln;
                ba3ln = ba2ln;
                ba2ln = ith;

                ith = ba3id;
                ba3id = ba2id;
                ba2id = ith;

                field1.BackgroundImage = imgs[ba1id];
                field2.BackgroundImage = imgs[ba2id];
                field3.BackgroundImage = imgs[ba3id];

                ith = ba3c;
                ba3c = ba2c;
                ba2c = ith;

                ith = ba3cc;
                ba3cc = ba2cc;
                ba2cc = ith;

                ith = ba3ac;
                ba3ac = ba2ac;
                ba2ac = ith;

                ith = ba3hp;
                ba3hp = ba2hp;
                ba2hp = ith;

                ith = ba3d1;
                ba3d1 = ba2d1;
                ba2d1 = ith;

                ith = ba3d2;
                ba3d2 = ba2d2;
                ba2d2 = ith;

                ith = ba3p1;
                ba3p1 = ba2p1;
                ba2p1 = ith;

                ith = ba3p2;
                ba3p2 = ba2p2;
                ba2p2 = ith;

                field1.Cursor = Cursors.Default;
                field2.Cursor = Cursors.Default;
            }
        }
        private void field4_Click(object sender, EventArgs e)
        {
            if (ba4ln == 0)
            {
                if (s == 1)
                {
                    ba4ln = mln1;
                    button1.BackgroundImage = null;
                    field4.BackgroundImage = imgs[ba1[1]];
                    button1.Visible = false;
                    mtcst = mtcst - mc1;
                    mcst = mcst + mcc1;
                    mln1 = 0;
                    button1.Top += 10;
                    mthd--;
                }
                else if (s == 2)
                {
                    ba4ln = mln2;
                    button2.BackgroundImage = null;
                    field4.BackgroundImage = imgs[ba2[1]];
                    button2.Visible = false;
                    mtcst = mtcst - mc2;
                    mcst = mcst + mcc2;
                    mln2 = 0;
                    button2.Top += 10;
                    mthd--;
                }
                else if (s == 3)
                {
                    ba4ln = mln3;
                    button3.BackgroundImage = null;
                    field4.BackgroundImage = imgs[ba3[1]];
                    button3.Visible = false;
                    mtcst = mtcst - mc3;
                    mcst = mcst + mcc3;
                    mln3 = 0;
                    button3.Top += 10;
                    mthd--;
                }
                else if (s == 4)
                {
                    ba4ln = mln4;
                    button4.BackgroundImage = null;
                    field4.BackgroundImage = imgs[ba4[1]];
                    button4.Visible = false;
                    mtcst = mtcst - mc4;
                    mcst = mcst + mcc4;
                    mln4 = 0;
                    button4.Top += 10;
                    mthd--;
                }
                else if (s == 5)
                {
                    ba4ln = mln5;
                    button5.BackgroundImage = null;
                    field4.BackgroundImage = imgs[ba5[1]];
                    button5.Visible = false;
                    mtcst = mtcst - mc5;
                    mcst = mcst + mcc5;
                    mln5 = 0;
                    button5.Top += 10;
                    mthd--;
                }
                for (i = 0; i < 20; i++)
                {
                    ba4[i] = mdk[ba4ln, i];
                }
                ba4set = 1;
                s = 0;
                bacheck2();
                bPara();
                ba4set = 0;
                label4.Text = mtcst.ToString();
            }
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            CardImage.BackgroundImage = imgm[mid1];
            Dice1Image.Visible = true;
            Dice2Image.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label11.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            

            Dice1Image.Size = new Size(15 * mte1d1, 15);
            Dice1Image.BackgroundImage = ipda[mte1d1];
            
            Dice2Image.Size = new Size(15 * mte1d2, 15);
            Dice2Image.BackgroundImage = ipdb[mte1d2];
            
            label7.Text = mp11.ToString();
            label8.Text = mp12.ToString();
            label15.Text = mc1.ToString();
            label17.Text = mcc1.ToString();

            label9.Visible = true;
            label9.Text = mhp1.ToString();
            label10.Visible = true;
            label10.Text = string.Format("AC: {0}", mac1);
        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            CardImage.BackgroundImage = imgm[mid2];
            Dice1Image.Visible = true;
            Dice2Image.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label11.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;

            Dice1Image.Size = new Size(15 * mte2d1, 15);
            Dice1Image.BackgroundImage = ipda[mte2d1];

            Dice2Image.Size = new Size(15 * mte2d2, 15);
            Dice2Image.BackgroundImage = ipdb[mte2d2];

            label7.Text = mp21.ToString();
            label8.Text = mp22.ToString();
            label15.Text = mc2.ToString();
            label17.Text = mcc2.ToString();
            label9.Visible = true;
            label9.Text = mhp2.ToString();
            label10.Visible = true;
            label10.Text = string.Format("AC: {0}", mac2);
        }
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {

            CardImage.BackgroundImage = imgm[mid3];
            Dice1Image.Visible = true;
            Dice2Image.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label11.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;

            Dice1Image.Size = new Size(15 * mte3d1, 15);
            Dice1Image.BackgroundImage = ipda[mte3d1];            

            Dice2Image.Size = new Size(15 * mte3d2, 15);
            Dice2Image.BackgroundImage = ipdb[mte3d2];
            
            label7.Text = mp31.ToString();
            label8.Text = mp32.ToString();
            label15.Text = mc3.ToString();
            label17.Text = mcc3.ToString();
            label9.Visible = true;
            label9.Text = mhp3.ToString();
            label10.Visible = true;
            label10.Text = string.Format("AC: {0}", mac3);
        }
        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            CardImage.BackgroundImage = imgm[mid4];
            Dice1Image.Visible = true;
            Dice2Image.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label11.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;

            Dice1Image.Size = new Size(15 * mte4d1, 15);
            Dice1Image.BackgroundImage = ipda[mte4d1];
            
            Dice2Image.Size = new Size(15 * mte4d2, 15);
            Dice2Image.BackgroundImage = ipdb[mte4d2];
            
            label7.Text = mp41.ToString();
            label8.Text = mp42.ToString();
            label15.Text = mc4.ToString();
            label17.Text = mcc4.ToString();
            label9.Visible = true;
            label9.Text = mhp4.ToString();
            label10.Visible = true;
            label10.Text = string.Format("AC: {0}", mac4);
        }
        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            CardImage.BackgroundImage = imgm[mid5];
            Dice1Image.Visible = true;
            Dice2Image.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label11.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;

            Dice1Image.Size = new Size(15 * mte5d1, 15);
            Dice1Image.BackgroundImage = ipda[mte5d1];
            
            Dice2Image.Size = new Size(15 * mte5d2, 15);
            Dice2Image.BackgroundImage = ipdb[mte5d2];
            
            label7.Text = mp51.ToString();
            label8.Text = mp52.ToString();
            label15.Text = mc5.ToString();
            label17.Text = mcc5.ToString();
            label9.Visible = true;
            label9.Text = mhp5.ToString();
            label10.Visible = true;
            label10.Text = string.Format("AC: {0}", mac5);
        }
        private void field1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ba1ln > 0)
            {
                CardImage.BackgroundImage = imgm[ba1id];
                Dice1Image.Visible = true;
                Dice2Image.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;


                Dice1Image.Size = new Size(15 * ba1d1, 15);
                Dice1Image.BackgroundImage = ipda[ba1d1];

                Dice2Image.Size = new Size(15 * ba1d2, 15);
                Dice2Image.BackgroundImage = ipdb[ba1d2];

                label7.Text = ba1p1.ToString();
                label8.Text = ba1p2.ToString();
                label15.Text = ba1c.ToString();
                label17.Text = ba1cc.ToString();
                label9.Visible = true;
                label9.Text = ba1hp.ToString();
                label10.Visible = true;
                label10.Text = string.Format("AC: {0}", ba1ac);
                label11.Visible = true;
            }
            else
            {
                CardImage.BackgroundImage = null;
                Dice1Image.Visible = false;
                Dice2Image.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
            }
        }
        private void field2_MouseMove(object sender, MouseEventArgs e)
        {
            if (ba2ln > 0)
            {
                CardImage.BackgroundImage = imgm[ba2id];
                Dice1Image.Visible = true;
                Dice2Image.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;


                Dice1Image.Size = new Size(15 * ba2d1, 15);
                Dice1Image.BackgroundImage = ipda[ba2d1];

                Dice2Image.Size = new Size(15 * ba2d2, 15);
                Dice2Image.BackgroundImage = ipdb[ba2d2];

                label7.Text = ba2p1.ToString();
                label8.Text = ba2p2.ToString();
                label15.Text = ba2c.ToString();
                label17.Text = ba2cc.ToString();
                label9.Visible = true;
                label9.Text = ba2hp.ToString();
                label10.Visible = true;
                label10.Text = string.Format("AC: {0}", ba2ac);
                label11.Visible = true;
            }
            else
            {
                CardImage.BackgroundImage = null;
                Dice1Image.Visible = false;
                Dice2Image.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
            }
        }
        private void field3_MouseMove(object sender, MouseEventArgs e)
        {
            if (ba3ln > 0)
            {
                CardImage.BackgroundImage = imgm[ba3id];
                Dice1Image.Visible = true;
                Dice2Image.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;


                Dice1Image.Size = new Size(15 * ba3d1, 15);
                Dice1Image.BackgroundImage = ipda[ba3d1];

                Dice2Image.Size = new Size(15 * ba3d2, 15);
                Dice2Image.BackgroundImage = ipdb[ba3d2];

                label7.Text = ba3p1.ToString();
                label8.Text = ba3p2.ToString();
                label15.Text = ba3c.ToString();
                label17.Text = ba3cc.ToString();
                label9.Visible = true;
                label9.Text = ba3hp.ToString();
                label10.Visible = true;
                label10.Text = string.Format("AC: {0}", ba3ac);
                label11.Visible = true;
            }
            else
            {
                CardImage.BackgroundImage = null;
                Dice1Image.Visible = false;
                Dice2Image.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
            }
        }
        private void field6_MouseMove(object sender, MouseEventArgs e)
        {
            if (ba6ln > 0)
            {
                CardImage.BackgroundImage = imgm[ba6id];
                Dice1Image.Visible = true;
                Dice2Image.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;


                Dice1Image.Size = new Size(15 * ba6d1, 15);
                Dice1Image.BackgroundImage = ipda[ba6d1];

                Dice2Image.Size = new Size(15 * ba6d2, 15);
                Dice2Image.BackgroundImage = ipdb[ba6d2];

                label7.Text = ba6p1.ToString();
                label8.Text = ba6p2.ToString();
                label15.Text = ba6c.ToString();
                label17.Text = ba6cc.ToString();
                label9.Visible = true;
                label9.Text = ba6hp.ToString();
                label10.Visible = true;
                label10.Text = string.Format("AC: {0}", ba6ac);
                label11.Visible = true;
            }
            else
            {
                CardImage.BackgroundImage = null;
                Dice1Image.Visible = false;
                Dice2Image.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
            }
        }
        private void field7_MouseMove(object sender, MouseEventArgs e)
        {
            if (ba7ln > 0)
            {
                CardImage.BackgroundImage = imgm[ba7id];
                Dice1Image.Visible = true;
                Dice2Image.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;


                Dice1Image.Size = new Size(15 * ba7d1, 15);
                Dice1Image.BackgroundImage = ipda[ba7d1];

                Dice2Image.Size = new Size(15 * ba7d2, 15);
                Dice2Image.BackgroundImage = ipdb[ba7d2];

                label7.Text = ba7p1.ToString();
                label8.Text = ba7p2.ToString();
                label15.Text = ba7c.ToString();
                label17.Text = ba7cc.ToString();
                label9.Visible = true;
                label9.Text = ba7hp.ToString();
                label10.Visible = true;
                label10.Text = string.Format("AC: {0}", ba7ac);
                label11.Visible = true;
            }
            else
            {
                CardImage.BackgroundImage = null;
                Dice1Image.Visible = false;
                Dice2Image.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
            }
        }
        private void field8_MouseMove(object sender, MouseEventArgs e)
        {
            if (ba8ln > 0)
            {
                CardImage.BackgroundImage = imgm[ba8id];
                Dice1Image.Visible = true;
                Dice2Image.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;


                Dice1Image.Size = new Size(15 * ba8d1, 15);
                Dice1Image.BackgroundImage = ipda[ba8d1];

                Dice2Image.Size = new Size(15 * ba8d2, 15);
                Dice2Image.BackgroundImage = ipdb[ba8d2];

                label7.Text = ba8p1.ToString();
                label8.Text = ba8p2.ToString();
                label15.Text = ba8c.ToString();
                label17.Text = ba8cc.ToString();
                label9.Visible = true;
                label9.Text = ba8hp.ToString();
                label10.Visible = true;
                label10.Text = string.Format("AC: {0}", ba8ac);
                label11.Visible = true;
            }
            else
            {
                CardImage.BackgroundImage = null;
                Dice1Image.Visible = false;
                Dice2Image.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
            }
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            CardImage.BackgroundImage = null;
            
            Dice1Image.Visible = false;
            Dice2Image.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            toolStrip1.Size = new Size(884, 5);
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = true;
            trackBar1.Location = new Point(7, 0);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            volume = trackBar1.Value;
            sound_volume();
        }
        private void toolStrip1_MouseEnter(object sender, EventArgs e)
        {
            toolStrip1.Size = new Size(884, 25);
        }
        //Button26のClickイベントハンドラ
        public void Button26_Click(object sender, EventArgs e)
        {
            //turn++;
            DialogResult result = MessageBox.Show("メインフェイズを終了しますか？","",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.None,
            MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                button26.Visible = false;
                mainflag = 3;
            }
            else if (result == DialogResult.No)
            {

            }
        }
        private void Phase_on()
        {
            //Phase0："Draw Phase"A and B 
            //Phase1："Attack Set Phase"ユーザーA
            //Phase2："Defence Set Phase"ユーザーB
            //Phase3："Battle Phase"A→B
            //Phase4："Draw Phase";
            //Phase5："Attack Set Phase"ユーザーB
            //Phase6："Defence Set Phase"ユーザーA
            //Phase7："Battle Phase"B→A
            //Phase8："Draw Phase"A and B
            //Phase1に戻る。

            if (NowPhase == 0) obi.Text = "対戦開始";
            else if (NowPhase == 1) obi.Text = string.Format("{0} Turn",turn);
            else if (NowPhase == 2) obi.Text = "セットフェイズ";
            else if (NowPhase == 3) obi.Text = "バトルフェイズ";
            else if (NowPhase == 4) obi.Text = string.Format("{0}Turn", turn);
            else if (NowPhase == 5) obi.Text = "セットフェイズ";
            else if (NowPhase == 6) obi.Text = "バトルフェイズ";
            else if (NowPhase == 7) obi.Text = "対戦終了";


            EndTime = Environment.TickCount - StartTime;

            if (StartTime == 0 & TimePara == 0)
            {
                StartTime = Environment.TickCount;
                TimePara = 1;
                obi.Visible = true;
            }
            else if (EndTime >= 1000 & TimePara == 1)
            {
                EndTime = 0;
                obi.Visible = false;
                TimePara = 2;
            }
            else if (EndTime >= 50 & TimePara == 2)
            {
                StartTime = 0;
                EndTime = 0;
                TimePara = 0;
                mainflag++;
            }
        }
        private void Time9()
        {
            StartTime = Environment.TickCount;
            for (EndTime = 0; EndTime <= 9;)
            {
                EndTime = Environment.TickCount - StartTime;
            }
        }
        private void Time50()
        {
            StartTime = Environment.TickCount;
            EndTime = 0;
            while (EndTime <= 500)
            {
                EndTime = Environment.TickCount - StartTime;
            }
        }
        private void Time1000()
        {
            if (StartTime == 0)
            {
                StartTime = Environment.TickCount;
            }
            obi.Visible = true;
            EndTime = Environment.TickCount - StartTime;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("ウィンドウを閉じますか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                sound_stop();
                ((Form2)this.Owner).fm1end();
            }
        }
        private void yjs1()
        {

            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(field1.Width, field1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            string drawString = "↑";
            //Fontを作成
            Font fnt = new Font("MS UI Gothic", 20);
            //線形グラデーション（横に黄色から赤）を作成
            LinearGradientBrush b = new LinearGradientBrush(
                                        field1.ClientRectangle,
                                        Color.Red,
                                        Color.WhiteSmoke,
                                        LinearGradientMode.Vertical);
            //StringFormatを作成
            StringFormat sf = new StringFormat();
            //文字を真ん中に表示
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            //文字を書く
            g.DrawString(drawString,fnt , b,
                field1.ClientRectangle, sf);

            //リソースを解放する
            fnt.Dispose();
            b.Dispose();
            g.Dispose();

            //PictureBox3に表示する
            field1.Image = canvas;
        }
        private void bgm_OnOff_Click(object sender, EventArgs e)
        {
            if (bgm == "off")
            {
                bgm = "on";
                sound_play();
            }
            else if (bgm == "on")
            {
                bgm = "off";
                sound_stop();
            }

        }
        // BGM用　ここから
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern int mciSendString(String command,
        StringBuilder buffer, int bufferSize, IntPtr hwndCallback);
        private static int MM_MCINOTIFY = 0x3B9;
        private static int MCI_NOTIFY_SUCCESSFUL = 1;
        // ファイルオープン（path : ファイルパス）
        private int sound_open()
        {
            // alias : デバイス名（任意の文字列）を my_sound と定義
            return mciSendString("open \"" + path + "\" alias my_sound", null, 0, IntPtr.Zero);
        }
        // ファイルクローズ
        private void sound_close()
        {
            mciSendString("close my_sound", null, 0, IntPtr.Zero);
        }
        // 再生
        private void sound_play()
        {
            bgm = "on";
            mciSendString("play my_sound from 0 notify", null, 0, this.Handle);
        }
        // 停止
        private void sound_stop()
        {
            mciSendString("stop my_sound", null, 0, IntPtr.Zero);
        }
        // 一時停止
        private void sound_pause()
        {
            mciSendString("pause my_sound", null, 0, IntPtr.Zero);
        }
        // 一時停止解除
        private void sound_resume()
        {
            mciSendString("resume my_sound", null, 0, IntPtr.Zero);
        }
        // 音量設定（volume:音量、0で最小、1000程で最大）（*1）
        private void sound_volume()
        {
            mciSendString("setaudio my_sound volume to " + volume.ToString(), null, 0, IntPtr.Zero);
        }
        // 曲終了時の処理
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == MM_MCINOTIFY && (int)m.WParam == MCI_NOTIFY_SUCCESSFUL)
            {
                sound_play();
            }
            base.WndProc(ref m);
        }

        private void sound_hit()
        {
            //URLプロパティが指定されたら自動的に再生されるようにする
            axWindowsMediaPlayer1.settings.autoStart = true;
            //オーディオファイルを指定する（自動的に再生される）
            axWindowsMediaPlayer1.URL = waveFile;
            axWindowsMediaPlayer1.settings.volume = 40;
            //autoStartがfalseのときは、次のようにして再生する
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }


        //var assm = Assembly.GetExecutingAssembly();

        // リソースとして埋め込んだ画像ファイルのストリームを取得
        // using (var stream = assm.GetManifestResourceStream("test1.n62.mp3"))
        //{
        //   // ストリームの内容をMemoryStreamにコピー
        //   var length = (int)stream.Length;
        //    var reader = new BinaryReader(stream);
        //    var memoryStream = new MemoryStream(length);

        //    memoryStream.Write(reader.ReadBytes(length), 0, length);

        // コピーしたMemoryStreamからBitmapを作成し、背景に設定

        // }



    }
}

// 控え

//パス取得

//Path = Directory.GetCurrentDirectory();
//Path = Path + "\\test.txt";
//textBox1.Text = Path;

//1文読み込み

//StreamReader file = new StreamReader("test.txt");

// while ((line[counter] = file.ReadLine()) != null)
// {
//     MessageBox.Show(line[counter]);
//     counter++;
// }

// カンマ区切り

//StreamReader file = new StreamReader("kanma.txt");
//kanma = file.ReadToEnd();
          //  string[] kanma1 = kanma.Split(',');
          //  foreach (string stData in kanma1)
          //  {
          //     MessageBox.Show(stData);
          // }