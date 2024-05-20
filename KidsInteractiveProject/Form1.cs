using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace KidsInteractiveProject
{
    public partial class Form1 : Form
    {
        List<string> movementList = new List<string>();

        int size = 3;
        int x = 0;
        int y = 0;
        int coinX = 0;
        int coinY = 0;
        Random rand = new Random();
        public static string gameStatus = "YOU LOOSE";

        PictureBox[,] gridPictures = new PictureBox[3, 3];
        PictureBox[] codePictures = new PictureBox[5];

        string picPlayer = Directory.GetCurrentDirectory() + "/images/player.png";
        string picCoin = Directory.GetCurrentDirectory() + "/images/coin.jpg";
        public Form1()
        {
            InitializeComponent();
            coinX = rand.Next(3);
            coinY = rand.Next(3);
            if(coinX == x && coinY == y)
            {
                coinX = rand.Next(3);
                coinY = rand.Next(3);
            }
            tblCodeArea.CellBorderStyle = (TableLayoutPanelCellBorderStyle)FormBorderStyle.Fixed3D;
            table.CellBorderStyle = (TableLayoutPanelCellBorderStyle)FormBorderStyle.Fixed3D;
            gameStatus = "YOU LOOSE";
            for (int i = 0; i < codePictures.Length; i++)
            {
                codePictures[i] = new PictureBox();
                codePictures[i].SizeMode = PictureBoxSizeMode.Zoom;
                codePictures[i].AllowDrop = true;
                codePictures[i].DragEnter += new DragEventHandler(pictures_DragEnter);
                codePictures[i].DragDrop += new DragEventHandler(pictures_DragDrop);

                tblCodeArea.Controls.Add(codePictures[i]);
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    gridPictures[i, j] = new PictureBox();
                    gridPictures[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    table.Controls.Add(gridPictures[i, j]);
                }
            }
            gridPictures[y, x].Image = Image.FromFile(picPlayer);

            gridPictures[coinX, coinY].Image = Image.FromFile(picCoin);

        }

        private void codeBlock_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox codeBlock = sender as PictureBox;
            DataObject dragImgae = new DataObject();
            dragImgae.SetData(DataFormats.Bitmap, true, codeBlock.Image);
            dragImgae.SetData(DataFormats.Text, true, codeBlock.Tag);
            DoDragDrop(dragImgae, DragDropEffects.Copy);
        }

        private void pictures_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictures_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox picture = sender as PictureBox;

            picture.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            picture.Tag = e.Data.GetData(DataFormats.Text);
            movementList.Add((string)picture.Tag);
            lblList.Text = "";

            for (int i = 0; i < 5; i++)
            {
                string action = (string)codePictures[i].Tag;
                lblList.Text = String.Format("{0}{1} {2}\n", lblList.Text, i, action);
            }
        }

        public async void runButton_MouseUp(object sender, MouseEventArgs e)
        {
            int oldX = x, oldY = y;
            for(int i = 0; i < movementList.Count; i++)
            {
                oldX = x;
                oldY = y;
                if (movementList[i] == "Right")
                {
                    gridPictures[oldY, oldX].Image = null;
                    if (x < size - 1)
                        x++;
                    gridPictures[y, x].Image = Image.FromFile(picPlayer);
                }
                else if (movementList[i] == "Left")
                {
                    gridPictures[oldY, oldX].Image = null;
                    if (x > 0)
                        x--;
                    gridPictures[y, x].Image = Image.FromFile(picPlayer);
                }
                else if (movementList[i] == "Down")
                {
                    gridPictures[oldY, oldX].Image = null;
                    if (y < size - 1)
                        y++;
                    gridPictures[y, x].Image = Image.FromFile(picPlayer);
                }
                else if (movementList[i] == "Up")
                {
                    gridPictures[oldY, oldX].Image = null;
                    if (y > 0)
                        y--;
                    gridPictures[y, x].Image = Image.FromFile(picPlayer);
                }
                if (y == coinX && x == coinY)
                {
                    gameStatus = "YOU WIN";
                }
                await Task.Delay(500);
            }
            lblList.Text = "";
            movementList.Clear();
            for (int i = 0; i < 5; i++)
            {
                codePictures[i].Image = null;
            }
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }
    }
}
