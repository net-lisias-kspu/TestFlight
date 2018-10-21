﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using TestFlightAPI;

namespace TestFlight
{
    public class TestFlightFailureBase_Generic : TestFlightFailureBase
    {
        protected string modName = "";
        protected PartModule module;
        public override void OnStart(PartModule.StartState state)
        {
            base.OnStart(state);
            this.module = base.part.Modules[this.modName];
        }
        public void SetValue(string fieldName, object value)
        {
            if (this.module != null)
            {
                FieldInfo field = this.module.GetType().GetField(fieldName);
                if (field != null)
                {
                    field.SetValue(module, value);
                }
            }
        }
    }
}
