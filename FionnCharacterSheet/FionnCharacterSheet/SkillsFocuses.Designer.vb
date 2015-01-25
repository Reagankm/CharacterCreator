<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkillsFocuses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SkillsListBox = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FocusesListBox = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SelectedItemGroupBox = New System.Windows.Forms.GroupBox
        Me.ArmorPenaltyLabel = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DiceLabel = New System.Windows.Forms.Label
        Me.TotalModLabel = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ScoreAverageLabel = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SelectedItemDescriptionLabel = New System.Windows.Forms.Label
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SpecializeCheckBox = New System.Windows.Forms.CheckBox
        Me.TrainCheckBox = New System.Windows.Forms.CheckBox
        Me.DoneButton = New System.Windows.Forms.Button
        Me.AltSelectedItemGroupBox = New System.Windows.Forms.GroupBox
        Me.AltArmorPenaltyLabel = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.AltDiceLabel = New System.Windows.Forms.Label
        Me.AltTotalModLabel = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.AltScoreAverageLabel = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.AltSelectedItemDescriptionLabel = New System.Windows.Forms.Label
        Me.AltStatusLabel = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.AltSpecializeCheckBox = New System.Windows.Forms.CheckBox
        Me.AltTrainCheckBox = New System.Windows.Forms.CheckBox
        Me.SelectedItemGroupBox.SuspendLayout()
        Me.AltSelectedItemGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkillsListBox
        '
        Me.SkillsListBox.FormattingEnabled = True
        Me.SkillsListBox.ItemHeight = 16
        Me.SkillsListBox.Items.AddRange(New Object() {"Acrobatics (Dex)", "Arcane Magic (Mag)", "Armor (Str)", "Athletics (Str)", "Awareness (Wis)", "Clockwork (Int)", "Craft (Int)", "Cultural Lore (Wis)", "Divine Lore (Int)", "Fortitude (Con)", "Heavy Weapons (Str)", "History Lore (Int)", "Leadership (Per)", "Light Weapons (Dex)", "Magic Lore (Int)", "Martial Skill (Dex)", "Martial Skill (Str)", "Nature Lore (Int)", "Nature Magic (Mag)", "Perform (Per)", "Persuasion (Per)", "Planar Lore (Int)", "Planar Magic (Mag)", "Psionic Magic (Mag)", "Ranged Weapons (Dex)", "Resolve (Wil)", "Thievery (Dex)", "Treat Injury (Wis)", "Underground Lore (Int)"})
        Me.SkillsListBox.Location = New System.Drawing.Point(12, 38)
        Me.SkillsListBox.Name = "SkillsListBox"
        Me.SkillsListBox.Size = New System.Drawing.Size(167, 180)
        Me.SkillsListBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Skills"
        '
        'FocusesListBox
        '
        Me.FocusesListBox.FormattingEnabled = True
        Me.FocusesListBox.ItemHeight = 16
        Me.FocusesListBox.Location = New System.Drawing.Point(221, 38)
        Me.FocusesListBox.Name = "FocusesListBox"
        Me.FocusesListBox.Size = New System.Drawing.Size(294, 180)
        Me.FocusesListBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Focuses"
        '
        'SelectedItemGroupBox
        '
        Me.SelectedItemGroupBox.Controls.Add(Me.ArmorPenaltyLabel)
        Me.SelectedItemGroupBox.Controls.Add(Me.Label10)
        Me.SelectedItemGroupBox.Controls.Add(Me.DiceLabel)
        Me.SelectedItemGroupBox.Controls.Add(Me.TotalModLabel)
        Me.SelectedItemGroupBox.Controls.Add(Me.Label8)
        Me.SelectedItemGroupBox.Controls.Add(Me.ScoreAverageLabel)
        Me.SelectedItemGroupBox.Controls.Add(Me.Label6)
        Me.SelectedItemGroupBox.Controls.Add(Me.SelectedItemDescriptionLabel)
        Me.SelectedItemGroupBox.Controls.Add(Me.StatusLabel)
        Me.SelectedItemGroupBox.Controls.Add(Me.Label3)
        Me.SelectedItemGroupBox.Controls.Add(Me.SpecializeCheckBox)
        Me.SelectedItemGroupBox.Controls.Add(Me.TrainCheckBox)
        Me.SelectedItemGroupBox.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectedItemGroupBox.Location = New System.Drawing.Point(11, 237)
        Me.SelectedItemGroupBox.Name = "SelectedItemGroupBox"
        Me.SelectedItemGroupBox.Size = New System.Drawing.Size(504, 214)
        Me.SelectedItemGroupBox.TabIndex = 4
        Me.SelectedItemGroupBox.TabStop = False
        Me.SelectedItemGroupBox.Text = "Currently Selected Item"
        '
        'ArmorPenaltyLabel
        '
        Me.ArmorPenaltyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ArmorPenaltyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArmorPenaltyLabel.Location = New System.Drawing.Point(230, 161)
        Me.ArmorPenaltyLabel.Name = "ArmorPenaltyLabel"
        Me.ArmorPenaltyLabel.Size = New System.Drawing.Size(255, 37)
        Me.ArmorPenaltyLabel.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(296, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Dice:"
        '
        'DiceLabel
        '
        Me.DiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DiceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiceLabel.Location = New System.Drawing.Point(245, 40)
        Me.DiceLabel.Name = "DiceLabel"
        Me.DiceLabel.Size = New System.Drawing.Size(144, 43)
        Me.DiceLabel.TabIndex = 9
        '
        'TotalModLabel
        '
        Me.TotalModLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalModLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalModLabel.Location = New System.Drawing.Point(405, 40)
        Me.TotalModLabel.Name = "TotalModLabel"
        Me.TotalModLabel.Size = New System.Drawing.Size(64, 43)
        Me.TotalModLabel.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(402, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Mod: "
        '
        'ScoreAverageLabel
        '
        Me.ScoreAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScoreAverageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreAverageLabel.Location = New System.Drawing.Point(347, 132)
        Me.ScoreAverageLabel.Name = "ScoreAverageLabel"
        Me.ScoreAverageLabel.Size = New System.Drawing.Size(42, 16)
        Me.ScoreAverageLabel.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(225, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Score Average: "
        '
        'SelectedItemDescriptionLabel
        '
        Me.SelectedItemDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SelectedItemDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectedItemDescriptionLabel.Location = New System.Drawing.Point(6, 29)
        Me.SelectedItemDescriptionLabel.Name = "SelectedItemDescriptionLabel"
        Me.SelectedItemDescriptionLabel.Size = New System.Drawing.Size(213, 180)
        Me.SelectedItemDescriptionLabel.TabIndex = 4
        '
        'StatusLabel
        '
        Me.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(277, 105)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(112, 16)
        Me.StatusLabel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status: "
        '
        'SpecializeCheckBox
        '
        Me.SpecializeCheckBox.AutoSize = True
        Me.SpecializeCheckBox.Enabled = False
        Me.SpecializeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecializeCheckBox.Location = New System.Drawing.Point(405, 128)
        Me.SpecializeCheckBox.Name = "SpecializeCheckBox"
        Me.SpecializeCheckBox.Size = New System.Drawing.Size(97, 20)
        Me.SpecializeCheckBox.TabIndex = 1
        Me.SpecializeCheckBox.Text = "Specialize?"
        Me.SpecializeCheckBox.UseVisualStyleBackColor = True
        '
        'TrainCheckBox
        '
        Me.TrainCheckBox.AutoSize = True
        Me.TrainCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainCheckBox.Location = New System.Drawing.Point(405, 102)
        Me.TrainCheckBox.Name = "TrainCheckBox"
        Me.TrainCheckBox.Size = New System.Drawing.Size(65, 20)
        Me.TrainCheckBox.TabIndex = 0
        Me.TrainCheckBox.Text = "Train?"
        Me.TrainCheckBox.UseVisualStyleBackColor = True
        '
        'DoneButton
        '
        Me.DoneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneButton.Location = New System.Drawing.Point(128, 468)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(271, 31)
        Me.DoneButton.TabIndex = 5
        Me.DoneButton.Text = "Done Training in Skills and Focuses"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'AltSelectedItemGroupBox
        '
        Me.AltSelectedItemGroupBox.Controls.Add(Me.AltArmorPenaltyLabel)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.Label5)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.AltDiceLabel)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.AltTotalModLabel)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.Label11)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.AltScoreAverageLabel)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.Label13)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.AltSelectedItemDescriptionLabel)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.AltStatusLabel)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.Label16)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.AltSpecializeCheckBox)
        Me.AltSelectedItemGroupBox.Controls.Add(Me.AltTrainCheckBox)
        Me.AltSelectedItemGroupBox.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltSelectedItemGroupBox.Location = New System.Drawing.Point(533, 237)
        Me.AltSelectedItemGroupBox.Name = "AltSelectedItemGroupBox"
        Me.AltSelectedItemGroupBox.Size = New System.Drawing.Size(507, 214)
        Me.AltSelectedItemGroupBox.TabIndex = 12
        Me.AltSelectedItemGroupBox.TabStop = False
        Me.AltSelectedItemGroupBox.Text = "Currently Selected Item"
        '
        'AltArmorPenaltyLabel
        '
        Me.AltArmorPenaltyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AltArmorPenaltyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltArmorPenaltyLabel.Location = New System.Drawing.Point(230, 161)
        Me.AltArmorPenaltyLabel.Name = "AltArmorPenaltyLabel"
        Me.AltArmorPenaltyLabel.Size = New System.Drawing.Size(255, 37)
        Me.AltArmorPenaltyLabel.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dice:"
        '
        'AltDiceLabel
        '
        Me.AltDiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AltDiceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltDiceLabel.Location = New System.Drawing.Point(245, 40)
        Me.AltDiceLabel.Name = "AltDiceLabel"
        Me.AltDiceLabel.Size = New System.Drawing.Size(144, 43)
        Me.AltDiceLabel.TabIndex = 9
        '
        'AltTotalModLabel
        '
        Me.AltTotalModLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AltTotalModLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltTotalModLabel.Location = New System.Drawing.Point(405, 40)
        Me.AltTotalModLabel.Name = "AltTotalModLabel"
        Me.AltTotalModLabel.Size = New System.Drawing.Size(64, 43)
        Me.AltTotalModLabel.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(402, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Total Mod: "
        '
        'AltScoreAverageLabel
        '
        Me.AltScoreAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AltScoreAverageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltScoreAverageLabel.Location = New System.Drawing.Point(347, 132)
        Me.AltScoreAverageLabel.Name = "AltScoreAverageLabel"
        Me.AltScoreAverageLabel.Size = New System.Drawing.Size(42, 16)
        Me.AltScoreAverageLabel.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(225, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Score Average: "
        '
        'AltSelectedItemDescriptionLabel
        '
        Me.AltSelectedItemDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AltSelectedItemDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltSelectedItemDescriptionLabel.Location = New System.Drawing.Point(6, 29)
        Me.AltSelectedItemDescriptionLabel.Name = "AltSelectedItemDescriptionLabel"
        Me.AltSelectedItemDescriptionLabel.Size = New System.Drawing.Size(213, 180)
        Me.AltSelectedItemDescriptionLabel.TabIndex = 4
        '
        'AltStatusLabel
        '
        Me.AltStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AltStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltStatusLabel.Location = New System.Drawing.Point(277, 105)
        Me.AltStatusLabel.Name = "AltStatusLabel"
        Me.AltStatusLabel.Size = New System.Drawing.Size(112, 16)
        Me.AltStatusLabel.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(225, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 16)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Status: "
        '
        'AltSpecializeCheckBox
        '
        Me.AltSpecializeCheckBox.AutoSize = True
        Me.AltSpecializeCheckBox.Enabled = False
        Me.AltSpecializeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltSpecializeCheckBox.Location = New System.Drawing.Point(405, 128)
        Me.AltSpecializeCheckBox.Name = "AltSpecializeCheckBox"
        Me.AltSpecializeCheckBox.Size = New System.Drawing.Size(97, 20)
        Me.AltSpecializeCheckBox.TabIndex = 1
        Me.AltSpecializeCheckBox.Text = "Specialize?"
        Me.AltSpecializeCheckBox.UseVisualStyleBackColor = True
        '
        'AltTrainCheckBox
        '
        Me.AltTrainCheckBox.AutoSize = True
        Me.AltTrainCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltTrainCheckBox.Location = New System.Drawing.Point(405, 102)
        Me.AltTrainCheckBox.Name = "AltTrainCheckBox"
        Me.AltTrainCheckBox.Size = New System.Drawing.Size(65, 20)
        Me.AltTrainCheckBox.TabIndex = 0
        Me.AltTrainCheckBox.Text = "Train?"
        Me.AltTrainCheckBox.UseVisualStyleBackColor = True
        '
        'SkillsFocusesCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(525, 511)
        Me.Controls.Add(Me.AltSelectedItemGroupBox)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.SelectedItemGroupBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FocusesListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SkillsListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SkillsFocusesCreation"
        Me.Text = "SkillsFocuses"
        Me.SelectedItemGroupBox.ResumeLayout(False)
        Me.SelectedItemGroupBox.PerformLayout()
        Me.AltSelectedItemGroupBox.ResumeLayout(False)
        Me.AltSelectedItemGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SkillsListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FocusesListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelectedItemGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SpecializeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TrainCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ScoreAverageLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SelectedItemDescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DiceLabel As System.Windows.Forms.Label
    Friend WithEvents TotalModLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ArmorPenaltyLabel As System.Windows.Forms.Label
    Friend WithEvents DoneButton As System.Windows.Forms.Button
    Friend WithEvents AltSelectedItemGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AltArmorPenaltyLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AltDiceLabel As System.Windows.Forms.Label
    Friend WithEvents AltTotalModLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AltScoreAverageLabel As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents AltSelectedItemDescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents AltStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents AltSpecializeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AltTrainCheckBox As System.Windows.Forms.CheckBox
End Class
