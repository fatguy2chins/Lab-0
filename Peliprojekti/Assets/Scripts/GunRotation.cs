using UnityEngine;
using System.Collections;

public class GunRotation : MonoBehaviour
{

    void Start()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
    }

    void FixedUpdate()
    {


        Vector3 position = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 direction = Input.mousePosition - position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion newrot = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = transform.rotation = Quaternion.Slerp(transform.rotation, newrot, .35f);
        gameObject.transform.localPosition = new Vector3(0, 0, 0);
    }

}
