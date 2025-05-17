
Module Module_Enregistrement
        Public Structure PERS
        Dim Nom As String
        Dim Carres As Integer
        Dim TempsMin As Integer
        Dim Parties As Integer
        Dim TempsTotal As Integer
    End Structure

    Private TPERS() As PERS
    Private index As Integer = -1


    Public Sub AJOUT(nom As String, carres As Integer, tempsMin As Integer, parties As Integer, tempsTotal As Integer)
        index += 1
        ReDim Preserve TPERS(index)
        TPERS(index).Nom = nom
        TPERS(index).Carres = carres
        TPERS(index).TempsMin = tempsMin
        TPERS(index).Parties = parties
        TPERS(index).TempsTotal = tempsTotal
    End Sub

    Public Function GetPersonnes() As PERS()
            Return TPERS
        End Function

    End Module

