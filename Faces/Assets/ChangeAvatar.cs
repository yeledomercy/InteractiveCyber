using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class ChangeAvatar : MonoBehaviour
{
    public RealtimeAvatarManager MyManager;
    public GameObject Kai;
    public GameObject Sarah;
    private GameObject currentFace;
    // Start is called before the first frame update
    void Start()
    {
        currentFace = Kai;
    }
    // on click change prefab face
    // 

    public void OnClickChangeFace()
    {
        if (currentFace == Kai)
        {
            MyManager._localAvatarPrefab = Sarah;
            currentFace = Sarah;
        }
        else
        {
            MyManager._localAvatarPrefab = Kai;
            currentFace = Kai;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            OnClickChangeFace();
        }
        
    }
}
