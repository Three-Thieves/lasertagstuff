using TerrorTown;
using Sandbox;

namespace QZarMods
{
	public class QZarMods
	{
		[Event("Player.PostDress")]
		public static void ApplyClothing(TerrorTown.Player ply)
		{
			var clothing = ResourceLibrary.Get<Clothing>("models/3t/qzar/vest/lasertagvest.clothing");
			
			ply.Clothing.Toggle(clothing);
			ply.Clothing.DressEntity(ply);
		}
	}
}