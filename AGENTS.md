# AGENTS.md — MstscManage（远程桌面管理工具）

## 项目概述

.NET Framework 4.8 WinForms 桌面应用（仅 x86），用于管理和批量连接 RDP / VNC 远程主机。
代码由反编译碎片合并重建（见 README.md 的"碎片合并"说明），整体保留反编译器输出风格。

## 构建命令

- 无 NuGet 包、无测试、无 lint。唯一依赖 `src/libs/System.Data.SQLite.dll`（x86 混合模式程序集）。
- Release 编译（在 `src/` 目录下执行）：

  ```
  C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe MstscManage.csproj /p:Configuration=Release
  ```

- `src/build_exe.bat` 就是这条命令，但末尾有 `pause`，只适合双击运行，Agent 请直接调 MSBuild；日志写到 `src/build_msbuild.log`。
- 输出：`src/bin/Release/MstscManage.exe`（Debug 为 `src/bin/Debug/`）。
- README 里写的 `build.bat` 实际文件名是 `src/build_exe.bat`。

## 硬性约束

- **平台必须 x86**：RDP ActiveX 控件（系统 mstscax.dll）是 32 位 COM 组件，SQLite 驱动也是 x86。sln 已把 Any CPU / Mixed Platforms 全部映射到 x86。
- **旧式 csproj（非 SDK 风格）**：新增 .cs 文件必须手动加入 `src/MstscManage.csproj` 的 `<Compile>` 列表，否则不会编译。
- **文件编码为 UTF-8 with BOM**，代码含大量中文注释和 UI 字符串，新文件保持同样编码，避免 MSBuild 编译乱码。

## 目录与分层

- `src/Forms/` — 全部窗体，业务逻辑多写在窗体代码后置（MainForm 为主窗口，ClientMain 为 RDP 连接窗口）。
- `src/Helper/` — `HostServers` 实体、`HostServersDal`（继承 `SQLiteHelper` 的数据访问，SQL 为字符串拼接风格）、`TimeOutSocket` 端口探测。
- `src/Database/` — `BindingCollection` / `ObjectPropertyCompare`，供 UI 绑定与排序。
- `src/System/` — Fish* 系列扩展方法（`ToInt32ByDBNull`、`ToBooleanNullable` 等），数据库取值转换统一走这些扩展。
- `src/MSTSCLib/` 与 `src/AxMSTSCLib/` — 手工维护的 RDP COM interop 声明；改动前先读 `reference/MSTSCLib.Interfaces.cs`（接口合并存档，在 csproj 中为 `<None>`，不参与编译）。
- `src/NPinyin/` — 汉字转拼音。`reference/` — 参考存档，不参与编译。

## 运行时数据（均位于 exe 同目录，`Application.StartupPath`）

- `MstscManage.db` — SQLite 主库，缺失或文件头损坏时由 `EnsureDatabaseExists` 自动重建。
- `Config.ini` — 全局设置（`IniHelp` / `Config`）。
- `tvnviewer.exe` — TightVNC 客户端；VNC 类型连接（`RemoteType`）要求它放在 exe 同目录，缺失时弹窗提示。
- `src/bin/Release/` 下的 db 和 ini 是活数据，不要随手删除。

## WinForms 设计器注意事项

- 窗体**没有 .resx 源文件**；csproj 直接嵌入预编译的二进制 `.resources`（`<LogicalName>MstscManage.<窗体名>.resources</LogicalName>`）。
- 用 VS 设计器改窗体可能生成 .resx 并破坏现有资源流——建议直接编辑 `.Designer.cs` 代码。新增窗体需提供对应 `.resources` 并加入 csproj 的 `EmbeddedResource`。

## 代码风格与已知机制

- 反编译器输出风格（`bool flag = ...; if (flag)`、`global::` 前缀、显式写出可选参数）——保持一致，不要大规模重排或"净化"。
- 注释与 UI 文本为中文。
- 单实例：`Program.cs` 用命名 Mutex 保证；二次启动通过 `NativeMethods.PostMessage(HWND_BROADCAST, WM_SHOWME)` 唤醒已有窗口。
- 密码加密：`DES.cs` / `Rijndael.cs` / DPAPI（`DataProtector.cs`、`DataProtectionForRDPWrapper.cs`）。
- 改动前先读 `README.md`；改 COM interop 前先读 `reference/MSTSCLib.Interfaces.cs`。
