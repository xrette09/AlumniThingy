Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.ALUM = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Blank1 = New AlumniThingy.Blank()
        Me.Control_Alumni1 = New AlumniThingy.control_Alumni()
        Me.Control_student1 = New AlumniThingy.control_student()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.Control_Member1 = New AlumniThingy.control_Member()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.ALUM, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbonControl1.MaxItemId = 7
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.Size = New System.Drawing.Size(1080, 179)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Server Settings"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.LargeImage = Global.AlumniThingy.My.Resources.Resources.icons8_Server_40px
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Add User"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.LargeImage = Global.AlumniThingy.My.Resources.Resources.icons8_Data_Transfer_25px
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Students"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = Global.AlumniThingy.My.Resources.Resources.icons8_Split_Files_25px
        Me.BarButtonItem3.ImageOptions.LargeImage = Global.AlumniThingy.My.Resources.Resources.icons8_Data_Transfer_25px
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'ALUM
        '
        Me.ALUM.Caption = "Alumni"
        Me.ALUM.Id = 4
        Me.ALUM.Name = "ALUM"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Membership"
        Me.BarButtonItem4.Id = 5
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ribbonPage1"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Server Settings"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.ALUM)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Blank1)
        Me.PanelControl1.Controls.Add(Me.Control_Member1)
        Me.PanelControl1.Controls.Add(Me.Control_Alumni1)
        Me.PanelControl1.Controls.Add(Me.Control_student1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 179)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1080, 492)
        Me.PanelControl1.TabIndex = 1
        '
        'Blank1
        '
        Me.Blank1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Blank1.Location = New System.Drawing.Point(2, 2)
        Me.Blank1.Name = "Blank1"
        Me.Blank1.Size = New System.Drawing.Size(1076, 488)
        Me.Blank1.TabIndex = 2
        '
        'Control_Alumni1
        '
        Me.Control_Alumni1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_Alumni1.Location = New System.Drawing.Point(2, 2)
        Me.Control_Alumni1.Name = "Control_Alumni1"
        Me.Control_Alumni1.Size = New System.Drawing.Size(1076, 488)
        Me.Control_Alumni1.TabIndex = 1
        '
        'Control_student1
        '
        Me.Control_student1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_student1.Location = New System.Drawing.Point(2, 2)
        Me.Control_student1.Name = "Control_student1"
        Me.Control_student1.Size = New System.Drawing.Size(1076, 488)
        Me.Control_student1.TabIndex = 0
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Academic Year"
        Me.BarButtonItem5.Id = 6
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'Control_Member1
        '
        Me.Control_Member1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_Member1.Location = New System.Drawing.Point(2, 2)
        Me.Control_Member1.Name = "Control_Member1"
        Me.Control_Member1.Size = New System.Drawing.Size(1076, 488)
        Me.Control_Member1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 671)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Control_student1 As control_student
    Friend WithEvents Blank1 As Blank
    Friend WithEvents Control_Alumni1 As control_Alumni
    Friend WithEvents ALUM As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Control_Member1 As control_Member
End Class
