using UnityEngine;

public class FloatScript : MonoBehaviour
{
    public float v1;
    public float v2;
    public float v3;
    public float total;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = v3 * v1 + v2;
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
