using HarmonyLib;

namespace MalachiTemp.Backend;

[HarmonyPatch(typeof(MonkeAgent), "CheckReports")]
public class c
{
	private static bool Prefix()
	{
		return false;
	}
}
