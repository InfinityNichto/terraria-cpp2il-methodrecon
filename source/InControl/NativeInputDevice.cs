using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace InControl
{
	// Token: 0x0200003D RID: 61
	public class NativeInputDevice : InputDevice
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600032D RID: 813 RVA: 0x000096EC File Offset: 0x000078EC
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00009700 File Offset: 0x00007900
		public uint Handle
		{
			[CompilerGenerated]
			get
			{
				return this.<Handle>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Handle>k__BackingField = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00009714 File Offset: 0x00007914
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00009748 File Offset: 0x00007948
		public InputDeviceInfo Info
		{
			[CompilerGenerated]
			get
			{
				string serialNumber = this.<Info>k__BackingField.serialNumber;
				string name = this.<Info>k__BackingField.name;
				InputDeviceInfo inputDeviceInfo;
				inputDeviceInfo.serialNumber = serialNumber;
				inputDeviceInfo.name = name;
				return inputDeviceInfo;
			}
			[CompilerGenerated]
			private set
			{
				string serialNumber = value.serialNumber;
				this.<Info>k__BackingField.serialNumber = serialNumber;
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00009768 File Offset: 0x00007968
		internal NativeInputDevice()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00009780 File Offset: 0x00007980
		internal void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo, InputDeviceProfile deviceProfile)
		{
			int num = 1;
			this.<Handle>k__BackingField = deviceHandle;
			string serialNumber = deviceInfo.serialNumber;
			this.profile = deviceProfile;
			this.<Info>k__BackingField.serialNumber = serialNumber;
			this.<SortOrder>k__BackingField = num;
			uint numAnalogs = this.<Info>k__BackingField.numAnalogs;
			int num2;
			this.numUnknownButtons = num2;
			int num3 = 20;
			int num4 = Math.Min((int)numAnalogs, num3);
			this.numUnknownAnalogs = num4;
			uint numButtons = this.<Info>k__BackingField.numButtons;
			uint numAnalogs2 = this.<Info>k__BackingField.numAnalogs;
			base.ClearInputState();
			base.ClearControls();
			InputDeviceProfile inputDeviceProfile = this.profile;
			InputDeviceInfo inputDeviceInfo = this.<Info>k__BackingField;
			string deviceName = inputDeviceProfile.deviceName;
			this.<Name>k__BackingField = this;
			string text2;
			string text = text2.Trim();
			InputDeviceProfile inputDeviceProfile2 = this.profile;
			this.<Name>k__BackingField = text;
			InputDeviceInfo inputDeviceInfo2;
			if (inputDeviceProfile2.deviceNotes == null)
			{
				inputDeviceInfo2 = this.<Info>k__BackingField;
			}
			this.<Meta>k__BackingField = inputDeviceInfo2;
			InputDeviceClass deviceClass = inputDeviceProfile2.deviceClass;
			bool invert = inputDeviceProfile2.analogMappings.invert;
			string deviceNotes = inputDeviceProfile2.deviceNotes;
			float sensitivity = this.profile.sensitivity;
			float lowerDeadZone = this.profile.lowerDeadZone;
			InputDeviceProfile inputDeviceProfile3 = this.profile;
			float upperDeadZone = inputDeviceProfile3.upperDeadZone;
			InputControl inputControl;
			inputControl.Raw = inputDeviceProfile3 != null;
			inputControl.Passive = inputDeviceProfile3 != null;
			InputControlMapping[] analogMappings = this.profile.analogMappings;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00009950 File Offset: 0x00007B50
		internal void Initialize(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
			string serialNumber = deviceInfo.serialNumber;
			InputDeviceProfile inputDeviceProfile = this.profile;
			this.Initialize(deviceHandle, deviceInfo, inputDeviceProfile);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00009974 File Offset: 0x00007B74
		public override void Update(ulong updateTick, float deltaTime)
		{
			int num = this.skipUpdateFrames;
			this.skipUpdateFrames = num;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00009A1C File Offset: 0x00007C1C
		public override bool ReadRawButtonState(int index)
		{
			/*
An exception occurred when decompiling this method (06000335)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.NativeInputDevice::ReadRawButtonState(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int16[](var_0_06, ldfld:int16[](NativeInputDevice::buttons, ldloc:NativeInputDevice(this)))
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

		// Token: 0x06000336 RID: 822 RVA: 0x00009A34 File Offset: 0x00007C34
		public override float ReadRawAnalogValue(int index)
		{
			/*
An exception occurred when decompiling this method (06000336)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single InControl.NativeInputDevice::ReadRawAnalogValue(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int16[](var_0_06, ldfld:int16[](NativeInputDevice::analogs, ldloc:NativeInputDevice(this)))
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

		// Token: 0x06000337 RID: 823 RVA: 0x000025E1 File Offset: 0x000007E1
		private static byte FloatToByte(float value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00009A48 File Offset: 0x00007C48
		public override void Vibrate(float leftMotor, float rightMotor)
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00009A58 File Offset: 0x00007C58
		public override void SetLightColor(float red, float green, float blue)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00009A68 File Offset: 0x00007C68
		public override void SetLightFlash(float flashOnDuration, float flashOffDuration)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00009A78 File Offset: 0x00007C78
		public bool HasSameVendorID(InputDeviceInfo deviceInfo)
		{
			string serialNumber = this.<Info>k__BackingField.serialNumber;
			string name = this.<Info>k__BackingField.name;
			string serialNumber2 = deviceInfo.serialNumber;
			bool flag;
			return flag;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00009AA8 File Offset: 0x00007CA8
		public bool HasSameProductID(InputDeviceInfo deviceInfo)
		{
			string serialNumber = this.<Info>k__BackingField.serialNumber;
			string name = this.<Info>k__BackingField.name;
			string serialNumber2 = deviceInfo.serialNumber;
			bool flag;
			return flag;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00009AD8 File Offset: 0x00007CD8
		public bool HasSameVersionNumber(InputDeviceInfo deviceInfo)
		{
			string serialNumber = this.<Info>k__BackingField.serialNumber;
			string name = this.<Info>k__BackingField.name;
			string serialNumber2 = deviceInfo.serialNumber;
			bool flag;
			return flag;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00009B08 File Offset: 0x00007D08
		public bool HasSameLocation(InputDeviceInfo deviceInfo)
		{
			string serialNumber = this.<Info>k__BackingField.serialNumber;
			string name = this.<Info>k__BackingField.name;
			string serialNumber2 = deviceInfo.serialNumber;
			bool flag;
			return flag;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00009B38 File Offset: 0x00007D38
		public bool HasSameSerialNumber(InputDeviceInfo deviceInfo)
		{
			string serialNumber = this.<Info>k__BackingField.serialNumber;
			string name = this.<Info>k__BackingField.name;
			string serialNumber2 = deviceInfo.serialNumber;
			bool flag;
			return flag;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00009B68 File Offset: 0x00007D68
		public override bool IsSupportedOnThisPlatform
		{
			get
			{
				InputDeviceProfile inputDeviceProfile = this.profile;
				return inputDeviceProfile == null || inputDeviceProfile.IsSupportedOnThisPlatform;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00009B88 File Offset: 0x00007D88
		public override bool IsKnown
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000341)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean InControl.NativeInputDevice::get_IsKnown()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InputDeviceProfile(var_0_06, ldfld:InputDeviceProfile(NativeInputDevice::profile, ldloc:NativeInputDevice(this)))
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00009B9C File Offset: 0x00007D9C
		public override int NumUnknownButtons
		{
			get
			{
				return this.numUnknownButtons;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00009BB0 File Offset: 0x00007DB0
		public override int NumUnknownAnalogs
		{
			get
			{
				return this.numUnknownAnalogs;
			}
		}

		// Token: 0x040002D0 RID: 720
		private const int maxUnknownButtons = 20;

		// Token: 0x040002D1 RID: 721
		private const int maxUnknownAnalogs = 20;

		// Token: 0x040002D2 RID: 722
		[CompilerGenerated]
		private uint <Handle>k__BackingField;

		// Token: 0x040002D3 RID: 723
		[CompilerGenerated]
		private InputDeviceInfo <Info>k__BackingField;

		// Token: 0x040002D4 RID: 724
		private short[] buttons;

		// Token: 0x040002D5 RID: 725
		private short[] analogs;

		// Token: 0x040002D6 RID: 726
		private InputDeviceProfile profile;

		// Token: 0x040002D7 RID: 727
		private int skipUpdateFrames;

		// Token: 0x040002D8 RID: 728
		private int numUnknownButtons;

		// Token: 0x040002D9 RID: 729
		private int numUnknownAnalogs;
	}
}
