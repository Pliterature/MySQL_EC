﻿
using System.Collections.Generic;

namespace MySQL_EC
{
    ///<summary>
    ///interface<c>IDAO_Update</c>
    ///用来对数据库进行更新相关操作
    ///</summary> 
    interface IDAO_Update
    {
        int Update(string table_name, List<SQLRequirement> Set_list, List<SQLRequirement> Requirement_list);
    }
}
