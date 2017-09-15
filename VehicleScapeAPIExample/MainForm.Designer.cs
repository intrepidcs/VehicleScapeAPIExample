namespace VehicleScapeAPIExample {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TitleBarMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadDBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LogTabSplitter = new System.Windows.Forms.SplitContainer();
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.DAQsAndDevicesPage = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.AddDAQButton = new System.Windows.Forms.Button();
			this.DAQListView = new System.Windows.Forms.ListView();
			this.DAQName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DAQLabel = new System.Windows.Forms.Label();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.DeviceListView = new System.Windows.Forms.ListView();
			this.DeviceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeviceSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeviceHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DeviceLabel = new System.Windows.Forms.Label();
			this.SignalsPage = new System.Windows.Forms.TabPage();
			this.ChannelViewSplitter = new System.Windows.Forms.SplitContainer();
			this.AvailableSignalsLabel = new System.Windows.Forms.Label();
			this.AvailableChannelsListView = new System.Windows.Forms.ListView();
			this.AvailableSignalNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AvailableSourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AvailableNetworkColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AvailableTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SelectedSignalsLabel = new System.Windows.Forms.Label();
			this.SelectedChannelsListView = new System.Windows.Forms.ListView();
			this.SelectedSignalNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SelectedSourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SelectedNetworkColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SelectedTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MoveAllSelectedToAvailable = new System.Windows.Forms.Button();
			this.MoveSelectedToAvailable = new System.Windows.Forms.Button();
			this.MoveAllAvailableToSelected = new System.Windows.Forms.Button();
			this.MoveAvailableToSelected = new System.Windows.Forms.Button();
			this.GeneratePage = new System.Windows.Forms.TabPage();
			this.UploadButton = new System.Windows.Forms.Button();
			this.GenerateOptionsGroupBox = new System.Windows.Forms.GroupBox();
			this.ReflashFirmwareCheckbox = new System.Windows.Forms.CheckBox();
			this.PowerManagementGroupBox = new System.Windows.Forms.GroupBox();
			this.PowerManagementWirelessNeoVIGroupBox = new System.Windows.Forms.GroupBox();
			this.VoltageCutoffLabel = new System.Windows.Forms.Label();
			this.ConnectionTimeoutLabel = new System.Windows.Forms.Label();
			this.OverallTimeoutLabel = new System.Windows.Forms.Label();
			this.VoltageCutoffTextBox = new System.Windows.Forms.TextBox();
			this.ConnectionTimeoutTextBox = new System.Windows.Forms.TextBox();
			this.OverallTimeoutTextBox = new System.Windows.Forms.TextBox();
			this.PowerManagementWakeGroupBox = new System.Windows.Forms.GroupBox();
			this.RemoteWakeupLabel = new System.Windows.Forms.Label();
			this.StartNewFileOnWakeupCheckBox = new System.Windows.Forms.CheckBox();
			this.RemoteWakeupCheckBox = new System.Windows.Forms.CheckBox();
			this.WakeInstantRadioButton = new System.Windows.Forms.RadioButton();
			this.WakeNormalRadioButton = new System.Windows.Forms.RadioButton();
			this.PowerManagementSleepGroupBox = new System.Windows.Forms.GroupBox();
			this.BusActivityThresholdLabel = new System.Windows.Forms.Label();
			this.BusActivityThresholdTextBox = new System.Windows.Forms.TextBox();
			this.SleepOnNoBusActivityRadioButton = new System.Windows.Forms.RadioButton();
			this.NeverGoToSleepRadioButton = new System.Windows.Forms.RadioButton();
			this.MessageCountLabel = new System.Windows.Forms.Label();
			this.MessageCountTextBox = new System.Windows.Forms.TextBox();
			this.CollectionNameLabel = new System.Windows.Forms.Label();
			this.CollectionNameTextBox = new System.Windows.Forms.TextBox();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.LogLabel = new System.Windows.Forms.Label();
			this.LogTextbox = new System.Windows.Forms.TextBox();
			this.TitleBarMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LogTabSplitter)).BeginInit();
			this.LogTabSplitter.Panel1.SuspendLayout();
			this.LogTabSplitter.Panel2.SuspendLayout();
			this.LogTabSplitter.SuspendLayout();
			this.MainTabControl.SuspendLayout();
			this.DAQsAndDevicesPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SignalsPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChannelViewSplitter)).BeginInit();
			this.ChannelViewSplitter.Panel1.SuspendLayout();
			this.ChannelViewSplitter.Panel2.SuspendLayout();
			this.ChannelViewSplitter.SuspendLayout();
			this.GeneratePage.SuspendLayout();
			this.GenerateOptionsGroupBox.SuspendLayout();
			this.PowerManagementGroupBox.SuspendLayout();
			this.PowerManagementWirelessNeoVIGroupBox.SuspendLayout();
			this.PowerManagementWakeGroupBox.SuspendLayout();
			this.PowerManagementSleepGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleBarMenuStrip
			// 
			this.TitleBarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.TitleBarMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.TitleBarMenuStrip.Name = "TitleBarMenuStrip";
			this.TitleBarMenuStrip.Size = new System.Drawing.Size(888, 24);
			this.TitleBarMenuStrip.TabIndex = 3;
			this.TitleBarMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDBCToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// loadDBCToolStripMenuItem
			// 
			this.loadDBCToolStripMenuItem.Name = "loadDBCToolStripMenuItem";
			this.loadDBCToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.loadDBCToolStripMenuItem.Text = "Load DBC";
			this.loadDBCToolStripMenuItem.Click += new System.EventHandler(this.loadDBCToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// LogTabSplitter
			// 
			this.LogTabSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LogTabSplitter.Location = new System.Drawing.Point(12, 27);
			this.LogTabSplitter.Name = "LogTabSplitter";
			this.LogTabSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// LogTabSplitter.Panel1
			// 
			this.LogTabSplitter.Panel1.Controls.Add(this.MainTabControl);
			// 
			// LogTabSplitter.Panel2
			// 
			this.LogTabSplitter.Panel2.Controls.Add(this.LogLabel);
			this.LogTabSplitter.Panel2.Controls.Add(this.LogTextbox);
			this.LogTabSplitter.Size = new System.Drawing.Size(864, 540);
			this.LogTabSplitter.SplitterDistance = 431;
			this.LogTabSplitter.TabIndex = 5;
			// 
			// MainTabControl
			// 
			this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainTabControl.Controls.Add(this.DAQsAndDevicesPage);
			this.MainTabControl.Controls.Add(this.SignalsPage);
			this.MainTabControl.Controls.Add(this.GeneratePage);
			this.MainTabControl.Location = new System.Drawing.Point(6, 3);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(855, 425);
			this.MainTabControl.TabIndex = 3;
			this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
			// 
			// DAQsAndDevicesPage
			// 
			this.DAQsAndDevicesPage.Controls.Add(this.splitContainer1);
			this.DAQsAndDevicesPage.Location = new System.Drawing.Point(4, 22);
			this.DAQsAndDevicesPage.Name = "DAQsAndDevicesPage";
			this.DAQsAndDevicesPage.Size = new System.Drawing.Size(847, 399);
			this.DAQsAndDevicesPage.TabIndex = 2;
			this.DAQsAndDevicesPage.Text = "DAQs and Devices";
			this.DAQsAndDevicesPage.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(7, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.AddDAQButton);
			this.splitContainer1.Panel1.Controls.Add(this.DAQListView);
			this.splitContainer1.Panel1.Controls.Add(this.DAQLabel);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.RefreshButton);
			this.splitContainer1.Panel2.Controls.Add(this.DeviceListView);
			this.splitContainer1.Panel2.Controls.Add(this.DeviceLabel);
			this.splitContainer1.Size = new System.Drawing.Size(837, 393);
			this.splitContainer1.SplitterDistance = 422;
			this.splitContainer1.TabIndex = 2;
			// 
			// AddDAQButton
			// 
			this.AddDAQButton.Location = new System.Drawing.Point(341, 6);
			this.AddDAQButton.Name = "AddDAQButton";
			this.AddDAQButton.Size = new System.Drawing.Size(75, 23);
			this.AddDAQButton.TabIndex = 2;
			this.AddDAQButton.Text = "Add DAQ";
			this.AddDAQButton.UseVisualStyleBackColor = true;
			this.AddDAQButton.Click += new System.EventHandler(this.AddDAQButton_Click);
			// 
			// DAQListView
			// 
			this.DAQListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DAQListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DAQName});
			this.DAQListView.FullRowSelect = true;
			this.DAQListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.DAQListView.HideSelection = false;
			this.DAQListView.LabelEdit = true;
			this.DAQListView.Location = new System.Drawing.Point(0, 35);
			this.DAQListView.MultiSelect = false;
			this.DAQListView.Name = "DAQListView";
			this.DAQListView.Size = new System.Drawing.Size(416, 354);
			this.DAQListView.TabIndex = 1;
			this.DAQListView.UseCompatibleStateImageBehavior = false;
			this.DAQListView.View = System.Windows.Forms.View.Details;
			this.DAQListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.UpdateDAQEvent);
			this.DAQListView.SelectedIndexChanged += new System.EventHandler(this.DAQListView_SelectedIndexChanged);
			this.DAQListView.DoubleClick += new System.EventHandler(this.DAQListView_DoubleClick);
			// 
			// DAQName
			// 
			this.DAQName.Text = "DAQ Name";
			this.DAQName.Width = 157;
			// 
			// DAQLabel
			// 
			this.DAQLabel.AutoSize = true;
			this.DAQLabel.Location = new System.Drawing.Point(4, 6);
			this.DAQLabel.Name = "DAQLabel";
			this.DAQLabel.Size = new System.Drawing.Size(35, 13);
			this.DAQLabel.TabIndex = 1;
			this.DAQLabel.Text = "DAQs";
			// 
			// RefreshButton
			// 
			this.RefreshButton.Location = new System.Drawing.Point(332, 6);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(75, 23);
			this.RefreshButton.TabIndex = 4;
			this.RefreshButton.Text = "Refresh";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// DeviceListView
			// 
			this.DeviceListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DeviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DeviceType,
            this.DeviceSerial,
            this.DeviceHandle});
			this.DeviceListView.FullRowSelect = true;
			this.DeviceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.DeviceListView.HideSelection = false;
			this.DeviceListView.Location = new System.Drawing.Point(3, 35);
			this.DeviceListView.MultiSelect = false;
			this.DeviceListView.Name = "DeviceListView";
			this.DeviceListView.Size = new System.Drawing.Size(404, 354);
			this.DeviceListView.TabIndex = 3;
			this.DeviceListView.UseCompatibleStateImageBehavior = false;
			this.DeviceListView.View = System.Windows.Forms.View.Details;
			// 
			// DeviceType
			// 
			this.DeviceType.Text = "Device Type";
			this.DeviceType.Width = 175;
			// 
			// DeviceSerial
			// 
			this.DeviceSerial.Text = "Serial Number";
			this.DeviceSerial.Width = 100;
			// 
			// DeviceHandle
			// 
			this.DeviceHandle.Text = "Handle";
			this.DeviceHandle.Width = 103;
			// 
			// DeviceLabel
			// 
			this.DeviceLabel.AutoSize = true;
			this.DeviceLabel.Location = new System.Drawing.Point(3, 6);
			this.DeviceLabel.Name = "DeviceLabel";
			this.DeviceLabel.Size = new System.Drawing.Size(46, 13);
			this.DeviceLabel.TabIndex = 2;
			this.DeviceLabel.Text = "Devices";
			// 
			// SignalsPage
			// 
			this.SignalsPage.Controls.Add(this.ChannelViewSplitter);
			this.SignalsPage.Controls.Add(this.MoveAllSelectedToAvailable);
			this.SignalsPage.Controls.Add(this.MoveSelectedToAvailable);
			this.SignalsPage.Controls.Add(this.MoveAllAvailableToSelected);
			this.SignalsPage.Controls.Add(this.MoveAvailableToSelected);
			this.SignalsPage.Location = new System.Drawing.Point(4, 22);
			this.SignalsPage.Name = "SignalsPage";
			this.SignalsPage.Padding = new System.Windows.Forms.Padding(3);
			this.SignalsPage.Size = new System.Drawing.Size(847, 399);
			this.SignalsPage.TabIndex = 0;
			this.SignalsPage.Text = "Signals";
			this.SignalsPage.UseVisualStyleBackColor = true;
			// 
			// ChannelViewSplitter
			// 
			this.ChannelViewSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ChannelViewSplitter.Location = new System.Drawing.Point(10, 6);
			this.ChannelViewSplitter.Name = "ChannelViewSplitter";
			// 
			// ChannelViewSplitter.Panel1
			// 
			this.ChannelViewSplitter.Panel1.Controls.Add(this.AvailableSignalsLabel);
			this.ChannelViewSplitter.Panel1.Controls.Add(this.AvailableChannelsListView);
			// 
			// ChannelViewSplitter.Panel2
			// 
			this.ChannelViewSplitter.Panel2.Controls.Add(this.SelectedSignalsLabel);
			this.ChannelViewSplitter.Panel2.Controls.Add(this.SelectedChannelsListView);
			this.ChannelViewSplitter.Size = new System.Drawing.Size(831, 358);
			this.ChannelViewSplitter.SplitterDistance = 414;
			this.ChannelViewSplitter.TabIndex = 14;
			// 
			// AvailableSignalsLabel
			// 
			this.AvailableSignalsLabel.AutoSize = true;
			this.AvailableSignalsLabel.Location = new System.Drawing.Point(3, 3);
			this.AvailableSignalsLabel.Name = "AvailableSignalsLabel";
			this.AvailableSignalsLabel.Size = new System.Drawing.Size(97, 13);
			this.AvailableSignalsLabel.TabIndex = 14;
			this.AvailableSignalsLabel.Text = "Available Channels";
			// 
			// AvailableChannelsListView
			// 
			this.AvailableChannelsListView.AllowDrop = true;
			this.AvailableChannelsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AvailableChannelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AvailableSignalNameColumn,
            this.AvailableSourceColumn,
            this.AvailableNetworkColumn,
            this.AvailableTypeColumn});
			this.AvailableChannelsListView.FullRowSelect = true;
			this.AvailableChannelsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.AvailableChannelsListView.Location = new System.Drawing.Point(6, 19);
			this.AvailableChannelsListView.Name = "AvailableChannelsListView";
			this.AvailableChannelsListView.Size = new System.Drawing.Size(405, 336);
			this.AvailableChannelsListView.TabIndex = 13;
			this.AvailableChannelsListView.UseCompatibleStateImageBehavior = false;
			this.AvailableChannelsListView.View = System.Windows.Forms.View.Details;
			this.AvailableChannelsListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.AvailableSignalsListView_ItemDrag);
			this.AvailableChannelsListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.AvailableSignalsListView_DragDrop);
			this.AvailableChannelsListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.AvailableSignalsListView_DragEnter);
			// 
			// AvailableSignalNameColumn
			// 
			this.AvailableSignalNameColumn.Text = "Signal Name";
			this.AvailableSignalNameColumn.Width = 111;
			// 
			// AvailableSourceColumn
			// 
			this.AvailableSourceColumn.Text = "Source";
			this.AvailableSourceColumn.Width = 76;
			// 
			// AvailableNetworkColumn
			// 
			this.AvailableNetworkColumn.Text = "Network";
			// 
			// AvailableTypeColumn
			// 
			this.AvailableTypeColumn.Text = "Type";
			this.AvailableTypeColumn.Width = 59;
			// 
			// SelectedSignalsLabel
			// 
			this.SelectedSignalsLabel.AutoSize = true;
			this.SelectedSignalsLabel.Location = new System.Drawing.Point(3, 3);
			this.SelectedSignalsLabel.Name = "SelectedSignalsLabel";
			this.SelectedSignalsLabel.Size = new System.Drawing.Size(96, 13);
			this.SelectedSignalsLabel.TabIndex = 15;
			this.SelectedSignalsLabel.Text = "Selected Channels";
			// 
			// SelectedChannelsListView
			// 
			this.SelectedChannelsListView.AllowDrop = true;
			this.SelectedChannelsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectedChannelsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SelectedSignalNameColumn,
            this.SelectedSourceColumn,
            this.SelectedNetworkColumn,
            this.SelectedTypeColumn});
			this.SelectedChannelsListView.FullRowSelect = true;
			this.SelectedChannelsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.SelectedChannelsListView.Location = new System.Drawing.Point(6, 19);
			this.SelectedChannelsListView.Name = "SelectedChannelsListView";
			this.SelectedChannelsListView.Size = new System.Drawing.Size(404, 336);
			this.SelectedChannelsListView.TabIndex = 14;
			this.SelectedChannelsListView.UseCompatibleStateImageBehavior = false;
			this.SelectedChannelsListView.View = System.Windows.Forms.View.Details;
			this.SelectedChannelsListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.SelectedSignalsListView_ItemDrag);
			this.SelectedChannelsListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.SelectedSignalsListView_DragDrop);
			this.SelectedChannelsListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.SelectedSignalsListView_DragEnter);
			// 
			// SelectedSignalNameColumn
			// 
			this.SelectedSignalNameColumn.Text = "Signal Name";
			this.SelectedSignalNameColumn.Width = 110;
			// 
			// SelectedSourceColumn
			// 
			this.SelectedSourceColumn.Text = "Source";
			this.SelectedSourceColumn.Width = 77;
			// 
			// SelectedNetworkColumn
			// 
			this.SelectedNetworkColumn.Text = "Network";
			// 
			// SelectedTypeColumn
			// 
			this.SelectedTypeColumn.Text = "Type";
			this.SelectedTypeColumn.Width = 58;
			// 
			// MoveAllSelectedToAvailable
			// 
			this.MoveAllSelectedToAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.MoveAllSelectedToAvailable.Location = new System.Drawing.Point(744, 370);
			this.MoveAllSelectedToAvailable.Name = "MoveAllSelectedToAvailable";
			this.MoveAllSelectedToAvailable.Size = new System.Drawing.Size(97, 23);
			this.MoveAllSelectedToAvailable.TabIndex = 7;
			this.MoveAllSelectedToAvailable.Text = "<< Move All";
			this.MoveAllSelectedToAvailable.UseVisualStyleBackColor = true;
			this.MoveAllSelectedToAvailable.Click += new System.EventHandler(this.MoveAllSelectedToAvailable_Click);
			// 
			// MoveSelectedToAvailable
			// 
			this.MoveSelectedToAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.MoveSelectedToAvailable.Location = new System.Drawing.Point(641, 370);
			this.MoveSelectedToAvailable.Name = "MoveSelectedToAvailable";
			this.MoveSelectedToAvailable.Size = new System.Drawing.Size(97, 23);
			this.MoveSelectedToAvailable.TabIndex = 6;
			this.MoveSelectedToAvailable.Text = "< Move Selected";
			this.MoveSelectedToAvailable.UseVisualStyleBackColor = true;
			this.MoveSelectedToAvailable.Click += new System.EventHandler(this.MoveSelectedToAvailable_Click);
			// 
			// MoveAllAvailableToSelected
			// 
			this.MoveAllAvailableToSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.MoveAllAvailableToSelected.Location = new System.Drawing.Point(10, 370);
			this.MoveAllAvailableToSelected.Name = "MoveAllAvailableToSelected";
			this.MoveAllAvailableToSelected.Size = new System.Drawing.Size(97, 23);
			this.MoveAllAvailableToSelected.TabIndex = 5;
			this.MoveAllAvailableToSelected.Text = "Move All >>";
			this.MoveAllAvailableToSelected.UseVisualStyleBackColor = true;
			this.MoveAllAvailableToSelected.Click += new System.EventHandler(this.MoveAllAvailableToSelected_Click);
			// 
			// MoveAvailableToSelected
			// 
			this.MoveAvailableToSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.MoveAvailableToSelected.Location = new System.Drawing.Point(111, 370);
			this.MoveAvailableToSelected.Name = "MoveAvailableToSelected";
			this.MoveAvailableToSelected.Size = new System.Drawing.Size(97, 23);
			this.MoveAvailableToSelected.TabIndex = 4;
			this.MoveAvailableToSelected.Text = "Move Selected >";
			this.MoveAvailableToSelected.UseVisualStyleBackColor = true;
			this.MoveAvailableToSelected.Click += new System.EventHandler(this.MoveAvailableToSelected_Click);
			// 
			// GeneratePage
			// 
			this.GeneratePage.Controls.Add(this.UploadButton);
			this.GeneratePage.Controls.Add(this.GenerateOptionsGroupBox);
			this.GeneratePage.Controls.Add(this.GenerateButton);
			this.GeneratePage.Location = new System.Drawing.Point(4, 22);
			this.GeneratePage.Name = "GeneratePage";
			this.GeneratePage.Padding = new System.Windows.Forms.Padding(3);
			this.GeneratePage.Size = new System.Drawing.Size(847, 399);
			this.GeneratePage.TabIndex = 1;
			this.GeneratePage.Text = "Generate";
			this.GeneratePage.UseVisualStyleBackColor = true;
			// 
			// UploadButton
			// 
			this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UploadButton.Location = new System.Drawing.Point(3, 370);
			this.UploadButton.Name = "UploadButton";
			this.UploadButton.Size = new System.Drawing.Size(838, 23);
			this.UploadButton.TabIndex = 6;
			this.UploadButton.Text = "Transfer to Device";
			this.UploadButton.UseVisualStyleBackColor = true;
			this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
			// 
			// GenerateOptionsGroupBox
			// 
			this.GenerateOptionsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.GenerateOptionsGroupBox.Controls.Add(this.ReflashFirmwareCheckbox);
			this.GenerateOptionsGroupBox.Controls.Add(this.PowerManagementGroupBox);
			this.GenerateOptionsGroupBox.Controls.Add(this.MessageCountLabel);
			this.GenerateOptionsGroupBox.Controls.Add(this.MessageCountTextBox);
			this.GenerateOptionsGroupBox.Controls.Add(this.CollectionNameLabel);
			this.GenerateOptionsGroupBox.Controls.Add(this.CollectionNameTextBox);
			this.GenerateOptionsGroupBox.Location = new System.Drawing.Point(103, 52);
			this.GenerateOptionsGroupBox.Name = "GenerateOptionsGroupBox";
			this.GenerateOptionsGroupBox.Size = new System.Drawing.Size(645, 253);
			this.GenerateOptionsGroupBox.TabIndex = 5;
			this.GenerateOptionsGroupBox.TabStop = false;
			// 
			// ReflashFirmwareCheckbox
			// 
			this.ReflashFirmwareCheckbox.AutoSize = true;
			this.ReflashFirmwareCheckbox.Checked = true;
			this.ReflashFirmwareCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ReflashFirmwareCheckbox.Location = new System.Drawing.Point(9, 228);
			this.ReflashFirmwareCheckbox.Name = "ReflashFirmwareCheckbox";
			this.ReflashFirmwareCheckbox.Size = new System.Drawing.Size(107, 17);
			this.ReflashFirmwareCheckbox.TabIndex = 16;
			this.ReflashFirmwareCheckbox.Text = "Reflash Firmware";
			this.ReflashFirmwareCheckbox.UseVisualStyleBackColor = true;
			// 
			// PowerManagementGroupBox
			// 
			this.PowerManagementGroupBox.Controls.Add(this.PowerManagementWirelessNeoVIGroupBox);
			this.PowerManagementGroupBox.Controls.Add(this.PowerManagementWakeGroupBox);
			this.PowerManagementGroupBox.Controls.Add(this.PowerManagementSleepGroupBox);
			this.PowerManagementGroupBox.Location = new System.Drawing.Point(10, 65);
			this.PowerManagementGroupBox.Name = "PowerManagementGroupBox";
			this.PowerManagementGroupBox.Size = new System.Drawing.Size(625, 156);
			this.PowerManagementGroupBox.TabIndex = 15;
			this.PowerManagementGroupBox.TabStop = false;
			this.PowerManagementGroupBox.Text = "Power Management";
			// 
			// PowerManagementWirelessNeoVIGroupBox
			// 
			this.PowerManagementWirelessNeoVIGroupBox.Controls.Add(this.VoltageCutoffLabel);
			this.PowerManagementWirelessNeoVIGroupBox.Controls.Add(this.ConnectionTimeoutLabel);
			this.PowerManagementWirelessNeoVIGroupBox.Controls.Add(this.OverallTimeoutLabel);
			this.PowerManagementWirelessNeoVIGroupBox.Controls.Add(this.VoltageCutoffTextBox);
			this.PowerManagementWirelessNeoVIGroupBox.Controls.Add(this.ConnectionTimeoutTextBox);
			this.PowerManagementWirelessNeoVIGroupBox.Controls.Add(this.OverallTimeoutTextBox);
			this.PowerManagementWirelessNeoVIGroupBox.Location = new System.Drawing.Point(421, 20);
			this.PowerManagementWirelessNeoVIGroupBox.Name = "PowerManagementWirelessNeoVIGroupBox";
			this.PowerManagementWirelessNeoVIGroupBox.Size = new System.Drawing.Size(200, 130);
			this.PowerManagementWirelessNeoVIGroupBox.TabIndex = 2;
			this.PowerManagementWirelessNeoVIGroupBox.TabStop = false;
			this.PowerManagementWirelessNeoVIGroupBox.Text = "Wireless neoVI";
			// 
			// VoltageCutoffLabel
			// 
			this.VoltageCutoffLabel.AutoSize = true;
			this.VoltageCutoffLabel.Location = new System.Drawing.Point(10, 77);
			this.VoltageCutoffLabel.Name = "VoltageCutoffLabel";
			this.VoltageCutoffLabel.Size = new System.Drawing.Size(92, 13);
			this.VoltageCutoffLabel.TabIndex = 5;
			this.VoltageCutoffLabel.Text = "Voltage cutoff (V):";
			// 
			// ConnectionTimeoutLabel
			// 
			this.ConnectionTimeoutLabel.AutoSize = true;
			this.ConnectionTimeoutLabel.Location = new System.Drawing.Point(10, 51);
			this.ConnectionTimeoutLabel.Name = "ConnectionTimeoutLabel";
			this.ConnectionTimeoutLabel.Size = new System.Drawing.Size(146, 13);
			this.ConnectionTimeoutLabel.TabIndex = 4;
			this.ConnectionTimeoutLabel.Text = "Connection timeout (minutes):";
			// 
			// OverallTimeoutLabel
			// 
			this.OverallTimeoutLabel.AutoSize = true;
			this.OverallTimeoutLabel.Location = new System.Drawing.Point(10, 23);
			this.OverallTimeoutLabel.Name = "OverallTimeoutLabel";
			this.OverallTimeoutLabel.Size = new System.Drawing.Size(125, 13);
			this.OverallTimeoutLabel.TabIndex = 3;
			this.OverallTimeoutLabel.Text = "Overall timeout (minutes):";
			// 
			// VoltageCutoffTextBox
			// 
			this.VoltageCutoffTextBox.Location = new System.Drawing.Point(108, 74);
			this.VoltageCutoffTextBox.Name = "VoltageCutoffTextBox";
			this.VoltageCutoffTextBox.Size = new System.Drawing.Size(86, 20);
			this.VoltageCutoffTextBox.TabIndex = 2;
			this.VoltageCutoffTextBox.Text = "10.5";
			this.VoltageCutoffTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateContainsValidDouble);
			this.VoltageCutoffTextBox.Validated += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// ConnectionTimeoutTextBox
			// 
			this.ConnectionTimeoutTextBox.Location = new System.Drawing.Point(162, 48);
			this.ConnectionTimeoutTextBox.Name = "ConnectionTimeoutTextBox";
			this.ConnectionTimeoutTextBox.Size = new System.Drawing.Size(32, 20);
			this.ConnectionTimeoutTextBox.TabIndex = 1;
			this.ConnectionTimeoutTextBox.Text = "10";
			this.ConnectionTimeoutTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateContainsValidDouble);
			this.ConnectionTimeoutTextBox.Validated += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// OverallTimeoutTextBox
			// 
			this.OverallTimeoutTextBox.Location = new System.Drawing.Point(162, 20);
			this.OverallTimeoutTextBox.Name = "OverallTimeoutTextBox";
			this.OverallTimeoutTextBox.Size = new System.Drawing.Size(32, 20);
			this.OverallTimeoutTextBox.TabIndex = 0;
			this.OverallTimeoutTextBox.Text = "60";
			this.OverallTimeoutTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateContainsValidDouble);
			this.OverallTimeoutTextBox.Validated += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// PowerManagementWakeGroupBox
			// 
			this.PowerManagementWakeGroupBox.Controls.Add(this.RemoteWakeupLabel);
			this.PowerManagementWakeGroupBox.Controls.Add(this.StartNewFileOnWakeupCheckBox);
			this.PowerManagementWakeGroupBox.Controls.Add(this.RemoteWakeupCheckBox);
			this.PowerManagementWakeGroupBox.Controls.Add(this.WakeInstantRadioButton);
			this.PowerManagementWakeGroupBox.Controls.Add(this.WakeNormalRadioButton);
			this.PowerManagementWakeGroupBox.Location = new System.Drawing.Point(214, 20);
			this.PowerManagementWakeGroupBox.Name = "PowerManagementWakeGroupBox";
			this.PowerManagementWakeGroupBox.Size = new System.Drawing.Size(200, 130);
			this.PowerManagementWakeGroupBox.TabIndex = 1;
			this.PowerManagementWakeGroupBox.TabStop = false;
			this.PowerManagementWakeGroupBox.Text = "Wake";
			// 
			// RemoteWakeupLabel
			// 
			this.RemoteWakeupLabel.AutoSize = true;
			this.RemoteWakeupLabel.Location = new System.Drawing.Point(6, 86);
			this.RemoteWakeupLabel.Name = "RemoteWakeupLabel";
			this.RemoteWakeupLabel.Size = new System.Drawing.Size(69, 13);
			this.RemoteWakeupLabel.TabIndex = 4;
			this.RemoteWakeupLabel.Text = "devices only)";
			// 
			// StartNewFileOnWakeupCheckBox
			// 
			this.StartNewFileOnWakeupCheckBox.AutoSize = true;
			this.StartNewFileOnWakeupCheckBox.Checked = true;
			this.StartNewFileOnWakeupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.StartNewFileOnWakeupCheckBox.Location = new System.Drawing.Point(6, 107);
			this.StartNewFileOnWakeupCheckBox.Name = "StartNewFileOnWakeupCheckBox";
			this.StartNewFileOnWakeupCheckBox.Size = new System.Drawing.Size(152, 17);
			this.StartNewFileOnWakeupCheckBox.TabIndex = 3;
			this.StartNewFileOnWakeupCheckBox.Text = "Start a new file on wakeup";
			this.StartNewFileOnWakeupCheckBox.UseVisualStyleBackColor = true;
			this.StartNewFileOnWakeupCheckBox.CheckedChanged += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// RemoteWakeupCheckBox
			// 
			this.RemoteWakeupCheckBox.AutoSize = true;
			this.RemoteWakeupCheckBox.Location = new System.Drawing.Point(6, 66);
			this.RemoteWakeupCheckBox.Name = "RemoteWakeupCheckBox";
			this.RemoteWakeupCheckBox.Size = new System.Drawing.Size(178, 17);
			this.RemoteWakeupCheckBox.TabIndex = 2;
			this.RemoteWakeupCheckBox.Text = "Enable remote wakeup (wireless";
			this.RemoteWakeupCheckBox.UseVisualStyleBackColor = true;
			this.RemoteWakeupCheckBox.CheckedChanged += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// WakeInstantRadioButton
			// 
			this.WakeInstantRadioButton.AutoSize = true;
			this.WakeInstantRadioButton.Location = new System.Drawing.Point(7, 43);
			this.WakeInstantRadioButton.Name = "WakeInstantRadioButton";
			this.WakeInstantRadioButton.Size = new System.Drawing.Size(102, 17);
			this.WakeInstantRadioButton.TabIndex = 1;
			this.WakeInstantRadioButton.Text = "Instant (HS/MS)";
			this.WakeInstantRadioButton.UseVisualStyleBackColor = true;
			this.WakeInstantRadioButton.CheckedChanged += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// WakeNormalRadioButton
			// 
			this.WakeNormalRadioButton.AutoSize = true;
			this.WakeNormalRadioButton.Checked = true;
			this.WakeNormalRadioButton.Location = new System.Drawing.Point(7, 20);
			this.WakeNormalRadioButton.Name = "WakeNormalRadioButton";
			this.WakeNormalRadioButton.Size = new System.Drawing.Size(58, 17);
			this.WakeNormalRadioButton.TabIndex = 0;
			this.WakeNormalRadioButton.TabStop = true;
			this.WakeNormalRadioButton.Text = "Normal";
			this.WakeNormalRadioButton.UseVisualStyleBackColor = true;
			this.WakeNormalRadioButton.CheckedChanged += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// PowerManagementSleepGroupBox
			// 
			this.PowerManagementSleepGroupBox.Controls.Add(this.BusActivityThresholdLabel);
			this.PowerManagementSleepGroupBox.Controls.Add(this.BusActivityThresholdTextBox);
			this.PowerManagementSleepGroupBox.Controls.Add(this.SleepOnNoBusActivityRadioButton);
			this.PowerManagementSleepGroupBox.Controls.Add(this.NeverGoToSleepRadioButton);
			this.PowerManagementSleepGroupBox.Location = new System.Drawing.Point(7, 20);
			this.PowerManagementSleepGroupBox.Name = "PowerManagementSleepGroupBox";
			this.PowerManagementSleepGroupBox.Size = new System.Drawing.Size(200, 130);
			this.PowerManagementSleepGroupBox.TabIndex = 0;
			this.PowerManagementSleepGroupBox.TabStop = false;
			this.PowerManagementSleepGroupBox.Text = "Sleep";
			// 
			// BusActivityThresholdLabel
			// 
			this.BusActivityThresholdLabel.AutoSize = true;
			this.BusActivityThresholdLabel.Location = new System.Drawing.Point(6, 64);
			this.BusActivityThresholdLabel.Name = "BusActivityThresholdLabel";
			this.BusActivityThresholdLabel.Size = new System.Drawing.Size(71, 13);
			this.BusActivityThresholdLabel.TabIndex = 3;
			this.BusActivityThresholdLabel.Text = "for (seconds):";
			// 
			// BusActivityThresholdTextBox
			// 
			this.BusActivityThresholdTextBox.Location = new System.Drawing.Point(83, 61);
			this.BusActivityThresholdTextBox.Name = "BusActivityThresholdTextBox";
			this.BusActivityThresholdTextBox.Size = new System.Drawing.Size(100, 20);
			this.BusActivityThresholdTextBox.TabIndex = 2;
			this.BusActivityThresholdTextBox.Text = "120.00";
			this.BusActivityThresholdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateContainsValidDouble);
			this.BusActivityThresholdTextBox.Validated += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// SleepOnNoBusActivityRadioButton
			// 
			this.SleepOnNoBusActivityRadioButton.AutoSize = true;
			this.SleepOnNoBusActivityRadioButton.Checked = true;
			this.SleepOnNoBusActivityRadioButton.Location = new System.Drawing.Point(7, 44);
			this.SleepOnNoBusActivityRadioButton.Name = "SleepOnNoBusActivityRadioButton";
			this.SleepOnNoBusActivityRadioButton.Size = new System.Drawing.Size(174, 17);
			this.SleepOnNoBusActivityRadioButton.TabIndex = 1;
			this.SleepOnNoBusActivityRadioButton.TabStop = true;
			this.SleepOnNoBusActivityRadioButton.Text = "Sleep when bus activity ceases";
			this.SleepOnNoBusActivityRadioButton.UseVisualStyleBackColor = true;
			this.SleepOnNoBusActivityRadioButton.CheckedChanged += new System.EventHandler(this.SleepOnNoBusActivityRadioButton_CheckedChanged);
			// 
			// NeverGoToSleepRadioButton
			// 
			this.NeverGoToSleepRadioButton.AutoSize = true;
			this.NeverGoToSleepRadioButton.Location = new System.Drawing.Point(7, 20);
			this.NeverGoToSleepRadioButton.Name = "NeverGoToSleepRadioButton";
			this.NeverGoToSleepRadioButton.Size = new System.Drawing.Size(109, 17);
			this.NeverGoToSleepRadioButton.TabIndex = 0;
			this.NeverGoToSleepRadioButton.Text = "Never go to sleep";
			this.NeverGoToSleepRadioButton.UseVisualStyleBackColor = true;
			this.NeverGoToSleepRadioButton.CheckedChanged += new System.EventHandler(this.UpdateDAQEvent);
			// 
			// MessageCountLabel
			// 
			this.MessageCountLabel.AutoSize = true;
			this.MessageCountLabel.Location = new System.Drawing.Point(6, 42);
			this.MessageCountLabel.Name = "MessageCountLabel";
			this.MessageCountLabel.Size = new System.Drawing.Size(154, 13);
			this.MessageCountLabel.TabIndex = 14;
			this.MessageCountLabel.Text = "Number of Messages to Collect";
			// 
			// MessageCountTextBox
			// 
			this.MessageCountTextBox.Location = new System.Drawing.Point(170, 39);
			this.MessageCountTextBox.Name = "MessageCountTextBox";
			this.MessageCountTextBox.Size = new System.Drawing.Size(119, 20);
			this.MessageCountTextBox.TabIndex = 13;
			this.MessageCountTextBox.Text = "50000";
			this.MessageCountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateContainsDigitsOnly);
			// 
			// CollectionNameLabel
			// 
			this.CollectionNameLabel.AutoSize = true;
			this.CollectionNameLabel.Location = new System.Drawing.Point(6, 16);
			this.CollectionNameLabel.Name = "CollectionNameLabel";
			this.CollectionNameLabel.Size = new System.Drawing.Size(84, 13);
			this.CollectionNameLabel.TabIndex = 12;
			this.CollectionNameLabel.Text = "Collection Name";
			// 
			// CollectionNameTextBox
			// 
			this.CollectionNameTextBox.Location = new System.Drawing.Point(96, 13);
			this.CollectionNameTextBox.Name = "CollectionNameTextBox";
			this.CollectionNameTextBox.Size = new System.Drawing.Size(193, 20);
			this.CollectionNameTextBox.TabIndex = 11;
			this.CollectionNameTextBox.Text = "Collection 1";
			this.CollectionNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CollectionNameTextBox_Validating);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GenerateButton.Location = new System.Drawing.Point(3, 341);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(838, 23);
			this.GenerateButton.TabIndex = 4;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// LogLabel
			// 
			this.LogLabel.AutoSize = true;
			this.LogLabel.Location = new System.Drawing.Point(3, 5);
			this.LogLabel.Name = "LogLabel";
			this.LogLabel.Size = new System.Drawing.Size(25, 13);
			this.LogLabel.TabIndex = 6;
			this.LogLabel.Text = "Log";
			// 
			// LogTextbox
			// 
			this.LogTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LogTextbox.Location = new System.Drawing.Point(3, 21);
			this.LogTextbox.Multiline = true;
			this.LogTextbox.Name = "LogTextbox";
			this.LogTextbox.ReadOnly = true;
			this.LogTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LogTextbox.Size = new System.Drawing.Size(858, 81);
			this.LogTextbox.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 579);
			this.Controls.Add(this.LogTabSplitter);
			this.Controls.Add(this.TitleBarMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.TitleBarMenuStrip;
			this.Name = "MainForm";
			this.Text = "VehicleScape API Example";
			this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
			this.TitleBarMenuStrip.ResumeLayout(false);
			this.TitleBarMenuStrip.PerformLayout();
			this.LogTabSplitter.Panel1.ResumeLayout(false);
			this.LogTabSplitter.Panel2.ResumeLayout(false);
			this.LogTabSplitter.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LogTabSplitter)).EndInit();
			this.LogTabSplitter.ResumeLayout(false);
			this.MainTabControl.ResumeLayout(false);
			this.DAQsAndDevicesPage.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.SignalsPage.ResumeLayout(false);
			this.ChannelViewSplitter.Panel1.ResumeLayout(false);
			this.ChannelViewSplitter.Panel1.PerformLayout();
			this.ChannelViewSplitter.Panel2.ResumeLayout(false);
			this.ChannelViewSplitter.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChannelViewSplitter)).EndInit();
			this.ChannelViewSplitter.ResumeLayout(false);
			this.GeneratePage.ResumeLayout(false);
			this.GenerateOptionsGroupBox.ResumeLayout(false);
			this.GenerateOptionsGroupBox.PerformLayout();
			this.PowerManagementGroupBox.ResumeLayout(false);
			this.PowerManagementWirelessNeoVIGroupBox.ResumeLayout(false);
			this.PowerManagementWirelessNeoVIGroupBox.PerformLayout();
			this.PowerManagementWakeGroupBox.ResumeLayout(false);
			this.PowerManagementWakeGroupBox.PerformLayout();
			this.PowerManagementSleepGroupBox.ResumeLayout(false);
			this.PowerManagementSleepGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip TitleBarMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadDBCToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.SplitContainer LogTabSplitter;
		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage DAQsAndDevicesPage;
		private System.Windows.Forms.Label DAQLabel;
		private System.Windows.Forms.TabPage SignalsPage;
		private System.Windows.Forms.SplitContainer ChannelViewSplitter;
		private System.Windows.Forms.Label AvailableSignalsLabel;
		private System.Windows.Forms.ListView AvailableChannelsListView;
		private System.Windows.Forms.ColumnHeader AvailableSignalNameColumn;
		private System.Windows.Forms.ColumnHeader AvailableSourceColumn;
		private System.Windows.Forms.ColumnHeader AvailableNetworkColumn;
		private System.Windows.Forms.ColumnHeader AvailableTypeColumn;
		private System.Windows.Forms.Label SelectedSignalsLabel;
		private System.Windows.Forms.ListView SelectedChannelsListView;
		private System.Windows.Forms.ColumnHeader SelectedSignalNameColumn;
		private System.Windows.Forms.ColumnHeader SelectedSourceColumn;
		private System.Windows.Forms.ColumnHeader SelectedNetworkColumn;
		private System.Windows.Forms.ColumnHeader SelectedTypeColumn;
		private System.Windows.Forms.Button MoveAllSelectedToAvailable;
		private System.Windows.Forms.Button MoveSelectedToAvailable;
		private System.Windows.Forms.Button MoveAllAvailableToSelected;
		private System.Windows.Forms.Button MoveAvailableToSelected;
		private System.Windows.Forms.TabPage GeneratePage;
		private System.Windows.Forms.Button UploadButton;
		private System.Windows.Forms.GroupBox GenerateOptionsGroupBox;
		private System.Windows.Forms.GroupBox PowerManagementGroupBox;
		private System.Windows.Forms.GroupBox PowerManagementWirelessNeoVIGroupBox;
		private System.Windows.Forms.Label VoltageCutoffLabel;
		private System.Windows.Forms.Label ConnectionTimeoutLabel;
		private System.Windows.Forms.Label OverallTimeoutLabel;
		private System.Windows.Forms.TextBox VoltageCutoffTextBox;
		private System.Windows.Forms.TextBox ConnectionTimeoutTextBox;
		private System.Windows.Forms.TextBox OverallTimeoutTextBox;
		private System.Windows.Forms.GroupBox PowerManagementWakeGroupBox;
		private System.Windows.Forms.Label RemoteWakeupLabel;
		private System.Windows.Forms.CheckBox StartNewFileOnWakeupCheckBox;
		private System.Windows.Forms.CheckBox RemoteWakeupCheckBox;
		private System.Windows.Forms.RadioButton WakeInstantRadioButton;
		private System.Windows.Forms.RadioButton WakeNormalRadioButton;
		private System.Windows.Forms.GroupBox PowerManagementSleepGroupBox;
		private System.Windows.Forms.Label BusActivityThresholdLabel;
		private System.Windows.Forms.TextBox BusActivityThresholdTextBox;
		private System.Windows.Forms.RadioButton SleepOnNoBusActivityRadioButton;
		private System.Windows.Forms.RadioButton NeverGoToSleepRadioButton;
		private System.Windows.Forms.Label MessageCountLabel;
		private System.Windows.Forms.TextBox MessageCountTextBox;
		private System.Windows.Forms.Label CollectionNameLabel;
		private System.Windows.Forms.TextBox CollectionNameTextBox;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Label LogLabel;
		private System.Windows.Forms.TextBox LogTextbox;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView DAQListView;
		private System.Windows.Forms.ColumnHeader DAQName;
		private System.Windows.Forms.ListView DeviceListView;
		private System.Windows.Forms.ColumnHeader DeviceHandle;
		private System.Windows.Forms.Label DeviceLabel;
		private System.Windows.Forms.ColumnHeader DeviceType;
		private System.Windows.Forms.ColumnHeader DeviceSerial;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.CheckBox ReflashFirmwareCheckbox;
		private System.Windows.Forms.Button AddDAQButton;
	}
}

