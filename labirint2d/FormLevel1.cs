using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirint2d
{
    public partial class FormLevel1 : Form
    {
        int box_left = 6;
        public FormLevel1()
        {
            InitializeComponent();
        }

       private void start_game()
        {
            Point point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.play_start();
            box_left = 6;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box5.Visible = true;
            label_box6.Visible = true;
        }
        private void finish_game()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void restart_game()
        {
            Sound.play_fail();
            DialogResult d = MessageBox.Show("Dont go outside labirint\n\nTry again",
                "You lost", 
                MessageBoxButtons.YesNo);
            if (d == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }
          
        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if(box_left == 0)
            finish_game();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }

        private void c(object sender, EventArgs e)
        {

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            Sound.play_key();
            box_left--;
        }
    }
}
