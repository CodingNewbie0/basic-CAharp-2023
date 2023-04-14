using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf13_bookrentalshop.Helpers
{
    internal class Commons
    {
        // 모든 프로그램상에서 다 사용가능
        // DB 정보 불러와서 네임스페이스로 만들기
        public static readonly string ConString = "Server=localhost;"+
                                                   "Port=3306;"+
                                                   "Database=bookrentalshop;"+
                                                   "Uid=root;"+
                                                   "Pwd=12345";

    }
}
