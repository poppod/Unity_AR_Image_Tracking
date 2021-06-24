using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimation : MonoBehaviour
{
    [SerializeField] GameObject robot;
    [SerializeField] Transform originStart;
    [SerializeField] Transform underGroundStart;
    Animation m_animation;
    
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
       // robot.transform.position=underGroundStart.position;
       m_animation=robot.GetComponent<Animation>();
       m_animator=robot.GetComponent<Animator>();
       EventController.ON_TARGET_LOST+=ResetBtn;
    }

    // Update is called once per frame
    void Update()
    {
        //tets
    }
    public void OnImageTracked(){
        //LeanTween.move(robot,originStart.position,1.0f);
        //m_animation.Play();
        m_animator.SetTrigger("moveup");
    }
    public void OnImageLostTracked(){
       // m_animator.SetTrigger("Idle");
       m_animator.SetTrigger("Reset");
        
    }
    public void ResetBtn(){
        //robot.SetActive(false);
        //robot.transform.Rotate(Vector3.zero);
        m_animator.SetTrigger("Reset");
        m_animator.SetTrigger("moveup");
        robot.SetActive(true);
    }
    public void NextBtn(){
        m_animator.SetTrigger("NextStep");
    }
}
