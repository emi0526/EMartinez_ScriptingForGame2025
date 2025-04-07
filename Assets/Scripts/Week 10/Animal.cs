using UnityEngine;

public enum BloodType
{
    ColdBlooded,
    WarmBlooded
}
public class Animal : MonoBehaviour
{
    protected BloodType bType;
    protected int health = 100;
    protected int energy = 100;
    public virtual void Eat(int energyGained)
    {
        energy += energyGained;
    }
}
