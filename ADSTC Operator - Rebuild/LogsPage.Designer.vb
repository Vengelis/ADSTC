<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogsPage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleColorBox = New System.Windows.Forms.PictureBox()
        Me.ExitLogs = New System.Windows.Forms.Button()
        Me.LogsListBox = New System.Windows.Forms.ListBox()
        Me.BoxSelectViewLogs = New System.Windows.Forms.ComboBox()
        CType(Me.TitleColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleColorBox
        '
        Me.TitleColorBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TitleColorBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleColorBox.Location = New System.Drawing.Point(0, 0)
        Me.TitleColorBox.Name = "TitleColorBox"
        Me.TitleColorBox.Size = New System.Drawing.Size(1014, 36)
        Me.TitleColorBox.TabIndex = 1
        Me.TitleColorBox.TabStop = False
        '
        'ExitLogs
        '
        Me.ExitLogs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitLogs.BackColor = System.Drawing.Color.Gainsboro
        Me.ExitLogs.FlatAppearance.BorderSize = 0
        Me.ExitLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitLogs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitLogs.Location = New System.Drawing.Point(896, 7)
        Me.ExitLogs.Name = "ExitLogs"
        Me.ExitLogs.Size = New System.Drawing.Size(111, 21)
        Me.ExitLogs.TabIndex = 157
        Me.ExitLogs.Text = "Retour menu"
        Me.ExitLogs.UseVisualStyleBackColor = False
        '
        'LogsListBox
        '
        Me.LogsListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogsListBox.FormattingEnabled = True
        Me.LogsListBox.ItemHeight = 16
        Me.LogsListBox.Location = New System.Drawing.Point(12, 42)
        Me.LogsListBox.Name = "LogsListBox"
        Me.LogsListBox.ScrollAlwaysVisible = True
        Me.LogsListBox.Size = New System.Drawing.Size(990, 468)
        Me.LogsListBox.TabIndex = 158
        '
        'BoxSelectViewLogs
        '
        Me.BoxSelectViewLogs.FormattingEnabled = True
        Me.BoxSelectViewLogs.Items.AddRange(New Object() {"Loader", "Home", "Licence", "Paramètres"})
        Me.BoxSelectViewLogs.Location = New System.Drawing.Point(734, 7)
        Me.BoxSelectViewLogs.Name = "BoxSelectViewLogs"
        Me.BoxSelectViewLogs.Size = New System.Drawing.Size(156, 21)
        Me.BoxSelectViewLogs.TabIndex = 159
        Me.BoxSelectViewLogs.Text = "Loader"
        '
        'LogsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1014, 532)
        Me.Controls.Add(Me.BoxSelectViewLogs)
        Me.Controls.Add(Me.LogsListBox)
        Me.Controls.Add(Me.ExitLogs)
        Me.Controls.Add(Me.TitleColorBox)
        Me.Name = "LogsPage"
        Me.Text = "Logs"
        CType(Me.TitleColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleColorBox As PictureBox
    Friend WithEvents ExitLogs As Button
    Friend WithEvents LogsListBox As ListBox
    Friend WithEvents BoxSelectViewLogs As ComboBox
End Class
