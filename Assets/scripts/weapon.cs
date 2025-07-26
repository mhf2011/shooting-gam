using UnityEngine;

public class weapon : MonoBehaviour
{

    [SerializeField] PlayerInputs playerInputs;
    bool shoot;

    RaycastHit hit;
    void Update()
    {
        if (playerInputs.shoot)
        {
            shoot = playerInputs.shoot;
            Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity);
            if (hit.collider.CompareTag("Player"))
            {
                Destroy(hit.collider.gameObject);
            }



        }


    }
}
