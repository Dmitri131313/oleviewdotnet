﻿namespace OleViewDotNet
{
    partial class TypeLibControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnHeaderName;
            System.Windows.Forms.ColumnHeader columnHeaderGuid;
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewTypes = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGUIDCStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGIUDHexStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInterfaces = new System.Windows.Forms.TabPage();
            this.tabPageStructures = new System.Windows.Forms.TabPage();
            this.listViewStructures = new System.Windows.Forms.ListView();
            columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeaderGuid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageInterfaces.SuspendLayout();
            this.tabPageStructures.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 278;
            // 
            // columnHeaderGuid
            // 
            columnHeaderGuid.Text = "IID";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textEditor);
            this.splitContainer1.Size = new System.Drawing.Size(699, 418);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // listViewTypes
            // 
            this.listViewTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeaderName,
            columnHeaderGuid});
            this.listViewTypes.ContextMenuStrip = this.contextMenuStrip;
            this.listViewTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTypes.FullRowSelect = true;
            this.listViewTypes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTypes.Location = new System.Drawing.Point(3, 3);
            this.listViewTypes.Name = "listViewTypes";
            this.listViewTypes.Size = new System.Drawing.Size(280, 386);
            this.listViewTypes.TabIndex = 0;
            this.listViewTypes.UseCompatibleStateImageBehavior = false;
            this.listViewTypes.View = System.Windows.Forms.View.Details;
            this.listViewTypes.SelectedIndexChanged += new System.EventHandler(this.listViewTypes_SelectedIndexChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyGUIDToolStripMenuItem,
            this.copyGUIDCStructureToolStripMenuItem,
            this.copyGIUDHexStringToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(195, 92);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyGUIDToolStripMenuItem
            // 
            this.copyGUIDToolStripMenuItem.Name = "copyGUIDToolStripMenuItem";
            this.copyGUIDToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyGUIDToolStripMenuItem.Text = "Copy GUID";
            this.copyGUIDToolStripMenuItem.Click += new System.EventHandler(this.copyGUIDToolStripMenuItem_Click);
            // 
            // copyGUIDCStructureToolStripMenuItem
            // 
            this.copyGUIDCStructureToolStripMenuItem.Name = "copyGUIDCStructureToolStripMenuItem";
            this.copyGUIDCStructureToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyGUIDCStructureToolStripMenuItem.Text = "Copy GUID C Structure";
            this.copyGUIDCStructureToolStripMenuItem.Click += new System.EventHandler(this.copyGUIDCStructureToolStripMenuItem_Click);
            // 
            // copyGIUDHexStringToolStripMenuItem
            // 
            this.copyGIUDHexStringToolStripMenuItem.Name = "copyGIUDHexStringToolStripMenuItem";
            this.copyGIUDHexStringToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copyGIUDHexStringToolStripMenuItem.Text = "Copy GIUD Hex String";
            this.copyGIUDHexStringToolStripMenuItem.Click += new System.EventHandler(this.copyGIUDHexStringToolStripMenuItem_Click);
            // 
            // textEditor
            // 
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.IsReadOnly = false;
            this.textEditor.Location = new System.Drawing.Point(0, 0);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(401, 418);
            this.textEditor.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInterfaces);
            this.tabControl.Controls.Add(this.tabPageStructures);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(294, 418);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageInterfaces
            // 
            this.tabPageInterfaces.Controls.Add(this.listViewTypes);
            this.tabPageInterfaces.Location = new System.Drawing.Point(4, 22);
            this.tabPageInterfaces.Name = "tabPageInterfaces";
            this.tabPageInterfaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInterfaces.Size = new System.Drawing.Size(286, 392);
            this.tabPageInterfaces.TabIndex = 0;
            this.tabPageInterfaces.Text = "Interfaces";
            this.tabPageInterfaces.UseVisualStyleBackColor = true;
            // 
            // tabPageStructures
            // 
            this.tabPageStructures.Controls.Add(this.listViewStructures);
            this.tabPageStructures.Location = new System.Drawing.Point(4, 22);
            this.tabPageStructures.Name = "tabPageStructures";
            this.tabPageStructures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStructures.Size = new System.Drawing.Size(286, 392);
            this.tabPageStructures.TabIndex = 1;
            this.tabPageStructures.Text = "Structures";
            this.tabPageStructures.UseVisualStyleBackColor = true;
            // 
            // listViewStructures
            // 
            this.listViewStructures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1});
            this.listViewStructures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStructures.FullRowSelect = true;
            this.listViewStructures.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStructures.Location = new System.Drawing.Point(3, 3);
            this.listViewStructures.Name = "listViewStructures";
            this.listViewStructures.Size = new System.Drawing.Size(280, 386);
            this.listViewStructures.TabIndex = 1;
            this.listViewStructures.UseCompatibleStateImageBehavior = false;
            this.listViewStructures.View = System.Windows.Forms.View.Details;
            this.listViewStructures.SelectedIndexChanged += new System.EventHandler(this.listViewStructures_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 278;
            // 
            // TypeLibControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TypeLibControl";
            this.Size = new System.Drawing.Size(699, 418);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageInterfaces.ResumeLayout(false);
            this.tabPageStructures.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewTypes;
        private ICSharpCode.TextEditor.TextEditorControl textEditor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGUIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGUIDCStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGIUDHexStringToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInterfaces;
        private System.Windows.Forms.TabPage tabPageStructures;
        private System.Windows.Forms.ListView listViewStructures;
    }
}
