using UnityEngine;

public class BallJiggle : MonoBehaviour
{
    public Light glow;
    public Vector3 move;
    public Vector3 start;
    public float speed;
    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += (move*speed) * Time.deltaTime;
        if (timer <= 0)
        {
            this.transform.position = start;
            speed = 100;
            timer = Random.Range(3, 6);
        }
        else
        {
            timer -= Time.deltaTime*5;
        }
        speed -= Time.deltaTime*350;
        glow.intensity = speed / 8;
        
    }
}
