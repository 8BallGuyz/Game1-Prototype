using UnityEngine;

public class ScriptSwitcher : MonoBehaviour
{
    // References to the scripts you want to switch between
    public MonoBehaviour AR;
    public MonoBehaviour Sniper;
    public KeyCode KeyBindAR;
    public KeyCode KeyBindSniper;

    public Sprite ARsprite;
    public Sprite Snipersprite;

    // Array to hold the scripts
    private MonoBehaviour[] scripts;

    // Index of the currently active script
    private int currentIndex = 0;

    void Start()
    {
        // Populate the scripts array
        scripts = new MonoBehaviour[] { AR, Sniper };

        // Ensure only the first script is active initially
        ActivateScript(currentIndex);
    }

    void Update()
    {
        // Listen for key presses and switch scripts accordingly
        if (Input.GetKeyDown(KeyBindAR))
        {
            SwitchToScript(0);  // Switch to scriptA
            GetComponent<SpriteRenderer>().sprite = ARsprite;
        }
        else if (Input.GetKeyDown(KeyBindSniper))
        {
            SwitchToScript(1);  // Switch to scriptB
            GetComponent<SpriteRenderer>().sprite = Snipersprite;
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

