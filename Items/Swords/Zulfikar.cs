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
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 10;
			Item.value = 10000;
			Item.rare = ItemRarityID.Lime;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
			Item.scale = 1f;
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