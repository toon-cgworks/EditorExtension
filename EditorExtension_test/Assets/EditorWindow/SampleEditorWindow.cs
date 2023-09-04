using UnityEngine;
using UnityEditor;

public class SampleEditorWindow : EditorWindow
{

    [MenuItem("EditorExtension_test/SampleWindow")]
    private static void ShowWindow()
    {
        var window = GetWindow<SampleEditorWindow>();
        window.titleContent = new GUIContent("SampleWindow");
        window.Show();
    }

    private void OnGUI()
    {
        
    }
}