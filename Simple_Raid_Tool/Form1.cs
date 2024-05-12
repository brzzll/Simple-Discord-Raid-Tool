//bro por qué miras esto? ...
using DiscordRPC;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
//puto el que lo lea xdxdxdxdadadxd
namespace Simple_Raid_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RPC.rpctimestamp = Timestamps.Now;
            //ssex
            RPC.InitializeRPC();
            //.zx XD
            if (!File.Exists("by-ZenX-gg-kEB3PCPkzc.zx")){this.Close();};
            //bro no elimines ese archivo
            Process[] processes = Process.GetProcessesByName("node");
            if (processes.Length > 0){foreach (Process process in processes){process.Kill();}}
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e){if (guna2ToggleSwitch1.Checked == false){buttonAdminAll.Text = "Dar admin a todos";buttonBanAll.Text = "Banear a todos";buttonCreateChannels.Text = "Crear canales";buttonCreateEmojis.Text = "Crear emojis";buttonCreateMessages.Text = "Crear mensajes";buttonCreateRoles.Text = "Crear roles";buttonCreateWebhooks.Text = "Crear webhooks";buttonGetWebhooks.Text = "Obtener webhooks";buttonKickAll.Text = "Kickear a todos";buttonLeaveAllServers.Text = "Abandonar servidores";buttonMuteAll.Text = "Silenciar a todos";buttonRaidBrzzl.Text = "Raid Brzzl";buttonRaidNormal.Text = "Raid normal";buttonRemoveAll.Text = "Eliminar todo";buttonRemoveBans.Text = "Eliminar baneos";buttonRemoveChannels.Text = "Eliminar canales";buttonRemoveEmojis.Text = "Eliminar emojis";buttonRemoveInvites.Text = "Eliminar invitaciones";buttonRemoveMessages.Text = "Eliminar mensajes";buttonRemoveRoles.Text = "Eliminar roles";buttonRemoveStickers.Text = "Eliminar stickers";buttonRemoveWebhooks.Text = "Eliminar webhooks";buttonRenameAll.Text = "Renombrar a todos";buttonSpamMD.Text = "Enviar MD";buttonSpamWebhooks.Text = "Spamear webhooks";buttonZenXDiscord.Text = "Servidor de Discord";} else{buttonAdminAll.Text = "AdminAll";buttonBanAll.Text = "BanAll";buttonCreateChannels.Text = "MassChannels";buttonCreateEmojis.Text = "MassEmojis";buttonCreateMessages.Text = "MassMessages";buttonCreateRoles.Text = "MassRoles";buttonCreateWebhooks.Text = "MassWebhooks";buttonKickAll.Text = "KickAll";buttonLeaveAllServers.Text = "Leave all servers";buttonMuteAll.Text = "MuteAll";buttonRaidBrzzl.Text = "Raid Brzzl";buttonRaidNormal.Text = "Raid classic";buttonRemoveAll.Text = "RemoveAll";buttonRemoveBans.Text = "RemoveBans";buttonRemoveChannels.Text = "RemoveChannels";buttonRemoveEmojis.Text = "RemoveEmojis";buttonRemoveInvites.Text = "RemoveInvites";buttonRemoveMessages.Text = "RemoveMessages";buttonRemoveRoles.Text = "RemoveRoles";buttonRemoveStickers.Text = "RemoveStickers";buttonRemoveWebhooks.Text = "RemoveWebhooks";buttonRenameAll.Text = "RenameAll";buttonSpamMD.Text = "SpamDM";buttonSpamWebhooks.Text = "SpamWebhooks";buttonZenXDiscord.Text = "$ ZenX Discord";}}
        public int xClick = 0, yClick = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e){if (e.Button != MouseButtons.Left){ xClick = e.X; yClick = e.Y; }else{ this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }}
        //muev meuve meuvem uvem uv - sexxx
        private void buttonRaidNormal_Click(object sender, EventArgs e){procesoxd("raidnormal");}

        private void buttonRaidBrzzl_Click(object sender, EventArgs e){procesoxd("raidbrzzl");}

        private void buttonCreateChannels_Click(object sender, EventArgs e){procesoxd("createchannels");}
        //lmao
        private void buttonCreateRoles_Click(object sender, EventArgs e){procesoxd("createroles");}

        private void buttonCreateEmojis_Click(object sender, EventArgs e){procesoxd("createemojis");}

        private void buttonCreateMessages_Click(object sender, EventArgs e){procesoxd("createmessages");}
        private void buttonRemoveAll_Click(object sender, EventArgs e){procesoxd("removeall");}

        private void buttonRemoveChannels_Click(object sender, EventArgs e){procesoxd("removechannels");}

        private void buttonRemoveRoles_Click(object sender, EventArgs e){procesoxd("removeroles");}

        private void buttonRemoveStickers_Click(object sender, EventArgs e){procesoxd("removestickers");}

        private void buttonRemoveEmojis_Click(object sender, EventArgs e){procesoxd("removeemojis");}

        private void buttonRemoveInvites_Click(object sender, EventArgs e){procesoxd("removeinvites");}

        private void buttonRemoveMessages_Click(object sender, EventArgs e){procesoxd("removemessages");}
        //fallensexo
        private void buttonRemoveBans_Click(object sender, EventArgs e){procesoxd("removebans");}
        private void buttonMuteAll_Click(object sender, EventArgs e){procesoxd("muteall");}

        private void buttonKickAll_Click(object sender, EventArgs e){procesoxd("kickall");}

        private void buttonBanAll_Click(object sender, EventArgs e){procesoxd("banall");}

        private void buttonAdminAll_Click(object sender, EventArgs e){procesoxd("adminall");}

        private void buttonRenameAll_Click(object sender, EventArgs e){procesoxd("renameall");}

        private void buttonSpamMD_Click(object sender, EventArgs e){procesoxd("spammd");}
        //zenX-team
        private void buttonGetWebhooks_Click(object sender, EventArgs e){procesoxd("getwebhooks");}

        private void buttonCreateWebhooks_Click(object sender, EventArgs e){procesoxd("createwebhooks");}

        private void buttonSpamWebhooks_Click(object sender, EventArgs e){procesoxd("spamwebhooks");}

        private void buttonRemoveWebhooks_Click(object sender, EventArgs e){procesoxd("removewebhooks");}
        private void buttonLeaveAllServers_Click(object sender, EventArgs e){procesoxd("leaveallservers");}
        //by
        private void buttonZenXDiscord_Click(object sender, EventArgs e){Process.Start("https://discord.gg/kEB3PCPkzc");}
        //zenx
        public void procesoxd(string comando){string argumentos = $"\"{comando}\" \"{textboxToken.Text}\" \"{textboxGuildID.Text}\"";Process.Start("comandos_srt.exe", argumentos);}
    }
}
//que haces viendo esto niggerrrr