namespace SPZ_Lab5.View
{
    partial class GroupEditor
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
            this.listGroup_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newGroup_textBox = new System.Windows.Forms.TextBox();
            this.deleteGroup_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rename_button = new System.Windows.Forms.Button();
            this.addGroup_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listGroup_comboBox
            // 
            this.listGroup_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listGroup_comboBox.FormattingEnabled = true;
            this.listGroup_comboBox.Location = new System.Drawing.Point(173, 49);
            this.listGroup_comboBox.Name = "listGroup_comboBox";
            this.listGroup_comboBox.Size = new System.Drawing.Size(178, 28);
            this.listGroup_comboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(201, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список групп";
            // 
            // newGroup_textBox
            // 
            this.newGroup_textBox.Location = new System.Drawing.Point(202, 146);
            this.newGroup_textBox.Name = "newGroup_textBox";
            this.newGroup_textBox.Size = new System.Drawing.Size(149, 26);
            this.newGroup_textBox.TabIndex = 2;
            // 
            // deleteGroup_button
            // 
            this.deleteGroup_button.BackColor = System.Drawing.Color.Yellow;
            this.deleteGroup_button.Location = new System.Drawing.Point(218, 92);
            this.deleteGroup_button.Name = "deleteGroup_button";
            this.deleteGroup_button.Size = new System.Drawing.Size(91, 39);
            this.deleteGroup_button.TabIndex = 3;
            this.deleteGroup_button.Text = "Удалить";
            this.deleteGroup_button.UseVisualStyleBackColor = false;
            this.deleteGroup_button.Click += new System.EventHandler(this.deleteGroup_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название группы:";
            // 
            // rename_button
            // 
            this.rename_button.BackColor = System.Drawing.Color.Yellow;
            this.rename_button.Location = new System.Drawing.Point(53, 199);
            this.rename_button.Name = "rename_button";
            this.rename_button.Size = new System.Drawing.Size(144, 39);
            this.rename_button.TabIndex = 5;
            this.rename_button.Text = "Переименовать";
            this.rename_button.UseVisualStyleBackColor = false;
            this.rename_button.Click += new System.EventHandler(this.rename_button_Click);
            // 
            // addGroup_button
            // 
            this.addGroup_button.BackColor = System.Drawing.Color.Yellow;
            this.addGroup_button.Location = new System.Drawing.Point(341, 199);
            this.addGroup_button.Name = "addGroup_button";
            this.addGroup_button.Size = new System.Drawing.Size(144, 39);
            this.addGroup_button.TabIndex = 6;
            this.addGroup_button.Text = "Добавить";
            this.addGroup_button.UseVisualStyleBackColor = false;
            this.addGroup_button.Click += new System.EventHandler(this.addGroup_button_Click);
            // 
            // GroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(519, 265);
            this.Controls.Add(this.addGroup_button);
            this.Controls.Add(this.rename_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteGroup_button);
            this.Controls.Add(this.newGroup_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listGroup_comboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GroupEditor";
            this.Text = "GroupEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listGroup_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newGroup_textBox;
        private System.Windows.Forms.Button deleteGroup_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rename_button;
        private System.Windows.Forms.Button addGroup_button;
    }
}