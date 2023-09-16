using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hunt_Manager : MonoBehaviour
{
    [SerializeField]float timer = 30f;
    float timer2 = 3f;
    [SerializeField] List<GameObject> ms;
    [SerializeField] saveP gameStat;
    [SerializeField] AxeAttack axeData;
    int current_m;


    [SerializeField] TextMeshProUGUI animals_kill;
    [SerializeField] TextMeshProUGUI solder_feeded;
    [SerializeField] TextMeshProUGUI solder_kill;
    [SerializeField] TextMeshProUGUI day;

    void Start()
    {
        current_m = 0;

    }

    // Update is called once per frame
    void Update()
    {

        int remaining = (gameStat.total_mobs - ((gameStat.number_ship * 2) + (gameStat.number_cow * 3) + (gameStat.number_humain * 3)));
        animals_kill.text =  " Animals killed \n sheeps : " + gameStat.number_ship + "\n cows : " + gameStat.number_cow + " \n humains :" + gameStat.number_humain;
        solder_feeded.text = " Solders fed :\n      " + ((gameStat.number_ship * 2) + (gameStat.number_cow * 3) + (gameStat.number_humain * 3));
        day.text  = " DAY :" + gameStat.day.ToString();
        if(remaining > 0)
            solder_kill.text = " Solders killed : \n      " + remaining;
        else
            solder_kill.text = " Solders killed : \n      " + gameStat.total_mobs;
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            axeData.isAttacking = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            appearMenu(ms[current_m]);
            if (ms[2].activeInHierarchy)
            {
                timer2-=Time.deltaTime;
                if(timer2 <= 0) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

            }
        }
    }

    void appearMenu(GameObject m)
    {
        ms[current_m].SetActive(false);
        m.SetActive(true);
    }
    public void NextButton()
    {
        appearMenu(ms[current_m+1]);
        current_m++;
    }
}
