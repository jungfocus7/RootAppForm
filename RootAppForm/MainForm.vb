Imports System
Imports System.Windows.Forms
Imports AppNormalForm
Imports RootAppCommon
Imports RootAppCommon.Controls
Imports RootAppCommon.Models




Public NotInheritable Class MainForm
    Public Sub New()
        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub



    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        AlignBottomRight(10, 10)
    End Sub



    Private Sub pr_btn31__Click(sender As Object, e As EventArgs) Handles m_btn31.Click
        Dim fi As FormInfo = FormManager.GetFormInfo("NormalForm")
        If fi.RefFrom Is Nothing Then
            fi.RefFrom = New NormalForm()
        End If
        fi.RefFrom.ShowDialog(Me)
    End Sub
End Class
