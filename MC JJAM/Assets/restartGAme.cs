using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartGAme : MonoBehaviour
{
    [SerializeField] saveP g1;
    [SerializeField] saveP g2;
    [SerializeField] HubManager h;
    public void Restart()
    {
        g1.day = g2.day;
        g1.total_mobs = g2.total_mobs;
        g1.number_archer = g2.number_archer;
        g1.number_solders = g2.number_solders;
        g1.number_advanced = g2.number_advanced;
        g1.number_ship = g2.number_ship;
        g1.number_cow = g2.number_cow; 
        g1.number_humain = g2.number_humain;
        h.initUI();
    }

}
