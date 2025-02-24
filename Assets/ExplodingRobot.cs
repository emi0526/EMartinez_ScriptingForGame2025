using UnityEngine;

public class ExplodingRobot : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        new Vector3 moveDirection = 
        this.transform.position += moveDirection * speed * Time.deltaTime;
    }
}
