using UnityEngine;

public class ScriptSwitcher : MonoBehaviour
{
    // References to the scripts you want to switch between
    public MonoBehaviour scriptA;
    public MonoBehaviour scriptB;
    public MonoBehaviour scriptC;
    public MonoBehaviour scriptD;

    // Array to hold the scripts
    private MonoBehaviour[] scripts;

    // Index of the currently active script
    private int currentIndex = 0;

    void Start()
    {
        // Populate the scripts array
        scripts = new MonoBehaviour[] { scriptA, scriptB, scriptC, scriptD };

        // Ensure only the first script is active initially
        ActivateScript(currentIndex);
    }

    void Update()
    {
        // Listen for key presses and switch scripts accordingly
        if (Input.GetKeyDown(KeyCode.X))
        {
            SwitchToScript(0);  // Switch to scriptA
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchToScript(1);  // Switch to scriptB
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchToScript(2);  // Switch to scriptC
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            SwitchToScript(3);  // Switch to scriptD
        }
    }

    void SwitchToScript(int index)
    {
        if (index >= 0 && index < scripts.Length)
        {
            currentIndex = index;
            ActivateScript(currentIndex);
        }
    }

    void ActivateScript(int index)
    {
        // Disable all scripts
        foreach (var script in scripts)
        {
            if (script != null)
            {
                script.enabled = false;
            }
        }

        // Enable the selected script
        if (scripts[index] != null)
        {
            scripts[index].enabled = true;
            Debug.Log($"Activated: {scripts[index].GetType().Name}");
        }
        else
        {
            Debug.LogWarning($"Script at index {index} is not assigned.");
        }
    }
}

