Public Class formdua
    Dim hasil As String = " "

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Select Case ComboBox1.Text
                Case "Pyramid"
                    Pyramid(Convert.ToInt32(TextBox1.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(TextBox1.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(TextBox1.Text))
                Case "Hollow Inverted Pyramid"
                    hollowinvertedpyramid(Convert.ToInt32(TextBox1.Text))
                Case Else
                    TextBox2.Text = "pilihlah pola"
            End Select
        Catch ex As Exception
            TextBox2.Text = "masukkan pilihan"
        End Try
    End Sub

    Private Sub Pyramid(p1 As Integer)
        Dim kolom1 As Integer = p1
        Dim kolom2 As Integer = p1
        For baris As Integer = 1 To p1
            For kolom As Integer = 1 To p1 * 2 - 1
                If (kolom < kolom1 Or kolom > kolom2) Then
                    Me.hasil &= "  "
                Else
                    Me.hasil &= "*"
                End If
            Next
            kolom1 -= 1
            kolom2 += 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
        hasil = " "
    End Sub

    Private Sub hollowPyramid(p1 As Integer)
        Dim kolom1 As Integer = p1
        Dim kolom2 As Integer = p1
        For baris As Integer = 1 To p1
            For kolom As Integer = 1 To p1 * 2 - 1
                If (baris < p1) Then
                    If (kolom = kolom1 Or kolom = kolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            kolom1 -= 1
            kolom2 += 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
        hasil = ""
    End Sub

    Private Sub invertedPyramid(p1 As Integer)
        Dim kolom1 As Integer = 0
        Dim kolom2 As Integer = p1 * 2
        For baris As Integer = 1 To p1
            For kolom As Integer = 1 To p1 * 2 - 1
                If (kolom > kolom1 And kolom < kolom2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            kolom1 += 1
            kolom2 -= 1
        Next
        TextBox2.Text = hasil
        Me.hasil = " "
    End Sub

    Private Sub hollowinvertedpyramid(p1 As Integer)
        Dim kolom1 As Integer = 1
        Dim kolom2 As Integer = p1 * 2 - 1
        For baris As Integer = 1 To p1
            For kolom As Integer = 1 To p1 * 2 - 1
                If (baris = 1) Then
                    Me.hasil = "*"
                Else
                    If (kolom = kolom1 Or kolom = kolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            kolom1 += 1
            kolom2 -= 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
    End Sub
End Class