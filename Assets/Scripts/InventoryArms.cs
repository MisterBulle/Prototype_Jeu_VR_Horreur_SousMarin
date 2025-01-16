using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryArms : MonoBehaviour
{
    //ON MET LA V2
    public GameObject LAMP_Stuck_to_Arms;
    public GameObject LAMP_Delete;

    //Si notre objet est en collision avec notre inventaire
    private bool IsObjectTrigger = false;

    private bool IsHandInBlock = false;

    private Vector3 storedPosition;

    void Start()
    {
        //Quand on lance le jeu la lampe bloqué dans le bras est désactivé
        LAMP_Stuck_to_Arms.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Si notre main entre dans la collision �a va causer des probl�mes
        //NONNNNNNNNNNN
        //Pourquoi on met les deux, pour �viter que quand la lampe seule est dans l'inventaire de trigger le if
        //if (other.CompareTag("object") && other.CompareTag("hand")) 
        if (other.CompareTag("object"))
        {
            //Quand on entre dans l'inventaire avec l'objet la lampe
            LAMP_Stuck_to_Arms.SetActive(true);
            //Ducoup la lampe dans la scène n'existe plus (c normal)
            LAMP_Delete.SetActive(false);
            IsObjectTrigger = true;
        }
    }

    void OnTriggerStay(Collider stay)
    {
        if (stay.CompareTag("hand"))
        {
            Debug.Log("Contact main -> Bloc Inventaire");
            IsHandInBlock = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("hand"))
        {
            IsHandInBlock = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Si on un objet dans notre inventaire et qu'on a un contact avec la main
        if (IsObjectTrigger == true && IsHandInBlock == true)
        {
            //Je désactive la main 
            LAMP_Stuck_to_Arms.SetActive(false);
            storedPosition = LAMP_Stuck_to_Arms.transform.position;
            storedPosition.z += 0.5f;

            LAMP_Delete.transform.position = storedPosition;
            LAMP_Delete.transform.rotation = Quaternion.Euler(-90, 0, 0);
            LAMP_Delete.SetActive(true);

            IsObjectTrigger = false;
        }
    }

}
