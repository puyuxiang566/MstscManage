// 本文件由反编译碎片合并生成，包含以下原始文件的全部类型定义：
//   - IMsRdpClientAdvancedSettings.cs
//   - IMsRdpClientAdvancedSettings2.cs
//   - IMsRdpClientAdvancedSettings3.cs
//   - IMsRdpClientAdvancedSettings4.cs
//   - IMsRdpClientAdvancedSettings5.cs
//   - IMsRdpClientAdvancedSettings6.cs
//   - IMsRdpClientAdvancedSettings7.cs
//   - IMsRdpClientNonScriptable.cs
//   - IMsRdpClientNonScriptable2.cs
//   - IMsRdpClientNonScriptable3.cs
//   - IMsRdpClientNonScriptable4.cs
//   - IMsRdpClientNonScriptable5.cs
//   - IMsRdpDrive.cs
//   - IMsRdpDriveCollection.cs
//   - IMsTscAdvancedSettings.cs
//   - IMsTscNonScriptable.cs

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace MSTSCLib
{
	[CompilerGenerated]
	[Guid("3C65B4AB-12B3-465B-ACD4-B8DAD3BFF9E2")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings : IMsTscAdvancedSettings
	{
		void _VtblGap1_4();

		[DispId(161)]
		int allowBackgroundInput { [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(161)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		void _VtblGap2_22();

		[DispId(108)]
		int RDPPort { [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(108)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		void _VtblGap3_75();

		[DispId(186)]
		string ClearTextPassword { [DispId(186)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}

	[CompilerGenerated]
	[Guid("9AC42117-2B76-4320-AA44-0E616AB8437B")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings2 : IMsRdpClientAdvancedSettings
	{
	}

	[CompilerGenerated]
	[Guid("19CD856B-C542-4C53-ACEE-F127E3BE1A59")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings3 : IMsRdpClientAdvancedSettings2
	{
	}

	[CompilerGenerated]
	[Guid("FBA7F64E-7345-4405-AE50-FA4A763DC0DE")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings4 : IMsRdpClientAdvancedSettings3
	{
	}

	[CompilerGenerated]
	[Guid("FBA7F64E-6783-4405-DA45-FA4A763DABD0")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings5 : IMsRdpClientAdvancedSettings4
	{
	}

	[CompilerGenerated]
	[Guid("222C4B5D-45D9-4DF0-A7C6-60CF9089D285")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings6 : IMsRdpClientAdvancedSettings5
	{
	}

	[CompilerGenerated]
	[Guid("26036036-4010-4578-8091-0DB9A1EDF9C3")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientAdvancedSettings7 : IMsRdpClientAdvancedSettings6
	{
		void _VtblGap1_140();

		[DispId(212)]
		uint AuthenticationLevel { [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(212)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}

	[CompilerGenerated]
	[InterfaceType(1)]
	[Guid("2F079C4C-87B2-4AFD-97AB-20CDB43038AE")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientNonScriptable : IMsTscNonScriptable
	{
	}

	[CompilerGenerated]
	[Guid("17A5E535-4072-4FA4-AF32-C8D0D47345E9")]
	[InterfaceType(1)]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientNonScriptable2 : IMsRdpClientNonScriptable
	{
	}

	[CompilerGenerated]
	[InterfaceType(1)]
	[Guid("B3378D90-0728-45C7-8ED7-B6159FB92219")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientNonScriptable3 : IMsRdpClientNonScriptable2
	{
	}

	[CompilerGenerated]
	[InterfaceType(1)]
	[Guid("F50FA8AA-1C7D-4F59-B15C-A90CACAE1FCB")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientNonScriptable4 : IMsRdpClientNonScriptable3
	{
	}

	[CompilerGenerated]
	[InterfaceType(1)]
	[Guid("4F6996D5-D7B1-412C-B0FF-063718566907")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpClientNonScriptable5 : IMsRdpClientNonScriptable4
	{
		void _VtblGap1_27();

		[DispId(19)]
		IMsRdpDriveCollection DriveCollection { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }
	}

	[CompilerGenerated]
	[InterfaceType(1)]
	[Guid("D28B5458-F694-47A8-8E61-40356A767E46")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpDrive
	{
		[DispId(229)]
		string Name { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		[DispId(230)]
		bool RedirectionState { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }
	}

	[CompilerGenerated]
	[Guid("7FF17599-DA2C-4677-AD35-F60C04FE1585")]
	[InterfaceType(1)]
	[TypeIdentifier]
	[ComImport]
	public interface IMsRdpDriveCollection
	{
		void _VtblGap1_1();

		[DispId(231)]
		IMsRdpDrive this[uint index] { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		[DispId(233)]
		uint DriveCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}

	[CompilerGenerated]
	[Guid("809945CC-4B3B-4A92-A6B0-DBF9B5F2EF2D")]
	[TypeIdentifier]
	[ComImport]
	public interface IMsTscAdvancedSettings
	{
	}

	[CompilerGenerated]
	[Guid("C1E6743A-41C1-4A74-832A-0DD06C1C7A0E")]
	[InterfaceType(1)]
	[TypeIdentifier]
	[ComImport]
	public interface IMsTscNonScriptable
	{
	}

}
