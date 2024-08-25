using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security;
using Cpp2IlInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000450 RID: 1104
	public static class Marshal
	{
		// Token: 0x060021AA RID: 8618 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static IntPtr AllocHGlobal(IntPtr cb)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0004C53C File Offset: 0x0004A73C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static IntPtr AllocHGlobal(int cb)
		{
			return (IntPtr)0;
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0004C550 File Offset: 0x0004A750
		private unsafe static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element)
		{
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0004C560 File Offset: 0x0004A760
		private static bool skip_fixed(Array array, int startIndex)
		{
			return true;
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0004C570 File Offset: 0x0004A770
		internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length)
		{
			int num = 1;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0004C58C File Offset: 0x0004A78C
		public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
		{
			int num = 1;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0004C5B0 File Offset: 0x0004A7B0
		internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0004C5C0 File Offset: 0x0004A7C0
		private unsafe static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element)
		{
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
		{
			int num = 1;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0004C5F4 File Offset: 0x0004A7F4
		public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
		{
			int num = 1;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x0004C618 File Offset: 0x0004A818
		public static void Copy(IntPtr source, short[] destination, int startIndex, int length)
		{
			int num = 1;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0004C63C File Offset: 0x0004A83C
		public static void Copy(IntPtr source, int[] destination, int startIndex, int length)
		{
			int num = 1;
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0004C660 File Offset: 0x0004A860
		public static void FreeBSTR(IntPtr ptr)
		{
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0004C670 File Offset: 0x0004A870
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void FreeHGlobal(IntPtr hglobal)
		{
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0004C680 File Offset: 0x0004A880
		private unsafe static void ClearBSTR(IntPtr ptr)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			if (num == 0)
			{
			}
			void* ptr2 = (void*)IntPtr.Add(ptr, (int)num2);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0004C6A4 File Offset: 0x0004A8A4
		public static void ZeroFreeBSTR(IntPtr s)
		{
			if (!true)
			{
			}
			Marshal.ClearBSTR(s);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0004C6BC File Offset: 0x0004A8BC
		private unsafe static void ClearAnsi(IntPtr ptr)
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			void* ptr2 = (void*)ptr;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				void* ptr3 = (void*)IntPtr.Add(ptr, (int)num2);
				return;
			}
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0004C6EC File Offset: 0x0004A8EC
		private static void ClearUnicode(IntPtr ptr)
		{
			int num = 1;
			long num2 = 0L;
			if (num == 0)
			{
			}
			short num3 = Marshal.ReadInt16(ptr, (int)num2);
			if (num == 0)
			{
			}
			long num4 = 0L;
			Marshal.WriteInt16(ptr, (int)num2, (short)num4);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0004C718 File Offset: 0x0004A918
		public static void ZeroFreeGlobalAllocAnsi(IntPtr s)
		{
			if (!true)
			{
			}
			Marshal.ClearAnsi(s);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0004C730 File Offset: 0x0004A930
		public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
			if (!true)
			{
			}
			Marshal.ClearUnicode(s);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0000207A File Offset: 0x0000027A
		public static int GetHRForException(Exception e)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0004C748 File Offset: 0x0004A948
		public static bool IsComObject(object o)
		{
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int GetLastWin32Error()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0000207A File Offset: 0x0000027A
		public static string PtrToStringAnsi(IntPtr ptr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0000207A File Offset: 0x0000027A
		public static string PtrToStringUni(IntPtr ptr)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0000207A File Offset: 0x0000027A
		[ComVisible(true)]
		public static object PtrToStructure(IntPtr ptr, Type structureType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0004C758 File Offset: 0x0004A958
		public static T PtrToStructure<T>(IntPtr ptr)
		{
			object obj;
			while (obj != null)
			{
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0000207A File Offset: 0x0000027A
		public static byte ReadByte(IntPtr ptr, int ofs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x0000207A File Offset: 0x0000027A
		public static short ReadInt16(IntPtr ptr, int ofs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int ReadInt32(IntPtr ptr, int ofs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static IntPtr StringToHGlobalAnsi(char* s, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0004C774 File Offset: 0x0004A974
		public static IntPtr StringToHGlobalAnsi(string s)
		{
			/*
An exception occurred when decompiling this method (060021C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr System.Runtime.InteropServices.Marshal::StringToHGlobalAnsi(System.String)

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

		// Token: 0x060021CA RID: 8650 RVA: 0x0004C784 File Offset: 0x0004A984
		public static IntPtr SecureStringToBSTR(SecureString s)
		{
			byte[] array;
			while (array == null)
			{
			}
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0004C798 File Offset: 0x0004A998
		internal static IntPtr SecureStringGlobalAllocator(int len)
		{
			if (!true)
			{
			}
			return Marshal.AllocHGlobal(0);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		internal static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator)
		{
			int num = 1;
			byte[] data = s.data;
			long num2 = 0L;
			int num3;
			Marshal.WriteInt16(num, (int)num2, (short)num3);
			if (num == 0)
			{
			}
			long num4 = 0L;
			Marshal.WriteInt16(num, (int)num2, (short)num4);
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0004C808 File Offset: 0x0004AA08
		public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0004C818 File Offset: 0x0004AA18
		[ComVisible(true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld)
		{
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0004C828 File Offset: 0x0004AA28
		public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0000207A File Offset: 0x0000027A
		private unsafe static IntPtr BufferToBSTR(char* ptr, int slen)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0000207A File Offset: 0x0000027A
		public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0004C838 File Offset: 0x0004AA38
		public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index)
		{
			if (!true)
			{
			}
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0004C84C File Offset: 0x0004AA4C
		public unsafe static void WriteByte(IntPtr ptr, int ofs, byte val)
		{
			void* ptr2 = (void*)IntPtr.Add(ptr, ofs);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0004C868 File Offset: 0x0004AA68
		public unsafe static void WriteInt16(IntPtr ptr, int ofs, short val)
		{
			void* ptr2 = (void*)ptr;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0000207A File Offset: 0x0000027A
		private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x0004C880 File Offset: 0x0004AA80
		public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0004C894 File Offset: 0x0004AA94
		internal static void SetLastWin32Error(int error)
		{
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0004C8A4 File Offset: 0x0004AAA4
		internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			long num2 = 0L;
			int num3 = 3;
			if (num2 == 0L && num3 == 0)
			{
				Type type2;
				if (type2 != null && type2 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				MethodInfo methodInfo;
				if (methodInfo != null)
				{
				}
				if (type != null && type == null)
				{
					throw new ArrayTypeMismatchException();
				}
				object obj;
				long num4;
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					num4 = 0L;
				}
				if (obj != null)
				{
					ExceptionDispatchInfo exceptionDispatchInfo;
					exceptionDispatchInfo.Throw();
					if (!false)
					{
					}
					throw new OutOfMemoryException();
				}
				if (num4 == 0L)
				{
					return "' returned null, which is not allowed.";
				}
				if (false)
				{
					throw new OutOfMemoryException();
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0004C980 File Offset: 0x0004AB80
		// Note: this type is marked as 'beforefieldinit'.
		static Marshal()
		{
			bool isRunningOnWindows = Environment.IsRunningOnWindows;
		}

		// Token: 0x04001284 RID: 4740
		public static readonly int SystemMaxDBCSCharSize;

		// Token: 0x04001285 RID: 4741
		public static readonly int SystemDefaultCharSize;

		// Token: 0x04001286 RID: 4742
		internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache;

		// Token: 0x04001287 RID: 4743
		internal static readonly object MarshalerInstanceCacheLock;

		// Token: 0x02000451 RID: 1105
		internal sealed class SecureStringAllocator : MulticastDelegate
		{
			// Token: 0x060021DA RID: 8666 RVA: 0x0004C998 File Offset: 0x0004AB98
			public SecureStringAllocator(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060021DB RID: 8667 RVA: 0x0004C9EC File Offset: 0x0004ABEC
			public IntPtr Invoke(int len)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
				return method_code;
			}
		}

		// Token: 0x02000452 RID: 1106
		internal class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple<Type, string>>
		{
			// Token: 0x060021DC RID: 8668 RVA: 0x0000207A File Offset: 0x0000027A
			public bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060021DD RID: 8669 RVA: 0x0000207A File Offset: 0x0000027A
			public int GetHashCode(ValueTuple<Type, string> key)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060021DE RID: 8670 RVA: 0x0004CA10 File Offset: 0x0004AC10
			public MarshalerInstanceKeyComparer()
			{
			}
		}

		// Token: 0x02000453 RID: 1107
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060021DF RID: 8671 RVA: 0x0004CA24 File Offset: 0x0004AC24
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060021E0 RID: 8672 RVA: 0x0004CA34 File Offset: 0x0004AC34
			public <>c()
			{
			}

			// Token: 0x060021E1 RID: 8673 RVA: 0x0000207A File Offset: 0x0000027A
			internal Dictionary<ValueTuple<Type, string>, ICustomMarshaler> <GetCustomMarshalerInstance>b__201_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04001288 RID: 4744
			public static readonly Marshal.<>c <>9;

			// Token: 0x04001289 RID: 4745
			public static Func<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>> <>9__201_0;
		}
	}
}
