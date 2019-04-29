﻿using Platform.Helpers;

namespace Platform.Data.Core.Doublets
{
    public class DefaultSequenceElementCreteriaMatcher<TLink> : LinksOperatorBase<TLink>, ICreteriaMatcher<TLink>
    {
        public DefaultSequenceElementCreteriaMatcher(ILinks<TLink> links) : base(links)
        {
        }

        public bool IsMatched(TLink argument) => Links.IsPartialPoint(argument);
    }
}