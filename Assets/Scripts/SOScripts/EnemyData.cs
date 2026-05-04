using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Enemy", menuName = "My SO/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public Color enemyColor;
    public string enemyName;
    public int health;
    public int damage;

}
