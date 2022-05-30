using System;
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


namespace Final_Odevi
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //YAZI YAZMA KUTUSU VE LİSTEYE EKLEME 
        private void Add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " - " + textBox2.Text + " - " + textBox3.Text + " - " + textBox4.Text + " - " + ComboBox1.Text + " - " + ComboBox2.Text + " - " +  Birth_Year.Text);
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox4.Clear();
        }





        //SİLME BUTONU
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));

        }

        //LİSTEYİ TEMİZLER
        private void Reset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //TEXTBOX TEMİZLER 
        private void text_Reset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void ComboBox1_Selected(object sender, RoutedEventArgs e)
        {

        }

        //RAKAM YAZMA KUTUSU

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece rakam giriniz.", "Önemli Uyarı!");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        //GÜNCELLEME-DÜZENLEME



    }
}
