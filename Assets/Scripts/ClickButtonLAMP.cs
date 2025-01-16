using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickButtonLAMP : MonoBehaviour
{

    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public GameObject LightLamp;
    GameObject presser;
    //AudioSource sound;
    bool isPressed;
    bool IsLightOn;

    

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
        IsLightOn = false;
        LightLamp.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isPressed)
        {
            button.transform.localPosition = new Vector3(0.852f, 0.2172357f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject)
        {
            button.transform.localPosition = new Vector3(0.9473488f, 0.2172357f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void Allumer_Eteindre_la_Lampe()
    {

        if (IsLightOn) // Si la lampe est allumé et qu'on appuie sur le bouton 
        {
            LightLamp.SetActive(false);
            IsLightOn = false;
            //Debug.Log("J'éteins la lampe");
            return;
        }
        if (!IsLightOn)
        {
            LightLamp.SetActive(true);
            IsLightOn = true;
            //Debug.Log("J'allume la lampe");
            return;
        }
     
    }
    
}
