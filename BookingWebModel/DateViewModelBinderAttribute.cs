﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Ploeh.Samples.Booking.WebModel
{
    public class DateViewModelBinderAttribute : CustomModelBinderAttribute
    {
        public override IModelBinder GetBinder()
        {
            return new DateViewModelBinder();
        }
    }
}
