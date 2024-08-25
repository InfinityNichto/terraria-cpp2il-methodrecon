using System;
using System.Collections.Generic;

namespace Terraria.GameInput
{
	// Token: 0x020006C9 RID: 1737
	public class KeyConfiguration
	{
		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x0022F398 File Offset: 0x0022D598
		public bool DoGrappleAndInteractShareTheSameKey
		{
			get
			{
				/*
An exception occurred when decompiling this method (060039E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameInput.KeyConfiguration::get_DoGrappleAndInteractShareTheSameKey()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry[](var_0_0B, ldfld:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry<!0, !1>[][exp:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry[]](Dictionary`2::_entries, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.TriggerNames, class [mscorlib]System.Collections.Generic.List`1<string>>[exp:Dictionary`2](KeyConfiguration::KeyStatus, ldloc:KeyConfiguration(this))))
	stloc:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry[](var_1_17, ldfld:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry<!0, !1>[][exp:valuetype [mscorlib]System.Collections.Generic.Dictionary`2/Entry[]](Dictionary`2::_entries, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.TriggerNames, class [mscorlib]System.Collections.Generic.List`1<string>>[exp:Dictionary`2](KeyConfiguration::KeyStatus, ldloc:KeyConfiguration(this))))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.TriggerNames, class [mscorlib]System.Collections.Generic.List`1<string>>(var_2_1E, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.TriggerNames, class [mscorlib]System.Collections.Generic.List`1<string>>(KeyConfiguration::KeyStatus, ldloc:KeyConfiguration(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.TriggerNames, class [mscorlib]System.Collections.Generic.List`1<string>>(var_3_25, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<valuetype Terraria.GameInput.TriggerNames, class [mscorlib]System.Collections.Generic.List`1<string>>(KeyConfiguration::KeyStatus, ldloc:KeyConfiguration(this)))
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

		// Token: 0x060039E7 RID: 14823 RVA: 0x0022F3D0 File Offset: 0x0022D5D0
		public void SetupKeys()
		{
			Dictionary<TriggerNames, List<string>> keyStatus = this.KeyStatus;
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x0022F3E8 File Offset: 0x0022D5E8
		public void Processkey(TriggersSet set, string newKey)
		{
			Dictionary<TriggerNames, List<string>> keyStatus = this.KeyStatus;
			bool[] keyStatus2 = set.KeyStatus;
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x0022F454 File Offset: 0x0022D654
		public void CopyKeyState(TriggersSet oldSet, TriggersSet newSet, string newKey)
		{
			Dictionary<TriggerNames, List<string>> keyStatus = this.KeyStatus;
			bool[] keyStatus2 = oldSet.KeyStatus;
			bool[] keyStatus3 = newSet.KeyStatus;
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x0022F48C File Offset: 0x0022D68C
		public void ReadPreferences(Dictionary<TriggerNames, List<string>> dict)
		{
			Dictionary<TriggerNames, List<string>> keyStatus = this.KeyStatus;
			Dictionary<TriggerNames, List<string>> keyStatus2 = this.KeyStatus;
			Dictionary.Entry[] entries = keyStatus2._entries;
			int count = keyStatus2._count;
			keyStatus2._count = count;
			int[] buckets = keyStatus2._buckets;
			Dictionary<TriggerNames, List<string>> keyStatus3 = this.KeyStatus;
			Dictionary.Entry[] entries2 = keyStatus3._entries;
			int count2 = keyStatus3._count;
			int[] buckets2 = keyStatus3._buckets;
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x0022F524 File Offset: 0x0022D724
		public Dictionary<TriggerNames, List<string>> WritePreferences()
		{
			Dictionary.Entry[] entries = this.KeyStatus._entries;
			throw new OutOfMemoryException();
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x0022F550 File Offset: 0x0022D750
		public KeyConfiguration()
		{
		}

		// Token: 0x04007A10 RID: 31248
		public Dictionary<TriggerNames, List<string>> KeyStatus;
	}
}
