using System;
using System.Globalization;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CF RID: 207
	[DefaultMember("Item")]
	[NativeClass("ColorRGBAf")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Math/Color.h")]
	public struct Color : IEquatable<Color>, IFormattable
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x00007BA4 File Offset: 0x00005DA4
		public Color(float r, float g, float b, float a)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00007BB4 File Offset: 0x00005DB4
		public Color(float r, float g, float b)
		{
			this.a = (float)16256;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00007BCC File Offset: 0x00005DCC
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00007BDC File Offset: 0x00005DDC
		public string ToString(string format, IFormatProvider formatProvider)
		{
			bool flag = string.IsNullOrEmpty(format);
			if (formatProvider == null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			}
			string text;
			string text2;
			string text3;
			string text4;
			if ((text == null || text != null) && (text2 == null || text2 != null) && (text3 == null || text3 != null) && (text4 == null || text4 != null))
			{
				string text5;
				return text5;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00007C28 File Offset: 0x00005E28
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00007C38 File Offset: 0x00005E38
		public override bool Equals(object other)
		{
			if (other != null)
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00007C4C File Offset: 0x00005E4C
		public bool Equals(Color other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color operator *(Color a, float b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000021B3 File Offset: 0x000003B3
		public static bool operator ==(Color lhs, Color rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000021B3 File Offset: 0x000003B3
		public static bool operator !=(Color lhs, Color rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color Lerp(Color a, Color b, float t)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00007C60 File Offset: 0x00005E60
		internal Color RGBMultiplied(float multiplier)
		{
			float num = this.r;
			float num2 = this.g;
			float num3 = this.b;
			float num4 = this.a;
			return ref this;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color red
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color green
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color blue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color white
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color black
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color yellow
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color cyan
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color gray
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x000021B3 File Offset: 0x000003B3
		public static Color clear
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00007C8C File Offset: 0x00005E8C
		public Color linear
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600040D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.Color UnityEngine.Color::get_linear()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_2_08, ldfld:float32(Color::g, ldloc:valuetype UnityEngine.Color&(this)))
	stloc:float32(var_4_11, call:float32(Mathf::GammaToLinearSpace, ldloc:float32(var_1)))
	stloc:float32(var_5_19, ldfld:float32(Color::b, ldloc:valuetype UnityEngine.Color&(this)))
	stloc:float32(var_7_25, call:float32(Mathf::GammaToLinearSpace, ldloc:float32(var_4_11)))
	stloc:float32(var_8_2D, ldfld:float32(Color::a, ldloc:valuetype UnityEngine.Color&(this)))
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public float maxColorComponent
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600040E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single UnityEngine.Color::get_maxColorComponent()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(Color::r, ldloc:valuetype UnityEngine.Color&(this)))
	stloc:float32(var_1_0D, ldfld:float32(Color::g, ldloc:valuetype UnityEngine.Color&(this)))
	stloc:float32(var_2_14, ldfld:float32(Color::b, ldloc:valuetype UnityEngine.Color&(this)))
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

		// Token: 0x0600040F RID: 1039 RVA: 0x00007CEC File Offset: 0x00005EEC
		public static implicit operator Vector4(Color c)
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000021B3 File Offset: 0x000003B3
		public static implicit operator Color(Vector4 v)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040003C0 RID: 960
		public float r;

		// Token: 0x040003C1 RID: 961
		public float g;

		// Token: 0x040003C2 RID: 962
		public float b;

		// Token: 0x040003C3 RID: 963
		public float a;
	}
}
