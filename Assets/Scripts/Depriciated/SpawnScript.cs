using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform[] spawnPoints;
    private GameObject[] baloons;
    
    
    
    void Start()
    {
        StartCoroutine(StartTheSpawn());
    }

    // Update is called once per frame
   IEnumerator StartTheSpawn()
    {
        yield return new WaitForSeconds(4);

        for (int i = 0; i<3; i++)
        {
            Instantiate(baloons[i], spawnPoints[i].position, Quaternion.identity);
        }
        StartCoroutine(StartTheSpawn());


    }


}
