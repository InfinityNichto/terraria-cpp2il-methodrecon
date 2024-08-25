using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000129 RID: 297
	internal sealed class NetEventSource : EventSource
	{
		// Token: 0x060006F0 RID: 1776 RVA: 0x000194CC File Offset: 0x000176CC
		[NonEvent]
		public static void Enter(object thisOrContextObject, [Optional] FormattableString formattableString, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			if (formattableString != null)
			{
				if (!true)
				{
				}
				string text2 = NetEventSource.Format(formattableString);
				return;
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000194FC File Offset: 0x000176FC
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			object obj = NetEventSource.Format(arg0);
			string text2 = string.Format("({0})", obj);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00019530 File Offset: 0x00017730
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, object arg1, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			object obj = NetEventSource.Format(arg0);
			object obj2 = NetEventSource.Format(arg1);
			string text2 = string.Format("({0}, {1})", obj, obj2);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00019570 File Offset: 0x00017770
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			object obj = NetEventSource.Format(arg0);
			object obj2 = NetEventSource.Format(arg1);
			object obj3 = NetEventSource.Format(arg2);
			string text2 = string.Format("({0}, {1}, {2})", obj, obj2, obj3);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000195B8 File Offset: 0x000177B8
		[Event(1, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void Enter(string thisOrContextObject, string memberName, string parameters)
		{
			base.WriteEvent(1, thisOrContextObject, parameters, parameters);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000195D0 File Offset: 0x000177D0
		[NonEvent]
		public static void Exit(object thisOrContextObject, [Optional] FormattableString formattableString, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			if (formattableString != null)
			{
				if (!true)
				{
				}
				string text2 = NetEventSource.Format(formattableString);
				return;
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00019600 File Offset: 0x00017800
		[NonEvent]
		public static void Exit(object thisOrContextObject, object arg0, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			object obj = NetEventSource.Format(arg0);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00019628 File Offset: 0x00017828
		[NonEvent]
		public static void Exit(object thisOrContextObject, object arg0, object arg1, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			object obj = NetEventSource.Format(arg0);
			object obj2 = NetEventSource.Format(arg1);
			string text2 = string.Format("{0}, {1}", obj, obj2);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00019668 File Offset: 0x00017868
		[Event(2, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void Exit(string thisOrContextObject, string memberName, string result)
		{
			base.WriteEvent(2, thisOrContextObject, result, result);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00019680 File Offset: 0x00017880
		[NonEvent]
		public static void Info(object thisOrContextObject, [Optional] FormattableString formattableString, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			if (formattableString != null)
			{
				if (!true)
				{
				}
				string text2 = NetEventSource.Format(formattableString);
				return;
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000196B0 File Offset: 0x000178B0
		[NonEvent]
		public static void Info(object thisOrContextObject, object message, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			object obj = NetEventSource.Format(message);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000196D8 File Offset: 0x000178D8
		[Event(4, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void Info(string thisOrContextObject, string memberName, string message)
		{
			base.WriteEvent(4, thisOrContextObject, message, message);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x000196F0 File Offset: 0x000178F0
		[NonEvent]
		public static void Error(object thisOrContextObject, FormattableString formattableString, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			string text2 = NetEventSource.Format(formattableString);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00019718 File Offset: 0x00017918
		[NonEvent]
		public static void Error(object thisOrContextObject, object message, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			object obj = NetEventSource.Format(message);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00019740 File Offset: 0x00017940
		[Event(5, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
		private void ErrorMessage(string thisOrContextObject, string memberName, string message)
		{
			base.WriteEvent(5, thisOrContextObject, message, message);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00019758 File Offset: 0x00017958
		[NonEvent]
		public static void Fail(object thisOrContextObject, FormattableString formattableString, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			string text2 = NetEventSource.Format(formattableString);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00019780 File Offset: 0x00017980
		[NonEvent]
		public static void Fail(object thisOrContextObject, object message, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			object obj = NetEventSource.Format(message);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000197A8 File Offset: 0x000179A8
		[Event(6, Level = EventLevel.Critical, Keywords = (EventKeywords)2L)]
		private void CriticalFailure(string thisOrContextObject, string memberName, string message)
		{
			base.WriteEvent(6, thisOrContextObject, message, message);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000197C0 File Offset: 0x000179C0
		[NonEvent]
		public static void DumpBuffer(object thisOrContextObject, byte[] buffer, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000197D0 File Offset: 0x000179D0
		[NonEvent]
		public static void DumpBuffer(object thisOrContextObject, byte[] buffer, int offset, int count, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if ("DumpBuffer" == null || "DumpBuffer" != null)
			{
				FormattableString formattableString;
				NetEventSource.Fail(thisOrContextObject, formattableString, memberName);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00019820 File Offset: 0x00017A20
		[NonEvent]
		public static void DumpBuffer(object thisOrContextObject, IntPtr bufferPtr, int count, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			int num = 1024;
			int num2 = Math.Min(count, num);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00019858 File Offset: 0x00017A58
		[Event(7, Level = EventLevel.Verbose, Keywords = (EventKeywords)2L)]
		private void DumpBuffer(string thisOrContextObject, string memberName, byte[] buffer)
		{
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00019868 File Offset: 0x00017A68
		[NonEvent]
		public static void Associate(object first, object second, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(first);
			string text2 = NetEventSource.IdOf(first);
			string text3 = NetEventSource.IdOf(second);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00019898 File Offset: 0x00017A98
		[NonEvent]
		public static void Associate(object thisOrContextObject, object first, object second, [CallerMemberName] [Optional] string memberName)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			string text = NetEventSource.IdOf(thisOrContextObject);
			string text2 = NetEventSource.IdOf(first);
			string text3 = NetEventSource.IdOf(second);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000198C8 File Offset: 0x00017AC8
		[Event(3, Level = EventLevel.Informational, Keywords = (EventKeywords)1L, Message = "[{2}]<-->[{3}]")]
		private void Associate(string thisOrContextObject, string memberName, string first, string second)
		{
			this.WriteEvent(3, thisOrContextObject, first, first, second);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000198E4 File Offset: 0x00017AE4
		[Conditional("DEBUG_NETEVENTSOURCE_MISUSE")]
		private static void DebugValidateArg(object arg)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000198FC File Offset: 0x00017AFC
		[Conditional("DEBUG_NETEVENTSOURCE_MISUSE")]
		private static void DebugValidateArg(FormattableString arg)
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0001990C File Offset: 0x00017B0C
		public new static bool IsEnabled
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				return flag;
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00019920 File Offset: 0x00017B20
		[NonEvent]
		public static string IdOf(object value)
		{
			string text;
			return text;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
		[NonEvent]
		public static int GetHashCode(object value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00019934 File Offset: 0x00017B34
		[NonEvent]
		public static object Format(object value)
		{
			if ("(null)" != null)
			{
				return "(null)";
			}
			if ("(null)" != null)
			{
			}
			string text = NetEventSource.IdOf("(null)");
			string text3;
			string text2 = string.Format("0x{0:X}", text3);
			Type type = text3.GetType();
			int stringLength = text3._stringLength;
			throw new InvalidCastException();
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001998C File Offset: 0x00017B8C
		[NonEvent]
		private static string Format(FormattableString s)
		{
			object obj2;
			object obj = NetEventSource.Format(obj2);
			string text;
			return text;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000199F0 File Offset: 0x00017BF0
		[NonEvent]
		private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4)
		{
			bool flag = base.IsEnabled();
			if (arg1 != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				int offsetToStringData2 = RuntimeHelpers.OffsetToStringData;
				int offsetToStringData3 = RuntimeHelpers.OffsetToStringData;
				return;
			}
			int offsetToStringData4 = RuntimeHelpers.OffsetToStringData;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00019A38 File Offset: 0x00017C38
		[NonEvent]
		private void WriteEvent(int eventId, string arg1, string arg2, byte[] arg3)
		{
			bool flag = base.IsEnabled();
			if (arg3 != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				int offsetToStringData2 = RuntimeHelpers.OffsetToStringData;
				if (arg3 != null)
				{
					return;
				}
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00019A68 File Offset: 0x00017C68
		[NonEvent]
		private void WriteEvent(int eventId, string arg1, int arg2, int arg3, int arg4)
		{
			bool flag = base.IsEnabled();
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00019A90 File Offset: 0x00017C90
		[NonEvent]
		private void WriteEvent(int eventId, string arg1, int arg2, string arg3)
		{
			bool flag = base.IsEnabled();
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			int offsetToStringData2 = RuntimeHelpers.OffsetToStringData;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00019AB8 File Offset: 0x00017CB8
		[NonEvent]
		private void WriteEvent(int eventId, string arg1, string arg2, int arg3)
		{
			bool flag = base.IsEnabled();
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			int offsetToStringData2 = RuntimeHelpers.OffsetToStringData;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00019AE0 File Offset: 0x00017CE0
		[NonEvent]
		private void WriteEvent(int eventId, string arg1, string arg2, string arg3, int arg4)
		{
			bool flag = base.IsEnabled();
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			int offsetToStringData2 = RuntimeHelpers.OffsetToStringData;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00019B14 File Offset: 0x00017D14
		public NetEventSource()
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00019B28 File Offset: 0x00017D28
		// Note: this type is marked as 'beforefieldinit'.
		static NetEventSource()
		{
		}

		// Token: 0x0400056A RID: 1386
		public static readonly NetEventSource Log;

		// Token: 0x0400056B RID: 1387
		private const string MissingMember = "(?)";

		// Token: 0x0400056C RID: 1388
		private const string NullInstance = "(null)";

		// Token: 0x0400056D RID: 1389
		private const string StaticMethodObject = "(static)";

		// Token: 0x0400056E RID: 1390
		private const string NoParameters = "";

		// Token: 0x0400056F RID: 1391
		private const int MaxDumpSize = 1024;

		// Token: 0x04000570 RID: 1392
		private const int EnterEventId = 1;

		// Token: 0x04000571 RID: 1393
		private const int ExitEventId = 2;

		// Token: 0x04000572 RID: 1394
		private const int AssociateEventId = 3;

		// Token: 0x04000573 RID: 1395
		private const int InfoEventId = 4;

		// Token: 0x04000574 RID: 1396
		private const int ErrorEventId = 5;

		// Token: 0x04000575 RID: 1397
		private const int CriticalFailureEventId = 6;

		// Token: 0x04000576 RID: 1398
		private const int DumpArrayEventId = 7;

		// Token: 0x04000577 RID: 1399
		private const int EnumerateSecurityPackagesId = 8;

		// Token: 0x04000578 RID: 1400
		private const int SspiPackageNotFoundId = 9;

		// Token: 0x04000579 RID: 1401
		private const int AcquireDefaultCredentialId = 10;

		// Token: 0x0400057A RID: 1402
		private const int AcquireCredentialsHandleId = 11;

		// Token: 0x0400057B RID: 1403
		private const int InitializeSecurityContextId = 12;

		// Token: 0x0400057C RID: 1404
		private const int SecurityContextInputBufferId = 13;

		// Token: 0x0400057D RID: 1405
		private const int SecurityContextInputBuffersId = 14;

		// Token: 0x0400057E RID: 1406
		private const int AcceptSecuritContextId = 15;

		// Token: 0x0400057F RID: 1407
		private const int OperationReturnedSomethingId = 16;

		// Token: 0x04000580 RID: 1408
		private const int NextAvailableEventId = 17;

		// Token: 0x0200012A RID: 298
		public class Keywords
		{
			// Token: 0x06000718 RID: 1816 RVA: 0x00019B38 File Offset: 0x00017D38
			public Keywords()
			{
			}

			// Token: 0x04000581 RID: 1409
			public const EventKeywords Default = (EventKeywords)1L;

			// Token: 0x04000582 RID: 1410
			public const EventKeywords Debug = (EventKeywords)2L;

			// Token: 0x04000583 RID: 1411
			public const EventKeywords EnterExit = (EventKeywords)4L;
		}
	}
}
