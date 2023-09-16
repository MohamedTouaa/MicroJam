using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public List<GameObject> animals;
    float randomNum;
    float timer;
    int point = 4;
    void Start()
    {
        randomNum = Random.Range(0, 5);
        timer = randomNum;
    }
    private void Update()
    {
        if(point > 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                GameObject i = Instantiate(animals[Random.Range(0, animals.Count)], transform.position, Quaternion.identity);
                if(i.tag == "sheep")
                {
                    point -= 2;
                }
                else if(i.tag == "cow")
                {
                    point = Random.Range(0, 2);
                }
                else
                {
                    point = 0;
                }
            }
        }
 
    }


}
