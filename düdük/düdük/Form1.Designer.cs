namespace düdük
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baslat = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.progressBarHiz = new System.Windows.Forms.ProgressBar();
            this.progressBarKilometre = new System.Windows.Forms.ProgressBar();
            this.progressBarPil = new System.Windows.Forms.ProgressBar();
            this.progressBarPilSicakligi = new System.Windows.Forms.ProgressBar();
            this.labelHiz = new System.Windows.Forms.Label();
            this.labelKilometre = new System.Windows.Forms.Label();
            this.labelPil = new System.Windows.Forms.Label();
            this.labelPilSicakligi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baslat
            // 
            resources.ApplyResources(this.baslat, "baslat");
            this.baslat.BackColor = System.Drawing.Color.LightGreen;
            this.baslat.Name = "baslat";
            this.baslat.UseVisualStyleBackColor = false;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // durdur
            // 
            resources.ApplyResources(this.durdur, "durdur");
            this.durdur.BackColor = System.Drawing.Color.Salmon;
            this.durdur.Name = "durdur";
            this.durdur.UseVisualStyleBackColor = false;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // sifirla
            // 
            resources.ApplyResources(this.sifirla, "sifirla");
            this.sifirla.BackColor = System.Drawing.Color.LightCoral;
            this.sifirla.Name = "sifirla";
            this.sifirla.UseVisualStyleBackColor = false;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Name = "comboBox1";
            // 
            // kaydet
            // 
            resources.ApplyResources(this.kaydet, "kaydet");
            this.kaydet.BackColor = System.Drawing.Color.LightBlue;
            this.kaydet.Name = "kaydet";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // progressBarHiz
            // 
            resources.ApplyResources(this.progressBarHiz, "progressBarHiz");
            this.progressBarHiz.Name = "progressBarHiz";
            // 
            // progressBarKilometre
            // 
            resources.ApplyResources(this.progressBarKilometre, "progressBarKilometre");
            this.progressBarKilometre.Name = "progressBarKilometre";
            // 
            // progressBarPil
            // 
            resources.ApplyResources(this.progressBarPil, "progressBarPil");
            this.progressBarPil.Name = "progressBarPil";
            // 
            // progressBarPilSicakligi
            // 
            resources.ApplyResources(this.progressBarPilSicakligi, "progressBarPilSicakligi");
            this.progressBarPilSicakligi.Name = "progressBarPilSicakligi";
            // 
            // labelHiz
            // 
            resources.ApplyResources(this.labelHiz, "labelHiz");
            this.labelHiz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHiz.Name = "labelHiz";
            // 
            // labelKilometre
            // 
            resources.ApplyResources(this.labelKilometre, "labelKilometre");
            this.labelKilometre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKilometre.Name = "labelKilometre";
            // 
            // labelPil
            // 
            resources.ApplyResources(this.labelPil, "labelPil");
            this.labelPil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPil.Name = "labelPil";
            // 
            // labelPilSicakligi
            // 
            resources.ApplyResources(this.labelPilSicakligi, "labelPilSicakligi");
            this.labelPilSicakligi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPilSicakligi.Name = "labelPilSicakligi";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPilSicakligi);
            this.Controls.Add(this.labelPil);
            this.Controls.Add(this.labelKilometre);
            this.Controls.Add(this.labelHiz);
            this.Controls.Add(this.progressBarPilSicakligi);
            this.Controls.Add(this.progressBarPil);
            this.Controls.Add(this.progressBarKilometre);
            this.Controls.Add(this.progressBarHiz);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.baslat);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.ProgressBar progressBarHiz;
        private System.Windows.Forms.ProgressBar progressBarKilometre;
        private System.Windows.Forms.ProgressBar progressBarPil;
        private System.Windows.Forms.ProgressBar progressBarPilSicakligi;
        private System.Windows.Forms.Label labelHiz;
        private System.Windows.Forms.Label labelKilometre;
        private System.Windows.Forms.Label labelPil;
        private System.Windows.Forms.Label labelPilSicakligi;
        private System.Windows.Forms.Label label1;
    }
}