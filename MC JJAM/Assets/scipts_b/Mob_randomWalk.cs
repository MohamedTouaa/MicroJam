using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mob_randomWalk : MonoBehaviour
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

        agent = GetComponent<NavMeshAgent>();
        currentPoint = paths[pathCount];
    }

    private void Update()
    {
        if (currentPoint != null)
            agent.SetDestination(currentPoint.position);
        else
            currentPoint = paths[pathCount];
        checkPointDistance();
    }
    void checkPointDistance()
    {
        if(pathCount > paths.Count)
        {
            pathCount = -1;
        }
        float dis = Vector3.Distance(agent.transform.position, currentPoint.position);
        if(dis < 7f)
        {
            print("it coo");
            pathCount = Random.Range(0, paths.Count);
            currentPoint = paths[pathCount];
        }
    }
   

}
