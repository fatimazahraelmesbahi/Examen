namespace Examen_Qcm
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
            this.evaluation = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.Label();
            this.txtbox_numero = new System.Windows.Forms.TextBox();
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.btn_ajouter_examen = new System.Windows.Forms.Button();
            this.txt_choix = new System.Windows.Forms.Label();
            this.radio_qcm = new System.Windows.Forms.RadioButton();
            this.radio_dicho = new System.Windows.Forms.RadioButton();
            this.radio_question = new System.Windows.Forms.RadioButton();
            this.btn_ajouter_question = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // evaluation
            // 
            this.evaluation.AutoSize = true;
            this.evaluation.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluation.ForeColor = System.Drawing.Color.Red;
            this.evaluation.Location = new System.Drawing.Point(325, 9);
            this.evaluation.Name = "evaluation";
            this.evaluation.Size = new System.Drawing.Size(187, 50);
            this.evaluation.TabIndex = 0;
            this.evaluation.Text = "Examen";
            // 
            // txt_titre
            // 
            this.txt_titre.AutoSize = true;
            this.txt_titre.Location = new System.Drawing.Point(40, 129);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(88, 13);
            this.txt_titre.TabIndex = 1;
            this.txt_titre.Text = "Titre de l\'Examen";
            // 
            // txt_numero
            // 
            this.txt_numero.AutoSize = true;
            this.txt_numero.Location = new System.Drawing.Point(40, 88);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(79, 13);
            this.txt_numero.TabIndex = 2;
            this.txt_numero.Text = "N° de l\'Examen";
            // 
            // txtbox_numero
            // 
            this.txtbox_numero.Location = new System.Drawing.Point(138, 85);
            this.txtbox_numero.Name = "txtbox_numero";
            this.txtbox_numero.Size = new System.Drawing.Size(374, 20);
            this.txtbox_numero.TabIndex = 3;
            // 
            // txtbox_title
            // 
            this.txtbox_title.Location = new System.Drawing.Point(138, 126);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(374, 20);
            this.txtbox_title.TabIndex = 4;
            // 
            // btn_ajouter_examen
            // 
            this.btn_ajouter_examen.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_ajouter_examen.Location = new System.Drawing.Point(392, 172);
            this.btn_ajouter_examen.Name = "btn_ajouter_examen";
            this.btn_ajouter_examen.Size = new System.Drawing.Size(120, 38);
            this.btn_ajouter_examen.TabIndex = 5;
            this.btn_ajouter_examen.Text = "Ajouter un examen";
            this.btn_ajouter_examen.UseVisualStyleBackColor = false;
            this.btn_ajouter_examen.Click += new System.EventHandler(this.btn_ajouter_examen_Click);
            // 
            // txt_choix
            // 
            this.txt_choix.AutoSize = true;
            this.txt_choix.Location = new System.Drawing.Point(38, 240);
            this.txt_choix.Name = "txt_choix";
            this.txt_choix.Size = new System.Drawing.Size(140, 13);
            this.txt_choix.TabIndex = 6;
            this.txt_choix.Text = "Choisir le type des questions";
            // 
            // radio_qcm
            // 
            this.radio_qcm.AutoSize = true;
            this.radio_qcm.Location = new System.Drawing.Point(23, 273);
            this.radio_qcm.Name = "radio_qcm";
            this.radio_qcm.Size = new System.Drawing.Size(49, 17);
            this.radio_qcm.TabIndex = 7;
            this.radio_qcm.TabStop = true;
            this.radio_qcm.Text = "QCM";
            this.radio_qcm.UseVisualStyleBackColor = true;
            this.radio_qcm.CheckedChanged += new System.EventHandler(this.radio_qcm_CheckedChanged);
            // 
            // radio_dicho
            // 
            this.radio_dicho.AutoSize = true;
            this.radio_dicho.Location = new System.Drawing.Point(23, 353);
            this.radio_dicho.Name = "radio_dicho";
            this.radio_dicho.Size = new System.Drawing.Size(133, 17);
            this.radio_dicho.TabIndex = 8;
            this.radio_dicho.TabStop = true;
            this.radio_dicho.Text = "Question dichotomique";
            this.radio_dicho.UseVisualStyleBackColor = true;
            // 
            // radio_question
            // 
            this.radio_question.AutoSize = true;
            this.radio_question.Location = new System.Drawing.Point(23, 315);
            this.radio_question.Name = "radio_question";
            this.radio_question.Size = new System.Drawing.Size(96, 17);
            this.radio_question.TabIndex = 9;
            this.radio_question.TabStop = true;
            this.radio_question.Text = "Question direct";
            this.radio_question.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter_question
            // 
            this.btn_ajouter_question.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_ajouter_question.Location = new System.Drawing.Point(392, 368);
            this.btn_ajouter_question.Name = "btn_ajouter_question";
            this.btn_ajouter_question.Size = new System.Drawing.Size(120, 38);
            this.btn_ajouter_question.TabIndex = 10;
            this.btn_ajouter_question.Text = "Ajouter des questions";
            this.btn_ajouter_question.UseVisualStyleBackColor = false;
            this.btn_ajouter_question.Click += new System.EventHandler(this.btn_ajouter_question_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.Red;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(392, 412);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(120, 43);
            this.btn_annuler.TabIndex = 12;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 467);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ajouter_question);
            this.Controls.Add(this.radio_question);
            this.Controls.Add(this.radio_dicho);
            this.Controls.Add(this.radio_qcm);
            this.Controls.Add(this.txt_choix);
            this.Controls.Add(this.btn_ajouter_examen);
            this.Controls.Add(this.txtbox_title);
            this.Controls.Add(this.txtbox_numero);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.evaluation);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label evaluation;
        private System.Windows.Forms.Label txt_titre;
        private System.Windows.Forms.Label txt_numero;
        private System.Windows.Forms.TextBox txtbox_numero;
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.Button btn_ajouter_examen;
        private System.Windows.Forms.Label txt_choix;
        private System.Windows.Forms.RadioButton radio_qcm;
        private System.Windows.Forms.RadioButton radio_dicho;
        private System.Windows.Forms.RadioButton radio_question;
        private System.Windows.Forms.Button btn_ajouter_question;
        private System.Windows.Forms.Button btn_annuler;
    }
}

