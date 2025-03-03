using UnityEngine;

public class Door : MonoBehaviour
{
    public KeyColor DoorColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (DoorColor == KeyColor.Red)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (DoorColor == KeyColor.Blue)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (DoorColor == KeyColor.Yellow)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenDoor()
    {
        Destroy(this.gameObject);
    }
}
