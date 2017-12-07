<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.updAddQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnEditQuantity = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updEditQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.updAddQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updEditQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(281, 123)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 30)
        Me.btnAddItem.TabIndex = 3
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Add an item"
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(206, 95)
        Me.txtItem.MaxLength = 24
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(150, 22)
        Me.txtItem.TabIndex = 1
        '
        'updAddQuantity
        '
        Me.updAddQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updAddQuantity.Location = New System.Drawing.Point(206, 123)
        Me.updAddQuantity.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.updAddQuantity.Name = "updAddQuantity"
        Me.updAddQuantity.Size = New System.Drawing.Size(50, 22)
        Me.updAddQuantity.TabIndex = 2
        Me.updAddQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(12, 12)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(120, 30)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.Location = New System.Drawing.Point(281, 291)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(75, 30)
        Me.btnRemoveItem.TabIndex = 18
        Me.btnRemoveItem.Text = "Remove"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'btnEditQuantity
        '
        Me.btnEditQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditQuantity.Location = New System.Drawing.Point(281, 204)
        Me.btnEditQuantity.Name = "btnEditQuantity"
        Me.btnEditQuantity.Size = New System.Drawing.Size(75, 30)
        Me.btnEditQuantity.TabIndex = 19
        Me.btnEditQuantity.Text = "Edit"
        Me.btnEditQuantity.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Edit selected item quantity"
        '
        'updEditQuantity
        '
        Me.updEditQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updEditQuantity.Location = New System.Drawing.Point(206, 204)
        Me.updEditQuantity.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.updEditQuantity.Name = "updEditQuantity"
        Me.updEditQuantity.Size = New System.Drawing.Size(50, 22)
        Me.updEditQuantity.TabIndex = 21
        Me.updEditQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(12, 57)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(175, 251)
        Me.lstItems.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Remove selected item"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(112, 314)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 30)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.updEditQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEditQuantity)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.updAddQuantity)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddItem)
        Me.Name = "frmItems"
        Me.Text = "frmItems"
        CType(Me.updAddQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updEditQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents updAddQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents btnEditQuantity As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents updEditQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
