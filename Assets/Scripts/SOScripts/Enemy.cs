using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyData enemyData;

    public GameObject nameText;

    private void Start()
    {
        GetComponent<Renderer>().material.color = enemyData.enemyColor;
        nameText.GetComponent<TextMeshPro>().text = enemyData.enemyName;
    }
}
