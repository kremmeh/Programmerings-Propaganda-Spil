
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform[] player;
    private NavMeshAgent agent;
    int targetPoint = -1;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetPoint = (int)Random.Range(0, player.Length);
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player[targetPoint].position; 
    }
}
