using UnityEngine;

namespace DefaultNamespace
{
    public class CircleManager : MonoBehaviour
    {
        public GameObject circle, otherCircle;
        [Range(0, 360)] public float degree;
        [Range(0, 359)] public float otherDegree;
        [Range(2,10)] public float radius;

        private void Update()
        {
            var x = radius * Mathf.Cos(degree *  Mathf.Deg2Rad);
            var y = radius * Mathf.Sin(degree * Mathf.Deg2Rad);
            var otherX = radius * Mathf.Cos((degree + otherDegree) * Mathf.Deg2Rad);
            var otherY = radius * Mathf.Sin((degree + otherDegree) * Mathf.Deg2Rad);
            circle.transform.position = new Vector3(x, y, 0f);
            otherCircle.transform.position = new Vector3(otherX, otherY, 0f);
        }
    }
}