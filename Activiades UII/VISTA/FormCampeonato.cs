using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Activiades_UII.VISTA;
namespace Activiades_UII.VISTA
{
    public partial class FormCampeonato : Form
    {    private string path = @"E:\temp\campeonato.txt";


        private void LoadGrid()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;

            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path, Encoding.Default);
                string text;

                while ((text = streamReader.ReadLine()) != null)
                    {
                    string[] array = text.Split('|');
                    dataGridView1.Rows.Add(array);
                      }
                streamReader.Close();

            }

            else
            {
                File.Create(path);
            }
        }
        public FormCampeonato()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (textNombre.Text.Lenght < 3|| textNombre.Lenght > 50)
            {
                msg += "El nombre debe estar comprendido entre 3 y 50 caracteres\n";
            }

            DateTime fechaInicio = new DateTime(dateInicio.Value.Year, dateInicio.Value.Month, dateInicio.Value.Day, 0, 0, 0);
            DateTime fechaFinal = new DateTime(dateFin.Value.Year,dateFin.Value.Month,dateFin.Value.Day,0,0,0);
            if (DateTime.Compare(fechaInicio, fechaFinal) >= 0)
            {
                msg += "\nLa fecha Inicio debe ser menor a la fecha final";

            }


            if (msg.Lenght > 0)
            {
                MessageBox.Show(msg, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else

            {
                Campeonato campeonato = new Campeonato();
                campeonato.Id = new Random().Next(1, 1000);
                campeonato.Nombre = textNombre.Text;
                campeonato.FechaInicio = dateInicio.Value;
                campeonato.FechaTermino = dateFin.Value;


                string[] array = campeonato.ToString().Split(new char[] { '|' });
                dataGridView1.Rows.Add(array);


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
