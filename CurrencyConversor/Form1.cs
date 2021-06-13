﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace CurrencyConversor
{
    public partial class Form1 : Form
    {

        object json;

        public Form1()
        {
            InitializeComponent();
            using (WebClient wc = new WebClient())
            {
                string access_key = Properties.Settings.Default.access_key;
                string url = "http://data.fixer.io/api/latest?access_key=";
                json = wc.DownloadString($"{url}{access_key}");
                Console.WriteLine(json);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = cmbFrom.Text;
            string to = cmbTo.Text;
            double amount = 0;

            try
            {
                amount = Convert.ToDouble(txtValue.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("An invalid amount was given.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
            Console.WriteLine(amount);
            





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
