using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] animelList;
    public float startTime = 2f;
    public float intrevelTime = 4f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimel", startTime, intrevelTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnAnimel()
    {
        int randomIndex = Random.Range(0, animelList.Length);
        GameObject animel = Instantiate(animelList[randomIndex], transform.position, transform.rotation);
        animel.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        animel.transform.Rotate(Vector3.up, 180);
    }

}
