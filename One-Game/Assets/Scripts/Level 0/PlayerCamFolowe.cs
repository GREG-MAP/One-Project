using UnityEngine;

public class PlayerCamFolowe : MonoBehaviour
{
    [SerializeField] private Transform followTransform;
    private void FixedUpdate()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, -10);

    }
}
