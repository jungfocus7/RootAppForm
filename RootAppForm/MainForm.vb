Imports System
Imports System.Drawing
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


        m_lstv.BeginUpdate()
        m_lstv.Font = New Font(m_lstv.Font, FontStyle.Bold)
        m_lstv.View = View.Details
        m_lstv.HideSelection = False
        m_lstv.FullRowSelect = True
        m_lstv.Columns.Add("번호", 40, HorizontalAlignment.Left)
        m_lstv.Columns.Add("앱 이름", 200, HorizontalAlignment.Left)

        Dim lf As New Font(m_lstv.Font, FontStyle.Regular)
        Dim lvi As New ListViewItem With {
            .Text = "01)",
            .Font = lf
        }
        lvi.SubItems.Add("NormalForm")
        m_lstv.Items.Add(lvi)
        m_lstv.EndUpdate()
        m_lstv.Items(0).Selected = True

        'pr_btn31__Click(Nothing, Nothing)
    End Sub


    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)

        'pr_btn31__Click(Nothing, Nothing)
    End Sub


    Private Sub pr_btn31__Click(sender As Object, e As EventArgs) Handles m_btn31.Click
        Try
            Dim slvis As ListView.SelectedListViewItemCollection = m_lstv.SelectedItems
            Dim lvi As ListViewItem = slvis(0)

            Dim name As String = lvi.SubItems(1).Text
            Dim fi As FormInfo = AppCommon.GetFormInfo(name)
            fi.RefFrom.ShowDialog(Me)
        Catch
        End Try
    End Sub


    Private Sub pr_lstv__DoubleClick(sender As Object, e As EventArgs) Handles m_lstv.DoubleClick
        pr_btn31__Click(Nothing, Nothing)
    End Sub

End Class
