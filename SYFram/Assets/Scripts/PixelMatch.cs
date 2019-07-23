using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PixelMatch : MonoBehaviour
{

    private void Awake()
    {
        float wScale = Screen.width / 1920.0f;
        float hScale = Screen.height / 1080.0f;
        GetComponent<CanvasScaler>().scaleFactor = wScale>hScale ? wScale:hScale ;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
