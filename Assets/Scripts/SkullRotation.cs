using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullRotation : MonoBehaviour
{
    public float rotationSpeed = 15f;
    public float updownvelocity = 3f;
    public float amplitude = 1.25f;
    public float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
        transform.Translate(Vector3.up * amplitude * Mathf.Sin(timer * updownvelocity));
    }
}
