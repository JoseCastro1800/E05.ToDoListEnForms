using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E05.ToDoListForms
{
    public partial class frmE05 : Form
    {
        List<Tareas> ListaTa = new List<Tareas>();

        public frmE05()
        {
            InitializeComponent();
        }

        private void CmdCrearTarea_Click(object sender, EventArgs e)
        {
            //Aqui se ingresan los datos
            Tareas T = new Tareas();
            T.Nombre = txtNombre.Text;
            T.Actividad = txtNombreAc.Text;
            T.Hora = txtHora.Text;
            T.Fecha = txtFecha.Text;
            T.Status = txtStatus.Text;
            ListaTa.Add(T);
            MessageBox.Show("Se a creado la nueva Tarea");
            Limpieza();


        }

        private void CmdTareas_Click(object sender, EventArgs e)
        {
            //Aqui se crea las tareas
            ListaTareas.Items.Clear();
            foreach (var item in ListaTa)
            {
                ListaTareas.Items.Add(item.Actividad);
            }
        }

        private void CmdStatus_Click(object sender, EventArgs e)
        {
            //Aqui es para mostrar los status de la tarea
            ListaStatus.Items.Clear();
            foreach (var item in ListaTa)
            {
                ListaStatus.Items.Add(item.Actividad + ": " + item.Status);
            }
        }

        private void CmdDetalles_Click(object sender, EventArgs e)
        {
            ListaDetalles.Items.Clear();
            //Se crea una vaariale para que se utilize mas adelante
            int c = 0;
            //Aqui se ingresa el nombre de la actividad y si es igual procedera a ll demas 
            foreach (var item in ListaTa)
            {
                //Aqui se3 evita el error
                if (ListaTa.Count != 0)
                {

                    if (item.Actividad == txtDeta.Text)
                    {
                        ListaDetalles.Items.Add(item.Nombre);
                        ListaDetalles.Items.Add(item.Actividad);
                        ListaDetalles.Items.Add(item.Hora);
                        ListaDetalles.Items.Add(item.Fecha);
                        ListaDetalles.Items.Add(item.Status);
                        c = c + 1;
                    }
                }
            }
            //Aqui se da a conocer los errores del usuario y se le manda un mensaje
            if (c == 0)
            {
                MessageBox.Show("Se a equivocado de noombre de la actividad intente de nuevo chaval jaja");
            }
        }

        //Boton para limpiar
        private void CmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        public void Limpieza()
        {
            //Un metodo Creado para limpiar las cajas 
            txtNombreAc.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtNombre.Clear();
            txtStatus.Clear();
            txtNombre.Focus();
            txtDeta.Clear();
            ListaDetalles.Items.Clear();
            ListaStatus.Items.Clear();
            ListaTareas.Items.Clear();
        }

        //Boton para cerrar
        private void CmdSalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
