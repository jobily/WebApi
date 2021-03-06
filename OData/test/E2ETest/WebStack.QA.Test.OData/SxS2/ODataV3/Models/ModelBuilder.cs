﻿using System.Web.Http.OData.Builder;
using Microsoft.Data.Edm;

namespace WebStack.QA.Test.OData.SxS2.ODataV3.Models
{
    public static class ModelBuilder
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            return builder.GetEdmModel();
        }
    }
}