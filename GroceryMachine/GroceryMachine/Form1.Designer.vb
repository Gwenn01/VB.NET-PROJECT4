<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblDisplay = New Label()
        txtAmount = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        nmcQuntity = New NumericUpDown()
        btnAdd = New Button()
        btnRemove = New Button()
        btnClear = New Button()
        Label3 = New Label()
        txtTotalAmount = New TextBox()
        Label4 = New Label()
        CType(nmcQuntity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblDisplay
        ' 
        lblDisplay.AutoSize = True
        lblDisplay.BackColor = SystemColors.HighlightText
        lblDisplay.BorderStyle = BorderStyle.FixedSingle
        lblDisplay.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        lblDisplay.Location = New Point(33, 54)
        lblDisplay.MaximumSize = New Size(400, 500)
        lblDisplay.MinimumSize = New Size(400, 500)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(400, 500)
        lblDisplay.TabIndex = 0
        lblDisplay.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        txtAmount.Location = New Point(619, 106)
        txtAmount.Margin = New Padding(3, 2, 3, 2)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(189, 37)
        txtAmount.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(439, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 32)
        Label1.TabIndex = 2
        Label1.Text = "Enter Amount"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(513, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 32)
        Label2.TabIndex = 3
        Label2.Text = "Quntity"
        ' 
        ' nmcQuntity
        ' 
        nmcQuntity.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        nmcQuntity.Location = New Point(619, 157)
        nmcQuntity.Margin = New Padding(3, 2, 3, 2)
        nmcQuntity.Name = "nmcQuntity"
        nmcQuntity.Size = New Size(76, 39)
        nmcQuntity.TabIndex = 4
        nmcQuntity.Tag = ""
        nmcQuntity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ActiveCaption
        btnAdd.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.Location = New Point(596, 205)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(173, 52)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = SystemColors.ActiveCaption
        btnRemove.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnRemove.Location = New Point(596, 274)
        btnRemove.Margin = New Padding(3, 2, 3, 2)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(173, 52)
        btnRemove.TabIndex = 6
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ActiveCaption
        btnClear.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.Location = New Point(561, 11)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(257, 52)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(163, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 32)
        Label3.TabIndex = 8
        Label3.Text = "Receipt"
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotalAmount.Location = New Point(219, 556)
        txtTotalAmount.Margin = New Padding(3, 2, 3, 2)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.Size = New Size(214, 45)
        txtTotalAmount.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(43, 564)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 32)
        Label4.TabIndex = 10
        Label4.Text = "Total Amount"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(924, 619)
        Controls.Add(Label4)
        Controls.Add(txtTotalAmount)
        Controls.Add(Label3)
        Controls.Add(btnClear)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(nmcQuntity)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAmount)
        Controls.Add(lblDisplay)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        CType(nmcQuntity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nmcQuntity As NumericUpDown
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label4 As Label
End Class
