using UnityEngine;

// abstract means you can only INHERIT from 'speedPower'
public abstract class powerUp : ScriptableObject
{
    public abstract void Apply(GameObject target);
}
