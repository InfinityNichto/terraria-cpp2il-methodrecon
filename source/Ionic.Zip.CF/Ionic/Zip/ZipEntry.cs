using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2IlInjected;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x0200001D RID: 29
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
	[ComVisible(true)]
	public class ZipEntry
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002E64 File Offset: 0x00001064
		internal bool AttributesIndicateDirectory
		{
			get
			{
				while (this._InternalFileAttrs == 0)
				{
				}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002E7C File Offset: 0x0000107C
		internal void ResetDirEntry()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002E8C File Offset: 0x0000108C
		public string Info
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000A2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Ionic.Zip.ZipEntry::get_Info()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003F:
	stloc:bool(var_9_45, ldfld:bool(ZipEntry::_IsText, ldloc:ZipEntry(this)))
	stloc:string(var_10_56, call:string(string::Format, ldstr:string("         File type: {0}\n"), ldstr:string[exp:object]("         File type: {0}\n")))
	stloc:int64(var_14_5E, ldfld:int64(ZipEntry::_CompressedSize, ldloc:ZipEntry(this)))
	stloc:StringBuilder(var_16_69, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_13), ldloc:string(var_15)))
	stloc:int64(var_17_71, ldfld:int64(ZipEntry::_UncompressedSize, ldloc:ZipEntry(this)))
	stloc:StringBuilder(var_19_7C, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_16_69), ldloc:string(var_18)))
	stloc:int32(var_20_84, ldfld:int32(ZipEntry::_Crc32, ldloc:ZipEntry(this)))
	stloc:StringBuilder(var_22_8F, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_19_7C), ldloc:string(var_21)))
	stloc:uint32(var_23_97, ldfld:uint32(ZipEntry::_diskNumber, ldloc:ZipEntry(this)))
	stloc:int64(var_26_9F, ldfld:int64(ZipEntry::_RelativeOffsetOfLocalHeader, ldloc:ZipEntry(this)))
	stloc:int16(var_29_A7, ldfld:int16(ZipEntry::_BitField, ldloc:ZipEntry(this)))
	stloc:bool(var_32_AF, ldfld:bool(ZipEntry::_sourceIsEncrypted, ldloc:ZipEntry(this)))
	stloc:StringBuilder(var_34_BA, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_31), ldloc:string(var_33)))
	stloc:int32(var_35_C2, ldfld:int32(ZipEntry::_TimeBlob, ldloc:ZipEntry(this)))
	stloc:StringBuilder(var_37_CD, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_34_BA), ldloc:string(var_36)))
	stloc:DateTime(var_38_DA, call:DateTime(SharedUtilities::PackedToDateTime, ldfld:int32(ZipEntry::_TimeBlob, ldloc:ZipEntry(this))))
	stloc:StringBuilder(var_40_E5, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(var_37_CD), ldloc:string(var_39)))
	stloc:bool(var_41_ED, ldfld:bool(ZipEntry::_InputUsesZip64, ldloc:ZipEntry(this)))
	stloc:bool(var_44_FA, call:bool(string::IsNullOrEmpty, ldfld:string(ZipEntry::_Comment, ldloc:ZipEntry(this))))
	stloc:string(var_45_102, ldfld:string(ZipEntry::_Comment, ldloc:ZipEntry(this)))
	stloc:string(var_46_110, call:string(string::Format, ldstr:string("           Comment: {0}\n"), ldloc:string[exp:object](var_45_102)))
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

		// Token: 0x060000A3 RID: 163 RVA: 0x00002FAC File Offset: 0x000011AC
		internal static ZipEntry ReadDirEntry(ZipFile zf, Dictionary<string, object> previouslySeen)
		{
			/*
An exception occurred when decompiling this method (060000A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zip.ZipEntry Ionic.Zip.ZipEntry::ReadDirEntry(Ionic.Zip.ZipFile,System.Collections.Generic.Dictionary`2<System.String,System.Object>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	stloc:DateTime(var_4_23, call:DateTime(SharedUtilities::PackedToDateTime, ldc.i4:int32(-1073741824)))
	stloc:Encoding(var_20_55, callgetter:Encoding(Encoding::get_UTF8))
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

		// Token: 0x060000A4 RID: 164 RVA: 0x00002122 File Offset: 0x00000322
		internal static bool IsNotValidZipDirEntrySig(int signature)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003014 File Offset: 0x00001214
		public ZipEntry()
		{
			this._CompressionMethod = 8;
			this._CompressionLevel = CompressionLevel.Default;
			Encoding encoding = Encoding.GetEncoding("IBM437");
			this.<AlternateEncoding>k__BackingField = encoding;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00003058 File Offset: 0x00001258
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00003068 File Offset: 0x00001268
		public DateTime LastModified
		{
			get
			{
				DateTime dateTime;
				return dateTime;
			}
			set
			{
				DateTimeKind dateTimeKind;
				if (dateTimeKind != DateTimeKind.Unspecified)
				{
					return;
				}
				DateTime dateTime;
				this._LastModified = dateTime;
				DateTime dateTime2 = SharedUtilities.AdjustTime_Reverse(dateTime).ToUniversalTime();
				this._Mtime = dateTime2;
				this._metadataChanged = true;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000309C File Offset: 0x0000129C
		private int BufferSize
		{
			get
			{
				return this._container.BufferSize;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000030B4 File Offset: 0x000012B4
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000030CC File Offset: 0x000012CC
		public DateTime ModifiedTime
		{
			get
			{
				DateTime mtime = this._Mtime;
				DateTime dateTime;
				return dateTime;
			}
			set
			{
				DateTime atime = this._Atime;
				DateTime ctime = this._Ctime;
				this.SetEntryTimes(ctime, atime, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000030F0 File Offset: 0x000012F0
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00003108 File Offset: 0x00001308
		public DateTime AccessedTime
		{
			get
			{
				DateTime atime = this._Atime;
				DateTime dateTime;
				return dateTime;
			}
			set
			{
				DateTime ctime = this._Ctime;
				DateTime mtime = this._Mtime;
				this.SetEntryTimes(ctime, value, mtime);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000312C File Offset: 0x0000132C
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00003144 File Offset: 0x00001344
		public DateTime CreationTime
		{
			get
			{
				DateTime ctime = this._Ctime;
				DateTime dateTime;
				return dateTime;
			}
			set
			{
				DateTime mtime = this._Mtime;
				DateTime atime = this._Atime;
				this.SetEntryTimes(value, atime, mtime);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003168 File Offset: 0x00001368
		public void SetEntryTimes(DateTime created, DateTime accessed, DateTime modified)
		{
			int num = 1;
			this._ntfsTimesAreSet = num != 0;
			if (num == 0)
			{
			}
			DateTime dateTime;
			this._Ctime = dateTime;
			DateTime dateTime2 = dateTime.ToUniversalTime();
			this._Atime = dateTime2;
			DateTime dateTime3 = dateTime2.ToUniversalTime();
			bool emitUnixTimes = this._emitUnixTimes;
			this._LastModified = dateTime3;
			this._Mtime = dateTime3;
			if (!emitUnixTimes && !this._emitNtfsTimes)
			{
				int num2 = 1;
				this._emitNtfsTimes = num2 != 0;
			}
			int num3 = 1;
			this._metadataChanged = num3 != 0;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000031F4 File Offset: 0x000013F4
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			get
			{
				return this._emitNtfsTimes;
			}
			set
			{
				this._metadataChanged = true;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00003208 File Offset: 0x00001408
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000321C File Offset: 0x0000141C
		public bool EmitTimesInUnixFormatWhenSaving
		{
			get
			{
				return this._emitUnixTimes;
			}
			set
			{
				this._metadataChanged = true;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003230 File Offset: 0x00001430
		public ZipEntryTimestamp Timestamp
		{
			get
			{
				return this._timestamp;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003244 File Offset: 0x00001444
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00003258 File Offset: 0x00001458
		public FileAttributes Attributes
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.FileAttributes Ionic.Zip.ZipEntry::get_Attributes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ZipEntry::_ExternalFileAttrs, ldloc:ZipEntry(this)))
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
			set
			{
				this._ExternalFileAttrs = (int)value;
				this._VersionMadeBy = 45;
				this._metadataChanged = true;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000327C File Offset: 0x0000147C
		internal string LocalFileName
		{
			get
			{
				return this._LocalFileName;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003290 File Offset: 0x00001490
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000032A4 File Offset: 0x000014A4
		public string FileName
		{
			get
			{
				return this._FileNameInArchive;
			}
			set
			{
				if (this._container._zf != null)
				{
					string text;
					bool flag = this._FileNameInArchive == text;
					this._container._zf.RemoveEntry(this);
					this._container._zf.InternalAddEntry(text, this);
					ZipContainer container = this._container;
					this._FileNameInArchive = text;
					container._zf._contentsChanged = true;
					this._metadataChanged = true;
					return;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003310 File Offset: 0x00001510
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00003324 File Offset: 0x00001524
		public Stream InputStream
		{
			get
			{
				return this._sourceStream;
			}
			set
			{
				ZipEntrySource source = this._Source;
				this._sourceWasJitProvided = true;
				this._sourceStream = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003348 File Offset: 0x00001548
		public bool InputStreamWasJitProvided
		{
			get
			{
				return this._sourceWasJitProvided;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000335C File Offset: 0x0000155C
		public ZipEntrySource Source
		{
			get
			{
				return this._Source;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00003370 File Offset: 0x00001570
		public short VersionNeeded
		{
			get
			{
				return this._VersionNeeded;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00003384 File Offset: 0x00001584
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00003398 File Offset: 0x00001598
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				this._Comment = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002122 File Offset: 0x00000322
		public bool? RequiresZip64
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002122 File Offset: 0x00000322
		public bool? OutputUsedZip64
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000033AC File Offset: 0x000015AC
		public short BitField
		{
			get
			{
				return this._BitField;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002122 File Offset: 0x00000322
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000033C0 File Offset: 0x000015C0
		public CompressionMethod CompressionMethod
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this._CompressionMethod = (short)value;
				if (this._CompressionLevel == CompressionLevel.None)
				{
					return;
				}
				ZipFile zf = this._container._zf;
				if (zf != null)
				{
					zf._contentsChanged = true;
				}
				this._restreamRequiredOnSave = true;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003404 File Offset: 0x00001604
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00003418 File Offset: 0x00001618
		public CompressionLevel CompressionLevel
		{
			get
			{
				return this._CompressionLevel;
			}
			set
			{
				short compressionMethod = this._CompressionMethod;
				this._CompressionLevel = value;
				if (value == CompressionLevel.None && compressionMethod == 0)
				{
					return;
				}
				ZipFile zf = this._container._zf;
				if (zf != null)
				{
					zf._contentsChanged = true;
				}
				this._restreamRequiredOnSave = true;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003458 File Offset: 0x00001658
		public long CompressedSize
		{
			get
			{
				return this._CompressedSize;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000346C File Offset: 0x0000166C
		public long UncompressedSize
		{
			get
			{
				return this._UncompressedSize;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003480 File Offset: 0x00001680
		public double CompressionRatio
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Ionic.Zip.ZipEntry::get_CompressionRatio()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_0E, ldfld:int64(ZipEntry::_CompressedSize, ldloc:ZipEntry(this)))
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000349C File Offset: 0x0000169C
		public int Crc
		{
			get
			{
				return this._Crc32;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000034B0 File Offset: 0x000016B0
		public bool IsDirectory
		{
			get
			{
				return this._IsDirectory;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000034C4 File Offset: 0x000016C4
		public bool UsesEncryption
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipEntry::get_UsesEncryption()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:EncryptionAlgorithm(var_0_06, ldfld:EncryptionAlgorithm(ZipEntry::_Encryption_FromZipFile, ldloc:ZipEntry(this)))
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000034D8 File Offset: 0x000016D8
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000034EC File Offset: 0x000016EC
		public EncryptionAlgorithm Encryption
		{
			get
			{
				return this._Encryption;
			}
			set
			{
				EncryptionAlgorithm encryption = this._Encryption;
				ZipContainer container = this._container;
				this._Encryption = value;
				this._restreamRequiredOnSave = true;
				ZipFile zf = container._zf;
				if (zf != null)
				{
					zf._contentsChanged = true;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003568 File Offset: 0x00001768
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00003528 File Offset: 0x00001728
		public string Password
		{
			private get
			{
				return this._Password;
			}
			set
			{
				this._Password = value;
				if (value == null)
				{
					return;
				}
				ZipEntrySource source = this._Source;
				if (!this._sourceIsEncrypted)
				{
					this._restreamRequiredOnSave = true;
				}
				if (this._Encryption != EncryptionAlgorithm.None)
				{
					return;
				}
				this._Encryption = EncryptionAlgorithm.PkzipWeak;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000357C File Offset: 0x0000177C
		internal bool IsChanged
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipEntry::get_IsChanged()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(ZipEntry::_restreamRequiredOnSave, ldloc:ZipEntry(this)))
	stloc:bool(var_1_0D, ldfld:bool(ZipEntry::_metadataChanged, ldloc:ZipEntry(this)))
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003598 File Offset: 0x00001798
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000035AC File Offset: 0x000017AC
		public ExtractExistingFileAction ExtractExistingFile
		{
			get
			{
				return this.<ExtractExistingFile>k__BackingField;
			}
			set
			{
				this.<ExtractExistingFile>k__BackingField = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000035C0 File Offset: 0x000017C0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000035D4 File Offset: 0x000017D4
		public ZipErrorAction ZipErrorAction
		{
			get
			{
				return this.<ZipErrorAction>k__BackingField;
			}
			set
			{
				this.<ZipErrorAction>k__BackingField = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000035E8 File Offset: 0x000017E8
		public bool IncludedInMostRecentSave
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000D7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipEntry::get_IncludedInMostRecentSave()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(ZipEntry::_skippedDuringSave, ldloc:ZipEntry(this)))
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000035FC File Offset: 0x000017FC
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00003610 File Offset: 0x00001810
		public SetCompressionCallback SetCompression
		{
			get
			{
				return this.<SetCompression>k__BackingField;
			}
			set
			{
				this.<SetCompression>k__BackingField = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00003624 File Offset: 0x00001824
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000364C File Offset: 0x0000184C
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipEntry::get_UseUnicodeAsNecessary()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_0_06, ldfld:Encoding(ZipEntry::<AlternateEncoding>k__BackingField, ldloc:ZipEntry(this)))
	stloc:Encoding(var_1_11, call:Encoding(Encoding::GetEncoding, ldstr:string("UTF-8")))
	stloc:ZipOption(var_3_1A, ldfld:ZipOption(ZipEntry::<AlternateEncodingUsage>k__BackingField, ldloc:ZipEntry(this)))
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
			set
			{
				Encoding encoding = Encoding.GetEncoding("UTF-8");
				this.<AlternateEncoding>k__BackingField = encoding;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000367C File Offset: 0x0000187C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00003690 File Offset: 0x00001890
		[Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
		public Encoding ProvisionalAlternateEncoding
		{
			get
			{
				return this.<ProvisionalAlternateEncoding>k__BackingField;
			}
			set
			{
				this.<ProvisionalAlternateEncoding>k__BackingField = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000036A4 File Offset: 0x000018A4
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000036B8 File Offset: 0x000018B8
		public Encoding AlternateEncoding
		{
			get
			{
				return this.<AlternateEncoding>k__BackingField;
			}
			set
			{
				this.<AlternateEncoding>k__BackingField = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000036CC File Offset: 0x000018CC
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000036E0 File Offset: 0x000018E0
		public ZipOption AlternateEncodingUsage
		{
			get
			{
				return this.<AlternateEncodingUsage>k__BackingField;
			}
			set
			{
				this.<AlternateEncodingUsage>k__BackingField = value;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000036F4 File Offset: 0x000018F4
		internal static string NameInArchive(string filename, string directoryPathInArchive)
		{
			while (filename == null)
			{
			}
			bool flag = string.IsNullOrEmpty(filename);
			string text;
			return SharedUtilities.NormalizePathForUseInZipFile(Path.Combine(filename, text));
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003718 File Offset: 0x00001918
		internal static ZipEntry CreateFromNothing(string nameInArchive)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000372C File Offset: 0x0000192C
		internal static ZipEntry CreateFromFile(string filename, string nameInArchive)
		{
			if (!true)
			{
			}
			long num = 0L;
			return ZipEntry.Create(filename, ZipEntrySource.FileSystem, nameInArchive, num);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003748 File Offset: 0x00001948
		internal static ZipEntry CreateForStream(string entryName, Stream s)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000375C File Offset: 0x0000195C
		internal static ZipEntry CreateForWriter(string entryName, WriteDelegate d)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003770 File Offset: 0x00001970
		internal static ZipEntry CreateForJitStreamProvider(string nameInArchive, OpenDelegate opener, CloseDelegate closer)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003784 File Offset: 0x00001984
		internal static ZipEntry CreateForZipOutputStream(string nameInArchive)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003798 File Offset: 0x00001998
		private static ZipEntry Create(string nameInArchive, ZipEntrySource source, object arg1, object arg2)
		{
			if (45 == 0)
			{
			}
			DateTime utcNow = DateTime.UtcNow;
			if (source != ZipEntrySource.None)
			{
			}
			DateTime dateTime2;
			DateTime dateTime = dateTime2.ToUniversalTime();
			DateTime dateTime4;
			DateTime dateTime3 = dateTime4.ToUniversalTime();
			DateTime dateTime6;
			DateTime dateTime5 = dateTime6.ToUniversalTime();
			if (source == ZipEntrySource.None || source == ZipEntrySource.None || source != ZipEntrySource.None)
			{
			}
			if (arg1 != null)
			{
			}
			return "The filename must be non-null and non-empty.";
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003834 File Offset: 0x00001A34
		internal void MarkAsDirectory()
		{
			this._IsDirectory = true;
			bool flag = this._FileNameInArchive.EndsWith("/");
			string text = this._FileNameInArchive + "/";
			this._FileNameInArchive = text;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002122 File Offset: 0x00000322
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00003874 File Offset: 0x00001A74
		public bool IsText
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003884 File Offset: 0x00001A84
		public override string ToString()
		{
			string fileNameInArchive = this._FileNameInArchive;
			return string.Format("ZipEntry::{0}", fileNameInArchive);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000038A4 File Offset: 0x00001AA4
		internal Stream ArchiveStream
		{
			get
			{
				Stream outputStream;
				if (this._archiveStream == null)
				{
					ZipContainer container = this._container;
					ZipFile zf = container._zf;
					if (zf != null)
					{
						long num = 0L;
						zf.Reset(num != 0L);
						uint diskNumber = this._diskNumber;
						return zf.StreamForDiskNumber(diskNumber);
					}
					outputStream = container._zos._outputStream;
					this._archiveStream = outputStream;
				}
				return outputStream;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000038FC File Offset: 0x00001AFC
		private void SetFdpLoh()
		{
			Stream archiveStream = this.ArchiveStream;
			Stream archiveStream2 = this.ArchiveStream;
			long relativeOffsetOfLocalHeader = this._RelativeOffsetOfLocalHeader;
			Stream archiveStream3 = this.ArchiveStream;
			Stream archiveStream4 = this.ArchiveStream;
			Stream archiveStream5 = this.ArchiveStream;
			Stream archiveStream6 = this.ArchiveStream;
			int lengthOfCryptoHeaderBytes = ZipEntry.GetLengthOfCryptoHeaderBytes(this._Encryption_FromZipFile);
			long relativeOffsetOfLocalHeader2 = this._RelativeOffsetOfLocalHeader;
			this.__FileDataPosition = relativeOffsetOfLocalHeader2;
			Stream archiveStream7 = this.ArchiveStream;
			Stream archiveStream8 = this.ArchiveStream;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000398C File Offset: 0x00001B8C
		internal static int GetLengthOfCryptoHeaderBytes(EncryptionAlgorithm a)
		{
			return 12;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000399C File Offset: 0x00001B9C
		internal long FileDataPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (060000F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipEntry::get_FileDataPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_0_06, ldfld:int64(ZipEntry::__FileDataPosition, ldloc:ZipEntry(this)))
	call:void(ZipEntry::SetFdpLoh, ldloc:ZipEntry(this))
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000039B8 File Offset: 0x00001BB8
		private int LengthOfHeader
		{
			get
			{
				int lengthOfHeader = this._LengthOfHeader;
				if (lengthOfHeader == 0)
				{
				}
				return lengthOfHeader;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000039D0 File Offset: 0x00001BD0
		public void Extract()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000039E0 File Offset: 0x00001BE0
		public void Extract(ExtractExistingFileAction extractExistingFile)
		{
			this.<ExtractExistingFile>k__BackingField = extractExistingFile;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000039F4 File Offset: 0x00001BF4
		public void Extract(Stream stream)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003A04 File Offset: 0x00001C04
		public void Extract(string baseDirectory)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003A14 File Offset: 0x00001C14
		public void Extract(string baseDirectory, ExtractExistingFileAction extractExistingFile)
		{
			this.<ExtractExistingFile>k__BackingField = extractExistingFile;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003A28 File Offset: 0x00001C28
		public void ExtractWithPassword(string password)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003A38 File Offset: 0x00001C38
		public void ExtractWithPassword(string baseDirectory, string password)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003A48 File Offset: 0x00001C48
		public void ExtractWithPassword(ExtractExistingFileAction extractExistingFile, string password)
		{
			this.<ExtractExistingFile>k__BackingField = extractExistingFile;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003A5C File Offset: 0x00001C5C
		public void ExtractWithPassword(string baseDirectory, ExtractExistingFileAction extractExistingFile, string password)
		{
			this.<ExtractExistingFile>k__BackingField = extractExistingFile;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003A70 File Offset: 0x00001C70
		public void ExtractWithPassword(Stream stream, string password)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003A80 File Offset: 0x00001C80
		public CrcCalculatorStream OpenReader()
		{
			ZipContainer container;
			do
			{
				container = this._container;
			}
			while (container._zf == null);
			string password;
			if (this._Password == null)
			{
				password = container.Password;
			}
			return this.InternalOpenReader(password);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003AB4 File Offset: 0x00001CB4
		public CrcCalculatorStream OpenReader(string password)
		{
			while (this._container._zf == null)
			{
			}
			return this.InternalOpenReader(password);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003AD8 File Offset: 0x00001CD8
		internal CrcCalculatorStream InternalOpenReader(string password)
		{
			/*
An exception occurred when decompiling this method (060000FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Crc.CrcCalculatorStream Ionic.Zip.ZipEntry::InternalOpenReader(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0054:
	stloc:Stream(var_7_5B, call:Stream(ZipEntry::GetExtractDecryptor, ldloc:ZipEntry(this), ldloc:Stream(var_2_27)))
	stfld:Stream(ZipEntry::_inputDecryptorStream, ldloc:ZipEntry(this), ldloc:Stream(var_7_5B))
	stloc:Stream(var_8_6D, call:Stream(ZipEntry::GetExtractDecompressor, ldloc:ZipEntry(this), ldloc:Stream(var_7_5B)))
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

		// Token: 0x06000100 RID: 256 RVA: 0x00003B54 File Offset: 0x00001D54
		private void OnExtractProgress(long bytesWritten, long totalBytesToWrite)
		{
			ZipContainer container = this._container;
			ZipFile zf = container._zf;
			if (zf != null)
			{
				bool flag = zf.OnExtractBlock(this, bytesWritten, totalBytesToWrite);
				this._ioOperationCanceled = container != null;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003B84 File Offset: 0x00001D84
		private void OnBeforeExtract(string path)
		{
			ZipFile zf = this._container._zf;
			if (zf != null)
			{
				bool inExtractAll = zf._inExtractAll;
				if (!inExtractAll)
				{
					bool flag = zf.OnSingleEntryExtract(this, path, true);
					this._ioOperationCanceled = inExtractAll;
				}
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003BBC File Offset: 0x00001DBC
		private void OnAfterExtract(string path)
		{
			ZipFile zf = this._container._zf;
			if (zf == null || zf._inExtractAll)
			{
				return;
			}
			long num = 0L;
			bool flag = zf.OnSingleEntryExtract(this, path, num != 0L);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003BF0 File Offset: 0x00001DF0
		private void OnExtractExisting(string path)
		{
			ZipContainer container = this._container;
			ZipFile zf = container._zf;
			if (zf != null)
			{
				bool flag = zf.OnExtractExisting(this, path);
				this._ioOperationCanceled = container != null;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003C20 File Offset: 0x00001E20
		private static void ReallyDelete(string fileName)
		{
			uint attributes = NetCfFile.GetAttributes(fileName);
			bool flag = NetCfFile.SetAttributes(fileName, (uint)128);
			File.Delete(fileName);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003C48 File Offset: 0x00001E48
		private void WriteStatus(string format, params object[] args)
		{
			ZipFile zf = this._container._zf;
			if (zf != null && zf._StatusMessageTextWriter != null)
			{
				return;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003C70 File Offset: 0x00001E70
		private void InternalExtract(string baseDir, Stream outstream, string password)
		{
			ZipContainer container = this._container;
			if (container == null)
			{
				return;
			}
			ZipFile zf = container._zf;
			if (zf == null)
			{
				return;
			}
			long num = 0L;
			zf.Reset(num != 0L);
			ZipEntrySource source = this._Source;
			this.OnBeforeExtract(baseDir);
			this.ValidateCompression();
			this.ValidateEncryption();
			bool flag = this.ValidateOutput(baseDir, outstream, password);
			if (password != null && password == null)
			{
				throw new ArrayTypeMismatchException();
			}
			ZipFile zf2 = this._container._zf;
			if (zf2 != null)
			{
				ZipFile zf3;
				if (zf2._StatusMessageTextWriter != null)
				{
					zf3 = this._container._zf;
					if (zf3 == null)
					{
						goto IL_0098;
					}
				}
				if (!zf3._inExtractAll)
				{
					long num2 = 0L;
					bool flag2 = zf3.OnSingleEntryExtract(this, baseDir, num2 != 0L);
				}
			}
			IL_0098:
			if (!this._ioOperationCanceled)
			{
				return;
			}
			long num3;
			if (this == null || num3 == 0L)
			{
			}
			long num4;
			if (num4 == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003F68 File Offset: 0x00002168
		internal void VerifyCrcAfterExtract(int actualCrc32)
		{
			int crc = this._Crc32;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003F88 File Offset: 0x00002188
		private int CheckExtractExistingFile(string baseDir, string targetFileName)
		{
			do
			{
				long num = 0L;
				ExtractExistingFileAction extractExistingFileAction = this.<ExtractExistingFile>k__BackingField;
				if (num != 0L)
				{
					goto IL_00A1;
				}
				ZipFile zf = this._container._zf;
				if (zf != null)
				{
					bool flag = zf.OnExtractExisting(this, baseDir);
					this._ioOperationCanceled = extractExistingFileAction != ExtractExistingFileAction.Throw;
				}
			}
			while (!this._ioOperationCanceled);
			return 2;
			IL_00A1:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000403C File Offset: 0x0000223C
		private void _CheckRead(int nbytes)
		{
			/*
An exception occurred when decompiling this method (06000109)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.Zip.ZipEntry::_CheckRead(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0004:
	stloc:string(var_0_0A, ldfld:string(ZipEntry::_FileNameInArchive, ldloc:ZipEntry(this)))
	stloc:string(var_1_16, call:string(string::Format, ldstr:string("bad read of entry {0} from compressed archive."), ldloc:string[exp:object](var_0_0A)))
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

		// Token: 0x0600010A RID: 266 RVA: 0x00004060 File Offset: 0x00002260
		private int ExtractOne(Stream output)
		{
			Stream archiveStream;
			int num;
			do
			{
				archiveStream = this.ArchiveStream;
				long _FileDataPosition = this.__FileDataPosition;
				this.SetFdpLoh();
				long _FileDataPosition2 = this.__FileDataPosition;
				int bufferSize = this._container.BufferSize;
				short compressionMethod_FromZipFile = this._CompressionMethod_FromZipFile;
				num = 160;
				Stream extractDecryptor = this.GetExtractDecryptor(archiveStream);
				this._inputDecryptorStream = extractDecryptor;
				Stream extractDecompressor = this.GetExtractDecompressor(extractDecryptor);
				long num2 = 0L;
				this._CheckRead(42169232);
				ZipContainer container = this._container;
				ZipFile zf = container._zf;
				if (zf != null)
				{
					long uncompressedSize = this._UncompressedSize;
					bool flag = zf.OnExtractBlock(this, num2, uncompressedSize);
					this._ioOperationCanceled = container != null;
				}
			}
			while (!this._ioOperationCanceled);
			long num3 = 0L;
			if (42169232 != 0)
			{
				if (num != 0)
				{
				}
				return 42169232;
			}
			if (num3 != 0L)
			{
				throw new OutOfMemoryException();
			}
			long num4 = 0L;
			if (archiveStream != null)
			{
			}
			if (num4 == 0L)
			{
				int num5;
				return num5;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004170 File Offset: 0x00002370
		internal Stream GetExtractDecompressor(Stream input2)
		{
			while (this._CompressionMethod_FromZipFile == 0)
			{
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004188 File Offset: 0x00002388
		internal Stream GetExtractDecryptor(Stream input)
		{
			/*
An exception occurred when decompiling this method (0600010C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream Ionic.Zip.ZipEntry::GetExtractDecryptor(System.IO.Stream)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:EncryptionAlgorithm(var_0_06, ldfld:EncryptionAlgorithm(ZipEntry::_Encryption_FromZipFile, ldloc:ZipEntry(this)))
	stloc:ZipCrypto(var_1_0D, ldfld:ZipCrypto(ZipEntry::_zipCrypto_forExtract, ldloc:ZipEntry(this)))
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

		// Token: 0x0600010D RID: 269 RVA: 0x000041A4 File Offset: 0x000023A4
		internal void _SetTimes(string fileOrDirectory, bool isFile)
		{
			if (this._ntfsTimesAreSet)
			{
				DateTime atime = this._Atime;
				DateTime ctime = this._Ctime;
				DateTime mtime = this._Mtime;
				if (NetCfFile.SetTimes(fileOrDirectory, ctime, atime, mtime) != 0)
				{
					string fileNameInArchive = this._FileNameInArchive;
					if (fileNameInArchive != null && fileNameInArchive == null)
					{
						throw new ArrayTypeMismatchException();
					}
					if (fileOrDirectory != null && fileOrDirectory == null)
					{
						throw new ArrayTypeMismatchException();
					}
					ZipFile zf = this._container._zf;
					if (zf != null && zf._StatusMessageTextWriter != null)
					{
						return;
					}
				}
			}
			else
			{
				DateTime dateTime2;
				DateTime dateTime = SharedUtilities.AdjustTime_Reverse(dateTime2);
				if (NetCfFile.SetLastWriteTime(fileOrDirectory, dateTime) != 0)
				{
					string fileNameInArchive2 = this._FileNameInArchive;
					if (fileNameInArchive2 != null && fileNameInArchive2 == null)
					{
						throw new ArrayTypeMismatchException();
					}
					if (fileOrDirectory != null && fileOrDirectory == null)
					{
						throw new ArrayTypeMismatchException();
					}
					ZipFile zf2 = this._container._zf;
					if (zf2 == null || zf2._StatusMessageTextWriter != null)
					{
					}
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000042C0 File Offset: 0x000024C0
		private string UnsupportedAlgorithm
		{
			get
			{
				uint unsupportedAlgorithmId = this._UnsupportedAlgorithmId;
				if (unsupportedAlgorithmId != 0U)
				{
					return "RC2";
				}
				return "Blowfish";
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00004344 File Offset: 0x00002544
		private string UnsupportedCompressionMethod
		{
			get
			{
				return "PPMd";
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004388 File Offset: 0x00002588
		internal void ValidateEncryption()
		{
			EncryptionAlgorithm encryption = this._Encryption;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000043BC File Offset: 0x000025BC
		private void ValidateCompression()
		{
			short compressionMethod_FromZipFile = this._CompressionMethod_FromZipFile;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000043E0 File Offset: 0x000025E0
		private void SetupCryptoForExtract(string password)
		{
			do
			{
				EncryptionAlgorithm encryption_FromZipFile = this._Encryption_FromZipFile;
			}
			while (password == null);
			Stream archiveStream = this.ArchiveStream;
			long _FileDataPosition = this.__FileDataPosition;
			this.SetFdpLoh();
			long _FileDataPosition2 = this.__FileDataPosition;
			Stream archiveStream2 = this.ArchiveStream;
			ZipCrypto zipCrypto = ZipCrypto.ForRead(password, this);
			this._zipCrypto_forExtract = zipCrypto;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000442C File Offset: 0x0000262C
		private bool ValidateOutput(string basedir, Stream outstream, [Out] string outFileName)
		{
			string fileName;
			while (basedir == null)
			{
				if (fileName != null)
				{
					return this._IsDirectory || this._FileNameInArchive.EndsWith("/");
				}
			}
			string text = this._FileNameInArchive.Replace("\\", "/").Substring(2);
			bool flag = text.StartsWith("/");
			string text2 = text.Substring(1);
			bool <FlattenFoldersOnExtract>k__BackingField = this._container._zf.<FlattenFoldersOnExtract>k__BackingField;
			if (<FlattenFoldersOnExtract>k__BackingField)
			{
				if (!<FlattenFoldersOnExtract>k__BackingField)
				{
				}
				fileName = Path.GetFileName(text2);
			}
			if (!<FlattenFoldersOnExtract>k__BackingField)
			{
			}
			string text3 = Path.Combine(basedir, fileName).Replace("/", "\\");
			if (!this._IsDirectory)
			{
				bool flag2 = this._FileNameInArchive.EndsWith("/");
			}
			ExtractExistingFileAction extractExistingFileAction = this.<ExtractExistingFile>k__BackingField;
			bool flag3;
			return flag3;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000044F8 File Offset: 0x000026F8
		private void ReadExtraField()
		{
			int readExtraDepth = this._readExtraDepth;
			this._readExtraDepth = readExtraDepth;
			Stream archiveStream = this.ArchiveStream;
			Stream archiveStream2 = this.ArchiveStream;
			long relativeOffsetOfLocalHeader = this._RelativeOffsetOfLocalHeader;
			Stream archiveStream3 = this.ArchiveStream;
			Stream archiveStream4 = this.ArchiveStream;
			Stream archiveStream5 = this.ArchiveStream;
			Stream archiveStream6 = this.ArchiveStream;
			Stream archiveStream7 = this.ArchiveStream;
			Stream archiveStream8 = this.ArchiveStream;
			Stream archiveStream9 = this.ArchiveStream;
			int readExtraDepth2 = this._readExtraDepth;
			this._readExtraDepth = readExtraDepth2;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004574 File Offset: 0x00002774
		private static bool ReadHeader(ZipEntry ze, Encoding defaultEncoding)
		{
			Stream stream;
			int num = SharedUtilities.ReadEntrySignature(stream);
			DateTime dateTime = SharedUtilities.PackedToDateTime(-1073741824);
			int num2 = 1;
			if (num2 == 0)
			{
			}
			Encoding utf = Encoding.UTF8;
			Stream stream2;
			if (stream2 != null)
			{
			}
			if (num2 == 0)
			{
			}
			if (-1073741824 != 0)
			{
				return;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002122 File Offset: 0x00000322
		internal static int ReadWeakEncryptionHeader(Stream s, byte[] buffer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002122 File Offset: 0x00000322
		private static bool IsNotValidSig(int signature)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000045E4 File Offset: 0x000027E4
		internal static ZipEntry ReadEntry(ZipContainer zc, bool first)
		{
			int num = 3;
			if (num == 0)
			{
			}
			Stream stream;
			ZipEntry.HandlePK00Prefix(stream);
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004604 File Offset: 0x00002804
		internal static void HandlePK00Prefix(Stream s)
		{
			if (!true)
			{
			}
			int num = SharedUtilities.ReadInt(s);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000461C File Offset: 0x0000281C
		private static void HandleUnexpectedDataDescriptor(ZipEntry entry)
		{
			Stream archiveStream = entry.ArchiveStream;
			int num = SharedUtilities.ReadInt(archiveStream);
			int num2 = SharedUtilities.ReadInt(archiveStream);
			if (entry._CompressedSize == 0L)
			{
			}
			int num3 = SharedUtilities.ReadInt(archiveStream);
			long uncompressedSize = entry._UncompressedSize;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002122 File Offset: 0x00000322
		internal static int FindExtraFieldSegment(byte[] extra, int offx, ushort targetHeaderId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004658 File Offset: 0x00002858
		internal int ProcessExtraField(Stream s, short extraFieldLength)
		{
			int num;
			return num;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002122 File Offset: 0x00000322
		private int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004680 File Offset: 0x00002880
		private int ProcessExtraFieldZip64(byte[] buffer, int j, short dataSize, long posn)
		{
			/*
An exception occurred when decompiling this method (0600011E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zip.ZipEntry::ProcessExtraFieldZip64(System.Byte[],System.Int32,System.Int16,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:bool(ZipEntry::_InputUsesZip64, ldloc:ZipEntry(this), ldc.i4:bool(1))
	stloc:int64(var_0_0D, ldfld:int64(ZipEntry::_UncompressedSize, ldloc:ZipEntry(this)))
	stloc:int64(var_1_14, ldfld:int64(ZipEntry::_CompressedSize, ldloc:ZipEntry(this)))
	stloc:int64(var_2_1B, ldfld:int64(ZipEntry::_RelativeOffsetOfLocalHeader, ldloc:ZipEntry(this)))
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

		// Token: 0x0600011F RID: 287 RVA: 0x000046A8 File Offset: 0x000028A8
		private int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			/*
An exception occurred when decompiling this method (0600011F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zip.ZipEntry::ProcessExtraFieldInfoZipTimes(System.Byte[],System.Int32,System.Int16,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_2_03, ldc.i4:int64(0))
	stfld:DateTime(ZipEntry::_Mtime, ldloc:ZipEntry(this), ldloc:DateTime(var_3))
	stloc:int32(var_4_12, call:int32(BitConverter::ToInt32, ldloc:uint8[](buffer), ldloc:int64[exp:int32](var_2_03)))
	stfld:DateTime(ZipEntry::_Atime, ldloc:ZipEntry(this), ldloc:DateTime(var_5))
	stloc:DateTime(var_7_24, callgetter:DateTime(DateTime::get_UtcNow))
	stloc:ZipEntryTimestamp(var_8_2C, ldfld:ZipEntryTimestamp(ZipEntry::_timestamp, ldloc:ZipEntry(this)))
	stloc:int32(var_9_2F, ldc.i4:int32(1))
	stfld:DateTime(ZipEntry::_Ctime, ldloc:ZipEntry(this), ldloc:DateTime(var_7_24))
	stfld:bool(ZipEntry::_ntfsTimesAreSet, ldloc:ZipEntry(this), ldloc:int32[exp:bool](var_9_2F))
	stfld:ZipEntryTimestamp(ZipEntry::_timestamp, ldloc:ZipEntry(this), ldloc:ZipEntryTimestamp(var_8_2C))
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

		// Token: 0x06000120 RID: 288 RVA: 0x00004700 File Offset: 0x00002900
		private int ProcessExtraFieldUnixTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			/*
An exception occurred when decompiling this method (06000120)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zip.ZipEntry::ProcessExtraFieldUnixTimes(System.Byte[],System.Int32,System.Int16,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:DateTime(var_5_26, callgetter:DateTime(DateTime::get_UtcNow))
	stloc:ZipEntryTimestamp(var_6_2E, ldfld:ZipEntryTimestamp(ZipEntry::_timestamp, ldloc:ZipEntry(this)))
	stloc:int32(var_7_31, ldc.i4:int32(1))
	stfld:DateTime(ZipEntry::_Ctime, ldloc:ZipEntry(this), ldloc:DateTime(var_5_26))
	stfld:bool(ZipEntry::_ntfsTimesAreSet, ldloc:ZipEntry(this), ldloc:int32[exp:bool](var_7_31))
	stfld:ZipEntryTimestamp(ZipEntry::_timestamp, ldloc:ZipEntry(this), ldloc:ZipEntryTimestamp(var_6_2E))
	stfld:bool(ZipEntry::_emitUnixTimes, ldloc:ZipEntry(this), ldloc:int32[exp:bool](var_7_31))
	call:void(ZipEntry::ReadExtraField, ldloc:ZipEntry(this))
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

		// Token: 0x06000121 RID: 289 RVA: 0x00004768 File Offset: 0x00002968
		private int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			/*
An exception occurred when decompiling this method (06000121)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zip.ZipEntry::ProcessExtraFieldWindowsTimes(System.Byte[],System.Int32,System.Int16,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_0A, call:int64(BitConverter::ToInt64, ldloc:uint8[](buffer), ldloc:int64[exp:int32](posn)))
	stloc:int64(var_2_0C, ldc.i4:int64(0))
	stloc:DateTime(var_3_13, call:DateTime(DateTime::FromFileTimeUtc, ldloc:int64(var_1_0A)))
	stfld:DateTime(ZipEntry::_Mtime, ldloc:ZipEntry(this), ldloc:DateTime(var_3_13))
	stloc:int64(var_4_22, call:int64(BitConverter::ToInt64, ldloc:uint8[](buffer), ldloc:int64[exp:int32](var_2_0C)))
	stloc:int64(var_5_25, ldc.i4:int64(0))
	stloc:DateTime(var_6_2E, call:DateTime(DateTime::FromFileTimeUtc, ldloc:int64(var_4_22)))
	stfld:DateTime(ZipEntry::_Atime, ldloc:ZipEntry(this), ldloc:DateTime(var_6_2E))
	stloc:DateTime(var_7_45, call:DateTime(DateTime::FromFileTimeUtc, call:int64(BitConverter::ToInt64, ldloc:uint8[](buffer), ldloc:int64[exp:int32](var_5_25))))
	stloc:ZipEntryTimestamp(var_8_4D, ldfld:ZipEntryTimestamp(ZipEntry::_timestamp, ldloc:ZipEntry(this)))
	stloc:int32(var_9_54, ldc.i4:int32(257))
	stfld:DateTime(ZipEntry::_Ctime, ldloc:ZipEntry(this), ldloc:DateTime(var_7_45))
	stfld:bool(ZipEntry::_ntfsTimesAreSet, ldloc:ZipEntry(this), ldloc:int32[exp:bool](var_9_54))
	stfld:ZipEntryTimestamp(ZipEntry::_timestamp, ldloc:ZipEntry(this), ldloc:ZipEntryTimestamp(var_8_4D))
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

		// Token: 0x06000122 RID: 290 RVA: 0x00002122 File Offset: 0x00000322
		internal void WriteCentralDirectoryEntry(Stream s)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002122 File Offset: 0x00000322
		private byte[] ConstructExtraField(bool forCentralDirectory)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000047E4 File Offset: 0x000029E4
		private string NormalizeFileName()
		{
			string text = this._FileNameInArchive.Replace("\\", "/");
			if (this._TrimVolumeFromFullyQualifiedPaths)
			{
				string fileNameInArchive = this._FileNameInArchive;
				int stringLength = fileNameInArchive._stringLength;
				int num = 1;
				char c = fileNameInArchive[num];
				int num2 = 2;
				char c2 = text[num2];
			}
			int stringLength2 = this._FileNameInArchive._stringLength;
			long num3 = 0L;
			char c3 = text[(int)num3];
			int num4 = 1;
			char c4 = text[num4];
			int num5 = 47;
			int num6 = 2;
			int num7 = text.IndexOf((char)num5, num6);
			int stringLength3 = this._FileNameInArchive._stringLength;
			long num8 = 0L;
			char c5 = text[(int)num8];
			int num9 = 1;
			char c6 = text[num9];
			int num10 = 2;
			return text.Substring(num10);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000048A4 File Offset: 0x00002AA4
		private byte[] GetEncodedFileNameBytes()
		{
			/*
An exception occurred when decompiling this method (06000125)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Ionic.Zip.ZipEntry::GetEncodedFileNameBytes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00C7:
	stloc:string(var_15_CD, ldfld:string(ZipEntry::_Comment, ldloc:ZipEntry(this)))
	stloc:Encoding(var_17_D5, ldfld:Encoding(ZipEntry::<AlternateEncoding>k__BackingField, ldloc:ZipEntry(this)))
	stloc:Encoding(var_18_DD, ldfld:Encoding(ZipEntry::<AlternateEncoding>k__BackingField, ldloc:ZipEntry(this)))
	stloc:string(var_19_E5, ldfld:string(ZipEntry::_Comment, ldloc:ZipEntry(this)))
	stloc:Encoding(var_20_ED, ldfld:Encoding(ZipEntry::<AlternateEncoding>k__BackingField, ldloc:ZipEntry(this)))
	stfld:uint8[](ZipEntry::_CommentBytes, ldloc:ZipEntry(this), ldloc:Encoding[exp:uint8[]](var_18_DD))
	stfld:Encoding(ZipEntry::_actualEncoding, ldloc:ZipEntry(this), ldloc:Encoding(var_20_ED))
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

		// Token: 0x06000126 RID: 294 RVA: 0x000049B0 File Offset: 0x00002BB0
		private bool WantReadAgain()
		{
			long uncompressedSize = this._UncompressedSize;
			if (this._CompressionMethod != 0 && this._CompressionLevel != CompressionLevel.None)
			{
				long compressedSize = this._CompressedSize;
				ZipEntrySource source = this._Source;
				Stream sourceStream = this._sourceStream;
				if (this._zipCrypto_forWrite != null)
				{
					long compressedSize2 = this._CompressedSize;
					long uncompressedSize2 = this._UncompressedSize;
				}
				return;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004A08 File Offset: 0x00002C08
		private void MaybeUnsetCompressionMethodForWriting(int cycle)
		{
			while (!this._IsDirectory)
			{
				ZipEntrySource source = this._Source;
				if (this._sourceStream != null && this._sourceStream == null)
				{
					return;
				}
				SetCompressionCallback setCompressionCallback = this.<SetCompression>k__BackingField;
				if (setCompressionCallback != null)
				{
					string localFileName = this._LocalFileName;
					string fileNameInArchive = this._FileNameInArchive;
					IntPtr invoke_impl = setCompressionCallback.invoke_impl;
					IntPtr method_code = setCompressionCallback.method_code;
					IntPtr method = setCompressionCallback.method;
				}
				if (this._CompressionLevel == CompressionLevel.None)
				{
					short compressionMethod = this._CompressionMethod;
					return;
				}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004A84 File Offset: 0x00002C84
		internal void WriteHeader(Stream s, int cycle)
		{
			this._future_ROLH = s;
			Zip64Option zip = this._container.Zip64;
			int num = 1;
			this._presumeZip64 = num != 0;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004C64 File Offset: 0x00002E64
		private int FigureCrc32()
		{
			if (!this._crcCalculated)
			{
				if (this._Source == ZipEntrySource.None)
				{
				}
				WriteDelegate writeDelegate = this._WriteDelegate;
				string fileNameInArchive = this._FileNameInArchive;
				IntPtr invoke_impl = writeDelegate.invoke_impl;
				IntPtr method_code = writeDelegate.method_code;
				IntPtr method = writeDelegate.method;
				int num;
				this._Crc32 = num;
				return num;
			}
			return this._Crc32;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004D2C File Offset: 0x00002F2C
		private void PrepSourceStream()
		{
			while (this._sourceStream == null)
			{
			}
			if (this._sourceStreamOriginalPosition != null)
			{
				return;
			}
			Stream sourceStream = this._sourceStream;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004D54 File Offset: 0x00002F54
		internal void CopyMetaData(ZipEntry source)
		{
			long _FileDataPosition = source.__FileDataPosition;
			this.__FileDataPosition = _FileDataPosition;
			short compressionMethod_FromZipFile = source._CompressionMethod_FromZipFile;
			this._CompressionMethod_FromZipFile = compressionMethod_FromZipFile;
			short bitField = source._BitField;
			this._BitField = bitField;
			ZipEntrySource source2 = source._Source;
			this._Source = source2;
			DateTime lastModified = source._LastModified;
			this._LastModified = lastModified;
			DateTime mtime = source._Mtime;
			this._Mtime = mtime;
			DateTime atime = source._Atime;
			this._Atime = atime;
			DateTime ctime = source._Ctime;
			this._Ctime = ctime;
			bool ntfsTimesAreSet = source._ntfsTimesAreSet;
			this._ntfsTimesAreSet = ntfsTimesAreSet;
			bool emitUnixTimes = source._emitUnixTimes;
			this._emitUnixTimes = emitUnixTimes;
			bool emitNtfsTimes = source._emitNtfsTimes;
			this._emitNtfsTimes = emitNtfsTimes;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004E0C File Offset: 0x0000300C
		private void OnWriteBlock(long bytesXferred, long totalBytesToXfer)
		{
			ZipContainer container = this._container;
			ZipFile zf = container._zf;
			if (zf != null)
			{
				bool flag = zf.OnSaveBlock(this, bytesXferred, totalBytesToXfer);
				this._ioOperationCanceled = container != null;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004E3C File Offset: 0x0000303C
		private void _WriteEntryData(Stream s)
		{
			long num = this.SetInputAndFigureFileLength(s);
			if (num != 0L)
			{
				return;
			}
			ZipEntrySource source = this._Source;
			WriteDelegate writeDelegate = this._WriteDelegate;
			string fileNameInArchive = this._FileNameInArchive;
			IntPtr method_code = writeDelegate.method_code;
			IntPtr invoke_impl = writeDelegate.invoke_impl;
			IntPtr method = writeDelegate.method;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004F9C File Offset: 0x0000319C
		private long SetInputAndFigureFileLength(Stream input)
		{
			/*
An exception occurred when decompiling this method (0600012E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Ionic.Zip.ZipEntry::SetInputAndFigureFileLength(System.IO.Stream)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0097:
	stfld:Stream(ZipEntry::_sourceStream, ldloc:ZipEntry(this), ldloc:CrcCalculatorStream[exp:Stream](var_14))
	call:void(ZipEntry::PrepSourceStream, ldloc:ZipEntry(this))
	stloc:Stream(var_15_AB, ldfld:Stream(ZipEntry::_sourceStream, ldloc:ZipEntry(this)))
	stloc:Stream(var_16_B3, ldfld:Stream(ZipEntry::_sourceStream, ldloc:ZipEntry(this)))
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

		// Token: 0x0600012F RID: 303 RVA: 0x00005064 File Offset: 0x00003264
		internal void FinishOutputStream(Stream s, CountingStream entryCounter, Stream encryptor, Stream compressor, CrcCalculatorStream output)
		{
			if (output != null)
			{
				if (compressor != null)
				{
				}
				long totalBytesSlurped = output.TotalBytesSlurped;
				this._UncompressedSize = totalBytesSlurped;
				long bytesWritten = entryCounter._bytesWritten;
				this._CompressedSize = bytesWritten;
				this._CompressedFileDataSize = bytesWritten;
				int crc = output.Crc;
				long future_ROLH = this._future_ROLH;
				this._Crc32 = crc;
				this._RelativeOffsetOfLocalHeader = future_ROLH;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002122 File Offset: 0x00000322
		internal void PostProcessOutput(Stream s)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002122 File Offset: 0x00000322
		private void SetZip64Flags()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000050BC File Offset: 0x000032BC
		internal void PrepOutputStream(Stream s, long streamLength, [Out] CountingStream outputCounter, [Out] Stream encryptor, [Out] Stream compressor, [Out] CrcCalculatorStream output)
		{
			if (streamLength != 0L)
			{
				Stream stream2;
				Stream stream = this.MaybeApplyCompression(stream2, streamLength);
				return;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000050D8 File Offset: 0x000032D8
		private Stream MaybeApplyCompression(Stream s, long streamLength)
		{
			/*
An exception occurred when decompiling this method (06000133)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream Ionic.Zip.ZipEntry::MaybeApplyCompression(System.IO.Stream,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_1A, callgetter:int32(ZipContainer::get_CodecBufferSize, ldfld:ZipContainer(ZipEntry::_container, ldloc:ZipEntry(this))))
	stloc:int32(var_2_26, callgetter:int32(ZipContainer::get_CodecBufferSize, ldfld:ZipContainer(ZipEntry::_container, ldloc:ZipEntry(this))))
	stloc:CompressionStrategy(var_3_32, callgetter:CompressionStrategy(ZipContainer::get_Strategy, ldfld:ZipContainer(ZipEntry::_container, ldloc:ZipEntry(this))))
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

		// Token: 0x06000134 RID: 308 RVA: 0x00005118 File Offset: 0x00003318
		private Stream MaybeApplyEncryption(Stream s)
		{
			/*
An exception occurred when decompiling this method (06000134)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream Ionic.Zip.ZipEntry::MaybeApplyEncryption(System.IO.Stream)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:EncryptionAlgorithm(var_0_06, ldfld:EncryptionAlgorithm(ZipEntry::_Encryption, ldloc:ZipEntry(this)))
	stloc:ZipCrypto(var_1_0D, ldfld:ZipCrypto(ZipEntry::_zipCrypto_forWrite, ldloc:ZipEntry(this)))
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

		// Token: 0x06000135 RID: 309 RVA: 0x00005134 File Offset: 0x00003334
		private void OnZipErrorWhileSaving(Exception e)
		{
			ZipContainer container = this._container;
			ZipFile zf = container._zf;
			if (zf != null)
			{
				bool flag = zf.OnZipErrorSaving(this, e);
				this._ioOperationCanceled = container != null;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002122 File Offset: 0x00000322
		internal void Write(Stream s)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005164 File Offset: 0x00003364
		internal void StoreRelativeOffset()
		{
			long future_ROLH = this._future_ROLH;
			this._RelativeOffsetOfLocalHeader = future_ROLH;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00005180 File Offset: 0x00003380
		internal void NotifySaveComplete()
		{
			EncryptionAlgorithm encryption = this._Encryption;
			short compressionMethod = this._CompressionMethod;
			this._Encryption_FromZipFile = encryption;
			this._CompressionMethod_FromZipFile = compressionMethod;
			this._Source = ZipEntrySource.ZipFile;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000051B0 File Offset: 0x000033B0
		internal void WriteSecurityMetadata(Stream outstream)
		{
			if (this._Encryption == EncryptionAlgorithm.None)
			{
				return;
			}
			string password;
			if (this._Password == null)
			{
				ZipEntrySource source = this._Source;
				password = this._container.Password;
			}
			if (password != null)
			{
				EncryptionAlgorithm encryption = this._Encryption;
				ZipCrypto zipCrypto = ZipCrypto.ForWrite(password);
				this._zipCrypto_forWrite = zipCrypto;
				short bitField = this._BitField;
				int num = this.FigureCrc32();
				return;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002122 File Offset: 0x00000322
		private void CopyThroughOneEntry(Stream outStream)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005238 File Offset: 0x00003438
		private void CopyThroughWithRecompute(Stream outstream)
		{
			long num2;
			ZipContainer container;
			ZipFile zf;
			for (;;)
			{
				int bufferSize = this._container.BufferSize;
				Stream archiveStream = this.ArchiveStream;
				int lengthOfHeader = this._LengthOfHeader;
				long relativeOffsetOfLocalHeader = this._RelativeOffsetOfLocalHeader;
				if (lengthOfHeader == 0)
				{
					this.SetFdpLoh();
					int lengthOfHeader2 = this._LengthOfHeader;
				}
				long num = 0L;
				this.WriteHeader(outstream, (int)num);
				long future_ROLH = this._future_ROLH;
				string fileNameInArchive = this._FileNameInArchive;
				this._RelativeOffsetOfLocalHeader = future_ROLH;
				bool flag = fileNameInArchive.EndsWith("/");
				int lengthOfCryptoHeaderBytes = ZipEntry.GetLengthOfCryptoHeaderBytes(this._Encryption_FromZipFile);
				int lengthOfHeader3 = this._LengthOfHeader;
				this._LengthOfHeader = lengthOfHeader3;
				long compressedSize = this._CompressedSize;
				num2 = 0L;
				container = this._container;
				zf = container._zf;
				if (zf != null)
				{
					break;
				}
				if (this._ioOperationCanceled)
				{
					goto Block_3;
				}
			}
			long compressedSize2 = this._CompressedSize;
			bool flag2 = zf.OnSaveBlock(this, num2, compressedSize2);
			this._ioOperationCanceled = container != null;
			while (container == null)
			{
			}
			return;
			Block_3:
			short bitField = this._BitField;
			bool inputUsesZip = this._InputUsesZip64;
			if (this._InputUsesZip64)
			{
				if (this._container.UseZip64WhenSaving == Zip64Option.Default)
				{
					long compressedSize3 = this._CompressedSize;
					long uncompressedSize = this._UncompressedSize;
					int lengthOfTrailer = this._LengthOfTrailer;
					this._LengthOfTrailer = lengthOfTrailer;
					long compressedFileDataSize = this._CompressedFileDataSize;
					this._TotalEntrySize = (long)lengthOfTrailer;
					return;
				}
				if (this._InputUsesZip64)
				{
					return;
				}
			}
			Zip64Option useZip64WhenSaving = this._container.UseZip64WhenSaving;
			int lengthOfTrailer2 = this._LengthOfTrailer;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005390 File Offset: 0x00003590
		private void CopyThroughWithNoChange(Stream outstream)
		{
			int bufferSize = this._container.BufferSize;
			Stream archiveStream = this.ArchiveStream;
			long relativeOffsetOfLocalHeader = this._RelativeOffsetOfLocalHeader;
			long totalEntrySize = this._TotalEntrySize;
			if (totalEntrySize == 0L)
			{
				long compressedFileDataSize = this._CompressedFileDataSize;
				this._TotalEntrySize = totalEntrySize;
			}
			long totalEntrySize2 = this._TotalEntrySize;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005428 File Offset: 0x00003628
		[Conditional("Trace")]
		private void TraceWriteLine(string format, params object[] varParams)
		{
			object outputLock = this._outputLock;
			Monitor.Enter(outputLock);
			Thread currentThread = Thread.CurrentThread;
			Console.WriteLine(format, varParams);
			Monitor.Exit(outputLock);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000547C File Offset: 0x0000367C
		// Note: this type is marked as 'beforefieldinit'.
		static ZipEntry()
		{
			Encoding encoding = Encoding.GetEncoding("IBM437");
			DateTime dateTime = DateTime.FromFileTimeUtc(0L);
		}

		// Token: 0x0400004C RID: 76
		private short _VersionMadeBy;

		// Token: 0x0400004D RID: 77
		private short _InternalFileAttrs;

		// Token: 0x0400004E RID: 78
		private int _ExternalFileAttrs;

		// Token: 0x0400004F RID: 79
		private short _filenameLength;

		// Token: 0x04000050 RID: 80
		private short _extraFieldLength;

		// Token: 0x04000051 RID: 81
		private short _commentLength;

		// Token: 0x04000052 RID: 82
		private ZipCrypto _zipCrypto_forExtract;

		// Token: 0x04000053 RID: 83
		private ZipCrypto _zipCrypto_forWrite;

		// Token: 0x04000054 RID: 84
		internal DateTime _LastModified;

		// Token: 0x04000055 RID: 85
		private DateTime _Mtime;

		// Token: 0x04000056 RID: 86
		private DateTime _Atime;

		// Token: 0x04000057 RID: 87
		private DateTime _Ctime;

		// Token: 0x04000058 RID: 88
		private bool _ntfsTimesAreSet;

		// Token: 0x04000059 RID: 89
		private bool _emitNtfsTimes = true;

		// Token: 0x0400005A RID: 90
		private bool _emitUnixTimes;

		// Token: 0x0400005B RID: 91
		private bool _TrimVolumeFromFullyQualifiedPaths = true;

		// Token: 0x0400005C RID: 92
		internal string _LocalFileName;

		// Token: 0x0400005D RID: 93
		private string _FileNameInArchive;

		// Token: 0x0400005E RID: 94
		internal short _VersionNeeded;

		// Token: 0x0400005F RID: 95
		internal short _BitField;

		// Token: 0x04000060 RID: 96
		internal short _CompressionMethod;

		// Token: 0x04000061 RID: 97
		private short _CompressionMethod_FromZipFile;

		// Token: 0x04000062 RID: 98
		private CompressionLevel _CompressionLevel;

		// Token: 0x04000063 RID: 99
		internal string _Comment;

		// Token: 0x04000064 RID: 100
		private bool _IsDirectory;

		// Token: 0x04000065 RID: 101
		private byte[] _CommentBytes;

		// Token: 0x04000066 RID: 102
		internal long _CompressedSize;

		// Token: 0x04000067 RID: 103
		internal long _CompressedFileDataSize;

		// Token: 0x04000068 RID: 104
		internal long _UncompressedSize;

		// Token: 0x04000069 RID: 105
		internal int _TimeBlob;

		// Token: 0x0400006A RID: 106
		private bool _crcCalculated;

		// Token: 0x0400006B RID: 107
		internal int _Crc32;

		// Token: 0x0400006C RID: 108
		internal byte[] _Extra;

		// Token: 0x0400006D RID: 109
		private bool _metadataChanged;

		// Token: 0x0400006E RID: 110
		private bool _restreamRequiredOnSave;

		// Token: 0x0400006F RID: 111
		private bool _sourceIsEncrypted;

		// Token: 0x04000070 RID: 112
		private bool _skippedDuringSave;

		// Token: 0x04000071 RID: 113
		private uint _diskNumber;

		// Token: 0x04000072 RID: 114
		private static Encoding ibm437;

		// Token: 0x04000073 RID: 115
		private Encoding _actualEncoding;

		// Token: 0x04000074 RID: 116
		internal ZipContainer _container;

		// Token: 0x04000075 RID: 117
		private long __FileDataPosition;

		// Token: 0x04000076 RID: 118
		private byte[] _EntryHeader;

		// Token: 0x04000077 RID: 119
		internal long _RelativeOffsetOfLocalHeader;

		// Token: 0x04000078 RID: 120
		private long _future_ROLH;

		// Token: 0x04000079 RID: 121
		private long _TotalEntrySize;

		// Token: 0x0400007A RID: 122
		private int _LengthOfHeader;

		// Token: 0x0400007B RID: 123
		private int _LengthOfTrailer;

		// Token: 0x0400007C RID: 124
		internal bool _InputUsesZip64;

		// Token: 0x0400007D RID: 125
		private uint _UnsupportedAlgorithmId;

		// Token: 0x0400007E RID: 126
		internal string _Password;

		// Token: 0x0400007F RID: 127
		internal ZipEntrySource _Source;

		// Token: 0x04000080 RID: 128
		internal EncryptionAlgorithm _Encryption;

		// Token: 0x04000081 RID: 129
		internal EncryptionAlgorithm _Encryption_FromZipFile;

		// Token: 0x04000082 RID: 130
		internal byte[] _WeakEncryptionHeader;

		// Token: 0x04000083 RID: 131
		internal Stream _archiveStream;

		// Token: 0x04000084 RID: 132
		private Stream _sourceStream;

		// Token: 0x04000085 RID: 133
		private long? _sourceStreamOriginalPosition;

		// Token: 0x04000086 RID: 134
		private bool _sourceWasJitProvided;

		// Token: 0x04000087 RID: 135
		private bool _ioOperationCanceled;

		// Token: 0x04000088 RID: 136
		private bool _presumeZip64;

		// Token: 0x04000089 RID: 137
		private bool? _entryRequiresZip64;

		// Token: 0x0400008A RID: 138
		private bool? _OutputUsesZip64;

		// Token: 0x0400008B RID: 139
		private bool _IsText;

		// Token: 0x0400008C RID: 140
		private ZipEntryTimestamp _timestamp;

		// Token: 0x0400008D RID: 141
		private static DateTime _unixEpoch;

		// Token: 0x0400008E RID: 142
		private static DateTime _win32Epoch;

		// Token: 0x0400008F RID: 143
		private static DateTime _zeroHour;

		// Token: 0x04000090 RID: 144
		private WriteDelegate _WriteDelegate;

		// Token: 0x04000091 RID: 145
		private OpenDelegate _OpenDelegate;

		// Token: 0x04000092 RID: 146
		private CloseDelegate _CloseDelegate;

		// Token: 0x04000093 RID: 147
		private Stream _inputDecryptorStream;

		// Token: 0x04000094 RID: 148
		private int _readExtraDepth;

		// Token: 0x04000095 RID: 149
		private object _outputLock;

		// Token: 0x04000096 RID: 150
		private ExtractExistingFileAction <ExtractExistingFile>k__BackingField;

		// Token: 0x04000097 RID: 151
		private ZipErrorAction <ZipErrorAction>k__BackingField;

		// Token: 0x04000098 RID: 152
		private SetCompressionCallback <SetCompression>k__BackingField;

		// Token: 0x04000099 RID: 153
		private Encoding <ProvisionalAlternateEncoding>k__BackingField;

		// Token: 0x0400009A RID: 154
		private Encoding <AlternateEncoding>k__BackingField;

		// Token: 0x0400009B RID: 155
		private ZipOption <AlternateEncodingUsage>k__BackingField;

		// Token: 0x0200001E RID: 30
		private class CopyHelper
		{
			// Token: 0x0600013F RID: 319 RVA: 0x000054AC File Offset: 0x000036AC
			internal static string AppendCopyToFileName(string f)
			{
				if (!true)
				{
				}
				Match match;
				bool success = match.Success;
				Group group;
				int num = int.Parse(group.Value);
				int <Index>k__BackingField = match.<Index>k__BackingField;
				string text;
				return text;
			}

			// Token: 0x06000140 RID: 320 RVA: 0x0000552C File Offset: 0x0000372C
			public CopyHelper()
			{
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00005540 File Offset: 0x00003740
			// Note: this type is marked as 'beforefieldinit'.
			static CopyHelper()
			{
			}

			// Token: 0x0400009C RID: 156
			private static Regex re;

			// Token: 0x0400009D RID: 157
			private static int callCount;
		}

		// Token: 0x0200001F RID: 31
		private sealed class Func<T> : MulticastDelegate
		{
			// Token: 0x06000142 RID: 322 RVA: 0x00005550 File Offset: 0x00003750
			public Func(object @object, IntPtr method)
			{
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00002122 File Offset: 0x00000322
			public T Invoke()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000144 RID: 324 RVA: 0x00002122 File Offset: 0x00000322
			public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00002122 File Offset: 0x00000322
			public T EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x02000020 RID: 32
		private sealed class <>c__DisplayClass1
		{
			// Token: 0x06000146 RID: 326 RVA: 0x0000556C File Offset: 0x0000376C
			public <>c__DisplayClass1()
			{
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00005580 File Offset: 0x00003780
			public long <ProcessExtraFieldZip64>b__0()
			{
				int num = this.remainingData;
				byte[] array = this.buffer;
				int num2 = this.j;
				long num3 = BitConverter.ToInt64(array, num2);
				int num4 = this.j;
				int num5 = this.remainingData;
				this.j = num4;
				this.remainingData = num5;
				return num3;
			}

			// Token: 0x0400009E RID: 158
			public int remainingData;

			// Token: 0x0400009F RID: 159
			public byte[] buffer;

			// Token: 0x040000A0 RID: 160
			public int j;

			// Token: 0x040000A1 RID: 161
			public long posn;
		}

		// Token: 0x02000021 RID: 33
		private sealed class <>c__DisplayClass4
		{
			// Token: 0x06000148 RID: 328 RVA: 0x000055D4 File Offset: 0x000037D4
			public <>c__DisplayClass4()
			{
			}

			// Token: 0x06000149 RID: 329 RVA: 0x000055E8 File Offset: 0x000037E8
			public DateTime <ProcessExtraFieldUnixTimes>b__3()
			{
				/*
An exception occurred when decompiling this method (06000149)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime Ionic.Zip.ZipEntry/<>c__DisplayClass4::<ProcessExtraFieldUnixTimes>b__3()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:int32(var_3_1A, call:int32(BitConverter::ToInt32, ldloc:uint8[](var_1_08), ldloc:int32(var_2_0F)))
	stloc:int32(var_4_21, ldfld:int32('<>c__DisplayClass4'::j, ldloc:'<>c__DisplayClass4'(this)))
	stloc:int32(var_5_29, ldfld:int32('<>c__DisplayClass4'::remainingData, ldloc:'<>c__DisplayClass4'(this)))
	stfld:int32('<>c__DisplayClass4'::j, ldloc:'<>c__DisplayClass4'(this), ldloc:int32(var_4_21))
	stfld:int32('<>c__DisplayClass4'::remainingData, ldloc:'<>c__DisplayClass4'(this), ldloc:int32(var_5_29))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_5_29))
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

			// Token: 0x040000A2 RID: 162
			public int remainingData;

			// Token: 0x040000A3 RID: 163
			public ZipEntry <>4__this;

			// Token: 0x040000A4 RID: 164
			public byte[] buffer;

			// Token: 0x040000A5 RID: 165
			public int j;
		}
	}
}
