using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BogdanMod.Items.Swords
{
	public class Zulfikar : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BogdanMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 36;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 1;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 10000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.Banana, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}