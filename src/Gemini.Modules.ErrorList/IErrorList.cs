﻿using Caliburn.Micro;
using Gemini.Framework;

namespace Gemini.Modules.ErrorList
{
    public interface IErrorList : ITool
    {
        IObservableCollection<ErrorListItem> Items { get; }
        void AddItem(ErrorListItemType itemType, string description,
            string path = null, int? line = null, int? column = null,
            System.Action onClick = null);
    }
}