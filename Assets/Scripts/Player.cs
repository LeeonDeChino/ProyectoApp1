using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Player : MonoBehaviour
{
    public float speed = 2f;

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            PlayerMove();
        }
    }

    private void PlayerMove()
    {
        transform.Translate(Vector3.right * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime);
        transform.Translate(Vector3.up * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime);
    }
}
