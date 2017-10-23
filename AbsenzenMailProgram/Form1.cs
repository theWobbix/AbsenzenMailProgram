using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsenzenMailProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateCbox();
        }
                
        private static int CboxCounter = 0;
        private void CreateCbox()
        {
            //Set up Comboboxes
            ComboBox cBox1 = new ComboBox();
            ComboBox cBox2 = new ComboBox();
            ComboBox cBox3 = new ComboBox();
            ComboBox cBox4 = new ComboBox();
            ComboBox cBox5 = new ComboBox();
            ComboBox cBox6 = new ComboBox();
            ComboBox cBox7 = new ComboBox();
            ComboBox cBox8 = new ComboBox();
            ComboBox[] cBoxArray = { cBox1, cBox2, cBox3, cBox4, cBox5, cBox6, cBox7, cBox8 };

            //Set Location for new Combobox and set new Location for Button
            cBoxArray[CboxCounter].Location = new Point(b_newbox.Location.X, b_newbox.Location.Y);
            b_newbox.Location = new Point(b_newbox.Location.X, b_newbox.Location.Y + 20);

            //Add new Combobox to Frame
            this.Controls.Add(cBoxArray[CboxCounter]);

            CboxCounter += 1;

        }

        private void b_newbox_Click(object sender, EventArgs e)
        {
            CreateCbox();
        }
    }

}
