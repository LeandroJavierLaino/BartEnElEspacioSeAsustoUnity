using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody rigidbodyPlayer;
    public float speed = 5f;
    public float jumpForce = 32f;

    // Update is called once per frame
    void FixedUpdate() {
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");

        rigidbodyPlayer.velocity = move * speed  ;  
        rigidbodyPlayer.AddForce(new Vector3(0f,Input.GetKeyDown(KeyCode.Space) && rigidbodyPlayer.velocity.y >= 0 ? jumpForce : 0f,0f),ForceMode.Impulse);     
    }
}
