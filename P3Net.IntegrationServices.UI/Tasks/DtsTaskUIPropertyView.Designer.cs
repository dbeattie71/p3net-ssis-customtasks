﻿namespace P3Net.IntegrationServices.UI.Tasks
{
    partial class DtsTaskUIPropertyView<T>
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.m_propertyGrid = new Microsoft.DataTransformationServices.Controls.LocalizablePropertyGrid();
            this.SuspendLayout();
            // 
            // m_propertyGrid
            // 
            this.m_propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.m_propertyGrid.Name = "m_propertyGrid";
            this.m_propertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.m_propertyGrid.Size = new System.Drawing.Size(150, 150);
            this.m_propertyGrid.TabIndex = 0;
            this.m_propertyGrid.ToolbarVisible = false;
            // 
            // DtsTaskUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_propertyGrid);
            this.Name = "DtsTaskUIView";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.DataTransformationServices.Controls.LocalizablePropertyGrid m_propertyGrid;
    }
}
