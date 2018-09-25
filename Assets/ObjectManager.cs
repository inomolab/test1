using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ObjectManager : MonoBehaviour, IInputClickHandler
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public int n = 0;

    private void Start()
    {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        var obj = obj1;
        var pos = Camera.main.transform.position;
        var forword = Camera.main.transform.forward;

        if (n%3 == 0)
        {
            obj = obj1;
            n += 1;
            Instantiate(obj, pos + forword, new Quaternion());
            
        }
        else if (n%3 == 1)
        {
            obj = obj2;
            n += 1;
            Instantiate(obj, pos + forword, new Quaternion());
            
        }
         else
        {
            obj = obj3;
            n += 1;
            Instantiate(obj, pos + forword, new Quaternion());
            
        }
        
    }
}