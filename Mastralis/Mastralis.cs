using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;
using Memory;


namespace Mastralis
{
    //Please see Github for Fixes / To do / Or Done.
    public partial class Mastralis : MetroFramework.Forms.MetroForm
    {
        public Mem MemLib = new Mem();

        public Mastralis()
        {
            InitializeComponent();
        }



        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        #region All Buttons
        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MemLib.OpenProcess("TheChase-Win64-Shipping");
                if (IsAdministrator())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Attached to the game! - Have fun @123lkj12lk312kjl3 | @Sehyn", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    materialFlatButton1.Enabled = false;
                    float atk_speed = MemLib.readFloat("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17D0");
                    label1.Text = atk_speed.ToString();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please run the hack with administrator privileges", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Couldn't attach to game" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            AtkH.Start();
        }

        private void MaterialFlatButton3_Click(object sender, EventArgs e)
        {
            CastH.Start();


        }

        private void MaterialFlatButton4_Click(object sender, EventArgs e)
        {
            MovH.Start();

        }

        private void MaterialFlatButton6_Click_1(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "This hack/cheat/trainer has been made possible by @Sehyn @123lkj12lk312kjl3 @darkrole @UC Community\r\nIf you paid for this you got scammed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GithubBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Sehyn");
        }
        #endregion
        #region All CheckBoxes
        private void Infinite_HP_CheckedChanged(object sender, EventArgs e)
        {
            if (Infinite_HP.Checked)
            {
                INF_HP.Start();
            }
            else
            {
                INF_HP.Stop();
            }
        }

        private void Infinite_MANA_CheckedChanged(object sender, EventArgs e)
        {
            if (Infinite_MANA.Checked)
            {
                INF_MANA.Start();
            }
            else
            {
                INF_MANA.Stop();
            }
        }

        private void INFINITE_STAMINA_CheckedChanged(object sender, EventArgs e)
        {
            if (INFINITE_STAMINA.Checked)
            {
                INF_STAMINA.Start();
            }
            else
            {
                INF_STAMINA.Stop();
            }
        }



        private void INFINITE_KARMA_CheckedChanged(object sender, EventArgs e)
        {
            if (INFINITE_KARMA.Checked)
            {
                INF_KARMA.Start();
            }
            else
            {
                INF_KARMA.Stop();
            }
        }

        private void INFINITE_MAGIC_DEV_CheckedChanged(object sender, EventArgs e)
        {
            if (INFINITE_MAGIC_DEF.Checked)
            {
                INF_MAGIC_DEF.Start();
            }
            else
            {
                INF_MAGIC_DEF.Stop();
            }
        }

        private void INFINITE_PHY_DEF_CheckedChanged(object sender, EventArgs e)
        {
            if (INFINITE_PHY_DEF.Checked)
            {
                INF_PHY_DEF.Start();
            }
            else
            {
                INF_PHY_DEF.Stop();
            }
        }

        private void INFINITE_POSTURE_RES_CheckedChanged(object sender, EventArgs e)
        {
            if (INFINITE_POSTURE_RES.Checked)
            {
                INF_POSTURE_RES.Start();
            }
            else
            {
                INF_POSTURE_RES.Stop();
            }
        }

        private void OneHit_OneKill_CheckedChanged(object sender, EventArgs e)
        {
            if (OneHit_OneKill.Checked)
            {
                ONE_HIT_ONE_KILL.Start();
            }
            else
            {
                ONE_HIT_ONE_KILL.Stop();
            }
        }
        #endregion
        #region All Timers
        private void SpeedH_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17D0", "float", materialSingleLineTextField1.Text);
            float atk_speed = MemLib.readFloat("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17D0");
            label1.Text = atk_speed.ToString();

        }

        private void CastH_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17D4", "float", materialSingleLineTextField2.Text);
            float atk_speed = MemLib.readFloat("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17D4");
            label4.Text = atk_speed.ToString();
        }

        private void MovH_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17D8", "float", materialSingleLineTextField3.Text);
            float atk_speed = MemLib.readFloat("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17D8");
            label6.Text = atk_speed.ToString();
        }


        private void INF_HP_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x1788", "float", "999999");

        }

        private void INF_MANA_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x1798", "float", "999999");

        }

        private void INF_STAMINA_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x18F8", "float", "999999");

        }

        private void INF_KARMA_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x18FC", "float", "999999");

        }

        private void INF_MAGIC_DEF_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17C4", "float", "999999");

        }

        private void INF_PHY_DEF_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17C0", "float", "999999");

        }

        private void INF_POSTURE_RES_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17C8", "float", "999999");

        }

        private void ONE_HIT_ONE_KILL_Tick(object sender, EventArgs e)
        {
            MemLib.writeMemory("TheChase-Win64-Shipping.exe+0x0036E3AC0,0x20,0x90,0x8,0x0,0x17DC", "float", "999999");

        }
        #endregion
    }
}
