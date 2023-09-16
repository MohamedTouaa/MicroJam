using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hunt_Manager : MonoBehaviour
{
    [SerializeField]float timer = 30f;

    [SerializeField] GameObject[] ms;
    int current_m;


    void Start()
    {
        current_m = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    void appearMenu(GameObject m)
    {
        m.SetActive(true);
    }
    public void NextButton()
    {
        appearMenu[]
    }
}
