<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipment
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
        Me.EquipmentListBox = New System.Windows.Forms.ListBox
        Me.SubCategoryListBox = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AttackRollLabel = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DamageRollLabel = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DRLabel = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CombatDefBonusLabel = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.CombatDefPenaltyLabel = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.SkillCheckPenaltyLabel = New System.Windows.Forms.Label
        Me.BonusPenaltyGroupBox = New System.Windows.Forms.GroupBox
        Me.CombatDiceGroupBox = New System.Windows.Forms.GroupBox
        Me.AddButton = New System.Windows.Forms.Button
        Me.FinishedButton = New System.Windows.Forms.Button
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.AllRadioButton = New System.Windows.Forms.RadioButton
        Me.WeaponsRadioButton = New System.Windows.Forms.RadioButton
        Me.ArmorRadioButton = New System.Windows.Forms.RadioButton
        Me.OtherRadioButton = New System.Windows.Forms.RadioButton
        Me.InventoryListBox = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.WeightLabel = New System.Windows.Forms.Label
        Me.CostLabel = New System.Windows.Forms.Label
        Me.MaterialsListBox = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.BonusPenaltyGroupBox.SuspendLayout()
        Me.CombatDiceGroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'EquipmentListBox
        '
        Me.EquipmentListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipmentListBox.FormattingEnabled = True
        Me.EquipmentListBox.ItemHeight = 16
        Me.EquipmentListBox.Location = New System.Drawing.Point(12, 211)
        Me.EquipmentListBox.Name = "EquipmentListBox"
        Me.EquipmentListBox.Size = New System.Drawing.Size(220, 324)
        Me.EquipmentListBox.Sorted = True
        Me.EquipmentListBox.TabIndex = 4
        '
        'SubCategoryListBox
        '
        Me.SubCategoryListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubCategoryListBox.FormattingEnabled = True
        Me.SubCategoryListBox.ItemHeight = 16
        Me.SubCategoryListBox.Location = New System.Drawing.Point(12, 68)
        Me.SubCategoryListBox.Name = "SubCategoryListBox"
        Me.SubCategoryListBox.Size = New System.Drawing.Size(220, 116)
        Me.SubCategoryListBox.Sorted = True
        Me.SubCategoryListBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Attack Roll"
        '
        'AttackRollLabel
        '
        Me.AttackRollLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AttackRollLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttackRollLabel.Location = New System.Drawing.Point(117, 18)
        Me.AttackRollLabel.Name = "AttackRollLabel"
        Me.AttackRollLabel.Size = New System.Drawing.Size(127, 25)
        Me.AttackRollLabel.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Damage Roll"
        '
        'DamageRollLabel
        '
        Me.DamageRollLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DamageRollLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamageRollLabel.Location = New System.Drawing.Point(117, 43)
        Me.DamageRollLabel.Name = "DamageRollLabel"
        Me.DamageRollLabel.Size = New System.Drawing.Size(127, 25)
        Me.DamageRollLabel.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "DR"
        '
        'DRLabel
        '
        Me.DRLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DRLabel.Location = New System.Drawing.Point(13, 72)
        Me.DRLabel.Name = "DRLabel"
        Me.DRLabel.Size = New System.Drawing.Size(45, 25)
        Me.DRLabel.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(78, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 49)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Combat Defense Bonus"
        '
        'CombatDefBonusLabel
        '
        Me.CombatDefBonusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CombatDefBonusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombatDefBonusLabel.Location = New System.Drawing.Point(81, 72)
        Me.CombatDefBonusLabel.Name = "CombatDefBonusLabel"
        Me.CombatDefBonusLabel.Size = New System.Drawing.Size(45, 25)
        Me.CombatDefBonusLabel.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(146, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 49)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Combat Defense Penalty"
        '
        'CombatDefPenaltyLabel
        '
        Me.CombatDefPenaltyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CombatDefPenaltyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombatDefPenaltyLabel.Location = New System.Drawing.Point(149, 72)
        Me.CombatDefPenaltyLabel.Name = "CombatDefPenaltyLabel"
        Me.CombatDefPenaltyLabel.Size = New System.Drawing.Size(45, 25)
        Me.CombatDefPenaltyLabel.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(212, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 49)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Skill Check Penalty"
        '
        'SkillCheckPenaltyLabel
        '
        Me.SkillCheckPenaltyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SkillCheckPenaltyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkillCheckPenaltyLabel.Location = New System.Drawing.Point(217, 72)
        Me.SkillCheckPenaltyLabel.Name = "SkillCheckPenaltyLabel"
        Me.SkillCheckPenaltyLabel.Size = New System.Drawing.Size(45, 25)
        Me.SkillCheckPenaltyLabel.TabIndex = 9
        '
        'BonusPenaltyGroupBox
        '
        Me.BonusPenaltyGroupBox.Controls.Add(Me.CombatDefBonusLabel)
        Me.BonusPenaltyGroupBox.Controls.Add(Me.Label12)
        Me.BonusPenaltyGroupBox.Controls.Add(Me.DRLabel)
        Me.BonusPenaltyGroupBox.Controls.Add(Me.Label10)
        Me.BonusPenaltyGroupBox.Controls.Add(Me.CombatDefPenaltyLabel)
        Me.BonusPenaltyGroupBox.Controls.Add(Me.Label14)
        Me.BonusPenaltyGroupBox.Controls.Add(Me.Label16)
        Me.BonusPenaltyGroupBox.Controls.Add(Me.SkillCheckPenaltyLabel)
        Me.BonusPenaltyGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BonusPenaltyGroupBox.Location = New System.Drawing.Point(255, 169)
        Me.BonusPenaltyGroupBox.Name = "BonusPenaltyGroupBox"
        Me.BonusPenaltyGroupBox.Size = New System.Drawing.Size(277, 105)
        Me.BonusPenaltyGroupBox.TabIndex = 16
        Me.BonusPenaltyGroupBox.TabStop = False
        Me.BonusPenaltyGroupBox.Text = "Bonuses && Penalties"
        '
        'CombatDiceGroupBox
        '
        Me.CombatDiceGroupBox.Controls.Add(Me.AttackRollLabel)
        Me.CombatDiceGroupBox.Controls.Add(Me.Label1)
        Me.CombatDiceGroupBox.Controls.Add(Me.Label7)
        Me.CombatDiceGroupBox.Controls.Add(Me.DamageRollLabel)
        Me.CombatDiceGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombatDiceGroupBox.Location = New System.Drawing.Point(255, 291)
        Me.CombatDiceGroupBox.Name = "CombatDiceGroupBox"
        Me.CombatDiceGroupBox.Size = New System.Drawing.Size(277, 83)
        Me.CombatDiceGroupBox.TabIndex = 17
        Me.CombatDiceGroupBox.TabStop = False
        Me.CombatDiceGroupBox.Text = "Combat Dice"
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(15, 542)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(217, 35)
        Me.AddButton.TabIndex = 18
        Me.AddButton.Text = "Add to Inventory"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'FinishedButton
        '
        Me.FinishedButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinishedButton.Location = New System.Drawing.Point(675, 542)
        Me.FinishedButton.Name = "FinishedButton"
        Me.FinishedButton.Size = New System.Drawing.Size(87, 35)
        Me.FinishedButton.TabIndex = 19
        Me.FinishedButton.Text = "Done"
        Me.FinishedButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.Location = New System.Drawing.Point(555, 478)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(207, 35)
        Me.RemoveButton.TabIndex = 20
        Me.RemoveButton.Text = "Remove from Inventory"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'AllRadioButton
        '
        Me.AllRadioButton.AutoSize = True
        Me.AllRadioButton.Checked = True
        Me.AllRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllRadioButton.Location = New System.Drawing.Point(253, 12)
        Me.AllRadioButton.Name = "AllRadioButton"
        Me.AllRadioButton.Size = New System.Drawing.Size(41, 20)
        Me.AllRadioButton.TabIndex = 21
        Me.AllRadioButton.TabStop = True
        Me.AllRadioButton.Text = "All"
        Me.AllRadioButton.UseVisualStyleBackColor = True
        '
        'WeaponsRadioButton
        '
        Me.WeaponsRadioButton.AutoSize = True
        Me.WeaponsRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeaponsRadioButton.Location = New System.Drawing.Point(372, 12)
        Me.WeaponsRadioButton.Name = "WeaponsRadioButton"
        Me.WeaponsRadioButton.Size = New System.Drawing.Size(85, 20)
        Me.WeaponsRadioButton.TabIndex = 22
        Me.WeaponsRadioButton.Text = "Weapons"
        Me.WeaponsRadioButton.UseVisualStyleBackColor = True
        '
        'ArmorRadioButton
        '
        Me.ArmorRadioButton.AutoSize = True
        Me.ArmorRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArmorRadioButton.Location = New System.Drawing.Point(302, 12)
        Me.ArmorRadioButton.Name = "ArmorRadioButton"
        Me.ArmorRadioButton.Size = New System.Drawing.Size(62, 20)
        Me.ArmorRadioButton.TabIndex = 23
        Me.ArmorRadioButton.Text = "Armor"
        Me.ArmorRadioButton.UseVisualStyleBackColor = True
        '
        'OtherRadioButton
        '
        Me.OtherRadioButton.AutoSize = True
        Me.OtherRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherRadioButton.Location = New System.Drawing.Point(463, 12)
        Me.OtherRadioButton.Name = "OtherRadioButton"
        Me.OtherRadioButton.Size = New System.Drawing.Size(58, 20)
        Me.OtherRadioButton.TabIndex = 24
        Me.OtherRadioButton.Text = "Other"
        Me.OtherRadioButton.UseVisualStyleBackColor = True
        '
        'InventoryListBox
        '
        Me.InventoryListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryListBox.FormattingEnabled = True
        Me.InventoryListBox.ItemHeight = 16
        Me.InventoryListBox.Location = New System.Drawing.Point(555, 68)
        Me.InventoryListBox.Name = "InventoryListBox"
        Me.InventoryListBox.Size = New System.Drawing.Size(207, 404)
        Me.InventoryListBox.Sorted = True
        Me.InventoryListBox.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Available Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(595, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Your Inventory"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.WeightLabel)
        Me.GroupBox3.Controls.Add(Me.CostLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(255, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(277, 186)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item Details"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DescriptionTextBox.Location = New System.Drawing.Point(13, 76)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(253, 103)
        Me.DescriptionTextBox.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(174, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Weight (lb)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cost"
        '
        'WeightLabel
        '
        Me.WeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightLabel.Location = New System.Drawing.Point(156, 40)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(110, 25)
        Me.WeightLabel.TabIndex = 16
        '
        'CostLabel
        '
        Me.CostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostLabel.Location = New System.Drawing.Point(13, 40)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(137, 25)
        Me.CostLabel.TabIndex = 10
        '
        'MaterialsListBox
        '
        Me.MaterialsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialsListBox.FormattingEnabled = True
        Me.MaterialsListBox.ItemHeight = 16
        Me.MaterialsListBox.Location = New System.Drawing.Point(281, 68)
        Me.MaterialsListBox.Name = "MaterialsListBox"
        Me.MaterialsListBox.Size = New System.Drawing.Size(220, 84)
        Me.MaterialsListBox.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Special Materials"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Subcategories:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Equipment:"
        '
        'Equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(774, 585)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MaterialsListBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InventoryListBox)
        Me.Controls.Add(Me.OtherRadioButton)
        Me.Controls.Add(Me.ArmorRadioButton)
        Me.Controls.Add(Me.WeaponsRadioButton)
        Me.Controls.Add(Me.AllRadioButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.FinishedButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CombatDiceGroupBox)
        Me.Controls.Add(Me.BonusPenaltyGroupBox)
        Me.Controls.Add(Me.SubCategoryListBox)
        Me.Controls.Add(Me.EquipmentListBox)
        Me.Name = "Equipment"
        Me.Text = "AddEquipment"
        Me.BonusPenaltyGroupBox.ResumeLayout(False)
        Me.BonusPenaltyGroupBox.PerformLayout()
        Me.CombatDiceGroupBox.ResumeLayout(False)
        Me.CombatDiceGroupBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EquipmentListBox As System.Windows.Forms.ListBox
    Friend WithEvents SubCategoryListBox As System.Windows.Forms.ListBox
    Friend WithEvents DamageRollLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AttackRollLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DRLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CombatDefBonusLabel As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CombatDefPenaltyLabel As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SkillCheckPenaltyLabel As System.Windows.Forms.Label
    Friend WithEvents BonusPenaltyGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CombatDiceGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents FinishedButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents AllRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents WeaponsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ArmorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OtherRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents InventoryListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents WeightLabel As System.Windows.Forms.Label
    Friend WithEvents CostLabel As System.Windows.Forms.Label
    Friend WithEvents MaterialsListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
End Class
