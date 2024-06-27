Public Class Form1
    Dim Angka1, Angka2 As Single
    Dim operasi As String

    Private Sub txthasil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthasil.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("Masukkan Angka", "Peringatan")
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txthasil.Text = txthasil.Text + btn1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txthasil.Text = txthasil.Text + btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txthasil.Text = txthasil.Text + btn3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txthasil.Text = txthasil.Text + btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txthasil.Text = txthasil.Text + btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txthasil.Text = txthasil.Text + btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txthasil.Text = txthasil.Text + btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txthasil.Text = txthasil.Text + btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txthasil.Text = txthasil.Text + btn9.Text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txthasil.Text = txthasil.Text + btn0.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnsum.Click
        If txthasil.Text = "" Then Exit Sub
        Angka1 = CSng(txthasil.Text)
        operasi = "+"
        txthasil.Clear()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnkurang.Click
        If txthasil.Text = "" Then Exit Sub
        Angka1 = CSng(txthasil.Text)
        operasi = "-"
        txthasil.Clear()
    End Sub

    Private Sub btnkali_Click(sender As Object, e As EventArgs) Handles btnkali.Click
        If txthasil.Text = "" Then Exit Sub
        Angka1 = CSng(txthasil.Text)
        operasi = "*"
        txthasil.Clear()
    End Sub

    Private Sub btnbagi_Click(sender As Object, e As EventArgs) Handles btnbagi.Click
        If txthasil.Text = "" Then Exit Sub
        Angka1 = CSng(txthasil.Text)
        operasi = "/"
        txthasil.Clear()
    End Sub

    Private Sub btnsqry_Click(sender As Object, e As EventArgs)
        If txthasil.Text = "" Then Exit Sub
        Angka1 = CSng(txthasil.Text)
        operasi = "^"
        txthasil.Clear()
    End Sub

    Private Sub btnmodulus_Click(sender As Object, e As EventArgs) Handles btnmodulus.Click
        If txthasil.Text = "" Then Exit Sub
        Angka1 = CSng(txthasil.Text)
        operasi = "Mod"
        txthasil.Clear()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles btnequals.Click
        Dim hasil As Single
        Angka2 = CSng(txthasil.Text)
        Select Case operasi
            Case "+"
                hasil = Angka1 + Angka2
            Case "-"
                hasil = Angka1 - Angka2
            Case "*"
                hasil = Angka1 * Angka2
            Case "/"
                hasil = Angka1 / Angka2
            Case "^"
                hasil = Angka1 ^ Angka2
            Case "Mod"
                hasil = Angka1 Mod Angka2
        End Select
        txthasil.Text = hasil
    End Sub

    Private Sub btnpoint_Click(sender As Object, e As EventArgs) Handles btnpoint.Click
        txthasil.Text = txthasil.Text + btnpoint.Text
    End Sub

    Private Sub btnsqr2_Click(sender As Object, e As EventArgs) Handles btnsqr2.Click
        Dim hasil As Single
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Pow(Angka1, 2)
        txthasil.Text = hasil
    End Sub

    Private Sub btnsqr3_Click(sender As Object, e As EventArgs) Handles btnsqr3.Click
        Dim hasil As Single
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Pow(Angka1, 3)
        txthasil.Text = hasil
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles btnsqrt.Click
        Dim hasil As Single
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Sqrt(Angka1)
        txthasil.Text = hasil
    End Sub

    Private Sub btnpersen_Click(sender As Object, e As EventArgs) Handles btnpersen.Click
        Dim hasil As Single
        Angka1 = CSng(txthasil.Text)
        hasil = Angka1 / 100
        txthasil.Text = hasil
    End Sub

    Private Sub btntan_Click(sender As Object, e As EventArgs)
        Dim hasil As Single
        Dim phi As Single
        phi = 3.14159265
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Tan(Angka1 * (phi / 180))
        txthasil.Text = hasil
    End Sub

    Private Sub btncos_Click(sender As Object, e As EventArgs)
        Dim hasil As Single
        Dim phi As Single
        phi = 3.14159265
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Cos(Angka1 * (phi / 180))
        txthasil.Text = hasil
    End Sub

    Private Sub btnsin_Click(sender As Object, e As EventArgs)
        Dim hasil As Single
        Dim phi As Single
        phi = 3.14159265
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Sin(Angka1 * (phi / 180))
        txthasil.Text = hasil
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Dim hasil As Single
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Log10(Angka1)
        txthasil.Text = hasil
    End Sub

    Private Sub btntanh_Click(sender As Object, e As EventArgs) Handles btntanh.Click
        Dim hasil As Single
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Tanh(Angka1)
        txthasil.Text = hasil
    End Sub

    Private Sub btnconh_Click(sender As Object, e As EventArgs) Handles btncosh.Click
        Dim hasil As Single
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Cosh(Angka1)
        txthasil.Text = hasil
    End Sub

    Private Sub btnsinh_Click(sender As Object, e As EventArgs) Handles btnsinh.Click
        Dim hasil As Single
        Angka1 = CSng(txthasil.Text)
        hasil = Math.Sinh(Angka1)
        txthasil.Text = hasil
    End Sub

    Private Sub btntbhkrng_Click(sender As Object, e As EventArgs) Handles btntbhkrng.Click
        If txthasil.Text = "" Then Exit Sub
        If Val(txthasil.Text) > 0 Then
            txthasil.Text = Val(txthasil.Text) * -1
        Else
            txthasil.Text = Val(txthasil.Text) * -1
        End If
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        txthasil.Text = ""
    End Sub
    

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

End Class
