Public Class ArmorClass
    Inherits EquipmentClass

    Private MaterialString As String
    Private DRInteger As Integer
    Private CombatDefenseBonusInteger As Integer
    Private CombatDefensePenaltyInteger As Integer
    Private SkillAndFocusPenaltyInteger As Integer

    'Create constructor to store the variables
    Public Sub New(ByVal NameIn As String, ByVal CategoryIn As String, ByVal _
                   CostIn As Integer, ByVal WeightIn As Decimal, ByVal DescriptionIn As String, _
                   ByVal MaterialIn As String, ByVal DRIn As Integer, ByVal CombDefBonusIn As Integer, ByVal CombDefPenaltyIn _
                   As Integer, ByVal SkillFocusPenaltyIn As Integer)
        MyBase.New(NameIn, CategoryIn, CostIn, WeightIn, DescriptionIn)

        MaterialString = MaterialIn
        DRInteger = DRIn
        CombatDefenseBonusInteger = CombDefBonusIn
        CombatDefensePenaltyInteger = CombDefPenaltyIn
        SkillAndFocusPenaltyInteger = SkillFocusPenaltyIn

    End Sub

    'Create property procedures for the variables
    Property Material() As String
        Get
            Return MaterialString
        End Get
        Set(ByVal value As String)
            MaterialString = value
        End Set
    End Property

    Property DR() As Integer
        Get
            Return DRInteger
        End Get
        Set(ByVal value As Integer)
            DRInteger = value
        End Set
    End Property

    Property CombatDefenseBonus() As Integer
        Get
            Return CombatDefenseBonusInteger
        End Get
        Set(ByVal value As Integer)
            CombatDefenseBonusInteger = value
        End Set
    End Property

    Property CombatDefensePenalty() As Integer
        Get
            Return CombatDefensePenaltyInteger
        End Get
        Set(ByVal value As Integer)
            CombatDefensePenaltyInteger = value
        End Set
    End Property

    Property SkillAndFocusPenalty() As Integer
        Get
            Return SkillAndFocusPenaltyInteger
        End Get
        Set(ByVal value As Integer)
            SkillAndFocusPenaltyInteger = value
        End Set
    End Property

End Class
