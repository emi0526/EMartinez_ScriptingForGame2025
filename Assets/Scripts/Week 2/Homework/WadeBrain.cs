using UnityEngine;

public class WadeBrain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject WADE;
    public GearTurner gear;
    public float PAIN;
    public float temp;
    public float rotateamount;
    public FlamScript flams;
    public Animator anim;
    
    void Start()
    {
        temp = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Blend", temp/5);
        if (flams.tog.isOn == true)
        {
            temp += flams.intnsity * Time.deltaTime/10;
        }
        temp -= gear.rotateamount / 2 * Time.deltaTime/10;
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
