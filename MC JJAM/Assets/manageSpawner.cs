using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageSpawner : MonoBehaviour
{
    [SerializeField] saveP gameStat;

    private void Start()
    {
        if(gameStat.day <= 4)
        {
            for (int i = transform.childCount - 1; i > transform.childCount - (gameStat.day - 1) * 5; i--)
            {
                Destroy(transform.GetChild(i).gameObject);
            }
        }

    }
}
