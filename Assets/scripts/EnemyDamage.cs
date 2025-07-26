using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int damageAmount = 20;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth player = collision.gameObject.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.TakeDamage(damageAmount);
            }
        }
    }
}
