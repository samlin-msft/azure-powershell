// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.PowerShell;

    /// <summary>The properties of a configuration.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConfigurationPropertiesAutoGeneratedTypeConverter))]
    public partial class ConfigurationPropertiesAutoGenerated
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ConfigurationPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConfigurationPropertiesAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Value, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).DefaultValue, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).DataType = (string) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).DataType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).AllowedValue = (string) content.GetValueForProperty("AllowedValue",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).AllowedValue, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource?) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsReadOnly = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly?) content.GetValueForProperty("IsReadOnly",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsReadOnly, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsConfigPendingRestart = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart?) content.GetValueForProperty("IsConfigPendingRestart",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsConfigPendingRestart, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsDynamicConfig = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig?) content.GetValueForProperty("IsDynamicConfig",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsDynamicConfig, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ConfigurationPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConfigurationPropertiesAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Value, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).DefaultValue, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).DataType = (string) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).DataType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).AllowedValue = (string) content.GetValueForProperty("AllowedValue",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).AllowedValue, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource?) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.ConfigurationSource.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsReadOnly = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly?) content.GetValueForProperty("IsReadOnly",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsReadOnly, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsReadOnly.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsConfigPendingRestart = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart?) content.GetValueForProperty("IsConfigPendingRestart",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsConfigPendingRestart, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsConfigPendingRestart.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsDynamicConfig = (Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig?) content.GetValueForProperty("IsDynamicConfig",((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGeneratedInternal)this).IsDynamicConfig, Microsoft.Azure.PowerShell.Cmdlets.MySql.Support.IsDynamicConfig.CreateFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ConfigurationPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConfigurationPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.ConfigurationPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConfigurationPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConfigurationPropertiesAutoGenerated" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IConfigurationPropertiesAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties of a configuration.
    [System.ComponentModel.TypeConverter(typeof(ConfigurationPropertiesAutoGeneratedTypeConverter))]
    public partial interface IConfigurationPropertiesAutoGenerated

    {

    }
}