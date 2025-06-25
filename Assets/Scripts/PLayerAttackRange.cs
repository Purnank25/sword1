using UnityEngine;

public class PLayerAttackRange : MonoBehaviour
{
    public bool playerIsAttacking = false;

    void OnEnable()
    {
        playerIsAttacking = true;
        Invoke(nameof(EndAttack), 0.2f); // Set attack duration
    }

    void EndAttack()
    {
        playerIsAttacking = false;
        gameObject.SetActive(false); // Disable hitbox after attack
    }
}
