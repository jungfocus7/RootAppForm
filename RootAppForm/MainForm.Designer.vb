﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.m_btn31 = New System.Windows.Forms.Button()
        Me.m_lstv = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'm_btn31
        '
        Me.m_btn31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_btn31.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.m_btn31.Location = New System.Drawing.Point(208, 315)
        Me.m_btn31.Name = "m_btn31"
        Me.m_btn31.Size = New System.Drawing.Size(80, 23)
        Me.m_btn31.TabIndex = 0
        Me.m_btn31.Text = "선택 실행"
        Me.m_btn31.UseVisualStyleBackColor = True
        '
        'm_lstv
        '
        Me.m_lstv.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.m_lstv.HideSelection = False
        Me.m_lstv.Location = New System.Drawing.Point(12, 12)
        Me.m_lstv.Name = "m_lstv"
        Me.m_lstv.Size = New System.Drawing.Size(276, 297)
        Me.m_lstv.TabIndex = 1
        Me.m_lstv.UseCompatibleStateImageBehavior = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 350)
        Me.Controls.Add(Me.m_lstv)
        Me.Controls.Add(Me.m_btn31)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 40)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents m_btn31 As System.Windows.Forms.Button
    Friend WithEvents m_lstv As System.Windows.Forms.ListView
End Class
