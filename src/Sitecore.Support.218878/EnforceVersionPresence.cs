using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Globalization;

namespace Sitecore.Support.Pipelines.ItemProvider.GetItem
{
  public class EnforceVersionPresence: Sitecore.Pipelines.ItemProvider.GetItem.EnforceVersionPresence
  {
    protected override bool IsItemEnforceVersionPresenceEnabled(Item item)
    {
      if (item != null&&item.Language == Language.Invariant)
      {
        return false;
      }

      return base.IsItemEnforceVersionPresenceEnabled(item);
    }
  }
}