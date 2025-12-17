namespace Home
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btn_categorias = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de Adminstración";
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_logout.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(293, 31);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(92, 18);
            this.lbl_logout.TabIndex = 1;
            this.lbl_logout.Text = "Cerrar Sesión";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(131, 142);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(141, 45);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btn_categorias
            // 
            this.btn_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categorias.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categorias.Location = new System.Drawing.Point(131, 214);
            this.btn_categorias.Name = "btn_categorias";
            this.btn_categorias.Size = new System.Drawing.Size(141, 45);
            this.btn_categorias.TabIndex = 3;
            this.btn_categorias.Text = "Categorias";
            this.btn_categorias.UseVisualStyleBackColor = true;
            // 
            // btn_productos
            // 
            this.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productos.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.Location = new System.Drawing.Point(131, 284);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(141, 45);
            this.btn_productos.TabIndex = 4;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 390);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_categorias);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btn_categorias;
        private System.Windows.Forms.Button btn_productos;
    }
}

