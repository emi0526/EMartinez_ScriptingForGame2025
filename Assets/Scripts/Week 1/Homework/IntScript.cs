using UnityEngine;

public class IntScript : MonoBehaviour
{
    int v1 = 15;
    int v2 = 29;
    int v3 = 405;
    int total;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = (v3 / v1) * v2;
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
