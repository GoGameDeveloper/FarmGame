using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveHorizntal;
    public float speed = 20f;
    public int xRange = 50;
    public GameObject[] foodList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizntal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * moveHorizntal);

        if (transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            int randomIndex = Random.Range(0,13);
            GameObject foodObject = Instantiate(foodList[randomIndex]);
            foodObject.transform.position = transform.position;
        }

    }
}
