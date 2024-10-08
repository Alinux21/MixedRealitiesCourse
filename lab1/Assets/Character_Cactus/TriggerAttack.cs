using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    private Animator mAnimator;
    public Transform targetObject; 
    public float triggerDistance = 0.3f; 
    
    //Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    //Update is called once per frame
    void Update()
    {
        if (targetObject != null && mAnimator != null)
        {
            float distance = Vector3.Distance(transform.position, targetObject.position);
            print(distance);

            if (distance <= triggerDistance)
            {
                    print("ATTACK");
                    mAnimator.SetTrigger("TrAttack");
            }else{
                print("IDLE");
                mAnimator.SetTrigger("TrIdle");
            }
        }
    }
}