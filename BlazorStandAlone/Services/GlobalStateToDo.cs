using System.Collections.Generic;

namespace BlazorStandAlone.Services
{
    public class GlobalStateToDo
    {
        public List<string?> toDoList { get; set; } = new();

        //public event Action? OnChange;

        public void AddToList(string? item)
        {
            toDoList.Add(item);
        }

        public void Remove(string? item)
        {
            toDoList.Remove(item);
        }

        //public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
