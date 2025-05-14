
Module Module_Enregistrement
        Public Structure PERS
            Dim Nom As String
        End Structure

    Private TPERS() As PERS
    Private index As Integer = -1


    Public Sub AJOUT(nom As String)
        index += 1
        ReDim Preserve TPERS(index)
        TPERS(index).Nom = nom

    End Sub

    Public Function GetPersonnes() As PERS()
            Return TPERS
        End Function

    End Module

