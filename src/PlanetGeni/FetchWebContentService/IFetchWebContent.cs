﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTO.Custom;
using PlanetGeni.ContentProviders.Core;
namespace FetchWebContent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFetchWebContent
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped
            , UriTemplate = "GetUrlContent?urls={urls}"  //make it Bare

             )]
        List<ContentProviderResult> GetUrlContent(string urls);
    }




}
