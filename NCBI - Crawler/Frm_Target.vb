Public Class Frm_Target
    Private Sub Btn_Filter_Click(sender As Object, e As EventArgs) Handles Btn_Filter.Click
        'Verificar que se escriba una secuencia.
        'Que no se deje vacio el textbox
        If Txt_Target_Seq.Text = "" Then
            MsgBox("Can't find a sequence to search!" _
                       & vbNewLine & " " & vbNewLine & "Write a valid Sequence.", MsgBoxStyle.Critical, "Somethin is wrong!")
        Else
            'Pasar el valor de la secuencia a la variable
            Secuencia_Target = Txt_Target_Seq.Text
            'Cerrar el formulario
            Me.Close()
        End If

    End Sub

    Private Sub Txt_Target_Seq_TextChanged(sender As Object, e As EventArgs) Handles Txt_Target_Seq.TextChanged

    End Sub
End Class