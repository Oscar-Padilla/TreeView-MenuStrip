namespace TreeView___MenuStrip
{
    partial class Pantalla2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarRaízToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cómoSeUsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tBElemento = new System.Windows.Forms.TextBox();
            this.btnAddDel = new System.Windows.Forms.Button();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.informaciónToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cargarToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.guardarToolStripMenuItem.Text = "Guardar TreeView";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.cargarToolStripMenuItem.Text = "Cargar TreeView";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarRaízToolStripMenuItem,
            this.insertarNodoToolStripMenuItem,
            this.toolStripSeparator1,
            this.eliminarElementoToolStripMenuItem,
            this.eliminarTodoToolStripMenuItem});
            this.herramientasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // insertarRaízToolStripMenuItem
            // 
            this.insertarRaízToolStripMenuItem.Name = "insertarRaízToolStripMenuItem";
            this.insertarRaízToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.insertarRaízToolStripMenuItem.Text = "Insertar Raíz";
            this.insertarRaízToolStripMenuItem.Click += new System.EventHandler(this.insertarRaízToolStripMenuItem_Click);
            // 
            // insertarNodoToolStripMenuItem
            // 
            this.insertarNodoToolStripMenuItem.Name = "insertarNodoToolStripMenuItem";
            this.insertarNodoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.insertarNodoToolStripMenuItem.Text = "Insertar Nodo";
            this.insertarNodoToolStripMenuItem.Click += new System.EventHandler(this.insertarNodoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // eliminarElementoToolStripMenuItem
            // 
            this.eliminarElementoToolStripMenuItem.Name = "eliminarElementoToolStripMenuItem";
            this.eliminarElementoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.eliminarElementoToolStripMenuItem.Text = "Eliminar Elemento";
            this.eliminarElementoToolStripMenuItem.Click += new System.EventHandler(this.eliminarElementoToolStripMenuItem_Click);
            // 
            // eliminarTodoToolStripMenuItem
            // 
            this.eliminarTodoToolStripMenuItem.Name = "eliminarTodoToolStripMenuItem";
            this.eliminarTodoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.eliminarTodoToolStripMenuItem.Text = "Eliminar Todo";
            this.eliminarTodoToolStripMenuItem.Click += new System.EventHandler(this.eliminarTodoToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cómoSeUsaToolStripMenuItem});
            this.informaciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // cómoSeUsaToolStripMenuItem
            // 
            this.cómoSeUsaToolStripMenuItem.Name = "cómoSeUsaToolStripMenuItem";
            this.cómoSeUsaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cómoSeUsaToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.cómoSeUsaToolStripMenuItem.Text = "¿Cómo se usa?";
            this.cómoSeUsaToolStripMenuItem.Click += new System.EventHandler(this.cómoSeUsaToolStripMenuItem_Click);
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView.Location = new System.Drawing.Point(53, 43);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(199, 330);
            this.treeView.TabIndex = 1;
            // 
            // tBElemento
            // 
            this.tBElemento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBElemento.Location = new System.Drawing.Point(96, 390);
            this.tBElemento.Name = "tBElemento";
            this.tBElemento.Size = new System.Drawing.Size(124, 29);
            this.tBElemento.TabIndex = 2;
            this.tBElemento.Visible = false;
            // 
            // btnAddDel
            // 
            this.btnAddDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDel.Location = new System.Drawing.Point(106, 425);
            this.btnAddDel.Name = "btnAddDel";
            this.btnAddDel.Size = new System.Drawing.Size(100, 31);
            this.btnAddDel.TabIndex = 3;
            this.btnAddDel.Text = "Agregar";
            this.btnAddDel.UseVisualStyleBackColor = true;
            this.btnAddDel.Visible = false;
            this.btnAddDel.Click += new System.EventHandler(this.btnAddDel_Click);
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNodo.Location = new System.Drawing.Point(106, 425);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(100, 31);
            this.btnAgregarNodo.TabIndex = 4;
            this.btnAgregarNodo.Text = "Agregar";
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNodo.Visible = false;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarNodo.Location = new System.Drawing.Point(106, 388);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(100, 31);
            this.btnEliminarNodo.TabIndex = 5;
            this.btnEliminarNodo.Text = "Eliminar";
            this.btnEliminarNodo.UseVisualStyleBackColor = true;
            this.btnEliminarNodo.Visible = false;
            this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 25);
            // 
            // Pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(306, 466);
            this.Controls.Add(this.btnEliminarNodo);
            this.Controls.Add(this.btnAgregarNodo);
            this.Controls.Add(this.btnAddDel);
            this.Controls.Add(this.tBElemento);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pantalla2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem informaciónToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem insertarRaízToolStripMenuItem;
        private ToolStripMenuItem insertarNodoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem eliminarElementoToolStripMenuItem;
        private ToolStripMenuItem eliminarTodoToolStripMenuItem;
        private ToolStripMenuItem cómoSeUsaToolStripMenuItem;
        private TreeView treeView;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem salirToolStripMenuItem;
        private TextBox tBElemento;
        private Button btnAddDel;
        private Button btnAgregarNodo;
        private Button btnEliminarNodo;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}