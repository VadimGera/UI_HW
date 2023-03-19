using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace ButtonScript
{
    public class ButtonDown : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private string sceneName;
        [SerializeField] private GameObject loadingScreen;
    
        public void OnPointerDown(PointerEventData eventData)
        {
            loadingScreen.SetActive(true);
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}
