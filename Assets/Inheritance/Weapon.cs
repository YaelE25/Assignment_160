using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private string weaponName;
    private int weaponStrenght;

    protected string WeaponName { get => weaponName; set => weaponName = value; }
    protected int WeaponStrenght { get => weaponStrenght; set => weaponStrenght = value; }

    protected virtual void TakeDamage(int damage)
    {
        weaponStrenght -= damage;
    }
}
