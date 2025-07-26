using UnityEngine;

public class biullet : MonoBehaviour
{
  
    Vector3 playerPosition;
    bool istriggered = false;

    public void SetPlayerPosition(Vector3 position)
    {
        playerPosition = position;
        istriggered = true;
      
    }

        void OnCollisionEnter(Collision other)
    {
          if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
      
    }
    public void stopBullet()
    {
     istriggered = false;

  }

    void Update()
    {
        if (istriggered)
        {
            transform.position = Vector3.MoveTowards(transform.position,playerPosition,5*Time.deltaTime);
        }
            
        
        
    }
}