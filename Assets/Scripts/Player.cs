using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
    		
        float horizontalSpeed = Input.GetAxisRaw("Horizontal");
        float verticalSpeed = Input.GetAxisRaw("Vertical");

        UnityEngine.Vector3 direction = new UnityEngine.Vector3(horizontalSpeed, 0f, verticalSpeed).normalized;

        if (direction.magnitude >= 0f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
