using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorte : MonoBehaviour
{
  

    private bool PlayerInZone;                  //check if the player is in trigger        
    public GameObject Pivot, porte;
    private int check=0;

    private void Start()
    {
        PlayerInZone = false;                   //player not in zone      
    }

    private void Update()
    {

        if (check==0 && PlayerInZone && Input.GetKeyDown(KeyCode.T))           //if in zone and press T key
        {
            porte.transform.RotateAround(Pivot.transform.position, -Vector3.up, 90);
            check=1;
        }

        if (check==1 && PlayerInZone && Input.GetKeyDown(KeyCode.Y))           //close
        {
            porte.transform.RotateAround(Pivot.transform.position, Vector3.up, 90);
            check=0;
        }

    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")     //if player in zone
        {
            PlayerInZone = true;
        }
     }

    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
        }
    }
}
