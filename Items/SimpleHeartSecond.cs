using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BogdanMod.Items
{
	public class SimpleHeartSecond : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BogdanMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 18;
			Item.height = 18;
			Item.useTime = 1;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}