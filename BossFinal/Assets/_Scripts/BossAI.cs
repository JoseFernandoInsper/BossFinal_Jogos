using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : StateMachineBehaviour
{
    Transform player;
    Rigidbody2D rb;
    public float speed = 3f;
    public float attackRange = 3f;

    public float max = 100f;
    public float min = 0f;

    public float Ratkk;
    Boss boss;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<Boss>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss.LookAtPlayer();
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPosition = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        //Debug.Log(newPosition);
        rb.MovePosition(newPosition);

        Ratkk = Random.Range(min, max);
        if(Ratkk< 0.1f){
            animator.SetTrigger("RandomAttack");
        }

        if(Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            animator.SetTrigger("Attack");
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
        //animator.SetTrigger("RandomAttack");
    }

}
