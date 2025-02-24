using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Ship : MonoBehaviour
{
    public List<Cannon> cannons = new List<Cannon>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.InstanceID).ToList();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            FireAllCannons();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FireEvenCannons();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireOddCannons();
        }
        
    }
    void FireAllCannons()
    {
        foreach (Cannon c in cannons)
        {
            c.FireCannon();
        }
        /*for (int i = 0; i < cannons.Count; i++)
        {
            cannons[i].FireCannon();
        }*/
    }
    void FireEvenCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            // the mod (%) operator does division and returns the remainer, remainder of %2 is 0 for even numbers
            if (i % 2 == 0)
            {
                cannons[i].FireCannon();
            }

        }
    }
    void FireOddCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {

            if (i % 2 == 1)
            {
                cannons[i].FireCannon();
            }

        }
    }
    void FireAllPowerfulCannons()
    {
        foreach(Cannon c in cannons)
        {
            if(c.forcePower > 500)
            {
                c.FireCannon();
            }
        }
    }
    void FireAllWeakCannons()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            if(cannons[i].forcePower<4500)
            {
                cannons[i].FireCannon();
            }
        }
    }
}
