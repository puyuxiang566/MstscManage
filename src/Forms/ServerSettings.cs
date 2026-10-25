using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MstscManage.Class_Modules;
using MstscManage.Database;
using MstscManage.Helper;
using MstscManage.Properties;

namespace MstscManage
{
	public partial class ServerSettings : Form
	{
		public ServerSettings(ref BindingCollection<HostServers> hostInformation)
		{
			this.InitializeComponent();
			this.InitializeControlCurrency();
			this.InitializeControls();
			this.HostInformation = hostInformation;
		}

		public ServerSettings(ref HostServers sd)
		{
			this.InitializeComponent();
			this.InitializeControlCurrency();
			this.InitializeControls(ref sd);
		}

		public void InitializeControls()
		{
			this.CheckText.AddRange(new Control[]
			{
				this.txServername,
				this.txComputer,
				this.txUsername,
				this.GroupingComboBox
			});
			this.tbDeskSize.Value = 4;
			this.tbDeskSize_Scroll(this.tbDeskSize, null);
			this.tbColor.SelectedIndex = this.tbColor.Items.Count - 1;
			this.isUpdating = false;
		}

		public void LoadColorList()
		{
			List<ColorValueModel> ColorValue = new ColorValueModel().GetColorValue();
			this.tbColor.DisplayMember = "Name";
			this.tbColor.ValueMember = "Value";
			this.tbColor.DataSource = ColorValue;
			string[] GroupingItem = Config.GetConfig().GroupingItem.Split(new char[]
			{
				','
			});
			ComboBox.ObjectCollection items = this.GroupingComboBox.Items;
			object[] items2 = GroupingItem;
			items.AddRange(items2);
			this.GroupingComboBox.SelectedIndex = 0;
		}

		public void InitializeControls(ref HostServers Model)
		{
			this.CurrDetails = Model;
			TextboxRequiredWrapper checkText = this.CheckText;
			Control[] textbox = new TextBox[]
			{
				this.txServername,
				this.txComputer,
				this.txUsername
			};
			checkText.AddRange(textbox);
			this.txServername.Text = Model.ServerName;
			this.txComputer.Text = Model.Server;
			this.txUsername.Text = Model.Username;
			this.txPassword.Text = Model.Password;
			this.txDescription.Text = Model.Description;
			this.tbColor.SelectedValue = Model.ColorDepth;
			this.textOrder.Text = Model.SortNumber.ToString();
			bool flag = Model.DesktopWidth == 640 && Model.DesktopHeight == 480;
			if (flag)
			{
				this.tbDeskSize.Value = 1;
			}
			else
			{
				bool flag2 = Model.DesktopWidth == 800 && Model.DesktopHeight == 600;
				if (flag2)
				{
					this.tbDeskSize.Value = 2;
				}
				else
				{
					bool flag3 = Model.DesktopWidth == 1024 && Model.DesktopHeight == 768;
					if (flag3)
					{
						this.tbDeskSize.Value = 3;
					}
					else
					{
						bool flag4 = Model.DesktopWidth == 1120 && Model.DesktopHeight == 700;
						if (flag4)
						{
							this.tbDeskSize.Value = 4;
						}
						else
						{
							bool flag5 = Model.DesktopWidth == 1152 && Model.DesktopHeight == 864;
							if (flag5)
							{
								this.tbDeskSize.Value = 5;
							}
							else
							{
								bool flag6 = Model.DesktopWidth == 1280 && Model.DesktopHeight == 800;
								if (flag6)
								{
									this.tbDeskSize.Value = 6;
								}
								else
								{
									bool flag7 = Model.DesktopWidth == 1280 && Model.DesktopHeight == 1024;
									if (flag7)
									{
										this.tbDeskSize.Value = 7;
									}
									else
									{
										bool flag8 = Model.DesktopWidth == 1336 && Model.DesktopHeight == 768;
										if (flag8)
										{
											this.tbDeskSize.Value = 8;
										}
										else
										{
											bool flag9 = Model.DesktopWidth == 1440 && Model.DesktopHeight == 900;
											if (flag9)
											{
												this.tbDeskSize.Value = 9;
											}
											else
											{
												bool flag10 = Model.DesktopWidth == 1440 && Model.DesktopHeight == 1050;
												if (flag10)
												{
													this.tbDeskSize.Value = 10;
												}
												else
												{
													bool flag11 = Model.DesktopWidth == 1680 && Model.DesktopHeight == 1050;
													if (flag11)
													{
														this.tbDeskSize.Value = 11;
													}
													else
													{
														bool flag12 = Model.DesktopWidth == 1920 && Model.DesktopHeight == 1080;
														if (flag12)
														{
															this.tbDeskSize.Value = 12;
														}
														else
														{
															this.tbDeskSize.Value = 13;
															this.Fullscreen = Model.Fullscreen;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			this.txWidth.Text = Model.DesktopWidth.ToString();
			this.txHeight.Text = Model.DesktopHeight.ToString();
			this.GroupingComboBox.SelectedItem = Model.Grouping;
			this.isUpdating = true;
		}

		public void InitializeControlCurrency()
		{
			this.LoadColorList();
			this.tbDeskSize.Scroll += this.tbDeskSize_Scroll;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.CheckText.isAllFieldSet();
			if (flag)
			{
				MessageBox.Show("请填写完整的配置信息！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				this.CurrDetails.ServerName = this.txServername.Text;
				this.CurrDetails.Server = this.txComputer.Text;
				this.CurrDetails.Username = this.txUsername.Text;
				this.CurrDetails.Password = this.txPassword.Text;
				this.CurrDetails.Description = this.txDescription.Text;
				this.CurrDetails.ColorDepth = int.Parse(this.tbColor.SelectedValue.ToString());
				this.CurrDetails.DesktopWidth = int.Parse(this.txWidth.Text);
				this.CurrDetails.DesktopHeight = int.Parse(this.txHeight.Text);
				this.CurrDetails.Fullscreen = this.Fullscreen;
				this.CurrDetails.Grouping = this.GroupingComboBox.SelectedItem.ToString();
				this.CurrDetails.SortNumber = this.textOrder.Text.ToInt32(0, NumberStyles.Any, null);
				try
				{
					bool flag2 = this.isUpdating;
					if (flag2)
					{
						this.HostDal.Update(this.CurrDetails);
						base.Close();
					}
					else
					{
						this.CurrDetails.SortNumber = this.HostDal.GetMaxSortNumber();
						this.CurrDetails.RemoteType = "网络主机";
						this.HostDal.Save(this.CurrDetails);
						this.HostInformation.Add(this.CurrDetails);
						MessageBox.Show("添加主机成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						base.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("添加主机失败,错误信息：" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private void tbDeskSize_Scroll(object sender, EventArgs e)
		{
			switch (this.tbDeskSize.Value)
			{
			case 1:
				this.txWidth.Text = "640";
				this.txHeight.Text = "480";
				break;
			case 2:
				this.txWidth.Text = "800";
				this.txHeight.Text = "600";
				break;
			case 3:
				this.txWidth.Text = "1024";
				this.txHeight.Text = "768";
				break;
			case 4:
				this.txWidth.Text = "1120";
				this.txHeight.Text = "700";
				break;
			case 5:
				this.txWidth.Text = "1152";
				this.txHeight.Text = "864";
				break;
			case 6:
				this.txWidth.Text = "1280";
				this.txHeight.Text = "800";
				break;
			case 7:
				this.txWidth.Text = "1280";
				this.txHeight.Text = "1024";
				break;
			case 8:
				this.txWidth.Text = "1336";
				this.txHeight.Text = "768";
				break;
			case 9:
				this.txWidth.Text = "1440";
				this.txHeight.Text = "900";
				break;
			case 10:
				this.txWidth.Text = "1440";
				this.txHeight.Text = "1050";
				break;
			case 11:
				this.txWidth.Text = "1680";
				this.txHeight.Text = "1050";
				break;
			case 12:
				this.txWidth.Text = "1920";
				this.txHeight.Text = "1080";
				break;
			default:
			{
				Rectangle r = this.GetClientWindowSize();
				this.txWidth.Text = r.Width.ToString();
				this.txHeight.Text = r.Height.ToString();
				this.Fullscreen = true;
				break;
			}
			}
		}

		private Rectangle GetClientWindowSize()
		{
			int DesktopWidth = Screen.PrimaryScreen.Bounds.Height;
			int DesktopHeight = Screen.PrimaryScreen.Bounds.Width;
			return new Rectangle(0, 0, DesktopWidth, DesktopHeight);
		}

		private void ServerSettings_Load(object sender, EventArgs e)
		{
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			RandomPassword RadForm = new RandomPassword();
			RadForm.ShowDialog();
			this.txPassword.Text = RadForm.PasswordTxt.Text;
		}

		private HostServersDal HostDal = new HostServersDal();

		private TextboxRequiredWrapper CheckText = new TextboxRequiredWrapper();

		private HostServers CurrDetails = new HostServers();

		private bool isUpdating = false;

		private bool Fullscreen = false;

		private BindingCollection<HostServers> HostInformation;
	}
}
