namespace Win.Ventas
{
    partial class FormNiños
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label seccionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNiños));
            this.listaProdNiñosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaProdNiñosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.SeccionTextBox = new System.Windows.Forms.TextBox();
            this.listaProdNiñosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            seccionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProdNiñosBindingNavigator)).BeginInit();
            this.listaProdNiñosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProdNiñosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(53, 238);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(53, 57);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 3;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(53, 94);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(53, 200);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(58, 13);
            existenciaLabel.TabIndex = 7;
            existenciaLabel.Text = "Existencia:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(56, 129);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio:";
            // 
            // seccionLabel
            // 
            seccionLabel.AutoSize = true;
            seccionLabel.Location = new System.Drawing.Point(53, 164);
            seccionLabel.Name = "seccionLabel";
            seccionLabel.Size = new System.Drawing.Size(49, 13);
            seccionLabel.TabIndex = 11;
            seccionLabel.Text = "Seccion:";
            // 
            // listaProdNiñosBindingNavigator
            // 
            this.listaProdNiñosBindingNavigator.AddNewItem = null;
            this.listaProdNiñosBindingNavigator.BindingSource = this.listaProdNiñosBindingSource;
            this.listaProdNiñosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaProdNiñosBindingNavigator.DeleteItem = null;
            this.listaProdNiñosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaProdNiñosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaProdNiñosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaProdNiñosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaProdNiñosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaProdNiñosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaProdNiñosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaProdNiñosBindingNavigator.Name = "listaProdNiñosBindingNavigator";
            this.listaProdNiñosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaProdNiñosBindingNavigator.Size = new System.Drawing.Size(431, 25);
            this.listaProdNiñosBindingNavigator.TabIndex = 0;
            this.listaProdNiñosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaProdNiñosBindingNavigatorSaveItem
            // 
            this.listaProdNiñosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaProdNiñosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaProdNiñosBindingNavigatorSaveItem.Image")));
            this.listaProdNiñosBindingNavigatorSaveItem.Name = "listaProdNiñosBindingNavigatorSaveItem";
            this.listaProdNiñosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaProdNiñosBindingNavigatorSaveItem.Text = "Save Data";
            this.listaProdNiñosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaProdNiñosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProdNiñosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(125, 233);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProdNiñosBindingSource, "Codigo", true));
            this.CodigoTextBox.Location = new System.Drawing.Point(125, 54);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.ReadOnly = true;
            this.CodigoTextBox.Size = new System.Drawing.Size(180, 20);
            this.CodigoTextBox.TabIndex = 4;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProdNiñosBindingSource, "Descripcion", true));
            this.DescripcionTextBox.Location = new System.Drawing.Point(125, 91);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(180, 20);
            this.DescripcionTextBox.TabIndex = 6;
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProdNiñosBindingSource, "Existencia", true));
            this.ExistenciaTextBox.Location = new System.Drawing.Point(125, 197);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(180, 20);
            this.ExistenciaTextBox.TabIndex = 8;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProdNiñosBindingSource, "Precio", true));
            this.PrecioTextBox.Location = new System.Drawing.Point(125, 125);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(180, 20);
            this.PrecioTextBox.TabIndex = 10;
            // 
            // SeccionTextBox
            // 
            this.SeccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProdNiñosBindingSource, "Seccion", true));
            this.SeccionTextBox.Location = new System.Drawing.Point(125, 161);
            this.SeccionTextBox.Name = "SeccionTextBox";
            this.SeccionTextBox.Size = new System.Drawing.Size(180, 20);
            this.SeccionTextBox.TabIndex = 12;
            // 
            // listaProdNiñosBindingSource
            // 
            this.listaProdNiñosBindingSource.DataSource = typeof(BL.Ventas.NiñosBL);
            // 
            // FormNiños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 295);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(seccionLabel);
            this.Controls.Add(this.SeccionTextBox);
            this.Controls.Add(this.listaProdNiñosBindingNavigator);
            this.Name = "FormNiños";
            this.Text = "Niños";
            ((System.ComponentModel.ISupportInitialize)(this.listaProdNiñosBindingNavigator)).EndInit();
            this.listaProdNiñosBindingNavigator.ResumeLayout(false);
            this.listaProdNiñosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProdNiñosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaProdNiñosBindingSource;
        private System.Windows.Forms.BindingNavigator listaProdNiñosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaProdNiñosBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox SeccionTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}