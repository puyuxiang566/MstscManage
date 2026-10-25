namespace MstscManage
{
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.MainForm));
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripStatusLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.lvServerListContextMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.Menu_Link = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Menu_TvnViewerConnect = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Copy_MenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyServer_MenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyUserName_MenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyPwd_MenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Menu_NewClient = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Menu_DeleteClient = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Menu_EditClientSettings = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lvServerLists_IL48 = new global::System.Windows.Forms.ImageList(this.components);
			this.saveToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.saveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lvServerLists_IL16 = new global::System.Windows.Forms.ImageList(this.components);
			this.splitter1 = new global::System.Windows.Forms.Splitter();
			this.tabstripMDIContextMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStrip = new global::System.Windows.Forms.ToolStrip();
			this.NewClient_Link = new global::System.Windows.Forms.ToolStripButton();
			this.Button_Link = new global::System.Windows.Forms.ToolStripButton();
			this.DeleteClient_Button = new global::System.Windows.Forms.ToolStripButton();
			this.ExportRDP_Button = new global::System.Windows.Forms.ToolStripButton();
			this.MoveUp_Button = new global::System.Windows.Forms.ToolStripButton();
			this.MoveDown_Button = new global::System.Windows.Forms.ToolStripButton();
			this.StateDetection_Button = new global::System.Windows.Forms.ToolStripButton();
			this.SetUPButton = new global::System.Windows.Forms.ToolStripButton();
			this.RemarksButton = new global::System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.TextStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.OperationStateLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.DeleteStateTime = new global::System.Windows.Forms.Timer(this.components);
			this.HostDataGridView = new global::System.Windows.Forms.DataGridView();
			this.ColumnID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSortNumber = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnServerName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnServer = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnUserName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnGrouping = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRemoteType = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDescription = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPort = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPassword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnColorDepth = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDesktopWidth = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDesktopHeight = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupingComboBox = new global::System.Windows.Forms.ComboBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.Search_Text = new global::System.Windows.Forms.TextBox();
			this.Search_Button = new global::System.Windows.Forms.Button();
			this.lvServerListContextMenu.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.HostDataGridView).BeginInit();
			base.SuspendLayout();
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(149, 6);
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new global::System.Drawing.Size(39, 17);
			this.toolStripStatusLabel.Text = "Status";
			this.Menu_BatchGrouping = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator_BatchGrouping = new global::System.Windows.Forms.ToolStripSeparator();
			this.lvServerListContextMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Menu_Link,
				this.Menu_TvnViewerConnect,
				this.Copy_MenuItem,
				this.CopyServer_MenuItem,
				this.CopyUserName_MenuItem,
				this.CopyPwd_MenuItem,
				this.Menu_NewClient,
				this.Menu_DeleteClient,
				this.Menu_EditClientSettings,
				this.toolStripSeparator_BatchGrouping,
				this.Menu_BatchGrouping
			});
			this.lvServerListContextMenu.Name = "lvServerListContextMenu";
			this.lvServerListContextMenu.Size = new global::System.Drawing.Size(161, 224);
			this.Menu_Link.Image = global::MstscManage.Properties.Resources.kaishi;
			this.Menu_Link.Name = "Menu_Link";
			this.Menu_Link.Size = new global::System.Drawing.Size(160, 22);
			this.Menu_Link.Text = "连接主机";
			this.Menu_Link.Click += new global::System.EventHandler(this.Menu_Link_Click);
			this.Menu_TvnViewerConnect.Image = global::MstscManage.Properties.Resources.kaishi;
			this.Menu_TvnViewerConnect.Name = "Menu_TvnViewerConnect";
			this.Menu_TvnViewerConnect.Size = new global::System.Drawing.Size(160, 22);
			this.Menu_TvnViewerConnect.Text = "用 tvnviewer 连接";
			this.Menu_TvnViewerConnect.Click += new global::System.EventHandler(this.Menu_TvnViewerConnect_Click);
			this.Copy_MenuItem.Image = global::MstscManage.Properties.Resources.Copy;
			this.Copy_MenuItem.Name = "Copy_MenuItem";
			this.Copy_MenuItem.Size = new global::System.Drawing.Size(160, 22);
			this.Copy_MenuItem.Text = "复制新增主机";
			this.Copy_MenuItem.Click += new global::System.EventHandler(this.Copy_MenuItem_Click);
			this.CopyServer_MenuItem.Image = global::MstscManage.Properties.Resources.Copy2;
			this.CopyServer_MenuItem.Name = "CopyServer_MenuItem";
			this.CopyServer_MenuItem.Size = new global::System.Drawing.Size(160, 22);
			this.CopyServer_MenuItem.Text = "复制链接地址";
			this.CopyServer_MenuItem.Click += new global::System.EventHandler(this.CopyServer_MenuItem_Click);
			this.CopyUserName_MenuItem.Image = global::MstscManage.Properties.Resources.Copy2;
			this.CopyUserName_MenuItem.Name = "CopyUserName_MenuItem";
			this.CopyUserName_MenuItem.Size = new global::System.Drawing.Size(160, 22);
			this.CopyUserName_MenuItem.Text = "复制链接用户名";
			this.CopyUserName_MenuItem.Click += new global::System.EventHandler(this.CopyUserName_MenuItem_Click);
			this.CopyPwd_MenuItem.Image = global::MstscManage.Properties.Resources.Copy2;
			this.CopyPwd_MenuItem.Name = "CopyPwd_MenuItem";
			this.CopyPwd_MenuItem.Size = new global::System.Drawing.Size(160, 22);
			this.CopyPwd_MenuItem.Text = "复制链接密码";
			this.CopyPwd_MenuItem.Click += new global::System.EventHandler(this.CopyPwd_MenuItem_Click);
			this.Menu_NewClient.Image = global::MstscManage.Properties.Resources.xinjian;
			this.Menu_NewClient.Name = "Menu_NewClient";
			this.Menu_NewClient.Size = new global::System.Drawing.Size(160, 22);
			this.Menu_NewClient.Text = "新建连接";
			this.Menu_NewClient.Click += new global::System.EventHandler(this.lvServerListsContextMenu_NewClient_Click);
			this.Menu_DeleteClient.Image = global::MstscManage.Properties.Resources.shanchu;
			this.Menu_DeleteClient.Name = "Menu_DeleteClient";
			this.Menu_DeleteClient.Size = new global::System.Drawing.Size(160, 22);
			this.Menu_DeleteClient.Text = "删除连接";
			this.Menu_DeleteClient.Click += new global::System.EventHandler(this.lvServerListsContextMenu_DeleteClient_Click);
			this.Menu_EditClientSettings.Image = global::MstscManage.Properties.Resources.bianji;
			this.Menu_EditClientSettings.Name = "Menu_EditClientSettings";
			this.Menu_EditClientSettings.Size = new global::System.Drawing.Size(160, 22);
			this.Menu_EditClientSettings.Text = "编辑配置";
			this.Menu_EditClientSettings.Click += new global::System.EventHandler(this.lvServerListsContextMenu_EditClientSettings_Click);
			this.toolStripSeparator_BatchGrouping.Name = "toolStripSeparator_BatchGrouping";
			this.toolStripSeparator_BatchGrouping.Size = new global::System.Drawing.Size(157, 6);
			this.Menu_BatchGrouping.Name = "Menu_BatchGrouping";
			this.Menu_BatchGrouping.Size = new global::System.Drawing.Size(160, 22);
			this.Menu_BatchGrouping.Text = "批量修改分组";
			this.Menu_BatchGrouping.Click += new global::System.EventHandler(this.Menu_BatchGrouping_Click);
			this.lvServerLists_IL48.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("lvServerLists_IL48.ImageStream");
			this.lvServerLists_IL48.TransparentColor = global::System.Drawing.Color.Transparent;
			this.lvServerLists_IL48.Images.SetKeyName(0, "mstscax.dll_I345e_0409_16_48a.ico");
			this.lvServerLists_IL48.Images.SetKeyName(1, "mstscax.dll_I345e_0409_16_48a_grey.ico");
			this.lvServerLists_IL48.Images.SetKeyName(2, "logon_settings_48.ico");
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new global::System.Drawing.Size(23, 23);
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.lvServerLists_IL16.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("lvServerLists_IL16.ImageStream");
			this.lvServerLists_IL16.TransparentColor = global::System.Drawing.Color.Transparent;
			this.lvServerLists_IL16.Images.SetKeyName(0, "mstscax_16x16_32bpp.ico");
			this.lvServerLists_IL16.Images.SetKeyName(1, "mstscax_16x16_32bpp_grey.ico");
			this.lvServerLists_IL16.Images.SetKeyName(2, "mstscax_16x16_32bpp_secured.ico");
			this.splitter1.Location = new global::System.Drawing.Point(0, 25);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new global::System.Drawing.Size(3, 522);
			this.splitter1.TabIndex = 19;
			this.splitter1.TabStop = false;
			this.tabstripMDIContextMenu.Name = "contextMenuStrip1";
			this.tabstripMDIContextMenu.Size = new global::System.Drawing.Size(61, 4);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(6, 25);
			this.toolStrip.BackColor = global::System.Drawing.SystemColors.Control;
			this.toolStrip.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStrip.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.NewClient_Link,
				this.Button_Link,
				this.DeleteClient_Button,
				this.ExportRDP_Button,
				this.toolStripSeparator4,
				this.MoveUp_Button,
				this.MoveDown_Button,
				this.StateDetection_Button,
				this.SetUPButton,
				this.RemarksButton
			});
			this.toolStrip.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip.Size = new global::System.Drawing.Size(724, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "ToolStrip";
			this.NewClient_Link.Image = global::MstscManage.Properties.Resources.xinjian;
			this.NewClient_Link.ImageTransparentColor = global::System.Drawing.Color.Black;
			this.NewClient_Link.Name = "NewClient_Link";
			this.NewClient_Link.Size = new global::System.Drawing.Size(92, 22);
			this.NewClient_Link.Text = "添加新主机";
			this.NewClient_Link.Click += new global::System.EventHandler(this.ShowNewForm);
			this.Button_Link.Image = global::MstscManage.Properties.Resources.kaishi;
			this.Button_Link.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.Button_Link.Name = "Button_Link";
			this.Button_Link.Size = new global::System.Drawing.Size(79, 22);
			this.Button_Link.Text = "链接主机";
			this.Button_Link.Click += new global::System.EventHandler(this.Button_Link_Click);
			this.DeleteClient_Button.Image = global::MstscManage.Properties.Resources.shanchu;
			this.DeleteClient_Button.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.DeleteClient_Button.Name = "DeleteClient_Button";
			this.DeleteClient_Button.Size = new global::System.Drawing.Size(79, 22);
			this.DeleteClient_Button.Text = "删除主机";
			this.DeleteClient_Button.ToolTipText = "Delete selected RDP Server";
			this.DeleteClient_Button.Click += new global::System.EventHandler(this.DeleteClient_Button_Click);
			this.ExportRDP_Button.Image = global::MstscManage.Properties.Resources.daochu;
			this.ExportRDP_Button.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ExportRDP_Button.Name = "ExportRDP_Button";
			this.ExportRDP_Button.Size = new global::System.Drawing.Size(113, 22);
			this.ExportRDP_Button.Text = "导出到RDP文件";
			this.ExportRDP_Button.Click += new global::System.EventHandler(this.ExportRDP_Button_Click);
			this.MoveUp_Button.Image = global::MstscManage.Properties.Resources.shangyi;
			this.MoveUp_Button.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.MoveUp_Button.Name = "MoveUp_Button";
			this.MoveUp_Button.Size = new global::System.Drawing.Size(53, 22);
			this.MoveUp_Button.Text = "上移";
			this.MoveUp_Button.Click += new global::System.EventHandler(this.MoveUp_Button_Click);
			this.MoveDown_Button.Image = global::MstscManage.Properties.Resources.xiayi;
			this.MoveDown_Button.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.MoveDown_Button.Name = "MoveDown_Button";
			this.MoveDown_Button.Size = new global::System.Drawing.Size(53, 22);
			this.MoveDown_Button.Text = "下移";
			this.MoveDown_Button.Click += new global::System.EventHandler(this.MoveDown_Button_Click);
			this.StateDetection_Button.Image = global::MstscManage.Properties.Resources.zhuangtai;
			this.StateDetection_Button.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.StateDetection_Button.Name = "StateDetection_Button";
			this.StateDetection_Button.Size = new global::System.Drawing.Size(105, 22);
			this.StateDetection_Button.Text = "检测主机状态";
			this.StateDetection_Button.Click += new global::System.EventHandler(this.StateDetection_Button_Click);
			this.SetUPButton.Image = global::MstscManage.Properties.Resources.shezhi;
			this.SetUPButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.SetUPButton.Name = "SetUPButton";
			this.SetUPButton.Size = new global::System.Drawing.Size(53, 22);
			this.SetUPButton.Text = "设置";
			this.SetUPButton.Click += new global::System.EventHandler(this.toolStripButton1_Click);
			this.RemarksButton.Image = global::MstscManage.Properties.Resources.Beiwang;
			this.RemarksButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.RemarksButton.Name = "RemarksButton";
			this.RemarksButton.Size = new global::System.Drawing.Size(66, 22);
			this.RemarksButton.Text = "备忘录";
			this.RemarksButton.Click += new global::System.EventHandler(this.RemarksButton_Click);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.TextStatus,
				this.OperationStateLabel
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(3, 525);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new global::System.Drawing.Size(721, 22);
			this.statusStrip1.TabIndex = 21;
			this.statusStrip1.Text = "statusStrip1";
			this.TextStatus.Name = "TextStatus";
			this.TextStatus.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.TextStatus.Size = new global::System.Drawing.Size(39, 17);
			this.TextStatus.Text = "共0项";
			this.OperationStateLabel.Name = "OperationStateLabel";
			this.OperationStateLabel.Size = new global::System.Drawing.Size(0, 17);
			this.DeleteStateTime.Interval = 2000;
			this.DeleteStateTime.Tick += new global::System.EventHandler(this.DeleteStateTime_Tick);
			this.HostDataGridView.AllowUserToAddRows = false;
			this.HostDataGridView.AllowUserToDeleteRows = false;
			this.HostDataGridView.AutoGenerateColumns = false;
			this.HostDataGridView.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.HostDataGridView.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.HostDataGridView.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.ColumnID,
				this.ColumnSortNumber,
				this.ColumnServerName,
				this.ColumnServer,
				this.ColumnUserName,
				this.ColumnGrouping,
				this.ColumnRemoteType,
				this.ColumnDescription,
				this.ColumnPort,
				this.ColumnPassword,
				this.ColumnColorDepth,
				this.ColumnDesktopWidth,
				this.ColumnDesktopHeight
			});
			this.HostDataGridView.Location = new global::System.Drawing.Point(3, 60);
			this.HostDataGridView.MultiSelect = true;
			this.HostDataGridView.Name = "HostDataGridView";
			this.HostDataGridView.ReadOnly = true;
			this.HostDataGridView.RowTemplate.Height = 23;
			this.HostDataGridView.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.HostDataGridView.Size = new global::System.Drawing.Size(721, 465);
			this.HostDataGridView.TabIndex = 22;
			this.ColumnID.DataPropertyName = "Id";
			this.ColumnID.HeaderText = "Id";
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.ReadOnly = true;
			this.ColumnID.Visible = false;
			this.ColumnSortNumber.DataPropertyName = "SortNumber";
			this.ColumnSortNumber.HeaderText = "序号";
			this.ColumnSortNumber.Name = "ColumnSortNumber";
			this.ColumnSortNumber.ReadOnly = true;
			this.ColumnSortNumber.Visible = false;
			this.ColumnSortNumber.Width = 60;
			this.ColumnServerName.DataPropertyName = "ServerName";
			this.ColumnServerName.HeaderText = "主机标题";
			this.ColumnServerName.Name = "ColumnServerName";
			this.ColumnServerName.ReadOnly = true;
			this.ColumnServerName.Width = 150;
			this.ColumnServer.DataPropertyName = "Server";
			this.ColumnServer.HeaderText = "计算机地址";
			this.ColumnServer.Name = "ColumnServer";
			this.ColumnServer.ReadOnly = true;
			this.ColumnServer.Width = 130;
			this.ColumnUserName.DataPropertyName = "UserName";
			this.ColumnUserName.HeaderText = "用户名";
			this.ColumnUserName.Name = "ColumnUserName";
			this.ColumnUserName.ReadOnly = true;
			this.ColumnUserName.Width = 150;
			this.ColumnGrouping.DataPropertyName = "Grouping";
			this.ColumnGrouping.HeaderText = "分组";
			this.ColumnGrouping.Name = "ColumnGrouping";
			this.ColumnGrouping.ReadOnly = true;
			this.ColumnGrouping.Width = 80;
			this.ColumnRemoteType.DataPropertyName = "RemoteType";
			this.ColumnRemoteType.HeaderText = "远程类型";
			this.ColumnRemoteType.Name = "ColumnRemoteType";
			this.ColumnRemoteType.ReadOnly = true;
			this.ColumnRemoteType.Visible = false;
			this.ColumnRemoteType.Width = 90;
			this.ColumnDescription.DataPropertyName = "Description";
			this.ColumnDescription.HeaderText = "备注";
			this.ColumnDescription.Name = "ColumnDescription";
			this.ColumnDescription.ReadOnly = true;
			this.ColumnDescription.Width = 150;
			this.ColumnPort.DataPropertyName = "Port";
			this.ColumnPort.HeaderText = "端口号";
			this.ColumnPort.Name = "ColumnPort";
			this.ColumnPort.ReadOnly = true;
			this.ColumnPort.Visible = false;
			this.ColumnPassword.DataPropertyName = "Password";
			this.ColumnPassword.HeaderText = "密码";
			this.ColumnPassword.Name = "ColumnPassword";
			this.ColumnPassword.ReadOnly = true;
			this.ColumnPassword.Visible = false;
			this.ColumnColorDepth.DataPropertyName = "ColorDepth";
			this.ColumnColorDepth.HeaderText = "色彩深度";
			this.ColumnColorDepth.Name = "ColumnColorDepth";
			this.ColumnColorDepth.ReadOnly = true;
			this.ColumnColorDepth.Visible = false;
			this.ColumnDesktopWidth.DataPropertyName = "DesktopWidth";
			this.ColumnDesktopWidth.HeaderText = "桌面宽度";
			this.ColumnDesktopWidth.Name = "ColumnDesktopWidth";
			this.ColumnDesktopWidth.ReadOnly = true;
			this.ColumnDesktopWidth.Visible = false;
			this.ColumnDesktopHeight.DataPropertyName = "DesktopHeight";
			this.ColumnDesktopHeight.HeaderText = "桌面高度";
			this.ColumnDesktopHeight.Name = "ColumnDesktopHeight";
			this.ColumnDesktopHeight.ReadOnly = true;
			this.ColumnDesktopHeight.Visible = false;
			this.GroupingComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GroupingComboBox.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.GroupingComboBox.FormattingEnabled = true;
			this.GroupingComboBox.Items.AddRange(new object[]
			{
				"全部主机"
			});
			this.GroupingComboBox.Location = new global::System.Drawing.Point(103, 26);
			this.GroupingComboBox.Name = "GroupingComboBox";
			this.GroupingComboBox.Size = new global::System.Drawing.Size(194, 29);
			this.GroupingComboBox.TabIndex = 24;
			this.GroupingComboBox.TextChanged += new global::System.EventHandler(this.GroupingComboBox_TextChanged);
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.label12.Location = new global::System.Drawing.Point(12, 30);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(95, 21);
			this.label12.TabIndex = 23;
			this.label12.Text = "主机分组：";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.label1.Location = new global::System.Drawing.Point(303, 30);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(61, 21);
			this.label1.TabIndex = 25;
			this.label1.Text = "搜索：";
			this.Search_Text.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.Search_Text.Location = new global::System.Drawing.Point(359, 26);
			this.Search_Text.Name = "Search_Text";
			this.Search_Text.Size = new global::System.Drawing.Size(164, 29);
			this.Search_Text.TabIndex = 26;
			this.Search_Button.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.Search_Button.Location = new global::System.Drawing.Point(529, 25);
			this.Search_Button.Name = "Search_Button";
			this.Search_Button.Size = new global::System.Drawing.Size(75, 29);
			this.Search_Button.TabIndex = 27;
			this.Search_Button.Text = "搜索";
			this.Search_Button.UseVisualStyleBackColor = true;
			this.Search_Button.Click += new global::System.EventHandler(this.Search_Button_Click);
			base.AcceptButton = this.Search_Button;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(724, 547);
			base.Controls.Add(this.Search_Button);
			base.Controls.Add(this.Search_Text);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.GroupingComboBox);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.HostDataGridView);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.splitter1);
			base.Controls.Add(this.toolStrip);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "MainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "远程桌面管理";
			base.Load += new global::System.EventHandler(this.MainForm_Load);
			this.lvServerListContextMenu.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.HostDataGridView).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

		private global::System.Windows.Forms.ToolTip toolTip;

		private global::System.Windows.Forms.ImageList lvServerLists_IL48;

		private global::System.Windows.Forms.ToolStripButton saveToolStripButton;

		private global::System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;

		private global::System.Windows.Forms.ContextMenuStrip lvServerListContextMenu;

		private global::System.Windows.Forms.ToolStripMenuItem Menu_NewClient;

		private global::System.Windows.Forms.ToolStripMenuItem Menu_DeleteClient;

		private global::System.Windows.Forms.ToolStripMenuItem Menu_EditClientSettings;

		private global::System.Windows.Forms.ImageList lvServerLists_IL16;

		private global::System.Windows.Forms.Splitter splitter1;

		private global::System.Windows.Forms.ContextMenuStrip tabstripMDIContextMenu;

		private global::System.Windows.Forms.ToolStripMenuItem Menu_Link;

		private global::System.Windows.Forms.ToolStripMenuItem Menu_TvnViewerConnect;

		private global::System.Windows.Forms.ToolStripButton NewClient_Link;

		private global::System.Windows.Forms.ToolStripButton Button_Link;

		private global::System.Windows.Forms.ToolStripButton DeleteClient_Button;

		private global::System.Windows.Forms.ToolStripButton ExportRDP_Button;

		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private global::System.Windows.Forms.ToolStripButton MoveUp_Button;

		private global::System.Windows.Forms.ToolStripButton MoveDown_Button;

		private global::System.Windows.Forms.ToolStripButton StateDetection_Button;

		private global::System.Windows.Forms.ToolStrip toolStrip;

		private global::System.Windows.Forms.StatusStrip statusStrip1;

		private global::System.Windows.Forms.ToolStripStatusLabel TextStatus;

		private global::System.Windows.Forms.ToolStripButton SetUPButton;

		private global::System.Windows.Forms.ToolStripMenuItem CopyPwd_MenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem Copy_MenuItem;

		private global::System.Windows.Forms.ToolStripMenuItem CopyUserName_MenuItem;

		private global::System.Windows.Forms.ToolStripStatusLabel OperationStateLabel;

		private global::System.Windows.Forms.Timer DeleteStateTime;

		private global::System.Windows.Forms.ToolStripButton RemarksButton;

		private global::System.Windows.Forms.ToolStripMenuItem CopyServer_MenuItem;

		private global::System.Windows.Forms.DataGridView HostDataGridView;

		private global::System.Windows.Forms.ComboBox GroupingComboBox;

		private global::System.Windows.Forms.Label label12;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnSortNumber;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnServerName;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnServer;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrouping;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemoteType;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnPort;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnColorDepth;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesktopWidth;

		private global::System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesktopHeight;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox Search_Text;

		private global::System.Windows.Forms.Button Search_Button;

		private global::System.Windows.Forms.ToolStripMenuItem Menu_BatchGrouping;

		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator_BatchGrouping;
	}
}
