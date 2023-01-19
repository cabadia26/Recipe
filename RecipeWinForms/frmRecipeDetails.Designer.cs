namespace RecipeWinForms
{
    partial class frmRecipeDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblRows = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblDraftDate = new System.Windows.Forms.Label();
            this.lblPublishedDate = new System.Windows.Forms.Label();
            this.lblArchivedDate = new System.Windows.Forms.Label();
            this.lblStatusName = new System.Windows.Forms.Label();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.tblGrids = new System.Windows.Forms.TableLayoutPanel();
            this.gRecipeIngredientList = new System.Windows.Forms.DataGridView();
            this.gRecipeSteps = new System.Windows.Forms.DataGridView();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lstCuisine = new System.Windows.Forms.ComboBox();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.lblDraft = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblRows.SuspendLayout();
            this.tblGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeIngredientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeSteps)).BeginInit();
            this.tblButtons.SuspendLayout();
            this.tblLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.72455F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.27545F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 737F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.tblRows, 0, 0);
            this.tblMain.Controls.Add(this.tblGrids, 2, 0);
            this.tblMain.Controls.Add(this.tblButtons, 2, 1);
            this.tblMain.Controls.Add(this.tblLabels, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.91304F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.08696F));
            this.tblMain.Size = new System.Drawing.Size(1239, 667);
            this.tblMain.TabIndex = 0;
            // 
            // tblRows
            // 
            this.tblRows.ColumnCount = 1;
            this.tblRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRows.Controls.Add(this.lblRecipeName, 0, 1);
            this.tblRows.Controls.Add(this.lblCalories, 0, 2);
            this.tblRows.Controls.Add(this.lblIngredients, 0, 3);
            this.tblRows.Controls.Add(this.lblSteps, 0, 4);
            this.tblRows.Controls.Add(this.lblDraftDate, 0, 5);
            this.tblRows.Controls.Add(this.lblPublishedDate, 0, 6);
            this.tblRows.Controls.Add(this.lblArchivedDate, 0, 7);
            this.tblRows.Controls.Add(this.lblStatusName, 0, 8);
            this.tblRows.Controls.Add(this.lblCuisine, 0, 0);
            this.tblRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRows.Location = new System.Drawing.Point(3, 3);
            this.tblRows.Name = "tblRows";
            this.tblRows.RowCount = 9;
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblRows.Size = new System.Drawing.Size(183, 486);
            this.tblRows.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(3, 54);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(177, 54);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalories.Location = new System.Drawing.Point(3, 108);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(177, 54);
            this.lblCalories.TabIndex = 1;
            this.lblCalories.Text = "Num Calories";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngredients.Location = new System.Drawing.Point(3, 162);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(177, 54);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Num Ingredients";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSteps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSteps.Location = new System.Drawing.Point(3, 216);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(177, 54);
            this.lblSteps.TabIndex = 3;
            this.lblSteps.Text = "Num Steps";
            // 
            // lblDraftDate
            // 
            this.lblDraftDate.AutoSize = true;
            this.lblDraftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDraftDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDraftDate.Location = new System.Drawing.Point(3, 270);
            this.lblDraftDate.Name = "lblDraftDate";
            this.lblDraftDate.Size = new System.Drawing.Size(177, 54);
            this.lblDraftDate.TabIndex = 4;
            this.lblDraftDate.Text = "Draft Date";
            // 
            // lblPublishedDate
            // 
            this.lblPublishedDate.AutoSize = true;
            this.lblPublishedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublishedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPublishedDate.Location = new System.Drawing.Point(3, 324);
            this.lblPublishedDate.Name = "lblPublishedDate";
            this.lblPublishedDate.Size = new System.Drawing.Size(177, 54);
            this.lblPublishedDate.TabIndex = 5;
            this.lblPublishedDate.Text = "Published Date";
            // 
            // lblArchivedDate
            // 
            this.lblArchivedDate.AutoSize = true;
            this.lblArchivedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchivedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArchivedDate.Location = new System.Drawing.Point(3, 378);
            this.lblArchivedDate.Name = "lblArchivedDate";
            this.lblArchivedDate.Size = new System.Drawing.Size(177, 54);
            this.lblArchivedDate.TabIndex = 6;
            this.lblArchivedDate.Text = "Archived Date";
            // 
            // lblStatusName
            // 
            this.lblStatusName.AutoSize = true;
            this.lblStatusName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusName.Location = new System.Drawing.Point(3, 432);
            this.lblStatusName.Name = "lblStatusName";
            this.lblStatusName.Size = new System.Drawing.Size(177, 54);
            this.lblStatusName.TabIndex = 7;
            this.lblStatusName.Text = "Status";
            // 
            // lblCuisine
            // 
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuisine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuisine.Location = new System.Drawing.Point(3, 0);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(177, 54);
            this.lblCuisine.TabIndex = 8;
            this.lblCuisine.Text = "Cuisine";
            // 
            // tblGrids
            // 
            this.tblGrids.ColumnCount = 1;
            this.tblGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGrids.Controls.Add(this.gRecipeIngredientList, 0, 0);
            this.tblGrids.Controls.Add(this.gRecipeSteps, 0, 1);
            this.tblGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGrids.Location = new System.Drawing.Point(504, 3);
            this.tblGrids.Name = "tblGrids";
            this.tblGrids.RowCount = 2;
            this.tblGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGrids.Size = new System.Drawing.Size(732, 486);
            this.tblGrids.TabIndex = 1;
            // 
            // gRecipeIngredientList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gRecipeIngredientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gRecipeIngredientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gRecipeIngredientList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gRecipeIngredientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipeIngredientList.Location = new System.Drawing.Point(3, 3);
            this.gRecipeIngredientList.Name = "gRecipeIngredientList";
            this.gRecipeIngredientList.RowHeadersWidth = 51;
            this.gRecipeIngredientList.RowTemplate.Height = 29;
            this.gRecipeIngredientList.Size = new System.Drawing.Size(726, 237);
            this.gRecipeIngredientList.TabIndex = 0;
            // 
            // gRecipeSteps
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gRecipeSteps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gRecipeSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gRecipeSteps.DefaultCellStyle = dataGridViewCellStyle4;
            this.gRecipeSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipeSteps.Location = new System.Drawing.Point(3, 246);
            this.gRecipeSteps.Name = "gRecipeSteps";
            this.gRecipeSteps.RowHeadersWidth = 51;
            this.gRecipeSteps.RowTemplate.Height = 29;
            this.gRecipeSteps.Size = new System.Drawing.Size(726, 237);
            this.gRecipeSteps.TabIndex = 1;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButtons.ColumnCount = 2;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Controls.Add(this.btnSave, 0, 0);
            this.tblButtons.Controls.Add(this.btnDelete, 1, 0);
            this.tblButtons.Location = new System.Drawing.Point(986, 495);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Size = new System.Drawing.Size(250, 125);
            this.tblButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 119);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(128, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 119);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tblLabels
            // 
            this.tblLabels.AutoSize = true;
            this.tblLabels.ColumnCount = 1;
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLabels.Controls.Add(this.lstCuisine, 0, 0);
            this.tblLabels.Controls.Add(this.txtRecipe, 0, 1);
            this.tblLabels.Controls.Add(this.txtCalories, 0, 2);
            this.tblLabels.Controls.Add(this.txtIngredients, 0, 3);
            this.tblLabels.Controls.Add(this.txtSteps, 0, 4);
            this.tblLabels.Controls.Add(this.lblDraft, 0, 5);
            this.tblLabels.Controls.Add(this.lblPublished, 0, 6);
            this.tblLabels.Controls.Add(this.lblArchived, 0, 7);
            this.tblLabels.Controls.Add(this.lblStatus, 0, 8);
            this.tblLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLabels.Location = new System.Drawing.Point(192, 3);
            this.tblLabels.Name = "tblLabels";
            this.tblLabels.RowCount = 9;
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblLabels.Size = new System.Drawing.Size(306, 486);
            this.tblLabels.TabIndex = 3;
            // 
            // lstCuisine
            // 
            this.lstCuisine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCuisine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstCuisine.FormattingEnabled = true;
            this.lstCuisine.Location = new System.Drawing.Point(3, 3);
            this.lstCuisine.Name = "lstCuisine";
            this.lstCuisine.Size = new System.Drawing.Size(300, 36);
            this.lstCuisine.TabIndex = 0;
            // 
            // txtRecipe
            // 
            this.txtRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRecipe.Location = new System.Drawing.Point(3, 57);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(300, 34);
            this.txtRecipe.TabIndex = 1;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCalories.Location = new System.Drawing.Point(3, 111);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(300, 34);
            this.txtCalories.TabIndex = 2;
            // 
            // txtIngredients
            // 
            this.txtIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIngredients.Location = new System.Drawing.Point(3, 165);
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(300, 34);
            this.txtIngredients.TabIndex = 3;
            // 
            // txtSteps
            // 
            this.txtSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSteps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSteps.Location = new System.Drawing.Point(3, 219);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(300, 34);
            this.txtSteps.TabIndex = 4;
            // 
            // lblDraft
            // 
            this.lblDraft.AutoSize = true;
            this.lblDraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDraft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDraft.Location = new System.Drawing.Point(3, 270);
            this.lblDraft.Name = "lblDraft";
            this.lblDraft.Size = new System.Drawing.Size(300, 54);
            this.lblDraft.TabIndex = 5;
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPublished.Location = new System.Drawing.Point(3, 324);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(300, 54);
            this.lblPublished.TabIndex = 6;
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArchived.Location = new System.Drawing.Point(3, 378);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(300, 54);
            this.lblArchived.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(3, 432);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 54);
            this.lblStatus.TabIndex = 8;
            // 
            // frmRecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 667);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipeDetails";
            this.Text = "frmRecipeDetails";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblRows.ResumeLayout(false);
            this.tblRows.PerformLayout();
            this.tblGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeIngredientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeSteps)).EndInit();
            this.tblButtons.ResumeLayout(false);
            this.tblLabels.ResumeLayout(false);
            this.tblLabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblGrids;
        private DataGridView gRecipeIngredientList;
        private DataGridView gRecipeSteps;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private TableLayoutPanel tblLabels;
        private TableLayoutPanel tblRows;
        private Label lblRecipeName;
        private Label lblCalories;
        private Label lblIngredients;
        private Label lblSteps;
        private Label lblDraftDate;
        private Label lblPublishedDate;
        private Label lblArchivedDate;
        private Label lblStatusName;
        private Label lblCuisine;
        private ComboBox lstCuisine;
        private TextBox txtRecipe;
        private TextBox txtCalories;
        private TextBox txtIngredients;
        private TextBox txtSteps;
        private Label lblDraft;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatus;
    }
}