using UnityEngine;

public class WadeBrain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject WADE;
    public GearTurner gear;
    public float PAIN;
    public float rotateamount;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PAIN < 15)
        {
            PAIN += gear.rotateamount * Time.deltaTime * 5;
        }
        
        if (PAIN > 0)
        {
            PAIN -= Time.deltaTime;
            rotateamount += (Random.Range(-PAIN, PAIN)) * Time.deltaTime;
        }
        else if (rotateamount >0)
        {
            rotateamount -= Time.deltaTime;
        }
        else if (rotateamount < 0)
        {
            rotateamount += Time.deltaTime;
        }




        WADE.transform.Rotate(new Vector3(0f, 0f, rotateamount * 3));
    }
}
