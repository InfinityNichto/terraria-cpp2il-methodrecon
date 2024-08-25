using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x02000511 RID: 1297
	[ComDefaultInterface(typeof(_ParameterInfo))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[Serializable]
	internal class RuntimeParameterInfo : ParameterInfo
	{
		// Token: 0x06002633 RID: 9779 RVA: 0x000538BC File Offset: 0x00051ABC
		internal RuntimeParameterInfo(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			this.MemberImpl = member;
			this.NameImpl = name;
			this.PositionImpl = position;
			this.AttrsImpl = (ParameterAttributes)attrs;
			this.ClassImpl = type;
			this.DefaultValueImpl = defaultValue;
			this.marshalAs = marshalAs;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00053904 File Offset: 0x00051B04
		internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization)
		{
			Type classImpl = p.ClassImpl;
			if (false)
			{
				StringBuilder stringBuilder = sb.Append(", ");
			}
			string text;
			StringBuilder stringBuilder2 = sb.Append(text);
			StringBuilder stringBuilder3 = sb.Append(" ByRef");
			Type classImpl2 = p.ClassImpl;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00053968 File Offset: 0x00051B68
		internal RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member)
		{
			this.ClassImpl = pinfo;
			this.MemberImpl = member;
			this.NameImpl = pinfo;
			this.PositionImpl = pinfo;
			this.AttrsImpl = pinfo;
			object obj;
			this.DefaultValueImpl = obj;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000539A8 File Offset: 0x00051BA8
		internal RuntimeParameterInfo(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			this.ClassImpl = type;
			this.MemberImpl = member;
			this.AttrsImpl = ParameterAttributes.Retval;
			this.marshalAs = marshalAs;
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x000539D8 File Offset: 0x00051BD8
		public override object DefaultValue
		{
			get
			{
				Type classImpl = this.ClassImpl;
				if (!true)
				{
				}
				Type type;
				bool flag = classImpl == type;
				Type type2;
				bool flag2 = this.ClassImpl == type2;
				if (this == null || this != null)
				{
					if (this.ClassImpl != null)
					{
						object defaultValueImpl = this.DefaultValueImpl;
						Type type3;
						bool flag3 = this.ClassImpl == type3;
						Type type4;
						bool flag4 = this.ClassImpl == type4;
						if (this != null && this == null)
						{
							goto IL_0070;
						}
						if (this.ClassImpl != null)
						{
							return this.DefaultValueImpl;
						}
					}
					return this.DefaultValueImpl;
				}
				IL_0070:
				throw new InvalidCastException();
			}
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00053A5C File Offset: 0x00051C5C
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (!true)
			{
			}
			long num = 0L;
			return MonoCustomAttrs.GetCustomAttributes(this, num != 0L);
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00053A78 File Offset: 0x00051C78
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			long num = 0L;
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, num != 0L);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00053A94 File Offset: 0x00051C94
		internal object GetDefaultValueImpl(ParameterInfo pinfo)
		{
			/*
An exception occurred when decompiling this method (0600263A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Reflection.RuntimeParameterInfo::GetDefaultValueImpl(System.Reflection.ParameterInfo)

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

		// Token: 0x0600263B RID: 9787 RVA: 0x00053AA4 File Offset: 0x00051CA4
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (!true)
			{
			}
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00053ABC File Offset: 0x00051CBC
		internal object[] GetPseudoCustomAttributes()
		{
			bool isIn = base.IsIn;
			bool isOut = base.IsOut;
			long num = 0L;
			bool isOptional = base.IsOptional;
			if (this.marshalAs != null)
			{
			}
			if (num != 0L)
			{
				bool isIn2 = base.IsIn;
				bool isOut2 = base.IsOut;
				bool isOptional2 = base.IsOptional;
				MarshalAsAttribute marshalAsAttribute = this.marshalAs;
				if (marshalAsAttribute != null)
				{
					MarshalAsAttribute marshalAsAttribute2 = marshalAsAttribute.Copy();
					if (marshalAsAttribute2 == null || marshalAsAttribute2 != null)
					{
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00053B28 File Offset: 0x00051D28
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			bool isIn = base.IsIn;
			bool isOut = base.IsOut;
			long num = 0L;
			bool isOptional = base.IsOptional;
			if (this.marshalAs != null)
			{
			}
			if (num != 0L)
			{
				bool isIn2 = base.IsIn;
				bool isOut2 = base.IsOut;
				bool isOptional2 = base.IsOptional;
				if (this.marshalAs != null)
				{
					UnmanagedType utype = this.marshalAs.utype;
					Type type;
					if (type == null || type != null)
					{
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0000207A File Offset: 0x0000027A
		internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0000207A File Offset: 0x0000027A
		internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040014FF RID: 5375
		internal MarshalAsAttribute marshalAs;
	}
}
