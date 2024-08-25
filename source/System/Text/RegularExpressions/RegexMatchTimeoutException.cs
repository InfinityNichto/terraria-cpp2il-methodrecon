using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000BC RID: 188
	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException, ISerializable
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x000106C0 File Offset: 0x0000E8C0
		public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
		{
			TimeSpan timeSpan;
			this.<MatchTimeout>k__BackingField = timeSpan;
			base..ctor("The RegEx engine has timed out while trying to match a pattern to an input string. This can occur for many reasons, including very large inputs or excessive backtracking caused by nested quantifiers, back-references and other factors.");
			this.Input = regexInput;
			this.Pattern = regexPattern;
			this.<MatchTimeout>k__BackingField = matchTimeout;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000106F4 File Offset: 0x0000E8F4
		public RegexMatchTimeoutException()
		{
			TimeSpan timeSpan;
			this.<MatchTimeout>k__BackingField = timeSpan;
			base..ctor();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00010710 File Offset: 0x0000E910
		protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
		{
			TimeSpan timeSpan;
			this.<MatchTimeout>k__BackingField = timeSpan;
			base..ctor(info, context);
			string @string = info.GetString("regexInput");
			this.Input = @string;
			string string2 = info.GetString("regexPattern");
			this.Pattern = string2;
			long @int = info.GetInt64("timeoutTicks");
			this.<MatchTimeout>k__BackingField = @int;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00010768 File Offset: 0x0000E968
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string text = this.<Input>k__BackingField;
			info.AddValue("regexInput", text);
			string text2 = this.<Pattern>k__BackingField;
			info.AddValue("regexPattern", text2);
			TimeSpan timeSpan = this.<MatchTimeout>k__BackingField;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000107AC File Offset: 0x0000E9AC
		public string Input
		{
			[CompilerGenerated]
			get
			{
				return this.<Input>k__BackingField;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000107C0 File Offset: 0x0000E9C0
		public string Pattern
		{
			[CompilerGenerated]
			get
			{
				return this.<Pattern>k__BackingField;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x000107D4 File Offset: 0x0000E9D4
		public TimeSpan MatchTimeout
		{
			[CompilerGenerated]
			get
			{
				TimeSpan timeSpan = this.<MatchTimeout>k__BackingField;
				TimeSpan timeSpan2;
				return timeSpan2;
			}
		}

		// Token: 0x04000336 RID: 822
		[CompilerGenerated]
		private readonly string <Input>k__BackingField;

		// Token: 0x04000337 RID: 823
		[CompilerGenerated]
		private readonly string <Pattern>k__BackingField;

		// Token: 0x04000338 RID: 824
		[CompilerGenerated]
		private readonly TimeSpan <MatchTimeout>k__BackingField;
	}
}
