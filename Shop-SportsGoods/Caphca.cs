﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_SportsGoods
{
    public partial class Caphca : Form
    {
        public Caphca()
        {
            InitializeComponent();
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            Brush[] colors = { Brushes.Black,
                      };

            Graphics g = Graphics.FromImage((Image)result);


            g.Clear(Color.Gray);


            Text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                Text += ALF[rnd.Next(ALF.Length)];


            g.DrawString(Text, new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));


            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void BoxCap_Click(object sender, EventArgs e)
        {
            Enter Enter = new Enter();
            Enter.Show();
            this.Hide();

            if (TextEnter.Text == this.Text)
                MessageBox.Show("Верно!");
            else
                MessageBox.Show("Ошибка!");
        }

        private void Caphca_Load(object sender, EventArgs e)
        {
            BoxCap.Image = this.CreateImage(BoxCap.Width, BoxCap.Height);
        }

        private void btnObnov_Click(object sender, EventArgs e)
        {
            BoxCap.Image = this.CreateImage(BoxCap.Width, BoxCap.Height);
        }
    }
}
