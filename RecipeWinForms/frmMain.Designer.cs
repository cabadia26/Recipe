namespace RecipeWinForms
{
    partial class frmMain
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gRecipeSummary = new System.Windows.Forms.DataGridView();
            this.gRecipeList = new System.Windows.Forms.DataGridView();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeList)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.gRecipeSummary, 0, 0);
            this.tblMain.Controls.Add(this.gRecipeList, 1, 0);
            this.tblMain.Controls.Add(this.btnNewRecipe, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 0;
            // 
            // gRecipeSummary
            // 
            this.gRecipeSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipeSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipeSummary.Location = new System.Drawing.Point(3, 3);
            this.gRecipeSummary.Name = "gRecipeSummary";
            this.gRecipeSummary.RowHeadersWidth = 51;
            this.gRecipeSummary.RowTemplate.Height = 29;
            this.gRecipeSummary.Size = new System.Drawing.Size(394, 219);
            this.gRecipeSummary.TabIndex = 0;
            // 
            // gRecipeList
            // 
            this.gRecipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipeList.Location = new System.Drawing.Point(403, 3);
            this.gRecipeList.Name = "gRecipeList";
            this.gRecipeList.RowHeadersWidth = 51;
            this.gRecipeList.RowTemplate.Height = 29;
            this.gRecipeList.Size = new System.Drawing.Size(394, 219);
            this.gRecipeList.TabIndex = 1;
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.AutoSize = true;
            this.btnNewRecipe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewRecipe.Location = new System.Drawing.Point(3, 228);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(144, 41);
            this.btnNewRecipe.TabIndex = 2;
            this.btnNewRecipe.Text = "New Recipe";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gRecipeSummary;
        private DataGridView gRecipeList;
        private Button btnNewRecipe;
    }
}