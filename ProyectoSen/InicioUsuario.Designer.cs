namespace ProyectoSen
{
    partial class InicioUsuario
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
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnRegistrarC = new System.Windows.Forms.Button();
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTareas
            // 
            this.btnTareas.Location = new System.Drawing.Point(213, 279);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(175, 54);
            this.btnTareas.TabIndex = 2;
            this.btnTareas.Text = "TAREAS";
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnRegistrarC
            // 
            this.btnRegistrarC.Location = new System.Drawing.Point(213, 106);
            this.btnRegistrarC.Name = "btnRegistrarC";
            this.btnRegistrarC.Size = new System.Drawing.Size(175, 54);
            this.btnRegistrarC.TabIndex = 4;
            this.btnRegistrarC.Text = "REGISTRAR CLIENTE";
            this.btnRegistrarC.UseVisualStyleBackColor = true;
            this.btnRegistrarC.Click += new System.EventHandler(this.btnRegistrarC_Click);
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.Location = new System.Drawing.Point(213, 181);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(175, 54);
            this.btnRegistrarE.TabIndex = 5;
            this.btnRegistrarE.Text = "REGISTRAR EQUIPO";
            this.btnRegistrarE.UseVisualStyleBackColor = true;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 44);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnRegistrarE);
            this.panel2.Controls.Add(this.btnTareas);
            this.panel2.Controls.Add(this.btnRegistrarC);
            this.panel2.Location = new System.Drawing.Point(246, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 428);
            this.panel2.TabIndex = 7;
            // 
            // InicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1028, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InicioUsuario";
            this.Text = "InicioUsuario";
            this.Load += new System.EventHandler(this.InicioUsuario_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnRegistrarC;
        private System.Windows.Forms.Button btnRegistrarE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}