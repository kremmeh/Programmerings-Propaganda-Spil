using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scenes.Btest
{
    public class AIRandomMovement : MonoBehaviour
    {
        public NavMeshAgent agent;
        public float range;
        public bool isTalking = false;

        public Transform centrePoint;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            if (!isTalking)
            {
                if (agent.remainingDistance <= agent.stoppingDistance) //done with path
                {
                    if (RandomPoint(centrePoint.position, range, out Vector3 point)) //pass in our centre point and radius of area
                    {
                        Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f); //so you can see with gizmos
                        agent.SetDestination(point);
                    }
                }

            }else
                agent.velocity = Vector3.zero;
        }
        bool RandomPoint(Vector3 center, float range, out Vector3 result)
        {

            Vector3 randomPoint = center + Random.insideUnitSphere * range; //random point in a sphere 
            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas)) //documentation: https://docs.unity3d.com/ScriptReference/AI.NavMesh.SamplePosition.html
            {
                //the 1.0f is the max distance from the random point to a point on the navmesh, might want to increase if range is big
                //or add a for loop like in the documentation
                result = hit.position;
                return true;
            }

            result = Vector3.zero;
            return false;
        }

        public void startTalking()
        {

            isTalking = true;

        }

        public void stopTalking() 
        { 
            isTalking = false; 
        }
    }

   

}