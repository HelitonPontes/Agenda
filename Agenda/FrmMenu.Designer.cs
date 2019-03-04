namespace Agenda
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInserirAgenda = new System.Windows.Forms.Button();
            this.btnSairAgenda = new System.Windows.Forms.Button();
            this.btnPesquisarAgenda = new System.Windows.Forms.Button();
            this.btnAtualizarAgenda = new System.Windows.Forms.Button();
            this.btnNovoAgenda = new System.Windows.Forms.Button();
            this.btnDeletarAgenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAgenda = new System.Windows.Forms.TextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRGAgenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoAgenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroAgenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairroAgenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailAgenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidadeAgenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPFAgenda = new System.Windows.Forms.MaskedTextBox();
            this.txtIDAgenda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnInserirAgenda);
            this.panel1.Controls.Add(this.btnSairAgenda);
            this.panel1.Controls.Add(this.btnPesquisarAgenda);
            this.panel1.Controls.Add(this.btnAtualizarAgenda);
            this.panel1.Controls.Add(this.btnNovoAgenda);
            this.panel1.Controls.Add(this.btnDeletarAgenda);
            this.panel1.Location = new System.Drawing.Point(6, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnInserirAgenda
            // 
            this.btnInserirAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInserirAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAgenda.Location = new System.Drawing.Point(174, 4);
            this.btnInserirAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirAgenda.Name = "btnInserirAgenda";
            this.btnInserirAgenda.Size = new System.Drawing.Size(82, 24);
            this.btnInserirAgenda.TabIndex = 8;
            this.btnInserirAgenda.Text = "&Inserir";
            this.btnInserirAgenda.UseVisualStyleBackColor = false;
            this.btnInserirAgenda.Click += new System.EventHandler(this.btnInserirAgenda_Click);
            // 
            // btnSairAgenda
            // 
            this.btnSairAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSairAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairAgenda.Location = new System.Drawing.Point(432, 4);
            this.btnSairAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnSairAgenda.Name = "btnSairAgenda";
            this.btnSairAgenda.Size = new System.Drawing.Size(82, 24);
            this.btnSairAgenda.TabIndex = 11;
            this.btnSairAgenda.Text = "Sair";
            this.btnSairAgenda.UseVisualStyleBackColor = false;
            this.btnSairAgenda.Click += new System.EventHandler(this.btnSairAgenda_Click);
            // 
            // btnPesquisarAgenda
            // 
            this.btnPesquisarAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPesquisarAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAgenda.Location = new System.Drawing.Point(88, 4);
            this.btnPesquisarAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarAgenda.Name = "btnPesquisarAgenda";
            this.btnPesquisarAgenda.Size = new System.Drawing.Size(82, 24);
            this.btnPesquisarAgenda.TabIndex = 12;
            this.btnPesquisarAgenda.Text = "&Pesquisar";
            this.btnPesquisarAgenda.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarAgenda
            // 
            this.btnAtualizarAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtualizarAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarAgenda.Location = new System.Drawing.Point(260, 4);
            this.btnAtualizarAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizarAgenda.Name = "btnAtualizarAgenda";
            this.btnAtualizarAgenda.Size = new System.Drawing.Size(82, 24);
            this.btnAtualizarAgenda.TabIndex = 9;
            this.btnAtualizarAgenda.Text = "&Atualizar";
            this.btnAtualizarAgenda.UseVisualStyleBackColor = false;
            // 
            // btnNovoAgenda
            // 
            this.btnNovoAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovoAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAgenda.Location = new System.Drawing.Point(2, 4);
            this.btnNovoAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoAgenda.Name = "btnNovoAgenda";
            this.btnNovoAgenda.Size = new System.Drawing.Size(82, 24);
            this.btnNovoAgenda.TabIndex = 7;
            this.btnNovoAgenda.Text = "&Novo";
            this.btnNovoAgenda.UseVisualStyleBackColor = false;
            this.btnNovoAgenda.Click += new System.EventHandler(this.btnNovoAgenda_Click);
            // 
            // btnDeletarAgenda
            // 
            this.btnDeletarAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeletarAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarAgenda.Location = new System.Drawing.Point(346, 4);
            this.btnDeletarAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletarAgenda.Name = "btnDeletarAgenda";
            this.btnDeletarAgenda.Size = new System.Drawing.Size(82, 24);
            this.btnDeletarAgenda.TabIndex = 10;
            this.btnDeletarAgenda.Text = "&Deletar";
            this.btnDeletarAgenda.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNomeAgenda
            // 
            this.txtNomeAgenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeAgenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nome", true));
            this.txtNomeAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAgenda.Location = new System.Drawing.Point(5, 81);
            this.txtNomeAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeAgenda.Name = "txtNomeAgenda";
            this.txtNomeAgenda.Size = new System.Drawing.Size(443, 26);
            this.txtNomeAgenda.TabIndex = 2;
            // 
            // tableBindingSource
            // 
             // txtRGAgenda
            // 
            this.txtRGAgenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRGAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGAgenda.Location = new System.Drawing.Point(452, 82);
            this.txtRGAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtRGAgenda.Name = "txtRGAgenda";
            this.txtRGAgenda.Size = new System.Drawing.Size(142, 26);
            this.txtRGAgenda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CPF", true));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // txtEnderecoAgenda
            // 
            this.txtEnderecoAgenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnderecoAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoAgenda.Location = new System.Drawing.Point(5, 130);
            this.txtEnderecoAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnderecoAgenda.Name = "txtEnderecoAgenda";
            this.txtEnderecoAgenda.Size = new System.Drawing.Size(382, 26);
            this.txtEnderecoAgenda.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // txtNumeroAgenda
            // 
            this.txtNumeroAgenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroAgenda.Location = new System.Drawing.Point(390, 131);
            this.txtNumeroAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroAgenda.Name = "txtNumeroAgenda";
            this.txtNumeroAgenda.Size = new System.Drawing.Size(56, 26);
            this.txtNumeroAgenda.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero";
            // 
            // txtBairroAgenda
            // 
            this.txtBairroAgenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairroAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroAgenda.Location = new System.Drawing.Point(450, 131);
            this.txtBairroAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairroAgenda.Name = "txtBairroAgenda";
            this.txtBairroAgenda.Size = new System.Drawing.Size(268, 26);
            this.txtBairroAgenda.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bairro";
            // 
            // txtEmailAgenda
            // 
            this.txtEmailAgenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmailAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAgenda.Location = new System.Drawing.Point(5, 183);
            this.txtEmailAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAgenda.Name = "txtEmailAgenda";
            this.txtEmailAgenda.Size = new System.Drawing.Size(379, 26);
            this.txtEmailAgenda.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // txtCidadeAgenda
            // 
            this.txtCidadeAgenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeAgenda.Location = new System.Drawing.Point(397, 196);
            this.txtCidadeAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidadeAgenda.Name = "txtCidadeAgenda";
            this.txtCidadeAgenda.Size = new System.Drawing.Size(332, 26);
            this.txtCidadeAgenda.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telefone1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(597, 230);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefone3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(314, 230);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefone2";
            // 
            // mtxtTelefone2
            // 
            this.mtxtTelefone2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone2.Location = new System.Drawing.Point(313, 251);
            this.mtxtTelefone2.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtTelefone2.Mask = "(00)000-00-0000";
            this.mtxtTelefone2.Name = "mtxtTelefone2";
            this.mtxtTelefone2.Size = new System.Drawing.Size(121, 26);
            this.mtxtTelefone2.TabIndex = 23;
            // 
            // mtxtTelefone3
            // 
            this.mtxtTelefone3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone3.Location = new System.Drawing.Point(600, 251);
            this.mtxtTelefone3.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtTelefone3.Mask = "(00)000-00-0000";
            this.mtxtTelefone3.Name = "mtxtTelefone3";
            this.mtxtTelefone3.Size = new System.Drawing.Size(120, 26);
            this.mtxtTelefone3.TabIndex = 24;
            // 
            // mtxtTelefone1
            // 
            this.mtxtTelefone1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone1.Location = new System.Drawing.Point(6, 238);
            this.mtxtTelefone1.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtTelefone1.Mask = "(00)000-00-0000";
            this.mtxtTelefone1.Name = "mtxtTelefone1";
            this.mtxtTelefone1.Size = new System.Drawing.Size(117, 26);
            this.mtxtTelefone1.TabIndex = 25;
            // 
            // mtxtCPFAgenda
            // 
            this.mtxtCPFAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPFAgenda.Location = new System.Drawing.Point(613, 94);
            this.mtxtCPFAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtCPFAgenda.Mask = "000,000,000-00";
            this.mtxtCPFAgenda.Name = "mtxtCPFAgenda";
            this.mtxtCPFAgenda.Size = new System.Drawing.Size(116, 26);
            this.mtxtCPFAgenda.TabIndex = 26;
            // 
            // txtIDAgenda
            // 
            this.txtIDAgenda.Location = new System.Drawing.Point(682, 66);
            this.txtIDAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDAgenda.Name = "txtIDAgenda";
            this.txtIDAgenda.Size = new System.Drawing.Size(47, 20);
            this.txtIDAgenda.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(663, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Id";
            // 
            // tableTableAdapter
            // 
           // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(5, 282);
            this.tableDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowTemplate.Height = 24;
            this.tableDataGridView.Size = new System.Drawing.Size(735, 179);
            this.tableDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RG";
            this.dataGridViewTextBoxColumn3.HeaderText = "RG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn4.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Endereço";
            this.dataGridViewTextBoxColumn5.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn6.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Telefone1";
            this.dataGridViewTextBoxColumn10.HeaderText = "Telefone1";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Telefone2";
            this.dataGridViewTextBoxColumn11.HeaderText = "Telefone2";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Telefone3";
            this.dataGridViewTextBoxColumn12.HeaderText = "Telefone3";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DataCadastro";
            this.dataGridViewTextBoxColumn13.HeaderText = "DataCadastro";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEnderecoAgenda);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.mtxtTelefone1);
            this.panel2.Controls.Add(this.txtEmailAgenda);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtNomeAgenda);
            this.panel2.Controls.Add(this.txtRGAgenda);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBairroAgenda);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNumeroAgenda);
            this.panel2.Controls.Add(this.tableDataGridView);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 477);
            this.panel2.TabIndex = 29;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(765, 501);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIDAgenda);
            this.Controls.Add(this.mtxtCPFAgenda);
            this.Controls.Add(this.mtxtTelefone3);
            this.Controls.Add(this.mtxtTelefone2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCidadeAgenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisarAgenda;
        private System.Windows.Forms.Button btnInserirAgenda;
        private System.Windows.Forms.Button btnSairAgenda;
        private System.Windows.Forms.Button btnNovoAgenda;
        private System.Windows.Forms.Button btnDeletarAgenda;
        private System.Windows.Forms.Button btnAtualizarAgenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAgenda;
        private System.Windows.Forms.TextBox txtRGAgenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnderecoAgenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroAgenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairroAgenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailAgenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidadeAgenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone2;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone3;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone1;
        private System.Windows.Forms.MaskedTextBox mtxtCPFAgenda;
        private System.Windows.Forms.TextBox txtIDAgenda;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.BindingSource tableBindingSource;
       private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Panel panel2;
    }
}