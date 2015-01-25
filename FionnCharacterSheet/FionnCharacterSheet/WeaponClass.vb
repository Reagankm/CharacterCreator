Public Class WeaponClass
    Inherits EquipmentClass

    Private MaterialString As String
    Private DamageString As String
    Private RangeString As String
    Private SkillString As String
    Private SizeString As String
    Private TraitString As String

    'Create constructor to store the variables
    Public Sub New(ByVal NameIn As String, ByVal CategoryIn As String, ByVal _
                   CostIn As Integer, ByVal WeightIn As Decimal, ByVal DescriptionIn As String, _
                   ByVal MaterialIn As String, ByVal DamageIn As String, ByVal RangeIn As String, ByVal SkillIn _
                   As String, ByVal SizeIn As String, ByVal TraitIn As String)
        MyBase.New(NameIn, CategoryIn, CostIn, WeightIn, DescriptionIn)

        MaterialString = MaterialIn
        DamageString = DamageIn
        RangeString = RangeIn
        SkillString = SkillIn
        SizeString = SizeIn
        TraitString = TraitIn

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

    Property Damage() As String
        Get
            Return DamageString
        End Get
        Set(ByVal value As String)
            DamageString = value
        End Set
    End Property

    Property Range() As String
        Get
            Return RangeString
        End Get
        Set(ByVal value As String)
            RangeString = value
        End Set
    End Property

    Property Skill() As String
        Get
            Return SkillString
        End Get
        Set(ByVal value As String)
            SkillString = value
        End Set
    End Property

    Property Size() As String
        Get
            Return SizeString
        End Get
        Set(ByVal value As String)
            SizeString = value
        End Set
    End Property

    Property Trait() As String
        Get
            Return TraitString
        End Get
        Set(ByVal value As String)
            TraitString = value
        End Set
    End Property

End Class
