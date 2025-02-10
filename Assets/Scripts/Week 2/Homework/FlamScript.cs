using UnityEngine;
using UnityEngine.UI;


public class FlamScript : MonoBehaviour
{
    public float intnsity;
    public Toggle tog;
    public NumberInputer num;
    public ParticleSystem flam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (intnsity < num.powerLevel)
        {
            intnsity += Time.deltaTime * 2;
        }
        if (intnsity > num.powerLevel)
        {
            intnsity -= Time.deltaTime / 3;
        }

        flam.startSpeed = intnsity * 10;

        if (tog.isOn == true)
        {
            flam.emissionRate = 30;
            
        }
        if (tog.isOn == false)
        {
            flam.emissionRate = 0;
            intnsity = 0;
        }
    }
   
}
