using UnityEditor;

namespace FeatherConstruct.Utils
{

    public static class PropertyUtils
    {

        /// <summary>
        /// Gets property value as object.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static object GetPropertyValue(SerializedProperty property)
        {
            switch (property.propertyType)
            {
                case SerializedPropertyType.Boolean: return property.boolValue;
                case SerializedPropertyType.Color: return property.colorValue;
                case SerializedPropertyType.Float: return property.floatValue;
                case SerializedPropertyType.Integer: return property.intValue;
                case SerializedPropertyType.String: return property.stringValue;
                default: return "Field type is not supported.";
            }
        }

    }

}