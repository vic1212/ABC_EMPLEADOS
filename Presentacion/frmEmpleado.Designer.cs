
namespace ABC_EMPLEADOS.Presentacion
{
    partial class frmEmpleado
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnPuestos = new System.Windows.Forms.Button();
            this.panelVisor = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(43, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 33);
            this.label12.TabIndex = 32;
            this.label12.Text = "ABC EMPLEADOS";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.label12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1604, 77);
            this.panel7.TabIndex = 33;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Controls.Add(this.btnEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnPuestos);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 569);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.White;
            this.btnEmpleados.Font = new System.Drawing.Font("Roboto", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEmpleados.Location = new System.Drawing.Point(3, 3);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(143, 74);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnPuestos
            // 
            this.btnPuestos.BackColor = System.Drawing.Color.White;
            this.btnPuestos.Font = new System.Drawing.Font("Roboto", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPuestos.Location = new System.Drawing.Point(3, 83);
            this.btnPuestos.Name = "btnPuestos";
            this.btnPuestos.Size = new System.Drawing.Size(143, 74);
            this.btnPuestos.TabIndex = 1;
            this.btnPuestos.Text = "Puestos";
            this.btnPuestos.UseVisualStyleBackColor = false;
            this.btnPuestos.Click += new System.EventHandler(this.btnPuestos_Click);
            // 
            // panelVisor
            // 
            this.panelVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisor.Location = new System.Drawing.Point(146, 77);
            this.panelVisor.Name = "panelVisor";
            this.panelVisor.Size = new System.Drawing.Size(1458, 569);
            this.panelVisor.TabIndex = 36;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 646);
            this.Controls.Add(this.panelVisor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnPuestos;
        private System.Windows.Forms.Panel panelVisor;
    }
}