using UnityEngine;

public class BreakingCollectables : MonoBehaviour
{
    private bool isbreak = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(" Grass triggered by: " + collision.name + " | Tag: " + collision.tag);

        if (!isbreak && collision.CompareTag("PlayerAttack"))
        {
            var attackScript = collision.GetComponent<PLayerAttackRange>();

            if (attackScript == null)
            {
                Debug.LogWarning(" PLayerAttackRange script NOT found on: " + collision.name);
            }
            else
            {
                Debug.Log(" Found PLayerAttackRange on: " + collision.name + " | playerIsAttacking: " + attackScript.playerIsAttacking);

                if (attackScript.playerIsAttacking)
                {
                    isbreak = true;
                    GetComponent<Collider2D>().enabled = false;
                    Debug.Log(" Grass broken!");
                    transform.position += new Vector3(0, 0.5f, 0);
                }
                else
                {
                    Debug.Log("? Script found but playerIsAttacking was FALSE.");
                }
            }
        }
    }

}
