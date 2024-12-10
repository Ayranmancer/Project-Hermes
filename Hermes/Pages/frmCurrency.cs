using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.DirectoryServices.ActiveDirectory;

namespace Hermes.Pages
{
    public partial class frmCurrency : Form
    {

        private Dictionary<string, double> _currencies = new Dictionary<string, double>();
        public frmCurrency()
        {
            InitializeComponent();

            var response = GetLatestCurrencies();
            dynamic responseObject = JsonConvert.DeserializeObject(response);

            foreach (var item in responseObject.data)
            {
                sourceCurrency.Items.Add(item.First.code.ToString());
                destinationCurrency.Items.Add(item.First.code.ToString());
                _currencies.Add(item.First.code.ToString(), item.First.value.Value);
            }


        }


        private string GetLatestCurrencies()   // Api Request
        {

            var client = new RestClient("https://api.currencyapi.com/v3/latest");

            //var client = new RestClient("https://api.currencyapi.com/v3/latest?base_currency=TRY");  //to change default base currency

            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "cur_live_NGdc1WSmjTTjGNsHhQn9zHjURK5nFxaQrcJO44Q5");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response.Content;

        }

        private void responseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void value_Click(object sender, EventArgs e)
        {
            var selectedSourceCurrency = sourceCurrency.SelectedItem;
            var selectedDestinationCurrency = destinationCurrency.SelectedItem;
            var amount = double.Parse(txtAmount.Text);


            var sourceCurrencyExchangeRate = _currencies
                .First(c => c.Key == selectedSourceCurrency).Value;

            var destinationCurrencyExchangeRate = _currencies
                .First(c => c.Key == selectedDestinationCurrency).Value;

            var calculetedAmount = (amount * sourceCurrencyExchangeRate ) * destinationCurrencyExchangeRate;

            lblResult.Text = $"Result : {calculetedAmount} {_currencies.First(c => c.Key == selectedDestinationCurrency).Key}";
        }
    }
}
