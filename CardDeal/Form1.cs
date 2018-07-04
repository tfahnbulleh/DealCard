using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDeal
{
    public partial class Form1 : Form
    {
        private Deck _deck;
        private CardPlayer _cardPlayer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._deck = new Deck();
            this._cardPlayer = new CardPlayer();
            this._cardPlayer.Clear();
            this.flowLayoutPanel1.Controls.Clear();
            int numberOfCardsToDeal =(int)this.numericUpDown1.Value;
            for (int i = 0; i < numberOfCardsToDeal; i++)
            {
                this._cardPlayer.AddCard(this._deck.GetDeal());            
            }
            
            foreach (var card in this._cardPlayer.showCards())
            {
                PictureBox pictureBox = new PictureBox();
                string filePath = Directory.GetCurrentDirectory() + "\\Resources\\" + card.ToString().Replace(" ", "").ToLower() + ".PNG";
                pictureBox.Image = System.Drawing.Image.FromFile(filePath);// Properties.Resources.club3;
                pictureBox.Size = new Size(141, 178);
                this.flowLayoutPanel1.Controls.Add(pictureBox);
            }

          


           
           
        }
    }
}
