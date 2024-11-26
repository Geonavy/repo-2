namespace InterfazXML
{
    partial class Administrador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GridViewArchivo = new DataGridView();
            btnCargar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)GridViewArchivo).BeginInit();
            SuspendLayout();
            // 
            // GridViewArchivo
            // 
            GridViewArchivo.BackgroundColor = Color.FromArgb(192, 255, 255);
            GridViewArchivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewArchivo.Dock = DockStyle.Top;
            GridViewArchivo.Location = new Point(0, 0);
            GridViewArchivo.Name = "GridViewArchivo";
            GridViewArchivo.Size = new Size(800, 150);
            GridViewArchivo.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = SystemColors.Highlight;
            btnCargar.Cursor = Cursors.Hand;
            btnCargar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCargar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 130, 255);
            btnCargar.ForeColor = SystemColors.Control;
            btnCargar.Location = new Point(657, 191);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(106, 45);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 130, 255);
            btnActualizar.ForeColor = SystemColors.Control;
            btnActualizar.Location = new Point(545, 191);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 45);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnCargar);
            Controls.Add(GridViewArchivo);
            Name = "Administrador";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridViewArchivo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridViewArchivo;
        private Button btnCargar;
        private Button btnActualizar;
    }
}
