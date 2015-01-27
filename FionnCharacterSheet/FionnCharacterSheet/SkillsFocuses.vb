Option Strict On
Imports Microsoft.VisualBasic.FileIO

Public Class SkillsFocuses

    'Declare constants
    Friend Const RULES_FILE_NAME As String = "E:\Shared with Kilroy\SkillsFocuses.csv"
    Friend Const SCORES_AND_DICE_FILE_NAME As String = "E:\Shared with Kilroy\ScoresDiceAndRanks.csv"

    'Declare variables
    Dim SearchTextFieldParser As TextFieldParser
    Dim m_SelectedItemRow, m_SelectedSkillRow, CurrentFocusRow, SkillTwinRow, _
    FocusTwinRow As Integer
    Dim SkillTwinBoolean, FocusTwinBoolean As Boolean

    'Create an array to temporarily store character's skills and focus scores
    Friend Shared CharSkillAndFocusStringArray(239, 10) As String

    Private Sub SkillsFocusesCreation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' When form loads, create an array to store character-specific
        ' skill and focus data

        Try

            'Instantiate text field parser
            InstantiateTextFieldParser(RULES_FILE_NAME, SearchTextFieldParser)

            'Declare variables
            Dim InfoString As String()
            Dim m_rowCounter, m_ColumnCounter As Integer
            Dim Culture As String = "Cultural Knowledge: " + BaseStats.CultureComboBox.Text

            'Bypass header row
            SearchTextFieldParser.ReadFields()

            'Loop through data and store it in the CharacterSkillsAndFocuses array
            Do Until SearchTextFieldParser.EndOfData

                'Save current line of csv file to InfoString
                InfoString = SearchTextFieldParser.ReadFields()

                'Store data from InfoString into character array
                Do Until m_ColumnCounter > 10I
                    CharSkillAndFocusStringArray(m_rowCounter, m_ColumnCounter) = _
                        InfoString(m_ColumnCounter)
                    m_ColumnCounter += 1I
                Loop
                m_rowCounter += 1I
                m_ColumnCounter = 0I
                If m_rowCounter = 238 Then
                    Dim j As Integer = 19
                End If
            Loop

            'Characters start out trained in Cultural Knowledge                      
            'for their culture, so loop through character skills
            'array to find cust's culture and update status to 
            'trained
            m_rowCounter = -1
            Dim Current As String = ""
            Do
                m_rowCounter += 1I
                Current = StripParentheses(CharSkillAndFocusStringArray(m_rowCounter, 0))
            Loop Until Culture = Current
            'Mark this focus as Trained
            CharSkillAndFocusStringArray(m_rowCounter, 9) = "TRUE"
            'Mark this focus as a Starting Skill (so user can't "untrain" in it)
            CharSkillAndFocusStringArray(m_rowCounter, 5) = "TRUE"

            'TESTING: Uncomment the code below to randomly assign 70 skill points.  It takes 
            '4 points to train in a skill and 12 more points to specialize; it takes 2 points 
            'to train in a focus and 6 more to specialize. You have to be trained in a skill 
            'before you can train in its focus.
            'Dim SkillPoints As Integer = 70
            'Dim RandomNum As Random = New Random(DateTime.Now.Millisecond)
            'Dim SkillRow As Integer
            'Dim FocusRow As Integer
            'Do Until SkillPoints < 2
            '    Dim AssignPoints As Integer
            '    SkillsListBox.SelectedIndex = RandomNum.Next(28)
            '    SkillRow = FindItemInArray("Skill")
            '    'Get a random number from 1 to 4 and assign skill points accordingly.
            '    '1: Train in the skill 
            '    '2: Specialize in the skill (train first if needed)
            '    '3: Train in a random focus
            '    '4: Specialize in a random focus
            '    AssignPoints = RandomNum.Next(1, 4)
            '    If AssignPoints = 1 Then
            '        'If untrained in this skill
            '        If TrainCheckBox.Checked = False Then
            '            'If you have enough skill points
            '            If SkillPoints >= 4 Then
            '                'Become trained in it, update values, and subtract 4 skillpoints
            '                TrainCheckBox.Checked = True
            '                UpdateTraining(SkillRow, False)
            '                RefreshScores(SkillRow, False)
            '                SkillPoints -= 4
            '            End If
            '        End If
            '    ElseIf AssignPoints = 2 Then
            '        'If unspecialized in this skill
            '        If SpecializeCheckBox.Checked = False Then
            '            'If untrained and you have enough skill points 
            '            If TrainCheckBox.Checked = False And SkillPoints >= 18 Then
            '                'Become trained and specialized in it and update scores
            '                TrainCheckBox.Checked = True
            '                UpdateTraining(SkillRow, False)
            '                SpecializeCheckBox.Checked = True
            '                UpdateSpecialization(SkillRow, False)
            '                RefreshScores(SkillRow, False)
            '                SkillPoints -= 16
            '                'Else if you're already trained and have enough skill points
            '            ElseIf TrainCheckBox.Checked = True And SkillPoints >= 12 Then
            '                'Become specialized in it and update scores
            '                SpecializeCheckBox.Checked = True
            '                UpdateSpecialization(SkillRow, False)
            '                RefreshScores(SkillRow, False)
            '                SkillPoints -= 12
            '            End If
            '        End If
            '    Else
            '        'Choose a random focus
            '        FocusesListBox.SelectedIndex = RandomNum.Next(FocusesListBox.Items.Count)
            '        FocusRow = FindItemInArray("Focus")
            '        If AssignPoints = 3 Then
            '            'If untrained and you have enough skill points
            '            If TrainCheckBox.Checked = False And SkillPoints >= 2 Then
            '                'Become trained and subtract skill points
            '                TrainCheckBox.Checked = True
            '                UpdateTraining(FocusRow, False)
            '                RefreshScores(FocusRow, False)
            '                SkillPoints -= 2
            '            End If
            '        Else
            '            'If unspecialized
            '            If SpecializeCheckBox.Checked = False Then
            '                'If untrained and you have the skill points
            '                If TrainCheckBox.Checked = False And SkillPoints >= 8 Then
            '                    'Become trained and specialized and subtract skill points
            '                    TrainCheckBox.Checked = True
            '                    UpdateTraining(FocusRow, False)
            '                    SpecializeCheckBox.Checked = True
            '                    UpdateSpecialization(FocusRow, False)
            '                    RefreshScores(FocusRow, False)
            '                    SkillPoints -= 8
            '                    'Else if you're already trained and have the skill points
            '                ElseIf TrainCheckBox.Checked = True And SkillPoints >= 6 Then
            '                    'Become specialized and subtract skill points
            '                    SpecializeCheckBox.Checked = True
            '                    UpdateSpecialization(FocusRow, False)
            '                    RefreshScores(FocusRow, False)
            '                    SkillPoints -= 6
            '                End If
            '            End If
            '        End If
            '    End If


            'Loop

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try


    End Sub

    Private Sub SkillsListBox_SelectedIndexChanged(ByVal sender As Object, ByVal _
                    e As System.EventArgs) Handles SkillsListBox.SelectedIndexChanged

        Try
            'When the user selects a new skill, update the Focuses List Box and display
            'info about the current item in the Selected Item Group Box

            'Find selected skill in array
            m_SelectedSkillRow = FindItemInArray("Skill")

            'Save row number of currently selected item
            m_SelectedItemRow = m_SelectedSkillRow

            'Display currently selected item's details
            DisplayDetails(m_SelectedItemRow)
            UpdateFocuses(m_SelectedItemRow)

            'Check for twin skill and display and update its details as well
            SkillTwinRow = SkillHasTwin()
            SkillTwinBoolean = (SkillTwinRow >= 0)
            FocusTwinBoolean = False

            If SkillTwinBoolean Then
                'Widen window to display second skill
                'Me.Size = New System.Drawing.Size(541, 549)
                Me.Width = 1067
                'Display details
                DisplayTwinItemName(SkillTwinRow)
                DisplayTwinItemDescription(SkillTwinRow)
                DisplayTwinItemPenalty(SkillTwinRow)
                DisplayTwinItemTrainSpecStatus(SkillTwinRow)
                DisplayTwinItemDice(SkillTwinRow)

            Else
                Me.Width = 541
            End If


        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub
    Private Function FocusHasTwin() As Integer
        'Checks the focus immediately before and after the current ones to see
        'whether they are twins (the same skill with different ability mod emphasis)


        Dim PossibleTwin As String
        Dim CurrentFocus As String = StripParentheses(CharSkillAndFocusStringArray(m_SelectedItemRow, 0I))
        Dim Result As Integer = -1I
        Dim RowCounter As Integer = m_SelectedItemRow - 1I

        PossibleTwin = StripParentheses(CharSkillAndFocusStringArray(RowCounter, 0))

        'If the focus immediately prior is a twin, save its row number
        If PossibleTwin = CurrentFocus Then
            Result = RowCounter
        Else
            'Otherwise check the focus immediately after the selected one
            RowCounter = m_SelectedItemRow + 1I
            If RowCounter <= 239 Then
                PossibleTwin = StripParentheses(CharSkillAndFocusStringArray(RowCounter, 0))
                If PossibleTwin = CurrentFocus Then
                    Result = RowCounter
                End If

            End If
        End If

        Return Result

    End Function
    Private Function SkillHasTwin() As Integer
        'Checks the skill immediately before and after the current ones to see
        'whether they are twins (the same focus with different ability mod emphasis)

        Dim PossibleTwin As String = ""
        Dim CurrentSkill As String = StripParentheses(CharSkillAndFocusStringArray(m_SelectedSkillRow, 0I))
        Dim Result As Integer = -1I
        Dim RowCounter As Integer = m_SelectedSkillRow - 1I

        If RowCounter >= 0 Then

            Do Until CharSkillAndFocusStringArray(RowCounter, 1I) = "Skill"
                RowCounter -= 1I
            Loop

            PossibleTwin = StripParentheses(CharSkillAndFocusStringArray(RowCounter, 0))

        End If

        If PossibleTwin = CurrentSkill Then
            'If the skill prior to the selected one is a twin, save its row number
            Result = RowCounter
        Else
            'Otherwise check the skill immediately after the selected one
            RowCounter = m_SelectedSkillRow + 1I
            Do Until RowCounter > 239 OrElse _
            CharSkillAndFocusStringArray(RowCounter, 1I) = "Skill"
                RowCounter += 1I
            Loop

            If RowCounter <= 239 Then
                PossibleTwin = StripParentheses(CharSkillAndFocusStringArray(RowCounter, 0))
            End If

            If PossibleTwin = CurrentSkill Then
                Result = RowCounter
            End If
        End If



        Return Result

    End Function
    Private Sub DisplayDetails(ByVal RowInteger As Integer)

        DisplaySelectedItemName(RowInteger)
        DisplaySelectedItemDescription(RowInteger)
        DisplaySelectedItemPenalty(RowInteger)
        DisplaySelectedItemTrainSpecStatus(RowInteger)
        DisplaySelectedItemDice(RowInteger)

    End Sub



    Private Sub FocusesListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e _
                    As System.EventArgs) Handles FocusesListBox.SelectedIndexChanged
        Try

            'When the user selects a new focus, display info about the current
            'item in the Selected Item Group Box

            'Find selected focus in array
            m_SelectedItemRow = FindItemInArray("Focus")

            'Display currently selected item's details
            DisplayDetails(m_SelectedItemRow)

            'Check for twin focus and display and update its details as well
            FocusTwinRow = FocusHasTwin()
            FocusTwinBoolean = (FocusTwinRow >= 0)

            If FocusTwinBoolean Then
                'Widen window to display second focus
                'Me.Size = New System.Drawing.Size(541, 549)
                Me.Width = 1067
                'Display details
                DisplayTwinItemName(FocusTwinRow)
                DisplayTwinItemDescription(FocusTwinRow)
                DisplayTwinItemPenalty(FocusTwinRow)
                DisplayTwinItemTrainSpecStatus(FocusTwinRow)
                DisplayTwinItemDice(FocusTwinRow)

            Else
                Me.Width = 541
            End If


        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try


    End Sub

    Private Sub TrainCheckBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainCheckBox.Click

        Try

            'When the user selects or deselects the "Trained?" checkbox, 
            'update training status and ranks of currently selected item

            'Update Trained Boolean and Skill/Focus Ranks
            UpdateTraining(m_SelectedItemRow, False)

            'Repopulate affected fields
            RefreshScores(m_SelectedItemRow, False)

            'Find out if item has twin and, if so, refresh its scores too
            Dim SkillOrFocusString As String = CharSkillAndFocusStringArray(m_SelectedItemRow, 1)
            Dim TwinRowInteger As Integer
            If SkillOrFocusString = "Skill" Then
                TwinRowInteger = SkillHasTwin()
            Else
                TwinRowInteger = FocusHasTwin()
            End If

            If TwinRowInteger >= 0I Then
                RefreshScores(TwinRowInteger, True)
            End If

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub

    Private Sub SpecializeCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpecializeCheckBox.Click

        Try

            'When the user selects or deselects the "Specialized?" checkbox, 
            'update specialization status and ranks of currently selected item

            'Update Specialized Boolean and Skill/Focus Ranks
            UpdateSpecialization(m_SelectedItemRow, False)

            'Repopulate affected fields
            RefreshScores(m_SelectedItemRow, False)

            'Find out if item has twin and, if so, refresh its scores too
            Dim SkillOrFocusString As String = CharSkillAndFocusStringArray(m_SelectedItemRow, 1)
            Dim TwinRowInteger As Integer
            If SkillOrFocusString = "Skill" Then
                TwinRowInteger = SkillHasTwin()
            Else
                TwinRowInteger = FocusHasTwin()
            End If

            If TwinRowInteger >= 0I Then
                RefreshScores(TwinRowInteger, True)
            End If

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub
    Private Function StripParentheses(ByVal Name As String) As String

        Dim StrippedString As String = ""

        Try

            'Takes a string (the name of a skill or focus) and returns the name without
            'the ability parentheses at the end, allowing for easy comparison of names
            'with multiple versions (ie Martial Skill (Str) and Martial Skill (Dex))

            StrippedString += Name.Substring(0, Name.Length - 6)

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

        Return StrippedString
    End Function

    Private Function FindItemInArray(ByVal SkillOrFocus As String) As Integer

        Try
            'Declare variables
            Dim RowCounter As Integer
            Dim CurrentName As String
            Dim GoalString As String
            Dim Found As Boolean = False

            'Initialize starting row if it's not starting at 0
            If SkillOrFocus = "Focus" Then
                RowCounter = m_SelectedSkillRow + 1I
                GoalString = FocusesListBox.Text
            Else 'It's looking for a Skill
                GoalString = SkillsListBox.Text
                RowCounter = 0
            End If

            'Loop through data to find selected item
            Do Until Found OrElse _
            (SkillOrFocus = "Focus" And CharSkillAndFocusStringArray(RowCounter, 1) = "Skill") _
                                   OrElse (RowCounter = 240I)

                CurrentName = CharSkillAndFocusStringArray(RowCounter, 0)
                If CurrentName = GoalString Then
                    Found = True
                Else
                    RowCounter += 1I
                End If
            Loop

            'Return row number of selected item or -1
            'if focus was not found

            If Not Found Then
                RowCounter = -1I
            End If

            Return RowCounter

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Function
    Private Sub DisplaySelectedItemName(ByVal Row As Integer)
        'This subprocedure updates the form with the current skill or focus'
        'name

        Try
            SelectedItemGroupBox.Text = CharSkillAndFocusStringArray(Row, 0)
        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Sub
    Private Sub DisplayTwinItemName(ByVal Row As Integer)
        'This subprocedure updates the form with the current skill or focus'
        'name

        Try
            AltSelectedItemGroupBox.Text = CharSkillAndFocusStringArray(Row, 0)
        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Sub
    Private Sub DisplaySelectedItemDescription(ByVal Row As Integer)
        'This subprocedure updates the form with the current skill or focus'
        'description, including whether you must be trained to make checks
        'in it and whether you start out trained in it.

        Try

            Dim Description As String = ""
            Dim TrainingRequired, StartingSkill As Boolean

            'If training is required to use this skill or focus, include a sentence at the
            'start of the skill/focus description
            TrainingRequired = CBool(CharSkillAndFocusStringArray(Row, 4))
            If TrainingRequired Then
                Description &= "You must be trained in this to make any checks with it. "
            End If

            'If this skill or focus starts out as Trained, include a sentence at the start
            'of the skill/focus description
            StartingSkill = CBool(CharSkillAndFocusStringArray(Row, 5))
            If StartingSkill Then
                Description &= "Your character begins the game trained in this skill. "
            End If

            'Add any other description text from the array
            Description &= CharSkillAndFocusStringArray(Row, 6)

            'Display full description on the form
            SelectedItemDescriptionLabel.Text = Description
        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Sub
    Private Sub DisplayTwinItemDescription(ByVal Row As Integer)
        'This subprocedure updates the form with the current skill or focus'
        'description, including whether you must be trained to make checks
        'in it and whether you start out trained in it.

        Try

            'Display full description on the form
            AltSelectedItemDescriptionLabel.Text = SelectedItemDescriptionLabel.Text
        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Sub
    Private Sub DisplaySelectedItemPenalty(ByVal Row As Integer)
        'This subprocedure updates the form to display whether armor check
        'penalties apply when using this skill or focus

        Try

            Dim ArmorPenalty As Boolean = CBool(CharSkillAndFocusStringArray(Row, 3))
            Dim PenaltyString As String = ""

            If ArmorPenalty Then
                PenaltyString = "Armor &"
            Else
                PenaltyString = "No armor or"
            End If

            ArmorPenaltyLabel.Text = PenaltyString & " shield penalties apply to skill checks."
        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Sub
    Private Sub DisplayTwinItemPenalty(ByVal Row As Integer)
        'This subprocedure updates the form to display whether armor check
        'penalties apply when using this skill or focus

        Try

            AltArmorPenaltyLabel.Text = ArmorPenaltyLabel.Text

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Sub
    Private Sub DisplaySelectedItemTrainSpecStatus(ByVal Row As Integer)
        'This subprocedure updates the form to display whether the character is
        'trained or specialized in this skill/focus

        Try


            Dim Trained As Boolean = CBool(CharSkillAndFocusStringArray(Row, 9))
            Dim Specialized As Boolean = CBool(CharSkillAndFocusStringArray(Row, 10))
            Dim StartingSkill As Boolean = CBool(CharSkillAndFocusStringArray(Row, 5))

            'Adjust check boxes to reflect whether char is trained or specialized
            'in the selected skill
            With TrainCheckBox
                .Checked = Trained
                .Enabled = Not StartingSkill
            End With

            With SpecializeCheckBox
                .Checked = Specialized
                .Enabled = Trained
            End With

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try


    End Sub
    Private Sub DisplayTwinItemTrainSpecStatus(ByVal Row As Integer)
        'This subprocedure updates the form to display whether the character is
        'trained or specialized in this skill/focus

        Try


            Dim Trained As Boolean = CBool(CharSkillAndFocusStringArray(Row, 9))
            Dim Specialized As Boolean = CBool(CharSkillAndFocusStringArray(Row, 10))
            Dim StartingSkill As Boolean = CBool(CharSkillAndFocusStringArray(Row, 5))

            'Adjust check boxes to reflect whether char is trained or specialized
            'in the selected skill
            With AltTrainCheckBox
                .Checked = Trained
                .Enabled = Not StartingSkill
            End With

            With AltSpecializeCheckBox
                .Checked = Specialized
                .Enabled = Trained
            End With

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try


    End Sub
    Private Sub DisplaySelectedItemDice(ByVal Row As Integer)
        'Calculates and displays on the form the total number and types of dice
        'to roll when making skill/focus checks with currently selected skill/focus

        Try

            Dim AbilityMod, SkillRanks, FocusRanks, SelectedItemScore, CurrentScore As Integer
            Dim D10, ExplodingDice, Status, ScoreAverage, ItemMod As String
            Dim Trained As Boolean = CBool(CharSkillAndFocusStringArray(Row, 9))
            Dim InfoString() As String

            'The number of dice you roll when making a skill or focus check is based on 
            'that skill/focus' total score (a combination of its ability mod, total skill
            'ranks, and total focus ranks)
            AbilityMod = GetAbilityMod(CharSkillAndFocusStringArray(Row, 2))
            SkillRanks = CInt(CharSkillAndFocusStringArray(Row, 7))
            FocusRanks = CInt(CharSkillAndFocusStringArray(Row, 8))
            SelectedItemScore = AbilityMod + SkillRanks + FocusRanks

            'Instantiate text field parser
            InstantiateTextFieldParser(SCORES_AND_DICE_FILE_NAME, _
                                       SearchTextFieldParser)

            'Loop through Scores And Dice table to find the row of data with character's score
            'Begin before entering loop to bypass title row.
            InfoString = SearchTextFieldParser.ReadFields()
            Do
                InfoString = SearchTextFieldParser.ReadFields()
                CurrentScore = CInt(InfoString(0))
            Loop Until (CurrentScore = SelectedItemScore) Or SearchTextFieldParser.EndOfData

            'Update variables
            D10 = InfoString(1)
            ExplodingDice = InfoString(4)
            ItemMod = InfoString(2)
            ScoreAverage = InfoString(3)

            If Trained Then
                Status = InfoString(5)
            Else
                Status = "Uninitiated(0)"
            End If

            'Update form with this data
            StatusLabel.Text = Status
            ScoreAverageLabel.Text = ScoreAverage
            TotalModLabel.Text = ItemMod
            DiceLabel.Text = D10 + " of which " + ExplodingDice + " are Exploding."

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub
    Private Sub DisplayTwinItemDice(ByVal Row As Integer)
        'Calculates and displays on the form the total number and types of dice
        'to roll when making skill/focus checks with currently selected skill/focus

        Try

            Dim AbilityMod, SkillRanks, FocusRanks, SelectedItemScore, CurrentScore As Integer
            Dim D10, ExplodingDice, Status, ScoreAverage, ItemMod As String
            Dim Trained As Boolean = CBool(CharSkillAndFocusStringArray(Row, 9))
            Dim InfoString() As String

            'The number of dice you roll when making a skill or focus check is based on 
            'that skill/focus' total score (a combination of its ability mod, total skill
            'ranks, and total focus ranks)
            AbilityMod = GetAbilityMod(CharSkillAndFocusStringArray(Row, 2))
            SkillRanks = CInt(CharSkillAndFocusStringArray(Row, 7))
            FocusRanks = CInt(CharSkillAndFocusStringArray(Row, 8))
            SelectedItemScore = AbilityMod + SkillRanks + FocusRanks

            'Instantiate text field parser
            InstantiateTextFieldParser(SCORES_AND_DICE_FILE_NAME, _
                                       SearchTextFieldParser)

            'Loop through Scores And Dice table to find the row of data with character's score
            'Begin before entering loop to bypass title row.
            InfoString = SearchTextFieldParser.ReadFields()
            Do
                InfoString = SearchTextFieldParser.ReadFields()
                CurrentScore = CInt(InfoString(0))
            Loop Until (CurrentScore = SelectedItemScore) Or SearchTextFieldParser.EndOfData

            'Update variables
            D10 = InfoString(1)
            ExplodingDice = InfoString(4)
            ItemMod = InfoString(2)
            ScoreAverage = InfoString(3)

            If Trained Then
                Status = InfoString(5)
            Else
                Status = "Uninitiated(0)"
            End If

            'Update form with this data
            AltStatusLabel.Text = Status
            AltScoreAverageLabel.Text = ScoreAverage
            AltTotalModLabel.Text = ItemMod
            AltDiceLabel.Text = D10 + " of which " + ExplodingDice + " are Exploding."

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub

    Private Sub UpdateFocuses(ByVal StartingRow As Integer)

        Try

            'Declare variables
            Dim RowCounter As Integer = StartingRow
            Dim CurrentRowType As String
            Dim CurrentRowName As String

            'Clear any previous focuses
            FocusesListBox.Items.Clear()

            'Increment the row by one so it's on the first focus of the skill
            RowCounter += 1I
            CurrentRowType = CharSkillAndFocusStringArray(RowCounter, 1I)

            Do Until (RowCounter > 239) OrElse (CurrentRowType <> "Focus")

                CurrentRowName = CharSkillAndFocusStringArray(RowCounter, 0I)
                FocusesListBox.Items.Add(CurrentRowName)
                RowCounter += 1I
                If RowCounter <= 239 Then
                    CurrentRowType = CharSkillAndFocusStringArray(RowCounter, 1I)
                End If


            Loop

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub

    Friend Function GetAbilityMod(ByVal AbilityNameString As String) As Integer

        Try


            'Declare variables
            Dim ModInteger As Integer

            If AbilityNameString = "Con" Then
                ModInteger = CInt(BaseStats.ConModTextBox.Text)
            ElseIf AbilityNameString = "Dex" Then
                ModInteger = CInt(BaseStats.DexModTextBox.Text)
            ElseIf AbilityNameString = "Int" Then
                ModInteger = CInt(BaseStats.IntModTextBox.Text)
            ElseIf AbilityNameString = "Mag" Then
                ModInteger = CInt(BaseStats.MagModTextBox.Text)
            ElseIf AbilityNameString = "Per" Then
                ModInteger = CInt(BaseStats.PerModTextBox.Text)
            ElseIf AbilityNameString = "Str" Then
                ModInteger = CInt(BaseStats.StrModTextBox.Text)
            ElseIf AbilityNameString = "Wil" Then
                ModInteger = CInt(BaseStats.WilModTextBox.Text)
            ElseIf AbilityNameString = "Wis" Then
                ModInteger = CInt(BaseStats.WisModTextBox.Text)
            Else
                MessageBox.Show("Error in GetAbilityMod. AbilityNameString not understood.")
            End If

            'Return the relevant mod
            Return ModInteger
        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Function

    Private Sub InstantiateTextFieldParser(ByVal FileNameString As String, ByRef NewTextFieldParser As TextFieldParser)


        Try
            NewTextFieldParser = New TextFieldParser(FileNameString)
            NewTextFieldParser.TextFieldType = FieldType.Delimited
            NewTextFieldParser.SetDelimiters(",")
        Catch
            MessageBox.Show("Unable to read the file: " & FileNameString, "File Error")
        End Try

    End Sub
    Private Sub IncreaseSkillRank(ByVal RowInteger As Integer)

        'Increase skill rank for skill and its focuses
        Dim RowCountInteger = RowInteger

        Dim SkillRanksInteger As Integer = _
        CInt(CharSkillAndFocusStringArray(RowInteger, 7)) + 1I

        Do
            CharSkillAndFocusStringArray(RowCountInteger, 7) = CStr(SkillRanksInteger)
            RowCountInteger += 1I
        Loop Until (RowCountInteger > 239I) OrElse _
        (CharSkillAndFocusStringArray(RowCountInteger, 1) = "Skill")

    End Sub
    Private Sub IncreaseFocusRank(ByVal RowInteger As Integer)

        'Increase focus rank

        Dim FocusRanksInteger As Integer = _
        CInt(CharSkillAndFocusStringArray(RowInteger, 8)) + 1I

        CharSkillAndFocusStringArray(RowInteger, 8) = CStr(FocusRanksInteger)

    End Sub
    Private Sub DecreaseSkillRank(ByVal RowInteger As Integer)

        'Subtract one skill rank from selected item and its focuses
        Dim SkillRanksInteger As Integer = _
        CInt(CharSkillAndFocusStringArray(RowInteger, 7)) - 1I
        Dim RowCountInteger = RowInteger
        Do
            CharSkillAndFocusStringArray(RowCountInteger, 7) = CStr(SkillRanksInteger)
            RowCountInteger += 1I
        Loop Until (RowCountInteger > 239I) OrElse (CharSkillAndFocusStringArray(RowCountInteger, 1) = "Skill")

    End Sub
    Private Sub DecreaseFocusRank(ByVal RowInteger As Integer)

        'Subtract one focus rank from selected item
        Dim FocusRanksInteger As Integer = _
        CInt(CharSkillAndFocusStringArray(RowInteger, 8)) - 1I
        CharSkillAndFocusStringArray(RowInteger, 8) = CStr(FocusRanksInteger)


    End Sub
    Private Sub UpdateTraining(ByVal RowInteger As Integer, ByVal IsTwinBoolean As Boolean)
        Try
            '

            'Declare variables
            Dim SkillOrFocusString As String = CharSkillAndFocusStringArray(RowInteger, 1)
            Dim TrainedBoolean As Boolean
            Dim TwinRowInteger As Integer
            Dim HasTwinBoolean As Boolean

            'Find out whether selected skill or focus has a twin and save its
            'row number.  (If the item being manipulated already is a twin,
            'then its twin's row will be the SelectedItemRow.  Otherwise search
            'for the twin's row)
            If IsTwinBoolean Then
                TwinRowInteger = m_SelectedItemRow
            Else
                If SkillOrFocusString = "Skill" Then
                    TwinRowInteger = SkillHasTwin()
                Else
                    TwinRowInteger = FocusHasTwin()
                End If

            End If

            HasTwinBoolean = (TwinRowInteger >= 0I)

            'Update TrainedBoolean based on whether the TrainCheckBox or 
            'AltTrainCheckBox was changed and update values for twin checkbox
            '(No need to check if there is a twin because if there isn't one then
            'this change won't be visible and when one appears it will be overwritten)
            If IsTwinBoolean Then
                TrainedBoolean = AltTrainCheckBox.Checked
                TrainCheckBox.Checked = TrainedBoolean
            Else
                TrainedBoolean = TrainCheckBox.Checked
                AltTrainCheckBox.Checked = TrainedBoolean
            End If

            'Update the Boolean for the selected item and its twin
            CharSkillAndFocusStringArray(RowInteger, 9) = CStr(TrainedBoolean)

            If HasTwinBoolean Then
                CharSkillAndFocusStringArray(TwinRowInteger, 9) = CStr(TrainedBoolean)
            End If

            'Adjust ranks based on whether char is training or untraining
            If TrainedBoolean Then
                If SkillOrFocusString = "Skill" Then
                    IncreaseSkillRank(RowInteger)
                    If HasTwinBoolean Then
                        IncreaseSkillRank(TwinRowInteger)
                    End If
                Else 'this is a focus
                    IncreaseFocusRank(RowInteger)
                    If HasTwinBoolean Then
                        IncreaseFocusRank(TwinRowInteger)
                    End If
                End If

            Else 'Char is untraining 

                'Decrease ranks
                If SkillOrFocusString = "Skill" Then
                    DecreaseSkillRank(RowInteger)
                    If HasTwinBoolean Then
                        DecreaseSkillRank(TwinRowInteger)
                    End If
                Else 'this is a focus
                    DecreaseFocusRank(RowInteger)
                    If HasTwinBoolean Then
                        DecreaseFocusRank(TwinRowInteger)
                    End If
                End If

                'If char is specialized, remove specialization
                If (IsTwinBoolean And AltSpecializeCheckBox.Checked) Then
                    AltSpecializeCheckBox.Checked = False
                    SpecializeCheckBox.Checked = False
                    UpdateSpecialization(RowInteger, IsTwinBoolean)
                    'Because the "if" condition is talking about alt checkboxes
                    'then we know this item is a twin so its twin's specialization
                    'also needs to be updated
                    UpdateSpecialization(TwinRowInteger, Not IsTwinBoolean)

                ElseIf ((Not IsTwinBoolean) And SpecializeCheckBox.Checked) Then
                    SpecializeCheckBox.Checked = False
                    AltSpecializeCheckBox.Checked = False
                    UpdateSpecialization(RowInteger, IsTwinBoolean)
                    If HasTwinBoolean Then
                        UpdateSpecialization(TwinRowInteger, Not IsTwinBoolean)
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Sub

    Private Sub RefreshScores(ByVal RowInteger As Integer, ByVal TwinBoolean As Boolean)
        Try

            'Declare variables
            Dim ModInteger As Integer
            Dim ScoreInteger As Integer
            Dim SkillRanksInteger As Integer = CInt(CharSkillAndFocusStringArray(RowInteger, 7))
            Dim FocusRanksInteger As Integer = CInt(CharSkillAndFocusStringArray(RowInteger, 8))

            ModInteger = GetAbilityMod(CharSkillAndFocusStringArray(RowInteger, 2))
            ScoreInteger = ModInteger + SkillRanksInteger + FocusRanksInteger

            'Update data based on score 
            If TwinBoolean Then
                DisplayTwinItemDice(RowInteger)
            Else
                DisplaySelectedItemDice(RowInteger)
            End If

            'Lock/unlock the specialization checkboxes based
            'on whether char is trained
            SpecializeCheckBox.Enabled = TrainCheckBox.Checked
            AltSpecializeCheckBox.Enabled = AltTrainCheckBox.Checked


        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub

    Private Sub UpdateSpecialization(ByVal RowInteger As Integer, ByVal IsTwinBoolean As Boolean)
        Try

            'Declare variables
            Dim SkillOrFocusString As String = _
            CharSkillAndFocusStringArray(RowInteger, 1)
            Dim SpecializedBoolean As Boolean
            Dim TwinRowInteger As Integer
            Dim HasTwinBoolean As Boolean



            'Find out whether selected item has a twin. (If the item being manipulated 
            'already is a twin, then its twin's row will be the SelectedItemRow.
            'Otherwise search for the twin's row)
            If IsTwinBoolean Then
                TwinRowInteger = m_SelectedItemRow
            Else
                If SkillOrFocusString = "Skill" Then
                    TwinRowInteger = SkillHasTwin()
                Else
                    TwinRowInteger = FocusHasTwin()
                End If

            End If

            HasTwinBoolean = (TwinRowInteger >= 0I)

            'Update the Boolean
            If IsTwinBoolean Then
                SpecializedBoolean = AltSpecializeCheckBox.Checked
                SpecializeCheckBox.Checked = SpecializedBoolean

            Else
                SpecializedBoolean = SpecializeCheckBox.Checked
                AltSpecializeCheckBox.Checked = SpecializedBoolean

            End If

            CharSkillAndFocusStringArray(RowInteger, 10) = CStr(SpecializedBoolean)
            If HasTwinBoolean Then
                CharSkillAndFocusStringArray(TwinRowInteger, 10) = CStr(SpecializedBoolean)

            End If

            If SpecializedBoolean Then
                If SkillOrFocusString = "Skill" Then
                    IncreaseSkillRank(RowInteger)
                    If HasTwinBoolean Then
                        IncreaseSkillRank(TwinRowInteger)
                    End If
                Else
                    IncreaseFocusRank(RowInteger)
                    If HasTwinBoolean Then
                        IncreaseFocusRank(TwinRowInteger)
                    End If
                End If

            Else 'Char is un-specializing
                If SkillOrFocusString = "Skill" Then
                    DecreaseSkillRank(RowInteger)
                    If HasTwinBoolean Then
                        DecreaseSkillRank(TwinRowInteger)
                    End If
                Else
                    DecreaseFocusRank(RowInteger)
                    If HasTwinBoolean Then
                        DecreaseFocusRank(TwinRowInteger)
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub

    Private Sub DoneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoneButton.Click
        Try

            'Close the current window and open the equipment window
            Me.Close()

            Equipment.Show()

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try
    End Sub

    Private Sub AltTrainCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AltTrainCheckBox.Click
        Try

            'When the user selects or deselects the "Trained?" checkbox, 
            'update training status and ranks of currently selected item
            'and its twin if it has one

            'Update Trained Boolean and Skill/Focus Ranks
            Dim RowInteger As Integer
            If FocusTwinBoolean Then
                RowInteger = FocusTwinRow
            Else
                RowInteger = SkillTwinRow
            End If

            'Update training and refresh scores for item and its twin
            UpdateTraining(RowInteger, True)
            RefreshScores(RowInteger, True)
            RefreshScores(m_SelectedItemRow, False)


        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub


    Private Sub AltSpecializeCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AltSpecializeCheckBox.Click
        Try

            'When the user selects or deselects the "Specialized?" checkbox, 
            'update specialization status and ranks of currently selected item

            'Update Specialized Boolean and Skill/Focus Ranks
            Dim RowInteger As Integer
            If FocusTwinBoolean Then
                RowInteger = FocusTwinRow
            Else
                RowInteger = SkillTwinRow
            End If

            'Update ranks and refresh scores for item and its twin
            UpdateSpecialization(RowInteger, True)

            'Repopulate affected fields
            RefreshScores(RowInteger, True)
            RefreshScores(m_SelectedItemRow, False)

        Catch ex As Exception
            MessageBox.Show("There was an error!  Panic panic panic panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub
End Class



