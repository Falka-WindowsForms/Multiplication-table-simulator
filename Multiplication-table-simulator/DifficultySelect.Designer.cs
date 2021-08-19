
namespace Multiplication_table_simulator
{
    partial class DifficultySelect
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
            this.label = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.single_button = new System.Windows.Forms.Button();
            this.double_button = new System.Windows.Forms.Button();
            this.insane_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(16, 9);
            this.label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Welcome:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(133, 9);
            this.label_name.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(64, 25);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // single_button
            // 
            this.single_button.Location = new System.Drawing.Point(49, 69);
            this.single_button.Name = "single_button";
            this.single_button.Size = new System.Drawing.Size(182, 67);
            this.single_button.TabIndex = 2;
            this.single_button.Text = "Single digits";
            this.single_button.UseVisualStyleBackColor = true;
            this.single_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // double_button
            // 
            this.double_button.Location = new System.Drawing.Point(49, 157);
            this.double_button.Name = "double_button";
            this.double_button.Size = new System.Drawing.Size(182, 63);
            this.double_button.TabIndex = 3;
            this.double_button.Text = "Double digits";
            this.double_button.UseVisualStyleBackColor = true;
            this.double_button.Click += new System.EventHandler(this.double_button_Click);
            // 
            // insane_button
            // 
            this.insane_button.Location = new System.Drawing.Point(49, 241);
            this.insane_button.Name = "insane_button";
            this.insane_button.Size = new System.Drawing.Size(182, 58);
            this.insane_button.TabIndex = 4;
            this.insane_button.Text = "Insane mode";
            this.insane_button.UseVisualStyleBackColor = true;
            this.insane_button.Click += new System.EventHandler(this.insane_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(49, 328);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(182, 63);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "Exit";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // DifficultySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(280, 428);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.insane_button);
            this.Controls.Add(this.double_button);
            this.Controls.Add(this.single_button);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "DifficultySelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DifficultySelect";
            this.Load += new System.EventHandler(this.DifficultySelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button single_button;
        private System.Windows.Forms.Button double_button;
        private System.Windows.Forms.Button insane_button;
        private System.Windows.Forms.Button close_button;
    }
}