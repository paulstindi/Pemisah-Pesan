'Created by : arifintindi
'email : arifintindi@gmail.com
Public Class frmPemisahPesan
    Dim pesan As String

    Private Sub PisahkanPesan()
        Dim pesan As String = txtPesanOringinal.Text
        Dim batasMaxKarakter As Integer = Convert.ToInt32(txtMaxKarater.Text)
        PemisahPesan.PisahkanPesan(pesan, 30)
        lsvDaftarPesan.Clear()

        '''AREA PERULANGAN INI DAPAT DISIMULASIKAN JUGA UNTUK MENGIRIM PESAN SECARA PARSIAL
        For i As Integer = 0 To PemisahPesan.DaftarPesan.Count - 1
            lsvDaftarPesan.Items.Add(PemisahPesan.DaftarPesan(i))
            'lsvDaftarPesan.Items.Add bisa digantikan dengan Gammu Send SMS
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PisahkanPesan()
    End Sub

    Private Sub txtPesanOringinal_TextChanged(sender As Object, e As EventArgs) Handles txtPesanOringinal.TextChanged
        lblKet.Text = "Total Karakter Terinput = " & txtPesanOringinal.Text.Length.ToString()
    End Sub
End Class
