Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim a = SAL.Encriptador.EncryptString("Hola Mundo", "Lander05")
        Dim b = SAL.Encriptador.DecryptString(a, "Lander05")
        Dim c = 1
    End Sub

End Class