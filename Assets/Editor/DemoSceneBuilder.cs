using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class DemoSceneBuilder
{
    [MenuItem("Tools/Build Demo Scene")]
    public static void BuildScene()
    {
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        var setup = new GameObject("EnvironmentSetup");
        setup.AddComponent<DemoEnvironmentSetup>();
        EditorSceneManager.SaveScene(scene, "Assets/Scenes/Main.unity");
        Debug.Log("Demo scene created at Assets/Scenes/Main.unity");
    }
}
