﻿namespace factura
{
    partial class FORM
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btfac = new System.Windows.Forms.Button();
            this.btpro = new System.Windows.Forms.Button();
            this.btcli = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btfac, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btpro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btcli, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btfac
            // 
            this.btfac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btfac.Location = new System.Drawing.Point(3, 178);
            this.btfac.Name = "btfac";
            this.btfac.Size = new System.Drawing.Size(392, 169);
            this.btfac.TabIndex = 2;
            this.btfac.Text = "FACTURAS";
            this.btfac.UseVisualStyleBackColor = true;
            this.btfac.Click += new System.EventHandler(this.btfac_Click);
            // 
            // btpro
            // 
            this.btpro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btpro.Location = new System.Drawing.Point(401, 3);
            this.btpro.Name = "btpro";
            this.btpro.Size = new System.Drawing.Size(392, 169);
            this.btpro.TabIndex = 1;
            this.btpro.Text = "PRODUCTO";
            this.btpro.UseVisualStyleBackColor = true;
            this.btpro.Click += new System.EventHandler(this.btpro_Click);
            // 
            // btcli
            // 
            this.btcli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btcli.Location = new System.Drawing.Point(3, 3);
            this.btcli.Name = "btcli";
            this.btcli.Size = new System.Drawing.Size(392, 169);
            this.btcli.TabIndex = 0;
            this.btcli.Text = "CLIENTE";
            this.btcli.UseVisualStyleBackColor = true;
            this.btcli.Click += new System.EventHandler(this.btcli_Click);
            // 
            // FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FORM";
            this.Text = "SISTEMA";
            this.Load += new System.EventHandler(this.FORM_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btfac;
        private System.Windows.Forms.Button btpro;
        private System.Windows.Forms.Button btcli;
    }
}

