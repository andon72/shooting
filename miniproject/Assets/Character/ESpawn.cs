using System.Collections;
using UnityEngine;

public class ESpawn : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator EnemySpawn()
    {
        while (true)
        {
            Instantiate(enemy, new Vector2(3.5f, Random.Range(-1.8f,1.9f)),Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0.5f, 3f));
            
        }
    }
}
