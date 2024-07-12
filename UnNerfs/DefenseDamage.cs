using CalamityMod.CalPlayer;
using CalamityUnNerfs.Config;
using CalamityUnNerfs.On;

namespace CalamityUnNerfs.UnNerfs;

public class DefenseDamage : BaseUnNerf {
    public override bool Active(UnNerfsConfig config) => config.DefenseDamage;

    public override void Apply() {
        base.Apply();
        OnCalPlayer.ApplyDefenseDamageInternal += calamityPlayerApplyDefenseDamageInternal;
    }

    public override void Revert() {
        OnCalPlayer.ApplyDefenseDamageInternal -= calamityPlayerApplyDefenseDamageInternal;
    }

    private void calamityPlayerApplyDefenseDamageInternal(OnCalPlayer.orig_ApplyDefenseDamageInternal orig, CalamityPlayer self,
        int defenseDamage, bool showVisuals) {
    }
}