using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DBZMOD.Npcs
{
	public class MajinZombie : ModNPC
	{
        private int majinRegentimer;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Majin Zombie");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 84;
			npc.defense = 24;
			npc.lifeMax = 600;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.05f;
		}

        public override void AI()
        {
            majinRegentimer++;
            if(majinRegentimer > 12)
            {
                npc.life += 1;
                majinRegentimer = 0;
            }
            base.AI();
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(9) == 0)
            {
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CandyLaser"));
                }
            }
        }
    }
}
