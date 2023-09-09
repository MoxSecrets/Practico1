namespace Practico1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_Rut = new System.Windows.Forms.TextBox();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.text_Telefono = new System.Windows.Forms.TextBox();
            this.text_Direccion = new System.Windows.Forms.TextBox();
            this.text_CantidadFacturas = new System.Windows.Forms.TextBox();
            this.text_NumeroUltimaFactura = new System.Windows.Forms.TextBox();
            this.text_MontoUltimaFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaRegistro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dt_FechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.rbtn_EmpresaSi = new System.Windows.Forms.RadioButton();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.rbtn_EmpresaNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Rut
            // 
            this.text_Rut.Location = new System.Drawing.Point(149, 46);
            this.text_Rut.Name = "text_Rut";
            this.text_Rut.Size = new System.Drawing.Size(100, 20);
            this.text_Rut.TabIndex = 0;
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(149, 85);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(100, 20);
            this.text_Nombre.TabIndex = 0;
            // 
            // text_Telefono
            // 
            this.text_Telefono.Location = new System.Drawing.Point(149, 159);
            this.text_Telefono.Name = "text_Telefono";
            this.text_Telefono.Size = new System.Drawing.Size(100, 20);
            this.text_Telefono.TabIndex = 0;
            // 
            // text_Direccion
            // 
            this.text_Direccion.Location = new System.Drawing.Point(149, 194);
            this.text_Direccion.Name = "text_Direccion";
            this.text_Direccion.Size = new System.Drawing.Size(100, 20);
            this.text_Direccion.TabIndex = 0;
            // 
            // text_CantidadFacturas
            // 
            this.text_CantidadFacturas.Location = new System.Drawing.Point(149, 272);
            this.text_CantidadFacturas.Name = "text_CantidadFacturas";
            this.text_CantidadFacturas.Size = new System.Drawing.Size(100, 20);
            this.text_CantidadFacturas.TabIndex = 0;
            // 
            // text_NumeroUltimaFactura
            // 
            this.text_NumeroUltimaFactura.Location = new System.Drawing.Point(149, 310);
            this.text_NumeroUltimaFactura.Name = "text_NumeroUltimaFactura";
            this.text_NumeroUltimaFactura.Size = new System.Drawing.Size(100, 20);
            this.text_NumeroUltimaFactura.TabIndex = 0;
            // 
            // text_MontoUltimaFactura
            // 
            this.text_MontoUltimaFactura.Location = new System.Drawing.Point(149, 355);
            this.text_MontoUltimaFactura.Name = "text_MontoUltimaFactura";
            this.text_MontoUltimaFactura.Size = new System.Drawing.Size(100, 20);
            this.text_MontoUltimaFactura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "EsEmpresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Direccion";
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.AutoSize = true;
            this.txtFechaRegistro.Location = new System.Drawing.Point(22, 236);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(79, 13);
            this.txtFechaRegistro.TabIndex = 1;
            this.txtFechaRegistro.Text = "Fecha Registro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cantidad Facturas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Numero Ultima Factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Monto Ultima Factura";
            // 
            // dgCliente
            // 
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Location = new System.Drawing.Point(505, 32);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.Size = new System.Drawing.Size(879, 246);
            this.dgCliente.TabIndex = 2;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(350, 46);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(350, 100);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dt_FechaRegistro
            // 
            this.dt_FechaRegistro.Location = new System.Drawing.Point(117, 236);
            this.dt_FechaRegistro.Name = "dt_FechaRegistro";
            this.dt_FechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dt_FechaRegistro.TabIndex = 4;
            // 
            // rbtn_EmpresaSi
            // 
            this.rbtn_EmpresaSi.Location = new System.Drawing.Point(149, 123);
            this.rbtn_EmpresaSi.Name = "rbtn_EmpresaSi";
            this.rbtn_EmpresaSi.Size = new System.Drawing.Size(41, 24);
            this.rbtn_EmpresaSi.TabIndex = 5;
            this.rbtn_EmpresaSi.TabStop = true;
            this.rbtn_EmpresaSi.Text = "Si";
            this.rbtn_EmpresaSi.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(350, 152);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 6;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // rbtn_EmpresaNo
            // 
            this.rbtn_EmpresaNo.Location = new System.Drawing.Point(208, 123);
            this.rbtn_EmpresaNo.Name = "rbtn_EmpresaNo";
            this.rbtn_EmpresaNo.Size = new System.Drawing.Size(41, 24);
            this.rbtn_EmpresaNo.TabIndex = 7;
            this.rbtn_EmpresaNo.TabStop = true;
            this.rbtn_EmpresaNo.Text = "No";
            this.rbtn_EmpresaNo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 456);
            this.Controls.Add(this.rbtn_EmpresaNo);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.rbtn_EmpresaSi);
            this.Controls.Add(this.dt_FechaRegistro);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFechaRegistro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_MontoUltimaFactura);
            this.Controls.Add(this.text_NumeroUltimaFactura);
            this.Controls.Add(this.text_CantidadFacturas);
            this.Controls.Add(this.text_Direccion);
            this.Controls.Add(this.text_Telefono);
            this.Controls.Add(this.text_Nombre);
            this.Controls.Add(this.text_Rut);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Rut;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.TextBox text_Telefono;
        private System.Windows.Forms.TextBox text_Direccion;
        private System.Windows.Forms.TextBox text_CantidadFacturas;
        private System.Windows.Forms.TextBox text_NumeroUltimaFactura;
        private System.Windows.Forms.TextBox text_MontoUltimaFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtFechaRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DateTimePicker dt_FechaRegistro;
        private System.Windows.Forms.RadioButton rbtn_EmpresaSi;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.RadioButton rbtn_EmpresaNo;
    }
}

