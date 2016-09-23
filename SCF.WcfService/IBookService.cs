﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SCF.WcfService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IBookService”。
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        string GetBook(string Id);
        [OperationContract]
        string AddBook(string book);
        [OperationContract]
        string EditBook(string book);
        [OperationContract]
        string Search(string Category, string searchString);
    }
}
