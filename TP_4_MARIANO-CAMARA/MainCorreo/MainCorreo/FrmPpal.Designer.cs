namespace MainCorreo
{
    partial class FrmPpal
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxIngresado = new System.Windows.Forms.ListBox();
            this.listBoxEnViaje = new System.Windows.Forms.ListBox();
            this.listBoxEntregado = new System.Windows.Forms.ListBox();
            this.BoxTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtBoxMostrar = new System.Windows.Forms.RichTextBox();
            this.BoxDireccion = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuMostrar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxEntregado);
            this.groupBox1.Controls.Add(this.listBoxEnViaje);
            this.groupBox1.Controls.Add(this.listBoxIngresado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Paquetes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnMostrar);
            this.groupBox2.Controls.Add(this.BoxDireccion);
            this.groupBox2.Controls.Add(this.BtnAgregar);
            this.groupBox2.Controls.Add(this.BoxTrackingID);
            this.groupBox2.Location = new System.Drawing.Point(294, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "En Viaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entregado";
            // 
            // listBoxIngresado
            // 
            this.listBoxIngresado.FormattingEnabled = true;
            this.listBoxIngresado.Location = new System.Drawing.Point(13, 43);
            this.listBoxIngresado.Name = "listBoxIngresado";
            this.listBoxIngresado.Size = new System.Drawing.Size(157, 251);
            this.listBoxIngresado.TabIndex = 3;
            // 
            // listBoxEnViaje
            // 
            this.listBoxEnViaje.FormattingEnabled = true;
            this.listBoxEnViaje.Location = new System.Drawing.Point(184, 43);
            this.listBoxEnViaje.Name = "listBoxEnViaje";
            this.listBoxEnViaje.Size = new System.Drawing.Size(154, 251);
            this.listBoxEnViaje.TabIndex = 4;
            // 
            // listBoxEntregado
            // 
            this.listBoxEntregado.ContextMenuStrip = this.contextMenuMostrar;
            this.listBoxEntregado.FormattingEnabled = true;
            this.listBoxEntregado.Location = new System.Drawing.Point(355, 43);
            this.listBoxEntregado.Name = "listBoxEntregado";
            this.listBoxEntregado.Size = new System.Drawing.Size(157, 251);
            this.listBoxEntregado.TabIndex = 5;
            // 
            // BoxTrackingID
            // 
            this.BoxTrackingID.Location = new System.Drawing.Point(21, 39);
            this.BoxTrackingID.Mask = "000-000-0000";
            this.BoxTrackingID.Name = "BoxTrackingID";
            this.BoxTrackingID.Size = new System.Drawing.Size(100, 20);
            this.BoxTrackingID.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(135, 34);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(91, 29);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtBoxMostrar
            // 
            this.TxtBoxMostrar.Location = new System.Drawing.Point(12, 333);
            this.TxtBoxMostrar.Name = "TxtBoxMostrar";
            this.TxtBoxMostrar.Size = new System.Drawing.Size(276, 133);
            this.TxtBoxMostrar.TabIndex = 2;
            this.TxtBoxMostrar.Text = "";
            // 
            // BoxDireccion
            // 
            this.BoxDireccion.Location = new System.Drawing.Point(21, 90);
            this.BoxDireccion.Name = "BoxDireccion";
            this.BoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.BoxDireccion.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(135, 85);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(91, 29);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tracking ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion";
            // 
            // contextMenuMostrar
            // 
            this.contextMenuMostrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.contextMenuMostrar.Name = "contextMenuMostrar";
            this.contextMenuMostrar.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 477);
            this.Controls.Add(this.TxtBoxMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Mariano.Camara.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuMostrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxEntregado;
        private System.Windows.Forms.ListBox listBoxEnViaje;
        private System.Windows.Forms.ListBox listBoxIngresado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.MaskedTextBox BoxTrackingID;
        private System.Windows.Forms.RichTextBox TxtBoxMostrar;
        private System.Windows.Forms.TextBox BoxDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuMostrar;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

