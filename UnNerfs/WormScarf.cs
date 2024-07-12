using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityUnNerfs.UnNerfs;

internal class WormScarf : GlobalItem {
    public override bool IsLoadingEnabled(Mod mod) => CalamityFly.config.WormScarf;


    public override void UpdateAccessory(Item item, Player player, bool hideVisual) {
        if (item.type == ItemID.WormScarf) {
            player.endurance += 0.07f;
        }
    }
}