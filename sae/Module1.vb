
Module Module_Enregistrement
        Public Structure PERS
            Dim Nom As String
        End Structure

        Private TPERS() As PERS
        Private index As Integer = 0


        Public Sub AJOUT(nom As String)
            TPERS(index).Nom = nom
            index += 1
        End Sub

        Public Function GetPersonnes() As PERS()
            Return TPERS
        End Function

    End Module

