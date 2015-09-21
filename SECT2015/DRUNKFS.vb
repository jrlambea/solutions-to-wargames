Imports System

Module Main

    Structure File
        Dim Offset As Long
        Dim data() As Byte
        Dim Sum As Integer
    End Structure

    Function GetFileOffsets(ByVal FileName As String) As File()

        Dim br As New IO.BinaryReader(IO.File.Open(FileName, IO.FileMode.Open))
        Dim FileLen As Long = br.BaseStream.Length
        Dim Files() As File = {}

        Dim check As Long = 0

        While br.BaseStream.Position < FileLen

            If br.ReadByte() = 255 Then
                If br.ReadByte() = 216 Then
                    If br.ReadByte() = 255 Then
                        If br.ReadByte() = 224 Then
                            br.ReadBytes(2)

                            If br.ReadBytes(4).SequenceEqual({74, 70, 73, 70}) Then
                                ReDim Preserve Files(Files.Count)
                                Files(UBound(Files)).Offset = br.BaseStream.Position - 10

                                For i = 0 To 100 Step 1 : Files(UBound(Files)).Sum += br.ReadByte : Next

                            End If
                        End If
                    End If
                End If
            End If

        End While

        br.Close()

        Return Files

    End Function

    Sub Main()
        Console.WriteLine("  ________________________________________" & vbCrLf &
                          " /   _____/\_   _____/\_   ___ \__    ___/" & vbCrLf &
                          " \_____  \  |    __)_ /    \  \/ |    |   " & vbCrLf &
                          " /        \ |        \\     \____|    |   " & vbCrLf &
                          "/_______  //_______  / \______  /|____|   " & vbCrLf &
                          "        \/         \/         \/ 2015" & vbCrLf)

        Console.WriteLine("Challenge DRUNK-FS ( Forensics - 200 )")
        Console.WriteLine("JFIF File Extractor")
        Console.WriteLine("JR. Lambea" & vbCrLf)

        If My.Application.CommandLineArgs.Count <> 1 Then
            Console.WriteLine("USE: $0 img")
            Environment.Exit(1)
        End If

        Dim FileName As String = My.Application.CommandLineArgs(0)

        If Not IO.File.Exists(FileName) Then
            Console.WriteLine("Error: File " & IO.Path.GetFileName(FileName) & " does not exists.")
            Environment.Exit(2)
        End If

        Console.WriteLine("Analyzing " & IO.Path.GetFileName(FileName) & "...")

        Dim Files() As File = GetFileOffsets(FileName)

        Console.WriteLine("Offsets & 100 fst. bytes summarize:")

        For Each F In Files
            Console.WriteLine("    0x" & F.Offset.ToString("X8") & " Sum: 0x" & F.Sum.ToString("X8"))
        Next

        Console.WriteLine(vbCrLf & "Total: " & Files.Count & " objects.")

        Console.ReadKey()
    End Sub

End Module
