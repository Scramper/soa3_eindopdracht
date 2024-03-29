﻿using ProjectManagementSystem.Core.Domain.Interfaces;

namespace ProjectManagementSystem.Core.Domain.Models
{
    public class BacklogItemStateObserver : IBacklogItemStateObserver
    {
        public void Update(IBacklogItemState newState)
        {
            // Respond to the state change, e.g., refresh UI, recalculate something, etc.
        }
    }
}
