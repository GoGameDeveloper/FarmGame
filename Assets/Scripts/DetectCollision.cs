using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    ScoreManager sm;
    // Start is called before the first frame update
    void Start()
    {
        sm = FindAnyObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        sm.AddScore();
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
