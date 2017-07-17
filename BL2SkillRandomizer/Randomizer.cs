using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BL2SkillRandomizer
{
    public partial class Randomizer : Form
    {
        /* 
         * randomly distribute every skill -> 0-3 on each level.
         * Scan the result, see if it is possible to reach capstones.
         * If not, repeat step 1
         * If so -> see for each level how many skills are in there
         * Set that number of random slots on that level to true
        */
        Random.Org.Random r = new Random.Org.Random();
        public Randomizer()
        {
            InitializeComponent();
            r.UseLocalMode = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Zer0Random();
        }
        private void KriegButton_Click(object sender, EventArgs e)
        {
            KriegRandom();
        }
        private void Randomizer_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MayaRandom();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AxtonRandom();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SalRandom();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GaigeRandom();
        }
        public void Zer0Random()
        {
            #region Setup
            DialogSaver.RestoreDirectory = true;
            DialogSaver.DefaultExt = "hotfix";
            DialogSaver.Filter = "Hotfix files (*.hotfix)|*.hotfix";
            DialogSaver.Title = "Save Randomized Skill Tree";
            DialogSaver.CheckFileExists = false;
            DialogSaver.CheckPathExists = true;
            #endregion
            if (DialogSaver.ShowDialog() == DialogResult.OK)
            {
                string[] SkillList = { "GD_Assassin_Skills.Sniping.HeadShot", "GD_Assassin_Skills.Sniping.Optics", "GD_Assassin_Skills.Sniping.Killer", "GD_Assassin_Skills.Sniping.Precision", "GD_Assassin_Skills.Sniping.OneShotOneKill", "GD_Assassin_Skills.Sniping.Bore", "GD_Assassin_Skills.Sniping.Velocity", "GD_Assassin_Skills.Sniping.KillConfirmed", "GD_Assassin_Skills.Sniping.AtOneWithTheGun", "GD_Assassin_Skills.Sniping.CriticalAscention", "GD_Assassin_Skills.Cunning.FastHands", "GD_Assassin_Skills.Cunning.CounterStrike", "GD_Assassin_Skills.Cunning.Fearless", "GD_Assassin_Skills.Cunning.Ambush", "GD_Assassin_Skills.Cunning.RisingShot", "GD_Assassin_Skills.Cunning.DeathMark", "GD_Assassin_Skills.Cunning.Unforseen", "GD_Assassin_Skills.Cunning.Innervate", "GD_Assassin_Skills.Cunning.TwoFang", "GD_Assassin_Skills.Cunning.DeathBlossom", "GD_Assassin_Skills.Bloodshed.KillingBlow", "GD_Assassin_Skills.Bloodshed.IronHand", "GD_Assassin_Skills.Bloodshed.Grim", "GD_Assassin_Skills.Bloodshed.BeLikeWater", "GD_Assassin_Skills.Bloodshed.Followthrough", "GD_Assassin_Skills.Bloodshed.Execute", "GD_Assassin_Skills.Bloodshed.Backstab", "GD_Assassin_Skills.Bloodshed.Resurgence", "GD_Assassin_Skills.Bloodshed.LikeTheWind", "GD_Assassin_Skills.Bloodshed.ManyMustFall" };
                using (var sw = new StreamWriter(DialogSaver.FileName))
                {
                    sw.WriteLine("start OnDemand GD_Assassin_Streaming");
                    string SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("## Sniping ##" + Environment.NewLine);
                    #region Sniping
                    #region Sniping Tier - 1
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 2
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 3
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 4
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 5
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 6
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Cunning ##" + Environment.NewLine);
                    #region Cunning
                    #region Cunning Tier - 1
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 2
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 3
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 4
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 5
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Cunning Tier - 6
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Bloodshed ##" + Environment.NewLine);
                    #region Bloodshed
                    #region Bloodshed Tier - 1
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 2
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 3
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 4
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 5
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Bloodshed Tier - 6
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    #endregion
                    #endregion
                    #region Skill Tree Name Randomizer
                    string[] SkillTreeBranchNames = { "Snider", "class", "mods", "redux", "dandy", "even.", ".", "Dexiduous", "Vorac", "A", "Skill Tree Name", "shake", "Milkshake", "Monty", "Python", "Atlantic", "Slot", "Machine", "BBC", "Bloodshed", "Pie", "good", "comedy", "British", "Larry", "Cable", "the", "sellout", "money", "stupid", "REKT", "beatle", "member", "withdrew", "film", "life", "of", "average", "former", "Tier", "6", "Skill", "paid", "back", "then", "residuals", "perpetuity", "who", "bark", "ruff", "ban", "shell", "vision" };
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    #endregion
                    MessageBox.Show("Skill Tree Randomized!");
                }
            }
        }
        public void MayaRandom()
        {
            #region Setup
            DialogSaver.RestoreDirectory = true;
            DialogSaver.DefaultExt = "hotfix";
            DialogSaver.Filter = "Hotfix files (*.hotfix)|*.hotfix";
            DialogSaver.Title = "Save Randomized Skill Tree";
            DialogSaver.CheckFileExists = false;
            DialogSaver.CheckPathExists = true;
            #endregion
            if (DialogSaver.ShowDialog() == DialogResult.OK)
            {
                string[] SkillList = { "GD_Siren_Skills.Motion.Ward", "GD_Siren_Skills.Motion.Accelerate", "GD_Siren_Skills.Motion.Suspension", "GD_Siren_Skills.Motion.KineticReflection", "GD_Siren_Skills.Motion.Converge", "GD_Siren_Skills.Motion.Fleet", "GD_Siren_Skills.Motion.Inertia", "GD_Siren_Skills.Cataclysm.Ruin", "GD_Siren_Skills.Motion.Quicken", "GD_Siren_Skills.Motion.SubSequence", "GD_Siren_Skills.Motion.ThoughtLock", "GD_Siren_Skills.Harmony.MindsEye", "GD_Siren_Skills.Harmony.SweetRelease", "GD_Siren_Skills.Harmony.Restoration", "GD_Siren_Skills.Harmony.Wreck", "GD_Siren_Skills.Harmony.Res", "GD_Siren_Skills.Harmony.Scorn", "GD_Siren_Skills.Cataclysm.Flicker", "GD_Siren_Skills.Cataclysm.Foresight", "GD_Siren_Skills.Cataclysm.Immolate", "GD_Siren_Skills.Harmony.Elated", "GD_Siren_Skills.Harmony.Recompense", "GD_Siren_Skills.Harmony.Sustenance", "GD_Siren_Skills.Harmony.LifeTap", "GD_Siren_Skills.Cataclysm.Helios", "GD_Siren_Skills.Cataclysm.CloudKill", "GD_Siren_Skills.Cataclysm.ChainReaction", "GD_Siren_Skills.Cataclysm.Backdraft", "GD_Siren_Skills.Cataclysm.Reaper", "GD_Siren_Skills.Cataclysm.BlightPhoenix" };
                using (var sw = new StreamWriter(DialogSaver.FileName))
                {
                    sw.WriteLine("start OnDemand GD_Siren_Streaming");
                    string SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("## Motion ##" + Environment.NewLine);
                    #region Sniping
                    #region Sniping Tier - 1
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 2
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 3
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 4
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 5
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 6
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Harmony ##" + Environment.NewLine);
                    #region Cunning
                    #region Cunning Tier - 1
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 2
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 3
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 4
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 5
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Cunning Tier - 6
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Cataclysm ##" + Environment.NewLine);
                    #region Bloodshed
                    #region Bloodshed Tier - 1
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 2
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 3
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 4
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 5
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Bloodshed Tier - 6
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    #endregion
                    #endregion
                    #region Skill Tree Name Randomizer
                    string[] SkillTreeBranchNames = { "Snider", "class", "mods", "redux", "dandy", "even.", ".", "Dexiduous", "Vorac", "A", "Skill Tree Name", "shake", "Milkshake", "Monty", "Python", "Atlantic", "Slot", "Machine", "BBC", "Bloodshed", "Pie", "good", "comedy", "British", "Larry", "Cable", "the", "sellout", "money", "stupid", "REKT", "beatle", "member", "withdrew", "film", "life", "of", "average", "former", "Tier", "6", "Skill", "paid", "back", "then", "residuals", "perpetuity", "who", "bark", "ruff", "ban", "shell", "vision" };
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Motion BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Harmony BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Siren_Skills.SkillTree.Branch_Cataclysm BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    #endregion
                    MessageBox.Show("Skill Tree Randomized!");
                }
            }
        }
        public void AxtonRandom()
        {
            #region Setup
            DialogSaver.RestoreDirectory = true;
            DialogSaver.DefaultExt = "hotfix";
            DialogSaver.Filter = "Hotfix files (*.hotfix)|*.hotfix";
            DialogSaver.Title = "Save Randomized Skill Tree";
            DialogSaver.CheckFileExists = false;
            DialogSaver.CheckPathExists = true;
            #endregion
            if (DialogSaver.ShowDialog() == DialogResult.OK)
            {
                string[] SkillList = { "GD_Soldier_Skills.Guerrilla.Sentry", "GD_Soldier_Skills.Guerrilla.Ready", "GD_Soldier_Skills.Guerrilla.LaserSight", "GD_Soldier_Skills.Guerrilla.Willing", "GD_Soldier_Skills.Guerrilla.Onslaught", "GD_Soldier_Skills.Guerrilla.ScorchedEarth", "GD_Soldier_Skills.Guerrilla.Able", "GD_Soldier_Skills.Guerrilla.Grenadier", "GD_Soldier_Skills.Guerrilla.CrisisManagement", "GD_Soldier_Skills.Guerrilla.DoubleUp", "GD_Soldier_Skills.Gunpowder.Impact", "GD_Soldier_Skills.Gunpowder.Expertise", "GD_Soldier_Skills.Gunpowder.Overload", "GD_Soldier_Skills.Gunpowder.MetalStorm", "GD_Soldier_Skills.Gunpowder.Steady", "GD_Soldier_Skills.Gunpowder.LongBowTurret", "GD_Soldier_Skills.Gunpowder.Battlefront", "GD_Soldier_Skills.Gunpowder.DutyCalls", "GD_Soldier_Skills.Gunpowder.DoOrDie", "GD_Soldier_Skills.Gunpowder.Ranger", "GD_Soldier_Skills.Gunpowder.Nuke", "GD_Soldier_Skills.Survival.HealthY", "GD_Soldier_Skills.Survival.Preparation", "GD_Soldier_Skills.Survival.LastDitchEffort", "GD_Soldier_Skills.Survival.Pressure", "GD_Soldier_Skills.Survival.Forbearance", "GD_Soldier_Skills.Survival.PhalanxShield", "GD_Soldier_Skills.Survival.QuickCharge", "GD_Soldier_Skills.Survival.Resourceful", "GD_Soldier_Skills.Survival.Grit", "GD_Soldier_Skills.Survival.Mag-Lock", "GD_Soldier_Skills.Survival.Gemini" };
                using (var sw = new StreamWriter(DialogSaver.FileName))
                {
                    sw.WriteLine("start OnDemand GD_Soldier_Streaming");
                    string SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("## Guerrila ##" + Environment.NewLine);
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #region Sniping Tier - 2
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 3
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 4
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 5
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 6
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    sw.WriteLine("## Gunpowder ##" + Environment.NewLine);
                    #region Gunpowder
                    #region Cunning Tier - 1
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 2
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 3
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 4
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 5
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Cunning Tier - 6
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Survival ##" + Environment.NewLine);
                    #region Survival
                    #region Bloodshed Tier - 1
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 2
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 3
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 4
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 5
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Bloodshed Tier - 6
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    #endregion
                    #endregion
                    #region Skill Tree Name Randomizer
                    string[] SkillTreeBranchNames = { "Snider", "class", "mods", "redux", "dandy", "even.", ".", "Dexiduous", "Vorac", "A", "Skill Tree Name", "shake", "Milkshake", "Monty", "Python", "Atlantic", "Slot", "Machine", "BBC", "Bloodshed", "Pie", "good", "comedy", "British", "Larry", "Cable", "the", "sellout", "money", "stupid", "REKT", "beatle", "member", "withdrew", "film", "life", "of", "average", "former", "Tier", "6", "Skill", "paid", "back", "then", "residuals", "perpetuity", "who", "bark", "ruff", "ban", "shell", "vision" };
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Survival BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Gunpowder BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Soldier_Skills.SkillTree.Branch_Guerrilla BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    #endregion
                    MessageBox.Show("Skill Tree Randomized!");
                }
            }
        }
        public void SalRandom()
        {
            #region Setup
            DialogSaver.RestoreDirectory = true;
            DialogSaver.DefaultExt = "hotfix";
            DialogSaver.Filter = "Hotfix files (*.hotfix)|*.hotfix";
            DialogSaver.Title = "Save Randomized Skill Tree";
            DialogSaver.CheckFileExists = false;
            DialogSaver.CheckPathExists = true;
            #endregion
            if (DialogSaver.ShowDialog() == DialogResult.OK)
            {
                string[] SkillList = { "GD_Mercenary_Skills.Gun_Lust.LockedandLoaded", "GD_Mercenary_Skills.Gun_Lust.QuickDraw", "GD_Mercenary_Skills.Gun_Lust.ImYourHuckleberry", "GD_Mercenary_Skills.Gun_Lust.AllIneedIsOne", "GD_Mercenary_Skills.Gun_Lust.DivergentLikness", "GD_Mercenary_Skills.Gun_Lust.AutoLoader", "GD_Mercenary_Skills.Gun_Lust.MoneyShot", "GD_Mercenary_Skills.Gun_Lust.LayWaste", "GD_Mercenary_Skills.Gun_Lust.DownNotOut", "GD_Mercenary_Skills.Gun_Lust.KeepItPipingHot", "GD_Mercenary_Skills.Gun_Lust.NoKillLikeOverkill", "GD_Mercenary_Skills.Rampage.Inconceivable", "GD_Mercenary_Skills.Rampage.FilledtotheBrim", "GD_Mercenary_Skills.Rampage.AllInTheReflexes", "GD_Mercenary_Skills.Rampage.LastLonger", "GD_Mercenary_Skills.Rampage.ImReadyAlready", "GD_Mercenary_Skills.Rampage.SteadyAsSheGoes", "GD_Mercenary_Skills.Rampage.5Shotsor6", "GD_Mercenary_Skills.Rampage.YippeeKiYay", "GD_Mercenary_Skills.Rampage.DoubleYourFun", "GD_Mercenary_Skills.Rampage.GetSome", "GD_Mercenary_Skills.Rampage.KeepFiring", "GD_Mercenary_Skills.Brawn.Diehard", "GD_Mercenary_Skills.Brawn.Incite", "GD_Mercenary_Skills.Brawn.Asbestos", "GD_Mercenary_Skills.Brawn.ImTheJuggernaut", "GD_Mercenary_Skills.Brawn.AintGotTimeToBleed", "GD_Mercenary_Skills.Brawn.FistfulOfHurt", "GD_Mercenary_Skills.Brawn.OutOfBubblegum", "GD_Mercenary_Skills.Brawn.BusThatCantSlowDown", "GD_Mercenary_Skills.Brawn.JustGotReal", "GD_Mercenary_Skills.Brawn.SexualTyrannosaurus", "GD_Mercenary_Skills.Brawn.ComeAtMeBro" };
                using (var sw = new StreamWriter(DialogSaver.FileName))
                {
                    sw.WriteLine("start OnDemand GD_Mercenary_Streaming");
                    string SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("## Gun Lust ##" + Environment.NewLine);
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #region Sniping Tier - 2
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 3
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 4
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 5
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 6
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    sw.WriteLine("## Rampage ##" + Environment.NewLine);
                    #region Gunpowder
                    #region Cunning Tier - 1
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 2
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 3
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 4
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 5
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Cunning Tier - 6
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Brawn ##" + Environment.NewLine);
                    #region Survival
                    #region Bloodshed Tier - 1
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 2
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 3
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 4
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 5
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Bloodshed Tier - 6
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    #endregion
                    #endregion
                    #region Skill Tree Name Randomizer
                    string[] SkillTreeBranchNames = { "Snider", "class", "mods", "redux", "dandy", "even.", ".", "Dexiduous", "Vorac", "A", "Skill Tree Name", "shake", "Milkshake", "Monty", "Python", "Atlantic", "Slot", "Machine", "BBC", "Bloodshed", "Pie", "good", "comedy", "British", "Larry", "Cable", "the", "sellout", "money", "stupid", "REKT", "beatle", "member", "withdrew", "film", "life", "of", "average", "former", "Tier", "6", "Skill", "paid", "back", "then", "residuals", "perpetuity", "who", "bark", "ruff", "ban", "shell", "vision" };
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Brawn BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_Rampage BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Mercenary_Skills.SkillTree.Branch_GunLust BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    MessageBox.Show("Skill Tree Randomized!");
                    #endregion
                }
            }
        }
        public void KriegRandom()
        {
            #region Setup
            DialogSaver.RestoreDirectory = true;
            DialogSaver.DefaultExt = "hotfix";
            DialogSaver.Filter = "Hotfix files (*.hotfix)|*.hotfix";
            DialogSaver.Title = "Save Randomized Skill Tree";
            DialogSaver.CheckFileExists = false;
            DialogSaver.CheckPathExists = true;
            #endregion
            if (DialogSaver.ShowDialog() == DialogResult.OK)
            {
                string[] SkillList = { "GD_Lilac_Skills_Bloodlust.Skills.BloodfilledGuns", "GD_Lilac_Skills_Bloodlust.Skills.BloodyTwitch", "GD_Lilac_Skills_Bloodlust.Skills.TasteOfBlood", "GD_Lilac_Skills_Bloodlust.Skills.BloodyRevival", "GD_Lilac_Skills_Bloodlust.Skills.BloodOverdrive", "GD_Lilac_Skills_Bloodlust.Skills.BloodBath", "GD_Lilac_Skills_Bloodlust.Skills.BuzzAxeBombadier", "GD_Lilac_Skills_Bloodlust.Skills.FuelTheBlood", "GD_Lilac_Skills_Bloodlust.Skills.BloodTrance", "GD_Lilac_Skills_Bloodlust.Skills.BoilingBlood", "GD_Lilac_Skills_Bloodlust.Skills.NervousBlood", "GD_Lilac_Skills_Bloodlust.Skills.Bloodsplosion", "GD_Lilac_Skills_Mania.Skills.EmptyRage", "GD_Lilac_Skills_Mania.Skills.PullThePin", "GD_Lilac_Skills_Mania.Skills.FeedTheMeat", "GD_Lilac_Skills_Mania.Skills.EmbraceThePain", "GD_Lilac_Skills_Mania.Skills.FuelTheRampage", "GD_Lilac_Skills_Mania.Skills.ThrillOfTheKill", "GD_Lilac_Skills_Mania.Skills.LightTheFuse", "GD_Lilac_Skills_Mania.Skills.StripTheFlesh", "GD_Lilac_Skills_Mania.Skills.RedeemTheSoul", "GD_Lilac_Skills_Mania.Skills.SaltTheWound", "GD_Lilac_Skills_Mania.Skills.SilenceTheVoices", "GD_Lilac_Skills_Mania.Skills.ReleaseTheBeast", "GD_Lilac_Skills_Hellborn.Skills.BurnBabyBurn", "GD_Lilac_Skills_Hellborn.Skills.FuelTheFire", "GD_Lilac_Skills_Hellborn.Skills.NumbedNerves", "GD_Lilac_Skills_Hellborn.Skills.PainIsPower", "GD_Lilac_Skills_Hellborn.Skills.ElementalElation", "GD_Lilac_Skills_Hellborn.Skills.DelusionalDamage", "GD_Lilac_Skills_Hellborn.Skills.FireFiend", "GD_Lilac_Skills_Hellborn.Skills.FlameFlare", "GD_Lilac_Skills_Hellborn.Skills.HellfireHalitosis", "GD_Lilac_Skills_Hellborn.Skills.ElementalEmpathy", "GD_Lilac_Skills_Hellborn.Skills.RavingRetribution"};
                using (var sw = new StreamWriter(DialogSaver.FileName))
                {
                    sw.WriteLine("start OnDemand GD_Lilac_Psycho_Streaming");
                    string SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("## Bloodlust ##" + Environment.NewLine);
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #region Sniping Tier - 2
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[1].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 3
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 4
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 5
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 6
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    sw.WriteLine("## Mania ##" + Environment.NewLine);
                    #region Gunpowder
                    #region Cunning Tier - 1
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[0].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 2
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 3
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 4
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 5
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Cunning Tier - 6
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Hellborn ##" + Environment.NewLine);
                    #region Survival
                    #region Bloodshed Tier - 1
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 2
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 3
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 4
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 5
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Bloodshed Tier - 6
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    #endregion
                    #endregion
                    #region Skill Tree Name Randomizer
                    string[] SkillTreeBranchNames = { "Snider", "class", "mods", "redux", "dandy", "even.", ".", "Dexiduous", "Vorac", "A", "Skill Tree Name", "shake", "Milkshake", "Monty", "Python", "Atlantic", "Slot", "Machine", "BBC", "Bloodshed", "Pie", "good", "comedy", "British", "Larry", "Cable", "the", "sellout", "money", "stupid", "REKT", "beatle", "member", "withdrew", "film", "life", "of", "average", "former", "Tier", "6", "Skill", "paid", "back", "then", "residuals", "perpetuity", "who", "bark", "ruff", "ban", "shell", "vision" };
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Hellborn BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Bloodlust BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Lilac_SkillsBase.SkillTree.Branch_Mania BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    #endregion
                    MessageBox.Show("Skill Tree Randomized!");
                }
            }
        }
        public void GaigeRandom()
        {
            #region Setup
            DialogSaver.RestoreDirectory = true;
            DialogSaver.DefaultExt = "hotfix";
            DialogSaver.Filter = "Hotfix files (*.hotfix)|*.hotfix";
            DialogSaver.Title = "Save Randomized Skill Tree";
            DialogSaver.CheckFileExists = false;
            DialogSaver.CheckPathExists = true;
            #endregion
            if (DialogSaver.ShowDialog() == DialogResult.OK)
            {
                string[] SkillList = { "GD_Tulip_Mechromancer_Skills.BestFriendsForever.SharingIsCaring", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.20PercentCooler", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.ExplosiveClap", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.MadeOfSternerStuff", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.PotentAsAPony", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.UpshotRobot", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.UnstoppableForce", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.FancyMathematics", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.BuckUp", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.TheBetterHalf", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.CloseEnough", "GD_Tulip_Mechromancer_Skills.BestFriendsForever.CookingUpTrouble", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.MakeItSparkle", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.InterspersedOutburst", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.OneTwoBoom", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.WiresDontTalk", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.ElectricalBurn", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.ShockAndAAAGGGHHH", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.EvilEnchantress", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.ShockStorm", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.TheStare", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.StrengthOfFiveGorillas", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.MorePep", "GD_Tulip_Mechromancer_Skills.LittleBigTrouble.Myelin", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.WithClaws", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.TheNthDegree", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.RationalAnarchist", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.DeathFromAbove", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.AnnoyedAndroid", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.Discord", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.TypecastIconoclast", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.PreshrunkCyberpunk", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.RobotRampage", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.BloodSoakedShields", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.SmallerLighterFaster", "GD_Tulip_Mechromancer_Skills.EmbraceChaos.Anarchy"};
                using (var sw = new StreamWriter(DialogSaver.FileName))
                {
                    sw.WriteLine("start OnDemand GD_Tulip_Mechro_Streaming");
                    string SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("## Ordered Chaos ##" + Environment.NewLine);
                    #region Sniping
                    #region Sniping Tier - 1
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 2
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[1].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 3
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 4
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 5
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Sniping Tier - 6
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Little Big Trouble ##" + Environment.NewLine);
                    #region Cunning
                    #region Cunning Tier - 1
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 2
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[1].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 3
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 4
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Cunning Tier - 5
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Cunning Tier - 6
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #endregion
                    sw.WriteLine("## Best Friends Forever ##" + Environment.NewLine);
                    #region Bloodshed
                    #region Bloodshed Tier - 1
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[0].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[0].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 2
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[1].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[1].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[1].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 3
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[2].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[2].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[2].Skills[2] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 4
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[3].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[3].Skills[1] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region Bloodshed Tier - 5
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[4].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    SkillList = SkillList.Where(s => s != SkillRandom).ToArray();
                    SkillRandom = SkillList[r.Next(0, SkillList.Length)];
                    #endregion
                    #region  Bloodshed Tier - 6
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever Tiers[5].Skills[0] SkillDefinition'" + SkillRandom + "'" + Environment.NewLine);
                    #endregion
                    #endregion
                    #region Skill Tree Name Randomizer
                    string[] SkillTreeBranchNames = { "Snider", "class", "mods", "redux", "dandy", "even.", ".", "Dexiduous", "Vorac", "A", "Skill Tree Name", "shake", "Milkshake", "Monty", "Python", "Atlantic", "Slot", "Machine", "BBC", "Bloodshed", "Pie", "good", "comedy", "British", "Larry", "Cable", "the", "sellout", "money", "stupid", "REKT", "beatle", "member", "withdrew", "film", "life", "of", "average", "former", "Tier", "6", "Skill", "paid", "back", "then", "residuals", "perpetuity", "who", "bark", "ruff", "ban", "shell", "vision" };
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_BestFriendsForever BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_EmbracingChaos BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Tulip_Mechromancer_Skills.SkillTrees.Branch_LittleBigTrouble BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    #endregion
                    MessageBox.Show("Skill Tree Randomized!");
                }
            }
        }
    }
}
