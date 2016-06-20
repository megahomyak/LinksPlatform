﻿using System;
using Platform.Data.Core.Pairs;
using Platform.Helpers;

namespace Platform.Data.Core.Sequences
{
    public struct SequencesOptions // TODO: To use type parameter <TLink> the ILinks<TLink> must contain GetConstants function.
    {
        private static readonly LinksConstants<bool, ulong, long> Constants = Default<LinksConstants<bool, ulong, long>>.Instance;

        public ulong SequenceMarkerLink;
        public bool UseCascadeUpdate;
        public bool UseCascadeDelete;
        public bool UseIndex; // TODO: Update Index on sequence update/delete.
        public bool UseSequenceMarker;
        public bool UseCompression;
        public bool UseGarbageCollection;
        public bool EnforceSingleSequenceVersionOnWrite;
        // TODO: Реализовать компактификацию при чтении
        //public bool EnforceSingleSequenceVersionOnRead; 
        //public bool UseRequestMarker;
        //public bool StoreRequestResults;

        public void InitOptions(ILinks<ulong> links)
        {
            if (UseSequenceMarker && SequenceMarkerLink == Constants.Null)
                SequenceMarkerLink = links.CreatePoint();
        }

        public void ValidateOptions()
        {
            if (UseGarbageCollection && !UseSequenceMarker)
                throw new NotSupportedException("To use garbage collection UseSequenceMarker option must be on.");
        }
    }
}
