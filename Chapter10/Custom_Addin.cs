string fromCurrency = (string)lstFromCurrency.SelectedItem;
string toCurrency = (string)lstToCurrency.SelectedItem;

fromCurrency = fromCurrency.Substring(0, 3);
toCurrency = toCurrency.Substring(0, 3);

string fromValue = txtFromAmount.Text;
float sendValue = float.Parse(fromValue);

ConverterService.ccydemo conversionSvc = new PopupConverter.ConverterService.ccydemo(); 
float rtnValue = conversionSvc.calcExcRate(fromCurrency, toCurrency, sendValue);

this.txtToAmount.Text = rtnValue.ToString();
