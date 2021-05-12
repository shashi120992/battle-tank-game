using UnityEngine;

public class SingletonClass<T> : MonoBehaviour where T:MonoBehaviour
{
    static T instance;
    static object m_lock = new object();
    public static T Getinstnce()
    {
        lock(m_lock)
        { 
            if(instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    GameObject Obj = new GameObject();
                    Obj.name = typeof(T).ToString();
                    instance = Obj.AddComponent<T>();
                    DontDestroyOnLoad(Obj);
                }       
            }
        }
        return instance;
    }
}