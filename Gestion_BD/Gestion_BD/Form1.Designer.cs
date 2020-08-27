namespace Gestion_BD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnexionDB = new System.Windows.Forms.Button();
            this.btnDecoDB = new System.Windows.Forms.Button();
            this.cbListDB = new System.Windows.Forms.ComboBox();
            this.btnListDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnexionDB
            // 
            this.btnConnexionDB.Location = new System.Drawing.Point(25, 38);
            this.btnConnexionDB.Name = "btnConnexionDB";
            this.btnConnexionDB.Size = new System.Drawing.Size(142, 51);
            this.btnConnexionDB.TabIndex = 0;
            this.btnConnexionDB.Text = "C O N N E C T I O N";
            this.btnConnexionDB.UseVisualStyleBackColor = true;
            this.btnConnexionDB.Click += new System.EventHandler(this.btnConnexionDB_Click);
            // 
            // btnDecoDB
            // 
            this.btnDecoDB.Location = new System.Drawing.Point(25, 95);
            this.btnDecoDB.Name = "btnDecoDB";
            this.btnDecoDB.Size = new System.Drawing.Size(142, 51);
            this.btnDecoDB.TabIndex = 1;
            this.btnDecoDB.Text = "D E C O N N E C T I O N";
            this.btnDecoDB.UseVisualStyleBackColor = true;
            this.btnDecoDB.Click += new System.EventHandler(this.btnDecoDB_Click);
            // 
            // cbListDB
            // 
            this.cbListDB.FormattingEnabled = true;
            this.cbListDB.Location = new System.Drawing.Point(222, 200);
            this.cbListDB.Name = "cbListDB";
            this.cbListDB.Size = new System.Drawing.Size(121, 21);
            this.cbListDB.TabIndex = 2;
            // 
            // btnListDB
            // 
            this.btnListDB.Location = new System.Drawing.Point(25, 184);
            this.btnListDB.Name = "btnListDB";
            this.btnListDB.Size = new System.Drawing.Size(142, 51);
            this.btnListDB.TabIndex = 3;
            this.btnListDB.Text = "L I S T E R   DB";
            this.btnListDB.UseVisualStyleBackColor = true;
            this.btnListDB.Click += new System.EventHandler(this.btnListDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListDB);
            this.Controls.Add(this.cbListDB);
            this.Controls.Add(this.btnDecoDB);
            this.Controls.Add(this.btnConnexionDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnexionDB;
        private System.Windows.Forms.Button btnDecoDB;
        private System.Windows.Forms.ComboBox cbListDB;
        private System.Windows.Forms.Button btnListDB;
    }
}

