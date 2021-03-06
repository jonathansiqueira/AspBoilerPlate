﻿using Abp.Web.Mvc.Views;

namespace AspBoilerPlate.MyProject.Web.Views
{
    public abstract class MyProjectWebViewPageBase : MyProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class MyProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyProjectWebViewPageBase()
        {
            LocalizationSourceName = MyProjectConsts.LocalizationSourceName;
        }
    }
}