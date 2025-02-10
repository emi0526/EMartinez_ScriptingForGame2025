using UnityEngine;
using UnityEngine.UI;
public class GearTurner : MonoBehaviour
{
    public GameObject Gear1;
    public GameObject Gear2;
    public GameObject Gear3;
    public float rotateamount;
    public NumberInputer num;
    public AudioSource sound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateamount < num.powerLevel)
        {
            rotateamount += Time.deltaTime*2;
        }
        if (rotateamount > num.powerLevel)
        {
            rotateamount -= Time.deltaTime/3;
        }
        sound.volume = rotateamount;
        sound.pitch = (rotateamount/10)+0.5f;
        Gear1.transform.Rotate(new Vector3(0f, 0f, rotateamount/2));
        Gear2.transform.Rotate(new Vector3(0f, 0f, -rotateamount / 2));
        Gear3.transform.Rotate(new Vector3(0f, 0f, rotateamount));
    }
}
