using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parcial2POO.Datos;
using Parcial2POO.Entidades;

namespace Parcial2POO.Windows
{
    public partial class frmJugadores : Form
    {

        //----ATRIBUTOS----//

        private Repositorio repoPersonas;
        private Equipo equipo;
        public frmJugadores()
        {
            InitializeComponent();
            repoPersonas = new Repositorio();
        }

        //----METODOS----//

        private void CargarGrilla()
        {
            List<Persona> personas = repoPersonas.GetLista();

            foreach (Persona p in personas)
            {
                DataGridViewRow fila = new DataGridViewRow();

                fila.CreateCells(DisponiblesDataGridView);

                fila.Cells[colPersona.Index].Value = p.NombreCompleto();

                if(p is Jugador)
                {
                    fila.Cells[colEsCapitan.Index].Value = ((Jugador)p).EsCapitan;
                    fila.Cells[colCamiseta.Index].Value = ((Jugador)p).Numero.ToString();
                    fila.Cells[colTipo.Index].Value = Tipo.Jugador.ToString();

                }
                else
                {
                    fila.Cells[colEsCapitan.Index].Value = false;
                    fila.Cells[colCamiseta.Index].Value = "";
                    fila.Cells[colTipo.Index].Value = Tipo.Tecnico.ToString();
                }

                fila.Tag = p;

                DisponiblesDataGridView.Rows.Add(fila);
            }



        }

        //----EVENTOS----//

        private void frmJugadores_Load(object sender, EventArgs e)
        {
            DirectorTecnico scaloni = new DirectorTecnico("leonel", "scaloni");
            equipo = new Equipo(scaloni, "Argentina");

            CargarGrilla();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(DisponiblesDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DisponiblesDataGridView.SelectedRows[0];
                string tipo = fila.Cells[colTipo.Index].Value.ToString();

                if(tipo == Tipo.Jugador.ToString())
                {
                    Jugador jugador = (Jugador)fila.Tag;

                    equipo = equipo + jugador;

                    if(equipo == jugador)
                    {
                        DisponiblesDataGridView.Rows.Remove(fila);
                        MessageBox.Show("Se agrego jugador", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se agrego jugador porque ya esta en el equipo o es capitan",
                            "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede agregar otro tecnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
