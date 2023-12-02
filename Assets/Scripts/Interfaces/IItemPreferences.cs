using DungeonAndDemons.ScriptableObjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DungeonAndDemons.Interfaces
{
    public interface IItemPreferences
    {
        public string Name { get; }
        public ItemModel Model { get; }
    }
}