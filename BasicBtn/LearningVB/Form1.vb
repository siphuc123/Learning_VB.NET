Public Class Form1
    Private Sub btnMsg_Click(sender As Object, e As EventArgs) Handles btnMsg.Click

        MsgBox("Hello Word")

        MessageBox.Show("Checkin, Xin chào", "Lời chào đầu", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        ' Dim mean Dimension
        Dim stIntroduce As String
        Dim stMyName As String

        stIntroduce = "Watashi wa"
        stMyName = " Phuc desu"

        MsgBox("Hello guys, " & stIntroduce & stMyName & " Love to working with all global friends.")

        ' Contents of variable can change while the programs is running
        stIntroduce = "My name is"
        stMyName = " Phuc"

        MsgBox("Hello guys, " & stIntroduce & stMyName & " Love to working with all global friends.")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stType As String
        Dim stMake As String
        Dim stModel As String
        Dim iDoor As String
        Dim stColor As String
        Dim bTax As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal ' Suitable for store Money Type/Values
        Dim dtDateRegistered As Date

        stType = "Motobike"
        stMake = "Kawasaki"
        stModel = " Z1000"
        iDoor = 0
        stColor = "Green"
        bTax = True
        iEngineSize = 903
        decPrice = 100.99
        dtDateRegistered = #03/16/2023#

        MsgBox("The " & stType & " is:" & vbNewLine & "- Make: " & stMake &
               vbNewLine & "- Model: " & stModel & vbNewLine & "- How many doors: " & iDoor &
               vbNewLine & "- Color: " & stColor & vbNewLine & "- Tax: " & If((bTax = True), "Yes", "No") &
               vbNewLine & "- Engine Size: " & iEngineSize & vbNewLine & "- Discount: " & decPrice &
               vbNewLine & "- Date Registered: " & dtDateRegistered
               )

    End Sub
End Class
