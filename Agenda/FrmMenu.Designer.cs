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
            this.btnPesquisarAgenda = new System.Windows.Forms.Button();
            this.btnInserirAgenda = new System.Windows.Forms.Button();
            this.btnSairAgenda = new System.Windows.Forms.Button();
            this.btnNovoAgenda = new System.Windows.Forms.Button();
            this.btnDeletarAgenda = new System.Windows.Forms.Button();
            this.btnAtualizarAgenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAgenda = new System.Windows.Forms.TextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new Agenda.AgendaDataSet();
            this.txtRGAgenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderçoAgenda = new System.Windows.Forms.TextBox();
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
            this.txtTelefone3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPFAgenda = new System.Windows.Forms.MaskedTextBox();
            this.txtIDAgenda = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableTableAdapter = new Agenda.AgendaDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Agenda.AgendaDataSetTableAdapters.TableAdapterManager();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPesquisarAgenda);
            this.panel1.Controls.Add(this.btnInserirAgenda);
            this.panel1.Controls.Add(this.btnSairAgenda);
            this.panel1.Controls.Add(this.btnNovoAgenda);
            this.panel1.Controls.Add(this.btnDeletarAgenda);
            this.panel1.Controls.Add(this.btnAtualizarAgenda);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnPesquisarAgenda
            // 
            this.btnPesquisarAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPesquisarAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAgenda.Location = new System.Drawing.Point(120, 4);
            this.btnPesquisarAgenda.Name = "btnPesquisarAgenda";
            this.btnPesquisarAgenda.Size = new System.Drawing.Size(102, 30);
            this.btnPesquisarAgenda.TabIndex = 12;
            this.btnPesquisarAgenda.Text = "&Pesquisar";
            this.btnPesquisarAgenda.UseVisualStyleBackColor = false;
            // 
            // btnInserirAgenda
            // 
            this.btnInserirAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInserirAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirAgenda.Location = new System.Drawing.Point(228, 4);
            this.btnInserirAgenda.Name = "btnInserirAgenda";
            this.btnInserirAgenda.Size = new System.Drawing.Size(102, 30);
            this.btnInserirAgenda.TabIndex = 8;
            this.btnInserirAgenda.Text = "&Inserir";
            this.btnInserirAgenda.UseVisualStyleBackColor = false;
            // 
            // btnSairAgenda
            // 
            this.btnSairAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSairAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairAgenda.Location = new System.Drawing.Point(552, 4);
            this.btnSairAgenda.Name = "btnSairAgenda";
            this.btnSairAgenda.Size = new System.Drawing.Size(102, 30);
            this.btnSairAgenda.TabIndex = 11;
            this.btnSairAgenda.Text = "Sair";
            this.btnSairAgenda.UseVisualStyleBackColor = false;
            this.btnSairAgenda.Click += new System.EventHandler(this.btnSairAgenda_Click);
            // 
            // btnNovoAgenda
            // 
            this.btnNovoAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovoAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAgenda.Location = new System.Drawing.Point(12, 4);
            this.btnNovoAgenda.Name = "btnNovoAgenda";
            this.btnNovoAgenda.Size = new System.Drawing.Size(102, 30);
            this.btnNovoAgenda.TabIndex = 7;
            this.btnNovoAgenda.Text = "&Novo";
            this.btnNovoAgenda.UseVisualStyleBackColor = false;
            this.btnNovoAgenda.Click += new System.EventHandler(this.btnNovoAgenda_Click);
            // 
            // btnDeletarAgenda
            // 
            this.btnDeletarAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeletarAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarAgenda.Location = new System.Drawing.Point(444, 4);
            this.btnDeletarAgenda.Name = "btnDeletarAgenda";
            this.btnDeletarAgenda.Size = new System.Drawing.Size(102, 30);
            this.btnDeletarAgenda.TabIndex = 10;
            this.btnDeletarAgenda.Text = "&Deletar";
            this.btnDeletarAgenda.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarAgenda
            // 
            this.btnAtualizarAgenda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtualizarAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarAgenda.Location = new System.Drawing.Point(336, 4);
            this.btnAtualizarAgenda.Name = "btnAtualizarAgenda";
            this.btnAtualizarAgenda.Size = new System.Drawing.Size(102, 30);
            this.btnAtualizarAgenda.TabIndex = 9;
            this.btnAtualizarAgenda.Text = "&Atualizar";
            this.btnAtualizarAgenda.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNomeAgenda
            // 
            this.txtNomeAgenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nome", true));
            this.txtNomeAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAgenda.Location = new System.Drawing.Point(10, 116);
            this.txtNomeAgenda.Name = "txtNomeAgenda";
            this.txtNomeAgenda.Size = new System.Drawing.Size(589, 30);
            this.txtNomeAgenda.TabIndex = 2;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "AgendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtRGAgenda
            // 
            this.txtRGAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGAgenda.Location = new System.Drawing.Point(614, 116);
            this.txtRGAgenda.Name = "txtRGAgenda";
            this.txtRGAgenda.Size = new System.Drawing.Size(188, 30);
            this.txtRGAgenda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CPF", true));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // txtEnderçoAgenda
            // 
            this.txtEnderçoAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderçoAgenda.Location = new System.Drawing.Point(12, 177);
            this.txtEnderçoAgenda.Name = "txtEnderçoAgenda";
            this.txtEnderçoAgenda.Size = new System.Drawing.Size(508, 30);
            this.txtEnderçoAgenda.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // txtNumeroAgenda
            // 
            this.txtNumeroAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroAgenda.Location = new System.Drawing.Point(526, 177);
            this.txtNumeroAgenda.Name = "txtNumeroAgenda";
            this.txtNumeroAgenda.Size = new System.Drawing.Size(73, 30);
            this.txtNumeroAgenda.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero";
            // 
            // txtBairroAgenda
            // 
            this.txtBairroAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroAgenda.Location = new System.Drawing.Point(614, 177);
            this.txtBairroAgenda.Name = "txtBairroAgenda";
            this.txtBairroAgenda.Size = new System.Drawing.Size(356, 30);
            this.txtBairroAgenda.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bairro";
            // 
            // txtEmailAgenda
            // 
            this.txtEmailAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAgenda.Location = new System.Drawing.Point(16, 241);
            this.txtEmailAgenda.Name = "txtEmailAgenda";
            this.txtEmailAgenda.Size = new System.Drawing.Size(504, 30);
            this.txtEmailAgenda.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // txtCidadeAgenda
            // 
            this.txtCidadeAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeAgenda.Location = new System.Drawing.Point(529, 241);
            this.txtCidadeAgenda.Name = "txtCidadeAgenda";
            this.txtCidadeAgenda.Size = new System.Drawing.Size(441, 30);
            this.txtCidadeAgenda.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telefone1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(796, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefone3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(419, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefone2";
            // 
            // mtxtTelefone2
            // 
            this.mtxtTelefone2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone2.Location = new System.Drawing.Point(417, 309);
            this.mtxtTelefone2.Mask = "(00)000-00-0000";
            this.mtxtTelefone2.Name = "mtxtTelefone2";
            this.mtxtTelefone2.Size = new System.Drawing.Size(160, 30);
            this.mtxtTelefone2.TabIndex = 23;
            // 
            // txtTelefone3
            // 
            this.txtTelefone3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone3.Location = new System.Drawing.Point(800, 309);
            this.txtTelefone3.Mask = "(00)000-00-0000";
            this.txtTelefone3.Name = "txtTelefone3";
            this.txtTelefone3.Size = new System.Drawing.Size(159, 30);
            this.txtTelefone3.TabIndex = 24;
            // 
            // mtxtTelefone1
            // 
            this.mtxtTelefone1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone1.Location = new System.Drawing.Point(16, 309);
            this.mtxtTelefone1.Mask = "(00)000-00-0000";
            this.mtxtTelefone1.Name = "mtxtTelefone1";
            this.mtxtTelefone1.Size = new System.Drawing.Size(155, 30);
            this.mtxtTelefone1.TabIndex = 25;
            // 
            // mtxtCPFAgenda
            // 
            this.mtxtCPFAgenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPFAgenda.Location = new System.Drawing.Point(817, 116);
            this.mtxtCPFAgenda.Mask = "000,000,000-00";
            this.mtxtCPFAgenda.Name = "mtxtCPFAgenda";
            this.mtxtCPFAgenda.Size = new System.Drawing.Size(153, 30);
            this.mtxtCPFAgenda.TabIndex = 26;
            // 
            // txtIDAgenda
            // 
            this.txtIDAgenda.Location = new System.Drawing.Point(909, 81);
            this.txtIDAgenda.Name = "txtIDAgenda";
            this.txtIDAgenda.Size = new System.Drawing.Size(61, 22);
            this.txtIDAgenda.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(884, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Id";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Agenda.AgendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tableDataGridView.Location = new System.Drawing.Point(16, 359);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowTemplate.Height = 24;
            this.tableDataGridView.Size = new System.Drawing.Size(943, 220);
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
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1011, 617);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIDAgenda);
            this.Controls.Add(this.mtxtCPFAgenda);
            this.Controls.Add(this.mtxtTelefone1);
            this.Controls.Add(this.txtTelefone3);
            this.Controls.Add(this.mtxtTelefone2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCidadeAgenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmailAgenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBairroAgenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroAgenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnderçoAgenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRGAgenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAgenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox txtEnderçoAgenda;
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
        private System.Windows.Forms.MaskedTextBox txtTelefone3;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone1;
        private System.Windows.Forms.MaskedTextBox mtxtCPFAgenda;
        private System.Windows.Forms.TextBox txtIDAgenda;
        private System.Windows.Forms.Label label12;
        private AgendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AgendaDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private AgendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
    }
}