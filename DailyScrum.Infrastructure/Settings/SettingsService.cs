using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Infrastructure.Settings
{

    public enum SettingKeys 
    { 
        CurrentProjectId,
        CurrentSprintId
    }

    public interface ISettingsService
    {
        void SetValue(SettingKeys key, string value);
        string GetValue(SettingKeys key);
    }

    public sealed class SettingsService : ISettingsService
    {
        public SettingsService()
        {
              // SetValue(SettingKeys.CurrentProjectId,_)
        }


        private readonly Dictionary<string, string> _applicationSettigns = new Dictionary<string, string>();

        public string GetValue(SettingKeys key)
            => _applicationSettigns[key.ToString()];

        public void SetValue(SettingKeys key, string value)
            => _applicationSettigns[key.ToString()] = value;
    }
}
