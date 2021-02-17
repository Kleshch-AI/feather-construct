using UnityEngine;
using FeatherConstruct.Utils;

namespace FeatherConstruct.Controllers
{

    public class ConstructController : MonoBehaviour
    {

        [SerializeField] private float speed = 2f;

        private bool flying = false;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                flying = true;
                var flightFactor = new Vector2(0, 0);
                if (Input.GetKey(KeyCode.D)) flightFactor.x += 1;
                if (Input.GetKey(KeyCode.A)) flightFactor.x -= 1;
                if (Input.GetKey(KeyCode.W)) flightFactor.y += 1;
                if (Input.GetKey(KeyCode.S)) flightFactor.y -= 1;
                ProcessFlight(flightFactor);
            }
            else if (flying)
            {
                ProcessLand();
            }
            else
            {
                var walkFactor = 0;
                if (Input.GetKey(KeyCode.D)) walkFactor += 1;
                if (Input.GetKey(KeyCode.A)) walkFactor -= 1;
                ProcessWalk(walkFactor);
            }
        }

        private void ProcessWalk(int factor)
        {
            gameObject.transform.position += new Vector3(factor * speed, 0, 0);
        }

        private void ProcessFlight(Vector2 factor)
        {
            gameObject.transform.position += new Vector3(factor.x * speed, factor.y * speed, 0);
        }

        private void ProcessLand()
        {
            gameObject.transform.position += new Vector3(0, -speed, 0);
        }

        private void OnTriggerEnter(Collider other) 
        {
            if (other.gameObject.CompareTag(TagUtils.Ground) && flying) flying = false;    
        }

    }

}