using UnityEngine;

public class Mammal : Animal
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        bType = BloodType.WarmBlooded;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Eat(int energyGained)
    {
        Debug.Log("Chomp Chomp eating with my mouth");
        base.Eat(energyGained);
    }
    public virtual void GiveBirth()
    {
        Debug.Log("Giving Birth to a Mammal");
    }
}
