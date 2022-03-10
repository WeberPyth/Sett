using R2API;
using System;

namespace SettMod.Modules
{
    internal static class Tokens
    {
        public const string bossSubtitle = "The Boss";
        public const string characterLore = "A leader of Ionia's growing criminal underworld, Sett rose to prominence in the wake of the war with Noxus. Though he began as a humble challenger in the fighting pits of Navori, he quickly gained notoriety for his savage strength, and his ability to take seemingly endless amounts of punishment. Now, having climbed through the ranks of local combatants, Sett has muscled to the top, reigning over the pits he once fought in.";
        public const string characterName = "<color=#ffa700>Sett</color>";
        public const string characterOutro = "..and so he left, with newfound might to honor.";
        public const string characterOutroFailure = "..and so he returned, infallible bastion truly immortalized.";
        public const string characterSubtitle = "The Boss";

        public static string descriptionText =
             "瑟提是一名强力的重装战士：更高的基础生命值，更高的成长生命值，以及一系列与生命值有关的战斗能力。<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! >瑟提的基础攻击会在左右拳之间交替。虽然他的基础伤害不高，但是他的拳头会带有与他生命值上限有关的伤害，并且瑟提可以一边奔跑一边出拳。通过提升他的生命值，他的每一拳都将造成极为可观的伤害。" + Environment.NewLine + Environment.NewLine
             + "< ! >瑟提可以将他周围的敌人拉向他。如果他的敌人都在一侧，那么敌人将会减速而不是眩晕。你可以在将敌人拉到身旁之后释放 [叹为观止] ，将会对敌人造成毁灭性打击。" + Environment.NewLine + Environment.NewLine
             + "< ! >[叹为观止] 是瑟提的成名技。在释放这一技能后，瑟提将会抓起一名面前的敌人，将其带至空中，然后砸向大地，造成与瑟提最大生命值以及敌人最大生命值有关的伤害。提升瑟提的生命值，这一技能将对敌人造成巨额伤害。" + Environment.NewLine + Environment.NewLine
             + "< ! > 瑟提在承受伤害时会积攒拳意。释放 [蓄意轰拳] ，瑟提将会把他的拳意转化为极为可观的伤害，并且获得一个非常可靠的护盾。拳意的上限与瑟提的生命值上限有关，提升瑟提的生命值上限，让他的拳意更具威慑力。" + Environment.NewLine + Environment.NewLine;

        internal static void AddTokens()
        {
            LanguageAPI.Add("SETT_NAME", characterName);
            LanguageAPI.Add("OBSIDIAN_SETT_NAME", "<color=#ffa700>Obsidian Dragon Sett</color>");
            LanguageAPI.Add("POOL_SETT_NAME", "<color=#ffa700>Pool Party Sett</color>");
            LanguageAPI.Add("PRESTIGE_SETT_NAME", "<color=#ffa700>Prestige Obsidian Dragon Sett</color>");
            LanguageAPI.Add("MECHA_SETT_NAME", "<color=#ffa700>Mecha Kingdoms Sett</color>");
            LanguageAPI.Add("FIRECRACKER_SETT_NAME", "<color=#ffa700>Firecracker Sett</color>");
            LanguageAPI.Add("SETT_DESCRIPTION", descriptionText);
            LanguageAPI.Add("SETT_SUBTITLE", characterSubtitle);
            LanguageAPI.Add("SETT_LORE", characterLore);
            LanguageAPI.Add("SETT_OUTRO_FLAVOR", characterOutro);
            LanguageAPI.Add("SETT_OUTRO_FAILURE", characterOutroFailure);
            LanguageAPI.Add("SETT_DEFAULT_SKIN_NAME", "<color=#ffa700>Sett</color>");

            LanguageAPI.Add("SETT_PASSIVE_NAME", "<color=#ffa700>沙场豪情</color>");
            LanguageAPI.Add("SETT_PASSIVE_DESC", "瑟提每损失<color=#f68835>5%生命值</color>，获得<color=#008744>0.25/秒</color> <color=#d62d20>(+ 0.25 每4级)</color>生命恢复");

            LanguageAPI.Add("SETT_PRIMARY_NAME", "<color=#ffa700>屈人之威</color>");
            LanguageAPI.Add("SETT_PRIMARY_DESC", "瑟提的 <color=#c9aa71>基础攻击</color> 会交替使用他的左拳 <color=#f68835>(80%伤害+5%瑟提最大生命值)</color>和右拳<color=#f68835>(120%伤害+5%瑟提最大生命值)</color>");

            LanguageAPI.Add("SETT_SECONDARY_NAME", "<color=#ffa700>强手裂颅</color>");
            LanguageAPI.Add("SETT_SECONDARY_DESC", "瑟提将周围<color=#0057e7>20 m</color>范围内的所有敌人<color=#c9aa71>拉向</color>他，  造成 <color=#f68835>50% </color>伤害,并使敌人 <color=#c9aa71>眩晕/减速</color>");

            LanguageAPI.Add("SETT_UTILITY_NAME", "<color=#ffa700>叹为观止</color>");
            LanguageAPI.Add("SETT_UTILITY_DESC", "瑟提释放他的成名技， <color=#c9aa71>抓住</color> 一名敌人将其带到空中然后砸向大地, 造成<color=#f68835>300%瑟提最大生命值</color> <color=#d62d20>(+15%目标最大生命值/最大护盾值)</color> 的伤害，并对落地点附近的其他敌人造成等量伤害.");

            LanguageAPI.Add("SETT_SPECIAL_NAME", "<color=#ffa700>蓄意轰拳</color>");
            LanguageAPI.Add("SETT_SPECIAL_DESC", "瑟提在承受攻击时积攒 <color=#ffffff>拳意</color>. 瑟提将所有的 <color=#ffffff>拳意</color> 打出，造成 <color=#f68835>400%</color><color=#d62d20>(+500% 拳意值，此加成每4级额外增加5%)</color>的<color=#ffffff>真实伤害</color>,并获得相当于全部<color=#ffffff>拳意</color>值的 <color=#ffffff>护盾</color>");

            LanguageAPI.Add("SETT_CONQUEROR_NAME", "<color=#ffa700>Conqueror</color>");
            LanguageAPI.Add("SETT_CONQUEROR_DESC", "<color=#c9aa71>Successful attacks & abilties</color> against enemies grant <color=#ffffff>1</color> stack of conqueror up to 12 stacks. Each stack of Conqueror grants <color=#f68835>0.6</color> <color=#d62d20>(+0.045 every 4 levels)</color> bonus base damage. While fully stacked you <color=#c9aa71>heal</color> for <color=#008744>6% of any damage from abilities dealt to enemies.</color>");

            LanguageAPI.Add("SETT_LETHAL_NAME", "<color=#ffa700>Lethal Tempo</color>");
            LanguageAPI.Add("SETT_LETHAL_DESC", "<color=#c9aa71>Successful attacks & abilties</color> against enemies grant <color=#ffffff>1</color> stack of lethal tempo up to 6 stacks. Gain <color=#f68835>10%</color> bonus attack speed for each stack up to <color=#f68835>60%</color> bonus attack speed at maximum stacks.");

            LanguageAPI.Add("SETT_PHASE_RUSH_NAME", "<color=#ffa700>Phase Rush</color>");
            LanguageAPI.Add("SETT_PHASE_RUSH_DESC", "<color=#c9aa71>Successful attacks & abilties</color> generate <color=#c9aa71>1</color> stack against enemies. Applying <color=#ffffff>3</color> stacks to a target within a 4 second period grants you <color=#f68835>30%</color> <color=#d62d20>(+5% every 4 levels)</color> bonus <color=#c9aa71>movement speed</color> for 3 seconds. Grants the bonus <color=#c9aa71>movement speed</color> on kill.");

            LanguageAPI.Add("SETT_ELECTROCUTE_NAME", "<color=#ffa700>Electrocute</color>");
            LanguageAPI.Add("SETT_ELECTROCUTE_DESC", "<color=#c9aa71>Successful attacks & abilties</color> generate <color=#c9aa71>1</color> stack against enemies. Applying <color=#ffffff>3</color> stacks to a target within a 3 second period causes them to be struck by lightning after a 1-second delay, dealing them <color=#f68835>600%</color> <color=#d62d20>(+75% every 4 levels)</color> damage. Electrocute has a 5 second cooldown per target.");
        }
    }
}