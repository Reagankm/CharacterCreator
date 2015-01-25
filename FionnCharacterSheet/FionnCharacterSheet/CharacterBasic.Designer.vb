<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseStats
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CharacterNameTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.RaceComboBox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CultureComboBox = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.WisModTextBox = New System.Windows.Forms.TextBox
        Me.WilModTextBox = New System.Windows.Forms.TextBox
        Me.StrModTextBox = New System.Windows.Forms.TextBox
        Me.PerModTextBox = New System.Windows.Forms.TextBox
        Me.MagModTextBox = New System.Windows.Forms.TextBox
        Me.IntModTextBox = New System.Windows.Forms.TextBox
        Me.DexModTextBox = New System.Windows.Forms.TextBox
        Me.ConModTextBox = New System.Windows.Forms.TextBox
        Me.WisTextBox = New System.Windows.Forms.TextBox
        Me.WilTextBox = New System.Windows.Forms.TextBox
        Me.StrTextBox = New System.Windows.Forms.TextBox
        Me.PerTextBox = New System.Windows.Forms.TextBox
        Me.MagTextBox = New System.Windows.Forms.TextBox
        Me.IntTextBox = New System.Windows.Forms.TextBox
        Me.DexTextBox = New System.Windows.Forms.TextBox
        Me.ConTextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.StaminaTextBox = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.ManaTextBox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.HealthLabel = New System.Windows.Forms.Label
        Me.NextButton = New System.Windows.Forms.Button
        Me.PlayerTextBox = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Character Name:"
        '
        'CharacterNameTextBox
        '
        Me.CharacterNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterNameTextBox.Location = New System.Drawing.Point(187, 56)
        Me.CharacterNameTextBox.Name = "CharacterNameTextBox"
        Me.CharacterNameTextBox.Size = New System.Drawing.Size(231, 22)
        Me.CharacterNameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Create a New Level One Character"
        '
        'RaceComboBox
        '
        Me.RaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RaceComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaceComboBox.FormattingEnabled = True
        Me.RaceComboBox.Items.AddRange(New Object() {"Avian", "Drakkon", "Dwarf", "Elf, Dark", "Elf", "Gnome", "Halfling", "Half-Elf", "Human"})
        Me.RaceComboBox.Location = New System.Drawing.Point(68, 124)
        Me.RaceComboBox.Name = "RaceComboBox"
        Me.RaceComboBox.Size = New System.Drawing.Size(121, 24)
        Me.RaceComboBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Race"
        '
        'CultureComboBox
        '
        Me.CultureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CultureComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CultureComboBox.FormattingEnabled = True
        Me.CultureComboBox.Items.AddRange(New Object() {"Avian", "Big City", "Dwarven", "Elven (Dark: Undersea)", "Elven (Star)", "Elven (Wood)", "Farming", "Gnome (Hill)", "Gnome (Forest)", "Halfling (Nomad)", "Halfling (Sedentary)", "Little Village", "Jalai", "Member of the Order", "Military", "Monastic", "Noble", "Rancher"})
        Me.CultureComboBox.Location = New System.Drawing.Point(278, 122)
        Me.CultureComboBox.Name = "CultureComboBox"
        Me.CultureComboBox.Size = New System.Drawing.Size(156, 24)
        Me.CultureComboBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(223, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Culture"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.WisModTextBox)
        Me.GroupBox1.Controls.Add(Me.WilModTextBox)
        Me.GroupBox1.Controls.Add(Me.StrModTextBox)
        Me.GroupBox1.Controls.Add(Me.PerModTextBox)
        Me.GroupBox1.Controls.Add(Me.MagModTextBox)
        Me.GroupBox1.Controls.Add(Me.IntModTextBox)
        Me.GroupBox1.Controls.Add(Me.DexModTextBox)
        Me.GroupBox1.Controls.Add(Me.ConModTextBox)
        Me.GroupBox1.Controls.Add(Me.WisTextBox)
        Me.GroupBox1.Controls.Add(Me.WilTextBox)
        Me.GroupBox1.Controls.Add(Me.StrTextBox)
        Me.GroupBox1.Controls.Add(Me.PerTextBox)
        Me.GroupBox1.Controls.Add(Me.MagTextBox)
        Me.GroupBox1.Controls.Add(Me.IntTextBox)
        Me.GroupBox1.Controls.Add(Me.DexTextBox)
        Me.GroupBox1.Controls.Add(Me.ConTextBox)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 266)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ability Scores"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(137, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 16)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Mod"
        '
        'WisModTextBox
        '
        Me.WisModTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.WisModTextBox.Enabled = False
        Me.WisModTextBox.Location = New System.Drawing.Point(140, 229)
        Me.WisModTextBox.Name = "WisModTextBox"
        Me.WisModTextBox.Size = New System.Drawing.Size(28, 22)
        Me.WisModTextBox.TabIndex = 23
        '
        'WilModTextBox
        '
        Me.WilModTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.WilModTextBox.Enabled = False
        Me.WilModTextBox.Location = New System.Drawing.Point(140, 202)
        Me.WilModTextBox.Name = "WilModTextBox"
        Me.WilModTextBox.Size = New System.Drawing.Size(28, 22)
        Me.WilModTextBox.TabIndex = 22
        '
        'StrModTextBox
        '
        Me.StrModTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StrModTextBox.Enabled = False
        Me.StrModTextBox.Location = New System.Drawing.Point(140, 175)
        Me.StrModTextBox.Name = "StrModTextBox"
        Me.StrModTextBox.Size = New System.Drawing.Size(28, 22)
        Me.StrModTextBox.TabIndex = 21
        '
        'PerModTextBox
        '
        Me.PerModTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PerModTextBox.Enabled = False
        Me.PerModTextBox.Location = New System.Drawing.Point(140, 148)
        Me.PerModTextBox.Name = "PerModTextBox"
        Me.PerModTextBox.Size = New System.Drawing.Size(28, 22)
        Me.PerModTextBox.TabIndex = 20
        '
        'MagModTextBox
        '
        Me.MagModTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MagModTextBox.Enabled = False
        Me.MagModTextBox.Location = New System.Drawing.Point(140, 121)
        Me.MagModTextBox.Name = "MagModTextBox"
        Me.MagModTextBox.Size = New System.Drawing.Size(28, 22)
        Me.MagModTextBox.TabIndex = 19
        '
        'IntModTextBox
        '
        Me.IntModTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IntModTextBox.Enabled = False
        Me.IntModTextBox.Location = New System.Drawing.Point(140, 94)
        Me.IntModTextBox.Name = "IntModTextBox"
        Me.IntModTextBox.Size = New System.Drawing.Size(28, 22)
        Me.IntModTextBox.TabIndex = 18
        '
        'DexModTextBox
        '
        Me.DexModTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DexModTextBox.Enabled = False
        Me.DexModTextBox.Location = New System.Drawing.Point(140, 67)
        Me.DexModTextBox.Name = "DexModTextBox"
        Me.DexModTextBox.Size = New System.Drawing.Size(28, 22)
        Me.DexModTextBox.TabIndex = 17
        '
        'ConModTextBox
        '
        Me.ConModTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ConModTextBox.Enabled = False
        Me.ConModTextBox.Location = New System.Drawing.Point(140, 40)
        Me.ConModTextBox.Name = "ConModTextBox"
        Me.ConModTextBox.Size = New System.Drawing.Size(28, 22)
        Me.ConModTextBox.TabIndex = 16
        '
        'WisTextBox
        '
        Me.WisTextBox.Location = New System.Drawing.Point(14, 229)
        Me.WisTextBox.Name = "WisTextBox"
        Me.WisTextBox.Size = New System.Drawing.Size(28, 22)
        Me.WisTextBox.TabIndex = 15
        '
        'WilTextBox
        '
        Me.WilTextBox.Location = New System.Drawing.Point(14, 202)
        Me.WilTextBox.Name = "WilTextBox"
        Me.WilTextBox.Size = New System.Drawing.Size(28, 22)
        Me.WilTextBox.TabIndex = 13
        '
        'StrTextBox
        '
        Me.StrTextBox.Location = New System.Drawing.Point(14, 175)
        Me.StrTextBox.Name = "StrTextBox"
        Me.StrTextBox.Size = New System.Drawing.Size(28, 22)
        Me.StrTextBox.TabIndex = 11
        '
        'PerTextBox
        '
        Me.PerTextBox.Location = New System.Drawing.Point(14, 148)
        Me.PerTextBox.Name = "PerTextBox"
        Me.PerTextBox.Size = New System.Drawing.Size(28, 22)
        Me.PerTextBox.TabIndex = 9
        '
        'MagTextBox
        '
        Me.MagTextBox.Location = New System.Drawing.Point(14, 121)
        Me.MagTextBox.Name = "MagTextBox"
        Me.MagTextBox.Size = New System.Drawing.Size(28, 22)
        Me.MagTextBox.TabIndex = 7
        '
        'IntTextBox
        '
        Me.IntTextBox.Location = New System.Drawing.Point(14, 94)
        Me.IntTextBox.Name = "IntTextBox"
        Me.IntTextBox.Size = New System.Drawing.Size(28, 22)
        Me.IntTextBox.TabIndex = 5
        '
        'DexTextBox
        '
        Me.DexTextBox.Location = New System.Drawing.Point(14, 67)
        Me.DexTextBox.Name = "DexTextBox"
        Me.DexTextBox.Size = New System.Drawing.Size(28, 22)
        Me.DexTextBox.TabIndex = 3
        '
        'ConTextBox
        '
        Me.ConTextBox.Location = New System.Drawing.Point(14, 40)
        Me.ConTextBox.Name = "ConTextBox"
        Me.ConTextBox.Size = New System.Drawing.Size(28, 22)
        Me.ConTextBox.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(48, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Wisdom"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Willpower"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Strength"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Persona"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Magic"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Intelligence"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Dexterity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Constitution"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(241, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Stamina"
        '
        'StaminaTextBox
        '
        Me.StaminaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaminaTextBox.Location = New System.Drawing.Point(303, 181)
        Me.StaminaTextBox.Name = "StaminaTextBox"
        Me.StaminaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StaminaTextBox.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(241, 219)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 16)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Health"
        '
        'ManaTextBox
        '
        Me.ManaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManaTextBox.Location = New System.Drawing.Point(303, 257)
        Me.ManaTextBox.Name = "ManaTextBox"
        Me.ManaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ManaTextBox.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(241, 257)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Mana"
        '
        'HealthLabel
        '
        Me.HealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HealthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthLabel.Location = New System.Drawing.Point(303, 219)
        Me.HealthLabel.Name = "HealthLabel"
        Me.HealthLabel.Size = New System.Drawing.Size(100, 23)
        Me.HealthLabel.TabIndex = 14
        '
        'NextButton
        '
        Me.NextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(275, 375)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(128, 43)
        Me.NextButton.TabIndex = 11
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PlayerTextBox
        '
        Me.PlayerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerTextBox.Location = New System.Drawing.Point(187, 84)
        Me.PlayerTextBox.Name = "PlayerTextBox"
        Me.PlayerTextBox.Size = New System.Drawing.Size(231, 22)
        Me.PlayerTextBox.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(65, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 16)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Player Name:"
        '
        'BaseStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 447)
        Me.Controls.Add(Me.PlayerTextBox)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.HealthLabel)
        Me.Controls.Add(Me.ManaTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.StaminaTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CultureComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RaceComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CharacterNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BaseStats"
        Me.Text = "Basic Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CharacterNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RaceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CultureComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MagTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IntTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents StaminaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ManaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents HealthLabel As System.Windows.Forms.Label
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents WisModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WilModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PerModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MagModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IntModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DexModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConModTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PlayerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
