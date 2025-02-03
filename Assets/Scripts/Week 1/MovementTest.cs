using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 moveDirection;
    public Vector3 moveDirection2;
    public float speed;
    public float speed2;
    public float timer;
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
        speed += Time.deltaTime*15;
        
        if (timer <= 0)
        {
            speed = Random.Range(-8f, 15);
            speed2 = Random.Range(-5f, 5);
            timer = Random.Range(1, 4)/4;
        }
        else
        {
            timer -= Time.deltaTime;
        }
        this.transform.position += moveDirection * speed * Time.deltaTime;
        this.transform.position += moveDirection2 * speed2 * Time.deltaTime;
        // this.transform.Translate(moveDirection * speed * Time.deltaTime);
        // multiplying by Time.deltatime makes it per second instead of per frame!
    }
}
