using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.Social.Discord
{
	// Token: 0x02000517 RID: 1303
	public class DiscordRpc
	{
		// Token: 0x06003179 RID: 12665
		public static extern void Initialize(string applicationId, DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x0600317A RID: 12666
		public static extern void Shutdown();

		// Token: 0x0600317B RID: 12667
		public static extern void RunCallbacks();

		// Token: 0x0600317C RID: 12668
		private static extern void UpdatePresenceNative(DiscordRpc.RichPresenceStruct presence);

		// Token: 0x0600317D RID: 12669
		public static extern void ClearPresence();

		// Token: 0x0600317E RID: 12670
		public static extern void Respond(string userId, DiscordRpc.Reply reply);

		// Token: 0x0600317F RID: 12671
		public static extern void UpdateHandlers(DiscordRpc.EventHandlers handlers);

		// Token: 0x06003180 RID: 12672 RVA: 0x001F8550 File Offset: 0x001F6750
		public static void UpdatePresence(DiscordRpc.RichPresence presence)
		{
			DiscordRpc.UpdatePresenceNative(presence.GetStruct());
			presence.FreeMem();
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x001F8570 File Offset: 0x001F6770
		public DiscordRpc()
		{
		}

		// Token: 0x02000518 RID: 1304
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class OnReadyInfo : MulticastDelegate
		{
			// Token: 0x06003182 RID: 12674 RVA: 0x001F8584 File Offset: 0x001F6784
			public OnReadyInfo(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003183 RID: 12675 RVA: 0x001F85D8 File Offset: 0x001F67D8
			public void Invoke(DiscordRpc.DiscordUser connectedUser)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003184 RID: 12676 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(DiscordRpc.DiscordUser connectedUser, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003185 RID: 12677 RVA: 0x001F85FC File Offset: 0x001F67FC
			public void EndInvoke(DiscordRpc.DiscordUser connectedUser, IAsyncResult result)
			{
			}
		}

		// Token: 0x02000519 RID: 1305
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class OnDisconnectedInfo : MulticastDelegate
		{
			// Token: 0x06003186 RID: 12678 RVA: 0x001F860C File Offset: 0x001F680C
			public OnDisconnectedInfo(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003187 RID: 12679 RVA: 0x001F8660 File Offset: 0x001F6860
			public void Invoke(int errorCode, string message)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003188 RID: 12680 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int errorCode, string message, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003189 RID: 12681 RVA: 0x001F8684 File Offset: 0x001F6884
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x0200051A RID: 1306
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class OnErrorInfo : MulticastDelegate
		{
			// Token: 0x0600318A RID: 12682 RVA: 0x001F8694 File Offset: 0x001F6894
			public OnErrorInfo(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600318B RID: 12683 RVA: 0x001F86E8 File Offset: 0x001F68E8
			public void Invoke(int errorCode, string message)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x0600318C RID: 12684 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int errorCode, string message, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600318D RID: 12685 RVA: 0x001F870C File Offset: 0x001F690C
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x0200051B RID: 1307
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class OnJoinInfo : MulticastDelegate
		{
			// Token: 0x0600318E RID: 12686 RVA: 0x001F871C File Offset: 0x001F691C
			public OnJoinInfo(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600318F RID: 12687 RVA: 0x001F8770 File Offset: 0x001F6970
			public void Invoke(string secret)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003190 RID: 12688 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(string secret, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003191 RID: 12689 RVA: 0x001F8794 File Offset: 0x001F6994
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x0200051C RID: 1308
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class OnSpectateInfo : MulticastDelegate
		{
			// Token: 0x06003192 RID: 12690 RVA: 0x001F87A4 File Offset: 0x001F69A4
			public OnSpectateInfo(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003193 RID: 12691 RVA: 0x001F87F8 File Offset: 0x001F69F8
			public void Invoke(string secret)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003194 RID: 12692 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(string secret, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003195 RID: 12693 RVA: 0x001F881C File Offset: 0x001F6A1C
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x0200051D RID: 1309
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public sealed class OnRequestInfo : MulticastDelegate
		{
			// Token: 0x06003196 RID: 12694 RVA: 0x001F882C File Offset: 0x001F6A2C
			public OnRequestInfo(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06003197 RID: 12695 RVA: 0x001F8880 File Offset: 0x001F6A80
			public void Invoke(DiscordRpc.DiscordUser request)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06003198 RID: 12696 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(DiscordRpc.DiscordUser request, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003199 RID: 12697 RVA: 0x001F88A4 File Offset: 0x001F6AA4
			public void EndInvoke(DiscordRpc.DiscordUser request, IAsyncResult result)
			{
			}
		}

		// Token: 0x0200051E RID: 1310
		public struct EventHandlers
		{
			// Token: 0x04003B28 RID: 15144
			public DiscordRpc.OnReadyInfo readyCallback;

			// Token: 0x04003B29 RID: 15145
			public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

			// Token: 0x04003B2A RID: 15146
			public DiscordRpc.OnErrorInfo errorCallback;

			// Token: 0x04003B2B RID: 15147
			public DiscordRpc.OnJoinInfo joinCallback;

			// Token: 0x04003B2C RID: 15148
			public DiscordRpc.OnSpectateInfo spectateCallback;

			// Token: 0x04003B2D RID: 15149
			public DiscordRpc.OnRequestInfo requestCallback;
		}

		// Token: 0x0200051F RID: 1311
		[Serializable]
		public struct RichPresenceStruct
		{
			// Token: 0x04003B2E RID: 15150
			public IntPtr state;

			// Token: 0x04003B2F RID: 15151
			public IntPtr details;

			// Token: 0x04003B30 RID: 15152
			public long startTimestamp;

			// Token: 0x04003B31 RID: 15153
			public long endTimestamp;

			// Token: 0x04003B32 RID: 15154
			public IntPtr largeImageKey;

			// Token: 0x04003B33 RID: 15155
			public IntPtr largeImageText;

			// Token: 0x04003B34 RID: 15156
			public IntPtr smallImageKey;

			// Token: 0x04003B35 RID: 15157
			public IntPtr smallImageText;

			// Token: 0x04003B36 RID: 15158
			public IntPtr partyId;

			// Token: 0x04003B37 RID: 15159
			public int partySize;

			// Token: 0x04003B38 RID: 15160
			public int partyMax;

			// Token: 0x04003B39 RID: 15161
			public IntPtr matchSecret;

			// Token: 0x04003B3A RID: 15162
			public IntPtr joinSecret;

			// Token: 0x04003B3B RID: 15163
			public IntPtr spectateSecret;

			// Token: 0x04003B3C RID: 15164
			public bool instance;
		}

		// Token: 0x02000520 RID: 1312
		[Serializable]
		public struct DiscordUser
		{
			// Token: 0x04003B3D RID: 15165
			public string userId;

			// Token: 0x04003B3E RID: 15166
			public string username;

			// Token: 0x04003B3F RID: 15167
			public string discriminator;

			// Token: 0x04003B40 RID: 15168
			public string avatar;
		}

		// Token: 0x02000521 RID: 1313
		public enum Reply
		{
			// Token: 0x04003B42 RID: 15170
			No,
			// Token: 0x04003B43 RID: 15171
			Yes,
			// Token: 0x04003B44 RID: 15172
			Ignore
		}

		// Token: 0x02000522 RID: 1314
		public class RichPresence
		{
			// Token: 0x0600319A RID: 12698 RVA: 0x001F88B4 File Offset: 0x001F6AB4
			internal DiscordRpc.RichPresenceStruct GetStruct()
			{
				/*
An exception occurred when decompiling this method (0600319A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Social.Discord.DiscordRpc/RichPresenceStruct Terraria.Social.Discord.DiscordRpc/RichPresence::GetStruct()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<native int>[exp:List`1](RichPresence::_buffers, ldloc:RichPresence(this))))
	call:void(RichPresence::FreeMem, ldloc:RichPresence(this))
	stloc:string(var_1_18, ldfld:string(RichPresence::state, ldloc:RichPresence(this)))
	stloc:native int(var_2_20, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_1_18)))
	stfld:RichPresenceStruct(RichPresence::_presence, ldloc:RichPresence(this), ldloc:native int[exp:RichPresenceStruct](var_2_20))
	stloc:string(var_3_2E, ldfld:string(RichPresence::details, ldloc:RichPresence(this)))
	stloc:native int(var_4_36, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_3_2E)))
	stloc:string(var_5_3E, ldfld:string(RichPresence::largeImageKey, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::details, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_4_36))
	stloc:native int(var_6_55, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_5_3E)))
	stloc:string(var_7_5D, ldfld:string(RichPresence::largeImageText, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::largeImageKey, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_6_55))
	stloc:native int(var_8_74, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_7_5D)))
	stloc:string(var_9_7C, ldfld:string(RichPresence::smallImageKey, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::largeImageText, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_8_74))
	stloc:native int(var_10_93, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_9_7C)))
	stloc:string(var_11_9B, ldfld:string(RichPresence::smallImageText, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::smallImageKey, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_10_93))
	stloc:native int(var_12_B2, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_11_9B)))
	stloc:string(var_13_BA, ldfld:string(RichPresence::partyId, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::smallImageText, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_12_B2))
	stloc:native int(var_14_D1, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_13_BA)))
	stloc:int32(var_15_D9, ldfld:int32(RichPresence::partySize, ldloc:RichPresence(this)))
	stloc:string(var_16_E1, ldfld:string(RichPresence::matchSecret, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::partyId, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_14_D1))
	stfld:int32(RichPresenceStruct::partySize, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:int32(var_15_D9))
	stloc:native int(var_17_105, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_16_E1)))
	stloc:string(var_18_10D, ldfld:string(RichPresence::joinSecret, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::matchSecret, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_17_105))
	stloc:native int(var_19_124, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_18_10D)))
	stloc:string(var_20_12C, ldfld:string(RichPresence::spectateSecret, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::joinSecret, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_19_124))
	stloc:native int(var_21_143, call:native int(RichPresence::StrToPtr, ldloc:RichPresence(this), ldloc:string(var_20_12C)))
	stloc:bool(var_22_14B, ldfld:bool(RichPresence::instance, ldloc:RichPresence(this)))
	stfld:native int(RichPresenceStruct::spectateSecret, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:native int(var_21_143))
	stfld:bool(RichPresenceStruct::instance, ldfld:RichPresenceStruct[exp:valuetype Terraria.Social.Discord.DiscordRpc/RichPresenceStruct&](RichPresence::_presence, ldloc:RichPresence(this)), ldloc:bool(var_22_14B))
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

			// Token: 0x0600319B RID: 12699 RVA: 0x000021DB File Offset: 0x000003DB
			private IntPtr StrToPtr(string input)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600319C RID: 12700 RVA: 0x001F8A28 File Offset: 0x001F6C28
			private static string StrToUtf8NullTerm(string toconv)
			{
				/*
An exception occurred when decompiling this method (0600319C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Social.Discord.DiscordRpc/RichPresence::StrToUtf8NullTerm(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:Encoding(var_5_2C, callgetter:Encoding(Encoding::get_UTF8))
	stloc:Encoding(var_7_36, callgetter:Encoding(Encoding::get_UTF8))
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

			// Token: 0x0600319D RID: 12701 RVA: 0x001F8A6C File Offset: 0x001F6C6C
			internal void FreeMem()
			{
				int size = this._buffers._size;
				List<IntPtr> buffers = this._buffers;
				List<IntPtr> buffers2 = this._buffers;
			}

			// Token: 0x0600319E RID: 12702 RVA: 0x001F8A94 File Offset: 0x001F6C94
			public RichPresence()
			{
			}

			// Token: 0x04003B45 RID: 15173
			private DiscordRpc.RichPresenceStruct _presence;

			// Token: 0x04003B46 RID: 15174
			private readonly List<IntPtr> _buffers;

			// Token: 0x04003B47 RID: 15175
			public string state;

			// Token: 0x04003B48 RID: 15176
			public string details;

			// Token: 0x04003B49 RID: 15177
			public long startTimestamp;

			// Token: 0x04003B4A RID: 15178
			public long endTimestamp;

			// Token: 0x04003B4B RID: 15179
			public string largeImageKey;

			// Token: 0x04003B4C RID: 15180
			public string largeImageText;

			// Token: 0x04003B4D RID: 15181
			public string smallImageKey;

			// Token: 0x04003B4E RID: 15182
			public string smallImageText;

			// Token: 0x04003B4F RID: 15183
			public string partyId;

			// Token: 0x04003B50 RID: 15184
			public int partySize;

			// Token: 0x04003B51 RID: 15185
			public int partyMax;

			// Token: 0x04003B52 RID: 15186
			public string matchSecret;

			// Token: 0x04003B53 RID: 15187
			public string joinSecret;

			// Token: 0x04003B54 RID: 15188
			public string spectateSecret;

			// Token: 0x04003B55 RID: 15189
			public bool instance;
		}
	}
}
