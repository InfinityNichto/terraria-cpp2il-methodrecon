using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using InControl.UnityDeviceProfiles;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005D RID: 93
	public class UnityInputDeviceManager : InputDeviceManager
	{
		// Token: 0x06000449 RID: 1097 RVA: 0x0000E258 File Offset: 0x0000C458
		public UnityInputDeviceManager()
		{
			if (!true)
			{
			}
			this.AddSystemDeviceProfiles();
			bool flag = Directory.Exists(UnityInputDeviceManager.CustomProfileFolder);
			DirectoryInfo directoryInfo = Directory.CreateDirectory(UnityInputDeviceManager.CustomProfileFolder);
			string customProfileFolder = UnityInputDeviceManager.CustomProfileFolder;
			this.LoadDeviceProfilesFromPath(customProfileFolder);
			this.QueryJoystickInfo();
			this.AttachDevices();
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		public override void Update(ulong updateTick, float deltaTime)
		{
			float num = this.deviceRefreshTimer;
			this.deviceRefreshTimer = num;
			this.QueryJoystickInfo();
			int num2 = this.joystickHash;
			int num3 = this.lastJoystickHash;
			int num4 = this.joystickCount;
			int num5 = this.lastJoystickCount;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		private void QueryJoystickInfo()
		{
			string[] array = Input.GetJoystickNames();
			this.joystickNames = array;
			int num = this.joystickCount;
			string[] array2 = this.joystickNames;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000E328 File Offset: 0x0000C528
		private bool JoystickInfoHasChanged
		{
			get
			{
				int num = this.joystickHash;
				int num2 = this.lastJoystickHash;
				int num3 = this.joystickCount;
				int num4 = this.lastJoystickCount;
				return true;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000E354 File Offset: 0x0000C554
		private void AttachDevices()
		{
			string[] array = this.joystickNames;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000025E1 File Offset: 0x000007E1
		private void DetachDevices()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000E38C File Offset: 0x0000C58C
		public void ReloadDevices()
		{
			this.QueryJoystickInfo();
			this.DetachDevices();
			this.AttachDevices();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000025E1 File Offset: 0x000007E1
		private void AttachDevice(UnityInputDevice device)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000E3AC File Offset: 0x0000C5AC
		private bool HasAttachedDeviceWithJoystickId(int unityJoystickId)
		{
			/*
An exception occurred when decompiling this method (06000451)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.UnityInputDeviceManager::HasAttachedDeviceWithJoystickId(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class InControl.InputDevice>(var_3_19, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.InputDevice>(InputDeviceManager::devices, ldloc:UnityInputDeviceManager[exp:InputDeviceManager](this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000E3D8 File Offset: 0x0000C5D8
		private void DetectJoystickDevice(int unityJoystickId, string unityJoystickName)
		{
			bool flag = this.HasAttachedDeviceWithJoystickId(unityJoystickId);
			int num = unityJoystickName.IndexOf("webcam", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		private InputDeviceProfile DetectDevice(string unityJoystickName)
		{
			/*
An exception occurred when decompiling this method (06000453)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.InputDeviceProfile InControl.UnityInputDeviceManager::DetectDevice(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0018:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class InControl.InputDeviceProfile>(var_0_1E, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.InputDeviceProfile>(UnityInputDeviceManager::systemDeviceProfiles, ldloc:UnityInputDeviceManager(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000025E1 File Offset: 0x000007E1
		private void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		private void AddSystemDeviceProfiles()
		{
			if (!true)
			{
			}
			InputDeviceProfile inputDeviceProfile;
			this.AddSystemDeviceProfile(inputDeviceProfile);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000025E1 File Offset: 0x000007E1
		public void AddDeviceProfile(CustomInputDeviceProfile deviceProfile)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000E608 File Offset: 0x0000C808
		public void LoadDeviceProfiles()
		{
			string customProfileFolder = UnityInputDeviceManager.CustomProfileFolder;
			this.LoadDeviceProfilesFromPath(customProfileFolder);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000E624 File Offset: 0x0000C824
		public void LoadDeviceProfile(string data)
		{
			CustomInputDeviceProfile customInputDeviceProfile = CustomInputDeviceProfile.Load(data);
			this.AddDeviceProfile(customInputDeviceProfile);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000E640 File Offset: 0x0000C840
		public void LoadDeviceProfileFromFile(string filePath)
		{
			CustomInputDeviceProfile customInputDeviceProfile = CustomInputDeviceProfile.LoadFromFile(filePath);
			this.AddDeviceProfile(customInputDeviceProfile);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000E65C File Offset: 0x0000C85C
		public void LoadDeviceProfilesFromPath(string rootPath)
		{
			bool flag = Directory.Exists(rootPath);
			string[] array;
			CustomInputDeviceProfile customInputDeviceProfile = CustomInputDeviceProfile.LoadFromFile(array);
			this.AddDeviceProfile(customInputDeviceProfile);
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000E680 File Offset: 0x0000C880
		public static string SavePath
		{
			get
			{
				if (Application.persistentDataPath._stringLength == 0)
				{
					Debug.Log("SetupPaths: Unity path is empty.  Trying native method...");
					return;
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000E6A4 File Offset: 0x0000C8A4
		public static string CustomProfileFolder
		{
			get
			{
				return UnityInputDeviceManager.SavePath + "/ControllerProfiles";
			}
		}

		// Token: 0x040003D4 RID: 980
		private const float deviceRefreshInterval = 1f;

		// Token: 0x040003D5 RID: 981
		private float deviceRefreshTimer;

		// Token: 0x040003D6 RID: 982
		private readonly List<InputDeviceProfile> systemDeviceProfiles;

		// Token: 0x040003D7 RID: 983
		private readonly List<InputDeviceProfile> customDeviceProfiles;

		// Token: 0x040003D8 RID: 984
		private string[] joystickNames;

		// Token: 0x040003D9 RID: 985
		private int lastJoystickCount;

		// Token: 0x040003DA RID: 986
		private int lastJoystickHash;

		// Token: 0x040003DB RID: 987
		private int joystickCount;

		// Token: 0x040003DC RID: 988
		private int joystickHash;

		// Token: 0x040003DD RID: 989
		public static string _savePath;

		// Token: 0x0200005E RID: 94
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x0600045D RID: 1117 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
			internal bool <DetectDevice>b__0(InputDeviceProfile profile)
			{
				string serialNumber = this.deviceInfo.serialNumber;
				string name = this.deviceInfo.name;
				bool flag;
				return flag;
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x0000E6FC File Offset: 0x0000C8FC
			internal bool <DetectDevice>b__1(InputDeviceProfile profile)
			{
				string serialNumber = this.deviceInfo.serialNumber;
				string name = this.deviceInfo.name;
				bool flag;
				return flag;
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x0000E724 File Offset: 0x0000C924
			internal bool <DetectDevice>b__2(InputDeviceProfile profile)
			{
				string serialNumber = this.deviceInfo.serialNumber;
				string name = this.deviceInfo.name;
				bool flag;
				return flag;
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x0000E74C File Offset: 0x0000C94C
			internal bool <DetectDevice>b__3(InputDeviceProfile profile)
			{
				string serialNumber = this.deviceInfo.serialNumber;
				string name = this.deviceInfo.name;
				bool flag;
				return flag;
			}

			// Token: 0x040003DE RID: 990
			public InputDeviceInfo deviceInfo;
		}
	}
}
