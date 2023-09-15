using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class war_manager : MonoBehaviour
{
    [SerializeField] List<GameObject> mobs;
    [SerializeField] selectedMob selectMob;
    int input_id;

    [SerializeField] int number_Archer;
    [SerializeField] int number_solders;
    [SerializeField] int number_advanced;

    private void Start()
    {
        selectMob.amount = number_Archer;
        selectMob.selectedmob = mobs[0];
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectMob.selectedmob = mobs[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
            selectMob.selectedmob = mobs[1];

        if (Input.GetKeyDown(KeyCode.Alpha3))
            selectMob.selectedmob = mobs[2];

        if (Input.GetMouseButtonDown(0))
        {
            if(selectMob.amount > 0)
                Instantiate(mobs[input_id].transform,getMousePosWorld(),Quaternion.identity);
            RefreshNumber(0);
            //addComponent mobWar
        }
    }

    public Vector3 getMousePosWorld()
    {
        Ray ray = Camera.main.ScreenPointToRay(transform.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000f, LayerMask.GetMask("ground")))
        {
            return hit.point;
        }
        else
            return Vector3.zero;
    }
    void RefreshNumber(int id )
    {
       if(selectMob.selectedmob == mobs[0])
        {
            number_Archer = selectMob.amount;
        }
        if (selectMob.selectedmob == mobs[1])
        {
            number_solders = selectMob.amount;
        }
        if (selectMob.selectedmob == mobs[2])
        {
            number_advanced = selectMob.amount;
        }

    }
}
public class selectedMob
{
    public int amount;
    public GameObject selectedmob;
}
