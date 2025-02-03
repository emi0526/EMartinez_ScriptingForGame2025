using UnityEngine;

public class TransformScript : MonoBehaviour
{
    Vector3 startpos;
    Vector3 movpos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = startpos;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += movpos * Time.deltaTime;
    }
}
