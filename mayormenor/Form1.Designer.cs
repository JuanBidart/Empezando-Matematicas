namespace mayormenor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtEleccion = new System.Windows.Forms.TextBox();
            this.btMenor = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblOk = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(26, 122);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(96, 69);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "00";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(238, 122);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(96, 69);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "00";
            // 
            // txtEleccion
            // 
            this.txtEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEleccion.Location = new System.Drawing.Point(128, 128);
            this.txtEleccion.Name = "txtEleccion";
            this.txtEleccion.Size = new System.Drawing.Size(100, 56);
            this.txtEleccion.TabIndex = 2;
            this.txtEleccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btMenor
            // 
            this.btMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenor.Location = new System.Drawing.Point(38, 47);
            this.btMenor.Name = "btMenor";
            this.btMenor.Size = new System.Drawing.Size(75, 51);
            this.btMenor.TabIndex = 3;
            this.btMenor.Text = "<";
            this.btMenor.UseVisualStyleBackColor = true;
            this.btMenor.Click += new System.EventHandler(this.btMenor_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(138, 47);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 51);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayor.Location = new System.Drawing.Point(250, 47);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(75, 51);
            this.btnMayor.TabIndex = 5;
            this.btnMayor.Text = ">";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(38, 205);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(287, 219);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 6;
            this.pbxImagen.TabStop = false;
            this.pbxImagen.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbxImagen_LoadCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblOk
            // 
            this.lblOk.AutoSize = true;
            this.lblOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOk.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblOk.Location = new System.Drawing.Point(41, 448);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(50, 54);
            this.lblOk.TabIndex = 7;
            this.lblOk.Text = "0";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.Crimson;
            this.lblNo.Location = new System.Drawing.Point(275, 448);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(50, 54);
            this.lblNo.TabIndex = 8;
            this.lblNo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 521);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btMenor);
            this.Controls.Add(this.txtEleccion);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtEleccion;
        private System.Windows.Forms.Button btMenor;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Label lblNo;
    }
}

