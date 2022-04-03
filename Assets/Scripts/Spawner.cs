using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _spawnPrefab;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }   

    private IEnumerator SpawnEnemy()
    {
        while(true)
        {
            int count = Random.Range(0,4);
            GameObject enemy = Instantiate(_spawnPrefab, _spawnPoints[count].position, Quaternion.Euler(40f, 50f, 50f));
            enemy.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 20f, 0f), ForceMode.Impulse);
            yield return new WaitForSeconds(0.2f);
        }
        
    }
}
