using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class RobotSpawnerScript : MonoBehaviour
{
    public GameObject RobotPrefab;
    public int RobotStartAmount;
    public int RobotCurrentAmount;
    public float explodetimer;
    public List<ExplodingRobot> robots = new List<ExplodingRobot>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RobotStartAmount = Random.Range(20, 40);
        RobotCurrentAmount = RobotStartAmount;
        explodetimer = 25;
    }

    // Update is called once per frame
    void Update()
    {
        if (RobotStartAmount > 0)
        {
            Vector3 RandomPos = new Vector3(Random.Range(-25,25), Random.Range(2, 5), Random.Range(-25, 25));
            GameObject go = Instantiate(RobotPrefab);
            go.transform.position = RandomPos;
            RobotStartAmount -= 1;
            robots = FindObjectsByType<ExplodingRobot>(FindObjectsSortMode.None).ToList();
        }
        if (explodetimer <= 0)
        {
            robots = FindObjectsByType<ExplodingRobot>(FindObjectsSortMode.None).ToList();
            robots[0].InitiateExplode();
            robots[1].InitiateExplode();
            RobotCurrentAmount -= 2;
            robots = FindObjectsByType<ExplodingRobot>(FindObjectsSortMode.None).ToList();
            explodetimer = Random.Range(5, 15);
        }
        else
        {
            explodetimer -= Time.deltaTime;
        }
    }
}
