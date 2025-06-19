namespace GestionDeGastosMensuales
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
            label1 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtCategoria = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            chkEsFijo = new CheckBox();
            chkPagado = new CheckBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvGastos = new DataGridView();
            label5 = new Label();
            txtMonto = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(87, 15);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 18);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(290, 15);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha del gasto";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(98, 78);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 5;
            // 
            // chkEsFijo
            // 
            chkEsFijo.AutoSize = true;
            chkEsFijo.Location = new Point(304, 80);
            chkEsFijo.Name = "chkEsFijo";
            chkEsFijo.Size = new Size(59, 19);
            chkEsFijo.TabIndex = 6;
            chkEsFijo.Text = "Es Fijo";
            chkEsFijo.UseVisualStyleBackColor = true;
            // 
            // chkPagado
            // 
            chkPagado.AutoSize = true;
            chkPagado.Location = new Point(369, 80);
            chkPagado.Name = "chkPagado";
            chkPagado.Size = new Size(66, 19);
            chkPagado.TabIndex = 7;
            chkPagado.Text = "Pagado";
            chkPagado.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(18, 123);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(99, 123);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 174);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 10;
            label4.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(66, 171);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(77, 200);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvGastos
            // 
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastos.Location = new Point(3, 229);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.Size = new Size(679, 217);
            dgvGastos.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 18);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 14;
            label5.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(497, 15);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMonto);
            Controls.Add(label5);
            Controls.Add(dgvGastos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(chkPagado);
            Controls.Add(chkEsFijo);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(txtCategoria);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtCategoria;
        private Label label3;
        private DateTimePicker dtpFecha;
        private CheckBox chkEsFijo;
        private CheckBox chkPagado;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label label4;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvGastos;
        private Label label5;
        private TextBox txtMonto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
