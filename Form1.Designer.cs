namespace Classes_importantes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btnAleatorios = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnEnvironment = new System.Windows.Forms.Button();
            this.btnAplication = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(4, 13);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(885, 310);
            this.lblResultado.TabIndex = 0;
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageBox.Location = new System.Drawing.Point(10, 347);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(204, 71);
            this.btnMessageBox.TabIndex = 1;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btnAleatorios
            // 
            this.btnAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorios.Location = new System.Drawing.Point(232, 347);
            this.btnAleatorios.Name = "btnAleatorios";
            this.btnAleatorios.Size = new System.Drawing.Size(204, 71);
            this.btnAleatorios.TabIndex = 2;
            this.btnAleatorios.Text = "Aleatorios";
            this.btnAleatorios.UseVisualStyleBackColor = true;
            this.btnAleatorios.Click += new System.EventHandler(this.btnAleatorios_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeSpan.Location = new System.Drawing.Point(459, 347);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(204, 71);
            this.btnTimeSpan.TabIndex = 3;
            this.btnTimeSpan.Text = "TimeSpan";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateTime.Location = new System.Drawing.Point(685, 347);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(204, 71);
            this.btnDateTime.TabIndex = 4;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(12, 434);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(204, 71);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnEnvironment
            // 
            this.btnEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvironment.Location = new System.Drawing.Point(232, 434);
            this.btnEnvironment.Name = "btnEnvironment";
            this.btnEnvironment.Size = new System.Drawing.Size(204, 71);
            this.btnEnvironment.TabIndex = 6;
            this.btnEnvironment.Text = "Environment";
            this.btnEnvironment.UseVisualStyleBackColor = true;
            this.btnEnvironment.Click += new System.EventHandler(this.btnEnvironment_Click);
            // 
            // btnAplication
            // 
            this.btnAplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplication.Location = new System.Drawing.Point(459, 434);
            this.btnAplication.Name = "btnAplication";
            this.btnAplication.Size = new System.Drawing.Size(204, 71);
            this.btnAplication.TabIndex = 7;
            this.btnAplication.Text = "Aplication";
            this.btnAplication.UseVisualStyleBackColor = true;
            this.btnAplication.Click += new System.EventHandler(this.btnAplication_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(685, 434);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(204, 71);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 534);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnAplication);
            this.Controls.Add(this.btnEnvironment);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btnAleatorios);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button btnAleatorios;
        private System.Windows.Forms.Button btnTimeSpan;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnEnvironment;
        private System.Windows.Forms.Button btnAplication;
        private System.Windows.Forms.Button btnFont;
    }
}

