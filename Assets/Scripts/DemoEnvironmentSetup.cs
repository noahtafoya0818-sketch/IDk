using UnityEngine;

public class DemoEnvironmentSetup : MonoBehaviour
{
    void Start()
    {
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Ground";
        ground.transform.localScale = new Vector3(4, 1, 4);

        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        player.name = "Player";
        player.transform.position = new Vector3(0f, 1f, 0f);
        player.AddComponent<SimplePlayerController>();

        Camera cam = player.AddComponent<Camera>();
        cam.nearClipPlane = 0.1f;
        cam.fieldOfView = 60f;

        GameObject follow = new GameObject("CameraPivot");
        follow.transform.SetParent(player.transform);
        follow.transform.localPosition = new Vector3(0f, 0.75f, 0f);
        cam.transform.SetParent(follow.transform);
        cam.transform.localPosition = new Vector3(0f, 0.35f, -0.2f);
        cam.transform.localRotation = Quaternion.identity;

        GameObject flower = GameObject.CreatePrimitive(PrimitiveType.Cube);
        flower.name = "Flower";
        flower.transform.position = new Vector3(3f, 0.3f, 2f);
        flower.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        GameObject tree = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tree.name = "Tree";
        tree.transform.position = new Vector3(-3f, 1.2f, -2f);
        tree.transform.localScale = new Vector3(0.7f, 1.2f, 0.7f);

        GameObject sky = new GameObject("Sky");
        RenderSettings.skybox = new Material(Shader.Find("Skybox/Procedural"));
        sky.transform.position = Vector3.zero;
    }
}
