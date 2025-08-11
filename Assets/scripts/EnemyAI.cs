using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 15f;
    public float shootingRange = 10f;
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public float fireCooldown = 1f;

    private NavMeshAgent agent;
    private float lastShotTime;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    [System.Obsolete]
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= detectionRange)
        {
            agent.SetDestination(player.position);

            if (distance <= shootingRange && Time.time > lastShotTime + fireCooldown)
            {
                Shoot();
                lastShotTime = Time.time;
            }

            // סיבוב לכיוון השחקן
            Vector3 dir = player.position - transform.position;
            dir.y = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * 5);
        }
    }

    [System.Obsolete]
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = shootPoint.forward * 20f;
    }
}
