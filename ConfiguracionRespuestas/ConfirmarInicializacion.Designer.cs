namespace ConfiguracionRespuestas
{
    partial class ConfirmarInicializacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSi = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirma que quiere iicializar el SandBox";
            // 
            // buttonSi
            // 
            this.buttonSi.Location = new System.Drawing.Point(13, 26);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(75, 23);
            this.buttonSi.TabIndex = 1;
            this.buttonSi.Text = "SI";
            this.buttonSi.UseVisualStyleBackColor = true;
            this.buttonSi.Click += new System.EventHandler(this.buttonSi_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(121, 26);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // ConfirmarInicializacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 53);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonSi);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmarInicializacion";
            this.Text = "Confirmar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Button buttonNo;
    }
}