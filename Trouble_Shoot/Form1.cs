using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * ROZWIAZAC PROBLEM OBRACANIA OBRAZKA!
 * */
namespace Trouble_Shoot
{
    public partial class Form1 : Form

    {
        int ballsize = 30;
        int x1 = 0;
        int y1 = 0;
        int X = 0;
        int Y = 0;
        bool click;
        bool click1;
        public int level = 1;
        public int sublevel = 1;
        public double speed_left = 4;
        public double speed_top = 4;
        public int score = 0;
        public int speed_bottom = 4;
        public int speed_right = 4;

        public Form1()
        {
           
            InitializeComponent();

            

           

            error.Visible = false;
            test_label.Visible = true;
            square.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = true;
            pila.Visible = true;

            //_________________________________________________
                                                   //ukrycie kursora
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;                                     //widok - mozna klikac inne formularze le jest na gorze Bounds
            this.Bounds = Screen.PrimaryScreen.Bounds;
            // na caly ekran
            pictureBox4.Width = obszargry.Width - obszargry.Width/5;
            pictureBox4.Left = obszargry.Width/10;
            pictureBox4.Top = 3 * (obszargry.Height / 5);

            pictureBox3.Width = obszargry.Width - obszargry.Width / 5;
            pictureBox3.Left = obszargry.Width / 10;
            pictureBox3.Top = obszargry.Height / 10;

            pictureBox2.Height = ((pictureBox4.Top - pictureBox3.Top) + pictureBox4.Height);
            pictureBox2.Top = obszargry.Height/10;
            pictureBox2.Left = (pictureBox3.Left - pictureBox2.Width);

            pictureBox1.Height = ((pictureBox4.Top - pictureBox3.Top) + pictureBox4.Height);
            pictureBox1.Top = obszargry.Height / 10;
            pictureBox1.Left = (pictureBox3.Left + pictureBox3.Width);

           
            
            
            //pictureBox4.Top = 



            rakieta.Top = obszargry.Bottom - (obszargry.Bottom / 10); // ustawienie kursora
            
            menu.Width = obszargry.Width;
            menu.Top = (rakieta.Top + rakieta.Height);
            menu.Left = 0;
            menu.Height = menu.Top;
            menu.Visible = true;

            score_label.Top = menu.Top;
            score_label.BringToFront();

            score_point.Top = menu.Top;
            score_point.BringToFront();

            level_label.Top = menu.Top;
            level_label.BringToFront();

            level_value.Top = menu.Top;
            level_value.BringToFront();

            sublevel_label.Top = menu.Top;
            sublevel_label.BringToFront();

            sublevel_value.Top = menu.Top;
            sublevel_value.BringToFront();

            test_label.Top = menu.Top;
            test_label.BringToFront();

            winner.Left = (obszargry.Width / 2 - winner.Width / 2);
            winner.Top = (rakieta.Top + rakieta.Height);
            winner.Visible = false;
            winner.BringToFront();

            next_level.Left = (obszargry.Width / 2 - next_level.Width / 2);
            next_level.Top = (rakieta.Top + rakieta.Height); // next_level.Top = (obszargry.Height / 2 - next_level.Height / 2);
            next_level.Visible = false;
            next_level.BringToFront();

            error.Left = (obszargry.Width / 2 - error.Width / 2);
            error.Top = (rakieta.Top + rakieta.Height);
            error.Visible = false;
            error.BringToFront();

            ball_placement.Left = (obszargry.Width / 2 - ball_placement.Width / 2);
            ball_placement.Top = (rakieta.Top + rakieta.Height);
            ball_placement.Visible = false;
            ball_placement.BringToFront();

            gameover.Left = (obszargry.Width / 2 - gameover.Width / 2);
            gameover.Top = (rakieta.Top + rakieta.Height);
            gameover.Visible = false;
            gameover.BringToFront();
            KeyPreview = true;

            
            
           
            if (level == 1)
            {
                Image img = hole.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                hole.Image = img;
            }

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            level_value.Text = level.ToString();
            sublevel_value.Text = sublevel.ToString();

            if (level == 3)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                winner.Visible = true;
                ball_placement.Visible = false;
                

            }

            if (level == 2)
            {

                next_level.Visible = false;
                ball_placement.Visible = true;
               
                score_point.Text = score.ToString();
                

            }

            if (level == 1)
            {
               
                next_level.Visible = false;
                ball_placement.Visible = true;
            }

            rakieta.Left = Cursor.Position.X - (rakieta.Width / 2);
            Cursor.Show();            

            if(click == true)
            {
                if (X > 0 && X < obszargry.Width && Y < (3 * (obszargry.Height / 5) + pictureBox4.Height))
                {
                    error.Visible = true;
                    ball_placement.Visible = false;
                    pila.Visible = false;

                }
                else
                {
                    error.Visible = false;
                    pila.Top = (Y - ballsize/2);
                    pila.Left =(X - ballsize/2);
                    pila.Visible = true;
                }

            }

            else
            {
                pila.Visible = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            List<PictureBox> boxes = new List<PictureBox>();
            foreach (Control x in obszargry.Controls)
            {
                if (x is PictureBox)
                {
                    boxes.Add((PictureBox)x);
                }
            }
            */
            var pictureBoxList = obszargry.Controls.OfType<PictureBox>()
             .Where(x => x.Name.StartsWith("pictureBox"))
             .ToList();

            


            square.Visible = false;
            pila.Show();
            rakieta.Left = Cursor.Position.X - (rakieta.Width / 2);
            pila.Left -= (int)speed_left;                                   // ruch piłki - od lewej strony
            pila.Top += (int)speed_top;                                     // ruch piłki - od góry

            level_value.Text = level.ToString();
            sublevel_value.Text = sublevel.ToString();

            if (pila.Bottom >= rakieta.Top && pila.Bottom <= rakieta.Bottom)// && pila.Left >= rakieta.Left && pila.Right <= rakieta.Right)
            {
                if (pila.Left >= (rakieta.Left) && pila.Right < (rakieta.Right))// + rakieta.Right/2))
                {
                    // speed_top += 0.75F;
                    // speed_left += 0.75F;
                    speed_top = -speed_top;
                    score += 1;
                    score_point.Text = score.ToString();
                }
                /*
                // kurwaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
                if (pila.Left >= (rakieta.Left ) && pila.Right < (rakieta.Right + rakieta.Width / 2) )// + rakieta.Right/2))
                {
                    // speed_top += 0.75F;
                    // speed_left += 0.75F;
                    speed_top = -speed_top;
                    speed_left = -speed_left;

                    score += 1;
                    score_point.Text = score.ToString();
                }

               
                
                if(pila.Left >= (rakieta.Width / 2) && pila.Right < (rakieta.Right)) 
                {
                    // speed_top += 0.75F;
                    // speed_left += 0.75F;
                    speed_top = -speed_top;
                    speed_left = speed_left;

                    score += 1;
                    score_point.Text = score.ToString();
                }
             */
            }

            if (pila.Left <= obszargry.Left)
            {
                speed_left = -speed_left;
            }
            if (pila.Right >= obszargry.Right)
            {
                speed_left = -speed_left;
            }
            if (pila.Top <= obszargry.Top )
            {
                speed_top = -speed_top;
            }
            if (pila.Top >= rakieta.Top)
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
            //PRZESZKODY______________________________________________________________________________________________________________  
            //OBSTACLE1
           
            for (int i = 0; i < 4; i++)
            {
                if (level == 1)
                {
                    if(i == 0 || i==1) // picturebox 1 i 2
                    {
                        if (pila.Top <= pictureBoxList[i].Top && pila.Left >= pictureBoxList[i].Left && pila.Right <= pictureBoxList[i].Right)
                        {
                            speed_top = -speed_top;
                            //speed_left = -speed_left; //if i add this in both condition, the obstacle works properly, but only top and bottom
                        }


                        if (pila.Bottom <= pictureBoxList[i].Bottom && pila.Left >= pictureBoxList[i].Left && pila.Right <= pictureBoxList[i].Right)
                        {
                            speed_top = -speed_top;
                            //speed_left = -speed_left; // if i add this in both condition, the obstacle works properly, but only top and bottom

                        }
                    }
                    if(i ==2 || i==3) // picturebox 3 i 4
                    {
                        if (pila.Left < pictureBoxList[i].Left && pila.Top >= pictureBoxList[i].Top && pila.Bottom <= pictureBoxList[i].Bottom)
                        {
                            speed_left = -speed_left;
                            //speed_top = -speed_top;// /if i add this in both condition, the obstacle works properly, but only left and right

                        }
                        // prawa strona

                        if (pila.Right < pictureBoxList[i].Right && pila.Top >= pictureBoxList[i].Top && pila.Bottom <= pictureBoxList[i].Bottom)
                        {
                            speed_left = -speed_left; // 
                                                      //  speed_top = -speed_top; // /if i add this in both condition, the obstacle works properly, but only left and right
                        }

                    }
                   
                }

            }

          
            //Dziura___________________________________________________________________________________________________________
            if (pila.Bounds.IntersectsWith(hole.Bounds))
            {
                timer1.Enabled = false;
                next_level.Visible = true;
                sublevel += 1;
                if(sublevel == 4)
                {
                    level += 1;
                    sublevel = 1;
                }
                if( level == 3)
                {
                    winner.Visible = true;
                    next_level.Visible = false;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                }
            }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.R)
            {
                if (level == 3)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    this.Close();
                }

                /*
                pila.Top = 50;
                pila.Left = 50;
                speed_left = 4;
                speed_top = 4;
                score = 0;
                score_point.Text = score.ToString();
                */
                //timer1.Enabled = true;
                gameover.Visible = false;
                ball_placement.Visible = true;
                test_label.Visible = true;
                Cursor.Show();
                timer2.Enabled = true;


            }

            if (e.KeyCode == Keys.S)
            {
                if(level == 3)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    this.Close();
                }
                else
                {
                    pila.Top = (Y - ballsize/2);
                    pila.Left = (X - ballsize/2);
                    speed_left = 4;
                    speed_top = 4;
                    score = 0;
                    score_point.Text = score.ToString();
                    timer1.Enabled = true;
                    timer2.Enabled = false;
                    ball_placement.Visible = false;
                    test_label.Visible = false;
                    Cursor.Hide();
                    
                }
            }
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            score_label.BringToFront();
        }

        private void obszargry_MouseClick(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;

            click = true;
            test_label.Text = ("X: " + e.X + "Y: " + e.Y);

        }
        
        private void prostokat_MouseClick(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            click1 = true;
            test_label.Text = ("X: " + e.X + " Y: " + e.Y);
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }
    }
}
