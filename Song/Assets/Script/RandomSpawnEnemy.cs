
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnEnemy : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnTargets = new List<Transform>();
    private bool inKD = false;
    [SerializeField] private GameObject emenyPrefab;
    [SerializeField] private float KD;
    private void Update()
    {
        if (!inKD)
        {
            GameObject enemy = Instantiate(emenyPrefab, spawnTargets[Random.Range(0, spawnTargets.Count)]);
            enemy.transform.parent = null;
            StartCoroutine(KDBetweenSpawns());
           
        }
    }
    private IEnumerator KDBetweenSpawns()
    {
        inKD = true;
        yield return new WaitForSeconds(KD);
        inKD = false;
    }
    

}
