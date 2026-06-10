using UnityEngine;

[CreateAssetMenu(menuName = "FSM/Attack")]
public class AttackStateSO : StateSO
{
    public StateSO chaseState;

    public override void Enter(EnemyController enemy)
    {
        Debug.Log("Masuk State: Attack");
    }

    public override void Execute(EnemyController enemy)
    {
        // Debug.Log("Enemy menyerang Player");

        if (enemy.DistanceToPlayer() > enemy.attackRange)
        {
            enemy.ChangeState(chaseState);
        }
    }

    public override void Exit(EnemyController enemy)
    {
        Debug.Log("Keluar dari State: Attack");
    }
}