﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using Foundation.Cms.Settings;
using Foundation.Find.Facets;
using Foundation.Find.Facets.Config;
using Foundation.Infrastructure;

namespace Foundation.Features.Settings
{
    [SettingsContentType(DisplayName = "SearchSettings",
        GUID = "d4171337-70a4-476a-aa3c-0d976ac185e8",
        SettingsName = "Search Settings")]
    public class SearchSettings : SettingsBase
    {
        [CultureSpecific]
        [SelectOne(SelectionFactoryType = typeof(SearchOptionSelectionFactory))]
        [Display(Name = "Search option", GroupName = TabNames.SearchSettings, Order = 50)]
        public virtual string SearchOption { get; set; }
    }

    public class SearchOptionSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[]
            {
                new SelectItem { Text = "Quick search", Value = "QuickSearch" },
                new SelectItem { Text = "Auto search", Value = "AutoSearch" }
            };
        }
    }
}