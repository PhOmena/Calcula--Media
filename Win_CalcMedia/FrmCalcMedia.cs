using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_CalcMedia
{
    public partial class FrmCadastroAluno : Form
    {
        #region Instância a Classe Aluno
       
        Aluno al = new Aluno();
        string saida;
        #endregion
        #region Método Construtor da Classe
        public FrmCadastroAluno()
        {
            InitializeComponent();
        }
        #endregion


        void Limpar()
        {
            txtNumero.Focus();
            txtNumero.Clear();
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtMedia.Clear();
            txtConceito.Clear();
            picFoto.Image = null;

        }
        #region Código do Botão Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                al.NumeroAluno = int.Parse(txtNumero.Text);
                al.NomeAluno = txtNome.Text;
                al.Nota1 = float.Parse(txtNota1.Text);
                al.Nota2 = float.Parse(txtNota2.Text);
                

                txtMedia.Text = al.Calcular_Media(al.Nota1, al.Nota2).ToString();
                txtMedia.Enabled = false;

                al.media = int.Parse(txtMedia.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dados incompatíveis\n\n"+ex.Message, 
                    "*** ERRO DE DADOS ***", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }


            if (al.media < 5)
            {
                txtConceito.ForeColor = Color.Red;
            }
            if (al.media > 5 && al.media < 7)
            {
                txtConceito.ForeColor = Color.Brown;
            }
            if (al.media >7 && al.media < 9)
            {
                txtConceito.ForeColor = Color.Green;
            }
            if (al.media > 9 && al.media <= 10)
            {
                txtConceito.ForeColor = Color.Blue;
            }

        }
        #endregion
        #region Código do botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            al.LimparControles(this);
            txtNumero.Focus();
        }
        #endregion
        #region Código do botão sair
      
        private void btnSair_Click(object sender, EventArgs e)
        {
            al.saida();
        }
        #endregion
        #region Código do botâo incluir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(0, txtNumero.Text, txtNome.Text, txtNota1.Text, txtNota2.Text, txtMedia.Text,
              txtConceito.Text, picFoto.Image);

            this.Limpar();

        }
        #endregion
        #region Código da tecla ENTER
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNota1.Focus();
            }
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNota2.Focus();
            }
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCalcular.Focus();
            }
        }
        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                picFoto.Load(openFileDialog1.FileName);
            }
            else
            {
                picFoto.Image = null;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int registro = dataGridView1.RowCount;
            if (linha == -1)
            {
                MessageBox.Show("A T E N Ç Ã O ! Selecione um item para excluir", "*** EXCLUSÃO DE ITEM ***",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (registro != 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Cells[0].RowIndex);
            }

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
