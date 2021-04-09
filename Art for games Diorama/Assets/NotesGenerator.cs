using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Note", menuName = "Not so sticky note", order = 0)]
    public class NotesGenerator : ScriptableObject
    {
        public string title;
        [TextArea]
        public string content;
        public string[] todolist;
    }
}