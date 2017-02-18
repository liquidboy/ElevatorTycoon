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


    //insert in "OnInitialize" of component
    //UnityPlayer.AppCallbacks.Instance.Initialized += OnInitialized;

    //private long eventWasReceivedCount;
    //private void OnInitialized()
    //{
    //    AppCallbacks.Instance.InvokeOnAppThread(() =>
    //    {
    //        Communications.SetEvent(UnityToXAML);
    //    }, false);
    //}
    //public void UnityToXAML(object arg)
    //{
    //    UnityPlayer.AppCallbacks.Instance.InvokeOnUIThread(new UnityPlayer.AppCallbackItem(() =>
    //    {
    //        eventWasReceivedCount++;
    //        var v3 = (UnityEngine.Vector3)arg;
    //        tbMain.Text = $"x:{ v3.x } y: { v3.y} z: { v3.z}";
    //    }
    //    ), false);


    //}
}
