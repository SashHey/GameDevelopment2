using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SashaHeyburgh_19336832_GADE5111_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void lblNumMines_Click(object sender, EventArgs e)
        {

        }

        private void lblMinOne_Click(object sender, EventArgs e)
        {

        }

        private void lblMinTwo_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxOne_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxTwo_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();    //hiding Form1
            Form2 Form2 = new Form2();
            Form2.startGame(Int16.Parse(txtMinOne.Text), Int16.Parse(txtMinTwo.Text), Int16.Parse(txtMaxOne.Text), Int16.Parse(txtMaxTwo.Text), Int16.Parse(txtNumMines.Text));  //calling the startGame method
            Form2.ShowDialog();     //displaying Form2  
        }

        private void lblMapSize_Click(object sender, EventArgs e)
        {

        }

        private void txtMinOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaxOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaxTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumMines_TextChanged(object sender, EventArgs e)
        {

        }

        public int NumberOfMines() => short.Parse(txtNumMines.Text);   //creating a method to return the number of mines to the second form
    }
}
