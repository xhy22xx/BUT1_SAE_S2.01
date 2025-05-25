
Module Module_Enregistrement
        Public Structure PERS
        Dim Nom As String
        Dim Carres As Integer
        Dim TempsMin As Integer
        Dim Parties As Integer
        Dim TempsTotal As Integer
        Dim Niveau As String
    End Structure

    Private TPERS() As PERS
    Private index As Integer = -1


    Public Sub AJOUT(nom As String, carres As Integer, tempsMin As Integer, parties As Integer, tempsTotal As Integer, niveau As String)
        index += 1
        ReDim Preserve TPERS(index)
        TPERS(index).Nom = nom
        TPERS(index).Carres = carres
        TPERS(index).TempsMin = tempsMin
        TPERS(index).Parties = parties
        TPERS(index).TempsTotal = tempsTotal
        TPERS(index).Niveau = niveau
    End Sub

    Public Function GetPersonnes() As PERS()
        Return TPERS
    End Function

    Public Sub ChangerStats(nom As String, nbCarres As Integer, tempsUtilise As Integer, niveau As String)
        For i As Integer = 0 To index
            If TPERS(i).Nom = nom AndAlso TPERS(i).Niveau = niveau Then
                TPERS(i).Parties += 1
                TPERS(i).TempsTotal += tempsUtilise

                If nbCarres > TPERS(i).Carres Then
                    TPERS(i).Carres = nbCarres
                    TPERS(i).TempsMin = tempsUtilise
                ElseIf nbCarres = TPERS(i).Carres AndAlso tempsUtilise < TPERS(i).TempsMin Then
                    TPERS(i).TempsMin = tempsUtilise
                End If

                Exit Sub
            End If
        Next

        AJOUT(nom, nbCarres, tempsUtilise, 1, tempsUtilise, niveau)
    End Sub

End Module

