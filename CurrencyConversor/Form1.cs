using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace CurrencyConversor
{
    public partial class Form1 : Form
    {

        dynamic json;

        public Form1()
        {
            InitializeComponent();
            using (WebClient wc = new WebClient())
            {
                string access_key = Properties.Settings.Default.access_key;
                string url = "http://data.fixer.io/api/latest?access_key=";
                try
                {
                    string jsonNotParsed = wc.DownloadString($"{url}{access_key}");
                    json = JObject.Parse(jsonNotParsed);
                } catch (Exception ex)
                {
                    MessageBox.Show("An error happened while trying to fetch the latest currency values, try again later or try to contact us." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
            double fromValue, toValue;

            try
            {
                Console.WriteLine(from + "" + to);
                fromValue = json.rates[from];
                toValue = json.rates[to];
                amount = Convert.ToDouble(txtValue.Text);


                double final = (1 / fromValue) * toValue * amount;
                Console.WriteLine($"From: {fromValue} | To: {toValue} | final {final}");
                labelResult.Text = $"RESULT: {amount} {from} = {Math.Round(final, 2)} {to}";

            } catch (Exception ex)
            {
                MessageBox.Show("An invalid amount or currency symbol was given. Check them and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            
            





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
