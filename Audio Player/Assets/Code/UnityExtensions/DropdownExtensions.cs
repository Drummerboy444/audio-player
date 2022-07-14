using UnityEngine.UI;

public static class DropdownExtensions
{
    public static string GetValue(this Dropdown dropdown) => dropdown.options[dropdown.value].text;
}
