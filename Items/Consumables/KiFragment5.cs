﻿﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Consumables
{
    public class KiFragment5 : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 32;
            item.consumable = true;
            item.maxStack = 1;
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.value = 0;
            item.rare = 10;
            item.potion = false;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Master Ki Fragment");
            Tooltip.SetDefault("Increases your max ki by 2000.");
        }


        public override bool UseItem(Player player)
        {
            MyPlayer.ModPlayer(player).KiMax += 2000;
            MyPlayer.ModPlayer(player).Fragment5 = true;
            return true;

        }
        public override bool CanUseItem(Player player)
        {
            if (MyPlayer.ModPlayer(player).Fragment5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
