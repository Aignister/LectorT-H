using System;
using System.IO.Ports;
using static System.Windows.Forms.DataFormats;

namespace LectorT_H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double temperatura;
        double humedad;
        bool actDato = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAbrir.Enabled = true;
            btnCerrar.Enabled = false;

            chart1.Series["Temperatura"].Points.AddXY(1, 1);
            chart1.Series["Humedad"].Poitns.AddXY(1, 1);
        }

        private void cmbCom_DropDown(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            cmbCom.Items.AddRange(portList);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbCom.Text;
                serialPort1.BaudRate = Convert.ToInt32(txtBaud.text);
                serialPort1.Open();

                btnAbrir.Enabled = false;
                btnCerrar.Enabled = true;

                chart1.Series["Temperatura"].Points.Clear();
                chart1.Series["Humedad"].Points.Clear();

                MessageBox.Show("Conexion exitosa a la tarjeta arduino");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btnAbrir.Enabled = true;
                btnCerrar.Enabled = false;

                MessageBox.Show("Desconectado de la tarjeta arduino");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Show_Data(object sender, EventArgs e)
        {
            if (actDato == true)
            {
                lblTemp.Text = string.Format("Temperatura= {0}°C",
                temperatura.ToString());
                lblHumedad.Text = string.Format("Humedad= {0}%HR",
                humdad.ToString());
                //Se dibujan los puntos en la gráfica
                chart1.Series["Temperatura"].Points.Add(temperatura);
                chart1.Series["Humedad"].Points.Add(humdad);
            }
        }

        private void Data_Parsing(string dato)
        {
            sbyte indexOf_startDataCharacter = (sbyte)dato.IndexOf("@");
            sbyte indexOfA = (sbyte)dato.IndexOf("A");
            sbyte indexOfB = (sbyte)dato.IndexOf("B");

            if(indexOfA != -1 && indexOfB != -1 && indexOf_startDataCharacter != -1)
            {
                try
                {
                    string str_Temperatura = dato.Substring(indexOf_startDataCharacter + 1, (indexOfA - indexOf_startDataCharacter) - 1);
                    string str_Humedad = dato.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);

                    temperatura = Convert.ToDouble(str_Temperatura);
                    humedad = Convert.ToDouble(str_Humedad);
                    actDato = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                actDato = false;
            }
        }
    }
}