Option Strict Off
Option Explicit On
Module KeyCode
    ' *
    ' * KeyCodeGen Module
    ' * Copyright (C) 2007 John Mazza.
    ' *
    ' * Written by John Mazza <maz@mgcworks.com>
    ' *
    ' * This library is free software; you can redistribute it and/or
    ' * modify it under the terms of the GNU Lesser General Public
    ' * License Version 2.1 as published by the Free Software Foundation.
    ' *
    ' * This library is distributed in the hope that it will be useful,
    ' * but WITHOUT ANY WARRANTY; without even the implied warranty of
    ' * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    ' * Lesser General Public License for more details.
    ' *
    ' * You should have received a copy of the GNU Lesser General Public
    ' * License along with this library; if not, write to the Free Software
    ' * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
    ' ****************************************************************************
    '
    '
    ' PURPOSE
    '    Generate a licening key code that encodes product features into the
    '    "keycode" string securely.
    '
    ' LANGUAGE
    '    Visual Basic 6.0 or VBA6
    '    Should work in VB.NET as well
    '
    ' DEPENDENCIES:
    '    Requires 'Visual Basic MD5 Implementation' by
    '              Robert Hubley and David Midkiff (mdj2023@hotmail.com) and
    '              StrFuncs module by John Mazza
    '


    ' GenKeyString() generates the actual keycode string based on
    ' modified MD5 hashes of Username, Product, and licensed "features"

    Public Function GenKeyString(ByVal UserName As Object, ByRef ProdName As String, ByRef F_Code As Integer) As String
        Dim StubStr As Object
        Dim RC2 As Object
        Dim RC1 As Object
        Dim RawChk As Object
        Dim ChrV2 As Object
        Dim ChrV1 As Object
        Dim KeyLow2 As Object
        Dim KeyLow1 As Object

        Dim TempStr As String
        Dim KeyStr As String
        Dim KeyVal As String
        Dim CodeVal As Integer
        Dim CodeLow As Byte
        Dim CodeHigh As Byte
        Dim KeyLowV1 As Byte
        Dim KeyLowV2 As Byte

        ' Make sure we're not case-sensitive since that is a pain for end users

        'UPGRADE_WARNING: Couldn't resolve default property of object UserName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TempStr = LCase(UserName) & LCase(ProdName)
        KeyStr = DigestStrToHexStr(TempStr)
        KeyVal = HexStrToBinStr(KeyStr)

        ' Mask off low order 16 bits from F_Code
        CodeVal = F_Code And &HFFFF
        CodeLow = CodeVal And &HFF
        CodeHigh = ((CShort(CodeVal And &HFF00) / 256) And &HFF)

        'UPGRADE_WARNING: Couldn't resolve default property of object KeyLow1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        KeyLow1 = Mid(KeyVal, Len(KeyVal), 1)
        'UPGRADE_WARNING: Couldn't resolve default property of object KeyLow2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        KeyLow2 = Mid(KeyVal, Len(KeyVal) - 1, 1)

        'UPGRADE_WARNING: Couldn't resolve default property of object KeyLow1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        KeyLowV1 = Asc(KeyLow1)
        'UPGRADE_WARNING: Couldn't resolve default property of object KeyLow2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        KeyLowV2 = Asc(KeyLow2)

        KeyLowV1 = (KeyLowV1 Xor CodeLow)
        KeyLowV2 = (KeyLowV2 Xor CodeHigh)

        'KeyLowV1 = KeyLowV1 Xor KeyLowV2
        'UPGRADE_WARNING: Couldn't resolve default property of object ChrV1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ChrV1 = Chr(KeyLowV1)
        'UPGRADE_WARNING: Couldn't resolve default property of object ChrV2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ChrV2 = Chr(KeyLowV2)

        ' Cut original first 2 bytes from KeyVal string
        KeyVal = Mid(KeyVal, 1, Len(KeyVal) - 2)

        ' Now append modified bytes
        'UPGRADE_WARNING: Couldn't resolve default property of object ChrV1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ChrV2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        KeyVal = KeyVal & ChrV2 & ChrV1
        'KeyVal = KeyVal & ChrV1

        ' Now we get sneaky and modify the KeyVal by replacing the first 2 bytes
        ' of KeyVal with the first and last bytes of the MD5 of KeyVal minus first 2 bytes

        KeyVal = Mid(KeyVal, 3, Len(KeyVal) - 2)

        'UPGRADE_WARNING: Couldn't resolve default property of object RawChk. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        RawChk = DigestStrToHexStr(KeyVal)

        'UPGRADE_WARNING: Couldn't resolve default property of object RawChk. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object RC1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        RC1 = Mid(RawChk, 1, 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object RawChk. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object RC2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        RC2 = Mid(RawChk, Len(RawChk) - 1, 2)

        'UPGRADE_WARNING: Couldn't resolve default property of object StubStr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StubStr = BinStrToHexStr(KeyVal)

        'UPGRADE_WARNING: Couldn't resolve default property of object StubStr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object RC2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object RC1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GenKeyString = RC1 & RC2 & StubStr

    End Function

    ' ValidateKeyCode() validates that a keycode is valid.
    ' Basically it is the inverse of GenKeyString()

    Public Function ValidateKeyCode(ByVal KeyCode As Object, ByRef UserName As Object, ByRef ProjName As String) As Boolean
        Dim ValidSig As Object
        Dim BinKeyCode As Object
        Dim ActiveBytes As String
        Dim LUNameHash As String
        Dim LUName As String
        Dim ValidKey As Boolean
        Dim KeyMD5 As String
        Dim KeySig As String

        ValidKey = False

        ' Key must be 32 bytes long - otherwise reject immediately

        If Len(KeyCode) = 32 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object BinKeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            BinKeyCode = HexStrToBinStr(KeyCode)
            'UPGRADE_WARNING: Couldn't resolve default property of object BinKeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ActiveBytes = Right(BinKeyCode, 14)
            KeyMD5 = DigestStrToHexStr(ActiveBytes)
            'UPGRADE_WARNING: Couldn't resolve default property of object ValidSig. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ValidSig = Left(KeyMD5, 2) & Right(KeyMD5, 2)
            'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            KeySig = Left(KeyCode, 4)

            'UPGRADE_WARNING: Couldn't resolve default property of object ValidSig. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If KeySig = ValidSig Then
                ValidKey = True
            Else
                ValidKey = False
            End If

            If ValidKey Then
                'UPGRADE_WARNING: Couldn't resolve default property of object UserName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                LUName = LCase(UserName) & LCase(ProjName)
                LUNameHash = DigestStrToHexStr(LUName)

                'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ActiveBytes = Mid(KeyCode, 5, 24)
                LUNameHash = Mid(LUNameHash, 5, 24)

                If ActiveBytes = LUNameHash Then
                    ValidKey = True
                Else
                    ValidKey = False
                End If
            End If

        Else
            ValidKey = False
        End If

        ValidateKeyCode = ValidKey

    End Function


    ' ExtractKeyFBits() returns the bitmap originally passed as F_Code
    ' when a key is created with GenKeyString()
    ' Note: it will return zero (0) if an invalid keycode is passed or if
    '       username or projectname are not a match.

    Public Function ExtractKeyFBits(ByVal KeyCode As Object, ByRef UserName As Object, ByRef ProjName As String) As Object
        Dim LoCodePerm As Object
        Dim UHashPerm As Object
        Dim KCodedPerm As Object
        Dim UserHash As Object
        Dim PermVal As Integer
        Dim RealHash As String
        Dim LUser As String
        Dim Perms As Integer
        Dim BinCodePerm As String
        Dim BinUHashPerm As String
        Dim HiCodePerm As Byte
        Dim HIUMask As Byte
        Dim LoUMask As Byte
        Dim HiPerm As Integer
        Dim LoPerm As Integer

        PermVal = 0

        If ValidateKeyCode(KeyCode, UserName, ProjName) Then

            'UPGRADE_WARNING: Couldn't resolve default property of object UserName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LUser = LCase(UserName) & LCase(ProjName)
            'UPGRADE_WARNING: Couldn't resolve default property of object UserHash. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            UserHash = DigestStrToHexStr(LUser)
            'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object KCodedPerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            KCodedPerm = Right(KeyCode, 4)
            'UPGRADE_WARNING: Couldn't resolve default property of object UserHash. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object UHashPerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            UHashPerm = Right(UserHash, 4)

            'UPGRADE_WARNING: Couldn't resolve default property of object KCodedPerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            BinCodePerm = HexStrToBinStr(KCodedPerm)
            'UPGRADE_WARNING: Couldn't resolve default property of object UHashPerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            BinUHashPerm = HexStrToBinStr(UHashPerm)

            HiCodePerm = Asc(Mid(BinCodePerm, 1, 1))
            'UPGRADE_WARNING: Couldn't resolve default property of object LoCodePerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LoCodePerm = Asc(Mid(BinCodePerm, 2, 1))

            HIUMask = Asc(Mid(BinUHashPerm, 1, 1))
            LoUMask = Asc(Mid(BinUHashPerm, 2, 1))

            HiPerm = HiCodePerm Xor HIUMask
            LoPerm = LoCodePerm Xor LoUMask
            PermVal = (HiPerm * 256) Or LoPerm

        Else
            PermVal = 0
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object ExtractKeyFBits. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ExtractKeyFBits = PermVal

    End Function

    Public Function FormatKeyCode(ByVal StrIn As String, ByVal GrpLen As Integer) As String
        Dim StrLeftOver As Object
        Dim StrGroups As Object
        Dim StrLen As Integer
        Dim CurGrp As Integer
        Dim OutStr As String
        Dim GrpStr As String
        Dim GrpStart As Integer

        StrLen = Len(StrIn)

        'UPGRADE_WARNING: Couldn't resolve default property of object StrGroups. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrGroups = Int(StrLen / GrpLen)
        'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrLeftOver = StrLen Mod GrpLen

        ' Run loop to add dashes into StrIn

        'UPGRADE_WARNING: Couldn't resolve default property of object StrGroups. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        For CurGrp = 0 To (StrGroups - 1)
            GrpStart = (CurGrp * GrpLen) + 1
            GrpStr = Mid(StrIn, GrpStart, GrpLen)

            If CurGrp > 0 Then
                OutStr = OutStr & "-" & GrpStr
            Else
                OutStr = OutStr & GrpStr
            End If

        Next CurGrp

        ' Append a final group if any leftover charaters
        ' exist in StrIn

        'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If StrLeftOver > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutStr = OutStr & "-" & Right(StrIn, StrLeftOver)
        End If

        FormatKeyCode = OutStr
    End Function
End Module