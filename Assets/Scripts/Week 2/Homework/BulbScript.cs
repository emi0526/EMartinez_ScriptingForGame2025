using UnityEngine;
using UnityEngine.UI;

public class BulbScript : MonoBehaviour
{
   
    
    public Animation anim;
    public AnimationClip on;
    public AnimationClip off;
    public AudioSource sound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LightOn()
    {
        anim.clip = on;
        anim.Play();
        sound.Play();
    }
    public void LightOff()
    {
        anim.clip = off;
        anim.Play();
    }

}
