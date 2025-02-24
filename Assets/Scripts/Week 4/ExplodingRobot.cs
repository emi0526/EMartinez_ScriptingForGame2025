using UnityEngine;

public class ExplodingRobot : MonoBehaviour
{
    public float XSpeed;
    public float ZSpeed;
    public float speed;
    public float freezeclock;
    public Animator anim;
    public GameObject explosionPrefab;
    public Rigidbody rbody;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(freezeclock<=0)
        {
            XSpeed = 0f;
            ZSpeed = 0f;
            freezeclock = Random.Range(1f, 5f);
        }
        else
        {
            freezeclock -= Time.deltaTime;
        }
        XSpeed += Random.Range(-4f, 4f);
        ZSpeed += Random.Range(-4f, 4f);
        rbody.AddForce(new Vector3(XSpeed, 0f, ZSpeed) * speed * Time.deltaTime);
            //new Vector3(XSpeed, 0f, ZSpeed) * speed * Time.deltaTime;
    }
    public void InitiateExplode()
    {
        anim.SetTrigger("Explode");
    }
    public void FinallyDie()
    {
        GameObject go = Instantiate(explosionPrefab, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
    }
}
