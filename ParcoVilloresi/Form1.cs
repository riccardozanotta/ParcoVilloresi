using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcoVilloresi
{
    public partial class Form1 : Form
    {
        private List<Coordinate> coordinates = new List<Coordinate>();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCoordinates(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length >= 3 && double.TryParse(values[1], out double latitude) && double.TryParse(values[2], out double longitude))
                        {
                            coordinates.Add(new Coordinate { Name = values[0], Latitude = latitude, Longitude = longitude });
                        }
                        else
                        {
                            MessageBox.Show("Formato CSV non valido.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la lettura del file CSV: {ex.Message}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCoordinates("C:\\Users\\riccardo.zanotta\\Desktop\\coordinate.csv");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            apriCoordinate(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            apriCoordinate(button3.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            apriCoordinate(button4.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            apriCoordinate(button1.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            apriCoordinate(button5.Text);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            apriCoordinate(button6.Text);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            apriCoordinate(button7.Text);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            apriCoordinate(button8.Text);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            apriCoordinate(button9.Text);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            apriCoordinate(button10.Text);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            apriCoordinate(button11.Text);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            apriCoordinate(button12.Text);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            apriCoordinate(button13.Text);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            apriCoordinate(button14.Text);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            apriCoordinate(button15.Text);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            apriCoordinate(button16.Text);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            apriCoordinate(button17.Text);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            apriCoordinate(button18.Text);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            apriCoordinate(button19.Text);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            apriCoordinate(button20.Text);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            apriCoordinate(button21.Text);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            apriCoordinate(button22.Text);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            apriCoordinate(button23.Text);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            apriCoordinate(button24.Text);
        }
        private void button25_Click(object sender, EventArgs e)
        {
            apriCoordinate(button25.Text);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            apriCoordinate(button26.Text);
        }
        private void button27_Click(object sender, EventArgs e)
        {
            apriCoordinate(button27.Text);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            apriCoordinate(button28.Text);
        }
        private void button29_Click(object sender, EventArgs e)
        {
            apriCoordinate(button29.Text);
        }
        private void button30_Click(object sender, EventArgs e)
        {
            apriCoordinate(button30.Text);
        }
        

        void apriCoordinate(string punto)
        {
            string buttonText = punto;
            var coordinate = coordinates.Find(c => c.Name.Equals(buttonText, StringComparison.OrdinalIgnoreCase));

            if (coordinate != null)
            {
                string googleMapsUrl = $"https://www.google.com/maps?q={coordinate.Latitude},{coordinate.Longitude}";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = googleMapsUrl,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Coordinate non trovate.");
            }
        }
    }
}
