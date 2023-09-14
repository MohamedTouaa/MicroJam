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
        RandomizePaths();
        RandomizePaths();
        RandomizePaths();

    }
    private void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        currentPoint = paths[pathCount];
    }

    private void Update()
    {
        agent.SetDestination(currentPoint.position);
        checkPointDistance();
    }
    void checkPointDistance()
    {
        if(pathCount > paths.Count)
        {
            pathCount = -1;
        }
        float dis = Vector3.Distance(agent.transform.position, currentPoint.position);
        if(dis < 5f)
        {
            print("it coo");
            pathCount++;
            currentPoint = paths[pathCount];
        }
    }
    void RandomizePaths()
    {
        Transform t;
        int k = Random.Range(0, paths.Count);
        t = paths[k];
        if (k + 1 <= paths.Count)
            paths[k] = paths[k + 1];
        else if (k - 1 >= 0)
            paths[k] = paths[k - 1];
        else
            paths[k] = paths[Random.Range(0, paths.Count)];

    }

}
