using UnityEngine;
using UnityEngine.UI;
public class GearTurner : MonoBehaviour
{
    public GameObject Gear1;
    public GameObject Gear2;
    public GameObject Gear3;
    public float rotateamount;
    public Scrollbar scroll;
    public AudioSource sound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateamount < scroll.value)
        {
            rotateamount += Time.deltaTime*2;
        }
        if (rotateamount > scroll.value)
        {
            rotateamount -= Time.deltaTime/3;
        }
        sound.volume = rotateamount;
        sound.pitch = rotateamount+0.5f;
        Gear1.transform.Rotate(new Vector3(0f, 0f, rotateamount*3));
        Gear2.transform.Rotate(new Vector3(0f, 0f, -rotateamount * 3));
        Gear3.transform.Rotate(new Vector3(0f, 0f, rotateamount * 2));
    }
}
