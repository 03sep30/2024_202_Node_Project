using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isMyPlayer = false;
    public float moveSpeed = 5.0f;

    public void SetAsMyPlayer()
    {
        isMyPlayer = true; 
    }


    // Update is called once per frame
    void Update()
    {
        if (isMyPlayer)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontal, 0, vertical);
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }
}
