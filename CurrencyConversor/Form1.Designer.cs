
namespace CurrencyConversor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "FROM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "TO:";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Items.AddRange(new object[] {
            "AED\t",
            "AFN\t",
            "ALL\t",
            "AMD\t",
            "ANG\t",
            "AOA\t",
            "ARS\t",
            "AUD\t",
            "AWG\t",
            "AZN\t",
            "BAM\t",
            "BBD\t",
            "BDT\t",
            "BGN\t",
            "BHD\t",
            "BIF\t",
            "BMD\t",
            "BND\t",
            "BOB\t",
            "BRL\t",
            "BSD\t",
            "BTC\t",
            "BTN\t",
            "BWP\t",
            "BYR\t",
            "BYN\t",
            "BZD\t",
            "CAD\t",
            "CDF\t",
            "CHF\t",
            "CLF\t",
            "CLP\t",
            "CNY\t",
            "COP\t",
            "CRC\t",
            "CUC\t",
            "CUP\t",
            "CVE\t",
            "CZK\t",
            "DJF\t",
            "DKK\t",
            "DOP\t",
            "DZD\t",
            "EGP\t",
            "ERN\t",
            "ETB\t",
            "EUR\t",
            "FJD\t",
            "FKP\t",
            "GBP\t",
            "GEL\t",
            "GGP\t",
            "GHS\t",
            "GIP\t",
            "GMD\t",
            "GNF\t",
            "GTQ\t",
            "GYD\t",
            "HKD\t",
            "HNL\t",
            "HRK\t",
            "HTG\t",
            "HUF\t",
            "IDR\t",
            "ILS\t",
            "IMP\t",
            "INR\t",
            "IQD\t",
            "IRR\t",
            "ISK\t",
            "JEP\t",
            "JMD\t",
            "JOD\t",
            "JPY\t",
            "KES\t",
            "KGS\t",
            "KHR\t",
            "KMF\t",
            "KPW\t",
            "KRW\t",
            "KWD\t",
            "KYD\t",
            "KZT\t",
            "LAK\t",
            "LBP\t",
            "LKR\t",
            "LRD\t",
            "LSL\t",
            "LTL\t",
            "LVL\t",
            "LYD\t",
            "MAD\t",
            "MDL\t",
            "MGA\t",
            "MKD\t",
            "MMK\t",
            "MNT\t",
            "MOP\t",
            "MRO\t",
            "MUR\t",
            "MVR\t",
            "MWK\t",
            "MXN\t",
            "MYR\t",
            "MZN\t",
            "NAD\t",
            "NGN\t",
            "NIO\t",
            "NOK\t",
            "NPR\t",
            "NZD\t",
            "OMR\t",
            "PAB\t",
            "PEN\t",
            "PGK\t",
            "PHP\t",
            "PKR\t",
            "PLN\t",
            "PYG\t",
            "QAR\t",
            "RON\t",
            "RSD\t",
            "RUB\t",
            "RWF\t",
            "SAR\t",
            "SBD\t",
            "SCR\t",
            "SDG\t",
            "SEK\t",
            "SGD\t",
            "SHP\t",
            "SLL\t",
            "SOS\t",
            "SRD\t",
            "STD\t",
            "SVC\t",
            "SYP\t",
            "SZL\t",
            "THB\t",
            "TJS\t",
            "TMT\t",
            "TND\t",
            "TOP\t",
            "TRY\t",
            "TTD\t",
            "TWD\t",
            "TZS\t",
            "UAH\t",
            "UGX\t",
            "USD\t",
            "UYU\t",
            "UZS\t",
            "VEF\t",
            "VND\t",
            "VUV\t",
            "WST\t",
            "XAF\t",
            "XAG\t",
            "XAU\t",
            "XCD\t",
            "XDR\t",
            "XOF\t",
            "XPF\t",
            "YER\t",
            "ZAR\t",
            "ZMK\t",
            "ZMW\t",
            "ZWL\t"});
            this.cmbFrom.Location = new System.Drawing.Point(97, 92);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(121, 21);
            this.cmbFrom.TabIndex = 3;
            this.cmbFrom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Items.AddRange(new object[] {
            "AED\t",
            "AFN\t",
            "ALL\t",
            "AMD\t",
            "ANG\t",
            "AOA\t",
            "ARS\t",
            "AUD\t",
            "AWG\t",
            "AZN\t",
            "BAM\t",
            "BBD\t",
            "BDT\t",
            "BGN\t",
            "BHD\t",
            "BIF\t",
            "BMD\t",
            "BND\t",
            "BOB\t",
            "BRL\t",
            "BSD\t",
            "BTC\t",
            "BTN\t",
            "BWP\t",
            "BYR\t",
            "BYN\t",
            "BZD\t",
            "CAD\t",
            "CDF\t",
            "CHF\t",
            "CLF\t",
            "CLP\t",
            "CNY\t",
            "COP\t",
            "CRC\t",
            "CUC\t",
            "CUP\t",
            "CVE\t",
            "CZK\t",
            "DJF\t",
            "DKK\t",
            "DOP\t",
            "DZD\t",
            "EGP\t",
            "ERN\t",
            "ETB\t",
            "EUR\t",
            "FJD\t",
            "FKP\t",
            "GBP\t",
            "GEL\t",
            "GGP\t",
            "GHS\t",
            "GIP\t",
            "GMD\t",
            "GNF\t",
            "GTQ\t",
            "GYD\t",
            "HKD\t",
            "HNL\t",
            "HRK\t",
            "HTG\t",
            "HUF\t",
            "IDR\t",
            "ILS\t",
            "IMP\t",
            "INR\t",
            "IQD\t",
            "IRR\t",
            "ISK\t",
            "JEP\t",
            "JMD\t",
            "JOD\t",
            "JPY\t",
            "KES\t",
            "KGS\t",
            "KHR\t",
            "KMF\t",
            "KPW\t",
            "KRW\t",
            "KWD\t",
            "KYD\t",
            "KZT\t",
            "LAK\t",
            "LBP\t",
            "LKR\t",
            "LRD\t",
            "LSL\t",
            "LTL\t",
            "LVL\t",
            "LYD\t",
            "MAD\t",
            "MDL\t",
            "MGA\t",
            "MKD\t",
            "MMK\t",
            "MNT\t",
            "MOP\t",
            "MRO\t",
            "MUR\t",
            "MVR\t",
            "MWK\t",
            "MXN\t",
            "MYR\t",
            "MZN\t",
            "NAD\t",
            "NGN\t",
            "NIO\t",
            "NOK\t",
            "NPR\t",
            "NZD\t",
            "OMR\t",
            "PAB\t",
            "PEN\t",
            "PGK\t",
            "PHP\t",
            "PKR\t",
            "PLN\t",
            "PYG\t",
            "QAR\t",
            "RON\t",
            "RSD\t",
            "RUB\t",
            "RWF\t",
            "SAR\t",
            "SBD\t",
            "SCR\t",
            "SDG\t",
            "SEK\t",
            "SGD\t",
            "SHP\t",
            "SLL\t",
            "SOS\t",
            "SRD\t",
            "STD\t",
            "SVC\t",
            "SYP\t",
            "SZL\t",
            "THB\t",
            "TJS\t",
            "TMT\t",
            "TND\t",
            "TOP\t",
            "TRY\t",
            "TTD\t",
            "TWD\t",
            "TZS\t",
            "UAH\t",
            "UGX\t",
            "USD\t",
            "UYU\t",
            "UZS\t",
            "VEF\t",
            "VND\t",
            "VUV\t",
            "WST\t",
            "XAF\t",
            "XAG\t",
            "XAU\t",
            "XCD\t",
            "XDR\t",
            "XOF\t",
            "XPF\t",
            "YER\t",
            "ZAR\t",
            "ZMK\t",
            "ZMW\t",
            "ZWL\t"});
            this.cmbTo.Location = new System.Drawing.Point(284, 92);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(133, 21);
            this.cmbTo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(240, 134);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "AMOUNT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

