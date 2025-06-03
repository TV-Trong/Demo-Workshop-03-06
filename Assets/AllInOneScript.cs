using UnityEngine;

public class AllInOneScript : MonoBehaviour
{
    public int SomeNumber {  get; private set; }

    public void SomeMethod() { }

    private void Start()
    {
         SomeNumber = 1;
    }
}
