﻿﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Projectiles.Auras
{
    public class KaiokenAuraProjx20 : AuraProjectile
    {
        public float KaioAuraTimer;
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 4;
        }
        public override void SetDefaults()
        {
            projectile.width = 97;
            projectile.height = 102;
            projectile.aiStyle = 0;
            projectile.alpha = 70;
            projectile.timeLeft = 10;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.penetrate = -1;
            projectile.damage = 0;
            KaioAuraTimer = 240;
            AuraOffset = -130;
            IsKaioAura = true;
            ScaleExtra = 2.8f;
        }
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            projectile.netUpdate = true;
            if (!player.HasBuff(mod.BuffType("KaiokenBuffX20")))
            {
                projectile.Kill();
            }
            if (KaioAuraTimer > 0)
            {
                //projectile.scale = 4f + 4f * (KaioAuraTimer / 240f);
                KaioAuraTimer--;
            }
            base.AI();
        }
    }
}