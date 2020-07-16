<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrdPlaceOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrdOrderLookUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrdSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOrdCancelOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInvDisplayAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInvSearchByName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInvSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuInvEditUpdateInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReturns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustSelectACustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustBrowseCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCustAddEditCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExmployees = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpViewSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpSwapDays = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEmpSendMessage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEmpViewSpecials = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMgrViewSchedules = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMgrCreateEditSchedules = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMgrSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMgrMessageEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMgrViewMessage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMgrSpecials = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMgrSpe2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMgrModifyEmployees = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOrders, Me.mnuInventory, Me.mnuReturns, Me.mnuCustomers, Me.mnuExmployees, Me.mnuManager, Me.mnuHelp, Me.mnuExit})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(631, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuOrders
        '
        Me.mnuOrders.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOrdPlaceOrder, Me.mnuOrdOrderLookUp, Me.mnuOrdSep1, Me.mnuOrdCancelOrder})
        Me.mnuOrders.Name = "mnuOrders"
        Me.mnuOrders.Size = New System.Drawing.Size(54, 20)
        Me.mnuOrders.Text = "Orders"
        '
        'mnuOrdPlaceOrder
        '
        Me.mnuOrdPlaceOrder.Name = "mnuOrdPlaceOrder"
        Me.mnuOrdPlaceOrder.Size = New System.Drawing.Size(180, 22)
        Me.mnuOrdPlaceOrder.Text = "Place Order"
        '
        'mnuOrdOrderLookUp
        '
        Me.mnuOrdOrderLookUp.Name = "mnuOrdOrderLookUp"
        Me.mnuOrdOrderLookUp.Size = New System.Drawing.Size(180, 22)
        Me.mnuOrdOrderLookUp.Text = "Look up"
        '
        'mnuOrdSep1
        '
        Me.mnuOrdSep1.Name = "mnuOrdSep1"
        Me.mnuOrdSep1.Size = New System.Drawing.Size(177, 6)
        '
        'mnuOrdCancelOrder
        '
        Me.mnuOrdCancelOrder.Name = "mnuOrdCancelOrder"
        Me.mnuOrdCancelOrder.Size = New System.Drawing.Size(180, 22)
        Me.mnuOrdCancelOrder.Text = "Cancel Order"
        '
        'mnuInventory
        '
        Me.mnuInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInvDisplayAll, Me.mnuInvSearchByName, Me.mnuInvSep1, Me.mnuInvEditUpdateInventory})
        Me.mnuInventory.Name = "mnuInventory"
        Me.mnuInventory.Size = New System.Drawing.Size(69, 20)
        Me.mnuInventory.Text = "Inventory"
        '
        'mnuInvDisplayAll
        '
        Me.mnuInvDisplayAll.Name = "mnuInvDisplayAll"
        Me.mnuInvDisplayAll.Size = New System.Drawing.Size(217, 22)
        Me.mnuInvDisplayAll.Text = "Display All"
        '
        'mnuInvSearchByName
        '
        Me.mnuInvSearchByName.Name = "mnuInvSearchByName"
        Me.mnuInvSearchByName.Size = New System.Drawing.Size(217, 22)
        Me.mnuInvSearchByName.Text = "Search by Name"
        '
        'mnuInvSep1
        '
        Me.mnuInvSep1.Name = "mnuInvSep1"
        Me.mnuInvSep1.Size = New System.Drawing.Size(214, 6)
        '
        'mnuInvEditUpdateInventory
        '
        Me.mnuInvEditUpdateInventory.Enabled = False
        Me.mnuInvEditUpdateInventory.Name = "mnuInvEditUpdateInventory"
        Me.mnuInvEditUpdateInventory.Size = New System.Drawing.Size(217, 22)
        Me.mnuInvEditUpdateInventory.Text = "Add/Edit/Update Inventory"
        '
        'mnuReturns
        '
        Me.mnuReturns.Enabled = False
        Me.mnuReturns.Name = "mnuReturns"
        Me.mnuReturns.Size = New System.Drawing.Size(59, 20)
        Me.mnuReturns.Text = "Returns"
        '
        'mnuCustomers
        '
        Me.mnuCustomers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustSelectACustomer, Me.mnuCustBrowseCustomers, Me.mnuCustSep1, Me.mnuCustAddEditCustomers})
        Me.mnuCustomers.Name = "mnuCustomers"
        Me.mnuCustomers.Size = New System.Drawing.Size(76, 20)
        Me.mnuCustomers.Text = "Customers"
        '
        'mnuCustSelectACustomer
        '
        Me.mnuCustSelectACustomer.Name = "mnuCustSelectACustomer"
        Me.mnuCustSelectACustomer.Size = New System.Drawing.Size(181, 22)
        Me.mnuCustSelectACustomer.Text = "Select a Customer"
        '
        'mnuCustBrowseCustomers
        '
        Me.mnuCustBrowseCustomers.Name = "mnuCustBrowseCustomers"
        Me.mnuCustBrowseCustomers.Size = New System.Drawing.Size(181, 22)
        Me.mnuCustBrowseCustomers.Text = "Browse Customers"
        '
        'mnuCustSep1
        '
        Me.mnuCustSep1.Name = "mnuCustSep1"
        Me.mnuCustSep1.Size = New System.Drawing.Size(178, 6)
        '
        'mnuCustAddEditCustomers
        '
        Me.mnuCustAddEditCustomers.Name = "mnuCustAddEditCustomers"
        Me.mnuCustAddEditCustomers.Size = New System.Drawing.Size(181, 22)
        Me.mnuCustAddEditCustomers.Text = "Add/Edit Customers"
        '
        'mnuExmployees
        '
        Me.mnuExmployees.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEmpViewSchedule, Me.mnuEmpSwapDays, Me.mnuEmpSep1, Me.mnuEmpSendMessage, Me.mnuEmpSep2, Me.mnuEmpViewSpecials})
        Me.mnuExmployees.Name = "mnuExmployees"
        Me.mnuExmployees.Size = New System.Drawing.Size(82, 20)
        Me.mnuExmployees.Text = "Exmployees"
        '
        'mnuEmpViewSchedule
        '
        Me.mnuEmpViewSchedule.Name = "mnuEmpViewSchedule"
        Me.mnuEmpViewSchedule.Size = New System.Drawing.Size(180, 22)
        Me.mnuEmpViewSchedule.Text = "View Schedule"
        '
        'mnuEmpSwapDays
        '
        Me.mnuEmpSwapDays.Name = "mnuEmpSwapDays"
        Me.mnuEmpSwapDays.Size = New System.Drawing.Size(180, 22)
        Me.mnuEmpSwapDays.Text = "Swap Days"
        '
        'mnuEmpSep1
        '
        Me.mnuEmpSep1.Name = "mnuEmpSep1"
        Me.mnuEmpSep1.Size = New System.Drawing.Size(177, 6)
        '
        'mnuEmpSendMessage
        '
        Me.mnuEmpSendMessage.Name = "mnuEmpSendMessage"
        Me.mnuEmpSendMessage.Size = New System.Drawing.Size(180, 22)
        Me.mnuEmpSendMessage.Text = "Send Message"
        '
        'mnuEmpSep2
        '
        Me.mnuEmpSep2.Name = "mnuEmpSep2"
        Me.mnuEmpSep2.Size = New System.Drawing.Size(177, 6)
        '
        'mnuEmpViewSpecials
        '
        Me.mnuEmpViewSpecials.Name = "mnuEmpViewSpecials"
        Me.mnuEmpViewSpecials.Size = New System.Drawing.Size(180, 22)
        Me.mnuEmpViewSpecials.Text = "View Specials"
        '
        'mnuManager
        '
        Me.mnuManager.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMgrViewSchedules, Me.mnuMgrCreateEditSchedules, Me.mnuMgrSep1, Me.mnuMgrMessageEmployee, Me.mnuMgrViewMessage, Me.mnuMgrSpecials, Me.mnuMgrSpe2, Me.mnuMgrModifyEmployees})
        Me.mnuManager.Name = "mnuManager"
        Me.mnuManager.Size = New System.Drawing.Size(71, 20)
        Me.mnuManager.Text = "Managers"
        '
        'mnuMgrViewSchedules
        '
        Me.mnuMgrViewSchedules.Name = "mnuMgrViewSchedules"
        Me.mnuMgrViewSchedules.Size = New System.Drawing.Size(229, 22)
        Me.mnuMgrViewSchedules.Text = "View Schedules"
        '
        'mnuMgrCreateEditSchedules
        '
        Me.mnuMgrCreateEditSchedules.Name = "mnuMgrCreateEditSchedules"
        Me.mnuMgrCreateEditSchedules.Size = New System.Drawing.Size(229, 22)
        Me.mnuMgrCreateEditSchedules.Text = "Create/Edit Schedules"
        '
        'mnuMgrSep1
        '
        Me.mnuMgrSep1.Name = "mnuMgrSep1"
        Me.mnuMgrSep1.Size = New System.Drawing.Size(226, 6)
        '
        'mnuMgrMessageEmployee
        '
        Me.mnuMgrMessageEmployee.Name = "mnuMgrMessageEmployee"
        Me.mnuMgrMessageEmployee.Size = New System.Drawing.Size(229, 22)
        Me.mnuMgrMessageEmployee.Text = "Message Employee"
        '
        'mnuMgrViewMessage
        '
        Me.mnuMgrViewMessage.Name = "mnuMgrViewMessage"
        Me.mnuMgrViewMessage.Size = New System.Drawing.Size(229, 22)
        Me.mnuMgrViewMessage.Text = "View Message"
        '
        'mnuMgrSpecials
        '
        Me.mnuMgrSpecials.Name = "mnuMgrSpecials"
        Me.mnuMgrSpecials.Size = New System.Drawing.Size(229, 22)
        Me.mnuMgrSpecials.Text = "Add/Edit Specials"
        '
        'mnuMgrSpe2
        '
        Me.mnuMgrSpe2.Name = "mnuMgrSpe2"
        Me.mnuMgrSpe2.Size = New System.Drawing.Size(226, 6)
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuHelpSep1, Me.mnuVersion})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(112, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuHelpSep1
        '
        Me.mnuHelpSep1.Name = "mnuHelpSep1"
        Me.mnuHelpSep1.Size = New System.Drawing.Size(109, 6)
        '
        'mnuVersion
        '
        Me.mnuVersion.Name = "mnuVersion"
        Me.mnuVersion.Size = New System.Drawing.Size(112, 22)
        Me.mnuVersion.Text = "Version"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(38, 20)
        Me.mnuExit.Text = "Exit"
        '
        'mnuMgrModifyEmployees
        '
        Me.mnuMgrModifyEmployees.Name = "mnuMgrModifyEmployees"
        Me.mnuMgrModifyEmployees.Size = New System.Drawing.Size(229, 22)
        Me.mnuMgrModifyEmployees.Text = "Add/Edit/Remove Employees"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VB_TSTC_Flower_Shoppe.My.Resources.Resources.TSTC_Flower_Shoppe
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(631, 496)
        Me.Controls.Add(Me.mnuMain)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuMain
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TSTC Flower Shoppe - Store Mangement Software"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuOrders As ToolStripMenuItem
    Friend WithEvents mnuInventory As ToolStripMenuItem
    Friend WithEvents mnuReturns As ToolStripMenuItem
    Friend WithEvents mnuCustomers As ToolStripMenuItem
    Friend WithEvents mnuExmployees As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuOrdOrderLookUp As ToolStripMenuItem
    Friend WithEvents mnuOrdPlaceOrder As ToolStripMenuItem
    Friend WithEvents mnuOrdCancelOrder As ToolStripMenuItem
    Friend WithEvents mnuInvDisplayAll As ToolStripMenuItem
    Friend WithEvents mnuInvSearchByName As ToolStripMenuItem
    Friend WithEvents mnuCustSelectACustomer As ToolStripMenuItem
    Friend WithEvents mnuCustBrowseCustomers As ToolStripMenuItem
    Friend WithEvents mnuManager As ToolStripMenuItem
    Friend WithEvents mnuEmpViewSchedule As ToolStripMenuItem
    Friend WithEvents mnuEmpSwapDays As ToolStripMenuItem
    Friend WithEvents mnuEmpSendMessage As ToolStripMenuItem
    Friend WithEvents mnuMgrViewSchedules As ToolStripMenuItem
    Friend WithEvents mnuMgrCreateEditSchedules As ToolStripMenuItem
    Friend WithEvents mnuMgrMessageEmployee As ToolStripMenuItem
    Friend WithEvents mnuMgrViewMessage As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuVersion As ToolStripMenuItem
    Friend WithEvents mnuHelpSep1 As ToolStripSeparator
    Friend WithEvents mnuOrdSep1 As ToolStripSeparator
    Friend WithEvents mnuInvEditUpdateInventory As ToolStripMenuItem
    Friend WithEvents mnuMgrSep1 As ToolStripSeparator
    Friend WithEvents mnuMgrSpe2 As ToolStripSeparator
    Friend WithEvents mnuMgrSpecials As ToolStripMenuItem
    Friend WithEvents mnuEmpViewSpecials As ToolStripMenuItem
    Friend WithEvents mnuInvSep1 As ToolStripSeparator
    Friend WithEvents mnuCustSep1 As ToolStripSeparator
    Friend WithEvents mnuCustAddEditCustomers As ToolStripMenuItem
    Friend WithEvents mnuEmpSep1 As ToolStripSeparator
    Friend WithEvents mnuEmpSep2 As ToolStripSeparator
    Friend WithEvents mnuMgrModifyEmployees As ToolStripMenuItem
End Class
