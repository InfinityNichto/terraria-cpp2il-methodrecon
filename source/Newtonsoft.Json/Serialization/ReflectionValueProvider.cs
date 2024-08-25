using System;
using System.Reflection;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B4 RID: 180
	[Preserve]
	public class ReflectionValueProvider : IValueProvider
	{
		// Token: 0x060006BC RID: 1724 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
			ValidationUtils.ArgumentNotNull(memberInfo, "memberInfo");
			this._memberInfo = memberInfo;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00011E0C File Offset: 0x0001000C
		public void SetValue(object target, object value)
		{
			int num = 1;
			MemberInfo memberInfo = this._memberInfo;
			if (num == 0)
			{
			}
			ReflectionUtils.SetMemberValue(memberInfo, target, value);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00011E5C File Offset: 0x0001005C
		public object GetValue(object target)
		{
			int num = 1;
			MemberInfo memberInfo = this._memberInfo;
			if (num == 0)
			{
			}
			return ReflectionUtils.GetMemberValue(memberInfo, target);
		}

		// Token: 0x040002E8 RID: 744
		private readonly MemberInfo _memberInfo;
	}
}
