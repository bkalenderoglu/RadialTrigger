using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class RadialTrigger : MonoBehaviour
{
    public float radius = 1f;
    public Transform player;


    #if UNITY_EDITOR
    void OnDrawGizmos(){
        Vector2 center = transform.position;

        if(player == null) return;

        Vector2 playerPos = player.position;
        Vector2 delta = center - playerPos; // vector
        float sqrDistance = delta.x * delta.x + delta.y * delta.y; // squared length of vector delta, another way -> Vector2.Dot(delta, delta)


        //float distance = Vector2.Distance(center, playerPos);
        bool isInside = sqrDistance <= radius * radius;
        Handles.color = isInside ? Color.green : Color.red;

        //DrawWireDisc(Vector3 center, Vector3 normal, float radius)
        // normal vector specifies what orientation that disc should have
        Handles.DrawWireDisc(center, Vector3.forward, radius);
    }
    #endif
}
