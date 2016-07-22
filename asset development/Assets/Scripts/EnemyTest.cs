using UnityEngine;
using System.Collections;

public class EnemyTest : MonoBehaviour {

    public float speed;

    public GameObject target;
    public Transform target_transform;
	// Use this for initialization
	void Start () {
        target_transform = target.transform;
	}
	
	// Update is called once per frame
	void Update () {

        
        gameObject.transform.LookAt(target_transform);


	}
    void FixedUpdate()
    {

        gameObject.transform.position += transform.up * speed * Time.deltaTime;
    }
}
