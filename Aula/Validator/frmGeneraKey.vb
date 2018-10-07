Option Strict Off
Option Explicit On
Imports System.Net.NetworkInformation

Public Class frmGeneraKey
    Inherits System.Windows.Forms.Form
    ' *
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
    '
    ' PURPOSE
    '    Demo application for KeyCode module.
    '
    ' LANGUAGE
    '    Visual Basic 6.0 (or VBA6) or newer
    '
    ' DEPENDENCIES:
    '    Requires KeyCode module and MD5_Crypt module
    '

    ' ================================================
    '   CUSTOMIZE THIS STRING BELOW
    ' ================================================
    ' "Secret" product name to append to Licensee/Serial
    ' Change to match your desired product name and/or version info
    ' Omit "version" if you want keys to work with any version of your
    ' application.

    Private Const MyProductName As String = "KeyCodeDemoV1"



    Private Sub UserName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles UserName.Enter
        Call GenNewKey()
    End Sub

    Private Sub UserName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles UserName.Leave
        Call GenNewKey()
    End Sub

    Private Sub ProdName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ProdName.Leave
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check1.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check1.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check2.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check2_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check2.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check3.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check3_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check3.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check4.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check4_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check4.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check5.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check5_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check5.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check6.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check6_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check6.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check7.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check7_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check7.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check8.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check8_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check8.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check9.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check9_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check9.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check10.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check10_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check10.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check11.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check11_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check11.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check12.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check12_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check12.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check13.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check13_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check13.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check14.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check14_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check14.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check15.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check15_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check15.CheckStateChanged
        Call GenNewKey()
    End Sub

    'UPGRADE_WARNING: Event Check16.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Check16_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check16.CheckStateChanged
        Call GenNewKey()
    End Sub

    Private Sub GenNewKey()
        Dim BinKey As Object
        Dim RawKey As Object
        Dim ProdNameT As Object
        Dim UserNameT As Object
        Dim FeatID As Integer

        FeatID = 0

        'Build bitmap from checkboxes

        If Check1.CheckState Then FeatID = FeatID Or 1
        If Check2.CheckState Then FeatID = FeatID Or 2
        If Check3.CheckState Then FeatID = FeatID Or 4
        If Check4.CheckState Then FeatID = FeatID Or 8
        If Check5.CheckState Then FeatID = FeatID Or 16
        If Check6.CheckState Then FeatID = FeatID Or 32
        If Check7.CheckState Then FeatID = FeatID Or 64
        If Check8.CheckState Then FeatID = FeatID Or 128
        If Check9.CheckState Then FeatID = FeatID Or 256
        If Check10.CheckState Then FeatID = FeatID Or 512
        If Check11.CheckState Then FeatID = FeatID Or 1024
        If Check12.CheckState Then FeatID = FeatID Or 2048
        If Check13.CheckState Then FeatID = FeatID Or 4096
        If Check14.CheckState Then FeatID = FeatID Or 8192
        If Check15.CheckState Then FeatID = FeatID Or 16384
        If Check16.CheckState Then FeatID = FeatID Or 32768

        ' Uncomment next line if you want to use hexadecimal keys instead
        'KeyCode = FormatKeyCode(GenKeyString(UserName, ProdName, FeatID))
        'UPGRADE_WARNING: Couldn't resolve default property of object UserNameT. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        UserNameT = Trim(UserName.Text)
        'UPGRADE_WARNING: Couldn't resolve default property of object ProdNameT. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ProdNameT = Trim(ProdName.Text)

        'UPGRADE_WARNING: Couldn't resolve default property of object ProdNameT. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object UserNameT. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Not (UserNameT = "") Or Not (ProdNameT = "") Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ProdNameT. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RawKey. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RawKey = GenKeyString(UserNameT, ProdNameT & MyProductName, FeatID)
            'UPGRADE_WARNING: Couldn't resolve default property of object RawKey. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object BinKey. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            BinKey = HexStrToBinStr(RawKey)
            'UPGRADE_WARNING: Couldn't resolve default property of object BinKey. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            KeyCode.Text = FormatKeyCode(Base32Enc(BinKey), 4)
        Else
            KeyCode.Text = "Please Enter Licensee and/or Serial Number"
        End If
    End Sub

    Private Sub frmGeneraKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim A = getMacAddress()
        Dim B = GetDriveSerialNumber()
        Dim C = GetInternet()
        UserName.Text = A & B
    End Sub

    Function getMacAddress() As String
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Dim MacAdress = nics(0).GetPhysicalAddress.ToString
        Return MacAdress
    End Function

    Function GetDriveSerialNumber() As String
        Dim DriveSerial As Integer
        'Create a FileSystemObject object
        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        Return DriveSerial.ToString("X2")
    End Function

    Function GetInternet() As Boolean
        If My.Computer.Network.IsAvailable() Then
            If My.Computer.Network.Ping("www.google.com.mx", 1000) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class