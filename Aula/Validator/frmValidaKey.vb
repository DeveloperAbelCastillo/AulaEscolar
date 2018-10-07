Option Strict Off
Option Explicit On
Public Class frmValidaKey
    Inherits System.Windows.Forms.Form
    ' * KeyCodeDemo
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
    ' Check input KeyCode
    ' Must match with code calculated for Username/ProdName/MyProductName combo

    ' Make sure this matches the MyProductName used in key generation!
    Private Const MyProductName As String = "KeyCodeDemoV1"

    Private Function IsKeyValid(ByVal KeyCode As Object, ByRef UserName As Object, ByRef ProdName As String) As Boolean
        Dim BinKey As String
        Dim IsValid As Boolean
        Dim HexKey As String

        IsValid = False

        ' First, decode Base32 string into binary one
        ' Remove any dashes in input string

        'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        BinKey = Base32Dec(RemoveDashes(KeyCode))

        HexKey = BinStrToHexStr(BinKey)
        IsValid = ValidateKeyCode(HexKey, UserName, ProdName & MyProductName)


        IsKeyValid = IsValid

    End Function

    Private Function GetKeyFeat(ByVal KeyCode As Object, ByRef UserName As Object, ByRef ProdName As String) As Integer
        Dim IsValid As Object
        Dim BinKey As String
        Dim FeatBMP As Integer
        Dim HexKey As String

        'UPGRADE_WARNING: Couldn't resolve default property of object IsValid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        IsValid = False

        ' First, decode Base32 string into binary one
        ' Remove any dashes in input string

        'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        BinKey = Base32Dec(RemoveDashes(KeyCode))

        ' Check length of BinKey - must be 16 to be valid
        If Len(BinKey) = 16 Then
            HexKey = BinStrToHexStr(BinKey)
            'UPGRADE_WARNING: Couldn't resolve default property of object ExtractKeyFBits(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            FeatBMP = ExtractKeyFBits(HexKey, UserName, ProdName & MyProductName)
        Else
            FeatBMP = 0
        End If

        GetKeyFeat = FeatBMP

    End Function

    Private Sub BtnReg_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnReg.Click
        Dim features As Object
        Dim UNameT As String
        Dim SerNoT As String
        Dim LKeyT As String

        UNameT = Trim(UName.Text)
        SerNoT = Trim(SerNo.Text)
        LKeyT = Trim(LKey.Text)

        If IsKeyValid(LKeyT, UNameT, SerNoT) Then


            'X = MsgBox("License Key Okay", vbInformation, "Success")

            'UPGRADE_WARNING: Couldn't resolve default property of object features. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            features = GetKeyFeat(LKeyT, UNameT, SerNoT)
            Stat.Text = "Licencia Valida."
            Stat.BackColor = Color.Green
            Stat.BackColor = Color.Red
            'UPGRADE_WARNING: Couldn't resolve default property of object features. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Call DoCheckBoxes(features)
        Else
            Call DoCheckBoxes(0)
            Stat.Text = "Licencia Invalida, revise por favor!"
            Stat.BackColor = Color.Green
            Stat.ForeColor = Color.White
        End If


    End Sub

    Private Sub DoCheckBoxes(ByVal ChkVal As Integer)
        Check1.CheckState = ChkVal And 1
        Check2.CheckState = CShort(ChkVal And 2) / 2
        Check3.CheckState = CShort(ChkVal And 4) / 4
        Check4.CheckState = CShort(ChkVal And 8) / 8
        Check5.CheckState = CShort(ChkVal And 16) / 16
        Check6.CheckState = CShort(ChkVal And 32) / 32
        Check7.CheckState = CShort(ChkVal And 64) / 64
        Check8.CheckState = CShort(ChkVal And 128) / 128
        Check9.CheckState = CShort(ChkVal And 256) / 256
        Check10.CheckState = CShort(ChkVal And 512) / 512
        Check11.CheckState = CShort(ChkVal And 1024) / 1024
        Check12.CheckState = CShort(ChkVal And 2048) / 2048
        Check13.CheckState = CShort(ChkVal And 4096) / 4096
        Check14.CheckState = CShort(ChkVal And 8192) / 8192
        Check15.CheckState = CShort(ChkVal And 16384) / 16384
        Check16.CheckState = CShort(ChkVal And 32768) / 32768
    End Sub

    Private Sub Form2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Stat.Text = "Enter Registration Information"
        Check1.Enabled = False
        Check2.Enabled = False
        Check3.Enabled = False
        Check4.Enabled = False
        Check5.Enabled = False
        Check6.Enabled = False
        Check7.Enabled = False
        Check8.Enabled = False
        Check9.Enabled = False
        Check10.Enabled = False
        Check11.Enabled = False
        Check12.Enabled = False
        Check13.Enabled = False
        Check14.Enabled = False
        Check15.Enabled = False
        Check16.Enabled = False
        Call DoCheckBoxes(0)
    End Sub
End Class
