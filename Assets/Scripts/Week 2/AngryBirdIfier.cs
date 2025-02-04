using UnityEngine;

public class AngryBirdIfier : MonoBehaviour
{
    public GameObject angryBird;
    public float scaleIncrease = 0.1f;
    public Transform tppos;
    public float rotateamount;
    public float rotate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(scaleIncrease > 0)
        {
            scaleIncrease -= Time.deltaTime / 5;
        }
      
        if (rotateamount > 0f)
        {
            rotateamount -= Time.deltaTime;
        }
        angryBird.transform.Rotate(new Vector3(0f, 0f, rotateamount));
        angryBird.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;
    }
    public void ResetAngryBird()
    {
        angryBird.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
        
       
    }
    public void RotateAngryBird()
    {
        rotateamount += 1;
    }
    public void TeleportAngryBird()
    {
        angryBird.transform.position = tppos.position;
    }
}
