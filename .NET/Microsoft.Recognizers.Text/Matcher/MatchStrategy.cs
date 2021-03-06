﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Recognizers.Text.Matcher
{
    public enum MatchStrategy
    {
        /// <summary>
        /// AcAtomaton
        /// </summary>
        AcAutomaton,

        /// <summary>
        /// TrieTree
        /// </summary>
        TrieTree,
    }
}