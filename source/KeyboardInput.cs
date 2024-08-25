using System;
using UnityEngine;

// Token: 0x02000056 RID: 86
internal static class KeyboardInput
{
	// Token: 0x060001D8 RID: 472 RVA: 0x000056F4 File Offset: 0x000038F4
	public static void KeyboardUpdate()
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x00005704 File Offset: 0x00003904
	public static bool KeyPressed(int keyCode)
	{
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00005714 File Offset: 0x00003914
	public static void Update()
	{
		if (!true)
		{
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00005960 File Offset: 0x00003B60
	public static bool GetKey(KeyCode keycode)
	{
		/*
An exception occurred when decompiling this method (060001DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean KeyboardInput::GetKey(UnityEngine.KeyCode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

	// Token: 0x060001DC RID: 476 RVA: 0x0000597C File Offset: 0x00003B7C
	public static bool GetKeyUp(KeyCode keycode)
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num != 0 || num == 0)
		{
			return;
		}
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00005998 File Offset: 0x00003B98
	public static bool GetKeyDown(KeyCode keycode)
	{
		/*
An exception occurred when decompiling this method (060001DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean KeyboardInput::GetKeyDown(UnityEngine.KeyCode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

	// Token: 0x060001DE RID: 478 RVA: 0x000059B4 File Offset: 0x00003BB4
	public static void KeyboardInitialise()
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x000059C4 File Offset: 0x00003BC4
	// Note: this type is marked as 'beforefieldinit'.
	static KeyboardInput()
	{
	}

	// Token: 0x0400013F RID: 319
	private static KeyboardInput.KeyCodeMapping[] keyMappings;

	// Token: 0x04000140 RID: 320
	private static bool[] KeyStates;

	// Token: 0x04000141 RID: 321
	private static bool[] KeyStatesOld;

	// Token: 0x04000142 RID: 322
	private static AndroidJavaObject pressedStateArray;

	// Token: 0x04000143 RID: 323
	private static IntPtr pressedStateArracyValues;

	// Token: 0x02000057 RID: 87
	public enum VirtualKey
	{
		// Token: 0x04000145 RID: 325
		None,
		// Token: 0x04000146 RID: 326
		LeftButton,
		// Token: 0x04000147 RID: 327
		RightButton,
		// Token: 0x04000148 RID: 328
		Cancel,
		// Token: 0x04000149 RID: 329
		MiddleButton,
		// Token: 0x0400014A RID: 330
		XButton1,
		// Token: 0x0400014B RID: 331
		XButton2,
		// Token: 0x0400014C RID: 332
		Back = 8,
		// Token: 0x0400014D RID: 333
		Tab,
		// Token: 0x0400014E RID: 334
		Clear = 12,
		// Token: 0x0400014F RID: 335
		Enter,
		// Token: 0x04000150 RID: 336
		Shift = 16,
		// Token: 0x04000151 RID: 337
		Control,
		// Token: 0x04000152 RID: 338
		Menu,
		// Token: 0x04000153 RID: 339
		Pause,
		// Token: 0x04000154 RID: 340
		CapitalLock,
		// Token: 0x04000155 RID: 341
		Kana,
		// Token: 0x04000156 RID: 342
		Hangul = 21,
		// Token: 0x04000157 RID: 343
		Junja = 23,
		// Token: 0x04000158 RID: 344
		Final,
		// Token: 0x04000159 RID: 345
		Hanja,
		// Token: 0x0400015A RID: 346
		Kanji = 25,
		// Token: 0x0400015B RID: 347
		Escape = 27,
		// Token: 0x0400015C RID: 348
		Convert,
		// Token: 0x0400015D RID: 349
		NonConvert,
		// Token: 0x0400015E RID: 350
		Accept,
		// Token: 0x0400015F RID: 351
		ModeChange,
		// Token: 0x04000160 RID: 352
		Space,
		// Token: 0x04000161 RID: 353
		PageUp,
		// Token: 0x04000162 RID: 354
		PageDown,
		// Token: 0x04000163 RID: 355
		End,
		// Token: 0x04000164 RID: 356
		Home,
		// Token: 0x04000165 RID: 357
		Left,
		// Token: 0x04000166 RID: 358
		Up,
		// Token: 0x04000167 RID: 359
		Right,
		// Token: 0x04000168 RID: 360
		Down,
		// Token: 0x04000169 RID: 361
		Select,
		// Token: 0x0400016A RID: 362
		Print,
		// Token: 0x0400016B RID: 363
		Execute,
		// Token: 0x0400016C RID: 364
		Snapshot,
		// Token: 0x0400016D RID: 365
		Insert,
		// Token: 0x0400016E RID: 366
		Delete,
		// Token: 0x0400016F RID: 367
		Help,
		// Token: 0x04000170 RID: 368
		Number0,
		// Token: 0x04000171 RID: 369
		Number1,
		// Token: 0x04000172 RID: 370
		Number2,
		// Token: 0x04000173 RID: 371
		Number3,
		// Token: 0x04000174 RID: 372
		Number4,
		// Token: 0x04000175 RID: 373
		Number5,
		// Token: 0x04000176 RID: 374
		Number6,
		// Token: 0x04000177 RID: 375
		Number7,
		// Token: 0x04000178 RID: 376
		Number8,
		// Token: 0x04000179 RID: 377
		Number9,
		// Token: 0x0400017A RID: 378
		A = 65,
		// Token: 0x0400017B RID: 379
		B,
		// Token: 0x0400017C RID: 380
		C,
		// Token: 0x0400017D RID: 381
		D,
		// Token: 0x0400017E RID: 382
		E,
		// Token: 0x0400017F RID: 383
		F,
		// Token: 0x04000180 RID: 384
		G,
		// Token: 0x04000181 RID: 385
		H,
		// Token: 0x04000182 RID: 386
		I,
		// Token: 0x04000183 RID: 387
		J,
		// Token: 0x04000184 RID: 388
		K,
		// Token: 0x04000185 RID: 389
		L,
		// Token: 0x04000186 RID: 390
		M,
		// Token: 0x04000187 RID: 391
		N,
		// Token: 0x04000188 RID: 392
		O,
		// Token: 0x04000189 RID: 393
		P,
		// Token: 0x0400018A RID: 394
		Q,
		// Token: 0x0400018B RID: 395
		R,
		// Token: 0x0400018C RID: 396
		S,
		// Token: 0x0400018D RID: 397
		T,
		// Token: 0x0400018E RID: 398
		U,
		// Token: 0x0400018F RID: 399
		V,
		// Token: 0x04000190 RID: 400
		W,
		// Token: 0x04000191 RID: 401
		X,
		// Token: 0x04000192 RID: 402
		Y,
		// Token: 0x04000193 RID: 403
		Z,
		// Token: 0x04000194 RID: 404
		LeftWindows,
		// Token: 0x04000195 RID: 405
		RightWindows,
		// Token: 0x04000196 RID: 406
		Application,
		// Token: 0x04000197 RID: 407
		Sleep = 95,
		// Token: 0x04000198 RID: 408
		NumberPad0,
		// Token: 0x04000199 RID: 409
		NumberPad1,
		// Token: 0x0400019A RID: 410
		NumberPad2,
		// Token: 0x0400019B RID: 411
		NumberPad3,
		// Token: 0x0400019C RID: 412
		NumberPad4,
		// Token: 0x0400019D RID: 413
		NumberPad5,
		// Token: 0x0400019E RID: 414
		NumberPad6,
		// Token: 0x0400019F RID: 415
		NumberPad7,
		// Token: 0x040001A0 RID: 416
		NumberPad8,
		// Token: 0x040001A1 RID: 417
		NumberPad9,
		// Token: 0x040001A2 RID: 418
		Multiply,
		// Token: 0x040001A3 RID: 419
		Add,
		// Token: 0x040001A4 RID: 420
		Separator,
		// Token: 0x040001A5 RID: 421
		Subtract,
		// Token: 0x040001A6 RID: 422
		Decimal,
		// Token: 0x040001A7 RID: 423
		Divide,
		// Token: 0x040001A8 RID: 424
		F1,
		// Token: 0x040001A9 RID: 425
		F2,
		// Token: 0x040001AA RID: 426
		F3,
		// Token: 0x040001AB RID: 427
		F4,
		// Token: 0x040001AC RID: 428
		F5,
		// Token: 0x040001AD RID: 429
		F6,
		// Token: 0x040001AE RID: 430
		F7,
		// Token: 0x040001AF RID: 431
		F8,
		// Token: 0x040001B0 RID: 432
		F9,
		// Token: 0x040001B1 RID: 433
		F10,
		// Token: 0x040001B2 RID: 434
		F11,
		// Token: 0x040001B3 RID: 435
		F12,
		// Token: 0x040001B4 RID: 436
		F13,
		// Token: 0x040001B5 RID: 437
		F14,
		// Token: 0x040001B6 RID: 438
		F15,
		// Token: 0x040001B7 RID: 439
		F16,
		// Token: 0x040001B8 RID: 440
		F17,
		// Token: 0x040001B9 RID: 441
		F18,
		// Token: 0x040001BA RID: 442
		F19,
		// Token: 0x040001BB RID: 443
		F20,
		// Token: 0x040001BC RID: 444
		F21,
		// Token: 0x040001BD RID: 445
		F22,
		// Token: 0x040001BE RID: 446
		F23,
		// Token: 0x040001BF RID: 447
		F24,
		// Token: 0x040001C0 RID: 448
		NumberKeyLock = 144,
		// Token: 0x040001C1 RID: 449
		Scroll,
		// Token: 0x040001C2 RID: 450
		LeftShift = 160,
		// Token: 0x040001C3 RID: 451
		RightShift,
		// Token: 0x040001C4 RID: 452
		LeftControl,
		// Token: 0x040001C5 RID: 453
		RightControl,
		// Token: 0x040001C6 RID: 454
		LeftMenu,
		// Token: 0x040001C7 RID: 455
		RightMenu,
		// Token: 0x040001C8 RID: 456
		Semicolon = 186,
		// Token: 0x040001C9 RID: 457
		Equals,
		// Token: 0x040001CA RID: 458
		Comma,
		// Token: 0x040001CB RID: 459
		Minus,
		// Token: 0x040001CC RID: 460
		Period,
		// Token: 0x040001CD RID: 461
		Slash,
		// Token: 0x040001CE RID: 462
		BackQuote,
		// Token: 0x040001CF RID: 463
		LeftBracket = 219,
		// Token: 0x040001D0 RID: 464
		RightBracket = 221,
		// Token: 0x040001D1 RID: 465
		Quote,
		// Token: 0x040001D2 RID: 466
		Backslash = 226
	}

	// Token: 0x02000058 RID: 88
	public struct KeyCodeMapping
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x000059D4 File Offset: 0x00003BD4
		public KeyCodeMapping(KeyboardInput.VirtualKey vKey, KeyCode code)
		{
			this.keyCode = code;
		}

		// Token: 0x040001D3 RID: 467
		public KeyCode keyCode;

		// Token: 0x040001D4 RID: 468
		public KeyboardInput.VirtualKey virtualKey;
	}
}
