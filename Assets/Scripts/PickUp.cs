using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    public List<string> inventory = new List<string>();
     private bool canPickUpGun = false;
    public GameObject gun;
    public GameObject gun1;
    public Transform gunspawnpoint;
   
   
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P) && canPickUpGun)
            {
                inventory.Add("Gun");
                GameObject.DestroyImmediate(gun);

               
                GameObject newGun = Instantiate(gun1, gunspawnpoint.transform.position, gunspawnpoint.rotation);

                
                newGun.transform.SetParent(transform); 

                newGun.transform.localPosition = new Vector3(-0.294f, 0.05f, 0); 
                newGun.transform.localRotation = Quaternion.identity; 

                Debug.Log("Gun picked up and added to inventory and attached to player.");
            }
        }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gun")) 
        {
            canPickUpGun = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Gun"))
        {
            canPickUpGun = false;
        }
    }
}


