'Created by : arifintindi
'email : arifintindi@gmail.com
Module PemisahPesan
    Public DaftarPesan As New List(Of String)
    Public Sub PisahkanPesan(ByVal PesanOriginal As String, ByVal PanjangPesanMax As Integer)
        Dim katakata As List(Of String) = PesanOriginal.Split(" "c).ToList()

        If PesanOriginal.Length <= PanjangPesanMax Then
            DaftarPesan.Add(PesanOriginal)
        Else
            Dim tmpDaftarPesan As New List(Of String)
            Dim daftarPesanAktif As String = katakata(0)
            For i As Integer = 1 To katakata.Count - 1
                If (daftarPesanAktif & " " & katakata(i)).Length > PanjangPesanMax Then
                    tmpDaftarPesan.Add(daftarPesanAktif)
                    daftarPesanAktif = katakata(i)

                    If i = katakata.Count - 1 Then
                        tmpDaftarPesan.Add(daftarPesanAktif)
                    End If
                Else
                    If i = katakata.Count - 1 Then
                        tmpDaftarPesan.Add(daftarPesanAktif & " " & katakata(i))
                    End If
                    daftarPesanAktif &= " " & katakata(i)
                End If
            Next
            DaftarPesan = tmpDaftarPesan
        End If
    End Sub
End Module
