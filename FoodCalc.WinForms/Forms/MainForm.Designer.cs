namespace FoodCalc.WinForms
{
    partial class MainForm
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
            this.Workspaces = new System.Windows.Forms.TabControl();
            this.ProductsPage = new System.Windows.Forms.TabPage();
            this.DishesPage = new System.Windows.Forms.TabPage();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CompositionGrdView = new System.Windows.Forms.DataGridView();
            this.Workspaces.SuspendLayout();
            this.ProductsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompositionGrdView)).BeginInit();
            this.SuspendLayout();
            // 
            // Workspaces
            // 
            this.Workspaces.Controls.Add(this.ProductsPage);
            this.Workspaces.Controls.Add(this.DishesPage);
            this.Workspaces.Location = new System.Drawing.Point(12, 12);
            this.Workspaces.Name = "Workspaces";
            this.Workspaces.SelectedIndex = 0;
            this.Workspaces.Size = new System.Drawing.Size(776, 426);
            this.Workspaces.TabIndex = 0;
            // 
            // ProductsPage
            // 
            this.ProductsPage.Controls.Add(this.CompositionGrdView);
            this.ProductsPage.Controls.Add(this.textBox1);
            this.ProductsPage.Controls.Add(this.Text1);
            this.ProductsPage.Controls.Add(this.ProductNameTextBox);
            this.ProductsPage.Controls.Add(this.ProductsGridView);
            this.ProductsPage.Location = new System.Drawing.Point(4, 22);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsPage.Size = new System.Drawing.Size(768, 400);
            this.ProductsPage.TabIndex = 0;
            this.ProductsPage.Text = "Продукты";
            this.ProductsPage.UseVisualStyleBackColor = true;
            // 
            // DishesPage
            // 
            this.DishesPage.Location = new System.Drawing.Point(4, 22);
            this.DishesPage.Name = "DishesPage";
            this.DishesPage.Padding = new System.Windows.Forms.Padding(3);
            this.DishesPage.Size = new System.Drawing.Size(768, 400);
            this.DishesPage.TabIndex = 1;
            this.DishesPage.Text = "Блюда";
            this.DishesPage.UseVisualStyleBackColor = true;
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Location = new System.Drawing.Point(6, 19);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(240, 375);
            this.ProductsGridView.TabIndex = 0;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(261, 38);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(489, 20);
            this.ProductNameTextBox.TabIndex = 2;
            // 
            // Text1
            // 
            this.Text1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text1.Location = new System.Drawing.Point(261, 19);
            this.Text1.Name = "Text1";
            this.Text1.ReadOnly = true;
            this.Text1.Size = new System.Drawing.Size(489, 13);
            this.Text1.TabIndex = 3;
            this.Text1.Text = "Наименование сырья";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(261, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(489, 13);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Химический состав";
            // 
            // CompositionGrdView
            // 
            this.CompositionGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompositionGrdView.Location = new System.Drawing.Point(261, 83);
            this.CompositionGrdView.Name = "CompositionGrdView";
            this.CompositionGrdView.Size = new System.Drawing.Size(406, 311);
            this.CompositionGrdView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Workspaces);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Workspaces.ResumeLayout(false);
            this.ProductsPage.ResumeLayout(false);
            this.ProductsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompositionGrdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Workspaces;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.TabPage DishesPage;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.DataGridView CompositionGrdView;
    }
}

