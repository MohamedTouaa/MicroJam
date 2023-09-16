using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Animals_randomizer : MonoBehaviour
{
    [SerializeField] List<Transform> paths;
    NavMeshAgent agent;
    [SerializeField] Transform currentPoint;
    public int pathCount = 0;
    private void Awake()
    {


    }
    private void Start()
    {
        if(!GetComponent<NavMeshAgent>()) 
            agent = transform.GetChild(0).GetComponent<NavMeshAgent>();
        else
            agent = GetComponent<NavMeshAgent>();

        int n = paths.Count;
        for (int i = 0; i < n - 1; i++)
        {
            int randomIndex = Random.Range(i, n);
            Transform temp = paths[i];
            paths[i] = paths[randomIndex];
            paths[randomIndex] = temp;
        }

        currentPoint = paths[pathCount];
    }

    private void Update()
    {
        if (currentPoint != null)
        {
            agent.SetDestination(currentPoint.position);
            //transform.parent.LookAt(currentPoint.position);
        }
        else
            currentPoint = paths[pathCount];
        checkPointDistance();
    }
    void checkPointDistance()
    {
        if (pathCount > paths.Count)
        {
            pathCount = -1;
        }
        float dis = Vector3.Distance(agent.transform.position, currentPoint.position);
        if (dis < 2f)
        {
            print("it coo");
            pathCount++;
            currentPoint = paths[pathCount];
        }
    }

}
