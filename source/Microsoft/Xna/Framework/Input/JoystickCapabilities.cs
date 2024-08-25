using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x0200034D RID: 845
	public struct JoystickCapabilities
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x00060CB0 File Offset: 0x0005EEB0
		public bool IsConnected
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00060CC0 File Offset: 0x0005EEC0
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x00060CD4 File Offset: 0x0005EED4
		public string Identifier
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Identifier>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Identifier>k__BackingField = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00060CE8 File Offset: 0x0005EEE8
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x00060CFC File Offset: 0x0005EEFC
		public bool IsGamepad
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<IsGamepad>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00060D0C File Offset: 0x0005EF0C
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x00060D20 File Offset: 0x0005EF20
		public int AxisCount
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<AxisCount>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<AxisCount>k__BackingField = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00060D34 File Offset: 0x0005EF34
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x00060D48 File Offset: 0x0005EF48
		public int ButtonCount
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<ButtonCount>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<ButtonCount>k__BackingField = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00060D5C File Offset: 0x0005EF5C
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x00060D70 File Offset: 0x0005EF70
		public int HatCount
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<HatCount>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<HatCount>k__BackingField = value;
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00060D84 File Offset: 0x0005EF84
		public static bool operator ==(JoystickCapabilities left, JoystickCapabilities right)
		{
			string text = left.<Identifier>k__BackingField;
			bool flag = left.<IsGamepad>k__BackingField;
			int num = left.<AxisCount>k__BackingField;
			int num2 = left.<ButtonCount>k__BackingField;
			int num3 = left.<HatCount>k__BackingField;
			bool flag2;
			return flag2;
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00060DBC File Offset: 0x0005EFBC
		public static bool operator !=(JoystickCapabilities left, JoystickCapabilities right)
		{
			bool flag = left.<IsConnected>k__BackingField;
			bool flag2;
			return flag2;
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00060DD4 File Offset: 0x0005EFD4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag = this.<IsConnected>k__BackingField;
			bool flag2;
			return flag2;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00060DF0 File Offset: 0x0005EFF0
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060015AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Input.JoystickCapabilities::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(JoystickCapabilities::<Identifier>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.JoystickCapabilities&(this)))
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

		// Token: 0x060015AD RID: 5549 RVA: 0x00060E04 File Offset: 0x0005F004
		public override string ToString()
		{
			string text;
			if (("[JoystickCapabilities: IsConnected=" == null || "[JoystickCapabilities: IsConnected=" != null) && (text == null || text != null))
			{
				string text2 = this.<Identifier>k__BackingField;
				if ((text2 == null || text2 != null) && (", IsGamepad=" == null || ", IsGamepad=" != null))
				{
					bool flag = this.<IsGamepad>k__BackingField;
					string text3;
					if ((text3 == null || text3 != null) && (" , AxisCount=" == null || " , AxisCount=" != null))
					{
						int num = this.<AxisCount>k__BackingField;
						string text4;
						if ((text4 == null || text4 != null) && (", ButtonCount=" == null || ", ButtonCount=" != null))
						{
							int num2 = this.<ButtonCount>k__BackingField;
							string text5;
							if ((text5 == null || text5 != null) && (", HatCount=" == null || ", HatCount=" != null))
							{
								int num3 = this.<HatCount>k__BackingField;
								string text6;
								if ((text6 == null || text6 != null) && ("]" == null || "]" != null))
								{
									string text7;
									return text7;
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04002324 RID: 8996
		[CompilerGenerated]
		private bool <IsConnected>k__BackingField;

		// Token: 0x04002325 RID: 8997
		[CompilerGenerated]
		private string <Identifier>k__BackingField;

		// Token: 0x04002326 RID: 8998
		[CompilerGenerated]
		private bool <IsGamepad>k__BackingField;

		// Token: 0x04002327 RID: 8999
		[CompilerGenerated]
		private int <AxisCount>k__BackingField;

		// Token: 0x04002328 RID: 9000
		[CompilerGenerated]
		private int <ButtonCount>k__BackingField;

		// Token: 0x04002329 RID: 9001
		[CompilerGenerated]
		private int <HatCount>k__BackingField;
	}
}
