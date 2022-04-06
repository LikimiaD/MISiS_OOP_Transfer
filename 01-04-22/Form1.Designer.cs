namespace _01_04_22
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
            this.main_value = new System.Windows.Forms.TextBox();
            this.main_box = new System.Windows.Forms.ComboBox();
            this.transfer_value = new System.Windows.Forms.TextBox();
            this.transfer_box = new System.Windows.Forms.ComboBox();
            this.add_buton = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_value
            // 
            this.main_value.Location = new System.Drawing.Point(60, 45);
            this.main_value.Name = "main_value";
            this.main_value.ReadOnly = true;
            this.main_value.Size = new System.Drawing.Size(125, 27);
            this.main_value.TabIndex = 0;
            // 
            // main_box
            // 
            this.main_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.main_box.FormattingEnabled = true;
            this.main_box.Location = new System.Drawing.Point(60, 104);
            this.main_box.Name = "main_box";
            this.main_box.Size = new System.Drawing.Size(151, 28);
            this.main_box.TabIndex = 1;
            // 
            // transfer_value
            // 
            this.transfer_value.Location = new System.Drawing.Point(64, 184);
            this.transfer_value.Name = "transfer_value";
            this.transfer_value.Size = new System.Drawing.Size(125, 27);
            this.transfer_value.TabIndex = 2;
            // 
            // transfer_box
            // 
            this.transfer_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transfer_box.FormattingEnabled = true;
            this.transfer_box.Location = new System.Drawing.Point(64, 252);
            this.transfer_box.Name = "transfer_box";
            this.transfer_box.Size = new System.Drawing.Size(151, 28);
            this.transfer_box.TabIndex = 3;
            // 
            // add_buton
            // 
            this.add_buton.Location = new System.Drawing.Point(37, 333);
            this.add_buton.Name = "add_buton";
            this.add_buton.Size = new System.Drawing.Size(94, 29);
            this.add_buton.TabIndex = 4;
            this.add_buton.Text = "Add";
            this.add_buton.UseVisualStyleBackColor = true;
            this.add_buton.Click += new System.EventHandler(this.add_buton_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(166, 333);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 29);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add_buton);
            this.Controls.Add(this.transfer_box);
            this.Controls.Add(this.transfer_value);
            this.Controls.Add(this.main_box);
            this.Controls.Add(this.main_value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox main_value;
        private ComboBox main_box;
        private TextBox transfer_value;
        private ComboBox transfer_box;
        private Button add_buton;
        private Button delete;
    }
}