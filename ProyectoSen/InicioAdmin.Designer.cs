﻿namespace ProyectoSen
{
    partial class InicioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdmin));
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnRegistrarT = new System.Windows.Forms.Button();
            this.btnRegistrarC = new System.Windows.Forms.Button();
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTareas
            // 
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(156)))), ((int)(((byte)(253)))));
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTareas.Image = ((System.Drawing.Image)(resources.GetObject("btnTareas.Image")));
            this.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTareas.Location = new System.Drawing.Point(437, 288);
            this.btnTareas.Margin = new System.Windows.Forms.Padding(4);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(261, 210);
            this.btnTareas.TabIndex = 1;
            this.btnTareas.Text = "TAREAS";
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnRegistrarT
            // 
            this.btnRegistrarT.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrarT.FlatAppearance.BorderSize = 4;
            this.btnRegistrarT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(131)))));
            this.btnRegistrarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarT.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarT.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarT.Image")));
            this.btnRegistrarT.Location = new System.Drawing.Point(119, 57);
            this.btnRegistrarT.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarT.Name = "btnRegistrarT";
            this.btnRegistrarT.Size = new System.Drawing.Size(261, 210);
            this.btnRegistrarT.TabIndex = 2;
            this.btnRegistrarT.Text = "REGISTRAR / BORRAR TECNICO";
            this.btnRegistrarT.UseVisualStyleBackColor = false;
            this.btnRegistrarT.Click += new System.EventHandler(this.btnRegistrarT_Click);
            // 
            // btnRegistrarC
            // 
            this.btnRegistrarC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrarC.FlatAppearance.BorderSize = 0;
            this.btnRegistrarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(156)))), ((int)(((byte)(253)))));
            this.btnRegistrarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarC.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarC.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarC.Image")));
            this.btnRegistrarC.Location = new System.Drawing.Point(437, 57);
            this.btnRegistrarC.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarC.Name = "btnRegistrarC";
            this.btnRegistrarC.Size = new System.Drawing.Size(261, 210);
            this.btnRegistrarC.TabIndex = 3;
            this.btnRegistrarC.Text = "REGISTRAR CLIENTE";
            this.btnRegistrarC.UseVisualStyleBackColor = true;
            this.btnRegistrarC.Click += new System.EventHandler(this.btnRegistrarC_Click);
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.FlatAppearance.BorderSize = 0;
            this.btnRegistrarE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(156)))), ((int)(((byte)(253)))));
            this.btnRegistrarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarE.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarE.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarE.Image")));
            this.btnRegistrarE.Location = new System.Drawing.Point(119, 288);
            this.btnRegistrarE.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(261, 210);
            this.btnRegistrarE.TabIndex = 4;
            this.btnRegistrarE.Text = "REGISTRAR EQUIPO";
            this.btnRegistrarE.UseVisualStyleBackColor = true;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.btnRegistrarC);
            this.panel1.Controls.Add(this.btnTareas);
            this.panel1.Controls.Add(this.btnRegistrarT);
            this.panel1.Controls.Add(this.btnRegistrarE);
            this.panel1.Location = new System.Drawing.Point(236, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 536);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 57);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(131)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1312, 586);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InicioAdmin";
            this.Text = "InicioAdmin";
            this.Load += new System.EventHandler(this.InicioAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnRegistrarT;
        private System.Windows.Forms.Button btnRegistrarC;
        private System.Windows.Forms.Button btnRegistrarE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}