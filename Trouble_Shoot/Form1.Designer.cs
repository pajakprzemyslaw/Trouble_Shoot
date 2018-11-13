namespace Trouble_Shoot
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.obszargry = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sublevel_value = new System.Windows.Forms.Label();
            this.sublevel_label = new System.Windows.Forms.Label();
            this.next_level = new System.Windows.Forms.Label();
            this.winner = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            this.test_label = new System.Windows.Forms.Label();
            this.ball_placement = new System.Windows.Forms.Label();
            this.level_value = new System.Windows.Forms.Label();
            this.level_label = new System.Windows.Forms.Label();
            this.hole = new System.Windows.Forms.PictureBox();
            this.score_point = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.pila = new Trouble_Shoot.Buttonellipse();
            this.rakieta = new System.Windows.Forms.PictureBox();
            this.square = new System.Windows.Forms.PictureBox();
            this.obszargry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakieta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // obszargry
            // 
            this.obszargry.AutoSize = true;
            this.obszargry.BackColor = System.Drawing.Color.White;
            this.obszargry.Controls.Add(this.pictureBox4);
            this.obszargry.Controls.Add(this.pictureBox3);
            this.obszargry.Controls.Add(this.pictureBox2);
            this.obszargry.Controls.Add(this.pictureBox1);
            this.obszargry.Controls.Add(this.sublevel_value);
            this.obszargry.Controls.Add(this.sublevel_label);
            this.obszargry.Controls.Add(this.next_level);
            this.obszargry.Controls.Add(this.winner);
            this.obszargry.Controls.Add(this.menu);
            this.obszargry.Controls.Add(this.error);
            this.obszargry.Controls.Add(this.test_label);
            this.obszargry.Controls.Add(this.ball_placement);
            this.obszargry.Controls.Add(this.level_value);
            this.obszargry.Controls.Add(this.level_label);
            this.obszargry.Controls.Add(this.hole);
            this.obszargry.Controls.Add(this.score_point);
            this.obszargry.Controls.Add(this.score_label);
            this.obszargry.Controls.Add(this.gameover);
            this.obszargry.Controls.Add(this.pila);
            this.obszargry.Controls.Add(this.rakieta);
            this.obszargry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obszargry.Location = new System.Drawing.Point(0, 0);
            this.obszargry.Name = "obszargry";
            this.obszargry.Size = new System.Drawing.Size(784, 562);
            this.obszargry.TabIndex = 0;
            this.obszargry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.obszargry_MouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox4.Location = new System.Drawing.Point(62, 446);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(674, 25);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox3.Location = new System.Drawing.Point(62, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(674, 25);
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox2.Location = new System.Drawing.Point(12, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 408);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Location = new System.Drawing.Point(714, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 369);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // sublevel_value
            // 
            this.sublevel_value.AutoSize = true;
            this.sublevel_value.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sublevel_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sublevel_value.Location = new System.Drawing.Point(205, 371);
            this.sublevel_value.Name = "sublevel_value";
            this.sublevel_value.Size = new System.Drawing.Size(17, 18);
            this.sublevel_value.TabIndex = 30;
            this.sublevel_value.Text = "0";
            // 
            // sublevel_label
            // 
            this.sublevel_label.AutoSize = true;
            this.sublevel_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sublevel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sublevel_label.Location = new System.Drawing.Point(136, 371);
            this.sublevel_label.Name = "sublevel_label";
            this.sublevel_label.Size = new System.Drawing.Size(81, 18);
            this.sublevel_label.TabIndex = 29;
            this.sublevel_label.Text = "Sublevel: ";
            // 
            // next_level
            // 
            this.next_level.AutoSize = true;
            this.next_level.BackColor = System.Drawing.Color.CornflowerBlue;
            this.next_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.next_level.Location = new System.Drawing.Point(127, 86);
            this.next_level.Name = "next_level";
            this.next_level.Size = new System.Drawing.Size(477, 54);
            this.next_level.TabIndex = 28;
            this.next_level.Text = "GRATULACJE, PRZECHODZISZ DO KOLEJNEGO POZIOMU!\r\nNACIŚNIJ R ABY GRAĆ DALEJ\r\nNACIŚN" +
    "IJ Q ABY WYJŚĆ";
            this.next_level.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.BackColor = System.Drawing.Color.CornflowerBlue;
            this.winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winner.Location = new System.Drawing.Point(273, 158);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(369, 24);
            this.winner.TabIndex = 27;
            this.winner.Text = "WYGRAŁEŚ, NACIŚNIJ Q ABY WYJŚĆ";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menu.Location = new System.Drawing.Point(311, 358);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(461, 50);
            this.menu.TabIndex = 26;
            this.menu.TabStop = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.CornflowerBlue;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error.Location = new System.Drawing.Point(326, 182);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(458, 24);
            this.error.TabIndex = 23;
            this.error.Text = "UMIESC PIŁKĘ W PRAWIDŁOWYM POŁOŻENIU";
            // 
            // test_label
            // 
            this.test_label.AutoSize = true;
            this.test_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.test_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.test_label.Location = new System.Drawing.Point(243, 371);
            this.test_label.Name = "test_label";
            this.test_label.Size = new System.Drawing.Size(0, 18);
            this.test_label.TabIndex = 21;
            // 
            // ball_placement
            // 
            this.ball_placement.AutoSize = true;
            this.ball_placement.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ball_placement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ball_placement.Location = new System.Drawing.Point(106, 425);
            this.ball_placement.Name = "ball_placement";
            this.ball_placement.Size = new System.Drawing.Size(432, 40);
            this.ball_placement.TabIndex = 19;
            this.ball_placement.Text = "Umieść piłkę pomiędzy paletką pierwszą przeszkodą!\r\nNaciśnij S aby rozpocząć, lub" +
    " Q aby wyjść.";
            this.ball_placement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // level_value
            // 
            this.level_value.AutoSize = true;
            this.level_value.BackColor = System.Drawing.Color.CornflowerBlue;
            this.level_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level_value.Location = new System.Drawing.Point(118, 371);
            this.level_value.Name = "level_value";
            this.level_value.Size = new System.Drawing.Size(17, 18);
            this.level_value.TabIndex = 8;
            this.level_value.Text = "0";
            // 
            // level_label
            // 
            this.level_label.AutoSize = true;
            this.level_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.level_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level_label.Location = new System.Drawing.Point(72, 371);
            this.level_label.Name = "level_label";
            this.level_label.Size = new System.Drawing.Size(57, 18);
            this.level_label.TabIndex = 7;
            this.level_label.Text = "Level: ";
            // 
            // hole
            // 
            this.hole.Image = ((System.Drawing.Image)(resources.GetObject("hole.Image")));
            this.hole.Location = new System.Drawing.Point(742, 20);
            this.hole.Name = "hole";
            this.hole.Size = new System.Drawing.Size(30, 30);
            this.hole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hole.TabIndex = 6;
            this.hole.TabStop = false;
            // 
            // score_point
            // 
            this.score_point.AutoSize = true;
            this.score_point.BackColor = System.Drawing.Color.CornflowerBlue;
            this.score_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_point.Location = new System.Drawing.Point(54, 371);
            this.score_point.Name = "score_point";
            this.score_point.Size = new System.Drawing.Size(17, 18);
            this.score_point.TabIndex = 5;
            this.score_point.Text = "0";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_label.Location = new System.Drawing.Point(3, 371);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(63, 18);
            this.score_label.TabIndex = 4;
            this.score_label.Text = "Score: ";
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gameover.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameover.Location = new System.Drawing.Point(325, 371);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(238, 54);
            this.gameover.TabIndex = 3;
            this.gameover.Text = "GAME OVER\r\nPress Q button to exit game.\r\nPress R button to repeat game.";
            // 
            // pila
            // 
            this.pila.BackColor = System.Drawing.Color.SteelBlue;
            this.pila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pila.FlatAppearance.BorderSize = 0;
            this.pila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.pila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.pila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pila.Location = new System.Drawing.Point(82, 98);
            this.pila.Name = "pila";
            this.pila.Size = new System.Drawing.Size(15, 15);
            this.pila.TabIndex = 1;
            this.pila.UseVisualStyleBackColor = false;
            // 
            // rakieta
            // 
            this.rakieta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rakieta.BackgroundImage = global::Trouble_Shoot.Properties.Resources.bricks1;
            this.rakieta.Location = new System.Drawing.Point(267, 507);
            this.rakieta.Name = "rakieta";
            this.rakieta.Size = new System.Drawing.Size(206, 20);
            this.rakieta.TabIndex = 0;
            this.rakieta.TabStop = false;
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(0, 0);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(100, 50);
            this.square.TabIndex = 1;
            this.square.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.obszargry);
            this.Controls.Add(this.square);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.obszargry.ResumeLayout(false);
            this.obszargry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakieta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel obszargry;
        private System.Windows.Forms.PictureBox rakieta;
        private Buttonellipse pila;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label score_point;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.PictureBox hole;
        private System.Windows.Forms.Label level_label;
        private System.Windows.Forms.Label level_value;
        private System.Windows.Forms.Label ball_placement;
        private System.Windows.Forms.Label test_label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox square;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.Label next_level;
        private System.Windows.Forms.Label sublevel_value;
        private System.Windows.Forms.Label sublevel_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

