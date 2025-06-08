
Imports System.IO

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

    Public Sub InitialiserJoueur(nom As String, niveau As String)
        For i As Integer = 0 To index
            If TPERS(i).Nom = nom AndAlso TPERS(i).Niveau = niveau Then
                Exit Sub
            End If
        Next

        AJOUT(nom, 0, 0, 0, 0, niveau)
    End Sub
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

        AJOUT(nom, nbCarres, tempsUtilise, 0, tempsUtilise, niveau)
    End Sub

    Public Sub ChargerDepuisFichier()
        If Not File.Exists("donneesDuJeu.txt") Then Exit Sub

        Dim lignes = File.ReadAllLines("donneesDuJeu.txt")
        For Each ligne In lignes
            Dim champs = ligne.Split("|"c)
            If champs.Length = 6 Then
                AJOUT(champs(0), CInt(champs(1)), CInt(champs(2)), CInt(champs(3)), CInt(champs(4)), champs(5))
            End If
        Next
    End Sub

    Public Sub SauvegarderDansFichier()
        Dim f As New StreamWriter("donneesDuJeu.txt", False)
        Dim personnes = GetPersonnes()
        If personnes Is Nothing Then Exit Sub
        For Each p In GetPersonnes()
            f.WriteLine($"{p.Nom}|{p.Carres}|{p.TempsMin}|{p.Parties}|{p.TempsTotal}|{p.Niveau}")
        Next
        f.Close()
    End Sub

End Module

