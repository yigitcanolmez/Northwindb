using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Business.Abstract;
using DataAccess.Abstract;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As <IProductDal>();
        }
    }
}
