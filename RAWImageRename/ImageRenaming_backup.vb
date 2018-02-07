Option Explicit On
Option Strict On
Option Infer On
Option Compare Text

Imports System.IO
Module ImageRenaming
    Public Const IMAGE_EXTENTION As String = ".NEF"
    Public Const SIDECAR_EXTENTION As String = ".xmp"
    Public Const DIR_PATH As String = "C:\Users\Ray\Desktop\ImageProject\Images\New"
    Sub UserFormSubmit(ByVal targetDirectory As String, ByVal UseDate As Boolean, Optional ByVal newName As String = Nothing, Optional ByVal startingNumber As Integer = -1)


        Const STARTING_NUMBER As Integer = 1
        Const APPEND_DATE As Boolean = True

        If Not Directory.Exists(DIR_PATH) Then Exit Sub
        Dim arrayOfFiles() As String = RetrieveFileNames(DIR_PATH)
        If arrayOfFiles.Length = 0 Then Exit Sub
        Dim fileName As String

        Dim numberOfFiles As Integer
        Dim countOfRenames As Integer = STARTING_NUMBER

        'WHAT IF A FILE OF THAT NAME EXISTS?
        For index As Integer = 0 To arrayOfFiles.Length - 1
            fileName = arrayOfFiles(index)
            If Path.GetExtension(fileName) = IMAGE_EXTENTION Then
                If arrayOfFiles.Contains(Path.GetFileNameWithoutExtension(fileName) & SIDECAR_EXTENTION) Then
                    numberOfFiles = 2
                Else
                    numberOfFiles = 1
                End If
                countOfRenames = MyRefactor(Path.GetFileNameWithoutExtension(fileName), numberOfFiles, APPEND_DATE, countOfRenames)
            End If
        Next

    End Sub

    Private Function MyRefactor(fileName As String, ByVal numberOfFiles As Integer, ByVal useDate As Boolean, ByVal countOfRenames As Integer, Optional ByVal newFileNameBase As String = Nothing) As Integer
        Const FILENAME_EXTENDER As String = "_"
        Dim newFileName As String
        If Not newFileNameBase = Nothing Then
            newFileName = newFileNameBase & FILENAME_EXTENDER
        Else
            newFileName = fileName & FILENAME_EXTENDER
        End If

        Dim appendString As String = countOfRenames.ToString

        If numberOfFiles = 2 Then
            If useDate Then appendString = GetFileDate(Path.ChangeExtension(fileName, SIDECAR_EXTENTION))
            newFileName += appendString
            RenamePhotoFiles(fileName, newFileName, numberOfFiles)
        Else
            'rename one
        End If
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
    Private Sub RenamePhotoFiles(ByVal oldName As String, ByVal newName As String, ByVal numberOfFiles As Integer)
        If numberOfFiles = 2 Then File.Move(DIR_PATH & oldName & SIDECAR_EXTENTION, DIR_PATH & newName & SIDECAR_EXTENTION)
        File.Move(DIR_PATH & oldName & IMAGE_EXTENTION, DIR_PATH & newName & IMAGE_EXTENTION)
    End Sub

    Private Function GetFileDate(ByVal sidecarFile As String) As String
        Const LINE_START As String = "   exif:DateTimeOriginal="
        Const DATE_STRING_LENGTH As Integer = 10
        Const CHAR_TO_REMOVE As String = "-"
        sidecarFile = DIR_PATH & sidecarFile
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
