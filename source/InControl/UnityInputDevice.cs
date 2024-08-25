using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005C RID: 92
	public class UnityInputDevice : InputDevice
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
		public int JoystickId
		{
			[CompilerGenerated]
			get
			{
				return this.<JoystickId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<JoystickId>k__BackingField = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		public InputDeviceProfile Profile
		{
			get
			{
				return this.profile;
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000DD0C File Offset: 0x0000BF0C
		public UnityInputDevice(int joystickId, string joystickName)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		public void RefreshProfile()
		{
			base.ClearControls();
			InputDeviceProfile inputDeviceProfile = this.profile;
			InputDeviceClass deviceClass = inputDeviceProfile.deviceClass;
			bool invert = inputDeviceProfile.analogMappings.invert;
			string deviceNotes = inputDeviceProfile.deviceNotes;
			if (inputDeviceProfile == null)
			{
			}
			string text;
			string text2;
			if (("Cannot map control \"" == null || "Cannot map control \"" != null) && (text == null || text != null) && ("\" as InputControlType." == null || "\" as InputControlType." != null) && (text2 == null || text2 != null) && (" in profile \"" == null || " in profile \"" != null))
			{
				string deviceName = this.profile.deviceName;
				if ((deviceName == null || deviceName != null) && ("\" because this target is reserved as an alias. The mapping will be ignored." == null || "\" because this target is reserved as an alias. The mapping will be ignored." != null))
				{
					string text3;
					Debug.LogError(text3);
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		public UnityInputDevice(InputDeviceProfile deviceProfile, int joystickId, string joystickName)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			this.profile = deviceProfile;
			this.JoystickId = joystickId;
			if (joystickId != 0)
			{
				if (num == 0)
				{
				}
				this.<SortOrder>k__BackingField = num;
			}
			UnityInputDevice.SetupAnalogQueries();
			UnityInputDevice.SetupButtonQueries();
			if (num == 0)
			{
			}
			string deviceName = this.profile.deviceName;
			InputDeviceProfile inputDeviceProfile = this.profile;
			this.<Name>k__BackingField = deviceName;
			string deviceNotes = inputDeviceProfile.deviceNotes;
			this.<Meta>k__BackingField = deviceNotes;
			InputDeviceClass deviceClass = inputDeviceProfile.deviceClass;
			bool invert = inputDeviceProfile.analogMappings.invert;
			string deviceNotes2 = inputDeviceProfile.deviceNotes;
			if (inputDeviceProfile == null)
			{
			}
			string text;
			string text2;
			if (("Cannot map control \"" == null || "Cannot map control \"" != null) && (text == null || text != null) && ("\" as InputControlType." == null || "\" as InputControlType." != null) && (text2 == null || text2 != null) && (" in profile \"" == null || " in profile \"" != null))
			{
				string deviceName2 = deviceProfile.deviceName;
				if ((deviceName2 == null || deviceName2 != null) && ("\" because this target is reserved as an alias. The mapping will be ignored." == null || "\" because this target is reserved as an alias. The mapping will be ignored." != null))
				{
					string text3;
					Debug.LogError(text3);
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		public override void Update(ulong updateTick, float deltaTime)
		{
			InputControlMapping[] analogMappings = this.profile.analogMappings;
			bool invert = analogMappings.invert;
			bool raw = analogMappings.raw;
			InputControl inputControl;
			if (analogMappings != null)
			{
				bool isOnZeroTick = inputControl.IsOnZeroTick;
				if (analogMappings == null)
				{
				}
				float num;
				bool flag = Utility.IsZero(num);
			}
			float num2;
			bool flag2 = inputControl.UpdateWithValue(num2, updateTick, deltaTime);
			InputDeviceProfile inputDeviceProfile = this.profile;
			InputControlMapping[] analogMappings2 = inputDeviceProfile.analogMappings;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000E190 File Offset: 0x0000C390
		private static void SetupAnalogQueries()
		{
			string text2;
			string text3;
			string text = "joystick " + text2 + " analog " + text3;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		private static void SetupButtonQueries()
		{
			string text2;
			string text3;
			string text = "joystick " + text2 + " button " + text3;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		public override bool ReadRawButtonState(int index)
		{
			int num = this.<JoystickId>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		public override float ReadRawAnalogValue(int index)
		{
			/*
An exception occurred when decompiling this method (06000444)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.UnityInputDevice::ReadRawAnalogValue(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(UnityInputDevice::<JoystickId>k__BackingField, ldloc:UnityInputDevice(this)))
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000E204 File Offset: 0x0000C404
		public override bool IsSupportedOnThisPlatform
		{
			get
			{
				InputDeviceProfile inputDeviceProfile = this.profile;
				return inputDeviceProfile == null || inputDeviceProfile.IsSupportedOnThisPlatform;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0000E224 File Offset: 0x0000C424
		public override bool IsKnown
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000446)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.UnityInputDevice::get_IsKnown()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputDeviceProfile(var_0_06, ldfld:InputDeviceProfile(UnityInputDevice::profile, ldloc:UnityInputDevice(this)))
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
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0000E238 File Offset: 0x0000C438
		public override int NumUnknownButtons
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000E248 File Offset: 0x0000C448
		public override int NumUnknownAnalogs
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x040003CD RID: 973
		private static string[,] analogQueries;

		// Token: 0x040003CE RID: 974
		private static string[,] buttonQueries;

		// Token: 0x040003CF RID: 975
		public const int MaxDevices = 10;

		// Token: 0x040003D0 RID: 976
		public const int MaxButtons = 20;

		// Token: 0x040003D1 RID: 977
		public const int MaxAnalogs = 20;

		// Token: 0x040003D2 RID: 978
		[CompilerGenerated]
		private int <JoystickId>k__BackingField;

		// Token: 0x040003D3 RID: 979
		private readonly InputDeviceProfile profile;
	}
}
