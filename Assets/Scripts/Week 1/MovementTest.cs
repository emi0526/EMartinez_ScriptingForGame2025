using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 moveDirection;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = Random.Range(1, 15);
        Debug.Log("Hello World! :D");
        //this script references the transform position from its parent object and sets it to vector3.zero which means 0,0,0
        //this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveDirection * speed * Time.deltaTime;
        // this.transform.Translate(moveDirection * speed * Time.deltaTime);
        // multiplying by Time.deltatime makes it per second instead of per frame!
    }
}
