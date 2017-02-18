using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Tycoon
{
    public delegate void UnityEvent(object arg);
    public sealed class Communications
    {
        public static void SetCubeMaterialColor(byte r, byte g, byte b, string unityObjectName)
        {
            UnityEngine.GameObject go = UnityEngine.GameObject.Find(unityObjectName);
            UnityEngine.Material mat = go.GetComponent<XamlConnection>().material;
            mat.color = new UnityEngine.Color32(r, g, b, 255);
        }
        public static void SetEvent(UnityEvent e, string unityObjectName)
        {
            UnityEngine.GameObject go = UnityEngine.GameObject.Find(unityObjectName);
            if (go != null)
            {
                go.GetComponent<XamlConnection>().onEvent = new XamlConnection.OnEvent(e);
            }
            else
            {
                throw new Exception("Player not found, have exported the correct scene?");
            }
        }
    }

}
