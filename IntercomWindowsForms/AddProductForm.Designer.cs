namespace IntercomWindowsForms
{
    partial class AddProductForm
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
            this.CaptionTextBox = new System.Windows.Forms.TextBox();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ShapeComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.Approve = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaptionTextBox
            // 
            this.CaptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaptionTextBox.Location = new System.Drawing.Point(118, 21);
            this.CaptionTextBox.Name = "CaptionTextBox";
            this.CaptionTextBox.Size = new System.Drawing.Size(202, 26);
            this.CaptionTextBox.TabIndex = 0;
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaptionLabel.Location = new System.Drawing.Point(10, 24);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(84, 20);
            this.CaptionLabel.TabIndex = 1;
            this.CaptionLabel.Text = "Подпись: ";
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.AutoSize = true;
            this.ShapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShapeLabel.Location = new System.Drawing.Point(10, 71);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(44, 20);
            this.ShapeLabel.TabIndex = 2;
            this.ShapeLabel.Text = "Тип: ";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialLabel.Location = new System.Drawing.Point(10, 121);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(94, 20);
            this.MaterialLabel.TabIndex = 3;
            this.MaterialLabel.Text = "Материал: ";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(10, 174);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(56, 20);
            this.ColorLabel.TabIndex = 4;
            this.ColorLabel.Text = "Цвет: ";
            // 
            // ShapeComboBox
            // 
            this.ShapeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShapeComboBox.FormattingEnabled = true;
            this.ShapeComboBox.Location = new System.Drawing.Point(118, 68);
            this.ShapeComboBox.Name = "ShapeComboBox";
            this.ShapeComboBox.Size = new System.Drawing.Size(202, 28);
            this.ShapeComboBox.TabIndex = 5;
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(118, 118);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(202, 28);
            this.MaterialComboBox.TabIndex = 6;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(118, 166);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(202, 28);
            this.ColorComboBox.TabIndex = 7;
            // 
            // Approve
            // 
            this.Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Approve.Location = new System.Drawing.Point(245, 209);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(75, 34);
            this.Approve.TabIndex = 8;
            this.Approve.Text = "Ок";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(158, 209);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(81, 34);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 255);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.ShapeComboBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.ShapeLabel);
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.CaptionTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 294);
            this.MinimumSize = new System.Drawing.Size(348, 294);
            this.Name = "AddProductForm";
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CaptionTextBox;
        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.Label ShapeLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.ComboBox ShapeComboBox;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.Button Cancel;
    }
}