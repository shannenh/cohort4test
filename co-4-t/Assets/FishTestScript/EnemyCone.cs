using UnityEngine;

namespace Assets.Code
{
    public class EnemyCone : MonoBehaviour
    {

        public Collider cone;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
         
        }

        public void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                
            }
        }
    }
}