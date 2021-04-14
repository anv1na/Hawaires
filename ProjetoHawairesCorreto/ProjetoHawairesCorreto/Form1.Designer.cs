namespace ProjetoHawairesCorreto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPromo = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.btnEnco = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "A doce intensidade tropical";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(98, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hawaires";
            // 
            // btnPromo
            // 
            this.btnPromo.Location = new System.Drawing.Point(21, 186);
            this.btnPromo.Name = "btnPromo";
            this.btnPromo.Size = new System.Drawing.Size(136, 42);
            this.btnPromo.TabIndex = 10;
            this.btnPromo.Text = "&Promoções";
            this.btnPromo.UseVisualStyleBackColor = true;
            this.btnPromo.Click += new System.EventHandler(this.btnPromo_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(192, 186);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(136, 42);
            this.btnTodos.TabIndex = 11;
            this.btnTodos.Text = "&Todos os Produtos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnContato
            // 
            this.btnContato.Location = new System.Drawing.Point(21, 296);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(136, 42);
            this.btnContato.TabIndex = 13;
            this.btnContato.Text = "&Atendimento ao Cliente";
            this.btnContato.UseVisualStyleBackColor = true;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // btnEnco
            // 
            this.btnEnco.Location = new System.Drawing.Point(192, 296);
            this.btnEnco.Name = "btnEnco";
            this.btnEnco.Size = new System.Drawing.Size(136, 42);
            this.btnEnco.TabIndex = 12;
            this.btnEnco.Text = "&Encomendar";
            this.btnEnco.UseVisualStyleBackColor = true;
            this.btnEnco.Click += new System.EventHandler(this.btnEnco_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(124, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Aloha!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.btnEnco);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnPromo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPromo;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Button btnEnco;
        private System.Windows.Forms.Label label3;
    }
}

