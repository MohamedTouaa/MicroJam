using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageSpawner : MonoBehaviour
{
    [SerializeField] saveP gameStat;
    int sp_amount = 0;

    private void Start()
    {
        if(gameStat.day > 2)
        {
            sp_amount = 10;
            gameStat.number_spawner -= sp_amount;

            for (int i = transform.childCount - 1; i > gameStat.number_spawner; i--)
            {
                Destroy(transform.GetChild(i).gameObject);
            }
        }

     



    }
}
