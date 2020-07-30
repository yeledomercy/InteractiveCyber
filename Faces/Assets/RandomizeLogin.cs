using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeLogin : MonoBehaviour
{
    public GameObject KaiLogin;
    public GameObject SarahLogin;

    private void Awake()
    {
       int login = Random.Range(0, 2);
        Debug.Log(login);
       if (login < 0.5)
       {
            KaiLogin.SetActive(true);
       }
       else
       {
            SarahLogin.SetActive(true);
       }
        
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
