namespace ConsultaFuncionários
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGrid = new DataGridView();
            lblNomeFuncionario = new Label();
            txtNomeFuncionario = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            radioMasculino = new RadioButton();
            dateTimePicker = new DateTimePicker();
            lblID = new Label();
            lblNome = new Label();
            lblData = new Label();
            lblSalario = new Label();
            lblCargo = new Label();
            lblCPF = new Label();
            lblSetor = new Label();
            btnGravar = new Button();
            gpBoxSexo = new GroupBox();
            radioFeminino = new RadioButton();
            txtID = new TextBox();
            btnEditar = new Button();
            button3 = new Button();
            txtNome = new TextBox();
            txtSalario = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            gpBoxSexo.SuspendLayout();
            SuspendLayout();
            // 
            // DataGrid
            // 
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(37, 88);
            DataGrid.Margin = new Padding(3, 4, 3, 4);
            DataGrid.Name = "DataGrid";
            DataGrid.Size = new Size(801, 200);
            DataGrid.TabIndex = 0;
            // 
            // lblNomeFuncionario
            // 
            lblNomeFuncionario.AutoSize = true;
            lblNomeFuncionario.Location = new Point(37, 20);
            lblNomeFuncionario.Name = "lblNomeFuncionario";
            lblNomeFuncionario.Size = new Size(160, 20);
            lblNomeFuncionario.TabIndex = 1;
            lblNomeFuncionario.Text = "Nome do Funcionário";
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.Location = new Point(39, 44);
            txtNomeFuncionario.Margin = new Padding(3, 4, 3, 4);
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.Size = new Size(319, 26);
            txtNomeFuncionario.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(568, 333);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(182, 26);
            maskedTextBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(568, 424);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 4;
            // 
            // radioMasculino
            // 
            radioMasculino.AutoSize = true;
            radioMasculino.Location = new Point(7, 29);
            radioMasculino.Margin = new Padding(3, 4, 3, 4);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(98, 24);
            radioMasculino.TabIndex = 5;
            radioMasculino.TabStop = true;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(90, 421);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(228, 26);
            dateTimePicker.TabIndex = 6;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(60, 333);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 20);
            lblID.TabIndex = 7;
            lblID.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(36, 379);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(55, 20);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(40, 424);
            lblData.Name = "lblData";
            lblData.Size = new Size(48, 20);
            lblData.TabIndex = 9;
            lblData.Text = "Data:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(29, 463);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(62, 20);
            lblSalario.TabIndex = 10;
            lblSalario.Text = "Salário:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(508, 382);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(56, 20);
            lblCargo.TabIndex = 11;
            lblCargo.Text = "Cargo:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(518, 337);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(44, 20);
            lblCPF.TabIndex = 12;
            lblCPF.Text = "CPF:";
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Location = new Point(513, 427);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(52, 20);
            lblSetor.TabIndex = 13;
            lblSetor.Text = "Setor:";
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(333, 553);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 31);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // gpBoxSexo
            // 
            gpBoxSexo.Controls.Add(radioFeminino);
            gpBoxSexo.Controls.Add(radioMasculino);
            gpBoxSexo.Location = new Point(39, 511);
            gpBoxSexo.Margin = new Padding(3, 4, 3, 4);
            gpBoxSexo.Name = "gpBoxSexo";
            gpBoxSexo.Padding = new Padding(3, 4, 3, 4);
            gpBoxSexo.Size = new Size(222, 73);
            gpBoxSexo.TabIndex = 15;
            gpBoxSexo.TabStop = false;
            gpBoxSexo.Text = "Sexo:";
            // 
            // radioFeminino
            // 
            radioFeminino.AutoSize = true;
            radioFeminino.Location = new Point(116, 29);
            radioFeminino.Margin = new Padding(3, 4, 3, 4);
            radioFeminino.Name = "radioFeminino";
            radioFeminino.Size = new Size(92, 24);
            radioFeminino.TabIndex = 6;
            radioFeminino.TabStop = true;
            radioFeminino.Text = "Feminino";
            radioFeminino.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(89, 333);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(65, 26);
            txtID.TabIndex = 16;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(447, 553);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "button2";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(555, 553);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 18;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(89, 379);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(319, 26);
            txtNome.TabIndex = 19;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(90, 460);
            txtSalario.Margin = new Padding(3, 4, 3, 4);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(228, 26);
            txtSalario.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 379);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 26);
            textBox2.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 631);
            Controls.Add(textBox2);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(button3);
            Controls.Add(btnEditar);
            Controls.Add(txtID);
            Controls.Add(gpBoxSexo);
            Controls.Add(btnGravar);
            Controls.Add(lblSetor);
            Controls.Add(lblCPF);
            Controls.Add(lblCargo);
            Controls.Add(lblSalario);
            Controls.Add(lblData);
            Controls.Add(lblNome);
            Controls.Add(lblID);
            Controls.Add(dateTimePicker);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtNomeFuncionario);
            Controls.Add(lblNomeFuncionario);
            Controls.Add(DataGrid);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            gpBoxSexo.ResumeLayout(false);
            gpBoxSexo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGrid;
        private Label lblNomeFuncionario;
        private TextBox txtNomeFuncionario;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private RadioButton radioMasculino;
        private DateTimePicker dateTimePicker;
        private Label lblID;
        private Label lblNome;
        private Label lblData;
        private Label lblSalario;
        private Label lblCargo;
        private Label lblCPF;
        private Label lblSetor;
        private Button btnGravar;
        private GroupBox gpBoxSexo;
        private TextBox txtID;
        private Button btnEditar;
        private Button button3;
        private TextBox txtNome;
        private TextBox txtSalario;
        private RadioButton radioFeminino;
        private TextBox textBox2;
    }
}
