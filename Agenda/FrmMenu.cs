using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            btnAtualizarAgenda.Enabled = false;
            btnInserirAgenda.Enabled = false;
            btnPesquisarAgenda.Enabled = false;
            btnPesquisarAgenda.Enabled = false;
            btnDeletarAgenda.Enabled = false;

            txtNomeAgenda.Enabled = false;
            txtIDAgenda.Enabled = false;
            txtRGAgenda.Enabled = false;
            mtxtCPFAgenda.Enabled = false;
            txtEmailAgenda.Enabled = false;
            txtEnderçoAgenda.Enabled = false;
            txtNumeroAgenda.Enabled = false;
            txtBairroAgenda.Enabled = false;
            txtCidadeAgenda.Enabled = false;
            mtxtTelefone1.Enabled = false;
            mtxtTelefone2.Enabled = false;
            txtTelefone3.Enabled = false;


           
        }

        private void btnNovoAgenda_Click(object sender, EventArgs e)
        {

            btnAtualizarAgenda.Enabled = true;
            btnInserirAgenda.Enabled = true;
            txtIDAgenda.Enabled = true;
            btnPesquisarAgenda.Enabled = true;
            btnPesquisarAgenda.Enabled = true;
            btnDeletarAgenda.Enabled = true;

            txtNomeAgenda.Enabled = true;
            txtRGAgenda.Enabled = true;
            mtxtCPFAgenda.Enabled = true;
            txtEmailAgenda.Enabled = true;
            txtEnderçoAgenda.Enabled = true;
            txtNumeroAgenda.Enabled = true;
            txtBairroAgenda.Enabled = true;
            txtCidadeAgenda.Enabled = true;
            mtxtTelefone1.Enabled = true;
            mtxtTelefone2.Enabled = true;
            txtTelefone3.Enabled = true;

            txtNomeAgenda.Clear();
            txtRGAgenda.Clear();
            txtIDAgenda.Clear();
            mtxtCPFAgenda.Clear();
            txtEmailAgenda.Clear();
            txtEnderçoAgenda.Clear();
            txtNumeroAgenda.Clear();
            txtBairroAgenda.Clear();
            txtCidadeAgenda.Clear();
            mtxtTelefone1.Clear();
            mtxtTelefone2.Clear();
            txtTelefone3.Clear();




        }

        private void btnSairAgenda_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
