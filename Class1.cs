using Harmony;
using MelonLoader;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using UnityEngine;
using VRCSDK2;
using System.Net.Http;
using VRC;
using VRTK.Controllables.ArtificialBased;
using Transmtn.DTO;
using UnityEngine.UI;
using VRC.Core;
using VRC.UI;
using VRC.Udon;
using ThirdParty.iOS4Unity;
using BestHTTP;
using Il2CppSystem.Threading.Tasks;
using Transmtn;
using System.Threading.Tasks;
using Il2CppSystem.Threading;
using UnityEngine.Networking;
using Newtonsoft.Json;
using Il2CppMono.Security;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using UnityEngine.SceneManagement;
using DiskWars;
using UnhollowerRuntimeLib;
using UnityEngine.Events;
using VRC.SDKBase;
using VRCSDK2.Validation.Performance.Scanners;
using Steamworks;
using WebSocketSharp;
using Transmtn.DTO.Notifications;
using Il2CppSystem.Security.Cryptography;
using UnhollowerBaseLib;
using VRC.UserCamera;
using Harmony.ILCopying;
using static VRC.SDKBase.VRC_EventHandler;
using ExitGames.Client.Photon;
using RootMotion.Dynamics;
using VRC.Animation;

namespace ForceClone
{
    public static class BuildInfo
    {
        public const string Name = "ForceClone"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "KITTY#0666"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.o"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "discord.gg/PQjc7FT"; // Download Link for the Mod.  (Set as null if none)
    }

    public class Class1 : MelonMod
    {public bool dun=false;
        public override void OnApplicationStart()
        {
        }
		public override void OnLevelWasLoaded(int level)
		{
            if(!dun){
                    var g=GameObject.Find("UserInterface/QuickMenu/UserInteractMenu/CloneAvatarButton").transform;
                    var x=GameObject.Instantiate(QuickMenu.prop_QuickMenu_0.transform.Find("CameraMenu/BackButton").gameObject,g.parent);
                    x.transform.position=g.position;
                    x.GetComponentInChildren<Text>().text = "Force Clone";
                    x.GetComponentInChildren<UiTooltip>().text = "Steal That Avatar";
                    x.GetComponentInChildren<Text>().color = new Color(1,.8f,1);
                    x.GetComponentInChildren<Image>().color = new Color(1,.8f,1);
                    x.GetComponent<Button>().onClick=new Button.ButtonClickedEvent();
                    x.GetComponent<Button>().onClick.AddListener(new Action(()=>{var a=PlayerManager.Method_Public_Static_Player_String_0(QuickMenu.prop_QuickMenu_0.prop_APIUser_0.id).field_Internal_VRCPlayer_0.prop_ApiAvatar_0;
                        Console.WriteLine("Force Cloning: "+a.id);
                        new PageAvatar(){avatar=new SimpleAvatarPedestal(){field_Internal_ApiAvatar_0=new ApiAvatar(){id=a.id}}}.ChangeToSelectedAvatar();
                    }));
                    g.position+=new Vector3(69,69,69);
            dun=true;}
		}
        public override void OnLevelWasInitialized(int level)
		{
		}
        public override void OnUpdate()
      {
      }
    }
}
