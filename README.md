# 远程桌面管理工具（MstscManage）

基于 .NET Framework 4.8 的 Windows 窗体应用程序，用于管理并批量连接远程桌面（RDP）主机。支持使用系统自带MSTSC和内置远程方式,同时支持右键tvnviewer连接

<img width="726" height="579" alt="Snipaste_2026-10-25_14-06-12" src="https://github.com/user-attachments/assets/9232eab9-2bdb-4400-a59c-aff4776b1ab8" />


## 目录结构

```text
远程桌面管理工具/
├─ MstscManage.sln            # 解决方案文件（可用 Visual Studio 打开）
├─ README.md                  # 本说明文件
├─ reference/                 # 参考存档（不参与编译）
│  └─ MSTSCLib.Interfaces.cs  # 远程桌面 COM 接口定义（由 16 个碎片合并）
└─ src/                       # 项目根目录
   ├─ MstscManage.csproj      # 工程文件（x86 平台，输出 WinExe）
   ├─ app.manifest            # 应用程序清单
   ├─ app.config              # 运行时配置（程序集绑定重定向）
   ├─ build.bat               # 一键编译脚本（Release 版）
   ├─ MstscManage.ico         # 应用程序图标
   ├─ Program.cs              # 程序入口（互斥体保证单实例运行）
   ├─ Config.cs               # INI 配置读写（程序全局设置）
   ├─ Delegates.cs            # 全部事件委托定义（由 11 个碎片文件合并）
   ├─ APIs.cs                 # Win32 API 声明（窗口查找、截图消息等）
   ├─ NativeMethods.cs        # Win32 API 声明（窗口消息广播）
   ├─ ControlToImage.cs       # 控件截图工具类
   ├─ TextboxRequiredWrapper.cs # 文本框“必填字段”提示包装类
   ├─ IniHelp.cs              # INI 文件读写帮助类
   ├─ RDPFile.cs              # RDP 连接文件解析与生成
   ├─ DES.cs / Rijndael.cs    # 加密算法（配置密码加密）
   ├─ DataProtector.cs        # Windows DPAPI 数据保护
   ├─ DataProtectionForRDPWrapper.cs # DPAPI 封装（用于 RDP 密码）
   ├─ Forms/                  # 全部窗体（代码 + 设计器 + 资源）
   ├─ Class_Modules/          # 通用模型（颜色值模型）
   ├─ Database/               # 数据绑定集合、对象属性比较器
   ├─ Helper/                 # 主机实体、SQLite 数据访问、端口探测
   ├─ MSTSCLib/               # 远程桌面 COM 接口声明
   ├─ AxMSTSCLib/             # 远程桌面 ActiveX 控件包装
   ├─ System/                 # Fish 系列扩展方法（数组、集合、日期、字符串等）
   │  └─ FishExtension/       # 注解特性（由 32 个碎片合并为 Annotations.cs）
   ├─ NPinyin/                # 汉字转拼音
   ├─ Properties/             # 程序集信息、强类型资源
   └─ libs/
      └─ System.Data.SQLite.dll   # SQLite 数据库驱动（混合模式程序集，内嵌原生 SQLite 引擎）
```


## 编译方法

### 方式一：命令行一键编译

双击目录下的 `build.bat`，或在命令行执行：

```bat
build.bat
```


## 环境要求

- 操作系统：Windows（需支持远程桌面 ActiveX 控件，即系统自带 mstscax.dll）
- .NET Framework 4.8 运行时
- 编译平台必须为 **x86**（远程桌面 ActiveX 控件为 32 位 COM 组件）
- 无需安装 NuGet 包，所有依赖 DLL 均在 `src\libs\` 目录中
- 右键tvnviewer连接,可自行准备tvnviewer.exe放入同目录下,编译文件已经附带
