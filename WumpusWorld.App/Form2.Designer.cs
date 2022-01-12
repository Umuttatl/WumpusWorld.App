
namespace WumpusWorld.App
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.AIaction = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 12);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(150, 91);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(168, 12);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(150, 91);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(324, 12);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(150, 91);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 109);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(150, 91);
            this.b4.TabIndex = 3;
            this.b4.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(168, 109);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(150, 91);
            this.b5.TabIndex = 4;
            this.b5.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(324, 109);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(150, 91);
            this.b6.TabIndex = 5;
            this.b6.UseVisualStyleBackColor = true;
            // 
            // AIaction
            // 
            this.AIaction.Tick += new System.EventHandler(this.AIactions);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 507);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Timer AIaction;
    }
}