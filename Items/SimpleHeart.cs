using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BogdanMod.Items
{
	public class SimpleHeart : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BogdanMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 5;
			Item.DamageType = DamageClass.Melee;
			Item.width = 9;
			Item.height = 9;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 600;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}