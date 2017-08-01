using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Add_product_This_one
{
    public partial class lblAddProduct : Form
    {
        public lblAddProduct()
        {
            InitializeComponent();
        }

        private void lblAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void DisplayFile_Click(object sender, EventArgs e)
        {
            //this code claer the lstproduct when press
            lstProduct.Items.Clear();

            try
            {
                // this is where the file will be read from 
                string path = "C:\\Users\\kenmogne\\Downloads\\introdaction to progamming Nick (1)\\introdaction to progamming Nick\\Add product This one\\ThisproductFile.csv";
                //this code open the file and create an object that will read from it. 
                // sr is an object that will allowes us to read from file one line at a time.
                StreamReader sr = new StreamReader(path);

                // this code create a varaible to read the line from the file into.
                string line;


                //The main work for the function is reading a line at a time until the end of the file
                //Add the following while loop
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                   // this code allow the items to disply              
                    lstProduct.Items.Add(line);
                }

                //Finally we must close the stream so that the file is available for other applications.  Add the line
                //alway after the whie loop
                sr.Close();

            } catch
            {
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {


            string path = "C:\\Users\\kenmogne\\Downloads\\introdaction to progamming Nick (1)\\introdaction to progamming Nick\\Add product This one\\ThisproductFile.csv";
            // this piece of code allowed to add neww product to the file 
            StreamWriter sw = new StreamWriter(path, true);

            // this piece of code allowed the to add neww product
            sw.WriteLine(txtProductCode.Text + "," + txtDescription.Text + "," + txtPrice.Text);
            sw.Close();

            txtProductCode.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            //textQuantity.Clear();
            lbltimer.Text = "saved";

            //timer1.Enabled = true;
        }
    }
}
