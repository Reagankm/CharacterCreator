Public Class ItemClass

    'Create variables for the Item properties
    Private NameString, CategoryString, DescriptionString As String
    Private CostDecimal, WeightDecimal As Decimal

    'Create constructor to store the variables
    Public Sub New(ByVal NameIn As String, ByVal CategoryIn As String, ByVal _
                   DescriptionIn As String, ByVal CostIn As Decimal, ByVal _
                   WeightIn As Decimal)

        Name = NameIn
        Category = CategoryIn
        Description = DescriptionIn
        Cost = CostIn
        Weight = WeightIn

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
            Return CostDecimal
        End Get
        Set(ByVal value As Decimal)
            CostDecimal = value
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
