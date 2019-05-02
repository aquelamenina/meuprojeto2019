using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
     GameObject parent;
    
    public GameObject prefab;
    public GameObject spawnPoint;

    public float waitTime = 3f;

    public float prejectileSpeed = 3f;

    public Vector3[] directions;  





    void Start()
    {
        parent = GameObject.Find("Tape");
    }
    
     IEnumerator  Spawn () {
        while(true) {
            yield return new WaitForSeconds(waitTime);
            for(int i=0; i<directions.Lenght; i++) {
               GameObject projectile = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
               projectile.transform.SetParent(parent.transform);
               projectile.GetComponent<Rigidbody2D>().velocity = projectileSpeed * directions[i];

            }
        }
    }
    
    
}
