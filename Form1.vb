Public Class Form1

    Dim park As Integer = 13
    Dim status As String = "area"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_show.Text = park.ToString()
        'AddHandler car1.Click, AddressOf carClick
    End Sub

    'Private Sub carClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim car As PictureBox = CType(sender, PictureBox)
    'End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case (e.KeyCode)
            Case Keys.Up
                If status = "under_park" And car.Top > pic_exit.Top + pic_exit.Height Then
                    car.Top -= 10
                ElseIf status <> "under_park" And car.Top >= pic_entra.Top Then
                    car.Top -= 10
                End If


            Case Keys.Down
                If status = "in_park" And car.Top < 480 Then
                    car.Top += 10
                ElseIf status <> "in_park" And car.Top < 600 Then
                    car.Top += 10
                End If


            Case Keys.Left
                If status = "under_park" And car.Right < pic_exit.Left Then
                    status = "out_park"
                ElseIf status = "area" And car.Left < pic_entra.Right Then
                    status = "under_park"
                ElseIf car.Left > 0 Then
                    car.Image = car_left.Image
                    car.Left -= 10
                End If

                If car.Left = pic_entra.Right And car.Top + car.Height < pic_entra.Top + pic_entra.Height Then '車前壓到入口線的右邊
                    park -= 1
                    status = "in_park"
                    If park = 0 Then '當車位已滿
                        pic_stop.Visible = True
                    End If
                ElseIf car.Right = pic_exit.Left And car.Top + car.Height < pic_entra.Top + pic_entra.Height Then '車後壓到出口線的左邊
                    park += 1
                    status = "out_park"
                    If park > 0 Then '當有車位
                        pic_stop.Visible = False
                    End If
                End If


            Case Keys.Right
                If status = "area" And car.Right < Me.Width Then
                    car.Image = car_right.Image
                    car.Left += 10
                ElseIf status = "in_park" And car.Right < pic_entra.Left Then
                    car.Image = car_right.Image
                    car.Left += 10
                ElseIf status = "out_park" And car.Right < pic_exit.Left Then
                    car.Image = car_right.Image
                    car.Left += 10
                ElseIf status = "out_park" And car.Top > pic_exit.Top + pic_exit.Height Then
                    car.Image = car_right.Image
                    car.Left += 10
                    If car.Right > pic_exit.Left Then
                        status = "under_park"
                    End If
                ElseIf status = "under_park" Then
                    If car.Left > pic_entra.Right Then
                        status = "area"
                    Else
                        car.Image = car_right.Image
                        car.Left += 10
                    End If
                End If


            Case Keys.Enter


                If status = "in_park" Then


                    If car.Left > 720 And car.Right < 840 Then
                        If car.Top < 52 Then
                            If car5.Visible = False Then
                                car5.Image = car.Image
                                car5.Visible = True
                                'MessageBox.Show("")
                            Else
                                park += 1 '此停車格已經有車
                            End If
                            'ElseIf car.Top > 224 And car.Top + car.Height < 314 Then
                            '    park += 1 '沒停好會被趕出去
                        ElseIf car.Top > 447 Then
                            If car13.Visible = False Then
                                car13.Image = car.Image
                                car13.Visible = True
                            Else
                                park += 1
                            End If
                        Else
                            park += 1
                        End If

                    ElseIf car.Left > 594 And car.Right < 714 Then
                        If car.Top < 52 Then
                            If car4.Visible = False Then
                                car4.Image = car.Image
                                car4.Visible = True
                            Else
                                park += 1
                            End If
                        ElseIf car.Top > 224 And car.Top + car.Height < 314 Then
                            If car8.Visible = False Then
                                car8.Image = car.Image
                                car8.Visible = True
                            Else
                                park += 1
                            End If
                        ElseIf car.Top > 447 Then
                            If car12.Visible = False Then
                                car12.Image = car.Image
                                car12.Visible = True
                            Else
                                park += 1
                            End If
                        Else
                            park += 1
                        End If

                    ElseIf car.Left > 468 And car.Right < 588 Then
                        If car.Top < 52 Then
                            If car3.Visible = False Then
                                car3.Image = car.Image
                                car3.Visible = True
                            Else
                                park += 1
                            End If
                        ElseIf car.Top > 224 And car.Top + car.Height < 314 Then
                            If car7.Visible = False Then
                                car7.Image = car.Image
                                car7.Visible = True
                            Else
                                park += 1
                            End If
                        ElseIf car.Top > 447 Then
                            If car11.Visible = False Then
                                car11.Image = car.Image
                                car11.Visible = True
                            Else
                                park += 1
                            End If
                        Else
                            park += 1
                        End If

                    ElseIf car.Left > 342 And car.Right < 462 Then
                        If car.Top < 52 Then
                            If car2.Visible = False Then
                                car2.Image = car.Image
                                car2.Visible = True
                            Else
                                park += 1
                            End If
                        ElseIf car.Top > 224 And car.Top + car.Height < 314 Then
                            If car6.Visible = False Then
                                car6.Image = car.Image
                                car6.Visible = True
                            Else
                                park += 1
                            End If
                        ElseIf car.Top > 447 Then
                            If car10.Visible = False Then
                                car10.Image = car.Image
                                car10.Visible = True
                            Else
                                park += 1
                            End If
                        Else
                            park += 1
                        End If

                    ElseIf car.Left > 216 And car.Right < 336 Then
                        If car.Top < 52 Then
                            If car1.Visible = False Then
                                car1.Image = car.Image
                                car1.Visible = True
                            Else
                                park += 1
                            End If
                            'ElseIf car.Top > 224 And car.Top + car.Height < 314 Then
                            '    park += 1 '沒停好會被趕出去
                        ElseIf car.Top > 447 Then
                            If car9.Visible = False Then
                                car9.Image = car.Image
                                car9.Visible = True
                            Else
                                park += 1
                            End If
                        Else
                            park += 1
                        End If

                    Else
                        park += 1 '沒停好會被趕出去
                    End If
                End If

                If park = 0 Then '當車位已滿
                    car.Visible = False
                Else
                    pic_stop.Visible = False
                    car.Location = New Point(958, 243)
                    car.Image = car_left.Image
                    status = "area"
                End If

            Case Keys.Delete

                If status = "in_park" And park < 12 Then
                    car.Visible = False
                    park += 1
                    If park > 1 Then '當有車位
                        pic_stop.Visible = False
                    End If
                ElseIf status <> "in_park" And park < 13 Then
                    car.Visible = False
                End If

        End Select
        Label1.Text = status
        lbl_show.Text = park.ToString()
    End Sub

    Private Sub car1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car1.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car1.Location
        car.Image = car1.Image
        car.Visible = True
        car1.Visible = False
    End Sub

    Private Sub car2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car2.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car2.Location
        car.Image = car2.Image
        car.Visible = True
        car2.Visible = False
    End Sub

    Private Sub car3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car3.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car3.Location
        car.Image = car3.Image
        car.Visible = True
        car3.Visible = False
    End Sub

    Private Sub car4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car4.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car4.Location
        car.Image = car4.Image
        car.Visible = True
        car4.Visible = False
    End Sub

    Private Sub car5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car5.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car5.Location
        car.Image = car5.Image
        car.Visible = True
        car5.Visible = False
    End Sub

    Private Sub car6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car6.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car6.Location
        car.Image = car6.Image
        car.Visible = True
        car6.Visible = False
    End Sub

    Private Sub car7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car7.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car7.Location
        car.Image = car7.Image
        car.Visible = True
        car7.Visible = False
    End Sub

    Private Sub car8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car8.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car8.Location
        car.Image = car8.Image
        car.Visible = True
        car8.Visible = False
    End Sub

    Private Sub car9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car9.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car9.Location
        car.Image = car9.Image
        car.Visible = True
        car9.Visible = False
    End Sub

    Private Sub car10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car10.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car10.Location
        car.Image = car10.Image
        car.Visible = True
        car10.Visible = False
    End Sub

    Private Sub car11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car11.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car11.Location
        car.Image = car11.Image
        car.Visible = True
        car11.Visible = False
    End Sub

    Private Sub car12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car12.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car12.Location
        car.Image = car12.Image
        car.Visible = True
        car12.Visible = False
    End Sub

    Private Sub car13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car13.Click
        If status = "in_park" And park > 0 Then
            park += 1
            lbl_show.Text = park.ToString()
        End If
        status = "in_park"
        car.Location = car13.Location
        car.Image = car13.Image
        car.Visible = True
        car13.Visible = False
    End Sub


End Class
