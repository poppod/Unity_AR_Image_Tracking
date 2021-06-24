using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    Vector3 ofset;
    // Start is called before the first frame update
    void Start()
    {
        ofset=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate(){
        transform.position=player.transform.position+ofset;
    }
}
