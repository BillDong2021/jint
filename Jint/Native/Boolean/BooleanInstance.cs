﻿using Jint.Native.Object;
using Jint.Runtime;

namespace Jint.Native.Boolean
{
    public class BooleanInstance : ObjectInstance, IPrimitiveInstance
    {
        public BooleanInstance(Engine engine)
            : base(engine, ObjectClass.Boolean)
        {
        }
        
        public BooleanInstance(Engine engine, JsBoolean value)
            : base(engine, ObjectClass.Boolean)
        {
            PrimitiveValue = value;
        }

        Types IPrimitiveInstance.Type => Types.Boolean;

        JsValue IPrimitiveInstance.PrimitiveValue => PrimitiveValue;

        public JsValue PrimitiveValue { get; set; }
    }
}