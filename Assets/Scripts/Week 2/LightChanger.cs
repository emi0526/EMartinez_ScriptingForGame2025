using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light lightWeWantToChange;

    public Vector3 lightMoveDirection;
    public bool isItorIsntIt = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.cyan);
        this.gameObject.SetActive(isItorIsntIt);
        lightWeWantToChange.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
       // AdjustLight();
        Debug.Log("lightadjusted");
        if(Input.GetKeyDown(KeyCode.G))
        {
            ChangeLightColor(Color.cyan);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeLightColor(Color.red);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lightWeWantToChange.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            lightWeWantToChange.gameObject.SetActive(true);
        }
    }
    private void AdjustLight()
    {
        lightWeWantToChange.transform.position += lightMoveDirection * Time.deltaTime;
        lightWeWantToChange.intensity += 40f * Time.deltaTime;
        lightWeWantToChange.spotAngle += 10f * Time.deltaTime;
    }
    public void ChangeLightColor(Color santa)
    {
        lightWeWantToChange.color = santa;

        if(lightWeWantToChange.color == Color.green)
        {
            lightWeWantToChange.intensity = 100f;
        }
        else if (lightWeWantToChange.color == Color.red)
        {
            lightWeWantToChange.transform.position += Vector3.right * 3;
        }
        else if (lightWeWantToChange.color == Color.blue)
        {
            lightWeWantToChange.gameObject.SetActive(false);
        }
        else
        {
            lightWeWantToChange.transform.position = Vector3.zero; 
        }

        if(lightWeWantToChange.color == Color.green || lightWeWantToChange.color == Color.red)
        {

        }
        if(lightWeWantToChange.color == Color.blue && lightWeWantToChange.intensity >50f)
        {

        }
    }    
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }
    private void Awake()
    {
        
    }
    private void OnDestroy()
    {
        
    }
}
