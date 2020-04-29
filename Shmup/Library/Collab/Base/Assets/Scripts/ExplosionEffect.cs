using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour {

    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
        animator.SetBool("endAnim", false);
        GetComponent<Animation>().Play();
        selfDestruct();
    }

    /**
     * selfDestruct
     * This function is called in the Animation Event for this objects' animation.
     * The animation is called "explosion_spritesheet.anim" but you can click the 2D 
     * sprite explosion prefab to check out the animation event on frame 35. 
     * That's when the animation ends. 
     */
    void selfDestruct() {
        //Destroy(this, animator.GetCurrentAnimatorStateInfo(0).length);
        //animator.SetBool("endAnim", true);
        GetComponent<Animation>().Stop();
        //Destroy(this);
        Destroy(GetComponent<Animation>());
        //exploAnimator.SetBool("endAnim", true);
        Debug.Log("PLEASE DESTROY EXPLOSION OBJECT");
        Destroy(animator);
        Destroy(this);
    }


}
