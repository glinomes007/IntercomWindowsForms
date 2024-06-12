﻿namespace IntercomWindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntercomList = new System.Windows.Forms.ListBox();
            this.ByShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByMateraialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ByCaptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.SortByToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // SortByToolStripMenuItem
            // 
            this.SortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ByPriceToolStripMenuItem,
            this.ByShapeToolStripMenuItem,
            this.ByMateraialToolStripMenuItem,
            this.ByColorToolStripMenuItem1,
            this.ByCaptionToolStripMenuItem});
            this.SortByToolStripMenuItem.Name = "SortByToolStripMenuItem";
            this.SortByToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SortByToolStripMenuItem.Text = "Сортировать по";
            // 
            // ByPriceToolStripMenuItem
            // 
            this.ByPriceToolStripMenuItem.Name = "ByPriceToolStripMenuItem";
            this.ByPriceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ByPriceToolStripMenuItem.Text = "Цене";
            this.ByPriceToolStripMenuItem.Click += new System.EventHandler(this.ByPriceToolStripMenuItem_Click);
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ProductToolStripMenuItem.Text = "Товар";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditToolStripMenuItem.Text = "Редактировать";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // IntercomList
            // 
            this.IntercomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntercomList.FormattingEnabled = true;
            this.IntercomList.ItemHeight = 20;
            this.IntercomList.Location = new System.Drawing.Point(0, 27);
            this.IntercomList.Name = "IntercomList";
            this.IntercomList.Size = new System.Drawing.Size(800, 424);
            this.IntercomList.TabIndex = 1;
            // 
            // ByShapeToolStripMenuItem
            // 
            this.ByShapeToolStripMenuItem.Name = "ByShapeToolStripMenuItem";
            this.ByShapeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ByShapeToolStripMenuItem.Text = "Типу";
            this.ByShapeToolStripMenuItem.Click += new System.EventHandler(this.ByShapeToolStripMenuItem_Click);
            // 
            // ByMateraialToolStripMenuItem
            // 
            this.ByMateraialToolStripMenuItem.Name = "ByMateraialToolStripMenuItem";
            this.ByMateraialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ByMateraialToolStripMenuItem.Text = "Материалу";
            this.ByMateraialToolStripMenuItem.Click += new System.EventHandler(this.ByMateraialToolStripMenuItem_Click);
            // 
            // ByColorToolStripMenuItem1
            // 
            this.ByColorToolStripMenuItem1.Name = "ByColorToolStripMenuItem1";
            this.ByColorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ByColorToolStripMenuItem1.Text = "Цвету";
            this.ByColorToolStripMenuItem1.Click += new System.EventHandler(this.ByColorToolStripMenuItem1_Click);
            // 
            // ByCaptionToolStripMenuItem
            // 
            this.ByCaptionToolStripMenuItem.Name = "ByCaptionToolStripMenuItem";
            this.ByCaptionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ByCaptionToolStripMenuItem.Text = "Подписи";
            this.ByCaptionToolStripMenuItem.Click += new System.EventHandler(this.ByCaptionToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.IntercomList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 485);
            this.MinimumSize = new System.Drawing.Size(816, 485);
            this.Name = "MainForm";
            this.Text = "Intercom";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox IntercomList;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByMateraialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ByCaptionToolStripMenuItem;
    }
}

