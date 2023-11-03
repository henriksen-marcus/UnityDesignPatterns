using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponFactory;

public class GManager : MonoBehaviour
{
    private WeaponFactory.WeaponFact weaponFactory;

    private void Start()
    {
        weaponFactory = new WeaponFactory.WeaponFact();

        // Create and use weapons
        Weapon sword = weaponFactory.CreateWeapon("Sword");
        sword.Attack();

        Weapon bow = weaponFactory.CreateWeapon("Bow");
        bow.Attack();
        Weapon pistol = weaponFactory.CreateWeapon("Pistol");
        pistol.Attack();
    }
}
