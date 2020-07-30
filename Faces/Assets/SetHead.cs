using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHead : MonoBehaviour
{
    public static SetHead instance;

    private void OnEnable()
    {
       ChangeHead.headStateChange += OnHeadStateChange;      
    }

    private void OnDisable()
    {
        ChangeHead.headStateChange -= OnHeadStateChange;         
    }

    private void OnHeadStateChange(string state)
    {
        if (gameObject.name == state)
        {
            gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        }
    }

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
