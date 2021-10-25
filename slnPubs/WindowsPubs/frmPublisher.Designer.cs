
namespace WindowsPubs
{
    partial class frmPublisher
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
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnFiltrar2 = new System.Windows.Forms.Button();
            this.txtFiltrar2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarCiudad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFiltrar3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPublisher.Location = new System.Drawing.Point(0, 94);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.Size = new System.Drawing.Size(800, 356);
            this.gridPublisher.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(666, 15);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 44);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnFiltrar2
            // 
            this.btnFiltrar2.Location = new System.Drawing.Point(510, 15);
            this.btnFiltrar2.Name = "btnFiltrar2";
            this.btnFiltrar2.Size = new System.Drawing.Size(112, 43);
            this.btnFiltrar2.TabIndex = 11;
            this.btnFiltrar2.Text = "Filtrar por ciudad y estado";
            this.btnFiltrar2.UseVisualStyleBackColor = true;
            this.btnFiltrar2.Click += new System.EventHandler(this.btnFiltrar2_Click);
            // 
            // txtFiltrar2
            // 
            this.txtFiltrar2.Location = new System.Drawing.Point(353, 31);
            this.txtFiltrar2.Name = "txtFiltrar2";
            this.txtFiltrar2.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrar2.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(16, 28);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // btnFiltrarCiudad
            // 
            this.btnFiltrarCiudad.Location = new System.Drawing.Point(140, 15);
            this.btnFiltrarCiudad.Name = "btnFiltrarCiudad";
            this.btnFiltrarCiudad.Size = new System.Drawing.Size(132, 44);
            this.btnFiltrarCiudad.TabIndex = 7;
            this.btnFiltrarCiudad.Text = "Filtrar por ciudad";
            this.btnFiltrarCiudad.UseVisualStyleBackColor = true;
            this.btnFiltrarCiudad.Click += new System.EventHandler(this.btnFiltrarCiudad_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btnFiltrar3
            // 
            this.btnFiltrar3.Location = new System.Drawing.Point(421, 65);
            this.btnFiltrar3.Name = "btnFiltrar3";
            this.btnFiltrar3.Size = new System.Drawing.Size(140, 23);
            this.btnFiltrar3.TabIndex = 14;
            this.btnFiltrar3.Text = "Mostrar filtros x 3";
            this.btnFiltrar3.UseVisualStyleBackColor = true;
            this.btnFiltrar3.Click += new System.EventHandler(this.btnFiltrar3_Click);
            // 
            // frmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrar3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnFiltrar2);
            this.Controls.Add(this.txtFiltrar2);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrarCiudad);
            this.Controls.Add(this.gridPublisher);
            this.Name = "frmPublisher";
            this.Text = "frmPublisher";
            this.Load += new System.EventHandler(this.frmPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnFiltrar2;
        private System.Windows.Forms.TextBox txtFiltrar2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrarCiudad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFiltrar3;
    }
}