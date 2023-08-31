namespace factura.Vista
{
    partial class cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cliente));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtced = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.NOMBRE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.vista = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btel = new System.Windows.Forms.Button();
            this.btag = new System.Windows.Forms.Button();
            this.bted = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.64968F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.35032F));
            this.tableLayoutPanel1.Controls.Add(this.txt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.93103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.06896F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Location = new System.Drawing.Point(3, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(95, 30);
            this.txt.TabIndex = 1;
            this.txt.Text = "OPCIONES";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt2.Location = new System.Drawing.Point(104, 0);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(586, 30);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "FORMULARIO DE CLIENTES";
            this.txt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.42836F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.57164F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.vista, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(104, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 201);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtapellido, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtced, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtnombre, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.NOMBRE, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtcedula, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(172, 195);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(89, 133);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(80, 20);
            this.txtapellido.TabIndex = 9;
            // 
            // txtced
            // 
            this.txtced.AutoSize = true;
            this.txtced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtced.Location = new System.Drawing.Point(3, 0);
            this.txtced.Name = "txtced";
            this.txtced.Size = new System.Drawing.Size(80, 65);
            this.txtced.TabIndex = 5;
            this.txtced.Text = "CEDULA";
            this.txtced.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(89, 68);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(80, 20);
            this.txtnombre.TabIndex = 8;
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSize = true;
            this.NOMBRE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOMBRE.Location = new System.Drawing.Point(3, 65);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(80, 65);
            this.NOMBRE.TabIndex = 4;
            this.NOMBRE.Text = "NOMBRE";
            this.NOMBRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 65);
            this.label2.TabIndex = 6;
            this.label2.Text = "APELLIDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(89, 3);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(80, 20);
            this.txtcedula.TabIndex = 7;
            // 
            // vista
            // 
            this.vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Apellido,
            this.Nombres});
            this.vista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vista.Location = new System.Drawing.Point(181, 3);
            this.vista.Name = "vista";
            this.vista.Size = new System.Drawing.Size(402, 195);
            this.vista.TabIndex = 3;
            this.vista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Column1";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btag, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bted, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(95, 201);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btel
            // 
            this.btel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btel.Image = ((System.Drawing.Image)(resources.GetObject("btel.Image")));
            this.btel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btel.Location = new System.Drawing.Point(3, 137);
            this.btel.Name = "btel";
            this.btel.Size = new System.Drawing.Size(89, 61);
            this.btel.TabIndex = 9;
            this.btel.Text = "ELIMINAR";
            this.btel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btel.UseVisualStyleBackColor = true;
            this.btel.Click += new System.EventHandler(this.btel_Click);
            // 
            // btag
            // 
            this.btag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btag.Image = ((System.Drawing.Image)(resources.GetObject("btag.Image")));
            this.btag.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btag.Location = new System.Drawing.Point(3, 3);
            this.btag.Name = "btag";
            this.btag.Size = new System.Drawing.Size(89, 61);
            this.btag.TabIndex = 5;
            this.btag.Text = "AGREGAR";
            this.btag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btag.UseVisualStyleBackColor = true;
            this.btag.Click += new System.EventHandler(this.btag_Click);
            // 
            // bted
            // 
            this.bted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bted.Image = ((System.Drawing.Image)(resources.GetObject("bted.Image")));
            this.bted.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bted.Location = new System.Drawing.Point(3, 70);
            this.bted.Name = "bted";
            this.bted.Size = new System.Drawing.Size(89, 61);
            this.bted.TabIndex = 6;
            this.bted.Text = "EDITAR";
            this.bted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bted.UseVisualStyleBackColor = true;
            this.bted.Click += new System.EventHandler(this.bted_Click);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 237);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "cliente";
            this.Text = "CLIENTES";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label txtced;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label NOMBRE;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView vista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btel;
        private System.Windows.Forms.Button btag;
        private System.Windows.Forms.Button bted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
    }
}