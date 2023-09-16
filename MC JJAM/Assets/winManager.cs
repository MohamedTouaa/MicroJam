using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class winManager : MonoBehaviour
{
    [SerializeField] saveP gamestat;
    int score;
    int Enemyscore;
    [SerializeField] TextMeshProUGUI ourScore;
    [SerializeField] TextMeshProUGUI EnemyScore;
    [SerializeField] TextMeshProUGUI WinText;
    int calculateScore()
    {
        score = gamestat.number_archer + gamestat.number_solders * 2 + gamestat.number_advanced * 3;
        return score;
    }
    private void Start()
    {
        Enemyscore = (int)Random.Range(10f,25f);
        
        ourScore.text =  calculateScore().ToString();
        EnemyScore.text =  Enemyscore.ToString();
        checkWIN();
    }

    void checkWIN()
    {
        if(Enemyscore < calculateScore())
        {
            WinText.text = " You won !!";
        }
        else
        {
            WinText.text = " You lost !!";
        }
    }

}
