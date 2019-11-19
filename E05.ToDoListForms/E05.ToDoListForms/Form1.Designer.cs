namespace E05.ToDoListForms
{
    partial class frmE05
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAct = new System.Windows.Forms.Label();
            this.txtNombreAc = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.txtDeta = new System.Windows.Forms.TextBox();
            this.lblTareas = new System.Windows.Forms.Label();
            this.lblDeta = new System.Windows.Forms.Label();
            this.lblSta = new System.Windows.Forms.Label();
            this.cmdCrearTarea = new System.Windows.Forms.Button();
            this.cmdTareas = new System.Windows.Forms.Button();
            this.cmdStatus = new System.Windows.Forms.Button();
            this.cmdDetalles = new System.Windows.Forms.Button();
            this.cmdLimpieza = new System.Windows.Forms.Button();
            this.cmdSalida = new System.Windows.Forms.Button();
            this.ListaTareas = new System.Windows.Forms.ListBox();
            this.ListaDetalles = new System.Windows.Forms.ListBox();
            this.ListaStatus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(2, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Ingrese Nombre";
            // 
            // lblAct
            // 
            this.lblAct.AutoSize = true;
            this.lblAct.Location = new System.Drawing.Point(216, 12);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(85, 26);
            this.lblAct.TabIndex = 2;
            this.lblAct.Text = "Ingrese Nombre \r\nde la actividad\r\n";
            // 
            // txtNombreAc
            // 
            this.txtNombreAc.Location = new System.Drawing.Point(307, 12);
            this.txtNombreAc.Name = "txtNombreAc";
            this.txtNombreAc.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAc.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(-1, 55);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(69, 26);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Ingresar hora\r\n\r\n";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(90, 55);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingresar Fecha\r\n";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(307, 55);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Ingrar Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(90, 100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(2, 160);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(97, 52);
            this.lblIngresar.TabIndex = 10;
            this.lblIngresar.Text = "Ingrese Nombre de\r\nla actividad para\r\nmostrar detalles \r\nde la tarea\r\n";
            // 
            // txtDeta
            // 
            this.txtDeta.Location = new System.Drawing.Point(105, 157);
            this.txtDeta.Name = "txtDeta";
            this.txtDeta.Size = new System.Drawing.Size(100, 20);
            this.txtDeta.TabIndex = 11;
            // 
            // lblTareas
            // 
            this.lblTareas.AutoSize = true;
            this.lblTareas.Location = new System.Drawing.Point(460, 9);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(40, 13);
            this.lblTareas.TabIndex = 13;
            this.lblTareas.Text = "Tareas";
            // 
            // lblDeta
            // 
            this.lblDeta.AutoSize = true;
            this.lblDeta.Location = new System.Drawing.Point(611, 9);
            this.lblDeta.Name = "lblDeta";
            this.lblDeta.Size = new System.Drawing.Size(48, 13);
            this.lblDeta.TabIndex = 14;
            this.lblDeta.Text = "Detalles ";
            // 
            // lblSta
            // 
            this.lblSta.AutoSize = true;
            this.lblSta.Location = new System.Drawing.Point(529, 146);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(37, 13);
            this.lblSta.TabIndex = 16;
            this.lblSta.Text = "Status";
            // 
            // cmdCrearTarea
            // 
            this.cmdCrearTarea.Location = new System.Drawing.Point(12, 288);
            this.cmdCrearTarea.Name = "cmdCrearTarea";
            this.cmdCrearTarea.Size = new System.Drawing.Size(75, 23);
            this.cmdCrearTarea.TabIndex = 18;
            this.cmdCrearTarea.Text = "Crear Tarea";
            this.cmdCrearTarea.UseVisualStyleBackColor = true;
            this.cmdCrearTarea.Click += new System.EventHandler(this.CmdCrearTarea_Click);
            // 
            // cmdTareas
            // 
            this.cmdTareas.Location = new System.Drawing.Point(160, 288);
            this.cmdTareas.Name = "cmdTareas";
            this.cmdTareas.Size = new System.Drawing.Size(75, 23);
            this.cmdTareas.TabIndex = 19;
            this.cmdTareas.Text = "Lista Tareas";
            this.cmdTareas.UseVisualStyleBackColor = true;
            this.cmdTareas.Click += new System.EventHandler(this.CmdTareas_Click);
            // 
            // cmdStatus
            // 
            this.cmdStatus.Location = new System.Drawing.Point(307, 288);
            this.cmdStatus.Name = "cmdStatus";
            this.cmdStatus.Size = new System.Drawing.Size(75, 23);
            this.cmdStatus.TabIndex = 20;
            this.cmdStatus.Text = "Lista Status";
            this.cmdStatus.UseVisualStyleBackColor = true;
            this.cmdStatus.Click += new System.EventHandler(this.CmdStatus_Click);
            // 
            // cmdDetalles
            // 
            this.cmdDetalles.Location = new System.Drawing.Point(115, 189);
            this.cmdDetalles.Name = "cmdDetalles";
            this.cmdDetalles.Size = new System.Drawing.Size(75, 23);
            this.cmdDetalles.TabIndex = 21;
            this.cmdDetalles.Text = "Detalles";
            this.cmdDetalles.UseVisualStyleBackColor = true;
            this.cmdDetalles.Click += new System.EventHandler(this.CmdDetalles_Click);
            // 
            // cmdLimpieza
            // 
            this.cmdLimpieza.Location = new System.Drawing.Point(448, 306);
            this.cmdLimpieza.Name = "cmdLimpieza";
            this.cmdLimpieza.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpieza.TabIndex = 22;
            this.cmdLimpieza.Text = "Limpieza";
            this.cmdLimpieza.UseVisualStyleBackColor = true;
            this.cmdLimpieza.Click += new System.EventHandler(this.CmdLimpiar_Click);
            // 
            // cmdSalida
            // 
            this.cmdSalida.Location = new System.Drawing.Point(538, 306);
            this.cmdSalida.Name = "cmdSalida";
            this.cmdSalida.Size = new System.Drawing.Size(75, 23);
            this.cmdSalida.TabIndex = 23;
            this.cmdSalida.Text = "Salida";
            this.cmdSalida.UseVisualStyleBackColor = true;
            this.cmdSalida.Click += new System.EventHandler(this.CmdSalida_Click);
            // 
            // ListaTareas
            // 
            this.ListaTareas.FormattingEnabled = true;
            this.ListaTareas.Location = new System.Drawing.Point(435, 30);
            this.ListaTareas.Name = "ListaTareas";
            this.ListaTareas.Size = new System.Drawing.Size(120, 95);
            this.ListaTareas.TabIndex = 24;
            // 
            // ListaDetalles
            // 
            this.ListaDetalles.FormattingEnabled = true;
            this.ListaDetalles.Location = new System.Drawing.Point(572, 30);
            this.ListaDetalles.Name = "ListaDetalles";
            this.ListaDetalles.Size = new System.Drawing.Size(126, 95);
            this.ListaDetalles.TabIndex = 25;
            // 
            // ListaStatus
            // 
            this.ListaStatus.FormattingEnabled = true;
            this.ListaStatus.Location = new System.Drawing.Point(493, 162);
            this.ListaStatus.Name = "ListaStatus";
            this.ListaStatus.Size = new System.Drawing.Size(120, 95);
            this.ListaStatus.TabIndex = 26;
            // 
            // frmE05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 341);
            this.Controls.Add(this.ListaStatus);
            this.Controls.Add(this.ListaDetalles);
            this.Controls.Add(this.ListaTareas);
            this.Controls.Add(this.cmdSalida);
            this.Controls.Add(this.cmdLimpieza);
            this.Controls.Add(this.cmdDetalles);
            this.Controls.Add(this.cmdStatus);
            this.Controls.Add(this.cmdTareas);
            this.Controls.Add(this.cmdCrearTarea);
            this.Controls.Add(this.lblSta);
            this.Controls.Add(this.lblDeta);
            this.Controls.Add(this.lblTareas);
            this.Controls.Add(this.txtDeta);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txtNombreAc);
            this.Controls.Add(this.lblAct);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmE05";
            this.Text = "E05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.TextBox txtNombreAc;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.TextBox txtDeta;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.Label lblDeta;
        private System.Windows.Forms.Label lblSta;
        private System.Windows.Forms.Button cmdCrearTarea;
        private System.Windows.Forms.Button cmdTareas;
        private System.Windows.Forms.Button cmdStatus;
        private System.Windows.Forms.Button cmdDetalles;
        private System.Windows.Forms.Button cmdLimpieza;
        private System.Windows.Forms.Button cmdSalida;
        private System.Windows.Forms.ListBox ListaTareas;
        private System.Windows.Forms.ListBox ListaDetalles;
        private System.Windows.Forms.ListBox ListaStatus;
    }
}

