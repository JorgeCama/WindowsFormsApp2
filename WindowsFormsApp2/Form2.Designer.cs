namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.saludo = new System.Windows.Forms.Label();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DAT1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.ComboBox();
            this.C3 = new System.Windows.Forms.ComboBox();
            this.L1 = new System.Windows.Forms.TextBox();
            this.mydbDataSet = new WindowsFormsApp2.mydbDataSet();
            this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPRESATableAdapter = new WindowsFormsApp2.mydbDataSetTableAdapters.EMPRESATableAdapter();
            this.mydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOSTableAdapter = new WindowsFormsApp2.mydbDataSetTableAdapters.EMPLEADOSTableAdapter();
            this.eMPLEADOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.Location = new System.Drawing.Point(64, 49);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(112, 25);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Hola hola";
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(694, 384);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(84, 39);
            this.boton2.TabIndex = 1;
            this.boton2.Text = "volver";
            this.boton2.UseVisualStyleBackColor = true;
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton1.Location = new System.Drawing.Point(342, 347);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(101, 31);
            this.boton1.TabIndex = 2;
            this.boton1.Text = "confirmar";
            this.boton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DATOS PERSONALES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DETALLES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.C2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DAT1);
            this.panel1.Location = new System.Drawing.Point(69, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 158);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.L1);
            this.panel2.Controls.Add(this.C3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(466, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 158);
            this.panel2.TabIndex = 6;
            // 
            // DAT1
            // 
            this.DAT1.AutoSize = true;
            this.DAT1.Location = new System.Drawing.Point(25, 29);
            this.DAT1.Name = "DAT1";
            this.DAT1.Size = new System.Drawing.Size(35, 13);
            this.DAT1.TabIndex = 0;
            this.DAT1.Text = "DAT1";
            this.DAT1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DAT2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "DAT3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "DAT4";
            // 
            // C2
            // 
            this.C2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPLEADOSBindingSource, "NOMBRE_EMPLEADOS", true));
            this.C2.DataSource = this.eMPLEADOSBindingSource;
            this.C2.DisplayMember = "NOMBRE_EMPLEADOS";
            this.C2.FormattingEnabled = true;
            this.C2.Location = new System.Drawing.Point(86, 59);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(121, 21);
            this.C2.TabIndex = 3;
            this.C2.ValueMember = "NOMBRE_EMPLEADOS";
            this.C2.SelectedIndexChanged += new System.EventHandler(this.C2_SelectedIndexChanged);
            // 
            // C3
            // 
            this.C3.FormattingEnabled = true;
            this.C3.Location = new System.Drawing.Point(101, 68);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(121, 21);
            this.C3.TabIndex = 2;
            // 
            // L1
            // 
            this.L1.Location = new System.Drawing.Point(101, 29);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(100, 20);
            this.L1.TabIndex = 3;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPRESABindingSource
            // 
            this.eMPRESABindingSource.DataMember = "EMPRESA";
            this.eMPRESABindingSource.DataSource = this.mydbDataSet;
            // 
            // eMPRESATableAdapter
            // 
            this.eMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // mydbDataSetBindingSource
            // 
            this.mydbDataSetBindingSource.DataSource = this.mydbDataSet;
            this.mydbDataSetBindingSource.Position = 0;
            // 
            // eMPLEADOSBindingSource
            // 
            this.eMPLEADOSBindingSource.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource.DataSource = this.mydbDataSetBindingSource;
            // 
            // eMPLEADOSTableAdapter
            // 
            this.eMPLEADOSTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLEADOSBindingSource1
            // 
            this.eMPLEADOSBindingSource1.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource1.DataSource = this.mydbDataSetBindingSource;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.saludo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox C2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DAT1;
        private System.Windows.Forms.TextBox L1;
        private System.Windows.Forms.ComboBox C3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource eMPRESABindingSource;
        private mydbDataSetTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
        private System.Windows.Forms.BindingSource mydbDataSetBindingSource;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource;
        private mydbDataSetTableAdapters.EMPLEADOSTableAdapter eMPLEADOSTableAdapter;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource1;
    }
}