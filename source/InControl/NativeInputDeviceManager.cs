using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200003E RID: 62
	public class NativeInputDeviceManager : InputDeviceManager
	{
		// Token: 0x06000344 RID: 836 RVA: 0x00009BC4 File Offset: 0x00007DC4
		public NativeInputDeviceManager()
		{
			if (!true)
			{
			}
			this.AddSystemDeviceProfiles();
			if (!true)
			{
			}
			if (true || !true)
			{
			}
			if (true || !true)
			{
			}
			if (true || !true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			float fixedDeltaTime = Time.fixedDeltaTime;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00009C08 File Offset: 0x00007E08
		public override void Destroy()
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00009C18 File Offset: 0x00007E18
		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00009C28 File Offset: 0x00007E28
		private void DetectDevice(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
			string serialNumber = deviceInfo.serialNumber;
			if (this.customDeviceProfiles == null && this.systemDeviceProfiles == null && this.customDeviceProfiles == null)
			{
				List<InputDeviceProfile> list = this.systemDeviceProfiles;
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000025E1 File Offset: 0x000007E1
		private void AttachDevice(NativeInputDevice device)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000025E1 File Offset: 0x000007E1
		private void DetachDevice(NativeInputDevice device)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00009C60 File Offset: 0x00007E60
		private NativeInputDevice FindAttachedDevice(uint deviceHandle)
		{
			/*
An exception occurred when decompiling this method (0600034A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling InControl.NativeInputDevice InControl.NativeInputDeviceManager::FindAttachedDevice(System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_0D, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.NativeInputDevice>[exp:List`1](NativeInputDeviceManager::attachedDevices, ldloc:NativeInputDeviceManager(this))))
	stloc:class [mscorlib]System.Collections.Generic.List`1<class InControl.NativeInputDevice>(var_2_14, ldfld:class [mscorlib]System.Collections.Generic.List`1<class InControl.NativeInputDevice>(NativeInputDeviceManager::attachedDevices, ldloc:NativeInputDeviceManager(this)))
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

		// Token: 0x0600034B RID: 843 RVA: 0x00009C84 File Offset: 0x00007E84
		private NativeInputDevice FindDetachedDevice(InputDeviceInfo deviceInfo)
		{
			List<NativeInputDevice> list = this.detachedDevices;
			string serialNumber = deviceInfo.serialNumber;
			string serialNumber2 = deviceInfo.serialNumber;
			NativeInputDevice nativeInputDevice;
			return nativeInputDevice;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00009CA8 File Offset: 0x00007EA8
		private static NativeInputDevice SystemFindDetachedDevice(InputDeviceInfo deviceInfo, ReadOnlyCollection<NativeInputDevice> detachedDevices)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000025E1 File Offset: 0x000007E1
		private void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00009CC4 File Offset: 0x00007EC4
		private void AddSystemDeviceProfiles()
		{
			if (!true)
			{
			}
			InputDeviceProfile inputDeviceProfile;
			this.AddSystemDeviceProfile(inputDeviceProfile);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00009CE0 File Offset: 0x00007EE0
		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			RuntimePlatform platform = Application.platform;
			if (Application.platform != RuntimePlatform.OSXEditor)
			{
				RuntimePlatform platform2 = Application.platform;
				RuntimePlatform platform3 = Application.platform;
				RuntimePlatform platform4 = Application.platform;
			}
			if ("InControl Native (version " == null || "InControl Native (version " != null)
			{
				string text;
				if (text != null && text == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if ("." != null && "." == null)
				{
					throw new ArrayTypeMismatchException();
				}
				string text2;
				if (text2 != null && text2 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if ("." != null && "." == null)
				{
					throw new ArrayTypeMismatchException();
				}
				string text3;
				if (text3 != null && text3 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (")" != null && ")" == null)
				{
					throw new ArrayTypeMismatchException();
				}
				string text4;
				Logger.LogInfo(text4);
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00009DB8 File Offset: 0x00007FB8
		internal static bool Enable()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				Type type;
				InputManager.HideDevicesWithProfile(type);
				Type type2;
				InputManager.HideDevicesWithProfile(type2);
				Type type3;
				InputManager.HideDevicesWithProfile(type3);
				Type type4;
				InputManager.HideDevicesWithProfile(type4);
			}
			InputManager.AddDeviceManager();
			return true;
		}

		// Token: 0x040002DA RID: 730
		public static Func<InputDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice> CustomFindDetachedDevice;

		// Token: 0x040002DB RID: 731
		private readonly List<NativeInputDevice> attachedDevices;

		// Token: 0x040002DC RID: 732
		private readonly List<NativeInputDevice> detachedDevices;

		// Token: 0x040002DD RID: 733
		private readonly List<InputDeviceProfile> systemDeviceProfiles;

		// Token: 0x040002DE RID: 734
		private readonly List<InputDeviceProfile> customDeviceProfiles;

		// Token: 0x040002DF RID: 735
		private uint[] deviceEvents;

		// Token: 0x0200003F RID: 63
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06000351 RID: 849 RVA: 0x00009E08 File Offset: 0x00008008
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06000352 RID: 850 RVA: 0x00009E1C File Offset: 0x0000801C
			internal bool <DetectDevice>b__0(InputDeviceProfile profile)
			{
				string serialNumber = this.deviceInfo.serialNumber;
				string name = this.deviceInfo.name;
				InputDeviceMatcher[] matchers = profile.matchers;
				bool flag;
				return flag;
			}

			// Token: 0x06000353 RID: 851 RVA: 0x00009E4C File Offset: 0x0000804C
			internal bool <DetectDevice>b__1(InputDeviceProfile profile)
			{
				string serialNumber = this.deviceInfo.serialNumber;
				string name = this.deviceInfo.name;
				InputDeviceMatcher[] matchers = profile.matchers;
				bool flag;
				return flag;
			}

			// Token: 0x06000354 RID: 852 RVA: 0x00009E7C File Offset: 0x0000807C
			internal bool <DetectDevice>b__2(InputDeviceProfile profile)
			{
				string serialNumber = this.deviceInfo.serialNumber;
				string name = this.deviceInfo.name;
				InputDeviceMatcher[] lastResortMatchers = profile.lastResortMatchers;
				bool flag;
				return flag;
			}

			// Token: 0x06000355 RID: 853 RVA: 0x00009EAC File Offset: 0x000080AC
			internal bool <DetectDevice>b__3(InputDeviceProfile profile)
			{
				string serialNumber = this.deviceInfo.serialNumber;
				string name = this.deviceInfo.name;
				InputDeviceMatcher[] lastResortMatchers = profile.lastResortMatchers;
				bool flag;
				return flag;
			}

			// Token: 0x040002E0 RID: 736
			public InputDeviceInfo deviceInfo;
		}
	}
}
