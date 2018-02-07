Option Explicit On
Option Strict On
Option Infer On
Option Compare Text

Imports System.IO
Module ImageRenaming
    Public Const IMAGE_EXTENTION As String = ".NEF"
    Public Const SIDECAR_EXTENTION As String = ".xmp"

    Public Sub UserFormSubmit(ByVal targetDirectory As String, ByVal UseDate As Boolean, Optional ByVal newName As String = Nothing, Optional ByVal startingNumber As Integer = -1)

        If Not Directory.Exists(targetDirectory) Then Exit Sub
        Dim arrayOfFiles() As String = RetrieveFileNames(targetDirectory)
        If arrayOfFiles.Length = 0 Then Exit Sub
        Dim fileName As String

        Dim numberOfFiles As Integer
        Dim countOfRenames As Integer = startingNumber
        If startingNumber = -1 Then countOfRenames = 1

        'WHAT IF A FILE OF THAT NAME EXISTS?
        For index As Integer = 0 To arrayOfFiles.Length - 1
            fileName = arrayOfFiles(index)
            If Path.GetExtension(fileName) = IMAGE_EXTENTION Then
                If arrayOfFiles.Contains(Path.GetFileNameWithoutExtension(fileName) & SIDECAR_EXTENTION) Then
                    numberOfFiles = 2
                Else
                    numberOfFiles = 1
                End If
                countOfRenames = MyRefactor(targetDirectory, Path.GetFileNameWithoutExtension(fileName), numberOfFiles, UseDate, countOfRenames, newName)
            End If
        Next

    End Sub

    Private Function MyRefactor(ByVal targetDirectory As String, ByVal fileName As String, ByVal numberOfFiles As Integer, ByVal useDate As Boolean, ByVal countOfRenames As Integer, Optional ByVal newFileNameBase As String = Nothing) As Integer

        Dim newFileName As String
        If Not newFileNameBase = Nothing And useDate Then
            newFileName = newFileNameBase & countOfRenames
        ElseIf newFileName = Nothing Then
            newFileName = newFileNameBase
        Else
            newFileName = fileName
        End If
        newFileName += "_"
        Dim appendString As String = countOfRenames.ToString

        If numberOfFiles = 2 Then
            If useDate Then appendString = GetFileDate(targetDirectory, Path.ChangeExtension(fileName, SIDECAR_EXTENTION))
            newFileName += appendString

        End If
        RenamePhotoFiles(targetDirectory, fileName, newFileName, numberOfFiles)

        countOfRenames += 1
        Return countOfRenames
    End Function
    Private Function RetrieveFileNames(ByVal targetPath As String) As String()
        Dim fileArray() As String = Directory.GetFiles(targetPath)
        For i As Integer = 0 To fileArray.Length - 1
            fileArray(i) = Path.GetFileName(fileArray(i))
        Next
        Return fileArray
    End Function
    Private Sub RenamePhotoFiles(ByVal targetDirectory As String, ByVal oldName As String, ByVal newName As String, ByVal numberOfFiles As Integer)
        If numberOfFiles = 2 Then
            File.Move(targetDirectory & oldName & SIDECAR_EXTENTION, targetDirectory & newName & SIDECAR_EXTENTION)
        End If
        File.Move(targetDirectory & oldName & IMAGE_EXTENTION, targetDirectory & newName & IMAGE_EXTENTION)
    End Sub

    Private Function GetFileDate(ByVal targetDirectory As String, ByVal sidecarFile As String) As String
        Const LINE_START As String = "   exif:DateTimeOriginal="
        Const DATE_STRING_LENGTH As Integer = 10
        Const CHAR_TO_REMOVE As String = "-"
        sidecarFile = targetDirectory & sidecarFile
        Dim lines = File.ReadAllLines(sidecarFile)
        Dim targetLine As String = Nothing
        For i As Integer = 0 To lines.Length - 1
            If lines(i).StartsWith(LINE_START) Then
                targetLine = lines(i)
                Exit For
            End If
        Next
        If targetLine.Length = 0 Then Return Nothing
        targetLine = targetLine.Substring(LINE_START.Length + 1, DATE_STRING_LENGTH)
        Return targetLine.Replace(CHAR_TO_REMOVE, "")
    End Function


End Module
