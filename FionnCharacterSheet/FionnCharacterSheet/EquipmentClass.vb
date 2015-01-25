Public Class EquipmentClass

    Private NameString As String
    Private CategoryString As String
    Private CostInteger As Integer
    Private WeightDecimal As Decimal
    Private DescriptionString As String

    'Create constructor to store the variables
    Public Sub New(ByVal NameIn As String, ByVal CategoryIn As String, ByVal _
                   CostIn As Integer, ByVal WeightIn As Decimal, ByVal DescriptionIn As String)

        NameString = NameIn
        CategoryString = CategoryIn
        CostInteger = CostIn
        WeightDecimal = WeightIn
        DescriptionString = DescriptionIn

    End Sub

    'Create property procedures for the variables
    Property Name() As String
        Get
            Return NameString
        End Get
        Set(ByVal value As String)
            NameString = value
        End Set
    End Property

    Property Category() As String
        Get
            Return CategoryString
        End Get
        Set(ByVal value As String)
            CategoryString = value
        End Set
    End Property

    Property Description() As String
        Get
            Return DescriptionString
        End Get
        Set(ByVal value As String)
            DescriptionString = value
        End Set
    End Property

    Property Cost() As Decimal
        Get
            Return CostInteger
        End Get
        Set(ByVal value As Decimal)
            CostInteger = value
        End Set
    End Property

    Property Weight() As Decimal
        Get
            Return WeightDecimal
        End Get
        Set(ByVal value As Decimal)
            WeightDecimal = value
        End Set
    End Property


End Class
