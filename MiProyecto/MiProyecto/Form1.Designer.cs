namespace MiProyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btncompras = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnproveedor = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnempleado = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.Slider = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btncompras);
            this.MenuVertical.Controls.Add(this.btnclientes);
            this.MenuVertical.Controls.Add(this.btnproveedor);
            this.MenuVertical.Controls.Add(this.btnreporte);
            this.MenuVertical.Controls.Add(this.btnempleado);
            this.MenuVertical.Controls.Add(this.btnventas);
            this.MenuVertical.Controls.Add(this.btnproducto);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVertical.ForeColor = System.Drawing.Color.White;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseDown);
            // 
            // btncompras
            // 
            this.btncompras.FlatAppearance.BorderSize = 0;
            this.btncompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompras.Image = ((System.Drawing.Image)(resources.GetObject("btncompras.Image")));
            this.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompras.Location = new System.Drawing.Point(-3, 353);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(250, 40);
            this.btncompras.TabIndex = 7;
            this.btncompras.Text = "Compras";
            this.btncompras.UseVisualStyleBackColor = true;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(-3, 215);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(250, 40);
            this.btnclientes.TabIndex = 6;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnproveedor
            // 
            this.btnproveedor.FlatAppearance.BorderSize = 0;
            this.btnproveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnproveedor.Image")));
            this.btnproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproveedor.Location = new System.Drawing.Point(-3, 261);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(250, 40);
            this.btnproveedor.TabIndex = 5;
            this.btnproveedor.Text = "Proveedores";
            this.btnproveedor.UseVisualStyleBackColor = true;
            this.btnproveedor.Click += new System.EventHandler(this.btnproveedor_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.FlatAppearance.BorderSize = 0;
            this.btnreporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Image = ((System.Drawing.Image)(resources.GetObject("btnreporte.Image")));
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(0, 399);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(250, 40);
            this.btnreporte.TabIndex = 4;
            this.btnreporte.Text = "Reportes";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // btnempleado
            // 
            this.btnempleado.FlatAppearance.BorderSize = 0;
            this.btnempleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleado.Image = ((System.Drawing.Image)(resources.GetObject("btnempleado.Image")));
            this.btnempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleado.Location = new System.Drawing.Point(0, 307);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(250, 40);
            this.btnempleado.TabIndex = 3;
            this.btnempleado.Text = "Empleados";
            this.btnempleado.UseVisualStyleBackColor = true;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // btnventas
            // 
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Image = ((System.Drawing.Image)(resources.GetObject("btnventas.Image")));
            this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Location = new System.Drawing.Point(0, 169);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(250, 40);
            this.btnventas.TabIndex = 2;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = true;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // btnproducto
            // 
            this.btnproducto.FlatAppearance.BorderSize = 0;
            this.btnproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnproducto.Image")));
            this.btnproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducto.Location = new System.Drawing.Point(0, 123);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(250, 40);
            this.btnproducto.TabIndex = 1;
            this.btnproducto.Text = "Productos";
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.iconRestaurar);
            this.BarraTitulo.Controls.Add(this.iconMinimizar);
            this.BarraTitulo.Controls.Add(this.iconMaximizar);
            this.BarraTitulo.Controls.Add(this.iconCerrar);
            this.BarraTitulo.Controls.Add(this.Slider);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconRestaurar.Image")));
            this.iconRestaurar.Location = new System.Drawing.Point(998, 3);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaurar.TabIndex = 2;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            this.iconRestaurar.Click += new System.EventHandler(this.iconRestaurar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimizar.Image")));
            this.iconMinimizar.Location = new System.Drawing.Point(972, 3);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximizar.Image")));
            this.iconMaximizar.Location = new System.Drawing.Point(998, 3);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximizar.TabIndex = 2;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconCerrar.Image")));
            this.iconCerrar.Location = new System.Drawing.Point(1024, 3);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(20, 20);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // Slider
            // 
            this.Slider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Slider.Image = ((System.Drawing.Image)(resources.GetObject("Slider.Image")));
            this.Slider.Location = new System.Drawing.Point(6, 9);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(35, 35);
            this.Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slider.TabIndex = 0;
            this.Slider.TabStop = false;
            this.Slider.Click += new System.EventHandler(this.Slider_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContenedor_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SISTEMA DE VENTA DE CELULARES Y ACCESORIOS VASQUEZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox Slider;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnproveedor;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Label label1;
    }
}

