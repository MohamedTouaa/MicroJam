using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HubManager : MonoBehaviour
{
    [SerializeField] saveP Game_stat;
    [Header("UI")]

    [SerializeField] TextMeshProUGUI allSolder;
    [SerializeField] TextMeshProUGUI m_archer;
    [SerializeField] TextMeshProUGUI m_solders;
    [SerializeField] TextMeshProUGUI m_advanced;
    audioManagers mm;

    private void Awake()
    {
     
        checkWhoLive();
        initUI();
    }
    public void initUI()
    {
        allSolder.text = "all : " + Game_stat.total_mobs.ToString();
        m_archer.text = "archers : " + Game_stat.number_archer.ToString();
        m_solders.text = "solders : " + Game_stat.number_solders.ToString();
        m_advanced.text = "advanced : " + Game_stat.number_advanced.ToString();
    }
    private void Start()
    {
        mm = GameObject.Find("AudioManager").GetComponent<audioManagers>();
   
        mm.playS("night_ambience");
        mm.playS("camp_fire");
        Game_stat.day++;
        if(Game_stat.day >= 6)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    void checkWhoLive()
    {


        if(!check(Game_stat.number_archer, Game_stat.number_ship * 2))
            Game_stat.number_archer = Game_stat.number_ship * 2;
        if (!check(Game_stat.number_solders, Game_stat.number_cow * 3))
            Game_stat.number_solders = Game_stat.number_cow * 3;
        if (!check(Game_stat.number_advanced, Game_stat.number_humain * 3))
            Game_stat.number_advanced = Game_stat.number_humain * 3;

        Game_stat.total_mobs = Game_stat.number_advanced + Game_stat.number_archer + Game_stat.number_solders;


        //Game_stat.number_ship = 0;
        //Game_stat.number_cow = 0;
        //Game_stat.number_humain = 0;
    }
    bool check(int a , int b)
    {
        if(b > a)
        {
            return true;
        }
        return false;
    }

}
