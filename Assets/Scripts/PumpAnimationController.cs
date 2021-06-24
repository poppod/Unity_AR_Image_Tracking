using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpAnimationController : MonoBehaviour
{
    public Animator pump_Animation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        // if(Input.GetKeyDown(KeyCode.W)){
        //     pump_Animation.SetTrigger("NextStep");
        // }
        // if(Input.GetKeyDown(KeyCode.S)){
            
        //     pump_Animation.SetTrigger("PreviousStep");
        // }
    }
    public void OnclickNext(){
        pump_Animation.SetTrigger("NextStep");
    }
        
    public void OnclickPrevious(){
         pump_Animation.SetTrigger("PreviousStep");
    }
}
