using Invector.vCharacterController;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.Utilities;

public class NavMeshEnemy : MonoBehaviour
{
    GameObject player;
    NavMeshAgent agent;
    PlayerScript playerScript;
    [SerializeField] float detectionRange = 10f;
    [SerializeField] float attackRange = 1.5f;
    [SerializeField] int damage = 10;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindAnyObjectByType<vThirdPersonController>().gameObject;
        playerScript = player.GetComponent<PlayerScript>();
    }

    void Update()
    {
        if (player == null) return;
        Vector3 positionDifference = player.transform.position - transform.position;
        float checkDistance = Vector3.Magnitude(positionDifference);
        if (checkDistance < detectionRange)
        {
            agent.SetDestination(player.transform.position);
            if(checkDistance < attackRange)
            {
                AttackPlayer();
            }
        }
        else
        {
            agent.SetDestination(transform.position);
        }

    }

    void AttackPlayer()
    {
        Debug.Log("Attack");
        //jakaœ animacja, particle system albo coœ
        playerScript.HpManager(-damage);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
