﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Armor.ArmorSets
{
    [AutoloadEquip(EquipType.Legs)]
    public class RadiantGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("10% Increased Ki Damage"
                + "\n16% Increased Ki Crit Chance" +
                               "\n+500 Max Ki" +
                               "\nIncreased Ki Regen" +
                               "\n26% Increased movement speed");
            DisplayName.SetDefault("Radiant Greaves");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 34000;
            item.rare = 10;
            item.defense = 14;
        }
        public override void UpdateEquip(Player player)
        {
            MyPlayer.ModPlayer(player).KiDamage += 0.10f;
            MyPlayer.ModPlayer(player).KiCrit += 16;
            MyPlayer.ModPlayer(player).KiMax += 500;
            MyPlayer.ModPlayer(player).KiRegen += 3;
            player.moveSpeed += 0.26f;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 12);
            recipe.AddIngredient(null, "RadiantFragment", 15);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}