
namespace Domaci1
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbKOM = new System.Windows.Forms.TextBox();
            this.tbCENA = new System.Windows.Forms.TextBox();
            this.tbPOPUST = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btNEXT = new System.Windows.Forms.Button();
            this.btPOCETAK = new System.Windows.Forms.Button();
            this.btPREV = new System.Windows.Forms.Button();
            this.btKRAJ = new System.Windows.Forms.Button();
            this.btUPDATE = new System.Windows.Forms.Button();
            this.btDELETE = new System.Windows.Forms.Button();
            this.btADDNEW = new System.Windows.Forms.Button();
            this.btADD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(50, 95);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(86, 22);
            this.tbID.TabIndex = 0;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKOM
            // 
            this.tbKOM.Enabled = false;
            this.tbKOM.Location = new System.Drawing.Point(183, 95);
            this.tbKOM.Name = "tbKOM";
            this.tbKOM.Size = new System.Drawing.Size(144, 22);
            this.tbKOM.TabIndex = 1;
            this.tbKOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCENA
            // 
            this.tbCENA.Enabled = false;
            this.tbCENA.Location = new System.Drawing.Point(377, 95);
            this.tbCENA.Name = "tbCENA";
            this.tbCENA.Size = new System.Drawing.Size(144, 22);
            this.tbCENA.TabIndex = 2;
            this.tbCENA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPOPUST
            // 
            this.tbPOPUST.Enabled = false;
            this.tbPOPUST.Location = new System.Drawing.Point(590, 95);
            this.tbPOPUST.Name = "tbPOPUST";
            this.tbPOPUST.Size = new System.Drawing.Size(144, 22);
            this.tbPOPUST.TabIndex = 3;
            this.tbPOPUST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Komada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Popust";
            // 
            // btNEXT
            // 
            this.btNEXT.Location = new System.Drawing.Point(403, 171);
            this.btNEXT.Name = "btNEXT";
            this.btNEXT.Size = new System.Drawing.Size(75, 80);
            this.btNEXT.TabIndex = 9;
            this.btNEXT.Text = ">";
            this.btNEXT.UseVisualStyleBackColor = true;
            this.btNEXT.Click += new System.EventHandler(this.btNEXT_Click);
            // 
            // btPOCETAK
            // 
            this.btPOCETAK.Location = new System.Drawing.Point(243, 171);
            this.btPOCETAK.Name = "btPOCETAK";
            this.btPOCETAK.Size = new System.Drawing.Size(75, 80);
            this.btPOCETAK.TabIndex = 10;
            this.btPOCETAK.Text = "<<";
            this.btPOCETAK.UseVisualStyleBackColor = true;
            this.btPOCETAK.Click += new System.EventHandler(this.btPOCETAK_Click);
            // 
            // btPREV
            // 
            this.btPREV.Location = new System.Drawing.Point(322, 171);
            this.btPREV.Name = "btPREV";
            this.btPREV.Size = new System.Drawing.Size(75, 80);
            this.btPREV.TabIndex = 11;
            this.btPREV.Text = "<";
            this.btPREV.UseVisualStyleBackColor = true;
            this.btPREV.Click += new System.EventHandler(this.btPREV_Click);
            // 
            // btKRAJ
            // 
            this.btKRAJ.Location = new System.Drawing.Point(484, 171);
            this.btKRAJ.Name = "btKRAJ";
            this.btKRAJ.Size = new System.Drawing.Size(75, 80);
            this.btKRAJ.TabIndex = 12;
            this.btKRAJ.Text = ">>";
            this.btKRAJ.UseVisualStyleBackColor = true;
            this.btKRAJ.Click += new System.EventHandler(this.btKRAJ_Click);
            // 
            // btUPDATE
            // 
            this.btUPDATE.Location = new System.Drawing.Point(322, 279);
            this.btUPDATE.Name = "btUPDATE";
            this.btUPDATE.Size = new System.Drawing.Size(144, 23);
            this.btUPDATE.TabIndex = 13;
            this.btUPDATE.Text = "AZURIRAJ";
            this.btUPDATE.UseVisualStyleBackColor = true;
            this.btUPDATE.Click += new System.EventHandler(this.btUPDATE_Click);
            // 
            // btDELETE
            // 
            this.btDELETE.Location = new System.Drawing.Point(322, 318);
            this.btDELETE.Name = "btDELETE";
            this.btDELETE.Size = new System.Drawing.Size(144, 23);
            this.btDELETE.TabIndex = 14;
            this.btDELETE.Text = "OBRISI";
            this.btDELETE.UseVisualStyleBackColor = true;
            this.btDELETE.Click += new System.EventHandler(this.btDELETE_Click);
            // 
            // btADDNEW
            // 
            this.btADDNEW.Location = new System.Drawing.Point(322, 358);
            this.btADDNEW.Name = "btADDNEW";
            this.btADDNEW.Size = new System.Drawing.Size(140, 23);
            this.btADDNEW.TabIndex = 15;
            this.btADDNEW.Text = "DODAJ NOVI";
            this.btADDNEW.UseVisualStyleBackColor = true;
            this.btADDNEW.Click += new System.EventHandler(this.btADDNEW_Click);
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(501, 358);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 16;
            this.btADD.Text = "DODAJ";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "UCITAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.btADDNEW);
            this.Controls.Add(this.btDELETE);
            this.Controls.Add(this.btUPDATE);
            this.Controls.Add(this.btKRAJ);
            this.Controls.Add(this.btPREV);
            this.Controls.Add(this.btPOCETAK);
            this.Controls.Add(this.btNEXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPOPUST);
            this.Controls.Add(this.tbCENA);
            this.Controls.Add(this.tbKOM);
            this.Controls.Add(this.tbID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbKOM;
        private System.Windows.Forms.TextBox tbCENA;
        private System.Windows.Forms.TextBox tbPOPUST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btNEXT;
        private System.Windows.Forms.Button btPOCETAK;
        private System.Windows.Forms.Button btPREV;
        private System.Windows.Forms.Button btKRAJ;
        private System.Windows.Forms.Button btUPDATE;
        private System.Windows.Forms.Button btDELETE;
        private System.Windows.Forms.Button btADDNEW;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

