using UnityEngine;
using UnityEngine.UI;

public class BulbScript : MonoBehaviour
{
    public Scrollbar scroll;
    public float val;
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
    public void LightCheck()
    {
        if (scroll.value >= val)
        {
            anim.clip = on;
            anim.Play();
            sound.Play();
        }
        if (scroll.value < val)
        {
            anim.clip = off;
            anim.Play();
        }
    }
   
}
