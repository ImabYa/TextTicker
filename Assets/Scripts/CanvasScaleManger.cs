using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScaleManger : MonoBehaviour
{
    private CanvasScaler cs;
    // Start is called before the first frame update
    void Awake()
    {
        cs = GetComponent<CanvasScaler>();
        cs.referenceResolution = new Vector2(Screen.width, Screen.height);
    }
}
