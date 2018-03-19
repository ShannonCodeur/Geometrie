namespace Session_Normale
{
    partial class Figure
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
            this.gpform = new System.Windows.Forms.GroupBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.lbllarg = new System.Windows.Forms.Label();
            this.lbllong = new System.Windows.Forms.Label();
            this.txtEp = new System.Windows.Forms.TextBox();
            this.txtcoul = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblform = new System.Windows.Forms.Label();
            this.btnenreg = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.RadioCercle = new System.Windows.Forms.RadioButton();
            this.RadioRectangle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.gpform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpform
            // 
            this.gpform.Controls.Add(this.RadioRectangle);
            this.gpform.Controls.Add(this.RadioCercle);
            this.gpform.Controls.Add(this.txtVal);
            this.gpform.Controls.Add(this.lbllarg);
            this.gpform.Controls.Add(this.txtlarg);
            this.gpform.Controls.Add(this.txtEp);
            this.gpform.Controls.Add(this.txtcoul);
            this.gpform.Controls.Add(this.lbllong);
            this.gpform.Controls.Add(this.txtId);
            this.gpform.Controls.Add(this.label4);
            this.gpform.Controls.Add(this.label3);
            this.gpform.Controls.Add(this.label2);
            this.gpform.Controls.Add(this.label1);
            this.gpform.Location = new System.Drawing.Point(30, 76);
            this.gpform.Name = "gpform";
            this.gpform.Size = new System.Drawing.Size(363, 225);
            this.gpform.TabIndex = 0;
            this.gpform.TabStop = false;
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(139, 189);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(59, 26);
            this.txtVal.TabIndex = 13;
            this.txtVal.Visible = false;
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(293, 189);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(59, 26);
            this.txtlarg.TabIndex = 12;
            this.txtlarg.Visible = false;
            // 
            // lbllarg
            // 
            this.lbllarg.AutoSize = true;
            this.lbllarg.Location = new System.Drawing.Point(213, 196);
            this.lbllarg.Name = "lbllarg";
            this.lbllarg.Size = new System.Drawing.Size(56, 19);
            this.lbllarg.TabIndex = 10;
            this.lbllarg.Text = "Largeur";
            this.lbllarg.Visible = false;
            // 
            // lbllong
            // 
            this.lbllong.AutoSize = true;
            this.lbllong.Location = new System.Drawing.Point(59, 196);
            this.lbllong.Name = "lbllong";
            this.lbllong.Size = new System.Drawing.Size(66, 19);
            this.lbllong.TabIndex = 9;
            this.lbllong.Text = "Longueur";
            this.lbllong.Visible = false;
            this.lbllong.Click += new System.EventHandler(this.lbllong_Click);
            // 
            // txtEp
            // 
            this.txtEp.Location = new System.Drawing.Point(164, 112);
            this.txtEp.Name = "txtEp";
            this.txtEp.Size = new System.Drawing.Size(159, 26);
            this.txtEp.TabIndex = 6;
            // 
            // txtcoul
            // 
            this.txtcoul.Location = new System.Drawing.Point(164, 70);
            this.txtcoul.Name = "txtcoul";
            this.txtcoul.Size = new System.Drawing.Size(159, 26);
            this.txtcoul.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(164, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(159, 26);
            this.txtId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Epaisseur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Couleur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // lblform
            // 
            this.lblform.AutoSize = true;
            this.lblform.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblform.Location = new System.Drawing.Point(301, 20);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(201, 31);
            this.lblform.TabIndex = 2;
            this.lblform.Text = "Nouvelle Figure";
            // 
            // btnenreg
            // 
            this.btnenreg.Location = new System.Drawing.Point(39, 27);
            this.btnenreg.Name = "btnenreg";
            this.btnenreg.Size = new System.Drawing.Size(86, 37);
            this.btnenreg.TabIndex = 3;
            this.btnenreg.Text = "Enregistrer";
            this.btnenreg.UseVisualStyleBackColor = true;
            this.btnenreg.Click += new System.EventHandler(this.btnenreg_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(139, 27);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(92, 37);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "&Annuler";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(428, 76);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(321, 225);
            this.dg.TabIndex = 5;
            // 
            // RadioCercle
            // 
            this.RadioCercle.AutoSize = true;
            this.RadioCercle.Location = new System.Drawing.Point(164, 150);
            this.RadioCercle.Name = "RadioCercle";
            this.RadioCercle.Size = new System.Drawing.Size(67, 23);
            this.RadioCercle.TabIndex = 14;
            this.RadioCercle.TabStop = true;
            this.RadioCercle.Text = "Cercle";
            this.RadioCercle.UseVisualStyleBackColor = true;
            this.RadioCercle.CheckedChanged += new System.EventHandler(this.RadioCercle_CheckedChanged);
            // 
            // RadioRectangle
            // 
            this.RadioRectangle.AutoSize = true;
            this.RadioRectangle.Location = new System.Drawing.Point(237, 150);
            this.RadioRectangle.Name = "RadioRectangle";
            this.RadioRectangle.Size = new System.Drawing.Size(86, 23);
            this.RadioRectangle.TabIndex = 15;
            this.RadioRectangle.TabStop = true;
            this.RadioRectangle.Text = "Rectangle";
            this.RadioRectangle.UseVisualStyleBackColor = true;
            this.RadioRectangle.CheckedChanged += new System.EventHandler(this.RadioRectangle_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exit);
            this.groupBox2.Controls.Add(this.btncancel);
            this.groupBox2.Controls.Add(this.btnenreg);
            this.groupBox2.Location = new System.Drawing.Point(30, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Touches";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(264, 27);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(80, 35);
            this.exit.TabIndex = 5;
            this.exit.Text = "&Quitter";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Figure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.lblform);
            this.Controls.Add(this.gpform);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Figure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Figure_Load);
            this.gpform.ResumeLayout(false);
            this.gpform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpform;
        private System.Windows.Forms.Label lblform;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEp;
        private System.Windows.Forms.TextBox txtcoul;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.Label lbllarg;
        private System.Windows.Forms.Label lbllong;
        private System.Windows.Forms.Button btnenreg;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.RadioButton RadioCercle;
        private System.Windows.Forms.RadioButton RadioRectangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exit;
    }
}

