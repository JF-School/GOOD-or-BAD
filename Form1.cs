using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace good_or_bad
{
    public partial class GoodBad : Form
    {
        public GoodBad()
        {
            InitializeComponent();
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            string imageChoice;
            imgBad1.Visible = false;
            imgBad2.Visible = false;
            imgBad3.Visible = false;
            this.BackColor = Color.LightGreen;
            lblImageStatus.Visible = true;
            Random generator = new Random();
            List<string> images = new List<string>();
            images.Add("imgGood1");
            images.Add("imgGood2");
            images.Add("imgGood3");
            imageChoice = images[generator.Next(images.Count)];
            if (imageChoice == "imgGood1")
            {
                imgGood1.Visible = true;
                imgGood2.Visible = false;
                imgGood3.Visible = false;
                lblImageStatus.Text = "Image: Monopoly Man";
            }
            else if (imageChoice == "imgGood2")
            {
                imgGood2.Visible = true;
                imgGood3.Visible = false;
                imgGood1.Visible = false;
                lblImageStatus.Text = "Image: Happy Happy Happy";
            }
            else if (imageChoice == "imgGood3")
            {
                imgGood3.Visible = true;
                imgGood1.Visible = false;
                imgGood2.Visible = false;
                lblImageStatus.Text = "Image: Ice Cream";
            }

        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            string imageBadChoice;
            imgGood1.Visible = false;
            imgGood2.Visible = false;
            imgGood3.Visible = false;
            this.BackColor = Color.LightCoral;
            lblImageStatus.Visible = true;
            Random generator = new Random();
            List<string> images = new List<string>();
            images.Add("imgBad1");
            images.Add("imgBad2");
            images.Add("imgBad3");
            imageBadChoice = images[generator.Next(images.Count)];
            if (imageBadChoice == "imgBad1")
            {
                imgBad1.Visible = true;
                imgBad2.Visible = false;
                imgBad3.Visible = false;
                lblImageStatus.Text = "Image: Smiling Devil";
            }
            else if (imageBadChoice == "imgBad2")
            {
                imgBad2.Visible = true;
                imgBad1.Visible = false;
                imgBad3.Visible = false;
                lblImageStatus.Text = "Image: SAD SAD SAD";
            }
            else if (imageBadChoice == "imgBad3")
            {
                imgBad3.Visible = true;
                imgBad2.Visible = false;
                imgBad1.Visible = false;
                lblImageStatus.Text = "Image: THWOMP";
            }
        }
    }
}
