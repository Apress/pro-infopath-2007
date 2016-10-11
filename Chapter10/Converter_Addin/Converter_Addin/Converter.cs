using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Converter_Addin
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fromCurrency = (string)lstFromCurrency.SelectedItem;
            string toCurrency = (string)lstToCurrency.SelectedItem;

            fromCurrency = fromCurrency.Substring(0, 3);
            toCurrency = toCurrency.Substring(0, 3);
            
            string fromValue = txtFromAmount.Text;
            float sendValue = float.Parse(fromValue);
            
            ConverterService.ccydemo conversionSvc = new PopupConverter.ConverterService.ccydemo();
            float rtnValue = conversionSvc.calcExcRate(fromCurrency, toCurrency, sendValue);
            
            this.txtToAmount.Text = rtnValue.ToString();
        }

    }
}