using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPicker : MonoBehaviour
{
    public GameObject flashlight;
    public GameObject lighter;
    public GameObject glowstick;

    public float flashlightAmount = 100f;
    public float lighterAmount = 100f;
    public int glowstickAmount = 3;
    
    // Update is called once per frame
    void Update()
    {
        // Enable glowstick
       if( Input.GetKeyDown(KeyCode.Alpha1)){
           glowstick.SetActive(true);
           lighter.SetActive(false);
           flashlight.SetActive(false);
       }

        // Enable lighter
       if( Input.GetKeyDown(KeyCode.Alpha2)){
            glowstick.SetActive(false);
            lighter.SetActive(true);
            flashlight.SetActive(false);
       } 

        // Enable flashlight
       if( Input.GetKeyDown(KeyCode.Alpha3)){
            glowstick.SetActive(false);
           lighter.SetActive(false);
           flashlight.SetActive(true);
       }
    }
}
