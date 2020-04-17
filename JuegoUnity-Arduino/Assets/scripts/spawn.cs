using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    [SerializeField]
    public GameObject enemigo;
    public int xPos;
    public int zPos;
    public int enemyCount;
    // Start is called before the first frame update
    void Start() {
        StartCoroutine(EnemyDrop());
    IEnumerator EnemyDrop() {
            while (enemyCount < 100) {

                xPos = Random.Range(-100,50);
                zPos = Random.Range(80,120);
                Instantiate(enemigo, new Vector3(xPos, 5, zPos), Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                enemyCount += 1;
            
            }
        
        
        }
    }

    // Update is called once per frame
   
}
