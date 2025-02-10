using UnityEngine;
using UnityEngine.UI;

public class LvaScript : MonoBehaviour
{
    public Toggle tog;
    public Animation anim;
    public AnimationClip on;
    public AnimationClip off;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LvrTry()
    {
        if (tog.isOn == true)
        {
            anim.clip = on;
            anim.Play();
        }
        if (tog.isOn == false)
        {
            anim.clip = off;
            anim.Play();
        }
        

    }

}
