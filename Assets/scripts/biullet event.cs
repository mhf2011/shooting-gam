using UnityEngine;

public class biulletevent : MonoBehaviour
{
    [SerializeField] biullet bullet;
    void OnTriggerEnter(Collider other)
    {


        bullet.SetPlayerPosition(other.gameObject.transform.position);
    }
     void OnTriggerExit(Collider other)
    {
        bullet.stopBullet();
    }


}