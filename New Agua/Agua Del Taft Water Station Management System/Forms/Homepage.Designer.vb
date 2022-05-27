<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStocksAndExpenses = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlDesktop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlMenu.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.pnlTitleBar.SuspendLayout()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnStocksAndExpenses)
        Me.pnlMenu.Controls.Add(Me.btnMaintenance)
        Me.pnlMenu.Controls.Add(Me.btnSalesReport)
        Me.pnlMenu.Controls.Add(Me.btnSales)
        Me.pnlMenu.Controls.Add(Me.btnDashboard)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(220, 621)
        Me.pnlMenu.TabIndex = 1
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.btnMaximize)
        Me.pnlLogo.Controls.Add(Me.btnClose)
        Me.pnlLogo.Controls.Add(Me.btnMinimize)
        Me.pnlLogo.Controls.Add(Me.imgHome)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 164)
        Me.pnlLogo.TabIndex = 2
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlTitleBar.Controls.Add(Me.lblFormTitle)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(964, 75)
        Me.pnlTitleBar.TabIndex = 3
        '
        'lblFormTitle
        '
        Me.lblFormTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(462, 22)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(56, 21)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'btnStocksAndExpenses
        '
        Me.btnStocksAndExpenses.FlatAppearance.BorderSize = 0
        Me.btnStocksAndExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStocksAndExpenses.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStocksAndExpenses.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStocksAndExpenses.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.coin
        Me.btnStocksAndExpenses.Location = New System.Drawing.Point(0, 434)
        Me.btnStocksAndExpenses.Name = "btnStocksAndExpenses"
        Me.btnStocksAndExpenses.Size = New System.Drawing.Size(220, 60)
        Me.btnStocksAndExpenses.TabIndex = 8
        Me.btnStocksAndExpenses.Text = "      Expenses"
        Me.btnStocksAndExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStocksAndExpenses.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.FlatAppearance.BorderSize = 0
        Me.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMaintenance.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.maintenance
        Me.btnMaintenance.Location = New System.Drawing.Point(0, 368)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(220, 60)
        Me.btnMaintenance.TabIndex = 7
        Me.btnMaintenance.Text = "      Maintenance"
        Me.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'btnSalesReport
        '
        Me.btnSalesReport.FlatAppearance.BorderSize = 0
        Me.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesReport.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReport.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSalesReport.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.increase
        Me.btnSalesReport.Location = New System.Drawing.Point(0, 302)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(220, 60)
        Me.btnSalesReport.TabIndex = 6
        Me.btnSalesReport.Text = "      Sales Report"
        Me.btnSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSales.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.best_price
        Me.btnSales.Location = New System.Drawing.Point(0, 236)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(220, 60)
        Me.btnSales.TabIndex = 5
        Me.btnSales.Text = "      Sales"
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.dashboard_1_
        Me.btnDashboard.Location = New System.Drawing.Point(0, 170)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "      Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.Maximize_removebg_preview
        Me.btnMaximize.Location = New System.Drawing.Point(40, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(14, 14)
        Me.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximize.TabIndex = 5
        Me.btnMaximize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.Close_removebg_preview
        Me.btnClose.Location = New System.Drawing.Point(0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(14, 14)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.Minimize_removebg_preview
        Me.btnMinimize.Location = New System.Drawing.Point(20, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(14, 14)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.TabStop = False
        '
        'imgHome
        '
        Me.imgHome.Image = Global.Agua_Del_Taft_Water_Station_Management_System.My.Resources.Resources.agua_removebg_preview
        Me.imgHome.Location = New System.Drawing.Point(40, 31)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(126, 96)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgHome.TabIndex = 1
        Me.imgHome.TabStop = False
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblDateTime.Location = New System.Drawing.Point(352, 374)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(93, 21)
        Me.lblDateTime.TabIndex = 3
        Me.lblDateTime.Text = "DATE TIME"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(341, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "AGUA DEL TAFT "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDesktop
        '
        Me.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.pnlDesktop.Controls.Add(Me.Label3)
        Me.pnlDesktop.Controls.Add(Me.Label2)
        Me.pnlDesktop.Controls.Add(Me.Label1)
        Me.pnlDesktop.Controls.Add(Me.lblDateTime)
        Me.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDesktop.Location = New System.Drawing.Point(220, 75)
        Me.pnlDesktop.Name = "pnlDesktop"
        Me.pnlDesktop.Size = New System.Drawing.Size(964, 546)
        Me.pnlDesktop.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(258, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(448, 42)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "WATER REFILLING STATION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(285, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(395, 42)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MANAGEMENT SYSTEM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 621)
        Me.Controls.Add(Me.pnlDesktop)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.pnlMenu)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1100, 600)
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDesktop.ResumeLayout(False)
        Me.pnlDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents btnMaximize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnStocksAndExpenses As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlDesktop As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
