using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using BogdanMod.Items.Swords;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.ID;
using Terraria.ModLoader;

namespace BogdanMod.NPCs.Enemies
{

    [AutoloadHead]

    public class BabaYaga: ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.CanFormatWith("Yaga");
        }
        public override void SetDefaults()
        {
          NPC.townNPC = true;
          NPC.friendly = true;
          NPC.width = 22;
          NPC.height = 46;
          NPC.aiStyle = 7;
          NPC.defense = 20;
          NPC.lifeMax = 300;
          NPC.HitSound = SoundID.NPCHit1;
          NPC.DeathSound = SoundID.NPCDeath1;
          NPC.knockBackResist = 0.5f;
          Main.npcFrameCount[NPC.type] = 25;
          NPCID.Sets.ExtraFramesCount[NPC.type] = 0;
          NPCID.Sets.AttackFrameCount[NPC.type] = 0;
          NPCID.Sets.DangerDetectRange[NPC.type] = -1;
          NPCID.Sets.AttackType[NPC.type] = 3;
          NPCID.Sets.AttackTime[NPC.type] = 30;
          NPCID.Sets.AttackAverageChance[NPC.type] = 10;
          NPCID.Sets.HatOffsetY[NPC.type] = 4;
          AnimationType = 22;
        }

        public override void DrawTownAttackSwing(ref Texture2D item, ref Rectangle itemFrame, ref int itemSize, ref float scale, ref Vector2 offset)
        {
          //  item.Name=;
            // itemFrame = null;
            itemSize = 10;
            scale = 10;
         //   offset = Vector2.UnitX;


            
            
            base.DrawTownAttackSwing(ref item, ref itemFrame, ref itemSize, ref scale, ref offset);
        }
        /*    public override bool CanTownNPCSpawn(int numTownNPCs, int money)
            {
                for (var i = 0; i < 255; i++)
                {
                    Player player = Main.player[i];
                    foreach (Item item in player.inventory)
                    {
                        if (item.type == ItemID.WoodenArrow)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            public override List<string> SetNPCNameList()
            {
                return new List<string>()
                {
                    "Orion",
                    "Apollo",
                    "Robin"
                };
            }

            public override void SetChatButtons(ref string button, ref string button2)
            {
                button = "Shop";
                button2 = "This is the second button";
            }

            public override void OnChatButtonClicked(bool firstButton, ref bool shop)
            {
                if (firstButton)
                {
                    shop = true;
                }
            }

            public override void SetupShop(Chest shop, ref int nextSlot)
            {
                //Wooden Arrow
                shop.item[nextSlot].SetDefaults(ItemID.WoodenArrow, false);
                shop.item[nextSlot].value = 1;
                nextSlot++;

                shop.item[nextSlot].SetDefaults(ItemID.WoodenBow, false);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(ItemID.TinBow, false);
                shop.item[nextSlot].value = 500;          
                nextSlot++;

                if (NPC.downedBoss1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PlatinumBow, false);
                    nextSlot++;
                }
            }
    */

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Pupochki";
            button2 = "Zhmachechki";
        }
        public override void OnChatButtonClicked(bool firstButton, ref string Pupochki)
        {
            if (firstButton)
            {
                Pupochki = "Yaga's Shop";
            }
        }
        public override void AddShops()
        {
            //ItemID.Wood;
        }
        public override string GetChat()
        {
            NPC.FindFirstNPC(ModContent.NPCType<BabaYaga>());
            switch (Main.rand.Next(3))
            {
                case 0:
                    return "If you're a gunslinger, you can see yourself out.";
                case 1:
                    return "This is the second case";
                case 2:
                    return "This is the third case";
                default:
                    return "This is the default case.";
            }
        }


        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 30;
            knockback = 2f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 5;
            randExtraCooldown = 10;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.WoodenArrowFriendly;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 7f;
        }

        public override void OnKill()
        {
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Wood, 1, false, 0, false, false);
        }
    }
}

    

