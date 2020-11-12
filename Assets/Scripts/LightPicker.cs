using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPicker : MonoBehaviour
{
    public GameObject flashlight;
    public GameObject lighter;
    public GameObject glowstick;
    public GameObject idleLight;

    public float flashlightAmount = 100f;
    public float lighterAmount = 100f;
    public int glowstickAmount = 3;
    public float opentimer = 0f;

    // Update is called once per frame
    void Update()
    {
        // Enable glowstick
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            glowstick.SetActive(true);
            lighter.SetActive(false);
            flashlight.SetActive(false);
        }

        // Enable lighter
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            glowstick.SetActive(false);
            lighter.SetActive(true);
            flashlight.SetActive(false);
        }

        // Enable flashlight
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            glowstick.SetActive(false);
            lighter.SetActive(false);
            flashlight.SetActive(true);
        }

        if (lighter.activeSelf && lighterAmount > 0) lighterAmount -= Time.deltaTime;
        if (lighterAmount <= 0) lighter.SetActive(false);

        if (flashlight.activeSelf && flashlightAmount > 0) flashlightAmount -= Time.deltaTime / 2;
        if (flashlightAmount <= 0)
        {
            flashlight.SetActive(false);
            flashlightAmount += Time.deltaTime;
        }

        if (glowstick.activeSelf && glowstickAmount > 0)
        {
            opentimer += Time.deltaTime;
            if (Mathf.Ceil(opentimer) % 60 == 0)
            {
                opentimer = 0;
                glowstickAmount--;
            }
        }
        if (glowstickAmount <= 0) glowstick.SetActive(false);

        if ((!lighter.activeSelf && lighterAmount <= 0) || (!flashlight.activeSelf && flashlightAmount <= 0) || (!glowstick.activeSelf && glowstickAmount == 0)) idleLight.SetActive(true);
        else idleLight.SetActive(false);
    }
}
