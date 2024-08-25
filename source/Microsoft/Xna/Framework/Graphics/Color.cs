using System;
using Cpp2IlInjected;
using Newtonsoft.Json;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200035C RID: 860
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public struct Color : IEquatable<Color>
	{
		// Token: 0x06001661 RID: 5729 RVA: 0x00062684 File Offset: 0x00060884
		public Color(Vector3 vector)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000626CC File Offset: 0x000608CC
		public Color(Vector4 vector)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00062714 File Offset: 0x00060914
		public Color(int r, int g, int b)
		{
			this.R = (byte)r;
			this.G = (byte)g;
			this.B = (byte)b;
			this.A = byte.MaxValue;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00062744 File Offset: 0x00060944
		public Color(int r, int g, int b, int a)
		{
			this.R = (byte)r;
			this.G = (byte)g;
			this.B = (byte)b;
			this.A = (byte)a;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00062770 File Offset: 0x00060970
		public Color(float r, float g, float b)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000627B8 File Offset: 0x000609B8
		public Color(float r, float g, float b, float a)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00062800 File Offset: 0x00060A00
		public Color(Color rgb, int a)
		{
			this.A = (byte)a;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00062814 File Offset: 0x00060A14
		public Color(Color rgb, float a)
		{
			this.R = 1;
			if (!true)
			{
			}
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0006283C File Offset: 0x00060A3C
		public ushort RGB565()
		{
			/*
An exception occurred when decompiling this method (06001669)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt16 Microsoft.Xna.Framework.Graphics.Color::RGB565()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(Color::R, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_1_0D, ldfld:uint8(Color::G, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_2_14, ldfld:uint8(Color::B, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
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

		// Token: 0x0600166A RID: 5738 RVA: 0x00062860 File Offset: 0x00060A60
		public ushort ARGB4444()
		{
			/*
An exception occurred when decompiling this method (0600166A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt16 Microsoft.Xna.Framework.Graphics.Color::ARGB4444()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(Color::R, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_1_0D, ldfld:uint8(Color::G, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_2_14, ldfld:uint8(Color::B, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
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

		// Token: 0x0600166B RID: 5739 RVA: 0x00062884 File Offset: 0x00060A84
		public Color32 RenderColour()
		{
			/*
An exception occurred when decompiling this method (0600166B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color32 Microsoft.Xna.Framework.Graphics.Color::RenderColour()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(Color::R, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_1_0D, ldfld:uint8(Color::G, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_2_14, ldfld:uint8(Color::B, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x000628A8 File Offset: 0x00060AA8
		public uint PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Color colorA, Color colorB)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000628B8 File Offset: 0x00060AB8
		public static bool operator !=(Color colorA, Color colorB)
		{
			/*
An exception occurred when decompiling this method (0600166F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.Color::op_Inequality(Microsoft.Xna.Framework.Graphics.Color,Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000628C8 File Offset: 0x00060AC8
		internal float GetBrightness()
		{
			/*
An exception occurred when decompiling this method (06001670)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.Color::GetBrightness()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:uint8(var_4_21, call:uint8(Math::Min, ldloc:uint8(var_2_0F), ldloc:uint8(var_3_16)))
	stloc:uint8(var_5_2B, call:uint8(Math::Min, ldloc:uint8(var_1_08), ldloc:uint8(var_4_21)))
	stloc:uint8(var_6_33, ldfld:uint8(Color::G, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_7_3B, ldfld:uint8(Color::B, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_8_43, ldfld:uint8(Color::R, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_9_4E, call:uint8(Math::Max, ldloc:uint8(var_6_33), ldloc:uint8(var_7_3B)))
	stloc:uint8(var_10_59, call:uint8(Math::Max, ldloc:uint8(var_8_43), ldloc:uint8(var_9_4E)))
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

		// Token: 0x06001671 RID: 5745 RVA: 0x00062930 File Offset: 0x00060B30
		internal float GetSaturation()
		{
			/*
An exception occurred when decompiling this method (06001671)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.Color::GetSaturation()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:uint8(var_4_21, call:uint8(Math::Min, ldloc:uint8(var_2_0F), ldloc:uint8(var_3_16)))
	stloc:uint8(var_5_2B, call:uint8(Math::Min, ldloc:uint8(var_1_08), ldloc:uint8(var_4_21)))
	stloc:uint8(var_6_33, ldfld:uint8(Color::G, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_7_3B, ldfld:uint8(Color::B, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_8_43, ldfld:uint8(Color::R, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_9_4E, call:uint8(Math::Max, ldloc:uint8(var_6_33), ldloc:uint8(var_7_3B)))
	stloc:uint8(var_10_59, call:uint8(Math::Max, ldloc:uint8(var_8_43), ldloc:uint8(var_9_4E)))
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

		// Token: 0x06001672 RID: 5746 RVA: 0x00062998 File Offset: 0x00060B98
		internal float GetHue()
		{
			/*
An exception occurred when decompiling this method (06001672)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.Color::GetHue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:int32(var_4_21, call:int32(Math::Min, ldloc:uint8[exp:int32](var_2_0F), ldloc:uint8[exp:int32](var_3_16)))
	stloc:int32(var_5_2B, call:int32(Math::Min, ldloc:uint8[exp:int32](var_1_08), ldloc:int32(var_4_21)))
	stloc:int32(var_6_34, call:int32(Math::Max, ldloc:uint8[exp:int32](var_2_0F), ldloc:uint8[exp:int32](var_3_16)))
	stloc:int32(var_7_3E, call:int32(Math::Max, ldloc:uint8[exp:int32](var_1_08), ldloc:int32(var_6_34)))
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

		// Token: 0x06001673 RID: 5747 RVA: 0x000629E4 File Offset: 0x00060BE4
		public override bool Equals(object o)
		{
			/*
An exception occurred when decompiling this method (06001673)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.Color::Equals(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, ldloc:object[exp:bool](o))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000629F8 File Offset: 0x00060BF8
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06001674)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Graphics.Color::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(Color::R, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
	stloc:uint8(var_1_0D, ldfld:uint8(Color::G, ldloc:valuetype Microsoft.Xna.Framework.Graphics.Color&(this)))
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

		// Token: 0x06001675 RID: 5749 RVA: 0x00062A14 File Offset: 0x00060C14
		public override string ToString()
		{
			byte r = this.R;
			byte g = this.G;
			byte b = this.B;
			string text;
			return text;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00062A40 File Offset: 0x00060C40
		public Vector4 ToVector4()
		{
			byte r = this.R;
			byte g = this.G;
			byte b = this.B;
			return 17279;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00062A68 File Offset: 0x00060C68
		public Vector3 ToVector3()
		{
			byte r = this.R;
			byte g = this.G;
			byte b = this.B;
			return 17279;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00062A90 File Offset: 0x00060C90
		public static Color operator *(Color a, float amount)
		{
			Color color;
			return color;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00062AA0 File Offset: 0x00060CA0
		public static Color Multiply(Color a, float amount)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00062AB4 File Offset: 0x00060CB4
		public static Color Lerp(Color value1, Color value2, float amount)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00062AE8 File Offset: 0x00060CE8
		public bool Equals(Color other)
		{
			/*
An exception occurred when decompiling this method (0600167B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.Color::Equals(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00062AF8 File Offset: 0x00060CF8
		// Note: this type is marked as 'beforefieldinit'.
		static Color()
		{
		}

		// Token: 0x0400242E RID: 9262
		[JsonProperty]
		public byte A;

		// Token: 0x0400242F RID: 9263
		[JsonProperty]
		public byte B;

		// Token: 0x04002430 RID: 9264
		[JsonProperty]
		public byte G;

		// Token: 0x04002431 RID: 9265
		[JsonProperty]
		public byte R;

		// Token: 0x04002432 RID: 9266
		public static readonly Color Transparent;

		// Token: 0x04002433 RID: 9267
		public static readonly Color TransparentBlack;

		// Token: 0x04002434 RID: 9268
		public static readonly Color TransparentWhite;

		// Token: 0x04002435 RID: 9269
		public static readonly Color AliceBlue;

		// Token: 0x04002436 RID: 9270
		public static readonly Color AntiqueWhite;

		// Token: 0x04002437 RID: 9271
		public static readonly Color Aqua;

		// Token: 0x04002438 RID: 9272
		public static readonly Color Aquamarine;

		// Token: 0x04002439 RID: 9273
		public static readonly Color Azure;

		// Token: 0x0400243A RID: 9274
		public static readonly Color Beige;

		// Token: 0x0400243B RID: 9275
		public static readonly Color Bisque;

		// Token: 0x0400243C RID: 9276
		public static readonly Color Black;

		// Token: 0x0400243D RID: 9277
		public static readonly Color BlanchedAlmond;

		// Token: 0x0400243E RID: 9278
		public static readonly Color Blue;

		// Token: 0x0400243F RID: 9279
		public static readonly Color BlueViolet;

		// Token: 0x04002440 RID: 9280
		public static readonly Color Brown;

		// Token: 0x04002441 RID: 9281
		public static readonly Color BurlyWood;

		// Token: 0x04002442 RID: 9282
		public static readonly Color CadetBlue;

		// Token: 0x04002443 RID: 9283
		public static readonly Color Chartreuse;

		// Token: 0x04002444 RID: 9284
		public static readonly Color Chocolate;

		// Token: 0x04002445 RID: 9285
		public static readonly Color Coral;

		// Token: 0x04002446 RID: 9286
		public static readonly Color CornflowerBlue;

		// Token: 0x04002447 RID: 9287
		public static readonly Color Cornsilk;

		// Token: 0x04002448 RID: 9288
		public static readonly Color Crimson;

		// Token: 0x04002449 RID: 9289
		public static readonly Color Cyan;

		// Token: 0x0400244A RID: 9290
		public static readonly Color DarkBlue;

		// Token: 0x0400244B RID: 9291
		public static readonly Color DarkCyan;

		// Token: 0x0400244C RID: 9292
		public static readonly Color DarkGoldenrod;

		// Token: 0x0400244D RID: 9293
		public static readonly Color DarkGray;

		// Token: 0x0400244E RID: 9294
		public static readonly Color DarkGreen;

		// Token: 0x0400244F RID: 9295
		public static readonly Color DarkKhaki;

		// Token: 0x04002450 RID: 9296
		public static readonly Color DarkMagenta;

		// Token: 0x04002451 RID: 9297
		public static readonly Color DarkOliveGreen;

		// Token: 0x04002452 RID: 9298
		public static readonly Color DarkOrange;

		// Token: 0x04002453 RID: 9299
		public static readonly Color DarkOrchid;

		// Token: 0x04002454 RID: 9300
		public static readonly Color DarkRed;

		// Token: 0x04002455 RID: 9301
		public static readonly Color DarkSalmon;

		// Token: 0x04002456 RID: 9302
		public static readonly Color DarkSeaGreen;

		// Token: 0x04002457 RID: 9303
		public static readonly Color DarkSlateBlue;

		// Token: 0x04002458 RID: 9304
		public static readonly Color DarkSlateGray;

		// Token: 0x04002459 RID: 9305
		public static readonly Color DarkTurquoise;

		// Token: 0x0400245A RID: 9306
		public static readonly Color DarkViolet;

		// Token: 0x0400245B RID: 9307
		public static readonly Color DeepPink;

		// Token: 0x0400245C RID: 9308
		public static readonly Color DeepSkyBlue;

		// Token: 0x0400245D RID: 9309
		public static readonly Color DimGray;

		// Token: 0x0400245E RID: 9310
		public static readonly Color DodgerBlue;

		// Token: 0x0400245F RID: 9311
		public static readonly Color Firebrick;

		// Token: 0x04002460 RID: 9312
		public static readonly Color FloralWhite;

		// Token: 0x04002461 RID: 9313
		public static readonly Color ForestGreen;

		// Token: 0x04002462 RID: 9314
		public static readonly Color Fuchsia;

		// Token: 0x04002463 RID: 9315
		public static readonly Color Gainsboro;

		// Token: 0x04002464 RID: 9316
		public static readonly Color GhostWhite;

		// Token: 0x04002465 RID: 9317
		public static readonly Color Gold;

		// Token: 0x04002466 RID: 9318
		public static readonly Color Goldenrod;

		// Token: 0x04002467 RID: 9319
		public static readonly Color Gray;

		// Token: 0x04002468 RID: 9320
		public static readonly Color Green;

		// Token: 0x04002469 RID: 9321
		public static readonly Color GreenYellow;

		// Token: 0x0400246A RID: 9322
		public static readonly Color Honeydew;

		// Token: 0x0400246B RID: 9323
		public static readonly Color HotPink;

		// Token: 0x0400246C RID: 9324
		public static readonly Color IndianRed;

		// Token: 0x0400246D RID: 9325
		public static readonly Color Indigo;

		// Token: 0x0400246E RID: 9326
		public static readonly Color Ivory;

		// Token: 0x0400246F RID: 9327
		public static readonly Color Khaki;

		// Token: 0x04002470 RID: 9328
		public static readonly Color Lavender;

		// Token: 0x04002471 RID: 9329
		public static readonly Color LavenderBlush;

		// Token: 0x04002472 RID: 9330
		public static readonly Color LawnGreen;

		// Token: 0x04002473 RID: 9331
		public static readonly Color LemonChiffon;

		// Token: 0x04002474 RID: 9332
		public static readonly Color LightBlue;

		// Token: 0x04002475 RID: 9333
		public static readonly Color LightCoral;

		// Token: 0x04002476 RID: 9334
		public static readonly Color LightCyan;

		// Token: 0x04002477 RID: 9335
		public static readonly Color LightGoldenrodYellow;

		// Token: 0x04002478 RID: 9336
		public static readonly Color LightGreen;

		// Token: 0x04002479 RID: 9337
		public static readonly Color LightGray;

		// Token: 0x0400247A RID: 9338
		public static readonly Color LightPink;

		// Token: 0x0400247B RID: 9339
		public static readonly Color LightSalmon;

		// Token: 0x0400247C RID: 9340
		public static readonly Color LightSeaGreen;

		// Token: 0x0400247D RID: 9341
		public static readonly Color LightSkyBlue;

		// Token: 0x0400247E RID: 9342
		public static readonly Color LightSlateGray;

		// Token: 0x0400247F RID: 9343
		public static readonly Color LightSteelBlue;

		// Token: 0x04002480 RID: 9344
		public static readonly Color LightYellow;

		// Token: 0x04002481 RID: 9345
		public static readonly Color Lime;

		// Token: 0x04002482 RID: 9346
		public static readonly Color LimeGreen;

		// Token: 0x04002483 RID: 9347
		public static readonly Color Linen;

		// Token: 0x04002484 RID: 9348
		public static readonly Color Magenta;

		// Token: 0x04002485 RID: 9349
		public static readonly Color Maroon;

		// Token: 0x04002486 RID: 9350
		public static readonly Color MediumAquamarine;

		// Token: 0x04002487 RID: 9351
		public static readonly Color MediumBlue;

		// Token: 0x04002488 RID: 9352
		public static readonly Color MediumOrchid;

		// Token: 0x04002489 RID: 9353
		public static readonly Color MediumPurple;

		// Token: 0x0400248A RID: 9354
		public static readonly Color MediumSeaGreen;

		// Token: 0x0400248B RID: 9355
		public static readonly Color MediumSlateBlue;

		// Token: 0x0400248C RID: 9356
		public static readonly Color MediumSpringGreen;

		// Token: 0x0400248D RID: 9357
		public static readonly Color MediumTurquoise;

		// Token: 0x0400248E RID: 9358
		public static readonly Color MediumVioletRed;

		// Token: 0x0400248F RID: 9359
		public static readonly Color MidnightBlue;

		// Token: 0x04002490 RID: 9360
		public static readonly Color MintCream;

		// Token: 0x04002491 RID: 9361
		public static readonly Color MistyRose;

		// Token: 0x04002492 RID: 9362
		public static readonly Color Moccasin;

		// Token: 0x04002493 RID: 9363
		public static readonly Color NavajoWhite;

		// Token: 0x04002494 RID: 9364
		public static readonly Color Navy;

		// Token: 0x04002495 RID: 9365
		public static readonly Color OldLace;

		// Token: 0x04002496 RID: 9366
		public static readonly Color Olive;

		// Token: 0x04002497 RID: 9367
		public static readonly Color OliveDrab;

		// Token: 0x04002498 RID: 9368
		public static readonly Color Orange;

		// Token: 0x04002499 RID: 9369
		public static readonly Color OrangeRed;

		// Token: 0x0400249A RID: 9370
		public static readonly Color Orchid;

		// Token: 0x0400249B RID: 9371
		public static readonly Color PaleGoldenrod;

		// Token: 0x0400249C RID: 9372
		public static readonly Color PaleGreen;

		// Token: 0x0400249D RID: 9373
		public static readonly Color PaleTurquoise;

		// Token: 0x0400249E RID: 9374
		public static readonly Color PaleVioletRed;

		// Token: 0x0400249F RID: 9375
		public static readonly Color PapayaWhip;

		// Token: 0x040024A0 RID: 9376
		public static readonly Color PeachPuff;

		// Token: 0x040024A1 RID: 9377
		public static readonly Color Peru;

		// Token: 0x040024A2 RID: 9378
		public static readonly Color Pink;

		// Token: 0x040024A3 RID: 9379
		public static readonly Color Plum;

		// Token: 0x040024A4 RID: 9380
		public static readonly Color PowderBlue;

		// Token: 0x040024A5 RID: 9381
		public static readonly Color Purple;

		// Token: 0x040024A6 RID: 9382
		public static readonly Color Red;

		// Token: 0x040024A7 RID: 9383
		public static readonly Color RosyBrown;

		// Token: 0x040024A8 RID: 9384
		public static readonly Color RoyalBlue;

		// Token: 0x040024A9 RID: 9385
		public static readonly Color SaddleBrown;

		// Token: 0x040024AA RID: 9386
		public static readonly Color Salmon;

		// Token: 0x040024AB RID: 9387
		public static readonly Color SandyBrown;

		// Token: 0x040024AC RID: 9388
		public static readonly Color SeaGreen;

		// Token: 0x040024AD RID: 9389
		public static readonly Color SeaShell;

		// Token: 0x040024AE RID: 9390
		public static readonly Color Sienna;

		// Token: 0x040024AF RID: 9391
		public static readonly Color Silver;

		// Token: 0x040024B0 RID: 9392
		public static readonly Color SkyBlue;

		// Token: 0x040024B1 RID: 9393
		public static readonly Color SlateBlue;

		// Token: 0x040024B2 RID: 9394
		public static readonly Color SlateGray;

		// Token: 0x040024B3 RID: 9395
		public static readonly Color Snow;

		// Token: 0x040024B4 RID: 9396
		public static readonly Color SpringGreen;

		// Token: 0x040024B5 RID: 9397
		public static readonly Color SteelBlue;

		// Token: 0x040024B6 RID: 9398
		public static readonly Color Tan;

		// Token: 0x040024B7 RID: 9399
		public static readonly Color Teal;

		// Token: 0x040024B8 RID: 9400
		public static readonly Color Thistle;

		// Token: 0x040024B9 RID: 9401
		public static readonly Color Tomato;

		// Token: 0x040024BA RID: 9402
		public static readonly Color Turquoise;

		// Token: 0x040024BB RID: 9403
		public static readonly Color Violet;

		// Token: 0x040024BC RID: 9404
		public static readonly Color Wheat;

		// Token: 0x040024BD RID: 9405
		public static readonly Color White;

		// Token: 0x040024BE RID: 9406
		public static readonly Color WhiteSmoke;

		// Token: 0x040024BF RID: 9407
		public static readonly Color Yellow;

		// Token: 0x040024C0 RID: 9408
		public static readonly Color YellowGreen;
	}
}
