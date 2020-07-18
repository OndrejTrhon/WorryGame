using UnityEngine;
using System.Collections;


namespace TMPro.Examples
{
    
    public class CameraController : MonoBehaviour
    {


        public Transform CameraTarget;
        private float offsetY;
        public float ManualOffset;
        // Use this for initialization
        void Start()
        {
            if (CameraTarget == null)
            {
                Debug.LogError("not target!!");
            }
            offsetY = transform.position.y - CameraTarget.position.y + ManualOffset;
        }


        private void Update()
        {
            transform.position = new Vector3(transform.position.x, CameraTarget.position.y + offsetY, transform.position.z);
        }
    }
}