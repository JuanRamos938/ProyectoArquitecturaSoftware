using System.Collections.Generic;
using System.Linq;

namespace ECOAPP.Core.Common
{
    public class Validator
    {
        public Dictionary<string, List<string>> Errors { get; } = new Dictionary<string, List<string>>();

        public void AddError(string field, string message)
        {
            if (Errors.TryGetValue(field, out List<string> messages))
            {
                messages.Add(message);
            }
            else
            {
                Errors.Add(field, new List<string>
                {
                    message
                });
            }
        }


        public bool IsValid()
        {
            return !Errors.Keys.Any();
        }

    }
}
