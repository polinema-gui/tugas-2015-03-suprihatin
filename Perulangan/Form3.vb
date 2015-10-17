Public Class formtiga
    Dim pengecekan As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim bmatriks1 As Integer = TextBox1.Lines.Count
            Dim kmatriks1 As Integer = TextBox1.Lines.ElementAt(0).Split("  ").Length
            Dim bmatriks2 As Integer = TextBox1.Lines.Count
            Dim kmatriks2 As Integer = TextBox1.Lines.ElementAt(0).Split("  ").Length
            Dim cMatriks1(bmatriks1, kmatriks1) As Integer
            Dim cMatriks2(bmatriks2, kmatriks2) As Integer
            cek(bmatriks1, kmatriks1, bmatriks1, kmatriks1)
            copyToArray(bmatriks1, kmatriks1, bmatriks1, kmatriks1, cMatriks1, cMatriks2)
            Proses(cMatriks1, cMatriks2, bmatriks1, kmatriks2)
        Catch ex As Exception
            MessageBox("maaf masukan harus angka")
        End Try
    End Sub

    Private Sub cek(ByVal b1 As Integer, k1 As Integer, b2 As Integer, k2 As Integer)
        Dim a As Boolean = True
        For b = 0 To b1 - 2
            If (TextBox1.Lines.ElementAt(b).Split(" ").Length <> TextBox1.Lines.ElementAt(b + 1).Split(" ").Length) Then
                a = False
            End If
        Next
        For b = 0 To b2 - 2
            If (TextBox1.Lines.ElementAt(b).Split(" ").Length <> TextBox2.Lines.ElementAt(b + 1).Split(" ").Length) Then
                a = False
            End If
        Next
        If (a = False) Then
            Me.pengecekan = False
            Convert.ToInt32(TextBox1.Text)
            Convert.ToInt32(TextBox2.Text)
            MessageBox("masukan tidak valid")
        ElseIf (b1 = b2 And k1 = k2) Then
            Me.pengecekan = True
        Else
            Me.pengecekan = False
            MessageBox("baris dan kolom pada matriks harus sama")
        End If
    End Sub

    Private Sub copyToArray(bmatriks1 As Integer, kmatriks1 As Integer, bmatriks11 As Integer, kmatriks11 As Integer, p5 As Object, p6 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub Proses(ByVal cMatriks1 As Integer(,), cMatriks2 As Integer(,), bmatriks1 As Integer, kmatriks2 As Integer)
        Dim hasil As String = ""
        If (Me.pengecekan) Then
            Select Case 
        End If
    End Sub

    Private Sub MessageBox(p1 As String)
        Throw New NotImplementedException
    End Sub

End Class