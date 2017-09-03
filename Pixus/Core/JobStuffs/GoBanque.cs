﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pixus.Core.JobStuffs
{
    class GoBanque
    {
        //=========================================================================================================================
        //                                                      attributs
        //=========================================================================================================================
        public static GoBanque Empty = new GoBanque();

        //=========================================================================================================================
        //                                                      propriétés
        //=========================================================================================================================
        public bool Enabled { get; set; }
        public Trajet Trajet { get; set; }

        //=========================================================================================================================
        //                                                      constr.
        //=========================================================================================================================
        public GoBanque()
        {
            this.Enabled = false;
        }
    }
}