using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class frmFilmes : Form
    {
        public frmFilmes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Filme bllFilme = new Camadas.BLL.Filme();
            Camadas.MODEL.Filme filme = new Camadas.MODEL.Filme();
            filme.id = Convert.ToInt32("-1");
            filme.titulo = txtTitulo.Text;
            filme.genero = txtGenero.Text;
            filme.quantidade = Convert.ToInt32(txtQuantidade.Text);
            filme.valor = Convert.ToSingle(txtValor.Text);
            bllFilme.Insert(filme);
            dgvFilmes.DataSource = bllFilme.Select(); 
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void frmFilmes_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Filme bllFilme = new Camadas.BLL.Filme();
            dgvFilmes.DataSource = bllFilme.Select(); 
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtGenero.Text = "";
            txtQuantidade.Text = "";
            txtTitulo.Text = "";
            txtValor.Text = "";
            txtTitulo.Text = ""; 
        }
    }
}
