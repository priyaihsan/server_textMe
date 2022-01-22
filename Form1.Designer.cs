
namespace ServerTextMe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txOnOff = new System.Windows.Forms.Label();
            this.txDes = new System.Windows.Forms.Label();
            this.btOn = new System.Windows.Forms.Button();
            this.btOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // txOnOff
            // 
            this.txOnOff.AutoSize = true;
            this.txOnOff.Location = new System.Drawing.Point(31, 102);
            this.txOnOff.Name = "txOnOff";
            this.txOnOff.Size = new System.Drawing.Size(0, 17);
            this.txOnOff.TabIndex = 1;
            // 
            // txDes
            // 
            this.txDes.AutoSize = true;
            this.txDes.Location = new System.Drawing.Point(31, 137);
            this.txDes.Name = "txDes";
            this.txDes.Size = new System.Drawing.Size(0, 17);
            this.txDes.TabIndex = 2;
            // 
            // btOn
            // 
            this.btOn.Location = new System.Drawing.Point(34, 187);
            this.btOn.Name = "btOn";
            this.btOn.Size = new System.Drawing.Size(75, 23);
            this.btOn.TabIndex = 3;
            this.btOn.Text = "ON";
            this.btOn.UseVisualStyleBackColor = true;
            this.btOn.Click += new System.EventHandler(this.btOn_Click);
            // 
            // btOff
            // 
            this.btOff.Location = new System.Drawing.Point(34, 236);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(75, 23);
            this.btOff.TabIndex = 4;
            this.btOff.Text = "OFF";
            this.btOff.UseVisualStyleBackColor = true;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 295);
            this.Controls.Add(this.btOff);
            this.Controls.Add(this.btOn);
            this.Controls.Add(this.txDes);
            this.Controls.Add(this.txOnOff);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txOnOff;
        private System.Windows.Forms.Label txDes;
        private System.Windows.Forms.Button btOn;
        private System.Windows.Forms.Button btOff;
    }
}

