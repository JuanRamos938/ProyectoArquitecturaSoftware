using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ECOAPP.Core.Common.Enums
{
    public static class EnumExtension
    {
        /// <summary>
        /// Get display info 
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetDisplayInfo(this Enum enumeration)
        {
            Type type = enumeration.GetType();
            Dictionary<string, string> displayInfo = new Dictionary<string, string>();
            MemberInfo[] member = type.GetMember(enumeration.ToString());
            DisplayAttribute displayAttribute = member[0].GetCustomAttribute<DisplayAttribute>();
            if (displayAttribute != null)
            {
                displayInfo.Add("name", displayAttribute.Name);
                displayInfo.Add("description", displayAttribute.Description);
            }
            return displayInfo;
        }

        /// <summary>
        /// Get display name
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static string GetName(this Enum enumeration)
        {
            Type type = enumeration.GetType();
            MemberInfo[] member = type.GetMember(enumeration.ToString());
            DisplayAttribute displayAttribute = member[0].GetCustomAttribute<DisplayAttribute>();
            if (displayAttribute != null)
            {
                return displayAttribute.Name;
            }
            return null;
        }


        /// <summary>
        /// Check for valid name
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsValidName(this Type type, string name)
        {
            foreach (string enumName in type.GetEnumNames())
            {
                MemberInfo[] member = type.GetMember(enumName);
                DisplayAttribute displayAttribute = member[0].GetCustomAttribute<DisplayAttribute>();
                if (displayAttribute != null && displayAttribute.Name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Get display name
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum enumeration)
        {
            Type type = enumeration.GetType();
            MemberInfo[] member = type.GetMember(enumeration.ToString());
            DisplayAttribute displayAttribute = member[0].GetCustomAttribute<DisplayAttribute>();
            if (displayAttribute != null)
            {
                return displayAttribute.Description;
            }
            return null;
        }
    }
}
