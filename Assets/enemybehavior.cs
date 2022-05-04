using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemybehavior : MonoBehaviour
{
    private GameObject p1;
    public GameObject enemyobj;
    public ParticleSystem ExplosionEffect;
    public bool explosionStarted;
    public bool explosionFinished;
    public float moveSpeed = 10;
    void Start()
    {
        p1 = GameObject.Find("p1");
    }
    void Update()
    {
        enemyobj.GetComponent<NavMeshAgent>().SetDestination(p1.transform.position);
        enemyobj.transform.position += enemyobj.transform.forward * moveSpeed * Time.deltaTime;
        var distance = Vector3.Distance(enemyobj.transform.position, p1.transform.position);
        Debug.Log(distance);
        if (distance < 7)
        {
            RemoveEnemy();
            StartCoroutine(Explode());
        }
    }
    void RemoveEnemy()
    {
        Destroy(enemyobj.gameObject);
    }
    IEnumerator Explode()
    {
        ParticleSystem explosion = Instantiate(ExplosionEffect) as ParticleSystem;
        explosion.transform.position = enemyobj.transform.position;
        explosion.Play();
        explosionStarted = true;
        yield return new WaitForSeconds(1);
        Destroy(explosion.gameObject);
    }
}
