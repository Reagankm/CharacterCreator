Public Class FocusClass
    Inherits SkillClass

    Private FocusRanksInteger As Integer

    Public Sub New(ByVal NameIn As String, ByVal AttributeIn As String, ByVal _
                   ArmorPenaltyIn As Boolean, ByVal TrainingRequiredIn As Boolean, _
                   ByVal StartingSkillIn As Boolean, ByVal AddlTextIn As String, _
                   ByVal SkillRanksIn As Integer, ByVal TrainedIn As Boolean, _
                   ByVal SpecializedIn As Boolean, ByVal FocusRanksIn As Integer)

        MyBase.New(NameIn, AttributeIn, ArmorPenaltyIn, TrainingRequiredIn, _
                   StartingSkillIn, AddlTextIn, SkillRanksIn, TrainedIn, SpecializedIn)

        FocusRanksInteger = FocusRanksIn


    End Sub

    Public Sub New(ByVal NameIn As String, ByVal AttributeIn As String, ByVal _
                   ArmorPenaltyIn As Boolean, ByVal TrainingRequiredIn As Boolean, _
                   ByVal StartingSkillIn As Boolean, ByVal AddlTextIn As String)

        MyBase.New(NameIn, AttributeIn, ArmorPenaltyIn, TrainingRequiredIn, _
                   StartingSkillIn, AddlTextIn)

        FocusRanksInteger = 0

    End Sub

End Class
