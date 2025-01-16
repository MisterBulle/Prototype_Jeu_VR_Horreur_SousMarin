using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VerticalRotationTest : MonoBehaviour
{
	public InputActionProperty rotateValue;
	public Camera cam;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector2 rotateX = rotateValue.action.ReadValue<Vector2>();
		
		if (rotateX.x >= 0f)
		{
		cam.transform.rotation = Quaternion.Euler(new Vector3(0,45,0));
		}
		
    }
}
