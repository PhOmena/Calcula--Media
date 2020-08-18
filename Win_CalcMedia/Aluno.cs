using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Win_CalcMedia
{
    class Aluno
    {
        private int numero;
        private string nome;
        private float n1;
        private float n2;

        public object resposta;
        internal int media;

        public int NumeroAluno
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }   

        public string NomeAluno
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public float Nota1
        {
            get
            {
                return n1;
            }
            set
            {
                n1 = value;
            }
        }

        public float Nota2
        {
            get
            {
                return n2;
            }
            set
            {
                n2 = value;
            }
        }

        public float Calcular_Media(float x, float y)
        {
            

            if(((x + y) / 2) <= 10)
            {
                return (x + y) / 2;
            }
            else
            {
                MessageBox.Show("Dados incompatíveis", "-----------Erro----------",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return 0;
            }
        }

        public void LimparControles(Control con)
        {
            foreach (Control caixa in con.Controls)
            {
                if (caixa is TextBox)
                {
                    ((TextBox)caixa).Clear();
                }
                else
                {
                    LimparControles(caixa);
                }
            }
        }

        public void saida()
        {
            this.resposta = MessageBox.Show("Deseja Sair da Aplicação?",
                "*** FINALIZANDO ***",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
            if (resposta.Equals(DialogResult.Yes)) { Application.Exit(); }
        }

    }
}
