﻿using System;
using System.Threading.Tasks;
using ProductivityTools.GetTask3.Contract;
using ProductivityTools.GetTask3.CoreObjects;

namespace ProductivityTools.GetTask3.Domain
{
    public interface ITaskRepositoryCmd
    {
        void Add(string Name, int? parentId, bool finished, ElementType type);
        void AddToTomato(int[] elementIds);
        void Delay(int elementId, DateTime date);
        void Delete(int elementId);
        void Finish(int elementId);
        void Start(int elementId);
        void Move(int[] elementsIds, int target);
        Task<ElementView> GetStructure(int? currentNode, string path);
        int? GetRoot(int? currentNode, string path);
        void Undone(int elementId);
    }
}