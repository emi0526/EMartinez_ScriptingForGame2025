using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public Transform cannonBallSpawn;
    public float forcePower = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (forcePower > 500f)
        {
            forcePower -= Time.deltaTime * 150;
        }
       // if (Input.GetKey(KeyCode.Space))
        //{
           // FireCannon();
        //}
    }
    public void FireCannon()
    {
        
        GameObject go = Instantiate(cannonBallPrefab, cannonBallSpawn.position, cannonBallSpawn.rotation);
        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * forcePower);
        forcePower = Random.Range(500,6500);
    }
}
