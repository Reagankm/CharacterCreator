Option Strict On
Imports Microsoft.VisualBasic.FileIO
Public Class Equipment

    'Declare constants
    Const WEAPONS_FILE_NAME_String As String = "E:\Shared with Kilroy\Weapons.csv"
    Const ARMOR_FILE_NAME_String As String = "E:\Shared with Kilroy\Armor.csv"
    Friend Const ITEMS_FILE_NAME_String As String = "E:\Shared with Kilroy\Items.csv"
    Friend Const INVENTORY_FILE_NAME_String As String = "E:\Shared with Kilroy\Inventory.csv"

    'Declare variables
    Dim m_OwnedItemsCounterInteger As Integer
    Dim SearchTextFieldParser As TextFieldParser
    Dim SelectedItemCategoryFlag As String

    'Create an array to store owned equipment
    Friend ArrayOfOwnedItems(499) As EquipmentClass

    Private Sub InstantiateTextFieldParser(ByVal FileNameString As String, ByRef NewTextFieldParser As TextFieldParser)

        Try
            NewTextFieldParser = New TextFieldParser(FileNameString)
            NewTextFieldParser.TextFieldType = FieldType.Delimited
            NewTextFieldParser.SetDelimiters(",")
        Catch
            MessageBox.Show("Unable to read the file: " & FileNameString, "File Error")
        End Try

    End Sub

    Private Sub AddEquipment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'When form loads, populate subcategory and equipment
        'list boxes and load any pre-existing inventory items
        Try

            'Determine whether Inventory.csv exists and whether it contains any data to load
            'If it does, then load data
            Try
                Dim InfoString() As String
                InstantiateTextFieldParser(INVENTORY_FILE_NAME_String, SearchTextFieldParser)

                'Read fields twice to bypass title line
                InfoString = SearchTextFieldParser.ReadFields()
                InfoString = SearchTextFieldParser.ReadFields()
                Do Until SearchTextFieldParser.EndOfData
                    If InfoString(0) = "Weapon" Then
                        arrayOfOwnedItems(m_OwnedItemsCounterInteger) = New WeaponClass(InfoString(1), InfoString(2), _
                                                                                        CInt(InfoString(3)), CDec(InfoString(4)), _
                                                                                        InfoString(5), InfoString(6), InfoString(7), _
                                                                                        InfoString(8), InfoString(9), InfoString(10), _
                                                                                        InfoString(11))
                        m_OwnedItemsCounterInteger += 1
                    ElseIf InfoString(0) = "Armor" Then
                        arrayOfOwnedItems(m_OwnedItemsCounterInteger) = New ArmorClass(InfoString(1), InfoString(2), _
                                                                                        CInt(InfoString(3)), CDec(InfoString(4)), _
                                                                                        InfoString(5), InfoString(6), CInt(InfoString(7)), _
                                                                                        CInt(InfoString(8)), CInt(InfoString(9)), CInt(InfoString(10)))
                        m_OwnedItemsCounterInteger += 1
                    ElseIf InfoString(0) = "Other" Then
                        arrayOfOwnedItems(m_OwnedItemsCounterInteger) = New EquipmentClass(InfoString(1), InfoString(2), _
                                                                                        CInt(InfoString(3)), CDec(InfoString(4)), _
                                                                                        InfoString(5))
                        m_OwnedItemsCounterInteger += 1
                    End If
                    InfoString = SearchTextFieldParser.ReadFields()
                Loop
            Catch ex As Exception
                'If no equipment has yet been added then inventory
                'file won't exist.
            End Try

            'Update list boxes to reflect changes
            UpdateListBox("Subcategory")
            UpdateListBox("Equipment")
            UpdateInventoryListBox()

        Catch ex As Exception
            MessageBox.Show("An error?  What will we do?!  Squee!  We're all going to die!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")

        End Try

    End Sub

    Private Sub AllRadioButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AllRadioButton.Click

        'When the All radio button is selected, update subcategory
        'and equipment listboxes accordingly

        UpdateListBox("Subcategory")
        UpdateListBox("Equipment")
        UpdateInventoryListBox()


    End Sub

    Friend Sub UpdateListBox(ByVal TypeString As String)
        'Looks at which radio button is selected and populates
        'the relevant listbox with that category's items

        'Declare variables
        Dim ArrayString(499) As String
        Dim ArrayCountInteger As Integer
        Dim RowCountInteger As Integer


        'Determine which radio button is selected and
        'save corresponding items
        If AllRadioButton.Checked Then
            'Load array with items from each of the equipment files

            'Save and pass ArrayCountInteger so the equipment from
            'the next file will not overwrite the previous file's entries
            ArrayCountInteger = PopulateArray(WEAPONS_FILE_NAME_String, ArrayString, _
                                                ArrayCountInteger, TypeString)
            ArrayCountInteger = PopulateArray(ARMOR_FILE_NAME_String, ArrayString, _
                                                ArrayCountInteger, TypeString)
            ArrayCountInteger = PopulateArray(ITEMS_FILE_NAME_String, ArrayString, _
                                                ArrayCountInteger, TypeString)
        ElseIf ArmorRadioButton.Checked Then
            ArrayCountInteger = PopulateArray(ARMOR_FILE_NAME_String, ArrayString, _
                                                ArrayCountInteger, TypeString)
        ElseIf WeaponsRadioButton.Checked Then
            ArrayCountInteger = PopulateArray(WEAPONS_FILE_NAME_String, ArrayString, _
                                                ArrayCountInteger, TypeString)
        Else 'Other must be the checked radio button 
            ArrayCountInteger = PopulateArray(ITEMS_FILE_NAME_String, ArrayString, _
                                                ArrayCountInteger, TypeString)
        End If

        'Clear previous listbox items and load the new items
        If TypeString = "Subcategory" Then
            SubCategoryListBox.Items.Clear()
            Do Until RowCountInteger = ArrayCountInteger
                SubCategoryListBox.Items.Add(ArrayString(RowCountInteger))
                RowCountInteger += 1I
            Loop
        Else
            EquipmentListBox.Items.Clear()
            Do Until RowCountInteger = ArrayCountInteger
                EquipmentListBox.Items.Add(ArrayString(RowCountInteger))
                RowCountInteger += 1I
            Loop
        End If


    End Sub
    Private Function PopulateArray(ByVal FileNameString As String, ByRef ArrayString() As String, _
                                   ByVal ArrayCountInteger As Integer, ByVal UpdateTypeString As String) _
                                   As Integer

        'Fill array with subcategories or equipment compiled from 
        'item spreadsheets

        'Declare variables
        Dim InfoString() As String
        Dim IndexLocationInteger As Integer

        'Determine what's being updated
        If UpdateTypeString = "Subcategory" Then
            IndexLocationInteger = 1I
        Else
            IndexLocationInteger = 0I
        End If


        InstantiateTextFieldParser(FileNameString, SearchTextFieldParser)
        'Read fields twice to bypass title line
        InfoString = SearchTextFieldParser.ReadFields()
        InfoString = SearchTextFieldParser.ReadFields()
        Do Until SearchTextFieldParser.EndOfData
            If UpdateTypeString = "Subcategory" Then
                'Check for duplicates
                If Not ArrayString.Contains(InfoString(IndexLocationInteger)) Then
                    'This subcategory is unique and should be added
                    'to the array
                    ArrayString(ArrayCountInteger) = InfoString(IndexLocationInteger)
                    ArrayCountInteger += 1I
                End If
            Else
                ArrayString(ArrayCountInteger) = InfoString(IndexLocationInteger)
                ArrayCountInteger += 1I
            End If
            InfoString = SearchTextFieldParser.ReadFields()
        Loop

        Return ArrayCountInteger

    End Function


    Private Sub ArmorRadioButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ArmorRadioButton.Click
        'When the Armor radio button is selected, update subcategory
        'and equipment listboxes accordingly

        UpdateListBox("Subcategory")
        UpdateListBox("Equipment")
        UpdateInventoryListBox()

    End Sub

    Private Sub WeaponsRadioButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WeaponsRadioButton.Click
        'When the Weapons radio button is selected, update subcategory
        'and equipment listboxes accordingly

        UpdateListBox("Subcategory")
        UpdateListBox("Equipment")
        UpdateInventoryListBox()

    End Sub

    Private Sub OtherRadioButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OtherRadioButton.Click
        'When the Other radio button is selected, update subcategory
        'and equipment listboxes accordingly

        UpdateListBox("Subcategory")
        UpdateListBox("Equipment")
        UpdateInventoryListBox()

    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        'Add item to inventory when "Add To Inventory" button is clicked

        If WeaponsRadioButton.Checked Then
            AddWeaponToInventory()
        ElseIf ArmorRadioButton.Checked Then
            AddArmorToInventory()
        ElseIf OtherRadioButton.Checked Then
            AddItemToInventory()
        Else
            'If "All" button is checked, determine what item type
            'is being added

            'Declare variables
            Dim ItemNameString As String = EquipmentListBox.Text
            Dim InfoString() As String
            Dim ItemFoundBoolean As Boolean

            'Search for item amongst the weapons
            InfoString = FindItem(WEAPONS_FILE_NAME_String, ItemNameString, True)

            If InfoString(0) = ItemNameString Then
                AddWeaponToInventory()
                ItemFoundBoolean = True
            End If

            If Not ItemFoundBoolean Then

                'Search for item amongst the armor

                InfoString = FindItem(ARMOR_FILE_NAME_String, ItemNameString, True)

                If InfoString(0) = ItemNameString Then
                    AddArmorToInventory()
                    ItemFoundBoolean = True
                End If

                If Not ItemFoundBoolean Then
                    'Search for item amongs the other items
                    InfoString = FindItem(ITEMS_FILE_NAME_String, ItemNameString, True)

                    If InfoString(0) = ItemNameString Then
                        AddItemToInventory()
                        ItemFoundBoolean = True
                    End If
                End If

                If Not ItemFoundBoolean Then
                    MessageBox.Show("Unable to locate selected item.", "Error")
                End If
            End If
        End If

    End Sub

    Private Sub EquipmentListBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles EquipmentListBox.Enter

        'When the EquipmentListBox is active, disable irrelevant buttons
        RemoveButton.Enabled = False

        'Enable relevant buttons
        AddButton.Enabled = True

    End Sub

    Private Sub EquipmentListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EquipmentListBox.SelectedIndexChanged
        'When a new item is selected, display its properties

        Dim ItemFoundBoolean As Boolean

        'Determine what type of item it is and update properties

        If WeaponsRadioButton.Checked Then
            'Search for item on Weapons spreadsheet
            SelectedItemCategoryFlag = "Weapon"
            UpdateWeapon()

        ElseIf ArmorRadioButton.Checked Then
            'Search for item on Armor spreadsheet
            SelectedItemCategoryFlag = "Armor"
            UpdateArmor()

        ElseIf OtherRadioButton.Checked Then
            'Search for item on Other Items spreadsheet
            SelectedItemCategoryFlag = "Other"
            UpdateOther()

        Else 'If All radio button is selected, search everywhere for item
            SelectedItemCategoryFlag = "Weapon"
            ItemFoundBoolean = UpdateWeapon()

            If Not ItemFoundBoolean Then
                SelectedItemCategoryFlag = "Armor"
                ItemFoundBoolean = UpdateArmor()
                If Not ItemFoundBoolean Then
                    SelectedItemCategoryFlag = "Other"
                    ItemFoundBoolean = UpdateOther()
                    If Not ItemFoundBoolean Then
                        SelectedItemCategoryFlag = "Error"
                        MessageBox.Show("Error. Cannot locate item.", "Error")
                    End If
                End If
            End If
        End If

    End Sub

    Private Function UpdateWeapon() As Boolean

        'Search on Weapons spreadsheet for currently selected item 

        'Declare variables
        Dim ItemNameString As String = EquipmentListBox.Text
        Dim InfoString() As String
        Dim ItemFoundBoolean As Boolean

        InfoString = FindItem(WEAPONS_FILE_NAME_String, ItemNameString, True)

        If InfoString(0) = ItemNameString Then
            ItemFoundBoolean = True
            'Hide irrelevant info
            BonusPenaltyGroupBox.Visible = False
            CombatDiceGroupBox.Visible = True

            'Update displayed item data
            Dim MainDamageString As String = InfoString(3)
            Dim SkillString As String = InfoString(13)
            Dim SizeString As String = InfoString(2)
            Dim FocusString As String = InfoString(1)
            Dim MaterialA As String = InfoString(9)
            Dim MaterialB As String = InfoString(10)
            Dim MaterialC As String = InfoString(11)
            Dim MaterialD As String = InfoString(12)
            Dim CostDecimal As Decimal = CDec(InfoString(5))
            Dim WeightString As String = InfoString(6)
            '           Dim TraitCode As String = InfoString(7)
            '          Dim DescripString As String = InfoString(8)

            'Update MaterialsListBox
            UpdateMaterials(MaterialA, MaterialB, MaterialC, MaterialD)

            'Update fields 
            UpdateAttackDice(FocusString)
            UpdateDamageDice(SkillString, SizeString, FocusString, MainDamageString, 0I)
            UpdateWeight(WeightString)
            UpdateCost(CostDecimal)
            UpdateDescription(False)
            '            UpdateDescription(GetWeaponTraits(TraitCode) + DescripString)

        End If

        Return ItemFoundBoolean

    End Function
    Private Function GetBonusDamage(ByVal SkillString As String, ByVal SizeString As String, _
                                    ByVal FocusString As String, ByVal OtherBonusInt As Integer) As Integer

        Dim DexModInteger, StrModInteger, BonusDamageInteger As Integer
        DexModInteger = SkillsFocuses.GetAbilityMod("Dex")
        StrModInteger = SkillsFocuses.GetAbilityMod("Str")

        If SkillString = "Heavy Weapons" Then
            'Heavy Weapons do Str mod bonus damage
            'or twice Str mod bonus damage if wielded
            'in two hands
            If SizeString = "L" Then
                'If the item is Large it must be wielded two-handed
                BonusDamageInteger = 2 * StrModInteger
            Else
                'Otherwise it is wielded one-handed
                BonusDamageInteger = StrModInteger
            End If

        ElseIf SkillString = "Light Weapons" Then
            'Light Weapons do Dex mod bonus damage
            'whether wielded one- or two-handed
            BonusDamageInteger = DexModInteger

        ElseIf SkillString = "Ranged Weapons" Then
            If (FocusString = "Bow") Or (FocusString = "Sling") Then
                'Bows and slings do Dex + Str mod bonus damage
                BonusDamageInteger = DexModInteger + StrModInteger
            ElseIf FocusString = "Crossbow" Then
                'Crossbows do Dex mod bonus damage
                BonusDamageInteger = DexModInteger
            Else
                'Unique ranged weapons have no bonus damage
                BonusDamageInteger = 0I
            End If
        ElseIf SkillString = "Unarmed Combat" Then
            'No bonus damage
        Else
            MessageBox.Show("Error in GetBonusDamage. Unrecognized weapon skill type.", "Error")
        End If

        Return BonusDamageInteger + OtherBonusInt

    End Function
    Private Function IsTrained(ByVal SkillName As String) As Boolean
        'Determine whether character is trained in this item
        Dim LoopCountInteger As Integer
        Dim temp = StripParentheses(SkillsFocuses.CharSkillAndFocusStringArray(LoopCountInteger, 0))

        'Find the relevant skill amongst the character's skills and focuses
        Do Until temp = SkillName
            LoopCountInteger += 1I
            temp = StripParentheses(SkillsFocuses.CharSkillAndFocusStringArray(LoopCountInteger, 0))
            If SkillName = "Shield" And temp.Length > 6 Then
                temp = temp.Substring(0, 6)
            End If
        Loop

        'Check whether they're trained
        Return If(SkillsFocuses.CharSkillAndFocusStringArray(LoopCountInteger, 9) = "True", True, False)

    End Function
    Private Function UpdateArmor() As Boolean

        'Search on Armor spreadsheet for currently selected item and
        'display its properties

        'Declare variables
        Dim ItemNameString As String = EquipmentListBox.Text
        Dim InfoString() As String
        Dim ItemFoundBoolean As Boolean

        InfoString = FindItem(ARMOR_FILE_NAME_String, ItemNameString, True)

        If InfoString(0) = ItemNameString Then

            'Declare variables
            '           Dim DescriptionString As String = ""
            Dim UntrainedPenaltyInteger As Integer = 1
            Dim SkillString As String = InfoString(1)
            Dim CombatDefPenaltyInt As Integer = CInt(InfoString(4))
            Dim SkillCheckPenaltyInt As Integer = CInt(InfoString(3))

            'Update item details
            BonusPenaltyGroupBox.Visible = True
            CombatDiceGroupBox.Visible = False

            ItemFoundBoolean = True

            'Update MaterialsListBox
            UpdateMaterials(InfoString(9), InfoString(10), InfoString(11), InfoString(12))

            'Update fields 
            '            DescriptionString += UpdateArmorDescription(SkillString)
            DRLabel.Text = InfoString(2)
            CombatDefBonusLabel.Text = InfoString(5)
            UpdateWeight(InfoString(7))
            UpdateCost(CDec(InfoString(6)))
            UpdateDescription(False)
            '            UpdateDescription(DescriptionString + InfoString(8))

            'If character is untrained in an armor type, increase penalties
            '(There is no penalty for being untrained in shields)
            If (Not IsTrained(SkillString)) And SkillString <> "Shield" Then
                UntrainedPenaltyInteger = 2
            End If

            If CombatDefPenaltyInt < 0 Then
                CombatDefPenaltyInt = 0
            End If

            If SkillCheckPenaltyInt < 0 Then
                SkillCheckPenaltyInt = 0
            End If

            CombatDefPenaltyLabel.Text = CStr(CombatDefPenaltyInt * UntrainedPenaltyInteger)
            SkillCheckPenaltyLabel.Text = CStr(SkillCheckPenaltyInt * UntrainedPenaltyInteger)

        End If

        Return ItemFoundBoolean

    End Function
    Private Function StripParentheses(ByVal Name As String) As String

        'Takes a string (the name of a skill or focus) and returns the name without
        'the ability parentheses at the end, allowing for easy comparison of names
        'with multiple versions (ie Martial Skill (Str) and Martial Skill (Dex))

        Dim StrippedString As String = ""

        Try

            StrippedString += Name.Substring(0, Name.Length - 6)

        Catch ex As Exception
            MessageBox.Show("There was an error trying to strip parentheses!  Panic!" & vbCrLf & _
                            vbCrLf & "MESSAGE: " & ex.Message, "Error")
        End Try

        Return StrippedString

    End Function
    Private Function UpdateOther() As Boolean

        'Search on Items spreadsheet for currently selected item 

        'Declare variables
        Dim ItemNameString As String = EquipmentListBox.Text
        Dim InfoString() As String
        Dim ItemFoundBoolean As Boolean

        InfoString = FindItem(ITEMS_FILE_NAME_String, ItemNameString, True)


        If InfoString(0) = ItemNameString Then
            ItemFoundBoolean = True
            'Update item details
            'Hide irrelevant info
            BonusPenaltyGroupBox.Visible = False
            CombatDiceGroupBox.Visible = False

            'Update displayed item data
            UpdateWeight(InfoString(3))
            UpdateCost(CDec(InfoString(2)))
            UpdateDescription(False)

        End If

        Return ItemFoundBoolean

    End Function
    Private Sub UpdateWeight(ByVal WeightString As String)
        'Updates the weight label with the current item's weight

        'Make sure whole numbers are displayed without .0
        '("9 pounds" not "9.0 pounds")
        Dim tempDec As Decimal = CDec(WeightString)
        Dim tempInt As Integer = CInt(WeightString)

        If tempDec.Equals(tempInt) Then
            WeightString = CStr(tempInt)
        End If

        WeightLabel.Text = WeightString + " pounds"

    End Sub
    Private Sub UpdateDescription(ByVal OwnedBoolean As Boolean)
        'Updates the description label with the item's description

        If SelectedItemCategoryFlag = "Weapon" Then
            UpdateWeaponDescription(OwnedBoolean)

        ElseIf SelectedItemCategoryFlag = "Armor" Then
            UpdateArmorDescription(OwnedBoolean)

        Else
            UpdateOtherDescription(OwnedBoolean)
        End If

    End Sub
    Private Sub UpdateWeaponDescription(ByVal OwnedBoolean As Boolean)

        'Update Description Textbox with the selected weapon's traits and
        'description

        Dim TraitString As String
        Dim SheetDescriptionString As String

        If Not OwnedBoolean Then

            Dim InfoString() As String
            Dim ItemNameString As String = EquipmentListBox.Text
            InfoString = FindItem(WEAPONS_FILE_NAME_String, ItemNameString, True)
            Dim TraitCode As String = InfoString(7)

            TraitString = GetWeaponTraits(TraitCode)
            SheetDescriptionString = InfoString(8)

        Else

            Dim ArrayLocation As Integer = FindSelectedInventory()
            Dim TempWeapon As WeaponClass = CType(ArrayOfOwnedItems(ArrayLocation), WeaponClass)

            TraitString = GetWeaponTraits(TempWeapon.Trait)
            SheetDescriptionString = TempWeapon.Description

        End If

        DescriptionTextBox.Text = (TraitString + SheetDescriptionString)

    End Sub
    Private Function GetWeaponTraits(ByVal TraitCodeString As String) As String

        Dim SpecialTraitString As String = ""

        'Determine whether item has any special traits

        If TraitCodeString.Length > 0 Then 'Item has special traits
            'Loop through TraitArray to determine which codes the item has
            'and add their description to the SpecialTraitString
            If TraitCodeString.Contains("BB") Then
                SpecialTraitString += "DOUBLE WEAPON: While wielding a double weapon you" + _
                " can fight as if you have a medium weapon in your main hand and a small" + _
                " weapon in your off hand (unless the description below says otherwise) or" + _
                " as if you are wielding a single large weapon two-handed. Double weapons" + _
                " may not be sheathed; they must be carried at all times in at least one hand.  " + _
                Environment.NewLine + Environment.NewLine
            End If

            If TraitCodeString.Contains("D") Then
                SpecialTraitString += "DEFENSIVE: This weapon grants a +1 shield bonus " + _
                "to Combat Defense. You must be trained in the 'Shields (Defense)' focus " + _
                "to gain this bonus. Improved status in the 'Shields (Defense)' focus will " + _
                "not improve this bonus.  " + Environment.NewLine + Environment.NewLine

                'If character is trained in Shields (Defense), display Combat Defense bonus
                'Dim IsTrainedBoolean As Boolean
                'Dim LoopCountInteger As Integer


                'Do Until StripParentheses(SkillsFocuses.CharSkillAndFocusStringArray(LoopCountInteger, 0)) = _
                '"Shields (Defense)"
                'LoopCountInteger += 1I
                'Loop
                'Dim tester As String = SkillsFocuses.CharSkillAndFocusStringArray(LoopCountInteger, 9)
                'IsTrainedBoolean = If(SkillsFocuses.CharSkillAndFocusStringArray(LoopCountInteger, 9) = "True", True, False)
                BonusPenaltyGroupBox.Visible = True

                If IsTrained("Shields (Defense)") Then
                    CombatDefBonusLabel.Text = "1"
                Else
                    CombatDefBonusLabel.Text = "0"
                End If


            End If
            If TraitCodeString.Contains("H") Then
                SpecialTraitString += "HIGH CRIT: This weapon's exploding dice explode " + _
                "on a 9 or 10, not just a 10. (This only applies to the original attack" + _
                " roll, not subsequent exploding dice rolls on the same attack.)  " + _
                Environment.NewLine + Environment.NewLine
            End If

            If TraitCodeString.Contains("L2") Or TraitCodeString.Contains("L3") Or TraitCodeString.Contains("L4") Then
                Dim APString As String = "4"

                If TraitCodeString.Contains("L2") Then
                    APString = "2"
                ElseIf TraitCodeString.Contains("L3") Then
                    APString = "3"
                End If

                SpecialTraitString += "RELOADING: It takes " + APString + " AP to reload this " + _
                "weapon in combat.  " + Environment.NewLine + Environment.NewLine
            End If

            If TraitCodeString.Contains("P") Then
                SpecialTraitString += "PENETRATING: This weapon ignores 2 points of DR gained" + _
                " from armor.  " + Environment.NewLine + Environment.NewLine
            End If

            If TraitCodeString.Contains("R") Then
                SpecialTraitString += "REACH: This weapon can be used to attack " + _
                "creatures that are 10 feet away instead of just 5. (You can still " + _
                "attack creatures that are adjacent to you unless otherwise stated.) " + _
                "Reach weapons may not be sheathed; they must be carried at all " + _
                "times in at least one hand.  " + Environment.NewLine + Environment.NewLine
            End If

            If TraitCodeString.Contains("T") Then
                SpecialTraitString += "TRIPPING: You can make trip attacks with this weapon.  " + _
                Environment.NewLine + Environment.NewLine
            End If

        End If

        Return SpecialTraitString

    End Function
    Private Sub UpdateCost(ByVal SilverPrice As Decimal)

        'Takes the price in silver pieces, determines the 
        'denominations to display, and updates the price label

        Dim CostString As String

        If SilverPrice < 1D Then
            'Convert from silver to copper
            SilverPrice *= 100D
            CostString = CStr(CInt(SilverPrice)) + " CP"
        ElseIf SilverPrice > 100D Then
            'Convert from silver to gold
            Dim GoldInteger As Integer
            GoldInteger = CInt(SilverPrice / 100I)
            SilverPrice = SilverPrice Mod 100I
            CostString = CStr(GoldInteger) + " GP and " + CStr(CInt(SilverPrice)) + " SP"
        Else
            'Display in silver
            CostString = CStr(CInt(SilverPrice)) + " SP"
        End If

        CostLabel.Text = CostString

    End Sub
    Private Function FindItem(ByVal FileNameString As String, ByVal ItemNameString As String, ByVal BypassTitleBoolean As Boolean) As String()
        'Locate a specific item in a given file and return its details
        Dim InfoString() As String
        Dim ItemFoundBoolean As Boolean

        InstantiateTextFieldParser(FileNameString, SearchTextFieldParser)

        If BypassTitleBoolean Then
            'Read fields once to bypass title line 
            InfoString = SearchTextFieldParser.ReadFields()
        End If

        InfoString = SearchTextFieldParser.ReadFields()
        Do Until SearchTextFieldParser.EndOfData Or ItemFoundBoolean

            If InfoString(0) = ItemNameString Then
                ItemFoundBoolean = True
            Else
                InfoString = SearchTextFieldParser.ReadFields()
            End If
        Loop

        Return InfoString

    End Function
    Private Sub AddItemToInventory()
        'Add selected item to inventory box

        'Search on Item spreadsheet for currently selected item 
        'Declare variables
        Dim ItemNameString As String
        Dim InfoString() As String
        'Dim ItemFoundBoolean As Boolean
        ItemNameString = EquipmentListBox.Text

        InfoString = FindItem(ITEMS_FILE_NAME_String, ItemNameString, True)

        If InfoString(0) <> ItemNameString Then
            MessageBox.Show("Error in AddItemToInventory. Unable to find item.", "Error")
        Else
            'Add to OwnedItems array
            ArrayOfOwnedItems(m_OwnedItemsCounterInteger) = New EquipmentClass(ItemNameString, _
                                                                               InfoString(1), _
                                                                               CInt(InfoString(2)), _
                                                                               CInt(InfoString(3)), _
                                                                               InfoString(4))

            'Update owned items counter
            m_OwnedItemsCounterInteger += 1I

            'Update InventoryListBox
            UpdateInventoryListBox()

        End If

    End Sub
    Private Sub UpdateInventoryListBox()

        'This subprocedure looks at which category and subcategory
        'are selected and repopulates the inventory listbox
        'with the relevant items

        InventoryListBox.Items.Clear()

        If m_OwnedItemsCounterInteger > 0 Then
            'Determine which radio button is selected and
            'save corresponding items
            If AllRadioButton.Checked Then
                'Update all types of items
                DisplayOwnedArmor()
                DisplayOwnedWeapons()
                DisplayOwnedOtherItems()
            ElseIf ArmorRadioButton.Checked Then
                DisplayOwnedArmor()
            ElseIf WeaponsRadioButton.Checked Then
                DisplayOwnedWeapons()
            Else
                DisplayOwnedOtherItems()
            End If
        End If


    End Sub
    Private Sub DisplayOwnedOtherItems()
        'Add all owned weapons to the inventory listbox
        'as long as they match the selected subcategory

        Dim CountInteger As Integer

        'Check whether a subcategory is selected
        If SubCategoryListBox.SelectedIndex < 0 Then
            'No subcategories are selected, so add all owned weapons
            Do Until (CountInteger >= m_OwnedItemsCounterInteger)
                If TypeOf ArrayOfOwnedItems(CountInteger) Is ArmorClass Then
                    'Do nothing
                ElseIf TypeOf ArrayOfOwnedItems(CountInteger) Is WeaponClass Then
                    'Do nothing
                Else
                    InventoryListBox.Items.Add(ArrayOfOwnedItems(CountInteger).Name)
                End If
                CountInteger += 1
            Loop
        Else
            'A subcategory is selected, so only display items of
            'that subcategory
            Do Until (CountInteger >= m_OwnedItemsCounterInteger)
                If SubCategoryListBox.SelectedItem.Equals(ArrayOfOwnedItems(CountInteger).Category) Then
                    If TypeOf ArrayOfOwnedItems(CountInteger) Is ArmorClass Then
                        'Do nothing
                    ElseIf TypeOf ArrayOfOwnedItems(CountInteger) Is WeaponClass Then
                        'Do nothing
                    Else
                        InventoryListBox.Items.Add(ArrayOfOwnedItems(CountInteger).Name)
                    End If
                End If
                CountInteger += 1
            Loop
        End If

    End Sub
    Private Sub DisplayOwnedArmor()
        'Add all owned weapons to the inventory listbox
        'as long as they match the selected subcategory

        Dim CountInteger As Integer

        'Check whether a subcategory is selected
        If SubCategoryListBox.SelectedIndex < 0 Then
            'No subcategories are selected, so add all owned weapons
            Do Until (CountInteger >= m_OwnedItemsCounterInteger)
                If TypeOf ArrayOfOwnedItems(CountInteger) Is ArmorClass Then
                    InventoryListBox.Items.Add(ArrayOfOwnedItems(CountInteger).Name)
                End If
                CountInteger += 1
            Loop
        Else
            'A subcategory is selected, so only display items of
            'that subcategory
            Do Until (CountInteger >= m_OwnedItemsCounterInteger)
                If SubCategoryListBox.SelectedItem.Equals(ArrayOfOwnedItems(CountInteger).Category) Then
                    If TypeOf ArrayOfOwnedItems(CountInteger) Is ArmorClass Then
                        InventoryListBox.Items.Add(ArrayOfOwnedItems(CountInteger).Name)
                    End If
                End If
                CountInteger += 1
            Loop
        End If

    End Sub
    Private Sub DisplayOwnedWeapons()
        'Add all owned weapons to the inventory listbox
        'as long as they match the selected subcategory

        Dim CountInteger As Integer

        'Check whether a subcategory is selected
        If SubCategoryListBox.SelectedIndex < 0 Then
            'No subcategories are selected, so add all owned weapons
            Do Until (CountInteger >= m_OwnedItemsCounterInteger)
                If TypeOf ArrayOfOwnedItems(CountInteger) Is WeaponClass Then
                    InventoryListBox.Items.Add(ArrayOfOwnedItems(CountInteger).Name)
                End If
                CountInteger += 1
            Loop
        Else
            'A subcategory is selected, so only display items of
            'that subcategory
            Do Until (CountInteger >= m_OwnedItemsCounterInteger)
                If SubCategoryListBox.SelectedItem.Equals(ArrayOfOwnedItems(CountInteger).Category) Then
                    If TypeOf ArrayOfOwnedItems(CountInteger) Is WeaponClass Then
                        InventoryListBox.Items.Add(ArrayOfOwnedItems(CountInteger).Name)
                    End If
                End If
                CountInteger += 1
            Loop
        End If

    End Sub
    Private Sub AddArmorToInventory()

        'Search on Armor spreadsheet for currently selected item 

        'Declare variables
        Dim ItemNameString As String
        Dim InfoString() As String
        Dim ItemFoundBoolean As Boolean
        ItemNameString = EquipmentListBox.Text

        InstantiateTextFieldParser(ARMOR_FILE_NAME_String, SearchTextFieldParser)
        'Read fields twice to bypass title line
        InfoString = SearchTextFieldParser.ReadFields()
        InfoString = SearchTextFieldParser.ReadFields()
        Do Until SearchTextFieldParser.EndOfData Or (ItemFoundBoolean = True)
            If InfoString(0) = ItemNameString Then
                ItemFoundBoolean = True
            End If
            InfoString = SearchTextFieldParser.ReadFields()
        Loop

        If ItemFoundBoolean <> True Then
            MessageBox.Show("Error in AddArmorToInventory. Unable to find armor on sheet.", "Error")
        Else
            'Store current item data in the OwnedArmor array
            ArrayOfOwnedItems(m_OwnedItemsCounterInteger) = New ArmorClass(ItemNameString, InfoString(1), _
                                                                           CInt(InfoString(6)), CDec(InfoString(7)), _
                                                                           InfoString(8), MaterialsListBox.Text, _
                                                                           CInt(InfoString(2)), CInt(InfoString(5)), _
                                                                           CInt(InfoString(4)), CInt(InfoString(3)))

            'Update Owned items counter
            m_OwnedItemsCounterInteger += 1I

            'Add item to InventoryListBox
            InventoryListBox.Items.Add(ItemNameString)
        End If

    End Sub
    Private Sub AddWeaponToInventory()

        'Search on Weapons spreadsheet for currently selected item 

        'Declare variables
        Dim ItemNameString As String
        Dim InfoString() As String
        Dim ItemFoundBoolean As Boolean
        ItemNameString = EquipmentListBox.Text

        InstantiateTextFieldParser(WEAPONS_FILE_NAME_String, SearchTextFieldParser)

        'Read fields twice to bypass title line
        InfoString = SearchTextFieldParser.ReadFields()
        InfoString = SearchTextFieldParser.ReadFields()

        Do Until SearchTextFieldParser.EndOfData Or (ItemFoundBoolean = True)
            If InfoString(0) = ItemNameString Then
                ItemFoundBoolean = True
            End If
            InfoString = SearchTextFieldParser.ReadFields()
        Loop

        If ItemFoundBoolean <> True Then
            MessageBox.Show("Unable to locate selected item.", "Error")
        Else
            'Save details in the owned items array
            ArrayOfOwnedItems(m_OwnedItemsCounterInteger) = New WeaponClass(ItemNameString, InfoString(1), _
                                                                            CInt(InfoString(5)), CDec(InfoString(6)), _
                                                                            InfoString(8), MaterialsListBox.Text, _
                                                                            InfoString(3), InfoString(4), InfoString(13), _
                                                                            InfoString(2), InfoString(7))

            'Update OwnedWeapons counter
            m_OwnedItemsCounterInteger += 1I

            'Add item to InventoryListBox
            InventoryListBox.Items.Add(ItemNameString)
        End If

    End Sub
    Private Sub UpdateMaterials(ByVal MaterialString As String, ByVal MaterialSupplement1String As String, _
                                ByVal MaterialSupplement2String As String, ByVal MaterialSupplement3String As String)

        'Populate the Materials listbox with the available materials
        'for this item.  Set the selected index to the default.

        MaterialsListBox.Items.Clear()

        'Most items can be made out of all the materials of a 
        'given type (metal, wood, or hide)
        If MaterialString = "Metal" Then
            MaterialsListBox.Items.Add("Iron")
            MaterialsListBox.Items.Add("Steel")
            MaterialsListBox.Items.Add("Mithral")
            MaterialsListBox.Items.Add("Adamantine")
        ElseIf MaterialString = "Wood" Then
            MaterialsListBox.Items.Add("Softwood")
            MaterialsListBox.Items.Add("Hardwood")
            MaterialsListBox.Items.Add("Grovewood")
        ElseIf MaterialString = "Hide" Then
            MaterialsListBox.Items.Add("Hide")
            MaterialsListBox.Items.Add("Exotic Hide")
            MaterialsListBox.Items.Add("Dragonhide")
        ElseIf MaterialString = "Iron" Then
            MaterialsListBox.Items.Add("Iron")
        End If

        'In addition to their general material type, some items
        'can be made out of one or two other unique materials.
        If MaterialSupplement1String <> "x" Then
            MaterialsListBox.Items.Add(MaterialSupplement1String)
        End If
        If MaterialSupplement2String <> "x" Then
            MaterialsListBox.Items.Add(MaterialSupplement2String)
        End If
        If MaterialSupplement3String <> "x" Then
            MaterialsListBox.Items.Add(MaterialSupplement3String)
        End If

        'Set selected index to the basic material
        If MaterialsListBox.Items.Count > 0 Then
            MaterialsListBox.SelectedIndex = 0
        End If

    End Sub
    Private Sub UpdateDamageDice(ByVal SkillString As String, ByVal SizeString As String, _
                                 ByVal FocusString As String, ByVal DamageString As String, _
                                 ByVal OtherBonusInt As Integer)
        'Calculates the number of damage dice plus bonuses and displays them

        Dim BonusDamageInteger As Integer

        BonusDamageInteger = GetBonusDamage(SkillString, SizeString, FocusString, OtherBonusInt)

        If BonusDamageInteger < 0 Then
            BonusDamageInteger = Math.Abs(BonusDamageInteger) 'Strip negative sign
            DamageRollLabel.Text = DamageString + " - " + CStr(BonusDamageInteger)
        Else
            DamageRollLabel.Text = DamageString + " + " + CStr(BonusDamageInteger)
        End If

    End Sub
    Private Sub UpdateAttackDice(ByVal FocusString As String)

        'Attack dice to roll are based on the character's score in
        'the weapon's focus.  This function finds that score and
        'looks up the number of dice allowed

        'Declare variables
        Dim ScoreInteger, AbilityModInteger, RowCountInteger, _
        SkillRanksInteger, FocusRanksInteger As Integer
        Dim D10String, ModString, AttackDiceString As String
        Dim InfoString() As String
        Dim RowFound As Boolean

        'Find focus on SkillsFocuses sheet
        InstantiateTextFieldParser(SkillsFocuses.RULES_FILE_NAME, SearchTextFieldParser)

        InfoString = SearchTextFieldParser.ReadFields
        Do Until RowFound Or SearchTextFieldParser.EndOfData
            If FocusString = StripParentheses(InfoString(0)) Then
                RowFound = True
            Else
                RowCountInteger += 1
                InfoString = SearchTextFieldParser.ReadFields
            End If
        Loop

        Dim TestString, Tester2 As String

        'The score in a skill is based on ability mod + skill ranks + focus ranks
        AbilityModInteger = SkillsFocuses.GetAbilityMod(InfoString(2))
        TestString = SkillsFocuses.CharSkillAndFocusStringArray(RowCountInteger, 7)
        SkillRanksInteger = CInt(SkillsFocuses.CharSkillAndFocusStringArray(RowCountInteger, 7))
        Tester2 = SkillsFocuses.CharSkillAndFocusStringArray(RowCountInteger, 8)
        FocusRanksInteger = CInt(SkillsFocuses.CharSkillAndFocusStringArray(RowCountInteger, 8))
        ScoreInteger = AbilityModInteger + SkillRanksInteger + FocusRanksInteger

        'Find score on Scores and Dice sheet
        InstantiateTextFieldParser(SkillsFocuses.SCORES_AND_DICE_FILE_NAME, _
                                   SearchTextFieldParser)

        'Loop through data to find character's score, then save the
        'number of dice.  (Begin before entering loop so loop 
        'conditions are not confused by title row.)
        InfoString = SearchTextFieldParser.ReadFields()

        Do
            InfoString = SearchTextFieldParser.ReadFields()
        Loop Until (CInt(InfoString(0)) = ScoreInteger) Or SearchTextFieldParser.EndOfData

        'Update variables
        D10String = InfoString(1)
        ModString = InfoString(2)
        If CInt(ModString) < 0 Then
            ModString = CStr(Math.Abs(CInt(ModString))) 'Strip negative sign
            AttackDiceString = D10String + " - " + ModString
        Else
            AttackDiceString = D10String + " + " + ModString
        End If

        AttackRollLabel.Text = AttackDiceString

    End Sub
    Private Sub MaterialsListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaterialsListBox.SelectedIndexChanged

        'When the user chooses a new material, update all
        'relevant information with that material's properties
        UpdatePropertiesBasedOnMaterial()

    End Sub
    Private Sub UpdatePropertiesBasedOnMaterial()
        'When a new material is selected, update any relevant resistances,
        'costs, weight, etc.

        Dim CostMultipleInteger As Integer = 1I
        Dim WeightMultipleDecimal As Decimal = 1I
        Dim DamageRollInteger, CombatDefPenaltyInteger, SkillFocusPenaltyInteger, _
        DRInteger As Integer
        Dim InfoString() As String
        Dim ItemFoundBoolean As Boolean
        '     Dim IsTrainedBoolean As Boolean
        Dim SilverDecimal, OriginalWeightDecimal As Decimal
        Dim MainDamageString As String = ""

        'Search for item
        If SelectedItemCategoryFlag = "Armor" Then
            InfoString = FindItem(ARMOR_FILE_NAME_String, EquipmentListBox.SelectedItem.ToString, _
                                  True)
        ElseIf SelectedItemCategoryFlag = "Weapon" Then
            InfoString = FindItem(WEAPONS_FILE_NAME_String, EquipmentListBox.SelectedItem.ToString, _
                                  True)
        ElseIf SelectedItemCategoryFlag = "Other" Then
            InfoString = FindItem(ITEMS_FILE_NAME_String, EquipmentListBox.SelectedItem.ToString, _
                                  True)
        Else
            MessageBox.Show("Error in MaterialsListBox_SelectedIndexChange. Unable to " _
                            + "locate item.", "Error")
        End If


        'Update variables 
        If MaterialsListBox.SelectedItem.Equals("Steel") Then
            DamageRollInteger = 1I
            DRInteger = 1I
            CostMultipleInteger = 2I
        ElseIf MaterialsListBox.SelectedItem.Equals("Mithral") Then
            WeightMultipleDecimal = 0.5D
            DamageRollInteger = 3I
            DRInteger = 3I
            SkillFocusPenaltyInteger = -2I
            CombatDefPenaltyInteger = -2I
            CostMultipleInteger = 10I
        ElseIf MaterialsListBox.SelectedItem.Equals("Adamantine") Then
            WeightMultipleDecimal = 1.5D
            DamageRollInteger = 5I
            DRInteger = 5I
            CostMultipleInteger = 10I
        ElseIf MaterialsListBox.SelectedItem.Equals("Hardwood") Then
            DamageRollInteger = 1I
            CostMultipleInteger = 2I
        ElseIf MaterialsListBox.SelectedItem.Equals("Grovewood") Then
            DamageRollInteger = 3I
            SkillFocusPenaltyInteger = -1I
            CostMultipleInteger = 5I
        ElseIf MaterialsListBox.SelectedItem.Equals("Exotic Hide") Then
            DRInteger = 1I
            CostMultipleInteger = 2I
        ElseIf MaterialsListBox.SelectedItem.Equals("Dragonhide") Then

            'Determine whether item selected is light, medium, or heavy armor
            If EquipmentListBox.SelectedItem.Equals(InfoString(0)) Then
                ItemFoundBoolean = True
                If InfoString(1) = "Light Armor" Then
                    DRInteger = 3I
                    '                    EnergyResistanceInteger = 10I
                ElseIf InfoString(1) = "Medium Armor" Then
                    DRInteger = 4I
                    '                   EnergyResistanceInteger = 20I
                ElseIf InfoString(1) = "Heavy Armor" Then
                    DRInteger = 5I
                    '                  EnergyResistanceInteger = 30I
                Else
                    '                 EnergyResistanceInteger = 10I
                End If
            End If

        End If

        'Determine original cost of selected equipment in silver
        If SelectedItemCategoryFlag = "Armor" And _
        EquipmentListBox.SelectedItem.Equals(InfoString(0)) Then
            ItemFoundBoolean = True
            SilverDecimal = CDec(InfoString(6))
            OriginalWeightDecimal = CDec(InfoString(7))
        End If

        If Not ItemFoundBoolean Then

            If SelectedItemCategoryFlag = "Weapon" And _
            EquipmentListBox.SelectedItem.Equals(InfoString(0)) Then
                ItemFoundBoolean = True
                SilverDecimal = CDec(InfoString(5))
                OriginalWeightDecimal = CDec(InfoString(6))

                'Find attack and damage info for original item
                Dim SkillString As String = InfoString(13)
                Dim SizeString As String = InfoString(2)
                Dim FocusString As String = InfoString(1)

                'Display damage dice for original item
                UpdateDamageDice(SkillString, SizeString, FocusString, InfoString(3), DamageRollInteger)

            End If
        End If

        If Not ItemFoundBoolean Then
            MessageBox.Show("Error in MaterialsListBox_SelectedIndexChange. Unable to locate item as weapon or armor.", "Error")
        Else

            'Verify whether item is armor and, if so, update stats
            If SelectedItemCategoryFlag = "Armor" Then

                DRLabel.Text = CStr(CInt(InfoString(2)) + DRInteger)

                'If character is untrained in an armor type, increase penalties
                '(There is no penalty for being untrained in shields)
                SkillFocusPenaltyInteger += CInt(InfoString(3))
                CombatDefPenaltyInteger += CInt(InfoString(4))

                'Make sure penalties are not negative numbers
                If CombatDefPenaltyInteger < 0 Then
                    CombatDefPenaltyInteger = 0
                End If

                If SkillFocusPenaltyInteger < 0 Then
                    SkillFocusPenaltyInteger = 0
                End If

                If (Not IsTrained(InfoString(1))) And InfoString(1) <> "Shield" Then
                    CombatDefPenaltyLabel.Text = CStr(CombatDefPenaltyInteger * 2)
                    SkillCheckPenaltyLabel.Text = CStr(SkillFocusPenaltyInteger * 2)
                Else
                    CombatDefPenaltyLabel.Text = CStr(CombatDefPenaltyInteger)
                    SkillCheckPenaltyLabel.Text = CStr(SkillFocusPenaltyInteger)
                End If

            Else
                DRLabel.Text = "0"
                SkillCheckPenaltyLabel.Text = "0"
                CombatDefPenaltyLabel.Text = "0"
            End If

            If MaterialsListBox.SelectedItem.Equals("Dragonhide") Then
                'Dragonhide doesn't yet have a cost, per the DM
                CostLabel.Text = """It's very expensive."""
            Else
                UpdateCost(CostMultipleInteger * SilverDecimal)
            End If

            UpdateWeight(CStr(OriginalWeightDecimal * WeightMultipleDecimal))

            'If EnergyResistanceInteger <> 0 Then
            '    DescriptionTextBox.Text &= " Gain +" + CStr(EnergyResistanceInteger) + _
            '    " energy resistance.  (Energy type based on the dragon that " _
            '    + "provided this dragonhide.)"
            'End If

        End If


    End Sub
    Private Function FillItemsMatchingSubcategory(ByVal FileNameString As String, ByVal ItemArray() As String) As String()

        'Load array with any items which match that subcategory.
        Dim InfoString() As String
        Dim ArrayCounter As Integer = CInt(ItemArray(0))

        InstantiateTextFieldParser(FileNameString, SearchTextFieldParser)

        'Read fields twice to bypass title line
        InfoString = SearchTextFieldParser.ReadFields()
        InfoString = SearchTextFieldParser.ReadFields()

        Do Until SearchTextFieldParser.EndOfData

            If SubCategoryListBox.SelectedItem.Equals(InfoString(1)) Then
                ItemArray(ArrayCounter) = InfoString(0)
                ArrayCounter += 1I
            End If

            InfoString = SearchTextFieldParser.ReadFields()
        Loop

        ItemArray(0) = CStr(ArrayCounter)
        Return ItemArray
    End Function
    Private Sub SubCategoryListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubCategoryListBox.SelectedIndexChanged
        'When the user chooses a subcategory, display only the items in that
        'subcategory

        Dim ArrayString(450) As String
        Dim ArrayCountInteger As Integer = 1
        Dim RowCountInteger As Integer = 1

        'Save the array counter as the first item in the array
        ArrayString(0) = CStr(ArrayCountInteger)

        'Determine which radio button is selected and
        'save corresponding items
        If AllRadioButton.Checked Then
            'Check each of the equipment files for the selected subcategory.  
            'Load array with any items which match that subcategory.

            ArrayString = FillItemsMatchingSubcategory(WEAPONS_FILE_NAME_String, ArrayString)

            'Search for items matching the subcategory on the armor sheet
            ArrayString = FillItemsMatchingSubcategory(ARMOR_FILE_NAME_String, ArrayString)

            'Search for items matching the subcategory on the other items sheet
            ArrayString = FillItemsMatchingSubcategory(ITEMS_FILE_NAME_String, ArrayString)

        ElseIf ArmorRadioButton.Checked Then
            'Load array with any items which match that subcategory.
            ArrayString = FillItemsMatchingSubcategory(ARMOR_FILE_NAME_String, ArrayString)

        ElseIf WeaponsRadioButton.Checked Then
            'Load array with any items which match that subcategory.
            ArrayString = FillItemsMatchingSubcategory(WEAPONS_FILE_NAME_String, ArrayString)

        Else
            'Load array with any items which match that subcategory.
            ArrayString = FillItemsMatchingSubcategory(ITEMS_FILE_NAME_String, ArrayString)

        End If

        'Clear previous equipment from the listbox and load the new items
        EquipmentListBox.Items.Clear()
        Do
            EquipmentListBox.Items.Add(ArrayString(RowCountInteger))
            RowCountInteger += 1I
        Loop Until RowCountInteger = ArrayCountInteger

        UpdateInventoryListBox()

    End Sub

    Private Sub InventoryListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles InventoryListBox.SelectedIndexChanged
        'When a new item is selected, display its properties and enable/disable buttons

        Dim ArrayLocationInteger As Integer

        RemoveButton.Enabled = True
        AddButton.Enabled = False

        'Search for selected item
        ArrayLocationInteger = FindSelectedInventory()

        'When item is found, update displayed properties
        'Otherwise keep searching
        If ArrayLocationInteger >= 0 Then

            'Determine type of item found
            If TypeOf ArrayOfOwnedItems(ArrayLocationInteger) Is ArmorClass Then
                UpdateOwnedArmor(ArrayLocationInteger)

            ElseIf TypeOf ArrayOfOwnedItems(ArrayLocationInteger) Is WeaponClass Then
                UpdateOwnedWeapon(ArrayLocationInteger)

            Else
                UpdateOwnedItem(ArrayLocationInteger)
            End If

        Else
            'Item was not found anywhere
            MessageBox.Show("Error in InventoryListBox_SelectedIndexChanged. Unable to find owned item.", "Error")
        End If

    End Sub
    Private Sub UpdateOwnedItem(ByVal LoopCountInteger As Integer)

        'Update item details
        'Hide irrelevant info
        MaterialsListBox.Items.Clear()
        BonusPenaltyGroupBox.Visible = False
        CombatDiceGroupBox.Visible = False

        'Update displayed item data
        UpdateWeight(CStr(ArrayOfOwnedItems(LoopCountInteger).Weight))
        UpdateCost(CDec(ArrayOfOwnedItems(LoopCountInteger).Cost))
        UpdateDescription(True)

    End Sub
    Private Sub UpdateOwnedWeapon(ByVal LoopCountInteger As Integer)

        Dim TempWeapon As WeaponClass = CType(ArrayOfOwnedItems(LoopCountInteger), WeaponClass)

        'Update item details
        'Hide irrelevant info
        BonusPenaltyGroupBox.Visible = False
        CombatDiceGroupBox.Visible = True

        'Update displayed item data
        Dim FocusString As String

        FocusString = ArrayOfOwnedItems(LoopCountInteger).Category

        'Update fields 
        UpdateAttackDice(FocusString)
        UpdateDamageDice(TempWeapon.Skill, TempWeapon.Size, FocusString, TempWeapon.Damage, 0I)
        UpdateWeight(CStr(TempWeapon.Weight))
        UpdateCost(CDec(TempWeapon.Cost))
        UpdateDescription(True)

        MaterialsListBox.Items.Clear()
        MaterialsListBox.Items.Add(TempWeapon.Material)
        MaterialsListBox.SelectedIndex = 0
        UpdatePropertiesBasedOnMaterial()

    End Sub
    Private Sub UpdateOwnedArmor(ByVal LoopCountInteger As Integer)

        'Declare variable
        Dim TempArmor As ArmorClass = CType(ArrayOfOwnedItems(LoopCountInteger), ArmorClass)
        'Dim DescriptionString As String = ""
        Dim UntrainedPenaltyInteger As Integer = 1
        Dim SkillString As String = TempArmor.Category

        'Update item details
        BonusPenaltyGroupBox.Visible = True
        CombatDiceGroupBox.Visible = False
        UpdateDescription(True)

        'Update fields 
        DRLabel.Text = CStr(TempArmor.DR)
        CombatDefBonusLabel.Text = CStr(TempArmor.CombatDefenseBonus)
        UpdateWeight(CStr(TempArmor.Weight))
        UpdateCost(CDec(TempArmor.Cost))
        '        UpdateDescription(DescriptionString + TempArmor.Description)

        'If character is untrained in an armor type, increase penalties
        '(There is no penalty for being untrained in shields)
        If (Not IsTrained(SkillString)) And SkillString <> "Shield" Then
            UntrainedPenaltyInteger = 2
        End If

        CombatDefPenaltyLabel.Text = CStr(CInt(TempArmor.CombatDefensePenalty) * UntrainedPenaltyInteger)
        SkillCheckPenaltyLabel.Text = CStr(CInt(TempArmor.SkillAndFocusPenalty) * UntrainedPenaltyInteger)

        MaterialsListBox.Items.Clear()
        MaterialsListBox.Items.Add(TempArmor.Material)
        MaterialsListBox.SelectedIndex = 0
        UpdatePropertiesBasedOnMaterial()


    End Sub
    Private Sub UpdateOtherDescription(ByVal OwnedBoolean As Boolean)

        'Updates Description Textbox with item's description
        Dim SheetDescriptionString As String

        If Not OwnedBoolean Then

            Dim ItemNameString As String = EquipmentListBox.Text
            Dim InfoString() As String

            InfoString = FindItem(ITEMS_FILE_NAME_String, ItemNameString, True)
            SheetDescriptionString = InfoString(4)

        Else

            Dim ArrayLocation As Integer = FindSelectedInventory()
            SheetDescriptionString = ArrayOfOwnedItems(ArrayLocation).Description

        End If

        DescriptionTextBox.Text = SheetDescriptionString

    End Sub
    Private Sub UpdateArmorDescription(ByVal OwnedBoolean As Boolean)

        'Updates Description Textbox with the armor's traits and description, including
        'description based on selected material

        Dim ArmorTraitsString As String
        Dim SheetDescriptionString As String
        Dim MaterialTraitsString As String
        Dim SkillString As String

        If Not OwnedBoolean Then

            Dim InfoString() As String
            Dim ItemNameString As String = EquipmentListBox.Text
            InfoString = FindItem(ARMOR_FILE_NAME_String, ItemNameString, True)
            SkillString = InfoString(1)

            ArmorTraitsString = GetArmorTraits(SkillString)
            SheetDescriptionString = InfoString(8) + Environment.NewLine + Environment.NewLine
            MaterialTraitsString = GetEnergyResistance(SkillString)
        Else 'Item is Owned

            Dim ArrayLocation As Integer = FindSelectedInventory()
            Dim TempArmor As ArmorClass = CType(ArrayOfOwnedItems(ArrayLocation), ArmorClass)
            SkillString = TempArmor.Category

            ArmorTraitsString = GetArmorTraits(SkillString)
            SheetDescriptionString = TempArmor.Description

        End If

        MaterialTraitsString = GetEnergyResistance(SkillString)
        DescriptionTextBox.Text = ArmorTraitsString + SheetDescriptionString + MaterialTraitsString

    End Sub
    Private Function GetEnergyResistance(ByVal SkillString As String) As String
        'Determine whether this item has Dragonhide resistance
        Dim ResultString As String = ""

        If MaterialsListBox.Items.Count > 0 Then
            If MaterialsListBox.SelectedItem.Equals("Dragonhide") Then

                Dim EnergyResistanceInteger As Integer
                'Determine whether item selected is light, medium, or heavy armor
                If SkillString = "Light Armor" Or SkillString = "Shield" Then
                    EnergyResistanceInteger = 10I
                ElseIf SkillString = "Medium Armor" Then
                    EnergyResistanceInteger = 20I
                Else 'Item is Heavy Armor
                    EnergyResistanceInteger = 30I
                End If

                ResultString += " Gain +" + CStr(EnergyResistanceInteger) + _
                " energy resistance.  (Energy type based on the dragon that " _
                + "provided this dragonhide.)"

            End If
        End If

        Return ResultString

    End Function
    Private Function GetArmorTraits(ByVal SkillString As String) As String

        'Looks for relevant details to display in the armor's description

        Dim DescriptionString As String = ""

        If SkillString = "Light Armor" Then
            DescriptionString = "Light armor takes 2 minutes to put on or take off. " + _
            "It may be slept in without penalty." + Environment.NewLine + Environment.NewLine
        ElseIf SkillString = "Medium Armor" Then
            DescriptionString = "Medium armor takes 5 minutes to put on or take off. " + _
            "Assistance is required to get in and out of this armor.  If slept in, " + _
            "you will wake fatigued." + Environment.NewLine + Environment.NewLine
        ElseIf SkillString = "Heavy Armor" Then
            DescriptionString = "Heavy armor takes 10 minutes to put on or take off. " + _
            "Assistance is required to get in and out of this armor.  If slept in, " + _
            "you will wake fatigued." + Environment.NewLine + Environment.NewLine
        ElseIf Not SkillString = "Shield" Then 'Shields have no special description
            MessageBox.Show("Error in UpdateArmorDescription. Unrecognized armor skill type.", "Error")
        End If

        Return DescriptionString

    End Function

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        'Remove this currently owned item and update array so there's no gap

        Dim ArrayLocationInteger As Integer
        Dim Counter As Integer

        'Search for item in owned item arrays
        ArrayLocationInteger = FindSelectedInventory()

        If ArrayLocationInteger < 0 Then
            'Item was not found anywhere
            MessageBox.Show("Error in RemoveButton_Click. Unable to find owned item.", "Error")
        Else
            'In the array of owned items, replace the item to be removed with 
            'the item after it in the array list.
            Do
                ArrayOfOwnedItems(ArrayLocationInteger) = ArrayOfOwnedItems(ArrayLocationInteger + 1)
                ArrayLocationInteger += 1
            Loop Until ArrayLocationInteger = m_OwnedItemsCounterInteger

            'Update the owned items counter
            m_OwnedItemsCounterInteger -= 1

            'Refresh the inventory listbox
            InventoryListBox.Items.Clear()

            Do Until Counter = m_OwnedItemsCounterInteger
                InventoryListBox.Items.Add(ArrayOfOwnedItems(Counter))
                Counter += 1I
            Loop

        End If

    End Sub
    Private Function FindSelectedInventory() As Integer

        Dim LoopCountInteger As Integer
        Dim ItemFoundBoolean As Boolean

        'Search for item in owned armor
        If m_OwnedItemsCounterInteger > 0 Then
            Do Until LoopCountInteger >= m_OwnedItemsCounterInteger Or ItemFoundBoolean

                'Check whether array's current "owned item" matches selected item
                If InventoryListBox.SelectedItem.Equals(ArrayOfOwnedItems(LoopCountInteger).Name) Then
                    'If found, update boolean
                    ItemFoundBoolean = True
                End If

                'Only increment loop counter if item has not been found
                If Not ItemFoundBoolean Then
                    LoopCountInteger += 1
                End If
            Loop

        End If

        'If item was not found return a -1, otherwise return
        'loop count value of item
        If Not ItemFoundBoolean Then
            LoopCountInteger = -1
        End If

        Return LoopCountInteger

    End Function

    Private Sub FinishedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishedButton.Click
        'Verify user wants to exit the window, then save
        'data and close the window

        Dim WhichButtonDialogResult As DialogResult = MessageBox.Show("Are you done adding/removing equipment?", "Are you sure?", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If WhichButtonDialogResult = DialogResult.Yes Then
            Dim LoopCountInteger As Integer

            'Save owned items
            Do Until m_OwnedItemsCounterInteger = LoopCountInteger
                'Overwrite any data currently existing in the file
                My.Computer.FileSystem.WriteAllText(INVENTORY_FILE_NAME_String, "Inventory List last updated on " & DateString, False)

                If TypeOf ArrayOfOwnedItems(LoopCountInteger) Is WeaponClass Then
                    Dim TempWeapon As WeaponClass = CType(ArrayOfOwnedItems(LoopCountInteger), WeaponClass)
                    My.Computer.FileSystem.WriteAllText(INVENTORY_FILE_NAME_String, "Weapon," & TempWeapon.Name & "," & _
                                                        TempWeapon.Category & "," & TempWeapon.Cost & "," & _
                                                        TempWeapon.Weight & "," & TempWeapon.Description & "," & _
                                                        TempWeapon.Material & "," & TempWeapon.Damage & "," & _
                                                        TempWeapon.Range & "," & TempWeapon.Skill & "," & _
                                                        TempWeapon.Size & "," & TempWeapon.Trait & vbCrLf, True)
                ElseIf TypeOf ArrayOfOwnedItems(LoopCountInteger) Is ArmorClass Then
                    Dim TempArmor As ArmorClass = CType(ArrayOfOwnedItems(LoopCountInteger), ArmorClass)
                    My.Computer.FileSystem.WriteAllText(INVENTORY_FILE_NAME_String, "Armor," & TempArmor.Name & "," & _
                                                        TempArmor.Category & "," & TempArmor.Cost & "," & _
                                                        TempArmor.Weight & "," & TempArmor.Description & "," & _
                                                        TempArmor.Material & "," & TempArmor.DR & "," & _
                                                        TempArmor.CombatDefenseBonus & "," & TempArmor.CombatDefensePenalty & "," & _
                                                        TempArmor.SkillAndFocusPenalty & vbCrLf, True)
                Else
                    My.Computer.FileSystem.WriteAllText(INVENTORY_FILE_NAME_String, "Other," & ArrayOfOwnedItems(LoopCountInteger).Name _
                                                        & "," & ArrayOfOwnedItems(LoopCountInteger).Category & "," & _
                                                        ArrayOfOwnedItems(LoopCountInteger).Cost & "," & _
                                                        ArrayOfOwnedItems(LoopCountInteger).Weight & "," & _
                                                        ArrayOfOwnedItems(LoopCountInteger).Description & vbCrLf, True)
                End If
                LoopCountInteger += 1
            Loop
            'Close window
            Me.Close()
        End If

    End Sub
End Class
