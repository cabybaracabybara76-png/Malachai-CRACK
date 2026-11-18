using HarmonyLib;

namespace MalachiTemp.Backend;

[HarmonyPatch(typeof(MonkeAgent), "DispatchReport")]
public class a
{
	private static bool Prefix()
	{
		return false;
	}
}
