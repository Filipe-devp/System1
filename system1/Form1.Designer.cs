﻿namespace system1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPainel = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(18)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 15);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btnLinks);
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Controls.Add(this.btnTarefas);
            this.panel2.Controls.Add(this.btnPainel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 666);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPainel
            // 
            this.btnPainel.FlatAppearance.BorderSize = 0;
            this.btnPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.Image = ((System.Drawing.Image)(resources.GetObject("btnPainel.Image")));
            this.btnPainel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainel.Location = new System.Drawing.Point(36, 93);
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.Size = new System.Drawing.Size(205, 60);
            this.btnPainel.TabIndex = 3;
            this.btnPainel.Text = "Painel\r\n";
            this.btnPainel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPainel.UseVisualStyleBackColor = true;
            // 
            // btnTarefas
            // 
            this.btnTarefas.FlatAppearance.BorderSize = 0;
            this.btnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarefas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefas.ForeColor = System.Drawing.Color.White;
            this.btnTarefas.Image = ((System.Drawing.Image)(resources.GetObject("btnTarefas.Image")));
            this.btnTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarefas.Location = new System.Drawing.Point(36, 240);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(205, 60);
            this.btnTarefas.TabIndex = 4;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(36, 534);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(205, 60);
            this.btnSobre.TabIndex = 5;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSobre.UseVisualStyleBackColor = true;
            // 
            // btnLinks
            // 
            this.btnLinks.FlatAppearance.BorderSize = 0;
            this.btnLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinks.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinks.ForeColor = System.Drawing.Color.White;
            this.btnLinks.Image = ((System.Drawing.Image)(resources.GetObject("btnLinks.Image")));
            this.btnLinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinks.Location = new System.Drawing.Point(36, 387);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(205, 60);
            this.btnLinks.TabIndex = 6;
            this.btnLinks.Text = "Link";
            this.btnLinks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLinks.UseVisualStyleBackColor = true;
            // 
            // btnfechar
            // 
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(1189, 15);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 3;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(280, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 478);
            this.panel3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnPainel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Panel panel3;
    }
}

