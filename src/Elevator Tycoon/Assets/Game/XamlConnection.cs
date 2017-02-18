using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XamlConnection : MonoBehaviour {

    public delegate void OnEvent(object arg);

    public OnEvent onEvent = null;
    
}
