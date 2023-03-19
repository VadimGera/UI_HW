using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ButtonScript
{
    public class ButtonDown : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private string sceneName;
        [SerializeField] private GameObject loadingScreen;
        [SerializeField] private TextMeshProUGUI _progressPercent;
    
        public void OnPointerDown(PointerEventData eventData)
        {
            loadingScreen.SetActive(true);
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}
