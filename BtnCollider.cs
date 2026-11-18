using MalachiTemp.Backend;
using MalachiTemp.UI;
using UnityEngine;
using dfgsfe;

internal class BtnCollider : MonoBehaviour
{
	public static int framePressCooldown;

	public string relatedText;

	public static bool La(string s)
	{
		return s != "sear" && s != "Dis" && s != "Next" && s != "Prev" && s != "Home" && !s.StartsWith("Exit ") && s != "Favorite Mods";
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (Time.frameCount < framePressCooldown + WristMenu.clickcool || (!(((Object)collider).name == "bp") && !(((Object)collider).name == "bp1")))
		{
			return;
		}
		bool flag = ((Object)collider).name == "bp";
		float num = Mods.GIn().tapHapticStrength / 10f;
		if (!Mods.searching)
		{
			int s = ((WristMenu.gripDownL && WristMenu.gripDownR && La(relatedText)) ? 213 : (-1));
			if (!Mods.right)
			{
				Mods.GIn().StartVibration(false, num, 0.001f);
				Gui.PT(b: false, s);
			}
			else
			{
				Mods.GIn().StartVibration(true, num, 0.001f);
				Gui.PT(b: true, s);
			}
		}
		else
		{
			Mods.GIn().StartVibration(!flag, num, 0.001f);
			Gui.PT(!flag, (Mods.actsearch && WristMenu.gripDownL && WristMenu.gripDownR && La(relatedText)) ? 213 : (-1));
		}
		WristMenu.Toggle(relatedText);
		framePressCooldown = Time.frameCount;
	}
}
