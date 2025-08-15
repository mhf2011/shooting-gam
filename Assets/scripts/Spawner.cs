using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject bot;
    [SerializeField] float spawnInterval = 1f; 

    void Start()
    {
        StartCoroutine(SpawnBots());
    }

    IEnumerator SpawnBots()
    {
        while (true)
        {
            Instantiate(bot, transform.position, transform.rotation);
            yield return new WaitForSeconds(spawnInterval);  
        }
    }
}
