using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000134 RID: 308
	[Serializable]
	public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable
	{
		// Token: 0x06000BE7 RID: 3047 RVA: 0x0001A85C File Offset: 0x00018A5C
		public static Array CreateInstance(Type elementType, params long[] lengths)
		{
			while (elementType == null || elementType == null)
			{
			}
			Array array;
			return array;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0000207A File Offset: 0x0000027A
		public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0001A874 File Offset: 0x00018A74
		public static void Resize<T>(T[] array, int newSize)
		{
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0001A884 File Offset: 0x00018A84
		int ICollection.Count
		{
			get
			{
				return this.Length;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0001A898 File Offset: 0x00018A98
		bool IList.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x1700010A RID: 266
		object IList.this[int index]
		{
			get
			{
				return this.GetValue(index);
			}
			set
			{
				this.SetValue(value, index);
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0000207A File Offset: 0x0000027A
		int IList.Add(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0001A8D4 File Offset: 0x00018AD4
		bool IList.Contains(object value)
		{
			/*
An exception occurred when decompiling this method (06000BEF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Array::System.Collections.IList.Contains(System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(Array::IndexOf, ldloc:Array(this), ldloc:object(value)))
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

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0001A8E8 File Offset: 0x00018AE8
		void IList.Clear()
		{
			int length = this.Length;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0001A8FC File Offset: 0x00018AFC
		int IList.IndexOf(object value)
		{
			return Array.IndexOf(this, value);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0000207A File Offset: 0x0000027A
		void IList.Insert(int index, object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0000207A File Offset: 0x0000027A
		void IList.Remove(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0000207A File Offset: 0x0000027A
		void IList.RemoveAt(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0001A910 File Offset: 0x00018B10
		public void CopyTo(Array array, int index)
		{
			if (array != null)
			{
			}
			int length = this.Length;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0001A928 File Offset: 0x00018B28
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0001A93C File Offset: 0x00018B3C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			int num2;
			while (other != null)
			{
				int length = this.Length;
				long num = 0L;
				object value = this.GetValue((int)num);
				if (comparer == null)
				{
					return num2;
				}
			}
			return num2;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0001A96C File Offset: 0x00018B6C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other != null)
			{
				int length = this.Length;
				long num = 0L;
				object value = this.GetValue((int)num);
				return;
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int CombineHashCodes(int h1, int h2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0001A998 File Offset: 0x00018B98
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			while (comparer == null)
			{
			}
			int length = this.Length;
			return this.Length;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		public static int BinarySearch(Array array, object value)
		{
			int num;
			return num;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0001A9E0 File Offset: 0x00018BE0
		public static TOutput[] ConvertAll<TOutput, TInput>(TInput[] array, Converter<TInput, TOutput> converter)
		{
			while (array == null)
			{
			}
			return array;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0001A9FC File Offset: 0x00018BFC
		public static void Copy(Array sourceArray, Array destinationArray, long length)
		{
			Array.Copy(sourceArray, destinationArray, (int)length);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0001AA14 File Offset: 0x00018C14
		public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
		{
			Array.Copy(sourceArray, (int)sourceIndex, destinationArray, (int)destinationIndex, (int)length);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0001AA30 File Offset: 0x00018C30
		public void CopyTo(Array array, long index)
		{
			this.CopyTo(array, (int)index);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0001AA48 File Offset: 0x00018C48
		public static void ForEach<T>(T[] array, Action<T> action)
		{
			while (array != null)
			{
				if (action != null)
				{
					return;
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0001AA60 File Offset: 0x00018C60
		public long LongLength
		{
			get
			{
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0000207A File Offset: 0x0000027A
		public long GetLongLength(int dimension)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0001AA70 File Offset: 0x00018C70
		public object GetValue(long index)
		{
			return this.GetValue((int)index);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0001AA84 File Offset: 0x00018C84
		public object GetValue(long index1, long index2)
		{
			return this.GetValue((int)index1, (int)index2);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0001AAA0 File Offset: 0x00018CA0
		public object GetValue(long index1, long index2, long index3)
		{
			return this.GetValue((int)index1, (int)index2, (int)index3);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0001AAC4 File Offset: 0x00018CC4
		public object GetValue(params long[] indices)
		{
			while (indices == null)
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		public bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0001AAE8 File Offset: 0x00018CE8
		public bool IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0001AAF8 File Offset: 0x00018CF8
		public bool IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0000207A File Offset: 0x0000027A
		public object SyncRoot
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0001AB08 File Offset: 0x00018D08
		public static int BinarySearch(Array array, int index, int length, object value)
		{
			int num;
			return num;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0001AB18 File Offset: 0x00018D18
		public static int BinarySearch(Array array, object value, IComparer comparer)
		{
			int num;
			return num;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0001AB28 File Offset: 0x00018D28
		public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer)
		{
			int num = 1;
			if (value != null || num == 0)
			{
			}
			return index;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0000207A File Offset: 0x0000027A
		private static int GetMedian(int low, int hi)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0000207A File Offset: 0x0000027A
		public static int BinarySearch<T>(T[] array, T value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0000207A File Offset: 0x0000027A
		public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0000207A File Offset: 0x0000027A
		public static int BinarySearch<T>(T[] array, int index, int length, T value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0000207A File Offset: 0x0000027A
		public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0001AB48 File Offset: 0x00018D48
		public static int IndexOf(Array array, object value)
		{
			int num;
			return num;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0001AB58 File Offset: 0x00018D58
		public static int IndexOf(Array array, object value, int startIndex)
		{
			int num;
			return num;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0001AB68 File Offset: 0x00018D68
		public static int IndexOf(Array array, object value, int startIndex, int count)
		{
			int num;
			if ((num != 0 && array == null) || array != null)
			{
			}
			return "Index was out of range. Must be non-negative and less than the size of the collection.";
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0000207A File Offset: 0x0000027A
		public static int IndexOf<T>(T[] array, T value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0000207A File Offset: 0x0000027A
		public static int IndexOf<T>(T[] array, T value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0001AB88 File Offset: 0x00018D88
		public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			return "Index was out of range. Must be non-negative and less than the size of the collection.";
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0001AB9C File Offset: 0x00018D9C
		public static int LastIndexOf(Array array, object value)
		{
			int num;
			return num;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0001ABAC File Offset: 0x00018DAC
		public static int LastIndexOf(Array array, object value, int startIndex)
		{
			int num;
			return num;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0001ABBC File Offset: 0x00018DBC
		public static int LastIndexOf(Array array, object value, int startIndex, int count)
		{
			int num;
			if (num != 0)
			{
				int num2;
				if (num2 != 0)
				{
					if (array != null)
					{
						if (num2 != 0)
						{
						}
						return num2;
					}
				}
				else if (array != null)
				{
				}
			}
			return "Index was out of range. Must be non-negative and less than the size of the collection.";
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0000207A File Offset: 0x0000027A
		public static int LastIndexOf<T>(T[] array, T value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0000207A File Offset: 0x0000027A
		public static int LastIndexOf<T>(T[] array, T value, int startIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0001ABE8 File Offset: 0x00018DE8
		public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			while (startIndex != 0)
			{
			}
			return "Index was out of range. Must be non-negative and less than the size of the collection.";
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0001AC00 File Offset: 0x00018E00
		public static void Reverse(Array array)
		{
			while (array == null)
			{
			}
			int length = array.Length;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0001AC18 File Offset: 0x00018E18
		public static void Reverse(Array array, int index, int length)
		{
			if (array == null)
			{
				return;
			}
			int length2 = array.Length;
			if (array != null)
			{
				return;
			}
			object value = array.GetValue(index);
			object value2 = array.GetValue(length);
			array.SetValue(value2, index);
			array.SetValue(value, length);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0001AC58 File Offset: 0x00018E58
		public static void Reverse<T>(T[] array)
		{
			while (array == null)
			{
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0001AC68 File Offset: 0x00018E68
		public static void Reverse<T>(T[] array, int index, int length)
		{
			if (array != null)
			{
				return;
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0001AC7C File Offset: 0x00018E7C
		public void SetValue(object value, long index)
		{
			this.SetValue(value, (int)index);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0001AC94 File Offset: 0x00018E94
		public void SetValue(object value, long index1, long index2)
		{
			this.SetValue(value, (int)index1, (int)index2);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0001ACAC File Offset: 0x00018EAC
		public void SetValue(object value, long index1, long index2, long index3)
		{
			this.SetValue(value, (int)index1, (int)index2, (int)index3);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0001ACC8 File Offset: 0x00018EC8
		public void SetValue(object value, params long[] indices)
		{
			if (indices != null)
			{
				return;
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0001ACE0 File Offset: 0x00018EE0
		public static void Sort(Array array)
		{
			while (array == null)
			{
			}
			int length = array.Length;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0001ACF8 File Offset: 0x00018EF8
		public static void Sort(Array array, int index, int length)
		{
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0001AD08 File Offset: 0x00018F08
		public static void Sort(Array array, IComparer comparer)
		{
			while (array == null)
			{
			}
			int length = array.Length;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0001AD20 File Offset: 0x00018F20
		public static void Sort(Array array, int index, int length, IComparer comparer)
		{
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0001AD30 File Offset: 0x00018F30
		public static void Sort(Array keys, Array items)
		{
			while (keys == null)
			{
			}
			int length = keys.Length;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0001AD48 File Offset: 0x00018F48
		public static void Sort(Array keys, Array items, IComparer comparer)
		{
			while (keys == null)
			{
			}
			int length = keys.Length;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0001AD60 File Offset: 0x00018F60
		public static void Sort(Array keys, Array items, int index, int length)
		{
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0001AD70 File Offset: 0x00018F70
		public static void Sort(Array keys, Array items, int index, int length, IComparer comparer)
		{
			if (keys == null)
			{
				return;
			}
			if (items != null)
			{
				return;
			}
			int length2 = keys.Length;
			if (items != null)
			{
				int length3 = items.Length;
			}
			Array.SortImpl(keys, items, index, length, comparer);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0001ADA4 File Offset: 0x00018FA4
		public static void Sort<T>(T[] array)
		{
			while (array == null)
			{
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0001ADB4 File Offset: 0x00018FB4
		public static void Sort<T>(T[] array, int index, int length)
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0001ADC4 File Offset: 0x00018FC4
		public static void Sort<T>(T[] array, IComparer<T> comparer)
		{
			while (array == null)
			{
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0001ADD4 File Offset: 0x00018FD4
		public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer)
		{
			if (array != null)
			{
				return;
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0001ADE8 File Offset: 0x00018FE8
		public static void Sort<T>(T[] array, Comparison<T> comparison)
		{
			while (array != null)
			{
				if (comparison != null)
				{
					return;
				}
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0001ADFC File Offset: 0x00018FFC
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items)
		{
			while (keys == null)
			{
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0001AE0C File Offset: 0x0001900C
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length)
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0001AE1C File Offset: 0x0001901C
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer)
		{
			while (keys == null)
			{
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0001AE2C File Offset: 0x0001902C
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer)
		{
			while (keys == null)
			{
			}
			if (items != null)
			{
			}
			if (items != null)
			{
				return;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool Exists<T>(T[] array, Predicate<T> match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0001AE48 File Offset: 0x00019048
		public static void Fill<T>(T[] array, T value)
		{
			while (array == null)
			{
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0001AE5C File Offset: 0x0001905C
		public static void Fill<T>(T[] array, T value, int startIndex, int count)
		{
			while (array == null)
			{
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0001AE70 File Offset: 0x00019070
		public static T Find<T>(T[] array, Predicate<T> match)
		{
			while (array == null)
			{
			}
			return "array";
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0001AE8C File Offset: 0x0001908C
		public static T[] FindAll<T>(T[] array, Predicate<T> match)
		{
			int num;
			do
			{
				num = 1;
			}
			while (array == null);
			if (num == 0)
			{
			}
			return "array";
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0000207A File Offset: 0x0000027A
		public static int FindIndex<T>(T[] array, Predicate<T> match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0000207A File Offset: 0x0000027A
		public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0001AEB0 File Offset: 0x000190B0
		public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
		{
			while (count == 0)
			{
			}
			return "Index was out of range. Must be non-negative and less than the size of the collection.";
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0001AECC File Offset: 0x000190CC
		public static T FindLast<T>(T[] array, Predicate<T> match)
		{
			while (array == null)
			{
			}
			return array;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0000207A File Offset: 0x0000027A
		public static int FindLastIndex<T>(T[] array, Predicate<T> match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0000207A File Offset: 0x0000027A
		public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0001AEE8 File Offset: 0x000190E8
		public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
		{
			while (count == 0)
			{
			}
			return count;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0001AF08 File Offset: 0x00019108
		public static bool TrueForAll<T>(T[] array, Predicate<T> match)
		{
			while (array == null)
			{
			}
			return "array" != null;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0001AF24 File Offset: 0x00019124
		public IEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06000C45)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Array::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, callgetter:int32(Array::get_Length, ldloc:Array(this)))
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

		// Token: 0x06000C46 RID: 3142 RVA: 0x0001AF38 File Offset: 0x00019138
		private Array()
		{
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0001AF4C File Offset: 0x0001914C
		internal int InternalArray__ICollection_get_Count()
		{
			return this.Length;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0001AF60 File Offset: 0x00019160
		internal bool InternalArray__ICollection_get_IsReadOnly()
		{
			return true;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0000207A File Offset: 0x0000027A
		internal byte GetRawSzArrayData()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0001AF70 File Offset: 0x00019170
		internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
		{
			/*
An exception occurred when decompiling this method (06000C4A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IEnumerator`1<T> System.Array::InternalArray__IEnumerable_GetEnumerator<T>()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(callgetter:int32[exp:bool](Array::get_Length, ldloc:Array(this))))
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

		// Token: 0x06000C4B RID: 3147 RVA: 0x0000207A File Offset: 0x0000027A
		internal void InternalArray__ICollection_Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0000207A File Offset: 0x0000027A
		internal void InternalArray__ICollection_Add<T>(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0000207A File Offset: 0x0000027A
		internal bool InternalArray__ICollection_Remove<T>(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0001AF84 File Offset: 0x00019184
		internal bool InternalArray__ICollection_Contains<T>(T item)
		{
			/*
An exception occurred when decompiling this method (06000C4E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Array::InternalArray__ICollection_Contains<T>(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, callgetter:int32(Array::get_Rank, ldloc:Array(this)))
	stloc:int32(var_1_0D, callgetter:int32(Array::get_Length, ldloc:Array(this)))
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

		// Token: 0x06000C4F RID: 3151 RVA: 0x0001AFA8 File Offset: 0x000191A8
		internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex)
		{
			long num = 0L;
			int lowerBound = this.GetLowerBound((int)num);
			int length = this.Length;
			Array.Copy(this, lowerBound, array, arrayIndex, length);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0001AFD0 File Offset: 0x000191D0
		internal T InternalArray__IReadOnlyList_get_Item<T>(int index)
		{
			/*
An exception occurred when decompiling this method (06000C50)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T System.Array::InternalArray__IReadOnlyList_get_Item<T>(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, callgetter:int32(Array::get_Length, ldloc:Array(this)))
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

		// Token: 0x06000C51 RID: 3153 RVA: 0x0001AFE4 File Offset: 0x000191E4
		internal int InternalArray__IReadOnlyCollection_get_Count()
		{
			return this.Length;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0000207A File Offset: 0x0000027A
		internal void InternalArray__Insert<T>(int index, T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0000207A File Offset: 0x0000027A
		internal void InternalArray__RemoveAt(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0001AFF8 File Offset: 0x000191F8
		internal int InternalArray__IndexOf<T>(T item)
		{
			int rank = this.Rank;
			int length = this.Length;
			long num = 0L;
			return this.GetLowerBound((int)num);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0001B02C File Offset: 0x0001922C
		internal T InternalArray__get_Item<T>(int index)
		{
			/*
An exception occurred when decompiling this method (06000C55)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T System.Array::InternalArray__get_Item<T>(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, callgetter:int32(Array::get_Length, ldloc:Array(this)))
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

		// Token: 0x06000C56 RID: 3158 RVA: 0x0001B040 File Offset: 0x00019240
		internal void InternalArray__set_Item<T>(int index, T item)
		{
			int length = this.Length;
			if (this != null)
			{
				return;
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0001B05E File Offset: 0x0001925E
		internal void GetGenericValueImpl<T>(int pos, [Out] T value)
		{
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0001B05E File Offset: 0x0001925E
		internal void SetGenericValueImpl<T>(int pos, T value)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0001B060 File Offset: 0x00019260
		public int Length
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0000207A File Offset: 0x0000027A
		public int Rank
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0000207A File Offset: 0x0000027A
		private int GetRank()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0000207A File Offset: 0x0000027A
		public int GetLength(int dimension)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int GetLowerBound(int dimension)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0000207A File Offset: 0x0000027A
		public object GetValue(params int[] indices)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0001B070 File Offset: 0x00019270
		public void SetValue(object value, params int[] indices)
		{
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0000207A File Offset: 0x0000027A
		internal object GetValueImpl(int pos)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0001B080 File Offset: 0x00019280
		internal void SetValueImpl(object value, int pos)
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0000207A File Offset: 0x0000027A
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int GetUpperBound(int dimension)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0001B090 File Offset: 0x00019290
		public object GetValue(int index)
		{
			/*
An exception occurred when decompiling this method (06000C65)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Array::GetValue(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Type(var_0_06, call:Type(object::GetType, ldloc:Array[exp:object](this)))
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

		// Token: 0x06000C66 RID: 3174 RVA: 0x0000207A File Offset: 0x0000027A
		public object GetValue(int index1, int index2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0000207A File Offset: 0x0000027A
		public object GetValue(int index1, int index2, int index3)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0001B0A4 File Offset: 0x000192A4
		public void SetValue(object value, int index)
		{
			Type type = base.GetType();
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0001B0BC File Offset: 0x000192BC
		public void SetValue(object value, int index1, int index2)
		{
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0001B0CC File Offset: 0x000192CC
		public void SetValue(object value, int index1, int index2, int index3)
		{
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0001B0DC File Offset: 0x000192DC
		internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
		{
			Array array;
			return array;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0001B0EC File Offset: 0x000192EC
		internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2)
		{
			Array array;
			return array;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0001B0FC File Offset: 0x000192FC
		internal static Array UnsafeCreateInstance(Type elementType, params int[] lengths)
		{
			Array array;
			return array;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0001B10C File Offset: 0x0001930C
		public static Array CreateInstance(Type elementType, int length)
		{
			Array array;
			return array;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0001B11C File Offset: 0x0001931C
		public static Array CreateInstance(Type elementType, int length1, int length2)
		{
			Array array;
			return array;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0001B12C File Offset: 0x0001932C
		public static Array CreateInstance(Type elementType, int length1, int length2, int length3)
		{
			Array array;
			return array;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0001B13C File Offset: 0x0001933C
		public static Array CreateInstance(Type elementType, params int[] lengths)
		{
			if (!true)
			{
			}
			if (elementType != null && false)
			{
				return "elementType";
			}
			return "Array type can not be void";
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0001B160 File Offset: 0x00019360
		public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
		{
			if (!true)
			{
			}
			if (elementType == null)
			{
				return "lengths";
			}
			if (lengths != null && false)
			{
				return "elementType";
			}
			return "Array type can not be void";
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0001B198 File Offset: 0x00019398
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void Clear(Array array, int index, int length)
		{
			if (array != null)
			{
				int length2 = array.Length;
				return;
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0001B1B4 File Offset: 0x000193B4
		private static void ClearInternal(Array a, int index, int count)
		{
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0001B1C4 File Offset: 0x000193C4
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static void Copy(Array sourceArray, Array destinationArray, int length)
		{
			while (sourceArray != null)
			{
				if (destinationArray != null)
				{
					return;
				}
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0001B1D8 File Offset: 0x000193D8
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			if (sourceArray == null)
			{
				return;
			}
			if (destinationArray != null)
			{
				int length2 = sourceArray.Length;
				int length3 = destinationArray.Length;
				Type type = sourceArray.GetType();
				Type type2 = destinationArray.GetType();
				return;
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0000207A File Offset: 0x0000027A
		private static ArrayTypeMismatchException CreateArrayTypeMismatchException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0001B228 File Offset: 0x00019428
		private static bool CanAssignArrayElement(Type source, Type target)
		{
			return source.IsInterface;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0001B240 File Offset: 0x00019440
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0000207A File Offset: 0x0000027A
		public static T[] Empty<T>()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0001B258 File Offset: 0x00019458
		public void Initialize()
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0000207A File Offset: 0x0000027A
		private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0000207A File Offset: 0x0000027A
		private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0001B268 File Offset: 0x00019468
		private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer)
		{
			if (keys == null || (items != null && items == null))
			{
				return;
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0000207A File Offset: 0x0000027A
		internal static T UnsafeLoad<T>(T[] array, int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0001B280 File Offset: 0x00019480
		internal static void UnsafeStore<T>(T[] array, int index, T value)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0000207A File Offset: 0x0000027A
		internal static R UnsafeMov<R, S>(S instance)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x02000135 RID: 309
		private sealed class ArrayEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06000C82 RID: 3202 RVA: 0x0001B290 File Offset: 0x00019490
			internal ArrayEnumerator(Array array)
			{
				this._array = array;
				int length = array.Length;
				this._endIndex = length;
			}

			// Token: 0x06000C83 RID: 3203 RVA: 0x0001B2B8 File Offset: 0x000194B8
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06000C83)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Array/ArrayEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ArrayEnumerator::_index, ldloc:ArrayEnumerator(this)))
	stfld:int32(ArrayEnumerator::_index, ldloc:ArrayEnumerator(this), ldloc:int32(var_0_06))
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

			// Token: 0x06000C84 RID: 3204 RVA: 0x0001B2D4 File Offset: 0x000194D4
			public void Reset()
			{
			}

			// Token: 0x06000C85 RID: 3205 RVA: 0x0001B2E4 File Offset: 0x000194E4
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0001B2F8 File Offset: 0x000194F8
			public object Current
			{
				get
				{
					int index = this._index;
					int endIndex = this._endIndex;
					if (index == 0)
					{
						Type type = this._array.GetType();
						int index2 = this._index;
					}
					Array array = this._array;
					return "Enumeration has not started. Call MoveNext.";
				}
			}

			// Token: 0x040004D1 RID: 1233
			private Array _array;

			// Token: 0x040004D2 RID: 1234
			private int _index;

			// Token: 0x040004D3 RID: 1235
			private int _endIndex;
		}

		// Token: 0x02000136 RID: 310
		[StructLayout(0)]
		private class RawData
		{
			// Token: 0x040004D4 RID: 1236
			public IntPtr Bounds;

			// Token: 0x040004D5 RID: 1237
			public IntPtr Count;

			// Token: 0x040004D6 RID: 1238
			public byte Data;
		}

		// Token: 0x02000137 RID: 311
		internal struct InternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000C87 RID: 3207 RVA: 0x0001B338 File Offset: 0x00019538
			internal InternalEnumerator(Array array)
			{
				this.array = array;
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x0001B34C File Offset: 0x0001954C
			public void Dispose()
			{
			}

			// Token: 0x06000C89 RID: 3209 RVA: 0x0001B35C File Offset: 0x0001955C
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06000C89)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Array/InternalEnumerator`1::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InternalEnumerator`1::idx, ldloc:valuetype System.Array/InternalEnumerator`1&(this)))
	stfld:int32(InternalEnumerator`1::idx, ldloc:valuetype System.Array/InternalEnumerator`1&(this), ldloc:int32(var_1))
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

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0001B378 File Offset: 0x00019578
			public T Current
			{
				get
				{
					int num = this.idx;
					int num2 = this.idx;
					return "Enumeration already finished";
				}
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x0001B398 File Offset: 0x00019598
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000C8C RID: 3212 RVA: 0x0001B3A8 File Offset: 0x000195A8
			object IEnumerator.Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000C8C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Array/InternalEnumerator`1::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(InternalEnumerator`1::idx, ldloc:valuetype System.Array/InternalEnumerator`1&(this)))
	stloc:!T(var_1_0D, callgetter:!0[exp:!T](InternalEnumerator`1::get_Current, ldloc:valuetype System.Array/InternalEnumerator`1&(this)))
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

			// Token: 0x040004D7 RID: 1239
			private readonly Array array;

			// Token: 0x040004D8 RID: 1240
			private int idx;
		}

		// Token: 0x02000138 RID: 312
		internal class EmptyInternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000C8D RID: 3213 RVA: 0x0001B3C4 File Offset: 0x000195C4
			public void Dispose()
			{
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x0001B3D4 File Offset: 0x000195D4
			public bool MoveNext()
			{
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0000207A File Offset: 0x0000027A
			public T Current
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0000207A File Offset: 0x0000027A
			object IEnumerator.Current
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06000C91 RID: 3217 RVA: 0x0001B3E4 File Offset: 0x000195E4
			void IEnumerator.Reset()
			{
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x0001B3F4 File Offset: 0x000195F4
			public EmptyInternalEnumerator()
			{
			}

			// Token: 0x06000C93 RID: 3219 RVA: 0x0001B408 File Offset: 0x00019608
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyInternalEnumerator()
			{
			}

			// Token: 0x040004D9 RID: 1241
			public static readonly Array.EmptyInternalEnumerator<T> Value;
		}

		// Token: 0x02000139 RID: 313
		private struct SorterObjectArray
		{
			// Token: 0x06000C94 RID: 3220 RVA: 0x0001B418 File Offset: 0x00019618
			internal SorterObjectArray(object[] keys, object[] items, IComparer comparer)
			{
				if (comparer != null || !true)
				{
				}
				this.keys = keys;
				this.items = items;
				this.comparer = 1;
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x0001B440 File Offset: 0x00019640
			internal void SwapIfGreaterWithItems(int a, int b)
			{
				IComparer comparer = this.comparer;
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x0001B46C File Offset: 0x0001966C
			private void Swap(int i, int j)
			{
				if ((ref this) != null && (ref this) != null)
				{
					if (this.items != null)
					{
						if (j != 0 && j == 0)
						{
							goto IL_0022;
						}
						object[] array = this.items;
						if (i != 0 && i == 0)
						{
							goto IL_0022;
						}
					}
					return;
				}
				IL_0022:
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x0001B4A0 File Offset: 0x000196A0
			internal void Sort(int left, int length)
			{
				this.IntrospectiveSort(left, length);
			}

			// Token: 0x06000C98 RID: 3224 RVA: 0x0001B4B8 File Offset: 0x000196B8
			private void IntrospectiveSort(int left, int length)
			{
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x0001B4D0 File Offset: 0x000196D0
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				int num = this.PickPivotAndPartition(lo, hi);
				this.IntroSort(lo, hi, depthLimit);
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x0001B51C File Offset: 0x0001971C
			private int PickPivotAndPartition(int lo, int hi)
			{
				this.SwapIfGreaterWithItems(lo, hi);
				this.SwapIfGreaterWithItems(lo, hi);
				this.SwapIfGreaterWithItems(lo, hi);
				this.Swap(lo, hi);
				IComparer comparer = this.comparer;
				IComparer comparer2 = this.comparer;
				this.Swap(lo, hi);
				this.Swap(lo, hi);
				return lo;
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x0001B56C File Offset: 0x0001976C
			private void Heapsort(int lo, int hi)
			{
				this.DownHeap(lo, hi, lo);
				this.Swap(lo, hi);
				int num = 1;
				this.DownHeap(num, hi, lo);
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x0001B598 File Offset: 0x00019798
			private void DownHeap(int i, int n, int lo)
			{
				object[] array = this.keys;
				if (this.items != null)
				{
					return;
				}
				IComparer comparer = this.comparer;
			}

			// Token: 0x06000C9D RID: 3229 RVA: 0x0001B5F4 File Offset: 0x000197F4
			private void InsertionSort(int lo, int hi)
			{
				object[] array = this.keys;
				if (this.items != null)
				{
					return;
				}
				IComparer comparer = this.comparer;
			}

			// Token: 0x040004DA RID: 1242
			private object[] keys;

			// Token: 0x040004DB RID: 1243
			private object[] items;

			// Token: 0x040004DC RID: 1244
			private IComparer comparer;
		}

		// Token: 0x0200013A RID: 314
		private struct SorterGenericArray
		{
			// Token: 0x06000C9E RID: 3230 RVA: 0x0001B644 File Offset: 0x00019844
			internal SorterGenericArray(Array keys, Array items, IComparer comparer)
			{
				if (comparer != null || !true)
				{
				}
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x0001B658 File Offset: 0x00019858
			internal void SwapIfGreaterWithItems(int a, int b)
			{
				IComparer comparer = this.comparer;
			}

			// Token: 0x06000CA0 RID: 3232 RVA: 0x0001B6B0 File Offset: 0x000198B0
			private void Swap(int i, int j)
			{
				Array array = this.items;
				if (array != null)
				{
					object value = array.GetValue(i);
					Array array2 = this.items;
					object value2 = array2.GetValue(j);
					array2.SetValue(value2, i);
					this.items.SetValue(value, j);
					return;
				}
			}

			// Token: 0x06000CA1 RID: 3233 RVA: 0x0001B6FC File Offset: 0x000198FC
			internal void Sort(int left, int length)
			{
				this.IntrospectiveSort(left, length);
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x0001B714 File Offset: 0x00019914
			private void IntrospectiveSort(int left, int length)
			{
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x0001B72C File Offset: 0x0001992C
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				int num = this.PickPivotAndPartition(lo, hi);
				this.IntroSort(lo, hi, depthLimit);
			}

			// Token: 0x06000CA4 RID: 3236 RVA: 0x0001B778 File Offset: 0x00019978
			private int PickPivotAndPartition(int lo, int hi)
			{
				this.SwapIfGreaterWithItems(lo, hi);
				this.SwapIfGreaterWithItems(lo, hi);
				this.SwapIfGreaterWithItems(lo, hi);
				this.Swap(lo, hi);
				IComparer comparer = this.comparer;
				IComparer comparer2 = this.comparer;
				this.Swap(lo, hi);
				this.Swap(lo, hi);
				return lo;
			}

			// Token: 0x06000CA5 RID: 3237 RVA: 0x0001B7C8 File Offset: 0x000199C8
			private void Heapsort(int lo, int hi)
			{
				this.DownHeap(lo, hi, lo);
				this.Swap(lo, hi);
				int num = 1;
				this.DownHeap(num, hi, lo);
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x0001B7F4 File Offset: 0x000199F4
			private void DownHeap(int i, int n, int lo)
			{
				Array array = this.items;
				if (array != null)
				{
					object value = array.GetValue(i);
					return;
				}
				IComparer comparer = this.comparer;
			}

			// Token: 0x06000CA7 RID: 3239 RVA: 0x0001B848 File Offset: 0x00019A48
			private void InsertionSort(int lo, int hi)
			{
				Array array = this.items;
				if (array != null)
				{
					object value = array.GetValue(0);
					return;
				}
				IComparer comparer = this.comparer;
			}

			// Token: 0x040004DD RID: 1245
			private Array keys;

			// Token: 0x040004DE RID: 1246
			private Array items;

			// Token: 0x040004DF RID: 1247
			private IComparer comparer;
		}
	}
}
