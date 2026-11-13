namespace CRUDEFCore
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDoc = new TextBox();
            lblDoc = new Label();
            lblSueldo = new Label();
            txtSueldo = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            Actualizar = new Button();
            btnEliminar = new Button();
            dgvEmpleados = new DataGridView();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(337, 97);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(100, 23);
            txtDoc.TabIndex = 2;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(214, 102);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(117, 15);
            lblDoc.TabIndex = 3;
            lblDoc.Text = "Numero Documento";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(475, 102);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(43, 15);
            lblSueldo.TabIndex = 4;
            lblSueldo.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(524, 94);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(98, 190);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(225, 190);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(337, 190);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(75, 23);
            Actualizar.TabIndex = 8;
            Actualizar.Text = "Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(448, 190);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(98, 293);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(604, 177);
            dgvEmpleados.TabIndex = 10;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(86, 147);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(39, 152);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 12;
            lblBuscar.Text = "Buscar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 564);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnEliminar);
            Controls.Add(Actualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtSueldo);
            Controls.Add(lblSueldo);
            Controls.Add(lblDoc);
            Controls.Add(txtDoc);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDoc;
        private Label lblDoc;
        private Label lblSueldo;
        private TextBox txtSueldo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button Actualizar;
        private Button btnEliminar;
        private DataGridView dgvEmpleados;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}
