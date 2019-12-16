namespace ServisTime
{
    partial class Form1
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
            this.bTCloseApp = new System.Windows.Forms.Button();
            this.labelLnfo = new System.Windows.Forms.Label();
            this.btStartServise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btRestart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bеStopServis = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNunMinutes = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            // 
            // bTCloseApp
            // 
            this.bTCloseApp.Location = new System.Drawing.Point(274, 309);
            this.bTCloseApp.MaximumSize = new System.Drawing.Size(104, 23);
            this.bTCloseApp.MinimumSize = new System.Drawing.Size(104, 23);
            this.bTCloseApp.Name = "bTCloseApp";
            this.bTCloseApp.Size = new System.Drawing.Size(104, 23);
            this.bTCloseApp.TabIndex = 0;
            this.bTCloseApp.Text = "Выход";
            this.bTCloseApp.UseVisualStyleBackColor = true;
            this.bTCloseApp.Click += new System.EventHandler(this.bTCloseApp_Click);
            this.bTCloseApp.Enter += new System.EventHandler(this.BTCloseApp_Enter);
            // 
            // labelLnfo
            // 
            this.labelLnfo.AutoSize = true;
            this.labelLnfo.Location = new System.Drawing.Point(23, 41);
            this.labelLnfo.Name = "labelLnfo";
            this.labelLnfo.Size = new System.Drawing.Size(38, 15);
            this.labelLnfo.TabIndex = 1;
            this.labelLnfo.Text = "label1";
            // 
            // btStartServise
            // 
            this.btStartServise.Location = new System.Drawing.Point(29, 106);
            this.btStartServise.Name = "btStartServise";
            this.btStartServise.Size = new System.Drawing.Size(75, 23);
            this.btStartServise.TabIndex = 2;
            this.btStartServise.Text = "Запустить";
            this.btStartServise.UseVisualStyleBackColor = true;
            this.btStartServise.Click += new System.EventHandler(this.btStartServise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Служба обновления времени.";
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(256, 106);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(104, 23);
            this.btRestart.TabIndex = 2;
            this.btRestart.Text = "Перезапустить";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(-583, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // bеStopServis
            // 
            this.bеStopServis.Location = new System.Drawing.Point(129, 106);
            this.bеStopServis.Name = "bеStopServis";
            this.bеStopServis.Size = new System.Drawing.Size(104, 23);
            this.bеStopServis.TabIndex = 2;
            this.bеStopServis.Text = "Остановить";
            this.bеStopServis.UseVisualStyleBackColor = true;
            this.bеStopServis.Click += new System.EventHandler(this.bеStopServis_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(129, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(144, 15);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Синхронизация времени";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Автозапуск службы";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время обновления (Мин.)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNunMinutes
            // 
            this.textBoxNunMinutes.Location = new System.Drawing.Point(274, 191);
            this.textBoxNunMinutes.Name = "textBoxNunMinutes";
            this.textBoxNunMinutes.Size = new System.Drawing.Size(52, 23);
            this.textBoxNunMinutes.TabIndex = 7;
            this.textBoxNunMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNunMinutes.TextChanged += new System.EventHandler(this.textBoxNunMinutes_TextChanged);
            this.textBoxNunMinutes.Enter += new System.EventHandler(this.textBoxNunMinutes_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 309);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(146, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить настройки";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 365);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxNunMinutes);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStartServise);
            this.Controls.Add(this.labelLnfo);
            this.Controls.Add(this.bTCloseApp);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.bеStopServis);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 404);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Синхронизация фремени";

        }

        #endregion

        private System.Windows.Forms.Button bTCloseApp;
        private System.Windows.Forms.Label labelLnfo;
        private System.Windows.Forms.Button btStartServise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bеStopServis;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNunMinutes;
        private System.Windows.Forms.Button buttonSave;
    }
}

