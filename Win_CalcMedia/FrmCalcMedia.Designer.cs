namespace Win_CalcMedia
{
    partial class FrmCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtConceito = new System.Windows.Forms.TextBox();
            this.lblConceito = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Win_CalcMedia.Properties.Resources.logout256_24927;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(12, 375);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 47);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::Win_CalcMedia.Properties.Resources.add_icon_icons_com_74429;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.Location = new System.Drawing.Point(390, 250);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(130, 47);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Win_CalcMedia.Properties.Resources.delete_40623;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(175, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 47);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::Win_CalcMedia.Properties.Resources.check_ok_accept_apply_1582__1_;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(390, 66);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 47);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 342);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.txtConceito);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.lblConceito);
            this.tabPage1.Controls.Add(this.picFoto);
            this.tabPage1.Controls.Add(this.btnFoto);
            this.tabPage1.Controls.Add(this.txtMedia);
            this.tabPage1.Controls.Add(this.txtNota2);
            this.tabPage1.Controls.Add(this.btnIncluir);
            this.tabPage1.Controls.Add(this.txtNota1);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtNumero);
            this.tabPage1.Controls.Add(this.lblMedia);
            this.tabPage1.Controls.Add(this.lblNota2);
            this.tabPage1.Controls.Add(this.lblNota1);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.lblNumero);
            this.tabPage1.ForeColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro Aluno";
            // 
            // txtConceito
            // 
            this.txtConceito.Location = new System.Drawing.Point(110, 271);
            this.txtConceito.Name = "txtConceito";
            this.txtConceito.Size = new System.Drawing.Size(250, 26);
            this.txtConceito.TabIndex = 23;
            // 
            // lblConceito
            // 
            this.lblConceito.AutoSize = true;
            this.lblConceito.Location = new System.Drawing.Point(22, 274);
            this.lblConceito.Name = "lblConceito";
            this.lblConceito.Size = new System.Drawing.Size(77, 18);
            this.lblConceito.TabIndex = 22;
            this.lblConceito.Text = "Conceito";
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(704, 21);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(207, 218);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 21;
            this.picFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Image = global::Win_CalcMedia.Properties.Resources.iPhoto_photo_picture_camera_2661;
            this.btnFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoto.Location = new System.Drawing.Point(740, 245);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(130, 47);
            this.btnFoto.TabIndex = 20;
            this.btnFoto.Text = "Foto";
            this.btnFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(110, 223);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(250, 26);
            this.txtMedia.TabIndex = 19;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(110, 168);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(250, 26);
            this.txtNota2.TabIndex = 18;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(110, 116);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(250, 26);
            this.txtNota1.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(110, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 26);
            this.txtNome.TabIndex = 16;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(110, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 26);
            this.txtNumero.TabIndex = 15;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(43, 223);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(56, 18);
            this.lblMedia.TabIndex = 14;
            this.lblMedia.Text = "Média";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(39, 169);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(60, 18);
            this.lblNota2.TabIndex = 13;
            this.lblNota2.Text = "2ª Nota";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(39, 119);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(60, 18);
            this.lblNota1.TabIndex = 12;
            this.lblNota1.Text = "1ª Nota";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(43, 21);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(67, 18);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "Número";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemover);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Aluno";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::Win_CalcMedia.Properties.Resources.Delete_27010;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(815, 120);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(130, 47);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nome,
            this.nota1,
            this.nota2,
            this.nota3,
            this.conceito,
            this.foto});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // nota1
            // 
            this.nota1.HeaderText = "Nota 1";
            this.nota1.Name = "nota1";
            // 
            // nota2
            // 
            this.nota2.HeaderText = "Nota 2";
            this.nota2.Name = "nota2";
            // 
            // nota3
            // 
            this.nota3.HeaderText = "Média";
            this.nota3.Name = "nota3";
            // 
            // conceito
            // 
            this.conceito.HeaderText = "Conceito";
            this.conceito.Name = "conceito";
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(983, 444);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroAluno";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtConceito;
        private System.Windows.Forms.Label lblConceito;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceito;
        private System.Windows.Forms.DataGridViewImageColumn foto;
    }
}

