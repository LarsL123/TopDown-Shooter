using UnityEngine;

public class DrawPoint : MonoBehaviour {

    [Range(0.1f, 5)]
    public float radius = 10;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
