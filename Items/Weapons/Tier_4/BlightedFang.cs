﻿﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Items.Weapons.Tier_4
{
    public class BlightedFang : KiItem
    {
        public override void SetDefaults()
        {
            item.shoot = mod.ProjectileType("BlightedFangProj");
            item.shootSpeed = 16f;
            item.damage = 62;
            item.knockBack = 4f;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 22;
            item.useTime = 22;
            item.width = 40;
            item.noUseGraphic = true;
            item.height = 40;
            item.autoReuse = false;
            item.value = 0;
            item.rare = 4;
            KiDrain = 120;
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("-Tier 4-");
            DisplayName.SetDefault("Blighted Fang");
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;
            return true;
        }

    }
}
