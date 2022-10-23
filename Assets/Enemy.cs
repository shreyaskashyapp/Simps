using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform playerpos;
    [SerializeField] LayerMask layer;
    [SerializeField] Transform sphere;
    [SerializeField] float range;
    public GameObject Projectile;
    public Transform bulletSpawn;
    public float bulletSpeed=10;
    void Awake()
    {
        navMeshAgent=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {   if(inRange()){
        Debug.Log("Ready to shoot");
        var bullet=Instantiate(Projectile,bulletSpawn.position,bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawn.forward *bulletSpeed;
    }
        
        navMeshAgent.destination=playerpos.position;
    }
    bool inRange(){
        return Physics.CheckSphere(sphere.position,range*0.1f,layer);
    }
}
