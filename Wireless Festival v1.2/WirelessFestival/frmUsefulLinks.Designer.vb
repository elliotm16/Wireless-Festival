﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsefulLinks
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
        Me.btnWebsite = New System.Windows.Forms.Button()
        Me.btnWikipedia = New System.Windows.Forms.Button()
        Me.btnFacebook = New System.Windows.Forms.Button()
        Me.btnTwitter = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWebsite
        '
        Me.btnWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWebsite.Location = New System.Drawing.Point(50, 140)
        Me.btnWebsite.Name = "btnWebsite"
        Me.btnWebsite.Size = New System.Drawing.Size(120, 30)
        Me.btnWebsite.TabIndex = 12
        Me.btnWebsite.Text = "Official Website"
        Me.btnWebsite.UseVisualStyleBackColor = True
        '
        'btnWikipedia
        '
        Me.btnWikipedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWikipedia.Location = New System.Drawing.Point(210, 140)
        Me.btnWikipedia.Name = "btnWikipedia"
        Me.btnWikipedia.Size = New System.Drawing.Size(120, 30)
        Me.btnWikipedia.TabIndex = 13
        Me.btnWikipedia.Text = "Wikipedia Page"
        Me.btnWikipedia.UseVisualStyleBackColor = True
        '
        'btnFacebook
        '
        Me.btnFacebook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacebook.Location = New System.Drawing.Point(50, 190)
        Me.btnFacebook.Name = "btnFacebook"
        Me.btnFacebook.Size = New System.Drawing.Size(120, 30)
        Me.btnFacebook.TabIndex = 14
        Me.btnFacebook.Text = "Facebook"
        Me.btnFacebook.UseVisualStyleBackColor = True
        '
        'btnTwitter
        '
        Me.btnTwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwitter.Location = New System.Drawing.Point(210, 190)
        Me.btnTwitter.Name = "btnTwitter"
        Me.btnTwitter.Size = New System.Drawing.Size(120, 30)
        Me.btnTwitter.TabIndex = 15
        Me.btnTwitter.Text = "Twitter"
        Me.btnTwitter.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(12, 12)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(120, 30)
        Me.btnReturn.TabIndex = 16
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmFurtherInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnTwitter)
        Me.Controls.Add(Me.btnFacebook)
        Me.Controls.Add(Me.btnWikipedia)
        Me.Controls.Add(Me.btnWebsite)
        Me.Name = "frmFurtherInfo"
        Me.Text = "frmFurtherInfo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnWebsite As System.Windows.Forms.Button
    Friend WithEvents btnWikipedia As System.Windows.Forms.Button
    Friend WithEvents btnFacebook As System.Windows.Forms.Button
    Friend WithEvents btnTwitter As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
End Class
