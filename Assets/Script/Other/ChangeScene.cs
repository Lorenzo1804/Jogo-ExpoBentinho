using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ChangeScene : MonoBehaviour
{
		public void Next(string sceneName)
		{
				SceneManager.LoadScene(sceneName);
		}

		public void Quit()
		{
#if UNITY_EDITOR
				EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
		}
}