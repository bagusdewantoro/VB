<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariables
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
        Me.txtVariables = New System.Windows.Forms.TextBox()
        Me.lblTransfer = New System.Windows.Forms.Label()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.cmdTransferToLabel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtVariables
        '
        Me.txtVariables.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVariables.Location = New System.Drawing.Point(65, 110)
        Me.txtVariables.Name = "txtVariables"
        Me.txtVariables.Size = New System.Drawing.Size(163, 27)
        Me.txtVariables.TabIndex = 0
        '
        'lblTransfer
        '
        Me.lblTransfer.AutoSize = True
        Me.lblTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransfer.Location = New System.Drawing.Point(61, 63)
        Me.lblTransfer.Name = "lblTransfer"
        Me.lblTransfer.Size = New System.Drawing.Size(125, 20)
        Me.lblTransfer.TabIndex = 1
        Me.lblTransfer.Text = "Label Caption"
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(65, 168)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(163, 23)
        Me.btnTransfer.TabIndex = 2
        Me.btnTransfer.Text = "Transfer to Text Box"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'cmdTransferToLabel
        '
        Me.cmdTransferToLabel.Location = New System.Drawing.Point(65, 214)
        Me.cmdTransferToLabel.Name = "cmdTransferToLabel"
        Me.cmdTransferToLabel.Size = New System.Drawing.Size(163, 23)
        Me.cmdTransferToLabel.TabIndex = 3
        Me.cmdTransferToLabel.Text = "Transfer To Label"
        Me.cmdTransferToLabel.UseVisualStyleBackColor = True
        '
        'frmVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdTransferToLabel)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.lblTransfer)
        Me.Controls.Add(Me.txtVariables)
        Me.Name = "frmVariables"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVariables As TextBox
    Friend WithEvents lblTransfer As Label
    Friend WithEvents btnTransfer As Button
    Friend WithEvents cmdTransferToLabel As Button
End Class
