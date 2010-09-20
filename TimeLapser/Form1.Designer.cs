namespace TimeLapser
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
            this.components = new System.ComponentModel.Container();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.controlImagen = new Emgu.CV.UI.ImageBox();
            this.spnMilisegundos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textoPath = new System.Windows.Forms.TextBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.cmbResolucion = new System.Windows.Forms.ComboBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.barraProgresoGeneracion = new System.Windows.Forms.ProgressBar();
            this.btnAbout = new System.Windows.Forms.Button();
            this.idCamara = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMilisegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // temporizador
            // 
            this.temporizador.Interval = 3000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // controlImagen
            // 
            this.controlImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlImagen.Location = new System.Drawing.Point(0, 0);
            this.controlImagen.Name = "controlImagen";
            this.controlImagen.Size = new System.Drawing.Size(842, 458);
            this.controlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.controlImagen.TabIndex = 2;
            this.controlImagen.TabStop = false;
            // 
            // spnMilisegundos
            // 
            this.spnMilisegundos.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnMilisegundos.Location = new System.Drawing.Point(108, 523);
            this.spnMilisegundos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spnMilisegundos.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnMilisegundos.Name = "spnMilisegundos";
            this.spnMilisegundos.Size = new System.Drawing.Size(120, 20);
            this.spnMilisegundos.TabIndex = 3;
            this.spnMilisegundos.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Take pic every (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Store pics in";
            // 
            // textoPath
            // 
            this.textoPath.Location = new System.Drawing.Point(73, 552);
            this.textoPath.Name = "textoPath";
            this.textoPath.ReadOnly = true;
            this.textoPath.Size = new System.Drawing.Size(155, 20);
            this.textoPath.TabIndex = 6;
            this.textoPath.Text = "c:\\";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(234, 546);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(87, 30);
            this.btnChooseFolder.TabIndex = 7;
            this.btnChooseFolder.Text = "Choose folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // cmbResolucion
            // 
            this.cmbResolucion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResolucion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbResolucion.FormattingEnabled = true;
            this.cmbResolucion.Items.AddRange(new object[] {
            "640x480",
            "800x600"});
            this.cmbResolucion.Location = new System.Drawing.Point(73, 588);
            this.cmbResolucion.Name = "cmbResolucion";
            this.cmbResolucion.Size = new System.Drawing.Size(121, 21);
            this.cmbResolucion.TabIndex = 8;
            this.cmbResolucion.SelectedIndexChanged += new System.EventHandler(this.cmbResolucion_SelectedIndexChanged);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(234, 614);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(110, 23);
            this.btnEmpezar.TabIndex = 9;
            this.btnEmpezar.Text = "Begin capture";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(390, 614);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(117, 23);
            this.btnParar.TabIndex = 10;
            this.btnParar.Text = "Stop capture";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // barraProgresoGeneracion
            // 
            this.barraProgresoGeneracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraProgresoGeneracion.Location = new System.Drawing.Point(0, 703);
            this.barraProgresoGeneracion.Name = "barraProgresoGeneracion";
            this.barraProgresoGeneracion.Size = new System.Drawing.Size(842, 23);
            this.barraProgresoGeneracion.TabIndex = 12;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(695, 482);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(119, 99);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // idCamara
            // 
            this.idCamara.Location = new System.Drawing.Point(108, 482);
            this.idCamara.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.idCamara.Name = "idCamara";
            this.idCamara.Size = new System.Drawing.Size(120, 20);
            this.idCamara.TabIndex = 13;
            this.idCamara.ValueChanged += new System.EventHandler(this.idCamara_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Camera ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idCamara);
            this.Controls.Add(this.barraProgresoGeneracion);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.cmbResolucion);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.textoPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spnMilisegundos);
            this.Controls.Add(this.controlImagen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeLapser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMilisegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer temporizador;
        private Emgu.CV.UI.ImageBox controlImagen;
        private System.Windows.Forms.NumericUpDown spnMilisegundos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog selectorCarpeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoPath;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.ComboBox cmbResolucion;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.ProgressBar barraProgresoGeneracion;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.NumericUpDown idCamara;
        private System.Windows.Forms.Label label3;
    }
}

