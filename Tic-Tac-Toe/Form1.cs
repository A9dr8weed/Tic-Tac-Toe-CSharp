using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private int player;
        private Button[,] buttons = new Button[3, 3];
     
        public Form1()
        {
            InitializeComponent();
            Height = 700;
            Width = 900;
            player = 1;
            label1.Text = "Хід: Гравець 1";

            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Size = new Size(200, 200)
                    };
                }
            }

            setButtons();
        }

        private void setButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Location = new Point(12 + (206 * j), 12 + (206 * i));
                    buttons[i, j].Click += button1_Click;
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 138);
                    buttons[i, j].Text = "";
                    Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    label1.Text = "Хід: Гравець 2";
                    player = 0;
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    label1.Text = "Хід: Гравець 1";
                    player = 1;
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }
        private void checkWin()
        {

            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text && buttons[0, 0].Text != "")
            {
                MessageBox.Show("Вы победили!");
                return;
            }

            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text && buttons[1, 0].Text != "")
            {
                MessageBox.Show("Вы победили!");
                return;
            }

            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text && buttons[2, 0].Text != "")
            {
                MessageBox.Show("Вы победили!");
                return;
            }

            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text && buttons[0, 0].Text != "")
            {
                MessageBox.Show("Вы победили!");
                return;
            }

            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text && buttons[0, 1].Text != "")
            {
                MessageBox.Show("Вы победили!");
                return;
            }

            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text && buttons[0, 2].Text != "")
            {
                MessageBox.Show("Вы победили!");
                return;
            }

            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text && buttons[0, 0].Text != "")
            {
                MessageBox.Show("Вы победили!");
                return;
            }

            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text && buttons[2, 0].Text != "")
            {
                MessageBox.Show("Вы победили!");
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
        }
    }
}