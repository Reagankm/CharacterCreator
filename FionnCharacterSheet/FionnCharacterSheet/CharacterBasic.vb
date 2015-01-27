Option Strict On

Public Class BaseStats

    'Declare variables
    Friend CharacterNameString As String
    Friend CharacterRaceString As String
    Friend CharacterCulture As String

    Private Sub SkillsFocusesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click

        Try


            If ConTextBox.Text <> "" Then
                If DexTextBox.Text <> "" Then
                    If IntTextBox.Text <> "" Then
                        If MagTextBox.Text <> "" Then
                            If PerTextBox.Text <> "" Then
                                If StrTextBox.Text <> "" Then
                                    If WilTextBox.Text <> "" Then
                                        If WisTextBox.Text <> "" Then
                                            'For TESTING: update mods with their new values
                                            Try

                                                If IsInteger(ConTextBox.Text) Then
                                                    'Declare variables
                                                    Dim ConScoreInteger As Integer = CInt(ConTextBox.Text)

                                                    ConModTextBox.Text = CStr(ConScoreInteger - 10)
                                                    HealthLabel.Text = CStr(ConScoreInteger * 2)
                                                Else
                                                    MessageBox.Show("You must enter an integer.", "Error")
                                                    ConTextBox.SelectAll()
                                                    ConTextBox.Focus()
                                                End If

                                            Catch ex As Exception
                                                MessageBox.Show("Unknown error in ConTextBox_Leave", "Error")
                                            End Try

                                            'When user finishes entering Dex score, update Dex mod

                                            Try
                                                If IsInteger(DexTextBox.Text) Then
                                                    DexModTextBox.Text = Str(CInt(DexTextBox.Text) - 10)
                                                Else
                                                    MessageBox.Show("You must enter an integer.", "Error")
                                                    DexTextBox.SelectAll()
                                                    DexTextBox.Focus()
                                                End If

                                            Catch ex As Exception
                                                MessageBox.Show("Unknown error in DexTextBox_Leave", "Error")
                                            End Try


                                            'When user finishes entering Int score, update Int mod
                                            Try
                                                If IsInteger(IntTextBox.Text) Then
                                                    IntModTextBox.Text = Str(CInt(IntTextBox.Text) - 10)
                                                Else
                                                    MessageBox.Show("You must enter an integer.", "Error")
                                                    IntTextBox.SelectAll()
                                                    IntTextBox.Focus()
                                                End If

                                            Catch ex As Exception
                                                MessageBox.Show("Unknown error in IntTextBox_Leave", "Error")
                                            End Try


                                            'When user finishes entering Mag score, update Mag mod
                                            Try
                                                If IsInteger(MagTextBox.Text) Then
                                                    MagModTextBox.Text = Str(CInt(MagTextBox.Text) - 10)
                                                Else
                                                    MessageBox.Show("You must enter an integer.", "Error")
                                                    MagTextBox.SelectAll()
                                                    MagTextBox.Focus()
                                                End If

                                            Catch ex As Exception
                                                MessageBox.Show("Unknown error in MagTextBox_Leave", "Error")
                                            End Try




                                            'When user finishes entering Per score, update Per mod
                                            Try
                                                If IsInteger(PerTextBox.Text) Then
                                                    PerModTextBox.Text = Str(CInt(PerTextBox.Text) - 10)

                                                Else
                                                    MessageBox.Show("You must enter an integer.", "Error")
                                                    PerTextBox.SelectAll()
                                                    PerTextBox.Focus()
                                                End If

                                            Catch ex As Exception
                                                MessageBox.Show("Unknown error in PerTextBox_Leave", "Error")
                                            End Try

                                            'When user finishes entering Str score, update Str mod
                                            Try
                                                If IsInteger(StrTextBox.Text) Then
                                                    StrModTextBox.Text = Str(CInt(StrTextBox.Text) - 10)

                                                Else
                                                    MessageBox.Show("You must enter an integer.", "Error")
                                                    StrTextBox.SelectAll()
                                                    StrTextBox.Focus()
                                                End If

                                            Catch ex As Exception
                                                MessageBox.Show("Unknown error in StrTextBox_Leave", "Error")
                                            End Try

                                            'When user finishes entering Will score, update Will mod
                                            Try
                                                If IsInteger(WilTextBox.Text) Then
                                                    WilModTextBox.Text = Str(CInt(WilTextBox.Text) - 10)

                                                Else
                                                    MessageBox.Show("You must enter an integer.", "Error")
                                                    WilTextBox.SelectAll()
                                                    WilTextBox.Focus()
                                                End If

                                            Catch ex As Exception
                                                MessageBox.Show("Unknown error in WilTextBox_Leave", "Error")
                                            End Try


                                            'When user finishes entering Wis score, update Wis mod
                                            Try
                                                If IsInteger(WisTextBox.Text) Then
                                                    WisModTextBox.Text = Str(CInt(WisTextBox.Text) - 10)

                                                Else
                                                    MessageBox.Show("You must enter an integer.", "Error")
                                                    WisTextBox.SelectAll()
                                                    WisTextBox.Focus()
                                                End If

                                            Catch ex As Exception
                                                MessageBox.Show("Unknown error in WisTextBox_Leave", "Error")
                                            End Try
                                            ' MessageBox.Show("Prepare thyself.")


                                            'Open Skills & Focuses Creation window
                                            SkillsFocuses.Show()
                                        Else
                                            MessageBox.Show("Please complete step one first.  (Fill in all Ability Scores before continuing.")
                                        End If
                                    Else
                                        MessageBox.Show("Please complete step one first.  (Fill in all Ability Scores before continuing.")
                                    End If
                                Else
                                    MessageBox.Show("Please complete step one first.  (Fill in all Ability Scores before continuing.")
                                End If
                            Else
                                MessageBox.Show("Please complete step one first.  (Fill in all Ability Scores before continuing.")
                            End If
                        Else
                            MessageBox.Show("Please complete step one first.  (Fill in all Ability Scores before continuing.")
                        End If
                    Else
                        MessageBox.Show("Please complete step one first.  (Fill in all Ability Scores before continuing.")
                    End If
                Else
                    MessageBox.Show("Please complete step one first.  (Fill in all Ability Scores before continuing.")
                End If
            Else
                MessageBox.Show("Please complete step one first.  (Fill in all Ability Scores before continuing.")
            End If
        Catch ex As Exception
            MessageBox.Show("Unknown error.", "Error")
        End Try
    End Sub

    Private Sub ConTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConTextBox.Leave

        'When user finishes entering Con score, update Con mod
        'and Health

        Try

            If IsInteger(ConTextBox.Text) Then
                'Declare variables
                Dim ConScoreInteger As Integer = CInt(ConTextBox.Text)

                ConModTextBox.Text = CStr(ConScoreInteger - 10)
                HealthLabel.Text = CStr(ConScoreInteger * 2)
            Else
                MessageBox.Show("You must enter an integer.", "Error")
                ConTextBox.SelectAll()
                ConTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Unknown error in ConTextBox_Leave", "Error")
        End Try

    End Sub

    Private Sub DexTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DexTextBox.Leave

        'When user finishes entering Dex score, update Dex mod

        Try
            If IsInteger(DexTextBox.Text) Then
                DexModTextBox.Text = Str(CInt(DexTextBox.Text) - 10)
            Else
                MessageBox.Show("You must enter an integer.", "Error")
                DexTextBox.SelectAll()
                DexTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Unknown error in DexTextBox_Leave", "Error")
        End Try


    End Sub

    Private Sub IntTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IntTextBox.Leave

        'When user finishes entering Int score, update Int mod
        Try
            If IsInteger(IntTextBox.Text) Then
                IntModTextBox.Text = Str(CInt(IntTextBox.Text) - 10)
            Else
                MessageBox.Show("You must enter an integer.", "Error")
                IntTextBox.SelectAll()
                IntTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Unknown error in IntTextBox_Leave", "Error")
        End Try


    End Sub

    Private Sub MagTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MagTextBox.Leave

        'When user finishes entering Mag score, update Mag mod
        Try
            If IsInteger(MagTextBox.Text) Then
                MagModTextBox.Text = Str(CInt(MagTextBox.Text) - 10)
            Else
                MessageBox.Show("You must enter an integer.", "Error")
                MagTextBox.SelectAll()
                MagTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Unknown error in MagTextBox_Leave", "Error")
        End Try



    End Sub

    Private Sub PerTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PerTextBox.Leave

        'When user finishes entering Per score, update Per mod
        Try
            If IsInteger(PerTextBox.Text) Then
                PerModTextBox.Text = Str(CInt(PerTextBox.Text) - 10)

            Else
                MessageBox.Show("You must enter an integer.", "Error")
                PerTextBox.SelectAll()
                PerTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Unknown error in PerTextBox_Leave", "Error")
        End Try
    End Sub

    Private Sub StrTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles StrTextBox.Leave

        'When user finishes entering Str score, update Str mod
        Try
            If IsInteger(StrTextBox.Text) Then
                StrModTextBox.Text = Str(CInt(StrTextBox.Text) - 10)

            Else
                MessageBox.Show("You must enter an integer.", "Error")
                StrTextBox.SelectAll()
                StrTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Unknown error in StrTextBox_Leave", "Error")
        End Try

    End Sub

    Private Sub WilTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles WilTextBox.Leave

        'When user finishes entering Will score, update Will mod
        Try
            If IsInteger(WilTextBox.Text) Then
                WilModTextBox.Text = Str(CInt(WilTextBox.Text) - 10)

            Else
                MessageBox.Show("You must enter an integer.", "Error")
                WilTextBox.SelectAll()
                WilTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Unknown error in WilTextBox_Leave", "Error")
        End Try

    End Sub

    Private Sub WisTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles WisTextBox.Leave

        'When user finishes entering Wis score, update Wis mod
        Try
            If IsInteger(WisTextBox.Text) Then
                WisModTextBox.Text = Str(CInt(WisTextBox.Text) - 10)

            Else
                MessageBox.Show("You must enter an integer.", "Error")
                WisTextBox.SelectAll()
                WisTextBox.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Unknown error in WisTextBox_Leave", "Error")
        End Try

    End Sub

    Private Sub PurchaseEquipmentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Open Add Equipment window
        Equipment.Show()

    End Sub
    Public Function IsInteger(ByVal arg As String) As Boolean
        If IsNumeric(arg) Then
            If arg.IndexOf(".") < 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub NewCharacter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Uncomment the lines below to autofill values for testing.  
        'Dim randomGen As Random = New Random(DateTime.Now.Millisecond)
        'CharacterNameTextBox.Text = "Test Case"
        'RaceComboBox.SelectedIndex = randomGen.Next(8)
        'CultureComboBox.SelectedIndex = randomGen.Next(17)
        'ConTextBox.Text = CStr(randomGen.Next(6, 17))
        'DexTextBox.Text = CStr(randomGen.Next(6, 17))
        'IntTextBox.Text = CStr(randomGen.Next(6, 17))
        'MagTextBox.Text = CStr(randomGen.Next(6, 17))
        'PerTextBox.Text = CStr(randomGen.Next(6, 17))
        'StrTextBox.Text = CStr(randomGen.Next(6, 17))
        'WilTextBox.Text = CStr(randomGen.Next(6, 17))
        'WisTextBox.Text = CStr(randomGen.Next(6, 17))
        'StaminaTextBox.Text = CStr(randomGen.Next(15, 30))
        'ManaTextBox.Text = CStr(randomGen.Next(10, 30))


    End Sub

End Class
