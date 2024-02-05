using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private string EnemyName;
    [SerializeField] private string EnemyDescription;
    [SerializeField] private int EnemyHealth;
    [SerializeField] private int EnemyDamage;
    [SerializeField] private int EnemmySpeed;

    public string EnemyName1 { get => EnemyName; set => EnemyName = value; }
    public string EnemyDescription1 { get => EnemyDescription; set => EnemyDescription = value; }
    public int EnemyHealth1 { get => EnemyHealth; set => EnemyHealth = value; }
    public int EnemyDamage1 { get => EnemyDamage; set => EnemyDamage = value; }
    public int EnemmySpeed1 { get => EnemmySpeed; set => EnemmySpeed = value; }

    public void Attacked(int damage)
    {
        EnemyHealth1 -= damage;

        Debug.Log(EnemyName + " has been hit! Health = " + EnemyHealth);
    }
}
