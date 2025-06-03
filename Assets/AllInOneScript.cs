using UnityEngine;

public class AllInOneScript : MonoBehaviour
{
    public int SomeNumber_Changed {  get; private set; }

    public float MoreNumber;

    public string SomeString;

    public void SomeMethod() { }

    private void Awake()
    {
        SomeMethod();
    }
    private void Start()
    {
         SomeNumber = 1;
    }
}
