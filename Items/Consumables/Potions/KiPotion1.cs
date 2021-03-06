﻿﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Consumables.Potions
{
    public class KiPotion1 : KiPotion
    {
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 24;
            item.consumable = true;
            item.maxStack = 30;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 12;
            item.useTime = 12;
            item.value = 200;
            item.rare = 3;
            item.potion = false;
            IsKiPotion = true;
            KiHeal = 200;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lesser Ki Potion");
            Tooltip.SetDefault("Restores 200 Ki.");
        }
		 public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "StableKiCrystal", 2);
            recipe.AddIngredient(null, "ScrapMetal", 2);
            recipe.AddTile(null, "KiManipulator");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}