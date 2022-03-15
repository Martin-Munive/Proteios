<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Target
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Target_Seq = New System.Windows.Forms.Label()
        Me.Txt_Target_Seq = New System.Windows.Forms.TextBox()
        Me.Btn_Filter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Target_Seq
        '
        Me.Lbl_Target_Seq.AutoSize = True
        Me.Lbl_Target_Seq.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Target_Seq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Lbl_Target_Seq.Location = New System.Drawing.Point(42, 12)
        Me.Lbl_Target_Seq.Name = "Lbl_Target_Seq"
        Me.Lbl_Target_Seq.Size = New System.Drawing.Size(123, 15)
        Me.Lbl_Target_Seq.TabIndex = 10
        Me.Lbl_Target_Seq.Text = "Target Sequence. XX"
        '
        'Txt_Target_Seq
        '
        Me.Txt_Target_Seq.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Txt_Target_Seq.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Target_Seq.ForeColor = System.Drawing.Color.Azure
        Me.Txt_Target_Seq.Location = New System.Drawing.Point(45, 31)
        Me.Txt_Target_Seq.Name = "Txt_Target_Seq"
        Me.Txt_Target_Seq.Size = New System.Drawing.Size(261, 22)
        Me.Txt_Target_Seq.TabIndex = 9
        '
        'Btn_Filter
        '
        Me.Btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Filter.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Filter.ForeColor = System.Drawing.Color.Azure
        Me.Btn_Filter.Location = New System.Drawing.Point(126, 65)
        Me.Btn_Filter.Name = "Btn_Filter"
        Me.Btn_Filter.Size = New System.Drawing.Size(102, 23)
        Me.Btn_Filter.TabIndex = 8
        Me.Btn_Filter.Text = "FILTER"
        Me.Btn_Filter.UseVisualStyleBackColor = True
        '
        'Frm_Target
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(349, 100)
        Me.Controls.Add(Me.Lbl_Target_Seq)
        Me.Controls.Add(Me.Txt_Target_Seq)
        Me.Controls.Add(Me.Btn_Filter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Target"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Target Sequence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Target_Seq As Label
    Friend WithEvents Txt_Target_Seq As TextBox
    Friend WithEvents Btn_Filter As Button
End Class
