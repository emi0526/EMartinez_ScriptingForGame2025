using UnityEngine;

public class NumberInputer : MonoBehaviour
{
    public int powerLevel;
    public BulbScript bulb1;
    public BulbScript bulb2;
    public BulbScript bulb3;
    public BulbScript bulb4;
    public BulbScript bulb5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            powerLevel = 0;
            bulb1.LightOff();
            bulb2.LightOff();
            bulb3.LightOff();
            bulb4.LightOff();
            bulb5.LightOff();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            powerLevel = 1;
            bulb1.LightOn();
            bulb2.LightOff();
            bulb3.LightOff();
            bulb4.LightOff();
            bulb5.LightOff();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            powerLevel = 2;
            bulb1.LightOn();
            bulb2.LightOn();
            bulb3.LightOff();
            bulb4.LightOff();
            bulb5.LightOff();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            powerLevel = 3;
            bulb1.LightOn();
            bulb2.LightOn();
            bulb3.LightOn();
            bulb4.LightOff();
            bulb5.LightOff();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            powerLevel = 4;
            bulb1.LightOn();
            bulb2.LightOn();
            bulb3.LightOn();
            bulb4.LightOn();
            bulb5.LightOff();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            powerLevel = 5;
            bulb1.LightOn();
            bulb2.LightOn();
            bulb3.LightOn();
            bulb4.LightOn();
            bulb5.LightOn();
        }
    }
}
