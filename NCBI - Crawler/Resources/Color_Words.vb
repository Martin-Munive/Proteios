Module Color_Words
    Public Sub Color_Word(ByVal Rtb_Pagina_con As RichTextBox, ByVal Color As Color, ByVal Words As String)
        For i As Integer = 0 To Rtb_Pagina_con.TextLength
            Try
                If Rtb_Pagina_con.Text.ElementAt(i).ToString = Words.ElementAt(0).ToString Then
                    Dim found As Boolean = False
                    For j As Integer = 1 To Words.Count - 1
                        If Rtb_Pagina_con.Text.ElementAt(i + j) = Words.ElementAt(j) Then
                            found = True
                        Else
                            found = False
                            Exit For
                        End If
                    Next
                    If found = True Then
                        Rtb_Pagina_con.Select(i, Words.Length)
                        Rtb_Pagina_con.SelectionColor = Color.Azure
                    End If
                End If
            Catch ex As Exception
                Continue For
            End Try
        Next
    End Sub
End Module
