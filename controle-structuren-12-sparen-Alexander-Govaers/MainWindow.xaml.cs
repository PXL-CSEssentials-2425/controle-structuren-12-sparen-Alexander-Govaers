﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace controle_structuren_12_sparen_Alexander_Govaers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double startweekgeld = double.Parse(weekGeldTextBox.Text);
            bool validVerhoging = double.TryParse(verhogingTextBox.Text, out double wekelijkseVerhoging);
            double teSparenBedrag = double.Parse(gewenstBedragTextBox.Text);

            double aantalWeken = 1;
            double totaalGespaard = startweekgeld + wekelijkseVerhoging;
            double TotaalextraWeekgeld = wekelijkseVerhoging;



            for (double i = aantalWeken; totaalGespaard < teSparenBedrag; aantalWeken++)
            {
                totaalGespaard = totaalGespaard + startweekgeld + wekelijkseVerhoging;
                TotaalextraWeekgeld += wekelijkseVerhoging;





            }


            resultTextBox.Text = $"Spaargeld na {aantalWeken} weken : € {totaalGespaard - TotaalextraWeekgeld:n2} \n" +
                                $"Extra weekgeld op dat moment: {TotaalextraWeekgeld:n2} \n" +
                                $"Totaal spaargeld = € {totaalGespaard:n2}";



        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            weekGeldTextBox.Clear();
            verhogingTextBox.Clear();
            gewenstBedragTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
