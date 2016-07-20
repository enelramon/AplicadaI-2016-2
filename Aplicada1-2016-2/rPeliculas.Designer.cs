namespace Aplicada1_2016_2
{
    partial class rPeliculas
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
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label clasificacionLabel;
            System.Windows.Forms.Label iMDBLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.Windows.Forms.Label autorIdLabel;
            this.peliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.anoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clasificacionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iMDBTextBox = new System.Windows.Forms.TextBox();
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            this.peliculasAutoresDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autorIdComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.AutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            peliculaIdLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            clasificacionLabel = new System.Windows.Forms.Label();
            iMDBLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            autorIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasAutoresDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Location = new System.Drawing.Point(25, 48);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(59, 13);
            peliculaIdLabel.TabIndex = 1;
            peliculaIdLabel.Text = "Pelicula Id:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(25, 74);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "Titulo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(25, 100);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(25, 150);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(29, 13);
            anoLabel.TabIndex = 7;
            anoLabel.Text = "Ano:";
            // 
            // clasificacionLabel
            // 
            clasificacionLabel.AutoSize = true;
            clasificacionLabel.Location = new System.Drawing.Point(228, 152);
            clasificacionLabel.Name = "clasificacionLabel";
            clasificacionLabel.Size = new System.Drawing.Size(69, 13);
            clasificacionLabel.TabIndex = 9;
            clasificacionLabel.Text = "Clasificacion:";
            // 
            // iMDBLabel
            // 
            iMDBLabel.AutoSize = true;
            iMDBLabel.Location = new System.Drawing.Point(25, 179);
            iMDBLabel.Name = "iMDBLabel";
            iMDBLabel.Size = new System.Drawing.Size(37, 13);
            iMDBLabel.TabIndex = 11;
            iMDBLabel.Text = "IMDB:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(228, 182);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(67, 13);
            categoriaIdLabel.TabIndex = 13;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // autorIdLabel
            // 
            autorIdLabel.AutoSize = true;
            autorIdLabel.Location = new System.Drawing.Point(9, 29);
            autorIdLabel.Name = "autorIdLabel";
            autorIdLabel.Size = new System.Drawing.Size(47, 13);
            autorIdLabel.TabIndex = 16;
            autorIdLabel.Text = "Autor Id:";
            // 
            // peliculaIdTextBox
            // 
            this.peliculaIdTextBox.Location = new System.Drawing.Point(98, 45);
            this.peliculaIdTextBox.Name = "peliculaIdTextBox";
            this.peliculaIdTextBox.Size = new System.Drawing.Size(120, 20);
            this.peliculaIdTextBox.TabIndex = 2;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(98, 71);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(323, 20);
            this.tituloTextBox.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(98, 97);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(323, 47);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // anoNumericUpDown
            // 
            this.anoNumericUpDown.Location = new System.Drawing.Point(98, 150);
            this.anoNumericUpDown.Name = "anoNumericUpDown";
            this.anoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.anoNumericUpDown.TabIndex = 8;
            // 
            // clasificacionNumericUpDown
            // 
            this.clasificacionNumericUpDown.Location = new System.Drawing.Point(301, 152);
            this.clasificacionNumericUpDown.Name = "clasificacionNumericUpDown";
            this.clasificacionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.clasificacionNumericUpDown.TabIndex = 10;
            // 
            // iMDBTextBox
            // 
            this.iMDBTextBox.Location = new System.Drawing.Point(98, 176);
            this.iMDBTextBox.Name = "iMDBTextBox";
            this.iMDBTextBox.Size = new System.Drawing.Size(120, 20);
            this.iMDBTextBox.TabIndex = 12;
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(301, 179);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(120, 21);
            this.categoriaIdComboBox.TabIndex = 14;
            this.categoriaIdComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaIdComboBox_SelectedIndexChanged);
            // 
            // peliculasAutoresDataGridView
            // 
            this.peliculasAutoresDataGridView.AllowUserToAddRows = false;
            this.peliculasAutoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliculasAutoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutorId,
            this.Nombres});
            this.peliculasAutoresDataGridView.Location = new System.Drawing.Point(6, 56);
            this.peliculasAutoresDataGridView.Name = "peliculasAutoresDataGridView";
            this.peliculasAutoresDataGridView.ReadOnly = true;
            this.peliculasAutoresDataGridView.RowHeadersWidth = 10;
            this.peliculasAutoresDataGridView.Size = new System.Drawing.Size(381, 96);
            this.peliculasAutoresDataGridView.TabIndex = 15;
            this.peliculasAutoresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.peliculasAutoresDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(autorIdLabel);
            this.groupBox1.Controls.Add(this.autorIdComboBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.peliculasAutoresDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(28, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 172);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autores";
            // 
            // autorIdComboBox
            // 
            this.autorIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autorIdComboBox.FormattingEnabled = true;
            this.autorIdComboBox.Location = new System.Drawing.Point(62, 26);
            this.autorIdComboBox.Name = "autorIdComboBox";
            this.autorIdComboBox.Size = new System.Drawing.Size(244, 21);
            this.autorIdComboBox.TabIndex = 17;
            this.autorIdComboBox.SelectedIndexChanged += new System.EventHandler(this.autorIdComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(28, 384);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 17;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(224, 45);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 18;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // AutorId
            // 
            this.AutorId.DataPropertyName = "AutorId";
            this.AutorId.HeaderText = "AutorId";
            this.AutorId.Name = "AutorId";
            this.AutorId.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // rPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 518);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdComboBox);
            this.Controls.Add(iMDBLabel);
            this.Controls.Add(this.iMDBTextBox);
            this.Controls.Add(clasificacionLabel);
            this.Controls.Add(this.clasificacionNumericUpDown);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoNumericUpDown);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(this.peliculaIdTextBox);
            this.Name = "rPeliculas";
            this.Text = "rPeliculas";
            this.Load += new System.EventHandler(this.rPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasAutoresDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox peliculaIdTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown anoNumericUpDown;
        private System.Windows.Forms.NumericUpDown clasificacionNumericUpDown;
        private System.Windows.Forms.TextBox iMDBTextBox;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
        private System.Windows.Forms.DataGridView peliculasAutoresDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox autorIdComboBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
    }
}