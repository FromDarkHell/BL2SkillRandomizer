using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BL2SkillRandomizer
{
    public partial class Randomizer : Form
    {
        Random.Org.Random r = new Random.Org.Random();
        public Randomizer()
        {
            InitializeComponent();
            r.UseLocalMode = true;
        }
        private void button1_Click(object sender, EventArgs e)
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
                    #region Skill Tree Name Randomizer
                    string[] SkillTreeBranchNames = {"Snider","class", "mods", "redux", "dandy", "even.", ".", "Dexiduous", "Vorac", "A", "Skill Tree Name", "shake", "Milkshake", "Monty", "Python", "Atlantic", "Slot", "Machine", "BBC", "Bloodshed", "Pie", "good", "comedy", "British", "Larry", "Cable", "the", "sellout", "money", "stupid", "REKT", "beatle", "member", "withdrew", "film", "life", "of", "average", "former", "Tier", "6", "Skill", "paid", "back", "then", "residuals", "perpetuity", "who", "bark", "ruff", "ban", "shell","vision" };
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Sniping BranchName " + SkillTreeBranchNames[r.Next(0,SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Cunning BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    sw.WriteLine("set GD_Assassin_Skills.SkillTree.Branch_Bloodshed BranchName " + SkillTreeBranchNames[r.Next(0, SkillTreeBranchNames.Length)]);
                    #endregion
                    #endregion
                }
                MessageBox.Show("Zer0's Skill Tree Randomized!");
            }
        }
        private void Loader_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
        private void KriegButton_Click(object sender, EventArgs e)
        {
            this.Krieg.Start();
        }
        private void Krieg_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(1);
        }
        private void Randomizer_Load(object sender, EventArgs e)
        {
        }
    }
}
