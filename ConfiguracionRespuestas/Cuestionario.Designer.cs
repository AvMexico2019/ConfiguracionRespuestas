﻿namespace ConfiguracionRespuestas
{
    partial class Cuestionario
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
            this.comboBoxTema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPreguntas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdInstitucion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIdConcepto = new System.Windows.Forms.ComboBox();
            this.comboBoxIdRespuesta = new System.Windows.Forms.ComboBox();
            this.textBoxNumOrden = new System.Windows.Forms.TextBox();
            this.textBoxValorRespuesta = new System.Windows.Forms.TextBox();
            this.textBoxValorMinimo = new System.Windows.Forms.TextBox();
            this.textBoxValorMaximo = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.comboBoxEstatusRegistro = new System.Windows.Forms.ComboBox();
            this.comboBoxIdUsuarioRegistro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTEMA = new System.Windows.Forms.Label();
            this.buttonInsertRelacion = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonInicializaRelaciones = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.comboBoxEsDeterminante = new System.Windows.Forms.ComboBox();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTema
            // 
            this.comboBoxTema.FormattingEnabled = true;
            this.comboBoxTema.Location = new System.Drawing.Point(12, 25);
            this.comboBoxTema.Name = "comboBoxTema";
            this.comboBoxTema.Size = new System.Drawing.Size(241, 21);
            this.comboBoxTema.TabIndex = 0;
            this.comboBoxTema.SelectedIndexChanged += new System.EventHandler(this.comboBoxTema_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tema";
            // 
            // listBoxPreguntas
            // 
            this.listBoxPreguntas.FormattingEnabled = true;
            this.listBoxPreguntas.Location = new System.Drawing.Point(13, 52);
            this.listBoxPreguntas.Name = "listBoxPreguntas";
            this.listBoxPreguntas.Size = new System.Drawing.Size(428, 680);
            this.listBoxPreguntas.TabIndex = 2;
            this.listBoxPreguntas.SelectedIndexChanged += new System.EventHandler(this.listBoxPreguntas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IdInstitucion";
            // 
            // textBoxIdInstitucion
            // 
            this.textBoxIdInstitucion.Location = new System.Drawing.Point(574, 52);
            this.textBoxIdInstitucion.Name = "textBoxIdInstitucion";
            this.textBoxIdInstitucion.Size = new System.Drawing.Size(374, 20);
            this.textBoxIdInstitucion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IdTema";
            // 
            // comboBoxIdConcepto
            // 
            this.comboBoxIdConcepto.FormattingEnabled = true;
            this.comboBoxIdConcepto.Location = new System.Drawing.Point(574, 107);
            this.comboBoxIdConcepto.Name = "comboBoxIdConcepto";
            this.comboBoxIdConcepto.Size = new System.Drawing.Size(374, 21);
            this.comboBoxIdConcepto.TabIndex = 7;
            // 
            // comboBoxIdRespuesta
            // 
            this.comboBoxIdRespuesta.FormattingEnabled = true;
            this.comboBoxIdRespuesta.Location = new System.Drawing.Point(574, 134);
            this.comboBoxIdRespuesta.Name = "comboBoxIdRespuesta";
            this.comboBoxIdRespuesta.Size = new System.Drawing.Size(374, 21);
            this.comboBoxIdRespuesta.TabIndex = 8;
            // 
            // textBoxNumOrden
            // 
            this.textBoxNumOrden.Location = new System.Drawing.Point(574, 162);
            this.textBoxNumOrden.Name = "textBoxNumOrden";
            this.textBoxNumOrden.Size = new System.Drawing.Size(374, 20);
            this.textBoxNumOrden.TabIndex = 9;
            // 
            // textBoxValorRespuesta
            // 
            this.textBoxValorRespuesta.Location = new System.Drawing.Point(574, 216);
            this.textBoxValorRespuesta.Name = "textBoxValorRespuesta";
            this.textBoxValorRespuesta.Size = new System.Drawing.Size(374, 20);
            this.textBoxValorRespuesta.TabIndex = 11;
            // 
            // textBoxValorMinimo
            // 
            this.textBoxValorMinimo.Location = new System.Drawing.Point(574, 243);
            this.textBoxValorMinimo.Name = "textBoxValorMinimo";
            this.textBoxValorMinimo.Size = new System.Drawing.Size(374, 20);
            this.textBoxValorMinimo.TabIndex = 12;
            // 
            // textBoxValorMaximo
            // 
            this.textBoxValorMaximo.Location = new System.Drawing.Point(574, 270);
            this.textBoxValorMaximo.Name = "textBoxValorMaximo";
            this.textBoxValorMaximo.Size = new System.Drawing.Size(374, 20);
            this.textBoxValorMaximo.TabIndex = 13;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(574, 297);
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(374, 20);
            this.textBoxComentario.TabIndex = 14;
            // 
            // comboBoxEstatusRegistro
            // 
            this.comboBoxEstatusRegistro.FormattingEnabled = true;
            this.comboBoxEstatusRegistro.Location = new System.Drawing.Point(574, 324);
            this.comboBoxEstatusRegistro.Name = "comboBoxEstatusRegistro";
            this.comboBoxEstatusRegistro.Size = new System.Drawing.Size(374, 21);
            this.comboBoxEstatusRegistro.TabIndex = 15;
            // 
            // comboBoxIdUsuarioRegistro
            // 
            this.comboBoxIdUsuarioRegistro.FormattingEnabled = true;
            this.comboBoxIdUsuarioRegistro.Location = new System.Drawing.Point(574, 352);
            this.comboBoxIdUsuarioRegistro.Name = "comboBoxIdUsuarioRegistro";
            this.comboBoxIdUsuarioRegistro.Size = new System.Drawing.Size(374, 21);
            this.comboBoxIdUsuarioRegistro.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "IdConcepto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "IdRespuesta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "NumOrden";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "EsDeterminante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "ValorRespuesta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "ValorMinimo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "ValorMaximo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Comentario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(450, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "EstatusRegistro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(451, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "IdUsuarioRegistro";
            // 
            // labelTEMA
            // 
            this.labelTEMA.AutoSize = true;
            this.labelTEMA.Location = new System.Drawing.Point(574, 79);
            this.labelTEMA.Name = "labelTEMA";
            this.labelTEMA.Size = new System.Drawing.Size(43, 13);
            this.labelTEMA.TabIndex = 28;
            this.labelTEMA.Text = "IdTema";
            // 
            // buttonInsertRelacion
            // 
            this.buttonInsertRelacion.Location = new System.Drawing.Point(451, 431);
            this.buttonInsertRelacion.Name = "buttonInsertRelacion";
            this.buttonInsertRelacion.Size = new System.Drawing.Size(166, 23);
            this.buttonInsertRelacion.TabIndex = 29;
            this.buttonInsertRelacion.Text = "Inserta Relacion";
            this.buttonInsertRelacion.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(451, 474);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(166, 23);
            this.buttonDeleteSelected.TabIndex = 30;
            this.buttonDeleteSelected.Text = "Borrar Relacion Seleccionada";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // buttonInicializaRelaciones
            // 
            this.buttonInicializaRelaciones.Location = new System.Drawing.Point(453, 567);
            this.buttonInicializaRelaciones.Name = "buttonInicializaRelaciones";
            this.buttonInicializaRelaciones.Size = new System.Drawing.Size(164, 23);
            this.buttonInicializaRelaciones.TabIndex = 31;
            this.buttonInicializaRelaciones.Text = "Inicializa Relaciones";
            this.buttonInicializaRelaciones.UseVisualStyleBackColor = true;
            this.buttonInicializaRelaciones.Click += new System.EventHandler(this.buttonInicializaRelaciones_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(448, 25);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(32, 13);
            this.labelInfo.TabIndex = 32;
            this.labelInfo.Text = "INFO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Modifica relación";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Hay que correr manualmete el SQL que inicializa el SandBox";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(342, 0);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(8, 20);
            this.domainUpDown1.TabIndex = 35;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // comboBoxEsDeterminante
            // 
            this.comboBoxEsDeterminante.FormattingEnabled = true;
            this.comboBoxEsDeterminante.Location = new System.Drawing.Point(574, 189);
            this.comboBoxEsDeterminante.Name = "comboBoxEsDeterminante";
            this.comboBoxEsDeterminante.Size = new System.Drawing.Size(374, 21);
            this.comboBoxEsDeterminante.TabIndex = 36;
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.Location = new System.Drawing.Point(574, 380);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(79, 13);
            this.labelFechaRegistro.TabIndex = 37;
            this.labelFechaRegistro.Text = "Fecha Registro";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(448, 379);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Fecha Registro";
            // 
            // Cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 739);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelFechaRegistro);
            this.Controls.Add(this.comboBoxEsDeterminante);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonInicializaRelaciones);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.buttonInsertRelacion);
            this.Controls.Add(this.labelTEMA);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxIdUsuarioRegistro);
            this.Controls.Add(this.comboBoxEstatusRegistro);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxValorMaximo);
            this.Controls.Add(this.textBoxValorMinimo);
            this.Controls.Add(this.textBoxValorRespuesta);
            this.Controls.Add(this.textBoxNumOrden);
            this.Controls.Add(this.comboBoxIdRespuesta);
            this.Controls.Add(this.comboBoxIdConcepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIdInstitucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPreguntas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTema);
            this.Name = "Cuestionario";
            this.Text = "Inserción y visualizacion de preguntas sistema contratos de arrendamiento";
            this.Load += new System.EventHandler(this.Cuestionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPreguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdInstitucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIdConcepto;
        private System.Windows.Forms.ComboBox comboBoxIdRespuesta;
        private System.Windows.Forms.TextBox textBoxNumOrden;
        private System.Windows.Forms.TextBox textBoxValorRespuesta;
        private System.Windows.Forms.TextBox textBoxValorMinimo;
        private System.Windows.Forms.TextBox textBoxValorMaximo;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.ComboBox comboBoxEstatusRegistro;
        private System.Windows.Forms.ComboBox comboBoxIdUsuarioRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTEMA;
        private System.Windows.Forms.Button buttonInsertRelacion;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonInicializaRelaciones;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.ComboBox comboBoxEsDeterminante;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.Label label16;
    }
}

