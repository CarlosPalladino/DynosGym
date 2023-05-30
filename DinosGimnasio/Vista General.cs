﻿using Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using System.IO;

namespace DinosGimnasio
{
    public partial class Vista_General : Form
    {


        private List<Usuarios> lista;
        private List<Compra> listacompra = new List<Compra>();
        private int idUsuarioSeleccionado;

        public Vista_General()
        {
            InitializeComponent();
        }
        private void Vista_General_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Registro nuevo = new Registro();
            nuevo.ShowDialog();
            Cargar();
        }
        public void Cargar()
        {
            MetodoUser metodo = new MetodoUser();
            Metodocompras compra = new Metodocompras();

            try
            {
                lista = metodo.lista();
                dgvUsers.DataSource = lista;
                listacompra = compra.lista();
                dgvCompra.DataSource = listacompra;
                CargarImagen(lista[0].FotoDePerfil);
                OcultarColumnas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {

                picImg.Image = Image.FromFile(imagen);

            }
            catch (Exception)
            {

                {
                    picImg.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");

                }
            }
        }
        public void OcultarColumnas()
        {
            dgvUsers.Columns["FotoDePerfil"].Visible = false;
            dgvUsers.Columns["Pago"].Visible = false;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;
                int idUsuarioSeleccionado = seleccionado.Id; // Suponiendo que la clase Usuarios tiene una propiedad Id que representa el ID del usuario

                List<Compra> comprasFiltradas = new List<Compra>();

                foreach (Compra compra in listacompra)
                {
                    if (compra.IdUsuario == idUsuarioSeleccionado)
                    {
                        comprasFiltradas.Add(compra);
                    }
                }

                dgvCompra.DataSource = comprasFiltradas;
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {

                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;

                CompraUsers compra = new CompraUsers(seleccionado);
                compra.ShowDialog();

            }
        }
     





    }

}





