﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acacia.Utils
{
    public class DisposableTracerDummy : DisposableTracer
    {
        public void Created(DisposableWrapper wrapper)
        {
        }

        public void Deleted(DisposableWrapper wrapper, bool wasDisposed)
        {
        }

        public void Disposed(DisposableWrapper wrapper)
        {
        }
    }
}
