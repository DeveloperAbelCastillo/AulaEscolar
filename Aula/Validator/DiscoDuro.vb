Imports System.Net.NetworkInformation
Imports System.ServiceModel
Imports DevExpress.XtraEditors

Module DiscoDuro

    Function getMacAddress() As String
        Try
            Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
            Dim MacAdress = nics(0).GetPhysicalAddress.ToString
            Return MacAdress
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function GetInternet() As Boolean
        Try
            Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
            Dim ConectInternet = nics(0).OperationalStatus
            Return ConectInternet
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetDriveSerialNumber() As String
        Try
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
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

End Module
