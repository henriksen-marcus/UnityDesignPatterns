using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


namespace WeaponFactory
{

public interface Weapon
{
    public void Attack();
}


public class Sword : Weapon
{
    public void Attack()
    {
        Debug.Log("Swinging a sword");
    }
}

public class Pistol : Weapon
{
    public void Attack()
    {
        Debug.Log("trigger pistol ");
    }
}

public class Bow : Weapon
{
    public  void Attack()
    {
        Debug.Log("Firing a bow");
    }
}


    public class WeaponFact
{
    public Weapon CreateWeapon(string weaponType)
    {
        switch (weaponType)
        {
            case "Sword":
                return new Sword();
            case "Bow":
                return new Bow();
            case "Pistol":
                return new Pistol();
            default:
                throw new Exception("Invalid weapon type");
            }
    }
}



}
