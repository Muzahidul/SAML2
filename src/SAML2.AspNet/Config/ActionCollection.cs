﻿using System.Configuration;

namespace SAML2.AspNet.Config
{
    /// <summary>
    /// Action configuration collection.
    /// </summary>
    [ConfigurationCollection(typeof(ActionElement), AddItemName = "action", CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    public class ActionCollection : EnumerableConfigurationElementCollection<ActionElement>
    {
    }
}
