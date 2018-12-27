using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Trouble_Shoot
{
    public partial class Form1 : Form

    {
        //zainicjalizowanie zmiennych pomocniczych
        //_________________________________________________________________________________
        int ballsize = 15;
        int X = 0;
        int Y = 0;
        bool click;

        public int level = 1;
        public double speed_left = 4;
        public double speed_top = 4;
        public int score = 0;
        public int speed_bottom = 4;
        public int speed_right = 4;

        public Form1()
        {
            InitializeComponent();

            //ustawienie obramowania, położenia programu(na wierzchu ekranu), rozciągnięcie gry na cały ekran
            //_______________________________________________________________________________
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;                                     
            this.Bounds = Screen.PrimaryScreen.Bounds;
            KeyPreview = true;

            //pokazanie/ukrycie elementów pokazujących się na początku gry
            //_______________________________________________________________________________

            //komunikaty odpowiadające z rozgrywkę
            error.Visible = false;
            test_label.Visible = true;
            timer1.Enabled = false;
            timer2.Enabled = true;
            pila.Visible = true;
            menu.Visible = true;
            winner.Visible = false;
            next_level.Visible = false;
            error.Visible = false;
            ball_placement.Visible = true;
            gameover.Visible = false;

            //tła przeszkód
            tloprzeszkody21.Visible = false;
            tloprzeszkody22.Visible = false;
            tloprzeszkody31.Visible = false;
            tloprzeszkody32.Visible = false;
            tloprzeszkody33.Visible = false;
            tloprzeszkody34.Visible = false;

            //obramowania wewntętrzne paletki - służące zabezpieczeniu piłeczki
            asekuracjagora.Visible = false;
            asekuracjadol.Visible = false;
            asekuracjalewa.Visible = false;
            asekuracjaprawa.Visible = false;
            
            //stworzenie listy, w celu rozmieszczenia ram otaczjących przeszkody, we wszystkich planszach
            //_________________________________________________________________________________
            var lista = obszargry.Controls.OfType<PictureBox>().Where(x => x.Name.StartsWith("pictureBox")).ToList();

            //Pokrycie krawędzi przeszkód tłem gry, tych które nie pojawiają się na początku
            for (int i = 0; i < 8; i++)
            {
                lista[23 - i].BackColor = obszargry.BackColor;
            }

            for (int i = 0; i < 4; i++)
            {
                lista[30 - i].BackColor = Color.Gray;
            }
            for (int i = 0; i < 16; i++)
            {
                lista[15 - i].BackColor = obszargry.BackColor;
            }

            //ustalenie położenia oraz rozmiarów zarówno krawędzi otaczających paletkę(obrazek), jak i asekuracji(wewnętrzne krawęzie ktorych nie widać(mechanizm służący zabezpieczenia piłki))
            //_______________________________________________________________________________

            //rozmiary paletki
            paletagora.Width = rakieta.Width;
            paletadol.Width = rakieta.Width;
            paletalewa.Height = rakieta.Height;
            paletaprawa.Height = rakieta.Height;

            //rozmiary asekuracji(paletek wewnętrznych)
            asekuracjagora.Width = paletagora.Width - 20;
            asekuracjadol.Width = paletagora.Width - 20;
            asekuracjalewa.Height = paletalewa.Height - 10;
            asekuracjaprawa.Height = paletaprawa.Height - 10;

            //położenie paletki
            paletagora.Top = obszargry.Bottom - (obszargry.Bottom / 10);
            paletadol.Top = obszargry.Bottom - (obszargry.Bottom / 10) + rakieta.Height;
            paletalewa.Top = obszargry.Bottom - (obszargry.Bottom / 10);
            paletaprawa.Top = obszargry.Bottom - (obszargry.Bottom / 10);
            
            //położenie krawęzi wewnętrzych 
            asekuracjagora.Top = paletagora.Top + 5;
            asekuracjadol.Top = paletagora.Top + rakieta.Height - 5;
            asekuracjalewa.Top = paletagora.Top + 5;
            asekuracjaprawa.Top = paletagora.Top + 5;

            
            //ROMIARY I ROZMIESZCZNIE ELEMENTÓW ODPOWIADAJĄCYCH ZA MECHANIKĘ(OBRAMOWANIE) I TŁA 3 PLANSZ
            //_____________________________________________________________________________________________________________________________

            //PLANSZA 3
            //________________________________________________________________________________________
            //tła pszeszkód
            tloprzeszkody31.Width = (obszargry.Width - obszargry.Width / 5 + 1) / 2 - 100 - 2;
            tloprzeszkody31.Height = ((3 * obszargry.Height / 5) / 2 - 50) -1;
            tloprzeszkody31.Left = obszargry.Width / 10 + 1 + 10;
            tloprzeszkody31.Top = obszargry.Height / 10 + 1 + 10;

            tloprzeszkody32.Width = (obszargry.Width - obszargry.Width / 5 + 1) / 2 - 100 - 2;
            tloprzeszkody32.Height = ((3 * obszargry.Height / 5) / 2 - 50) -1;
            tloprzeszkody32.Left = obszargry.Width / 10 + 1 + 10;
            tloprzeszkody32.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5) / 2 - 50 + 100 + 10+1;
            
            tloprzeszkody33.Width = (obszargry.Width - obszargry.Width / 5 + 1) / 2 - 100 - 2;
            tloprzeszkody33.Height = ((3 * obszargry.Height / 5) / 2 - 50) - 1;
            tloprzeszkody33.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 + 11 ;
            tloprzeszkody33.Top = obszargry.Height / 10 + 1 + 10;

            
            tloprzeszkody34.Width = (obszargry.Width - obszargry.Width / 5 + 1) / 2 - 100 - 2;
            tloprzeszkody34.Height = ((3 * obszargry.Height / 5) / 2 - 50) -1 ;
            tloprzeszkody34.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 +11 ;
            tloprzeszkody34.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5) / 2 - 50 + 100 + 10 +1;
          
            //pionowe słupki otaczające tła przeszkód 3 planszy(8)_____________________________________
            pictureBox16.Height = ((3 * obszargry.Height / 5) / 2 - 50) ;
            pictureBox16.Left = obszargry.Width / 10 +10;
            pictureBox16.Top = obszargry.Height / 10 +10;

            pictureBox17.Height = (3 * obszargry.Height / 5) / 2 - 50;
            pictureBox17.Left = obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100 +10;
            pictureBox17.Top = obszargry.Height / 10 +10;

            pictureBox18.Height = (3 * obszargry.Height / 5) / 2 - 50;
            pictureBox18.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 +10;
            pictureBox18.Top = obszargry.Height / 10 +10;

            pictureBox19.Height = (3 * obszargry.Height / 5) / 2 - 50;
            pictureBox19.Left = obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) +10 -1;
            pictureBox19.Top = obszargry.Height / 10 +10;

            //
            pictureBox20.Height = (3 * obszargry.Height / 5) / 2 - 50;
            pictureBox20.Left = obszargry.Width / 10 +10;
            pictureBox20.Top = obszargry.Height / 10 + pictureBox20.Height + 100 +10;

            pictureBox21.Height = (3 * obszargry.Height / 5) / 2 - 50;
            pictureBox21.Left = obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100 +10;
            pictureBox21.Top = obszargry.Height / 10 + pictureBox20.Height + 100 +10;

            pictureBox22.Height = (3 * obszargry.Height / 5) / 2 - 50;
            pictureBox22.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 +10;
            pictureBox22.Top = obszargry.Height / 10 + pictureBox20.Height + 100 +10;

            pictureBox23.Height = (3 * obszargry.Height / 5) / 2 - 50;
            pictureBox23.Left = obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) +10 -1;
            pictureBox23.Top = obszargry.Height / 10 + pictureBox20.Height + 100 +10;
            //_____________________________________________________________________________________________________


            //poziome słupki otaczające tła przeszkód 3 planszy(8)_________________________________________________
            pictureBox24.Width = (obszargry.Width - obszargry.Width / 5) / 2 - 100;
            pictureBox24.Top = obszargry.Height / 10 +10 ;
            pictureBox24.Left = obszargry.Width / 10 +10;

            pictureBox25.Width = (obszargry.Width - obszargry.Width / 5) / 2 - 100;
            pictureBox25.Left = obszargry.Width / 10 +10;
            pictureBox25.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5) / 2 - 50 +10;

            pictureBox26.Width = (obszargry.Width - obszargry.Width / 5) / 2 - 100;
            pictureBox26.Top = obszargry.Height / 10 +10;
            pictureBox26.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 +10;

            pictureBox27.Width = (obszargry.Width - obszargry.Width / 5 + 1) / 2 - 100;
            pictureBox27.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 +10;
            pictureBox27.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5) / 2 - 50 +10;

            pictureBox28.Width = (obszargry.Width - obszargry.Width / 5) / 2 - 100;
            pictureBox28.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5) / 2 - 50 + 100 + (3 * obszargry.Height / 5) / 2 - 50 +10;
            pictureBox28.Left = obszargry.Width / 10 +10 ;

            pictureBox29.Width = (obszargry.Width - obszargry.Width / 5) / 2 - 100;
            pictureBox29.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5) / 2 - 50 + 100 +10;
            pictureBox29.Left = obszargry.Width / 10 +10;

            pictureBox30.Width = (obszargry.Width - obszargry.Width / 5) / 2 - 100;
            pictureBox30.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5) / 2 - 50 + 100 +10;
            pictureBox30.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 +10;

            pictureBox31.Width = (obszargry.Width - obszargry.Width / 5) / 2 - 100;
            pictureBox31.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5) / 2 - 50 + 100 + (3 * obszargry.Height / 5) / 2 - 50+10;
            pictureBox31.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 +10;
            //_____________________________________________________________________________________________________

            //PLANSZA 2
            //_____________________________________________________________________________________________________
            //tła pszeszkód
            tloprzeszkody21.Width = (obszargry.Width - obszargry.Width / 5 + 1) / 2 - 100 -2;
            tloprzeszkody21.Height = 3 * obszargry.Height / 5 - 1;
            tloprzeszkody21.Left = obszargry.Width / 10 + 1 + 5;
            tloprzeszkody21.Top = obszargry.Height / 10 + 1 + 5;

            tloprzeszkody22.Width = (obszargry.Width - obszargry.Width / 5 + 1) / 2 - 100 - 1;
            tloprzeszkody22.Height = 3 * obszargry.Height / 5 - 1;
            tloprzeszkody22.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100) + 200 + 5 + 1;
            tloprzeszkody22.Top = obszargry.Height / 10 + 1 + 5;

            //pionowe słupki otaczające tła przeszkód 2 planszy(4)_________________________________________________
            pictureBox8.Height = 3*obszargry.Height/5 ;
            pictureBox8.Left = obszargry.Width / 10 +5;
            pictureBox8.Top = obszargry.Height / 10 +5;

            pictureBox9.Height = 3 * obszargry.Height / 5;
            pictureBox9.Top = obszargry.Height / 10 +5 ;
            pictureBox9.Left = obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100 +5;

            pictureBox10.Height = 3 * obszargry.Height / 5;
            pictureBox10.Left = (obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5) / 2 - 100)+200+5;
            pictureBox10.Top = obszargry.Height / 10 +5;

            pictureBox11.Height = 3 * obszargry.Height / 5;
            pictureBox11.Top = obszargry.Height / 10 +5 ;
            pictureBox11.Left = obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5)+5;
            //_____________________________________________________________________________________________________

            //poziome słupki otaczające tła przeszkód 2 planszy(4)_________________________________________________
            pictureBox12.Width = (obszargry.Width - obszargry.Width / 5)/2 - 100;
            pictureBox12.Top = obszargry.Height / 10 +5 ;
            pictureBox12.Left = obszargry.Width / 10 +5 ;
            
            pictureBox14.Width = (obszargry.Width - obszargry.Width / 5 + 1)/2 - 100;
            pictureBox14.Left = (obszargry.Width / 10 + pictureBox14.Width) + 200 +5; 
            pictureBox14.Top = obszargry.Height / 10 +5;

            pictureBox13.Width = (obszargry.Width - obszargry.Width / 5) / 2 - 100;
            pictureBox13.Top = obszargry.Height / 10 + pictureBox8.Height +5;
            pictureBox13.Left = obszargry.Width / 10 +5;

            pictureBox15.Width = (obszargry.Width - obszargry.Width / 5 + 1) / 2 - 100;
            pictureBox15.Left = (obszargry.Width / 10 + pictureBox14.Width) + 200 +5;
            pictureBox15.Top = obszargry.Height / 10 + pictureBox8.Height +5;
            //_____________________________________________________________________________________________________


            //PLANSZA 1
            //_____________________________________________________________________________________________________
            //tło
            tloprzeszkody1.Width = obszargry.Width - obszargry.Width / 5-1;
            tloprzeszkody1.Height = 3 * obszargry.Height / 5-1;
            tloprzeszkody1.Left = obszargry.Width / 10 +1 ;
            tloprzeszkody1.Top = obszargry.Height / 10 + 1;

            //_____________________________________________________________________________________________________

            //pionowe słupki otaczające tła przeszkody 1 planszy(2)________________________________________________
            pictureBox1.Height = 3 * obszargry.Height / 5;
            pictureBox1.Left = obszargry.Width / 10;
            pictureBox1.Top = obszargry.Height / 10;

            pictureBox3.Height = 3 * obszargry.Height / 5;
            pictureBox3.Top = obszargry.Height / 10;
            pictureBox3.Left = obszargry.Width / 10 + (obszargry.Width - obszargry.Width / 5);

            //poziome słupki otaczające tła przeszkody 1 planszy(2)_______________________________________________
            pictureBox2.Width = obszargry.Width - obszargry.Width / 5;
            pictureBox2.Top = obszargry.Height / 10;
            pictureBox2.Left = obszargry.Width / 10;

            pictureBox4.Width = obszargry.Width - obszargry.Width / 5 ;
            pictureBox4.Left = obszargry.Width / 10;
            pictureBox4.Top = obszargry.Height / 10 + (3 * obszargry.Height / 5);

            //_____________________________________________________________________________________________________________________________


            //ROMIARY I ROZMIESZCZNIE ELEMENTÓW ODPOWIADAJĄCYCH ZA KOMUNIKATY - NIE ZMIENIAJĄ SIĘ PRZY PRZEJŚCIU DO KOLEJNEJ PLANSZY
            //_____________________________________________________________________________________________________________________________

            //ustawienie położenia rakiety
            rakieta.Top = obszargry.Bottom - (obszargry.Bottom / 10); // ustawienie kursora

            //ustawienie menu - to na nim są umieszone komunikaty
            menu.Width = obszargry.Width;
            menu.Top = (rakieta.Top + rakieta.Height);
            menu.Left = 0;
            menu.Height = menu.Top;       

            //logo gry
            logo.Left = obszargry.Width - logo.Width-20;
            logo.Top = (rakieta.Top + rakieta.Height);

            //romieszczenie pola "Odbicia"
            score_label.Top = menu.Top;
            score_label.Left = 0;
            score_label.BringToFront();

            //rozmieszczenie pola w którym przechowywana jest wartość odbić
            score_point.Top = menu.Top;
            score_point.Left = score_label.Width + 5;
            score_point.BringToFront();

            //romieszczenie pola "Poziom"
            level_label.Top = menu.Top;
            level_label.Left = (score_label.Width + score_point.Width + 5);
            level_label.BringToFront();

            //rozmieszczenie pola w którym przechwywana jest wartość poziomu
            level_value.Top = menu.Top;
            level_value.Left = (score_label.Width + score_point.Width + level_label.Width + 5);
            level_value.BringToFront();

            //rozmieszczenie pola tekstowego, które przechowuje wartość współrzędnych przy rozmieszczeniu piłki
            test_label.Top = menu.Top;
            test_label.Left = (score_label.Width + score_point.Width + level_label.Width + level_value.Width + 20);
            test_label.BringToFront();

            //Komunikaty, odpowiadające za menu gry
            winner.Left = (obszargry.Width / 2 - winner.Width / 2);
            winner.Top = (rakieta.Top + rakieta.Height);            
            winner.BringToFront();

            next_level.Left = (obszargry.Width / 2 - next_level.Width / 2);
            next_level.Top = (rakieta.Top + rakieta.Height); // next_level.Top = (obszargry.Height / 2 - next_level.Height / 2);            
            next_level.BringToFront();

            error.Left = (obszargry.Width / 2 - error.Width / 2);
            error.Top = (rakieta.Top + rakieta.Height);            
            error.BringToFront();

            ball_placement.Left = (obszargry.Width / 2 - ball_placement.Width / 2);
            ball_placement.Top = (rakieta.Top + rakieta.Height);            
            ball_placement.BringToFront();

            gameover.Left = (obszargry.Width / 2 - gameover.Width / 2);
            gameover.Top = (rakieta.Top + rakieta.Height);           
            gameover.BringToFront();

            //_____________________________________________________________________________________________________________________________

        }

        //Funkcja odpowiadająca za rozmieszczenie piłki
        //_____________________________________________________________________________________________________________________________
        private void timer2_Tick(object sender, EventArgs e)
        {
            //przypisanie wartości planszy oraz wykonanie ustawień dla poszczególnych plansz
            level_value.Text = level.ToString();            
            if (level == 4)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                winner.Visible = true;
                ball_placement.Visible = false;                
            }

            if (level == 3)
            {
                next_level.Visible = false;
                ball_placement.Visible = true;
                score_point.Text = score.ToString();
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

            //ustawienie obramowania paletki
            paletagora.Left = rakieta.Left;
            paletadol.Left = Cursor.Position.X - (paletadol.Width / 2);
            paletalewa.Left = Cursor.Position.X - paletagora.Width / 2;
            paletaprawa.Left = Cursor.Position.X + paletagora.Width / 2;

            //ustawienie asekruracyjnych słupków wewnątrz paletki w celu asekuracji - niewidoczne
            asekuracjagora.Left = paletagora.Left + 10;
            asekuracjadol.Left = paletagora.Left + 10;
            asekuracjalewa.Left = paletagora.Left + 10;
            asekuracjaprawa.Left = paletagora.Left + 10 + asekuracjagora.Width;

            //ustawienie położenia rakiety - podąża za kursorem
            rakieta.Left = Cursor.Position.X - (rakieta.Width / 2);
            //pokazanie kursora
            Cursor.Show();            

            //jeśli użytkownik kliknął w odpowiednie miejsce , może rozpocząć rozgrywkę, w przeciwnym wypadku pokazanie komunikatu
            if(click == true)
            {
                if (X > 0 && X < obszargry.Width && Y < (obszargry.Height / 10 + 1 + tloprzeszkody1.Height+ 10))
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

        //funkcja odpowiadająca za całą mechanikę gry, po poprawmym ustawieniu piłki przez użytkownika
        private void timer1_Tick(object sender, EventArgs e)
        {
            //podanie ścieżki do elementów, w przypadku odbicia piłki
            SoundPlayer sp = new SoundPlayer(@"C:\Users\pszemek\source\repos\Trouble_Shoot\Trouble_Shoot\Hit_short.wav");
            SoundPlayer sp1 = new SoundPlayer(@"C:\Users\pszemek\source\repos\Trouble_Shoot\Trouble_Shoot\Def1_u.wav");
            
            //ponowne utworzenie listy, w celu utworzenie mechaniki gry - piłka odbija się od przeszkód
            var pictureBoxList = obszargry.Controls.OfType<PictureBox>().Where(x => x.Name.StartsWith("pictureBox")).ToList();
            //pokazanie piłki, ustawienie położenia rakiety oraz ruch piłki(spada od góry i lewej strony)
            pila.Show();
            rakieta.Left = Cursor.Position.X - (rakieta.Width / 2);
            pila.Left -= (int)speed_left;                                   // ruch piłki - od lewej strony
            pila.Top += (int)speed_top;                                     // ruch piłki - od góry
            level_value.Text = level.ToString();

            //położenie oraz mechanika obramowania zewnętrzego oraz wewnętrego paletki
            paletagora.Left = Cursor.Position.X - (paletadol.Width / 2);
            paletadol.Left = Cursor.Position.X - (paletadol.Width / 2);
            paletalewa.Left = Cursor.Position.X - paletagora.Width/2;
            paletaprawa.Left = Cursor.Position.X + paletagora.Width / 2;

            asekuracjagora.Left = paletagora.Left + 10;
            asekuracjadol.Left = paletagora.Left + 10;
            asekuracjalewa.Left = paletagora.Left + 10;
            asekuracjaprawa.Left = paletagora.Left + 10 + asekuracjagora.Width;

            //jeśli piłka wejdzie w interakcję z obramowaniem od góry i dołu - zmienienie jej prędkości od gory na przeciwną
            if (pila.Bounds.IntersectsWith(paletagora.Bounds) || pila.Bounds.IntersectsWith(paletadol.Bounds) || pila.Bounds.IntersectsWith(asekuracjagora.Bounds) || pila.Bounds.IntersectsWith(asekuracjadol.Bounds))
            {
                speed_top = -speed_top;
                score += 1;
                score_point.Text = score.ToString();
                sp.Play();
            }

            //jeśli piłka wejdzie w interakcję z obramowaniem od lewej i prawej strony - zmienienie jej prędkości od gory na przeciwną
            if (pila.Bounds.IntersectsWith(paletalewa.Bounds) || pila.Bounds.IntersectsWith(paletaprawa.Bounds) || pila.Bounds.IntersectsWith(asekuracjalewa.Bounds) || pila.Bounds.IntersectsWith(asekuracjaprawa.Bounds))
            {
                speed_left = -speed_left;
            }

            if (pila.Left <= obszargry.Left)
            {
                speed_left = -speed_left;
            }
            if (pila.Right + ballsize/2 >= obszargry.Right)
            {
                speed_left = -speed_left;
            }
            if (pila.Top <= obszargry.Top )
            {
                speed_top = -speed_top;
            } 
            if (pila.Top +ballsize >= rakieta.Bottom)
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
            //PRZESZKODY______________________________________________________________________________________________________________              
            for (int i = 0; i < 31; i++) 
            {
                //obramowania miejsca do ktorego wpada piłka(Dziura)________________________
                if (i == 24) // picturebox 1 i 2
                {
                    if (pila.Bounds.IntersectsWith(pictureBoxList[i].Bounds))
                    {
                        speed_top = -speed_top;
                        sp1.Play();
                    }

                }

                if (i == 25 || i == 26) // picturebox 1 i 2
                {
                    if (pila.Bounds.IntersectsWith(pictureBoxList[i].Bounds))
                    {
                        speed_left = -speed_left;
                        sp1.Play();
                    }

                }
                //obramowania przeszkody 1 planszy__________________________________
                if (level == 1)
                {
                   
                    if (i==29 || i==27)
                    {
                        if (pila.Bounds.IntersectsWith(pictureBoxList[i].Bounds))
                        {
                            speed_top = -speed_top;
                            sp1.Play();
                        }

                    }
                    
                     if (i==30 || i==28) // picturebox 1 i 2
                    {
                        if (pila.Bounds.IntersectsWith(pictureBoxList[i].Bounds))
                        {
                            speed_left = -speed_left;
                            sp1.Play();
                        }

                    }                    
                }

                //obramowania przeszkody 2 planszy__________________________________
                if (level == 2)
                {
                    //________________________________________________________________
                    if((i >= 16 && i<=19)) //(i == 19 || i == 18 || i == 17 || i == 16) 
                    {
                        if (pila.Bounds.IntersectsWith(pictureBoxList[i].Bounds))
                        {
                            speed_top = -speed_top;
                            sp1.Play();
                        }

                    }

                    if (i>= 20 && i <=23)//(i == 23 || i == 22 || i == 21 || i == 20) 
                    {
                        if (pila.Bounds.IntersectsWith(pictureBoxList[i].Bounds))
                        {
                            speed_left = -speed_left;
                            sp1.Play();
                        }
                    }
                }
                //obramowania przeszkód 3 planszy
                if(level == 3)
                {
                    if (i>=0 && i<= 7)//(i == 7 || i == 6 || i == 5 || i == 4 || i == 3 || i == 2 || i == 1 || i == 0)
                    {
                        if (pila.Bounds.IntersectsWith(pictureBoxList[i].Bounds))
                        {
                            speed_top = -speed_top;
                            sp1.Play();
                        }

                    }

                    if ( i >= 8 && i<=15 )//(i == 15 || i == 14 || i == 13 || i == 12 || i == 11 || i == 10 || i == 9 || i == 8) 
                    {
                        if (pila.Bounds.IntersectsWith(pictureBoxList[i].Bounds))
                        {
                            speed_left = -speed_left;
                            sp1.Play();
                        }
                    }
                }
                
            }
            
          
            //Dziura_____________________________________________________________________________
            if (pila.Bounds.IntersectsWith(hole.Bounds))
            {
                //W przypadku kiedy piłka znajdzie się w dziurze, pokazanie komunikatu, zwiększenie poziomu planszy oraz zatrzymanie timera
                timer1.Enabled = false;
                next_level.Visible = true;
                level += 1;

                //pokazanie odpowiednich przeszkód, oraz tła 2 planszy
                if(level==2)
                {
                    tloprzeszkody1.Visible = false;
                    tloprzeszkody21.Visible = true;
                    tloprzeszkody22.Visible = true;
                    tloprzeszkody31.Visible = false;
                    tloprzeszkody32.Visible = false;
                    tloprzeszkody33.Visible = false;
                    tloprzeszkody34.Visible = false;
                    for (int i = 0; i < 8; i++)
                    {
                        pictureBoxList[23 - i].BackColor = Color.Gray;
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        pictureBoxList[30-i].BackColor = obszargry.BackColor;
                    }
                    for(int i =0; i< 16; i++)
                    {
                        pictureBoxList[15 - i].BackColor = obszargry.BackColor;
                    }
                }

                //pokazanie odpowiednich przeszkód, oraz tła 3 planszy
                if ( level == 3)
                {
                    tloprzeszkody1.Visible = false;
                    tloprzeszkody21.Visible = false;
                    tloprzeszkody22.Visible = false;
                    tloprzeszkody31.Visible = true;
                    tloprzeszkody32.Visible = true;
                    tloprzeszkody33.Visible = true;
                    tloprzeszkody34.Visible = true;

                    for (int i = 0; i < 16; i++)
                    {
                        pictureBoxList[15 - i].BackColor = Color.Gray;
                    }
                    for(int i = 0; i<8; i++)
                    {
                        pictureBoxList[23 - i].BackColor = obszargry.BackColor;
                    }

                }
                //w przypadku przejścia plansz, pokazanie komunikatu o wygranej, koniec gry
                if (level == 4)
                {
                    winner.Visible = true;
                    next_level.Visible = false;
                    timer1.Enabled = false;
                    timer2.Enabled = false;

                }
            }
        }


        //funkcja odpowiadająca za obsługiwanie zdarzeń z klawiatury
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //wyjście
            if (e.KeyCode == Keys.Q)
            {
                this.Close();
            }

            //zaplętlenie
            if (e.KeyCode == Keys.R)
            {
                if(timer1.Enabled == false)
                {
                    if (error.Visible == true)
                    {
                        timer1.Enabled = false;
                    }

                    else
                    {
                        if (level == 4)
                        {
                            timer1.Enabled = false;
                            timer2.Enabled = false;
                            ball_placement.Visible = true;
                            this.Close();
                        }
                        gameover.Visible = false;
                        ball_placement.Visible = true;
                        test_label.Visible = true;
                        Cursor.Show();
                        timer2.Enabled = true;
                    }
                }                
            }

            // rozpoczęcie gry
            if (e.KeyCode == Keys.S)
            {
                if(timer1.Enabled == false)
                {
                    if (error.Visible == true)
                    {
                        timer1.Enabled = false;
                    }
                    else
                    {
                        if (level == 4)
                        {
                            timer1.Enabled = false;
                            timer2.Enabled = false;
                            this.Close();
                        }
                        else
                        {
                            pila.Top = (Y - ballsize / 2);
                            pila.Left = (X - ballsize / 2);
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
            }
        }       

        //funkcja odpowiadająca za pobranie współrzędnych piłki
        private void obszargry_MouseClick(object sender, MouseEventArgs e)
        {
            X = e.X ;
            Y = e.Y + ballsize / 2;

            click = true;
            test_label.Text = ("X: " + e.X + " Y: " + e.Y);

        }
    }
}
