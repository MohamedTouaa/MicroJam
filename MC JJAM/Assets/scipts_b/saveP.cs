using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "savepr", menuName = "save_Programe")]
public class saveP : ScriptableObject
{
    public int day;
    public int total_mobs;
    public int number_archer;
    public int number_solders;
    public int number_advanced;
    public int number_ship;
    public int number_cow;
    public int number_humain;
    public int number_spawner;

    public void Init(int day, int total_mobs, int number_archer, int number_solders, int number_advanced, int number_ship, int number_cow, int number_humain,int number_spawner)
    {
        this.day = day;
        this.total_mobs = total_mobs;
        this.number_archer = number_archer;
        this.number_solders = number_solders;
        this.number_advanced = number_advanced;
        this.number_ship = number_ship;
        this.number_cow = number_cow;
        this.number_humain = number_humain;
        this.number_spawner = number_spawner;
    }
}
