using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace düdük
{
    public partial class Form1 : Form
    {
        private string data;
        private Queue<string> dataQueue = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;

            serialPort1.Encoding = Encoding.GetEncoding(1254);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
            progressBarHiz.Maximum = 150;
            progressBarKilometre.Maximum = 999;
            progressBarPil.Maximum = 100;
            progressBarPilSicakligi.Maximum = 79;
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
            string temizVeri = data?.Trim();
            if (string.IsNullOrEmpty(temizVeri)) return;

            string[] parts = temizVeri.Split(new[] { ": " }, StringSplitOptions.None);
            if (parts.Length != 2) return;

            string etiket = parts[0];
            string degerStr = parts[1];

            if (Int16.TryParse(degerStr, out short value))
            {
                switch (etiket)
                {
                    case "Hiz":
                        if (value >= 0 && value <= 120) progressBarHiz.Value = value;
                        labelHiz.Text = "Hiz: " + degerStr;
                        break;
                    case "Kilometre":
                        if (value >= 0 && value <= 1000) progressBarKilometre.Value = value;
                        labelKilometre.Text = "Kilometre: " + degerStr;
                        break;
                    case "Pil":
                        if (value >= 0 && value <= 100) progressBarPil.Value = value;
                        labelPil.Text = "Pil: " + degerStr;
                        break;
                    case "Pil Sicakligi":
                        if (value >= 20 && value <= 90) progressBarPilSicakligi.Value = value;
                        labelPilSicakligi.Text = "Pil Sicakligi: " + degerStr;
                        break;
                }
            }

            dataQueue.Enqueue(temizVeri);
            if (dataQueue.Count > 4) dataQueue.Dequeue();
            textBox1.Text = string.Join(Environment.NewLine, dataQueue);
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir port seçin.", "Hata");
                    return;
                }

                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                durdur.Enabled = true;
                baslat.Enabled = false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"Port '{serialPort1.PortName}' erişime kapalı. Yönetici olarak çalıştırın.", "İzin Hatası");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                durdur.Enabled = false;
                baslat.Enabled = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataQueue.Clear();
            progressBarHiz.Value = 0;
            progressBarKilometre.Value = 0;
            progressBarPil.Value = 0;
            progressBarPilSicakligi.Value = 0;
            labelHiz.Text = "Hız: 0";
            labelKilometre.Text = "Kilometre: 0";
            labelPil.Text = "Pil: 0";
            labelPilSicakligi.Text = "Pil Sıcaklığı: 0";
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Metin Dosyası (*.txt)|*.txt";
                sfd.DefaultExt = "txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, textBox1.Text, Encoding.GetEncoding(1254));
                    MessageBox.Show("Veri başarıyla kaydedildi!", "Bilgi");
                }
            }
        }
    }
}