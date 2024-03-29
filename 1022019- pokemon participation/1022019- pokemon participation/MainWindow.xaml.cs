﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1022019__pokemon_participation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(@"https://pokeapi.co/api/v2/pokemon?offset=20&limit=964").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var VARIABLE = JsonConvert.DeserializeObject<Results>(content);

                    foreach (var item in VARIABLE.results)
                    {
                        LBPokemon.Items.Add(item);

                    }

                }
            }

        }

        private void BTNGetInfo_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ((Result)LBPokemon.SelectedItem);
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(selectedItem.url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var VARIABLE = JsonConvert.DeserializeObject<PokeInfo>(content);

                    TBlockPokeInfo.Text = VARIABLE.ToString();

                }
            }
        }

        private void LBPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
