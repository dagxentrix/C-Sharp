namespace Trening
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label øvelseLabel;
            System.Windows.Forms.Label persLabel;
            System.Windows.Forms.Label datoLabel;
            System.Windows.Forms.Label tidligereLabel;
            this.treningDataSet = new Trening.TreningDataSet();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treningTableAdapter = new Trening.TreningDataSetTableAdapters.TreningTableAdapter();
            this.tableAdapterManager = new Trening.TreningDataSetTableAdapters.TableAdapterManager();
            this.treningBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.treningBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.øvelseTextBox = new System.Windows.Forms.TextBox();
            this.persTextBox = new System.Windows.Forms.TextBox();
            this.datoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tidligereTextBox = new System.Windows.Forms.TextBox();
            øvelseLabel = new System.Windows.Forms.Label();
            persLabel = new System.Windows.Forms.Label();
            datoLabel = new System.Windows.Forms.Label();
            tidligereLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treningDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingNavigator)).BeginInit();
            this.treningBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // treningDataSet
            // 
            this.treningDataSet.DataSetName = "TreningDataSet";
            this.treningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataMember = "Trening";
            this.treningBindingSource.DataSource = this.treningDataSet;
            // 
            // treningTableAdapter
            // 
            this.treningTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TreningTableAdapter = this.treningTableAdapter;
            this.tableAdapterManager.UpdateOrder = Trening.TreningDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // treningBindingNavigator
            // 
            this.treningBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.treningBindingNavigator.BindingSource = this.treningBindingSource;
            this.treningBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.treningBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.treningBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.treningBindingNavigatorSaveItem});
            this.treningBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.treningBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.treningBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.treningBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.treningBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.treningBindingNavigator.Name = "treningBindingNavigator";
            this.treningBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.treningBindingNavigator.Size = new System.Drawing.Size(353, 25);
            this.treningBindingNavigator.TabIndex = 0;
            this.treningBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // treningBindingNavigatorSaveItem
            // 
            this.treningBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.treningBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("treningBindingNavigatorSaveItem.Image")));
            this.treningBindingNavigatorSaveItem.Name = "treningBindingNavigatorSaveItem";
            this.treningBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.treningBindingNavigatorSaveItem.Text = "Save Data";
            this.treningBindingNavigatorSaveItem.Click += new System.EventHandler(this.treningBindingNavigatorSaveItem_Click);
            // 
            // øvelseLabel
            // 
            øvelseLabel.AutoSize = true;
            øvelseLabel.Location = new System.Drawing.Point(77, 63);
            øvelseLabel.Name = "øvelseLabel";
            øvelseLabel.Size = new System.Drawing.Size(43, 13);
            øvelseLabel.TabIndex = 1;
            øvelseLabel.Text = "Øvelse:";
            // 
            // øvelseTextBox
            // 
            this.øvelseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "Øvelse", true));
            this.øvelseTextBox.Location = new System.Drawing.Point(133, 60);
            this.øvelseTextBox.Name = "øvelseTextBox";
            this.øvelseTextBox.Size = new System.Drawing.Size(200, 20);
            this.øvelseTextBox.TabIndex = 2;
            // 
            // persLabel
            // 
            persLabel.AutoSize = true;
            persLabel.Location = new System.Drawing.Point(77, 89);
            persLabel.Name = "persLabel";
            persLabel.Size = new System.Drawing.Size(31, 13);
            persLabel.TabIndex = 3;
            persLabel.Text = "Pers:";
            // 
            // persTextBox
            // 
            this.persTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "Pers", true));
            this.persTextBox.Location = new System.Drawing.Point(133, 86);
            this.persTextBox.Name = "persTextBox";
            this.persTextBox.Size = new System.Drawing.Size(200, 20);
            this.persTextBox.TabIndex = 4;
            // 
            // datoLabel
            // 
            datoLabel.AutoSize = true;
            datoLabel.Location = new System.Drawing.Point(77, 116);
            datoLabel.Name = "datoLabel";
            datoLabel.Size = new System.Drawing.Size(33, 13);
            datoLabel.TabIndex = 5;
            datoLabel.Text = "Dato:";
            // 
            // datoDateTimePicker
            // 
            this.datoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.treningBindingSource, "Dato", true));
            this.datoDateTimePicker.Location = new System.Drawing.Point(133, 112);
            this.datoDateTimePicker.Name = "datoDateTimePicker";
            this.datoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datoDateTimePicker.TabIndex = 6;
            // 
            // tidligereLabel
            // 
            tidligereLabel.AutoSize = true;
            tidligereLabel.Location = new System.Drawing.Point(77, 141);
            tidligereLabel.Name = "tidligereLabel";
            tidligereLabel.Size = new System.Drawing.Size(50, 13);
            tidligereLabel.TabIndex = 7;
            tidligereLabel.Text = "Tidligere:";
            // 
            // tidligereTextBox
            // 
            this.tidligereTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "Tidligere", true));
            this.tidligereTextBox.Location = new System.Drawing.Point(133, 138);
            this.tidligereTextBox.Name = "tidligereTextBox";
            this.tidligereTextBox.Size = new System.Drawing.Size(200, 20);
            this.tidligereTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(øvelseLabel);
            this.Controls.Add(this.øvelseTextBox);
            this.Controls.Add(persLabel);
            this.Controls.Add(this.persTextBox);
            this.Controls.Add(datoLabel);
            this.Controls.Add(this.datoDateTimePicker);
            this.Controls.Add(tidligereLabel);
            this.Controls.Add(this.tidligereTextBox);
            this.Controls.Add(this.treningBindingNavigator);
            this.Name = "Form1";
            this.Text = "TreningsLogg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treningDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingNavigator)).EndInit();
            this.treningBindingNavigator.ResumeLayout(false);
            this.treningBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreningDataSet treningDataSet;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private TreningDataSetTableAdapters.TreningTableAdapter treningTableAdapter;
        private TreningDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator treningBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton treningBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox øvelseTextBox;
        private System.Windows.Forms.TextBox persTextBox;
        private System.Windows.Forms.DateTimePicker datoDateTimePicker;
        private System.Windows.Forms.TextBox tidligereTextBox;
    }
}

