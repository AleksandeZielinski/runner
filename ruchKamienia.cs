using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruchKamienia : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 5f;
    [SerializeField] public GameObject wybuch;
    [SerializeField] public GameObject gracz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * Time.deltaTime * speed;
    }

 
}
