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
    {
        private string path = @"E:\temp\campeonato.txt";


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
        private void FormCampeonato_Load(object sender, EventArgs e)
        {
            LoadGrid();
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void AddRecordFile(FormCampeonato campeonato)
        {
            StreamWriter writer = new StreamWriter(path, true);

            writer.WriteLine(campeonato.ToString());
            writer.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuEliminar_Opening(object sender, CancelEventArgs e)
        {
            string opcion = e.ClickedItem.ToString().Tolower();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string id = dataGridView1.SelectedCells[0].Value.ToString();
                string nombre = dataGridView1.SelectedCells[1].Value.ToString();


                switch (opcion)
                {
                    case "eliminar":
                        string mensaje = "¿Deseas eliminar el" + nombre + "con Id=" + id;
                        menuEliminar.Hide();

                        if (MessageBox.Show(mensaje, "Eliminando registro", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                        {
                            dataGridView1.Rows.RemoveAt(row.Index);
                        }
                        break;

                    case "modificar":
                        break;

                }
            }
        }
    }
}
