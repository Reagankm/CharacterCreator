Public Class SkillClass

    Private NameString, AttributeString, AddlTextString As String
    Private ArmorPenaltyBoolean, TrainingRequiredBoolean, _
    StartingSkillBoolean, TrainedBoolean, SpecializedBoolean As Boolean
    Private SkillRanksInteger As Integer
    Private FocusesArray() As FocusClass

    'Create constructor to store the variables
    Public Sub New(ByVal NameIn As String, ByVal AttributeIn As String, ByVal _
                   ArmorPenaltyIn As Boolean, ByVal TrainingRequiredIn As Boolean, _
                   ByVal StartingSkillIn As Boolean, ByVal AddlTextIn As String, _
                   ByVal SkillRanksIn As Integer, ByVal TrainedIn As Boolean, _
                   ByVal SpecializedIn As Boolean)

        NameString = NameIn
        AttributeString = AttributeIn
        ArmorPenaltyBoolean = ArmorPenaltyIn
        TrainingRequiredBoolean = TrainingRequiredIn
        StartingSkillBoolean = StartingSkillIn
        AddlTextString = AddlTextIn
        SkillRanksInteger = SkillRanksIn
        TrainedBoolean = TrainedIn
        SpecializedBoolean = SpecializedIn

    End Sub
    Public Sub New(ByVal NameIn As String, ByVal AttributeIn As String, ByVal _
                   ArmorPenaltyIn As Boolean, ByVal TrainingRequiredIn As Boolean, _
                   ByVal StartingSkillIn As Boolean, ByVal AddlTextIn As String)

        NameString = NameIn
        AttributeString = AttributeIn
        ArmorPenaltyBoolean = ArmorPenaltyIn
        TrainingRequiredBoolean = TrainingRequiredIn
        StartingSkillBoolean = StartingSkillIn
        AddlTextString = AddlTextIn
        SkillRanksInteger = 0
        TrainedBoolean = False
        SpecializedBoolean = False

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

    Property Attribute() As String
        Get
            Return AttributeString
        End Get
        Set(ByVal value As String)
            AttributeString = value
        End Set
    End Property
    Property ArmorPenalty() As Boolean
        Get
            Return ArmorPenaltyBoolean
        End Get
        Set(ByVal value As Boolean)
            ArmorPenaltyBoolean = value
        End Set
    End Property
    Property TrainingRequired() As Boolean
        Get
            Return TrainingRequiredBoolean
        End Get
        Set(ByVal value As Boolean)
            TrainingRequiredBoolean = value
        End Set
    End Property
    Property StartingSkill() As Boolean
        Get
            Return StartingSkillBoolean
        End Get
        Set(ByVal value As Boolean)
            StartingSkillBoolean = value
        End Set
    End Property
    Property AddlText() As String
        Get
            Return AddlTextString
        End Get
        Set(ByVal value As String)
            AddlTextString = value
        End Set
    End Property
    Property SkillRanks() As Integer
        Get
            Return SkillRanksInteger
        End Get
        Set(ByVal value As Integer)
            SkillRanksInteger = value
        End Set
    End Property
    Property Trained() As Boolean
        Get
            Return TrainedBoolean
        End Get
        Set(ByVal value As Boolean)
            TrainedBoolean = value
        End Set
    End Property
    Property Specialized() As Boolean
        Get
            Return SpecializedBoolean
        End Get
        Set(ByVal value As Boolean)
            SpecializedBoolean = value
        End Set
    End Property

End Class
