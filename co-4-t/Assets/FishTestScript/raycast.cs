using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Code
{

    public class raycast : MonoBehaviour
    {
        public LayerMask layerMask;
        ConnectedWaypoint currentWaypoint;
        public CapsuleCollider coneCollider;
        float playerWaypoint;
        float playerPosition;
        
        private Ray sight;
        float chaseRange = 25f;

        private void Start()
        {
            bool coneTrigger = coneCollider.isTrigger = true;
            if (coneTrigger) 
            {

            }
        }


        void FixedUpdate()
        {
            
                sight.origin = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
                sight.direction = transform.forward;
                RaycastHit rayHit;
                Vector3 fwd = transform.TransformDirection(Vector3.forward);

                if (Physics.Raycast(sight, out rayHit, chaseRange, layerMask))
                {
                    Debug.DrawLine(sight.origin, rayHit.point, Color.red);
                    if (rayHit.collider.tag == "Player")
                    {
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayHit.distance, Color.red);
                        Debug.Log("Class");
                        return;
                    }

                    if (rayHit.collider.tag != "Player" && rayHit.collider.tag != "Enemy")
                    {
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayHit.distance, Color.green);
                    }
                }
            
        }
    }
}
