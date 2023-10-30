using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleMotionController : StateMachineBehaviour {
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.SetBool("LockMotion", false);
        animator.ResetTrigger("IdleSwitch01");
        animator.ResetTrigger("IdleSwitch02");
        animator.ResetTrigger("IdleSwitch03");
    }
}