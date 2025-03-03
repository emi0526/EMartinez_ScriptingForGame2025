using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
   
    public bool hasKeyRed = false;
    public bool hasKeyBlue = false;
    public bool hasKeyYellow = false;
    public GameObject PlayerCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //are we looking at the door
            RaycastHit hitobject;
           if(Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hitobject, 10f))
            {
                if (hitobject.collider.gameObject.tag == "Door")
                {
                    Door LookedAtDoor = hitobject.collider.gameObject.GetComponent<Door>();
                    if(LookedAtDoor.DoorColor == KeyColor.Red && hasKeyRed == true)
                    {
                        LookedAtDoor.OpenDoor();
                    }
                    else if (LookedAtDoor.DoorColor == KeyColor.Blue && hasKeyBlue == true)
                    {
                        LookedAtDoor.OpenDoor();
                    }
                    else if (LookedAtDoor.DoorColor == KeyColor.Yellow && hasKeyYellow == true)
                    {
                        LookedAtDoor.OpenDoor();
                    }
                    
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;
            if (pickedUpKeyColor == KeyColor.Red)
            {
                hasKeyRed = true;
            }
            else if (pickedUpKeyColor == KeyColor.Blue)
            {
                hasKeyBlue = true;
            }
            else if (pickedUpKeyColor == KeyColor.Yellow)
            {
                hasKeyYellow = true;
            }

            Destroy(other.gameObject);
        }
    }
}
