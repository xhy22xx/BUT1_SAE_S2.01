
Module Module_Enregistrement
        Public Structure PERS
            Dim Nom As String
        End Structure

    Private TPERS() As PERS
    Private index As Integer = 0


    Public Sub AJOUT(nom As String)
        ReDim TPERS(index + 1)
        TPERS(index + 1).Nom = nom

    End Sub

    Public Function GetPersonnes() As PERS()
            Return TPERS
        End Function

    End Module

