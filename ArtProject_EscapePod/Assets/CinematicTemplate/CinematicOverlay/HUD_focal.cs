using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class HUD_focal : MonoBehaviour
{
    [Tooltip("Target camera to retrieve physical data from.")]
    public Camera HDRPCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera targetCamera;

        if (HDRPCamera == null)
            targetCamera = Camera.main;
        else
            targetCamera = HDRPCamera;

        if (targetCamera == null)
            return;

        var camInfo1 = targetCamera;
        var text = gameObject.GetComponent<Text>();

        if (camInfo1 != null && text != null)
        {
            float f = camInfo1.focalLength;
            float n = camInfo1.aperture;

            text.text = "";
            text.text += f.ToString("0.00");
            text.text += " mm - f/";
            text.text += n.ToString("0.00");
        }
    }
}
