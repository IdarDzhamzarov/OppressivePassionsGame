using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private float zoomSpeed = 5f;
    [SerializeField] private float minZoomDistance = 1f;
    [SerializeField] private float maxZoomDistance = 25f;

    [SerializeField] private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if(scroll != 0)
        {
            float currentZoomDistance = cam.orthographicSize;
            currentZoomDistance -= scroll * zoomSpeed * Time.deltaTime;
            currentZoomDistance = Mathf.Clamp(currentZoomDistance, minZoomDistance, maxZoomDistance);

            cam.orthographicSize = currentZoomDistance;
        }
       
    }
}
