using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Code
{

    public class raycastBackup : MonoBehaviour
    {
        public LayerMask layerMask;
        ConnectedWaypoint currentWaypoint;
        public CapsuleCollider coneCollider;
        float playerWaypoint;

        private Ray sight;
        float chaseRange = 25f;

        public Collider visCone;

        private void Start()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
        }

        void Update()
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 25, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                Debug.Log("Hit");
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.green);
                Debug.Log("Not Hit");
            }
        }

        public void OnTriggerEnter(Collider collider)
        {
            if (!(coneCollider.isTrigger = true))
            {
                Debug.Log("ConeTriggered");
                return;
            }
            if (collider.gameObject.tag == "Player")
            {
                Debug.Log("Cone Triggered");
            }
        }
    }
}