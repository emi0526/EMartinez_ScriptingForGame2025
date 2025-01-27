using UnityEngine;

public class DatatypePractice : MonoBehaviour
{


    //class notes --
    //A datatype is a type of information
    // like whole numbers, words, letters, decimal numbers, etc...
    // aka      [int]egers, [strings], [char]acters, [floats]
    // variable allows a datatype to be represented in code
    // structure of a variable in scripts:
    // AccessabilityLevel - Datatype - VariableName
    // you can even name it santaclaus
    // we can manipulate santaclaus even further
    // accessability level is public, private
    // Deltatime is the time between Frames
    
    


    int santaClaus;
    public float yoshi = 4.8f;
    public float mario = 4f;
    char bee = 'B';
    string intro = "hey vro ";
    string outro = "bye vro";
    float total;
    string sentence;

    void Start()
    {
        santaClaus = 56;
        santaClaus = (santaClaus + 5) * 25 / (54-7);
        Debug.Log(santaClaus);
        Debug.Log(yoshi);
        yoshi = yoshi - 2;
        Debug.Log(yoshi);
        Debug.Log("yoshi's value is" + yoshi);
        Debug.Log(bee);
        Debug.Log(bee + intro);
        total = mario + yoshi;
        sentence = intro + outro;
        Debug.Log(total);
        Debug.Log(sentence);
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1, 6) == 1)
        {
            Debug.Log(">:3");
        }
        else if (Random.Range(1, 5) == 1)
        {
            Debug.Log(">:D");
        }
        else if (Random.Range(1, 4) == 1)
        {
            Debug.Log(">:O");
        }
        else if (Random.Range(1, 3) == 1)
        {
            Debug.Log(">:)");
        }
        else
        {
            Debug.Log(">:P");
        }
    }
}
