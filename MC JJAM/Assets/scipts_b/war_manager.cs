using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class war_manager : MonoBehaviour
{
    [SerializeField] List<GameObject> mobs;
    public List<GameObject> mobs_instance;
    [SerializeField] selectedMob selectMob;
    int input_id;

    [SerializeField] int number_Archer;
    [SerializeField] int number_solders;
    [SerializeField] int number_advanced;
    Transform parent;


    [Header("UI")]

    [SerializeField] TextMeshProUGUI allSolder;
    [SerializeField] TextMeshProUGUI m_archer;
    [SerializeField] TextMeshProUGUI m_solders;
    [SerializeField] TextMeshProUGUI m_advanced;

    [SerializeField] saveP gameStat;



    private void Awake()
    {
   
        number_Archer = gameStat.number_archer;
        number_solders = gameStat.number_solders;
        number_advanced = gameStat.number_advanced;


    }
    private void Start()
    {
        parent = GameObject.Find("Army_Parent").transform;
        selectMob.amount = number_Archer;
        selectMob.selectedmob = mobs[0];
    }
    private void Update()
    {

        allSolder.text = " all : " + gameStat.total_mobs.ToString();
        m_archer.text = " archers : " + number_Archer.ToString();
        m_solders.text = " solders : " + number_solders.ToString();
        m_advanced.text = " advanced : " + number_advanced.ToString();


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectMob.selectedmob = mobs[0];
            selectMob.amount = number_Archer;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectMob.selectedmob = mobs[1];
            selectMob.amount = number_solders;

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectMob.selectedmob = mobs[2];
            selectMob.amount = number_advanced;

        }


        if (Input.GetMouseButtonDown(0))
        {
            if(selectMob.amount > 0)
            {
                GameObject a = Instantiate(mobs[input_id].transform, GetMousePositionInWorld(), Quaternion.identity,parent).gameObject;
                selectMob.amount--;
                a.AddComponent<Rigidbody>();
                a.GetComponent<Rigidbody>().isKinematic = true;
                mobs_instance.Add(a);
            }
            RefreshNumber(input_id);
            //addComponent mobWar
        }
    }

    public Vector3 GetMousePositionInWorld()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("ground")))
        {
            return new Vector3(hit.point.x, hit.point.y, hit.point.z);
        }
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
[System.Serializable]
public class selectedMob
{
    public int amount;
    public GameObject selectedmob;
}
