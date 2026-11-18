using HarmonyLib;

namespace MalachiTemp.Backend;

[HarmonyPatch(typeof(MonkeAgent), "GetRPCCallTracker")]
internal class b
{
	private static bool Prefix()
	{
		return false;
	}
}
