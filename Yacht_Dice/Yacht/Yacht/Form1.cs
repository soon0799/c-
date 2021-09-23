using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yacht
{
    public partial class Form1 : Form
    {
        public int round = 1;
        public int[] dice = new int[5] { 0, 0, 0, 0, 0 };
        public int[] dicefix = new int[5] { 0, 0, 0, 0, 0 };
        public int dice_cnt = 0;
        public player1 p = new player1(-1, 0);
        public board_score b = new board_score();

        public struct player1
        {
            public int Totalscore;
            public int Aces;
            public int Deuces;
            public int Threes;
            public int Fours;
            public int Fives;
            public int Sixes;
            public int Bonus;
            public int Choice;
            public int FOK;
            public int FH;
            public int SS;
            public int LS;
            public int Yacht;
            public player1(int i, int j)
            {
                this.Totalscore = j;
                this.Aces = i;
                this.Deuces = i;
                this.Threes = i;
                this.Fours = i;
                this.Fives = i;
                this.Sixes = i;
                this.Bonus = j;
                this.Choice = i;
                this.FOK = i;
                this.FH = i;
                this.SS = i;
                this.LS = i;
                this.Yacht = i;
            }

        }
        public struct board_score
        {
            public int Aces;
            public int Deuces;
            public int Threes;
            public int Fours;
            public int Fives;
            public int Sixes;
            public int Bonus;
            public int Choice;
            public int FOK;
            public int FH;
            public int SS;
            public int LS;
            public int Yacht;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseDicePic1(int i)
        {
            switch (i)
            {
                case 1:
                    Dicepic1.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_1.png");
                    Dicepic1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    Dicepic1.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_2.png");
                    Dicepic1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    Dicepic1.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_3.png");
                    Dicepic1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    Dicepic1.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_4.png");
                    Dicepic1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 5:
                    Dicepic1.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_5.png");
                    Dicepic1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 6:
                    Dicepic1.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_6.png");
                    Dicepic1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
        private void ChooseDicePic2(int i)
        {
            switch (i)
            {
                case 1:
                    Dicepic2.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_1.png");
                    Dicepic2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    Dicepic2.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_2.png");
                    Dicepic2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    Dicepic2.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_3.png");
                    Dicepic2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    Dicepic2.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_4.png");
                    Dicepic2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 5:
                    Dicepic2.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_5.png");
                    Dicepic2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 6:
                    Dicepic2.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_6.png");
                    Dicepic2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
        private void ChooseDicePic3(int i)
        {
            switch (i)
            {
                case 1:
                    Dicepic3.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_1.png");
                    Dicepic3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    Dicepic3.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_2.png");
                    Dicepic3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    Dicepic3.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_3.png");
                    Dicepic3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    Dicepic3.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_4.png");
                    Dicepic3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 5:
                    Dicepic3.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_5.png");
                    Dicepic3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 6:
                    Dicepic3.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_6.png");
                    Dicepic3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
        private void ChooseDicePic4(int i)
        {
            switch (i)
            {
                case 1:
                    Dicepic4.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_1.png");
                    Dicepic4.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    Dicepic4.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_2.png");
                    Dicepic4.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    Dicepic4.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_3.png");
                    Dicepic4.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    Dicepic4.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_4.png");
                    Dicepic4.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 5:
                    Dicepic4.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_5.png");
                    Dicepic4.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 6:
                    Dicepic4.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_6.png");
                    Dicepic4.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
        private void ChooseDicePic5(int i)
        {
            switch (i)
            {
                case 1:
                    Dicepic5.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_1.png");
                    Dicepic5.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    Dicepic5.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_2.png");
                    Dicepic5.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    Dicepic5.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_3.png");
                    Dicepic5.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    Dicepic5.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_4.png");
                    Dicepic5.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 5:
                    Dicepic5.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_5.png");
                    Dicepic5.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 6:
                    Dicepic5.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\dice_6.png");
                    Dicepic5.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
           
            if (dice_cnt < 3)
            {
                dice_cnt++;                
                for (int i = 0; i < 5; i++)
                {
                    if (dicefix[i] == 0)
                    {
                        dice[i] = rand.Next(1, 7);
                        switch (i)
                        {
                            case 0:
                                ChooseDicePic1(dice[i]);
                                break;
                            case 1:
                                ChooseDicePic2(dice[i]);
                                break;
                            case 2:
                                ChooseDicePic3(dice[i]);
                                break;
                            case 3:
                                ChooseDicePic4(dice[i]);
                                break;
                            case 4:
                                ChooseDicePic5(dice[i]);
                                break;
                        }
                    }
                    else
                    {
                        dice[i] = dicefix[i];
                    }
                }

                switch (dice_cnt)
                {
                    case 1:
                        label6.Text = "1/3";
                        break;
                    case 2:
                        label6.Text = "2/3";
                        break;
                    case 3:
                        label6.Text = "3/3";
                        break;
                }
                Aces();
                Deuces();
                Threes();
                Fours();
                Fives();
                Sixes();
                Choice();
                Bonus();
                FOK();
                FH();
                SS();
                LS();
                Yacht();
            }

        }

        public void Aces()
        {
            if (p.Aces == -1)
            {
                b.Aces = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 1)
                    {
                        b.Aces++;
                    }
                }
                label20.Text = b.Aces.ToString();
            }
        }

        public void Deuces()
        {
            if (p.Deuces == -1)
            {
                b.Deuces = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 2)
                    {
                        b.Deuces = b.Deuces + 2;
                    }
                }
                label21.Text = b.Deuces.ToString();
            }
        }
        public void Threes()
        {
            if (p.Threes == -1)
            {
                b.Threes = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 3)
                    {
                        b.Threes = b.Threes + 3;
                    }
                }
                label22.Text = b.Threes.ToString();
            }
        }
        public void Fours()
        {
            if (p.Fours == -1)
            {
                b.Fours = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 4)
                    {
                        b.Fours = b.Fours + 4;
                    }
                }
                label23.Text = b.Fours.ToString();
            }
        }
        public void Fives()
        {
            if (p.Fives == -1)
            {
                b.Fives = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 5)
                    {
                        b.Fives = b.Fives + 5;
                    }
                }
                label24.Text = b.Fives.ToString();
            }
        }
        public void Sixes()
        {
            if (p.Sixes == -1)
            {
                b.Sixes = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 6)
                    {
                        b.Sixes = b.Sixes + 6;
                    }
                }
                label25.Text = b.Sixes.ToString();
            }
        }
        public void Bonus()
        {
            int ace=p.Aces;
            int deuce=p.Deuces;
            int three=p.Threes;
            int four=p.Fours;
            int five=p.Fives;
            int six=p.Sixes;

            if (p.Aces == -1) ace = 0;
            if (p.Deuces == -1) deuce = 0;
            if (p.Threes == -1) three = 0;
            if (p.Fours == -1) four = 0;
            if (p.Fives == -1) five = 0;
            if (p.Sixes == -1) six = 0;
            int tmp = ace + deuce + three + four + five + six;

            if ( tmp>= 63)
                {
                    p.Bonus = 35;
                }

                label26.Text = p.Bonus.ToString();
           
        }
        public void Choice()
        {
            if (p.Choice == -1)
            {
                b.Choice = 0;
                for (int i = 0; i < 5; i++)
                {
                    b.Choice = b.Choice + dice[i];
                }
                label27.Text = b.Choice.ToString();
            }
        }

        public void FOK()
        {
            int[] tmp = new int[6] { 0, 0, 0, 0, 0, 0 };

            if (p.FOK == -1)
            {
                b.FOK = 0;
                for(int i = 0; i < 5; i++)
                {
                    if (dice[i] == 1) tmp[0]++;
                    if (dice[i] == 2) tmp[1]++;
                    if (dice[i] == 3) tmp[2]++;
                    if (dice[i] == 4) tmp[3]++;
                    if (dice[i] == 5) tmp[4]++;
                    if (dice[i] == 6) tmp[5]++;
                }
                if(tmp[0] > 3 || tmp[1] > 3 || tmp[2] > 3 || tmp[3] > 3 || tmp[4] > 3 || tmp[5] > 3){
                    for(int i = 0; i < 5; i++)
                    {

                        b.FOK = b.FOK + dice[i];
                    }
                }
                label28.Text = b.FOK.ToString();
            }
        }

        public void FH()
        {
            int[] tmp = new int[6] { 0,0,0,0,0,0};
            int p1 = 0;
            if (p.FH == -1)
            {
                b.FH = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 1) tmp[0]++;
                    if (dice[i] == 2) tmp[1]++;
                    if (dice[i] == 3) tmp[2]++;
                    if (dice[i] == 4) tmp[3]++;
                    if (dice[i] == 5) tmp[4]++;
                    if (dice[i] == 6) tmp[5]++;
                }
                for(int i = 0; i < 6; i++)
                {
                    for(int j = i; j<6; j++)
                    {
                        if((tmp[i]==3&&tmp[j]==2)|| (tmp[i] == 2 && tmp[j] == 3))
                        {
                            p1 = 1;
                        }
                    }
                }
                if (p1 == 1)
                {
                    for(int i =0; i < 5; i++)
                    {
                        b.FH = b.FH + dice[i];
                    }
                }
                label29.Text = b.FH.ToString();
            }
        }
        public void SS()
        {
            int[] tmp = new int[6] { 0, 0, 0, 0, 0, 0 };
            int p1 = 0;
            if (p.SS == -1)
            {
                b.SS = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 1) tmp[0]++;
                    if (dice[i] == 2) tmp[1]++;
                    if (dice[i] == 3) tmp[2]++;
                    if (dice[i] == 4) tmp[3]++;
                    if (dice[i] == 5) tmp[4]++;
                    if (dice[i] == 6) tmp[5]++;
                }
                if((tmp[0] >= 1 && tmp[1] >= 1 && tmp[2] >= 1 && tmp[3] >= 1)|| (tmp[1] >= 1 && tmp[2] >= 1 && tmp[3] >= 1 && tmp[4] >= 1)|| (tmp[2] >= 1 && tmp[3] >= 1 && tmp[4] >= 1 && tmp[5] >= 1))
                {
                    p1 = 1;

                }
                if (p1 == 1)
                {
                    b.SS = 15;
                }
                label30.Text = b.SS.ToString();
            }
        }
        public void LS()
        {
            int[] tmp = new int[6] { 0, 0, 0, 0, 0, 0 };
            int p1 = 0;
            if (p.LS == -1)
            {
                b.LS = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (dice[i] == 1) tmp[0]++;
                    if (dice[i] == 2) tmp[1]++;
                    if (dice[i] == 3) tmp[2]++;
                    if (dice[i] == 4) tmp[3]++;
                    if (dice[i] == 5) tmp[4]++;
                    if (dice[i] == 6) tmp[5]++;
                }
                if ((tmp[0] >= 1 && tmp[1] >= 1 && tmp[2] >= 1 && tmp[3] >= 1&&tmp[4]>=1) || (tmp[1] >= 1 && tmp[2] >= 1 && tmp[3] >= 1 && tmp[4] >= 1&&tmp[5]>=1))
                {
                    p1 = 1;

                }
                if (p1 == 1)
                {
                    b.LS = 30;
                }
                label31.Text = b.LS.ToString();
            }
        }
        public void Yacht()
        {
            if (p.Yacht == -1)
            {
                b.Yacht = 0;
                int[] tmp = new int[5];
                tmp = dice;
                if (tmp[1] == tmp[0] && tmp[2] == tmp[1] && tmp[3] == tmp[2] && tmp[4] == tmp[3])
                {
                    b.Yacht = 50;
                }
                label32.Text = b.Yacht.ToString();
            }
        }
        public void Totalscore()
        {
            label34.Text = p.Totalscore.ToString();
        }
        private void label20_Click(object sender, EventArgs e)
        {
            if (p.Aces == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.Aces = b.Aces;
                    p.Totalscore = p.Totalscore + p.Aces;
                    dice_cnt = 0;
                    label20.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (p.Deuces == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.Deuces = b.Deuces;
                    p.Totalscore = p.Totalscore + p.Deuces;
                    dice_cnt = 0;
                    label21.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (p.Threes == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.Threes = b.Threes;
                    p.Totalscore = p.Totalscore + p.Threes;
                    dice_cnt = 0;
                    label22.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (p.Fours == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.Fours = b.Fours;
                    p.Totalscore = p.Totalscore + p.Fours;
                    dice_cnt = 0;
                    label23.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (p.Fives == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.Fives = b.Fives;
                    p.Totalscore = p.Totalscore + p.Fives;
                    dice_cnt = 0;
                    label24.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (p.Sixes == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.Sixes = b.Sixes;
                    p.Totalscore = p.Totalscore + p.Sixes;
                    dice_cnt = 0;
                    label25.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (p.Choice == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.Choice = b.Choice;
                    p.Totalscore = p.Totalscore + p.Choice;
                    dice_cnt = 0;
                    label27.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (p.FOK == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.FOK = b.FOK;
                    p.Totalscore = p.Totalscore + p.FOK;
                    dice_cnt = 0;
                    label28.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (p.FH == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.FH = b.FH;
                    p.Totalscore = p.Totalscore + p.FH;
                    dice_cnt = 0;
                    label29.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            if (p.SS == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.SS = b.SS;
                    p.Totalscore = p.Totalscore + p.SS;
                    dice_cnt = 0;
                    label30.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            if (p.LS == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.LS = b.LS;
                    p.Totalscore = p.Totalscore + p.LS;
                    dice_cnt = 0;
                    label31.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }
                }
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (p.Yacht == -1)
            {
                if (dice_cnt >= 3)
                {
                    p.Yacht = b.Yacht;
                    p.Totalscore = p.Totalscore + p.Yacht;
                    dice_cnt = 0;
                    label32.Font = new Font("맑은고딕", 14, FontStyle.Bold);
                    round++;
                    label36.Text = round.ToString();
                    Totalscore();
                    Reset();
                    if (round == 13)
                    {
                        result();
                        Close();
                    }

                }
            }
        }
        public void Reset()
        {
            dicefix = new int[5] { 0, 0, 0, 0, 0 };
            label1.Text = "unfixed";
            label2.Text = "unfixed";
            label3.Text = "unfixed";
            label4.Text = "unfixed";
            label5.Text = "unfixed";
            Dicepic1.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\FFFFFF.png");
            Dicepic2.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\FFFFFF.png");
            Dicepic3.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\FFFFFF.png");
            Dicepic4.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\FFFFFF.png");
            Dicepic5.Image = System.Drawing.Image.FromFile(@"C:\Users\User\source\repos\Yacht\FFFFFF.png");
            b.Aces = 0;
            b.Deuces = 0;
            b.Threes = 0;
            b.Fours = 0;
            b.Fives = 0;
            b.Sixes = 0;
            b.Choice = 0;
            b.FOK = 0;
            b.FH = 0;
            b.SS = 0;
            b.LS = 0;
            b.Yacht = 0;
            label6.Text = "0/3";

        }
        public void result()
        {
            Form3 newform3 = new Form3();
            newform3.label16.Text = p.Aces.ToString();
            newform3.label17.Text = p.Deuces.ToString();
            newform3.label18.Text = p.Threes.ToString();
            newform3.label19.Text = p.Fours.ToString();
            newform3.label20.Text = p.Fives.ToString();
            newform3.label21.Text = p.Sixes.ToString();
            newform3.label22.Text = p.Bonus.ToString();
            newform3.label23.Text = p.Choice.ToString();
            newform3.label24.Text = p.FOK.ToString();
            newform3.label25.Text = p.FH.ToString();
            newform3.label26.Text = p.SS.ToString();
            newform3.label27.Text = p.LS.ToString();
            newform3.label28.Text = p.Yacht.ToString();
            newform3.label29.Text = p.Totalscore.ToString();
            newform3.ShowDialog();

        }



        private void Dicepic1_Click_1(object sender, EventArgs e)
        {
            if (dice[0] != 0)
            {
                if (dicefix[0] == 0)
                {
                    dicefix[0] = dice[0];
                    label1.Text = "fixed";

                }
                else
                {
                    dicefix[0] = 0;
                    label1.Text = "Unfixed";
                }
            }
        }

        private void Dicepic2_Click_1(object sender, EventArgs e)
        {
            if (dice[0] != 0)
            {
                if (dicefix[1] == 0)
                {
                    dicefix[1] = dice[1];
                    label2.Text = "fixed";

                }
                else
                {
                    dicefix[1] = 0;
                    label2.Text = "Unfixed";
                }
            }
        }

        private void Dicepic3_Click_1(object sender, EventArgs e)
        {
            if (dice[0] != 0)
            {
                if (dicefix[2] == 0)
                {
                    dicefix[2] = dice[2];
                    label3.Text = "fixed";

                }
                else
                {
                    dicefix[2] = 0;
                    label3.Text = "Unfixed";
                }
            }
        }

        private void Dicepic4_Click_1(object sender, EventArgs e)
        {
            if (dice[0] != 0)
            {
                if (dicefix[3] == 0)
                {
                    dicefix[3] = dice[3];
                    label4.Text = "fixed";

                }
                else
                {
                    dicefix[3] = 0;
                    label4.Text = "Unfixed";
                }
            }
        }

        private void Dicepic5_Click_1(object sender, EventArgs e)
        {
            if (dice[0] != 0)
            {
                if (dicefix[4] == 0)
                {
                    dicefix[4] = dice[4];
                    label5.Text = "fixed";

                }
                else
                {
                    dicefix[4] = 0;
                    label5.Text = "Unfixed";
                }
            }
        }
    }
}
