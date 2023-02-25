using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class RadialTrigger : MonoBehaviour
{
    public float radius = 1f;
    public Transform objTf;


    #if UNITY_EDITOR
    void OnDrawGizmos(){
        Vector2 center = transform.position;
        Vector2 objPos = objTf.position;

        float distance = Vector2.Distance(center, objPos);


        bool isInside = distance <= radius;
        Handles.color = isInside ? Color.green : Color.red;
        
        //DrawWireDisc(Vector3 center, Vector3 normal, float radius)
        // normal vector specifies what orientation that disc should have
        Handles.DrawWireDisc(center, Vector3.forward, radius);
    }
    #endif
}
