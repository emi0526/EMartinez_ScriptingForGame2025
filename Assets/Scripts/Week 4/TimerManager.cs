using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public float Timer;
    public float CountDown;
    public float FinalRobotCount;
    public float GuessCount;
    public TextMeshPro MyCountText;
    public TextMeshPro FinalCountText;
    public TextMeshPro WinText;
    public TextMeshPro TimerText;
    public RobotSpawnerScript rss;
    public Animator brain;
    public Animator cam;
    public bool active;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Timer = 30f;
        CountDown = 5f;
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        MyCountText.text = GuessCount.ToString();
        
        TimerText.text = Timer.ToString("0");
        if (CountDown <= 0)
        {
            if(Timer <= 0)
            {
                
                FinalRobotCount = rss.RobotCurrentAmount;
                FinalCountText.text = FinalRobotCount.ToString();
                if(FinalRobotCount == GuessCount)
                {
                    WinText.text = "You Win!";
                }
                else
                {
                    WinText.text = "You Lose!";
                }
                cam.SetTrigger("End");
                rss.ExplodeAll();
                Timer = 30;
                active = false;
            }
            else if (active == true)
            {
                Timer -= Time.deltaTime;
            }
        }
        else
        {
            CountDown -= Time.deltaTime;
        }
        if (active)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GuessCount += 1;
                brain.SetTrigger("Pos");
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                GuessCount -= 1;
                brain.SetTrigger("Neg");
            }
        }
       
    }
    
}
