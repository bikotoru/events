﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WuaBleRs04.Annotations;
using WuaBleRs04.Model;

namespace WuaBleRs04.Drone
{
    public class ParrotBase : INotifyPropertyChanged
    {
        public ParrotBase()
        {
            _logActions = new List<LogAction>();
        }

        public void AddLogAction(string action)
        {
            LogActions.Add(new LogAction { ActionData = action });
        }

        private List<LogAction> _logActions;

        public List<LogAction> LogActions
        {
            get { return _logActions; }
            set
            {
                if (Equals(value, _logActions)) return;
                _logActions = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
